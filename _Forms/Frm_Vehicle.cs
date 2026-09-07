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
    public partial class Frm_Vehicle : Form
    {
        private int? vehicleID;
        public Frm_Vehicle()
        {
            InitializeComponent();
            btnSave.Text = "SAVE";
        }
        public Frm_Vehicle(int vehicleID, string model, string registration, string getStatus, int yom, string color, int capacity, string fuelType, string transmission, decimal dailyPrice, string condition, DateTime DateAdded)
        {
            InitializeComponent();
            this.vehicleID = vehicleID;

            txtModel.Text = model;
            txtRegistration.Text = registration;
            txtYOM.Text = yom.ToString();
            txtColor.Text = color;
            txtCapacity.Text = capacity.ToString();
            txtFuelType.SelectedItem = fuelType;
            txtTransmission.SelectedItem = transmission;
            txtDailyHirePrice.Text = dailyPrice.ToString("F2");
            txtCondition.SelectedItem = condition;
            txtStatus.SelectedItem = getStatus;
            dateAdded.Value = DateAdded;

            btnSave.Text = "UPDATE";
        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtModel.Text) ||
                string.IsNullOrWhiteSpace(txtRegistration.Text) ||
                string.IsNullOrWhiteSpace(txtYOM.Text) ||
                string.IsNullOrWhiteSpace(txtColor.Text) ||
                string.IsNullOrWhiteSpace(txtCapacity.Text) ||
                string.IsNullOrWhiteSpace(txtDailyHirePrice.Text) ||
                txtFuelType.SelectedIndex == -1 ||
                txtTransmission.SelectedIndex == -1 ||
                txtCondition.SelectedIndex == -1 ||
                txtStatus.SelectedIndex == -1)
            {
                MessageBox.Show("All fields must be filled.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            string selectedStatus = txtStatus.SelectedItem?.ToString();
            string selectedCondition = txtCondition.SelectedItem?.ToString();

            // Prevent setting status to Available if the vehicle is damaged / bad condition
            if (selectedStatus == "Available" && 
                (selectedCondition == "Damaged" || selectedCondition == "VeryBad" || selectedCondition == "Very Bad" || selectedCondition == "Bad"))
            {
                MessageBox.Show("A vehicle with damaged or poor condition cannot be set to 'Available'. Please set status to 'Unavailable' until it is repaired.", "Invalid Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;

            string model = txtModel.Text.Trim();
            string registration = txtRegistration.Text.Trim();
            int yom = int.Parse(txtYOM.Text.Trim());
            string color = txtColor.Text.Trim();
            int capacity = int.Parse(txtCapacity.Text.Trim());
            string fuelType = txtFuelType.SelectedItem.ToString();
            string transmission = txtTransmission.SelectedItem.ToString();
            decimal dailyPrice = decimal.Parse(txtDailyHirePrice.Text.Trim());
            string condition = txtCondition.SelectedItem.ToString();
            string status = txtStatus.SelectedItem.ToString();
            DateTime dateAdd = DateTime.Now;

            try
            {
                string sql;
                Dictionary<string, object> parameters = new Dictionary<string, object>
                {
                    { "@Model", model },
                    { "@Registration", registration },
                    { "@Status", status },
                    { "@YOM", yom },
                    { "@Color", color },
                    { "@Capacity", capacity },
                    { "@FuelType", fuelType },
                    { "@Transmission", transmission },
                    { "@DailyHirePrice", dailyPrice },
                    { "@Condition", condition },
                    { "@DateAdded", dateAdd }
                };

                if (btnSave.Text == "SAVE")
                {
                    sql = @"INSERT INTO vehicleInventory (Model, Registration, Status, YOM, Color, Capacity, FuelType, Transmission, DailyHirePrice, Condition, DateAdded) 
                            VALUES (@Model, @Registration, @Status, @YOM, @Color, @Capacity, @FuelType, @Transmission, @DailyHirePrice, @Condition, @DateAdded)";
                }
                else
                {
                    sql = @"UPDATE vehicleInventory SET Model = @Model, Registration = @Registration, Status = @Status, YOM = @YOM, 
                            Color = @Color, Capacity = @Capacity, FuelType = @FuelType, Transmission = @Transmission, 
                            DailyHirePrice = @DailyHirePrice, Condition = @Condition WHERE VehicleID = @VehicleID";
                    parameters["@VehicleID"] = vehicleID;
                }
                using (var db = new Database())
                {
                    int rowsAffected = db.Execute(sql, parameters);
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Vehicle saved successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Failed to save vehicle.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
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

        private void Frm_Vehicle_Load(object sender, EventArgs e)
        {
            
        }
    }
}
