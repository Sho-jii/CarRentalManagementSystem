using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using CarRentalManagementSystem._Models;

namespace CarRentalManagementSystem._Forms
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void linkBack_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginPanel.BringToFront();
        }

        private void linkReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            regPanel.Visible = true;
            regPanel.BringToFront();
        }
        private bool ValidateInputLogin()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("All fields must be filled!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        private bool ValidateInputRegister()
        {
            if (string.IsNullOrWhiteSpace(txtRegUsername.Text) ||
            string.IsNullOrWhiteSpace(txtRegPass.Text) ||
            string.IsNullOrWhiteSpace(txtCPass.Text))
            {
                MessageBox.Show("All fields must be filled!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtRegPass.Text != txtCPass.Text)
            {
                MessageBox.Show("Password and Confirm Password do not match!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateInputLogin()) return;

            string username = txtUsername.Text.Trim();
            string password = txtPass.Text.Trim();

            string query = "SELECT Status FROM CarRentalUsers WHERE LTRIM(RTRIM(Username)) = @username AND LTRIM(RTRIM(Password)) = @password";
            var parameters = new Dictionary<string, object>
            {
                { "@username", username },
                { "@password", password }
            };

            string userStatus = string.Empty;
            using (var db = new Database())
            {
                userStatus = db.Scalar(query, parameters);
            }

            if (!string.IsNullOrEmpty(userStatus))
            {
                MessageBox.Show("Login successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Determine if the user is active or inactive
                bool isActive = userStatus.Equals("Active", StringComparison.OrdinalIgnoreCase);

                // Pass the status to the main form
                MainForm mainForm = new MainForm(isActive);
                mainForm.FormClosed += (s, args) => this.Close();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid credentials.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!ValidateInputRegister()) return;

            string username = txtRegUsername.Text.Trim();
            string password = txtRegPass.Text.Trim();

            string checkQuery = "SELECT COUNT(*) FROM CarRentalUsers WHERE LTRIM(RTRIM(Username)) = @username";
            var checkParameters = new Dictionary<string, object>
            {
                { "@username", username }
            };

            using (var db = new Database())
            {
                string userExists = db.Scalar(checkQuery, checkParameters);

                if (int.Parse(userExists) > 0)
                {
                    MessageBox.Show("Username already exists!", "Registration Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string insertQuery = "INSERT INTO CarRentalUsers (Username, Password, Status) VALUES (@username, @password, 'Inactive')";
                var insertParameters = new Dictionary<string, object>
                {
                    { "@username", username },
                    { "@password", password }
                };

                db.Execute(insertQuery, insertParameters);
            }

            MessageBox.Show("Registration successful! Your account is now inactive and requires admin approval.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loginPanel.BringToFront();
        }
        private void showLog_CheckedChanged(object sender, EventArgs e)
        {
            if (showLog.Checked)
            {
                txtPass.UseSystemPasswordChar = false; // Show password
            }
            else
            {
                txtPass.UseSystemPasswordChar = true; // Hide password
            }
        }

        private void showReg_Click(object sender, EventArgs e)
        {
            if (showReg.Checked)
            {
                txtRegPass.UseSystemPasswordChar = false;         // Show password
                txtCPass.UseSystemPasswordChar = false;  // Show confirm password
            }
            else
            {
                txtRegPass.UseSystemPasswordChar = true;          // Hide password
                txtCPass.UseSystemPasswordChar = true;   // Hide confirm password
            }
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            txtRegPass.UseSystemPasswordChar = true;          
            txtCPass.UseSystemPasswordChar = true;
            txtPass.UseSystemPasswordChar = true;
        }
    }
}
