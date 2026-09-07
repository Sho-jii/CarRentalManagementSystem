using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagementSystem._Pages;
using CarRentalManagementSystem._Models;

namespace CarRentalManagementSystem._Forms
{
    public partial class Frm_IssueWizard : Form
    {
        Vehicle classVehicle = new Vehicle();
        Client classClient = new Client();
        public int selectedClientID { get; set; }
        public string selectedClientName { get; set; }
        public int selectedVehicleID { get; set; }
        public string selectedModel { get; set; }
        public decimal selectedDailyHirePrice { get; set; }
        public string selectedCondition { get; set; }
        public Frm_IssueWizard()
        {
            InitializeComponent();
            LoadClientsForIssue();
            LoadAvailableVehicles();
        }
        private void LoadClientsForIssue()
        {
            string sql = "SELECT * FROM clientProfiles";
            using (Database db = new Database())
            {
                dgvClient.DataSource = db.Select(sql);
            }
        }
        private void LoadAvailableVehicles()
        {
            // Only load vehicles that are Available and not damaged/in bad condition
            string sql = @"SELECT * FROM vehicleInventory 
                           WHERE Status = 'Available' 
                             AND Condition NOT IN ('Damaged', 'VeryBad', 'Very Bad', 'Bad', 'Needs Repair')";
            using (Database db = new Database())
            {
                dgvVehicles.DataSource = db.Select(sql);
            }
            FormatGridView();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (selectedClientID == 0)
            {
                MessageBox.Show("Please select a client!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            issueVehicles.Visible = true;
            issueVehicles.BringToFront();
        }
        private void btnBack_Click_1(object sender, EventArgs e)
        {
            clientInfo.BringToFront();
            issueVehicles.Visible = false;
        }
        private void Frm_IssueWizard_Load(object sender, EventArgs e)
        {
            
        }
        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (selectedClientID == 0 || selectedVehicleID == 0)
            {
                MessageBox.Show("Please select the vehicle!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extra safety guard: verify vehicle condition is not damaged
            if (selectedCondition == "Damaged" || selectedCondition == "VeryBad" || selectedCondition == "Very Bad" || selectedCondition == "Bad")
            {
                MessageBox.Show("This vehicle cannot be rented because it is damaged or in poor condition.", "Rental Blocked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Frm_Issue rentForm = new Frm_Issue(selectedClientID, selectedVehicleID, selectedModel, selectedClientName, selectedDailyHirePrice, selectedCondition);
            if (rentForm.ShowDialog() == DialogResult.OK)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void Frm_IssueWizard_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                selectedVehicleID = Convert.ToInt32(dgvVehicles.Rows[e.RowIndex].Cells[0].Value);
                selectedModel = dgvVehicles.Rows[e.RowIndex].Cells[1].Value.ToString();
                selectedDailyHirePrice = Convert.ToDecimal(dgvVehicles.Rows[e.RowIndex].Cells[9].Value);
                selectedCondition = dgvVehicles.Rows[e.RowIndex].Cells[10].Value.ToString();
            }
        }
        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Store selected client data
                selectedClientID = Convert.ToInt32(dgvClient.Rows[e.RowIndex].Cells[0].Value);
                selectedClientName = dgvClient.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
        private void dgvVehicles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3 && e.Value != null)
            {             
                e.CellStyle.ForeColor = System.Drawing.Color.SeaGreen;              
            }
        }
        private void FormatGridView()
        {
            dgvVehicles.Columns[9].DefaultCellStyle.Format = "C2";
            dgvVehicles.Columns[9].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
        }
        private void LoadVehiclesByTransmissionAvail(string transmission, string searchText)
        {
            DataTable filteredData = classVehicle.LoadVehiclesByTransmissionAvail(transmission, searchText);
            dgvVehicles.DataSource = filteredData;
            FormatGridView();
        }
        private void LoadVehiclesBySearchAvail(string searchTexts)
        {
            DataTable filteredData = classVehicle.LoadVehiclesBySearchAvail(searchTexts);
            dgvVehicles.DataSource = filteredData;
            FormatGridView();
        }
        private void LoadFilteredClients(string searchText, string gender)
        {
            try
            {
                DataTable filteredData = classClient.LoadClientsByNameAndGender(searchText, gender);
                dgvClient.DataSource = filteredData;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading filtered clients: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearchVehicle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearchVehicle.Text.Trim();
                string selectedTransmission = cmbTransmission.SelectedItem.ToString();
                if (selectedTransmission == "Transmission (All)" || string.IsNullOrEmpty(selectedTransmission))
                {
                    LoadVehiclesBySearchAvail(searchText);
                }
                else
                {
                    LoadVehiclesByTransmissionAvail(selectedTransmission, searchText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbTransmission_SelectedIndexChanged(object sender, EventArgs e)
        {
             try
            {
                string selectedTransmission = cmbTransmission.SelectedItem.ToString();
                string searchText = txtSearchVehicle.Text.Trim();
                if (selectedTransmission == "Transmission (All)" || string.IsNullOrEmpty(selectedTransmission))
                {
                    LoadVehiclesBySearchAvail(searchText);
                }
                else
                {
                    LoadVehiclesByTransmissionAvail(selectedTransmission, searchText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string gender = cmbGender.SelectedItem?.ToString() ?? "Gender (All)";
                string searchText = txtSearch.Text.Trim();

                LoadFilteredClients(searchText, gender);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering clients by gender: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string gender = cmbGender.SelectedItem?.ToString() ?? "Gender (All)";
                string searchText = txtSearch.Text.Trim();

                LoadFilteredClients(searchText, gender);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering clients by name: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRefreshClient_Click(object sender, EventArgs e)
        {
            LoadClientsForIssue();
            LoadAvailableVehicles();
            cmbGender.SelectedIndex = 0;
        }
        private void btnRefreshV_Click(object sender, EventArgs e)
        {
            LoadClientsForIssue();
            LoadAvailableVehicles();
            cmbTransmission.SelectedIndex = 0;
        }
        private void issueVehicles_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
