using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CarRentalManagementSystem._Forms;
using CarRentalManagementSystem._Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace CarRentalManagementSystem._Pages
{
    public partial class Page_Client : UserControl
    {
        Client clientCLass = new Client();
        public Page_Client()
        {
            InitializeComponent();
            loadClients();
        }
        public void loadClients()
        {
            try
            {
                string sql = "SELECT * FROM clientProfiles";
                using (Database database = new Database())
                {
                    dgvClient.DataSource = database.Select(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadClientsBySearch(string searchQuery = "", string genderFilter = "Gender (All)")
        {
            try
            {
                // Pass empty string for gender filter when 'Gender (All)' is selected
                string effectiveGenderFilter = genderFilter == "Gender (All)" ? "" : genderFilter;
                dgvClient.DataSource = clientCLass.GetClients(searchQuery, effectiveGenderFilter);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading clients: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Page_Client_Load(object sender, EventArgs e)
        {
            dgvClient.Columns["Edit"].DefaultCellStyle.NullValue = "🖊";
            dgvClient.Columns["Delete"].DefaultCellStyle.NullValue = "❌";
        }

        private void dgvClient_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvClient.Columns[e.ColumnIndex].Name == "Edit")
            {
                e.CellStyle.ForeColor = Color.FromArgb(27, 113, 187);
                e.CellStyle.SelectionForeColor = Color.FromArgb(27, 113, 187);
                e.CellStyle.SelectionBackColor = Color.WhiteSmoke;
            }
            else if (dgvClient.Columns[e.ColumnIndex].Name == "Delete")
            {
                e.CellStyle.ForeColor = Color.FromArgb(226, 72, 81);
                e.CellStyle.SelectionForeColor = Color.FromArgb(226, 72, 81);
                e.CellStyle.SelectionBackColor = Color.WhiteSmoke;
            }
        }       
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_Client client = new Frm_Client();
            client.ShowDialog();
        }
        private void refreshTable_Tick(object sender, EventArgs e)
        {
            loadClients();
        }
        private void dgvClient_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvClient.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int clientId = Convert.ToInt32(dgvClient.Rows[e.RowIndex].Cells[0].Value);
                string name = dgvClient.Rows[e.RowIndex].Cells[1].Value.ToString();
                string gender = dgvClient.Rows[e.RowIndex].Cells[2].Value.ToString();
                string email = dgvClient.Rows[e.RowIndex].Cells[3].Value.ToString();
                string phone = dgvClient.Rows[e.RowIndex].Cells[4].Value.ToString();
                string address = dgvClient.Rows[e.RowIndex].Cells[5].Value.ToString();

                // Open the form in Edit mode with the selected row data
                Frm_Client editForm = new Frm_Client(clientId, name, gender, email, phone, address);
                editForm.ShowDialog();
            }
            else if (e.ColumnIndex == dgvClient.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                string name = dgvClient.Rows[e.RowIndex].Cells[1].Value.ToString();
                int clientId = Convert.ToInt32(dgvClient.Rows[e.RowIndex].Cells[0].Value);
                clientCLass.DeleteClient(name, clientId);
            }
        }
        private void Page_Client_Leave(object sender, EventArgs e)
        {
            refreshTable.Stop();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            loadClients();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();
            string genderFilter = cmbGender.SelectedItem?.ToString() ?? "Gender (All)";
            LoadClientsBySearch(searchQuery, genderFilter);
        }
        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchQuery = txtSearch.Text.Trim();
            string genderFilter = cmbGender.SelectedItem?.ToString() ?? "Gender (All)";
            LoadClientsBySearch(searchQuery, genderFilter);
        }
    }
}
