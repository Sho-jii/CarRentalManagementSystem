using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalManagementSystem._Forms
{
    public partial class Frm_ClientReport : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        public Frm_ClientReport(string clientName, string gender, string address, string phone, int totalRentedCars, decimal damagecost, decimal totalSpent)
        {
            InitializeComponent();
            lblclientName.Text = clientName;
            lblGender.Text = gender;
            lblAddress.Text = address;
            lblPhoneNumber.Text = phone;
            lblRented.Text = totalRentedCars.ToString();
            lblTDC.Text = damagecost.ToString();
            lblTotalSpent.Text = totalSpent.ToString();
            printDocument.PrintPage += new PrintPageEventHandler(PrintDocument_PrintPage);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void printD_Click(object sender, EventArgs e)
        {
            printPreviewDialog.Document = printDocument;
            printPreviewDialog.ShowDialog();
        }
        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap formBitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(formBitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Draw the captured bitmap onto the print document, scaling it to fit the page
            e.Graphics.DrawImage(formBitmap, new Rectangle(0, 0, e.PageBounds.Width, e.PageBounds.Height));
        }
        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            // Capture the form's content as a bitmap
            Bitmap formBitmap = new Bitmap(this.Width, this.Height);
            this.DrawToBitmap(formBitmap, new Rectangle(0, 0, this.Width, this.Height));

            // Draw the bitmap onto the print document
            e.Graphics.DrawImage(formBitmap, 0, 0);
        }
    }
}
