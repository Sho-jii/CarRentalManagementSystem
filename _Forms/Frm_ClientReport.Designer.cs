namespace CarRentalManagementSystem._Forms
{
    partial class Frm_ClientReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ClientReport));
            this.dragControlForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.printD = new System.Windows.Forms.Panel();
            this.lblclientName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblRented = new System.Windows.Forms.Label();
            this.lblTotalSpent = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTDC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dragControlForm
            // 
            this.dragControlForm.DockIndicatorTransparencyValue = 0.6D;
            this.dragControlForm.TargetControl = this;
            this.dragControlForm.UseTransparentDrag = true;
            // 
            // borderlessForm
            // 
            this.borderlessForm.AnimateWindow = true;
            this.borderlessForm.ContainerControl = this;
            this.borderlessForm.DockIndicatorColor = System.Drawing.Color.DimGray;
            this.borderlessForm.DockIndicatorTransparencyValue = 0.6D;
            this.borderlessForm.ShadowColor = System.Drawing.Color.Teal;
            this.borderlessForm.TransparentWhileDrag = true;
            // 
            // printD
            // 
            this.printD.BackColor = System.Drawing.Color.Transparent;
            this.printD.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printD.Location = new System.Drawing.Point(684, 363);
            this.printD.Name = "printD";
            this.printD.Size = new System.Drawing.Size(238, 184);
            this.printD.TabIndex = 0;
            this.printD.Click += new System.EventHandler(this.printD_Click);
            // 
            // lblclientName
            // 
            this.lblclientName.AutoSize = true;
            this.lblclientName.BackColor = System.Drawing.Color.Transparent;
            this.lblclientName.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblclientName.Location = new System.Drawing.Point(365, 289);
            this.lblclientName.Name = "lblclientName";
            this.lblclientName.Size = new System.Drawing.Size(98, 23);
            this.lblclientName.TabIndex = 1;
            this.lblclientName.Text = "clientName";
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.BackColor = System.Drawing.Color.Transparent;
            this.lblGender.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGender.Location = new System.Drawing.Point(312, 349);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(63, 23);
            this.lblGender.TabIndex = 2;
            this.lblGender.Text = "gender";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(321, 408);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(71, 23);
            this.lblAddress.TabIndex = 3;
            this.lblAddress.Text = "address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(390, 467);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(122, 23);
            this.lblPhoneNumber.TabIndex = 4;
            this.lblPhoneNumber.Text = "phoneNumber";
            // 
            // lblRented
            // 
            this.lblRented.AutoSize = true;
            this.lblRented.BackColor = System.Drawing.Color.Transparent;
            this.lblRented.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRented.Location = new System.Drawing.Point(566, 583);
            this.lblRented.Name = "lblRented";
            this.lblRented.Size = new System.Drawing.Size(60, 23);
            this.lblRented.TabIndex = 5;
            this.lblRented.Text = "rented";
            // 
            // lblTotalSpent
            // 
            this.lblTotalSpent.AutoSize = true;
            this.lblTotalSpent.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalSpent.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSpent.Location = new System.Drawing.Point(381, 643);
            this.lblTotalSpent.Name = "lblTotalSpent";
            this.lblTotalSpent.Size = new System.Drawing.Size(91, 23);
            this.lblTotalSpent.TabIndex = 6;
            this.lblTotalSpent.Text = "totalSpent";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(356, 642);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "₱";
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(439, 701);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "₱";
            // 
            // lblTDC
            // 
            this.lblTDC.AutoSize = true;
            this.lblTDC.BackColor = System.Drawing.Color.Transparent;
            this.lblTDC.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDC.Location = new System.Drawing.Point(464, 702);
            this.lblTDC.Name = "lblTDC";
            this.lblTDC.Size = new System.Drawing.Size(146, 23);
            this.lblTDC.TabIndex = 8;
            this.lblTDC.Text = "totalDamageCost";
            // 
            // Frm_ClientReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentalManagementSystem.Properties.Resources.ClientReport;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 990);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTDC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalSpent);
            this.Controls.Add(this.lblRented);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblclientName);
            this.Controls.Add(this.printD);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_ClientReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_ClientReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl dragControlForm;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblclientName;
        private System.Windows.Forms.Panel printD;
        private System.Windows.Forms.Label lblTotalSpent;
        private System.Windows.Forms.Label lblRented;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTDC;
    }
}