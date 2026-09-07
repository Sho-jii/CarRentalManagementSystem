using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagementSystem._Forms;
using CarRentalManagementSystem._Models;
using ServiceStack.OrmLite.Dapper;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRentalManagementSystem._Pages
{
    public partial class Page_Vehicle : UserControl
    {
        Vehicle classVehicle = new Vehicle();
        public Page_Vehicle()
        {
            InitializeComponent();
            loadVehicles();
        }
        private void loadVehicles()
        {
            try
            {
                string sql = "SELECT * FROM vehicleInventory";
                using (var db = new Database())
                {
                    dgvVehicles.DataSource = db.Select(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            FormatGridView();
        }
        private void LoadVehiclesByTransmission(string transmission, string searchText)
        {
            DataTable filteredData = classVehicle.LoadVehiclesByTransmission(transmission, searchText);
            dgvVehicles.DataSource = filteredData;
            FormatGridView();
        }
        private void LoadVehiclesBySearch(string searchTexts)
        {
            DataTable filteredData = classVehicle.LoadVehiclesBySearch(searchTexts);
            dgvVehicles.DataSource = filteredData;
            FormatGridView();
        }
        private void FormatGridView()
        {
            dgvVehicles.Columns[9].DefaultCellStyle.Format = "C2";
            dgvVehicles.Columns[9].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
        }

        private void Page_Vehicle_Load(object sender, EventArgs e)
        {
            dgvVehicles.Columns["Edit"].DefaultCellStyle.NullValue = "🖊";
            dgvVehicles.Columns["Delete"].DefaultCellStyle.NullValue = "❌";
        }

        private void dgvVehicles_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvVehicles.Columns[e.ColumnIndex].Name == "Edit")
            {
                e.CellStyle.ForeColor = Color.FromArgb(27, 113, 187);
                e.CellStyle.SelectionForeColor = Color.FromArgb(27, 113, 187);
                e.CellStyle.SelectionBackColor = Color.WhiteSmoke;
            }
            else if (dgvVehicles.Columns[e.ColumnIndex].Name == "Delete")
            {
                e.CellStyle.ForeColor = Color.FromArgb(226, 72, 81);
                e.CellStyle.SelectionForeColor = Color.FromArgb(226, 72, 81);
                e.CellStyle.SelectionBackColor = Color.WhiteSmoke;
            }
            if (e.ColumnIndex == 3 && e.Value != null)
            {
                string status = e.Value.ToString();

                if (status == "Available")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.SeaGreen;
                }
                else if (status == "In-Possession")
                {
                    e.CellStyle.ForeColor = System.Drawing.Color.Crimson;
                }
            }
        }
        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string modelname = dgvVehicles.Rows[e.RowIndex].Cells[1].Value.ToString();
            string status = dgvVehicles.Rows[e.RowIndex].Cells[3].Value.ToString();
            if (e.ColumnIndex == dgvVehicles.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                if (status == "In-Possession")
                {
                    MessageBox.Show($"{modelname} cannot be edited as it is currently in possession.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int vehicleID = Convert.ToInt32(dgvVehicles.Rows[e.RowIndex].Cells[0].Value);
                string model = dgvVehicles.Rows[e.RowIndex].Cells[1].Value.ToString();
                string registration = dgvVehicles.Rows[e.RowIndex].Cells[2].Value.ToString();
                string getStatus = dgvVehicles.Rows[e.RowIndex].Cells[3].Value.ToString();
                int yom = Convert.ToInt32(dgvVehicles.Rows[e.RowIndex].Cells[4].Value);
                string color = dgvVehicles.Rows[e.RowIndex].Cells[5].Value.ToString();
                int capacity = Convert.ToInt32(dgvVehicles.Rows[e.RowIndex].Cells[6].Value);
                string fuelType = dgvVehicles.Rows[e.RowIndex].Cells[7].Value.ToString();
                string transmission = dgvVehicles.Rows[e.RowIndex].Cells[8].Value.ToString();
                decimal dailyPrice = Convert.ToDecimal(dgvVehicles.Rows[e.RowIndex].Cells[9].Value);
                string condition = dgvVehicles.Rows[e.RowIndex].Cells[10].Value.ToString();
                DateTime dateAdded = Convert.ToDateTime(dgvVehicles.Rows[e.RowIndex].Cells[11].Value);

                Frm_Vehicle editForm = new Frm_Vehicle(vehicleID, model, registration, getStatus, yom, color, capacity, fuelType, transmission, dailyPrice, condition, dateAdded);
                editForm.ShowDialog();
            }
            else if (e.ColumnIndex == dgvVehicles.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                if (status == "In-Possession")
                {
                    MessageBox.Show($"{modelname} cannot be deleted as it is currently in possession.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    int vehicleID = Convert.ToInt32(dgvVehicles.Rows[e.RowIndex].Cells[0].Value);
                    classVehicle.DeleteVehicle(modelname, vehicleID);
                }
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_Vehicle addVehicleForm = new Frm_Vehicle();
            addVehicleForm.ShowDialog();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadVehicles();
        }
        private void cmbTransmission_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedTransmission = cmbTransmission.SelectedItem.ToString();
                string searchText = txtSearch.Text.Trim();
                if (selectedTransmission == "Transmission (All)" || string.IsNullOrEmpty(selectedTransmission))
                {
                    LoadVehiclesBySearch(searchText);
                }
                else
                {
                    LoadVehiclesByTransmission(selectedTransmission, searchText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchText = txtSearch.Text.Trim();
                string selectedTransmission = cmbTransmission.SelectedItem.ToString();
                if (selectedTransmission == "Transmission (All)" || string.IsNullOrEmpty(selectedTransmission))
                {
                    LoadVehiclesBySearch(searchText);
                }
                else
                {
                    LoadVehiclesByTransmission(selectedTransmission, searchText);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
