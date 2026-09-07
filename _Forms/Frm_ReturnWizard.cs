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
using CarRentalManagementSystem._Pages;

namespace CarRentalManagementSystem._Forms
{
    public partial class Frm_ReturnWizard : Form
    {
        Vehicle classVehicle = new Vehicle();
        private int rentalId;
        private int vehicleId;
        private int clientId;
        private string condition;
        private DateTime rentDate;
        private decimal dailyHirePrice;
        private int days;
        private decimal total;
        private string vehicleModel;
        public Frm_ReturnWizard()
        {
            InitializeComponent();
            LoadReturnVehicle();
        }
        public void LoadReturnVehicle()
        {
            string sql = @"
                        SELECT 
                        vr.Id,
                        vr.RentDate,
                        vr.VehicleID, 
                        vr.ClientID, 
                        vi.Model AS VehicleModel, 
                        cp.Name AS ClientName, 
                        vr.ConditionBefore,
                        vr.ConditionAfter,
                        vr.Status,
                        vr.ReturnDate,
                        vr.DailyHirePrice,
                        CASE 
                            WHEN CAST(vr.RentDate AS DATE) > CAST(GETDATE() AS DATE) THEN 0
                            ELSE DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1
                        END AS Days,
                        CASE 
                            WHEN CAST(vr.RentDate AS DATE) > CAST(vr.DateAdded AS DATE) 
                                 THEN (DATEDIFF(DAY, vr.DateAdded, vr.RentDate) * 200) 
                                      + ((DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice)
                            WHEN CAST(vr.RentDate AS DATE) <= CAST(vr.DateAdded AS DATE) 
                                 THEN (DATEDIFF(DAY, vr.RentDate, ISNULL(vr.ReturnDate, GETDATE())) + 1) * vr.DailyHirePrice
                            ELSE 0
                        END AS Total,
                        vr.DateAdded
                        FROM 
                            vehicleRentals AS vr
                        LEFT JOIN 
                            vehicleInventory AS vi ON vr.VehicleID = vi.VehicleID
                        LEFT JOIN 
                            clientProfiles AS cp ON vr.ClientID = cp.ClientID
                        WHERE 
                            vr.Status = 'In-Possession'
                            AND CAST(vr.RentDate AS DATE) <= CAST(GETDATE() AS DATE)
                        ORDER BY 
                            vr.RentDate DESC";

            using (Database db = new Database())
            {
                dgvRentals.DataSource = db.Select(sql);
            }
            FormatGridView();
        }
        private void FormatGridView()
        {
            dgvRentals.Columns[8].DefaultCellStyle.Format = "C2";
            dgvRentals.Columns[8].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");

            dgvRentals.Columns[10].DefaultCellStyle.Format = "C2";
            dgvRentals.Columns[10].DefaultCellStyle.FormatProvider = new System.Globalization.CultureInfo("en-PH");
        }
        private void dgvRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                rentalId = Convert.ToInt32(dgvRentals.Rows[e.RowIndex].Cells[0].Value);
                vehicleId = Convert.ToInt32(dgvRentals.Rows[e.RowIndex].Cells[1].Value);
                clientId = Convert.ToInt32(dgvRentals.Rows[e.RowIndex].Cells[2].Value);
                rentDate = Convert.ToDateTime(dgvRentals.Rows[e.RowIndex].Cells[4].Value);
                condition = dgvRentals.Rows[e.RowIndex].Cells[7].Value.ToString();
                dailyHirePrice = Convert.ToDecimal(dgvRentals.Rows[e.RowIndex].Cells[8].Value);
                days = Convert.ToInt32(dgvRentals.Rows[e.RowIndex].Cells[9].Value);
                total = Convert.ToDecimal(dgvRentals.Rows[e.RowIndex].Cells[10].Value);
                vehicleModel = dgvRentals.Rows[e.RowIndex].Cells[5].Value.ToString();
            }
        }
        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (rentalId == 0)
            {
                MessageBox.Show("Please select a vehicle to return!");
                return;
            }

            Frm_Return returnDetailsForm = new Frm_Return(rentalId, clientId, vehicleId, condition, rentDate, dailyHirePrice, days, total, vehicleModel);
            returnDetailsForm.ShowDialog();           
        }

        private void Frm_ReturnWizard_Load(object sender, EventArgs e)
        {

        }
        private void LoadReturnVehicle(string searchQuery = "")
        {
            try
            {
                Vehicle vehicle = new Vehicle();
                dgvRentals.DataSource = vehicle.GetReturnableVehicles(searchQuery);
                FormatGridView();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading vehicles: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void txtSearchVehicle_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string searchQuery = txtSearchVehicle.Text.Trim();
                LoadReturnVehicle(searchQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadReturnVehicle();
            txtSearchVehicle.Clear();
        }
    }
}
