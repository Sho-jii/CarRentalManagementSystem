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
using ServiceStack.OrmLite;

namespace CarRentalManagementSystem._Pages
{
    public partial class Page_Rental : UserControl
    {
        Rental rental = new Rental();
        public Page_Rental()
        {
            InitializeComponent();
            LoadAllRentData();
        }
        private void LoadFilteredData(string status = null, string searchText = null)
        {
            try
            {
                DataTable rentalData;

                if (!string.IsNullOrWhiteSpace(searchText))
                {
                    rentalData = status == null
                        ? rental.GetRentalDataBySearchAS(searchText)
                        : rental.GetRentalDataBySearch(searchText, status);
                }
                else
                {
                    rentalData = status == null
                        ? rental.LoadRentData()
                        : rental.allStatus(status);
                }
                dgvRental.DataSource = rentalData;
                FormatGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error", MessageBoxButtons.OK);
            }
        }
        private void FormatGridView()
        {
            dgvRental.Columns[10].DefaultCellStyle.Format = "C2";
            dgvRental.Columns[10].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
            dgvRental.Columns[12].DefaultCellStyle.Format = "C2";
            dgvRental.Columns[12].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
        }
        public void LoadAllRentData()
        {
            LoadFilteredData();
        }
        private void Page_Rental_Load(object sender, EventArgs e)
        {
            LoadAllRentData();
        }  
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string status = null;

                switch (cmbStatus.SelectedIndex)
                {
                    case 1:
                        status = "In-Possession";
                        break;
                    case 2:
                        status = "Returned";
                        break;
                    case 3:
                        status = "Lost";
                        break;
                    case 4:
                        status = "Damaged";
                        break;
                    default:
                        status = null; 
                        break;
                }

                LoadFilteredData(status, txtSearch.Text.Trim()); // Pass search text here
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading Data: " + ex, "Error", MessageBoxButtons.OK);
            }
            
        }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Clear();
            string status = null;

            switch (cmbStatus.SelectedIndex)
            {
                case 1:
                    status = "In-Possession";
                    break;
                case 2:
                    status = "Returned";
                    break;
                case 3:
                    status = "Lost";
                    break;
                case 4:
                    status = "Damaged";
                    break;
                default:
                    status = null; 
                    break;
            }

            LoadFilteredData(status, txtSearch.Text.Trim()); // Pass search text even if it's empty
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadAllRentData();
            cmbStatus.SelectedIndex = 0;
        }
        private void dgvRental_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvRental.Columns["Cancel"].Index && e.RowIndex >= 0)
            {
                int rentalId = Convert.ToInt32(dgvRental.Rows[e.RowIndex].Cells[0].Value); 
                int vehicleId = Convert.ToInt32(dgvRental.Rows[e.RowIndex].Cells[1].Value);
                int clientId = Convert.ToInt32(dgvRental.Rows[e.RowIndex].Cells[2].Value);
                string vehicleModel = dgvRental.Rows[e.RowIndex].Cells[4].Value.ToString(); 
                DateTime? returnDate = dgvRental.Rows[e.RowIndex].Cells[9].Value as DateTime?;
                int days = Convert.ToInt32(dgvRental.Rows[e.RowIndex].Cells[11].Value);
                DateTime dateAdded = Convert.ToDateTime(dgvRental.Rows[e.RowIndex].Cells[14].Value);

                if (returnDate == null)
                {
                    if (days >= 1)
                    {
                        MessageBox.Show("This rental cannot be cancelled as it is already in use.", "Cancellation Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else if (days == 0 && (DateTime.Now - dateAdded).TotalDays > 2)
                    {
                        MessageBox.Show("This rental cannot be cancelled as it has exceeded 2 days from the booking date.", "Cancellation Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }

                    DialogResult result = MessageBox.Show($"Are you sure you want to cancel the rental of vehicle {vehicleModel}?", "Cancel Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (Database db = new Database())
                            {
                                string deleteQuery = "DELETE FROM vehicleRentals WHERE Id = @rentalId";
                                db.Execute(deleteQuery, new Dictionary<string, object> { { "@rentalId", rentalId } });

                                string updateQuery = "UPDATE vehicleInventory SET Status = 'Available' WHERE VehicleID = @vehicleId";
                                db.Execute(updateQuery, new Dictionary<string, object> { { "@vehicleId", vehicleId } });

                                string updateClientQuery = "UPDATE clientProfiles SET In_Possession = In_Possession - 1 WHERE ClientID = @clientId";
                                db.Execute(updateClientQuery, new Dictionary<string, object> { { "@clientId", clientId } });

                                LoadAllRentData();  

                                MessageBox.Show($"Rental has been successfully canceled and the vehicle {vehicleModel} is now available.", "Cancellation Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while canceling the rental: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    // If ReturnDate is not null, ask the user for confirmation to delete the rental
                    DialogResult result = MessageBox.Show("This rental has already been returned. Do you want to delete it instead?", "Delete Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            using (var db = new Database())
                            {
                                string deleteQuery = "DELETE FROM vehicleRentals WHERE Id = @rentalId";
                                var parameters = new Dictionary<string, object>
                                {
                                    { "@rentalId", rentalId }
                                };
                                db.Execute(deleteQuery, parameters);

                                LoadAllRentData();

                                MessageBox.Show("Rental data has been successfully deleted.", "Deletion Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"An error occurred while deleting the rental: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The rental data was not deleted.", "Cancel Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void dgvRental_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvRental.Columns[e.ColumnIndex].Name == "Cancel")
            {
                e.CellStyle.ForeColor = Color.FromArgb(226, 72, 81);
                e.CellStyle.SelectionForeColor = Color.FromArgb(226, 72, 81);
                e.CellStyle.SelectionBackColor = Color.WhiteSmoke;
            }
        }
    }
}
