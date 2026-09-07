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
    public partial class Frm_Client : Form
    {
        private int? clientId;
        public Frm_Client()
        {
            InitializeComponent();
            btnSave.Text = "SAVE";
        }
        public Frm_Client(int clientId, string name, string gender, string email, string phone, string address)
        {
            InitializeComponent();
            this.clientId = clientId;

            // Populate the fields with existing data
            txtName.Text = name;
            txtGender.Text = gender;
            txtEmail.Text = email;
            txtPhone.Text = phone;
            txtAddress.Text = address;

            btnSave.Text = "UPDATE"; // Change button text for clarity
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Frm_Client_Load(object sender, EventArgs e)
        {

        }
        private bool ValidateInput()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtGender.Text) ||  
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text) ||
                string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                MessageBox.Show("All fields must be filled in before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateInput()) return;
            try
            {
                // Collect data from textboxes
                string name = txtName.Text.Trim();
                string gender = txtGender.Text.Trim();
                string email = txtEmail.Text.Trim();
                string phone = txtPhone.Text.Trim();
                string address = txtAddress.Text.Trim();

                if (btnSave.Text == "SAVE")
                {
                    // SQL Insert Query
                    string sql = @" INSERT INTO clientProfiles (Name, Gender, Email, Phone, Address) 
                                VALUES (@Name, @Gender, @Email, @Phone, @Address)";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@Name", name },
                        { "@Gender", gender },
                        { "@Email", email },
                        { "@Phone", phone },
                        { "@Address", address }
                    };
                    // Database operation
                    using (var db = new Database())
                    {
                        int rowsAffected = db.Execute(sql, parameters);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("Failed to add client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else if (btnSave.Text == "UPDATE")
                {
                    string sql = @"UPDATE clientProfiles 
                           SET Name = @Name, Gender = @Gender, Email = @Email, Phone = @Phone, Address = @Address 
                           WHERE ClientID = @ClientID";

                    Dictionary<string, object> parameters = new Dictionary<string, object>
                    {
                        { "@Name", name },
                        { "@Gender", gender },
                        { "@Email", email },
                        { "@Phone", phone },
                        { "@Address", address },
                        { "@ClientID", clientId } 
                    };

                    using (var db = new Database())
                    {
                        int rowsAffected = db.Execute(sql, parameters);
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Client updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.DialogResult = DialogResult.OK;
                            this.Close(); // Close the form after updating
                        }
                        else
                        {
                            MessageBox.Show("Failed to update client.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }              
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void ClearInputFields()
        {
            txtName.Clear();
            txtGender.SelectedIndex = -1;
            txtEmail.Clear();
            txtPhone.Clear();
            txtAddress.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
