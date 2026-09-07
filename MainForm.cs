using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CarRentalManagementSystem._Pages;
using CarRentalManagementSystem._Forms;

namespace CarRentalManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm(bool isActive)
        {
            InitializeComponent();
            ConfigureUI(isActive);
        }
        private void ConfigureUI(bool isActive)
        {
            // Hide buttons if the user is inactive
            if (!isActive)
            {
                btnUsers.Visible = false;
                reportsBtn.Visible = false;
            }
        }
        private void vehiclesMenu_Click(object sender, EventArgs e)
        {
            returnBtn.Visible = !returnBtn.Visible;
            issueBtn.Visible = !issueBtn.Visible;
            manageBtn.Visible = !manageBtn.Visible;
        }
        private void PanelTransition()
        {
            panelMenu.Width = (panelMenu.Width == 200) ? 46 : 200;
        }
        private void panelBtn_Click(object sender, EventArgs e)
        {
            PanelTransition();
        }
        private void clientsBtn_Click(object sender, EventArgs e)
        {
            page_Clients.BringToFront();
            page_Clients.Visible = true;
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            page_Dashboard1.BringToFront();
            page_Dashboard1.Visible = true;
        }

        private void manageBtn_Click(object sender, EventArgs e)
        {
            page_Vehicle1.BringToFront();
            page_Vehicle1.Visible = true;
        }
        private void salesBtn_Click(object sender, EventArgs e)
        {
            page_Rental1.BringToFront();
            page_Rental1.Visible = true;
        }
        private void reportsBtn_Click(object sender, EventArgs e)
        {
            page_Report1.BringToFront();
            page_Report1.Visible = true;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dashboardBtn.PerformClick();
        }

        private void RefreshAllPages()
        {
            try
            {
                page_Dashboard1.LoadDashboardData();
                page_Rental1.LoadAllRentData();
                page_Vehicle1.loadVehicles();
                page_Clients.loadClients();
            }
            catch { }
        }

        private void issueBtn_Click(object sender, EventArgs e)
        {
            Frm_IssueWizard issueWizard = new Frm_IssueWizard();
            if (issueWizard.ShowDialog() == DialogResult.OK)
            {
                RefreshAllPages();
            }
        }

        private void returnBtn_Click(object sender, EventArgs e)
        {
            Frm_ReturnWizard returnWizard = new Frm_ReturnWizard();
            if (returnWizard.ShowDialog() == DialogResult.OK)
            {
                RefreshAllPages();
            }
        }
        private void btnUsers_Click(object sender, EventArgs e)
        {
            page_Users1.BringToFront();
            page_Users1.Visible = true;
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Frm_Login login = new Frm_Login();
                login.Show();
                this.Hide();
            }          
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}