using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagementSystem._Forms;
using CarRentalManagementSystem._Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CarRentalManagementSystem._Pages
{
    public partial class Page_Users : UserControl
    {
        public Page_Users()
        {
            InitializeComponent();
            DisplayAllUsers();
        }
        public void DisplayAllUsers(string searchText = "", string status = "All")
        {
            try
            {
                string sql = "SELECT * FROM CarRentalUsers WHERE 1 = 1";  // Base query

                // Add filter for username search
                if (!string.IsNullOrEmpty(searchText))
                {
                    sql += " AND Username LIKE @searchText";
                }

                // Add filter for status
                if (status != "All")
                {
                    sql += " AND Status = @status";
                }

                using (Database database = new Database())
                {
                    var parameters = new Dictionary<string, object>();
                    if (!string.IsNullOrEmpty(searchText))
                    {
                        parameters.Add("@searchText", "%" + searchText + "%");
                    }
                    if (status != "All")
                    {
                        parameters.Add("@status", status);
                    }

                    if (dgvUsers == null)
                    {
                        MessageBox.Show("The DataGridView is not initialized.");
                        return;
                    }

                    dgvUsers.DataSource = database.Select(sql, parameters);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading Users: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Page_Users_Load(object sender, EventArgs e)
        {
            dgvUsers.Columns["Edit"].DefaultCellStyle.NullValue = "🖊";
            dgvUsers.Columns["Delete"].DefaultCellStyle.NullValue = "❌";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Frm_Users addUser = new Frm_Users();
            addUser.ShowDialog();
        }
        private void dgvUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvUsers.Columns["Edit"].Index && e.RowIndex >= 0)
            {
                int userid = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
                string username = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                string password = dgvUsers.Rows[e.RowIndex].Cells[2].Value.ToString();
                string status = dgvUsers.Rows[e.RowIndex].Cells[3].Value.ToString();

                Frm_Users editUser = new Frm_Users(userid, username, password, status);
                editUser.ShowDialog();
            }
            else if (e.ColumnIndex == dgvUsers.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                int userid = Convert.ToInt32(dgvUsers.Rows[e.RowIndex].Cells[0].Value);
                string username = dgvUsers.Rows[e.RowIndex].Cells[1].Value.ToString();
                DialogResult result = MessageBox.Show($"Are you sure you want to remove {username.Trim()}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    string sql = "DELETE FROM CarRentalUsers WHERE UserID = @UserID";

                    using (var db = new Database())
                    {
                        db.Execute(sql, new Dictionary<string, object> { { "@UserID", userid } });
                        MessageBox.Show("User deleted successfully.", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void dgvUsers_CellFormatting_1(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvUsers.Columns[e.ColumnIndex].Name == "Edit")
            {
                e.CellStyle.ForeColor = Color.FromArgb(27, 113, 187);
                e.CellStyle.SelectionForeColor = Color.FromArgb(27, 113, 187);
                e.CellStyle.SelectionBackColor = Color.WhiteSmoke;
            }
            else if (dgvUsers.Columns[e.ColumnIndex].Name == "Delete")
            {
                e.CellStyle.ForeColor = Color.FromArgb(226, 72, 81);
                e.CellStyle.SelectionForeColor = Color.FromArgb(226, 72, 81);
                e.CellStyle.SelectionBackColor = Color.WhiteSmoke;
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            DisplayAllUsers();
            cmbStatus.SelectedIndex = 0;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string status = cmbStatus.SelectedItem.ToString();
            DisplayAllUsers(searchText, status);  
        }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            string status = cmbStatus.SelectedItem.ToString();
            DisplayAllUsers(searchText, status); 
        }
    }
}
