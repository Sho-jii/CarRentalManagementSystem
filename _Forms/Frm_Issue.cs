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
    public partial class Frm_Issue : Form
    {
        Page_Dashboard dashboard = new Page_Dashboard();
        Page_Rental Rentals = new Page_Rental();

        public int returnClientID {  get; set; }
        private int ClientID;
        private int VehicleID;
        private string vehicleModel;
        private string ClientName;
        private decimal DailyHirePrice;

        public Frm_Issue(int clientID, int vehicleID, string model, string clientName, decimal dailyHirePrice, string condition)
        {
            InitializeComponent();
            ClientID = clientID;
            VehicleID = vehicleID;
            vehicleModel = model;
            ClientName = clientName;
            DailyHirePrice = dailyHirePrice;
            dtpRentDate.MinDate = DateTime.Now;
            dtpRentDate.MaxDate = DateTime.Now.AddDays(7);
            returnClientID = clientID;
            cmbCB.Text = condition;
        }
        public Frm_Issue()
        {
            InitializeComponent();
        }
        private void Frm_Issue_Load(object sender, EventArgs e)
        {
            txtDHP.Text = DailyHirePrice.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string conditionBefore = cmbCB.Text;
                string conditionAfter = "Pending";
                DateTime rentDate = dtpRentDate.Value;
                string status = "In-Possession";
                int days = 1;
                decimal total = DailyHirePrice;
                decimal additionalFee = 0;
                DateTime currentDate = DateTime.Now.Date;

                // Check if RentDate is more than 1 day in the future
                if ((rentDate - currentDate).TotalDays > 1)
                {
                    int extraDays = (rentDate - currentDate).Days;
                    additionalFee = extraDays * 200; 
                    MessageBox.Show(
                        $"The selected Rent Date is in the future. There will be a PHP {additionalFee} fee for {extraDays} extra day(s).",
                        "Notice",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );
                }

                DialogResult confirmation = MessageBox.Show(
                    "Are you sure you want to rent this vehicle? This action cannot be undone.",
                    "Confirm Rental",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (confirmation == DialogResult.No)
                {
                    return;
                }

                string sql = @"INSERT INTO vehicleRentals 
                (VehicleID, ClientID, VehicleModel, ClientName, ConditionBefore, ConditionAfter, RentDate, Status, DailyHirePrice, Days, Total, DateAdded) 
                VALUES (@VehicleID, @ClientID, @VehicleModel, @ClientName, @ConditionBefore, @ConditionAfter, @RentDate, @Status, @DailyHirePrice, @Days, @Total, GETDATE())";

                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@VehicleID", VehicleID },
                    { "@ClientID", ClientID },
                    { "@VehicleModel", vehicleModel },
                    { "@ClientName", ClientName },
                    { "@ConditionBefore", conditionBefore },
                    { "@ConditionAfter", conditionAfter },
                    { "@RentDate", rentDate },
                    { "@Status", status },
                    { "@DailyHirePrice", DailyHirePrice },
                    { "@Days", days },
                    { "@Total", total },
                };

                using (var db = new Database())
                {
                    db.Execute(sql, parameters);
                    db.Execute("UPDATE vehicleInventory SET Status='In-Possession' WHERE VehicleID=@VehicleID", new Dictionary<string, object> { { "@VehicleID", VehicleID } });
                    db.Execute("UPDATE clientProfiles SET Orders = Orders + 1, In_Possession = In_Possession + 1 WHERE ClientID = @ClientID",
                        new Dictionary<string, object> { { "@ClientID", ClientID } });

                    MessageBox.Show("Vehicle issued successfully!", "Success");

                    dashboard.LoadDashboardData();
                    Rentals.LoadAllRentData();

                    Frm_ReturnWizard returnWizard = Application.OpenForms.OfType<Frm_ReturnWizard>().FirstOrDefault();
                    returnWizard?.LoadReturnVehicle();

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void exitBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        private void dtpRentDate_Validated(object sender, EventArgs e)
        {
            
        }
    }
}
