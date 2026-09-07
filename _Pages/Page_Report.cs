using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagementSystem._Models;
using ServiceStack.Text;
using ServiceStack;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using ServiceStack.OrmLite;
using CarRentalManagementSystem._Forms;

namespace CarRentalManagementSystem._Pages
{
    public partial class Page_Report : UserControl
    {
        
        public Page_Report()
        {
            InitializeComponent();
        }
        private async void cmbReportOptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedOption = cmbReportOptions.SelectedItem.ToString();

            if (selectedOption == "Vehicle Report")
            {
                await LoadVehicleRevenue();
                dgvReportV.BringToFront();
            }
            else if (selectedOption == "Client Report")
            {
                await LoadClientRevenue();
                dgvReportC.BringToFront();
            }
        }
        private async Task LoadVehicleRevenue()
        {
            try
            {
                string sql = @"
                            SELECT 
                            v.Model AS VehicleModel,
                            v.[Condition] AS VehicleCondition,
                            COUNT(r.Id) AS TimesRented,
                            COALESCE(SUM(r.Days), 0) AS TotalDaysRented,
                            COALESCE(SUM(r.DamageFee), 0) AS TotalDamageCost,
                            SUM(CASE 
                                WHEN r.ReturnDate IS NOT NULL THEN r.Total 
                                ELSE 0 
                            END) AS TotalRevenue
                            FROM 
                                vehicleInventory v
                            LEFT JOIN 
                                vehicleRentals r ON v.VehicleID = r.VehicleID
                            GROUP BY 
                                v.Model, v.[Condition]
                            ORDER BY 
                                v.Model ASC";

                using (var db = new Database())
                {
                    dgvReportV.DataSource = await Task.Run(() => db.Select(sql));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading vehicles: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvReportV.Columns[1].DefaultCellStyle.Format = "C2";
            dgvReportV.Columns[1].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
        }
        private async Task LoadClientRevenue()
        {
            try
            {
                string sql = @"
                            SELECT 
                            c.Name AS ClientName,
                            c.Gender,
                            c.Address,
                            c.Phone,
                            c.Orders AS TotalRentedCars,
                            COALESCE(SUM(r.DamageFee), 0) AS TotalDamageCost,
                            c.Spent AS TotalSpent
                            FROM 
                                clientProfiles c
                            LEFT JOIN 
                                vehicleRentals r ON c.ClientID = r.ClientID
                            GROUP BY 
                                c.Name, c.Gender, c.Address, c.Phone, c.Orders, c.Spent
                            ORDER BY 
                                c.Spent DESC";

                using (var db = new Database())
                {
                    dgvReportC.DataSource = await Task.Run(() => db.Select(sql));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading client revenue: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dgvReportC.Columns[1].DefaultCellStyle.Format = "C2";
            dgvReportC.Columns[1].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
        }

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string selectedOption = cmbReportOptions.SelectedItem.ToString();
            string searchText = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(searchText))
            {
                // Reload the data if the search box is empty
                if (selectedOption == "Vehicle Report")
                {
                    await LoadVehicleRevenue();
                }
                else if (selectedOption == "Client Report")
                {
                    await LoadClientRevenue();
                }
            }
            else
            {
                try
                { 
                    string sql = "";
                    if (selectedOption == "Vehicle Report")
                    {
                        // Search for vehicle model
                        sql = @"
                            SELECT 
                            v.Model AS VehicleModel,
                            v.[Condition] AS VehicleCondition,
                            COUNT(r.Id) AS TimesRented,
                            COALESCE(SUM(r.Days), 0) AS TotalDaysRented,
                            SUM(CASE 
                                    WHEN r.ReturnDate IS NOT NULL THEN r.Total 
                                    ELSE 0 
                                END) AS TotalRevenue
                            FROM 
                                vehicleInventory v
                            LEFT JOIN 
                                vehicleRentals r ON v.VehicleID = r.VehicleID
                            WHERE
                            v.Model LIKE @SearchText
                            GROUP BY 
                                v.Model, v.[Condition]
                            ORDER BY 
                                v.Model ASC";
                        using (var db = new Database())
                        {
                            var parameters = new Dictionary<string, object>
                        {
                            { "@SearchText", searchText + "%" } 
                        };
                            dgvReportV.DataSource = await Task.Run(() => db.Select(sql, parameters));
                        }
                    }
                    else if (selectedOption == "Client Report")
                    {
                        // Search for client name
                        sql = @"
                        SELECT 
                            c.Name AS ClientName,
                            c.Gender,
                            c.Address,
                            c.Phone,
                            c.Orders AS TotalRentedCars,
                            c.Spent AS TotalSpent
                            FROM 
                                clientProfiles c
                            WHERE
                               c.Name LIKE @SearchText
                            ORDER BY 
                                c.Spent DESC";
                        using (var db = new Database())
                        {
                            var parameters = new Dictionary<string, object>
                        {
                            { "@SearchText", searchText + "%" } 
                        };
                            dgvReportC.DataSource = await Task.Run(() => db.Select(sql, parameters));
                        }
                    }            
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error searching: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            
        }
        private void Page_Report_Load(object sender, EventArgs e)
        {
            dgvReportC.Columns["ClientReport"].DefaultCellStyle.NullValue = "📄";
            dgvReportV.Columns["VehicleReport"].DefaultCellStyle.NullValue = "📄";
        }

        private void dgvReportC_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex == dgvReportC.Columns["ClientReport"].Index)
                {
                    // Extract values from the selected row
                    string clientName = dgvReportC.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string gender = dgvReportC.Rows[e.RowIndex].Cells[2].Value.ToString();
                    string address = dgvReportC.Rows[e.RowIndex].Cells[3].Value.ToString();
                    string phone = dgvReportC.Rows[e.RowIndex].Cells[4].Value.ToString();
                    int totalRentedCars = Convert.ToInt32(dgvReportC.Rows[e.RowIndex].Cells[5].Value);
                    decimal damagecost = Convert.ToDecimal(dgvReportC.Rows[e.RowIndex].Cells[6].Value);
                    decimal totalSpent = Convert.ToDecimal(dgvReportC.Rows[e.RowIndex].Cells[7].Value);

                    // Open the detailed client report form and pass the data
                    Frm_ClientReport clientReport = new Frm_ClientReport(clientName, gender, address, phone, totalRentedCars, damagecost, totalSpent);
                    clientReport.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }         
        }
        private void dgvReportV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvReportV.Columns["VehicleReport"].Index && e.RowIndex >= 0)
                {
                    string vehicleModel = dgvReportV.Rows[e.RowIndex].Cells[1].Value.ToString();
                    string vehicleCondition = dgvReportV.Rows[e.RowIndex].Cells[2].Value.ToString();
                    int timesRented = Convert.ToInt32(dgvReportV.Rows[e.RowIndex].Cells[3].Value);
                    int totalDaysRented = Convert.ToInt32(dgvReportV.Rows[e.RowIndex].Cells[4].Value);
                    decimal damagecost = Convert.ToDecimal(dgvReportV.Rows[e.RowIndex].Cells[5].Value);
                    decimal totalRevenue = Convert.ToDecimal(dgvReportV.Rows[e.RowIndex].Cells[6].Value);

                    Frm_CarReport carReport = new Frm_CarReport(vehicleModel, vehicleCondition, timesRented, totalDaysRented, damagecost, totalRevenue);
                    carReport.ShowDialog();
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error: " + ex);
            }          
        }
    }
}
