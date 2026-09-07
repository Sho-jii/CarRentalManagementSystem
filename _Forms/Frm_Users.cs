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
    public partial class Frm_Users : Form
    {
        private readonly Users _userManager;

        private int UserIds;
        private string Usernames;
        private string Passwords;
        private string Statuss;
        public Frm_Users(int id, string user, string pass, string status)
        {
            InitializeComponent();
            _userManager = new Users();
            UserIds = id;
            Usernames = user;
            Passwords = pass;
            Statuss = status;

            txtUsername.Text = user;
            txtPassword.Text = pass;
            cmbStatus.Text = status;

            btnSave.Text = "UPDATE";
        }
        public Frm_Users()
        {
            InitializeComponent();
            _userManager = new Users();
            btnSave.Text = "SAVE";
        }
        private void ClearFields()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            cmbStatus.SelectedIndex = -1;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (btnSave.Text == "SAVE")
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var newUser = new User
                {
                    Username = txtUsername.Text.Trim(),
                    Password = txtPassword.Text.Trim(),
                    Status = cmbStatus.SelectedItem.ToString()
                };

                if (_userManager.AddUser(newUser))
                {
                    MessageBox.Show("User added successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (btnSave.Text == "UPDATE")
            {
                if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text) || cmbStatus.SelectedIndex == -1)
                {
                    MessageBox.Show("Empty fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (MessageBox.Show($"Are you sure you want to update user: {Usernames}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    var updatedUser = new User
                    {
                        Id = UserIds,
                        Username = txtUsername.Text.Trim(),
                        Password = txtPassword.Text.Trim(),
                        Status = cmbStatus.SelectedItem.ToString()
                    };

                    _userManager.UpdateUser(updatedUser);
                    MessageBox.Show("User updated successfully!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
