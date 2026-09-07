using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagementSystem._Models;

namespace CarRentalManagementSystem._Pages
{
    public partial class Page_Dashboard : UserControl
    {
        Rental rental = new Rental();
        public Page_Dashboard()
        {
            InitializeComponent();
        }
        private void Page_Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardData();
            LoadRentDataTodayF();
        }
        public void LoadDashboardData()
        {
            try
            {
                using (Database db = new Database()) 
                {
                    // Vehicle count
                    string vehicleCount = db.Scalar("SELECT COUNT(*) FROM vehicleInventory");

                    // Number of vehicles issued
                    string vehiclesIssued = db.Scalar("SELECT COUNT(*) FROM vehicleRentals WHERE RentDate IS NOT NULL");

                    // Number of vehicles returned
                    string vehiclesReturned = db.Scalar("SELECT COUNT(*) FROM vehicleRentals WHERE ReturnDate IS NOT NULL");

                    // Number of vehicles available
                    string vehiclesAvailable = db.Scalar("SELECT COUNT(*) FROM vehicleInventory WHERE Status = 'Available'");

                    // Number of vehicles damaged or lost
                    string vehiclesDamagedLost = db.Scalar("SELECT COUNT(*) FROM vehicleRentals WHERE Status IN ('Damaged', 'Lost')");

                    // Number of clients
                    string clientCount = db.Scalar("SELECT COUNT(*) FROM clientProfiles");

                    // Number of clients in possession
                    string clientsInPossession = db.Scalar("SELECT COUNT(*) FROM clientProfiles WHERE In_Possession > 0");

                    // Total revenue (only for returned vehicles, including rental and damages)
                    string revenue = db.Scalar("SELECT ISNULL(SUM(Total), 0) FROM vehicleRentals WHERE ReturnDate IS NOT NULL");
                    decimal revValue = 0;
                    decimal.TryParse(revenue, out revValue);

                    lblvehicles.Text = vehicleCount;
                    lblvehiclesIssued.Text = vehiclesIssued;
                    lblvehiclesReturned.Text = vehiclesReturned;
                    lblvehiclesAvailable.Text = vehiclesAvailable;
                    lblvehiclesDL.Text = vehiclesDamagedLost;
                    lblclients.Text = clientCount;
                    lblclientsIP.Text = clientsInPossession;
                    lblrevenue.Text = $"₱{revValue:N2}";
                }
            }
            catch (Exception ex)
            {
                // Display a message box with the exception details
                MessageBox.Show($"An error occurred while loading the dashboard data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LoadRentDataTodayF()
        {
            string searchTerm = txtSearch.Text.Trim();
            string status = cmbStatus.SelectedItem?.ToString() ?? "Status (All)";

            DataTable rentalDataToday = rental.LoadRentDataToday(searchTerm, status);
            dgvRental.DataSource = rentalDataToday;

            FormatGridView();
        }
        private void FormatGridView()
        {
            dgvRental.Columns[10].DefaultCellStyle.Format = "C2";
            dgvRental.Columns[10].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");

            dgvRental.Columns[12].DefaultCellStyle.Format = "C2";
            dgvRental.Columns[12].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            LoadRentDataTodayF();
        }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadRentDataTodayF();
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            cmbStatus.SelectedIndex = 0;
            LoadDashboardData();
            LoadRentDataTodayF();
        }
    }
}

