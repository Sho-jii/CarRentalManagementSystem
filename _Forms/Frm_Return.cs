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
    public partial class Frm_Return : Form
    {
        Page_Dashboard dashboard = new Page_Dashboard();
        Rental Rentals = new Rental();

        private int rentalId;
        private int clientId;
        private int vehicleId;
        private string vehicleName;

        public Frm_Return(int rentalId, int clientid, int vehicleid, string condition, DateTime rentDate, decimal dailyHirePrice, int days, decimal total, string vehicleModel)
        {
            InitializeComponent();
            this.rentalId = rentalId;
            this.clientId = clientid;
            this.vehicleId = vehicleid;
            this.vehicleName = vehicleModel;

            txtConditionAfter.Text = condition;
            txtRentDate.Value = rentDate;
            txtDHP.Text = dailyHirePrice.ToString();
            txtDays.Text = days.ToString();
            txtTotal.Text = total.ToString();

            txtReturnDate.MinDate = DateTime.Now; 
        }
        private void Frm_Return_Load(object sender, EventArgs e)
        {
            DisableConditionOptions(txtConditionAfter.Text);
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string conditionAfter = txtConditionAfter.Text;
                string status = txtStatus.Text;
                string days = txtDays.Text;
                string total = txtTotal.Text;
                DateTime returnDate = txtReturnDate.Value;

                if (string.IsNullOrEmpty(conditionAfter) || string.IsNullOrEmpty(status))
                {
                    MessageBox.Show("Please fill out all fields.", "Validation Error");
                    return;
                }

                decimal damageFee = 0;
                decimal dailyHirePrice = 0;

                if (!decimal.TryParse(txtDHP.Text, out dailyHirePrice))
                {
                    MessageBox.Show("Invalid Daily Hire Price entered.", "Error");
                    return;
                }

                if (status == "Damaged")
                {
                    // Calculate the damage fee using the method
                    damageFee = CalculateDamageFee(dailyHirePrice);

                    // Add the damage fee to the total spent
                    total = (Convert.ToDecimal(total) + damageFee).ToString();
                }

                // Update the vehicle's condition and status
                string updateVehicleConditionSql = @"UPDATE vehicleInventory 
                                             SET Condition = @Condition, 
                                                 Status = CASE 
                                                             WHEN @status = 'Damaged' THEN 'Unavailable' 
                                                             ELSE 'Available' 
                                                         END
                                             WHERE VehicleID = @VehicleID";

                Dictionary<string, object> vehicleParams = new Dictionary<string, object>
                {
                    { "@Condition", conditionAfter },
                    { "@status", status },
                    { "@VehicleID", vehicleId }
                };

                // Update the rental record
                string updateRentalsql = @"UPDATE vehicleRentals 
                           SET ConditionAfter = @ConditionAfter, 
                               Status = @Status, 
                               ReturnDate = @ReturnDate, 
                               DamageFee = @DamageFee
                           WHERE Id = @RentalId";

                Dictionary<string, object> rentalParams = new Dictionary<string, object>
                {
                    { "@ConditionAfter", conditionAfter },
                    { "@Status", status },
                    { "@ReturnDate", returnDate },
                    { "@DamageFee", damageFee },
                    { "@RentalId", rentalId }
                };

                // Update the client record, including the damage fee
                string updateClientSql = @"
                                 UPDATE clientProfiles
                                 SET 
                                     In_Possession = In_Possession - 1,
                                     Damaged = Damaged + CASE WHEN @Status = 'Damaged' THEN 1 ELSE 0 END,
                                     Lost = Lost + CASE WHEN @Status = 'Lost' THEN 1 ELSE 0 END,
                                     Spent = Spent + @Total
                                 WHERE ClientID = @ClientID";

                Dictionary<string, object> clientParams = new Dictionary<string, object>
                {
                    { "@Status", status },
                    { "@Total", total },
                    { "@ClientID", clientId }
                };

                using (Database db = new Database())
                {
                    // Execute the vehicle condition update
                    db.Execute(updateVehicleConditionSql, vehicleParams);

                    // Execute the rental record update
                    db.Execute(updateRentalsql, rentalParams);

                    // Execute the client record update
                    db.Execute(updateClientSql, clientParams);

                    if (status == "Lost")
                    {
                        // Display a message that the vehicle is marked as lost
                        MessageBox.Show($"The vehicle {vehicleName} has been marked as Lost and will be removed from inventory.", "Vehicle Lost", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Delete the vehicle from the inventory
                        string deleteVehicleSql = @"DELETE FROM vehicleInventory WHERE VehicleID = @VehicleID";
                        db.Execute(deleteVehicleSql, new Dictionary<string, object> { { "@VehicleID", vehicleId } });
                    }
                }

                if (status == "Damaged")
                {
                    MessageBox.Show($"A damage fee of ₱{damageFee} has been charged to the client.", "Damage Fee", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                MessageBox.Show("Vehicle returned successfully!", "Success");
                dashboard.LoadDashboardData();
                Rentals.LoadRentData();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        // Calculate the damage fee
        private decimal CalculateDamageFee(decimal dailyHirePrice)
        {
            // Default calculation: 50% of daily hire price
            decimal defaultFee = dailyHirePrice * 0.5m;

            // Ask if the user wants to override the fee
            DialogResult result = MessageBox.Show($"The default damage fee is ₱{defaultFee}. Would you like to override it?",
                                                  "Override Damage Fee",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Allow manual input for the damage fee
                return GetDamageFee();
            }

            // Return the default fee
            return defaultFee;
        }

        // Method to get the custom damage fee from the user
        private decimal GetDamageFee()
        {
            decimal customFee = 0;

            // Show an input dialog to get the custom damage fee
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter the custom damage fee:", "Custom Damage Fee", "0.00");

            if (!decimal.TryParse(input, out customFee) || customFee < 0)
            {
                MessageBox.Show("Invalid input. Please enter a valid positive number.", "Error");
                return 0;
            }

            return customFee;
        }



        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void DisableConditionOptions(string condition)
        {
            // Enable all options initially
            foreach (var item in txtConditionAfter.Items)
            {
                txtConditionAfter.Enabled = true;
            }

            // Switch statement to remove higher condition options based on the selected condition
            switch (condition)
            {
                case "BrandNew":
                    txtConditionAfter.Items.Remove("BrandNew");
                    break;
                case "VeryGood":
                    txtConditionAfter.Items.Remove("BrandNew");
                    break;
                case "Good":
                    txtConditionAfter.Items.Remove("BrandNew");
                    txtConditionAfter.Items.Remove("VeryGood");
                    break;
                case "Fair":
                    txtConditionAfter.Items.Remove("BrandNew");
                    txtConditionAfter.Items.Remove("VeryGood");
                    txtConditionAfter.Items.Remove("Good");
                    break;
                case "Bad":
                    txtConditionAfter.Items.Remove("BrandNew");
                    txtConditionAfter.Items.Remove("VeryGood");
                    txtConditionAfter.Items.Remove("Good");
                    txtConditionAfter.Items.Remove("Fair");
                    break;
                case "VeryBad":
                    txtConditionAfter.Items.Remove("BrandNew");
                    txtConditionAfter.Items.Remove("VeryGood");
                    txtConditionAfter.Items.Remove("Good");
                    txtConditionAfter.Items.Remove("Fair");
                    txtConditionAfter.Items.Remove("Bad");
                    break;
                case "Damaged":
                    txtConditionAfter.Items.Remove("BrandNew");
                    txtConditionAfter.Items.Remove("VeryGood");
                    txtConditionAfter.Items.Remove("Good");
                    txtConditionAfter.Items.Remove("Fair");
                    txtConditionAfter.Items.Remove("Bad");
                    txtConditionAfter.Items.Remove("VeryBad");
                    break;
                default:
                    break;
            }

        }

        private void txtConditionAfter_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisableConditionOptions(txtConditionAfter.Text);
        }
    }
}
