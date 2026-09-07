namespace CarRentalManagementSystem._Forms
{
    partial class Frm_CarReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_CarReport));
            this.dragControlForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.printD = new System.Windows.Forms.Panel();
            this.lblNumRented = new System.Windows.Forms.Label();
            this.lblTotalDaysR = new System.Windows.Forms.Label();
            this.lblCondition = new System.Windows.Forms.Label();
            this.lblVehicleModel = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTDC = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dragControlForm
            // 
            this.dragControlForm.DockIndicatorTransparencyValue = 0.6D;
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
            this.printD.Location = new System.Drawing.Point(682, 358);
            this.printD.Name = "printD";
            this.printD.Size = new System.Drawing.Size(238, 184);
            this.printD.TabIndex = 1;
            this.printD.Click += new System.EventHandler(this.printD_Click);
            // 
            // lblNumRented
            // 
            this.lblNumRented.AutoSize = true;
            this.lblNumRented.BackColor = System.Drawing.Color.Transparent;
            this.lblNumRented.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumRented.Location = new System.Drawing.Point(504, 491);
            this.lblNumRented.Name = "lblNumRented";
            this.lblNumRented.Size = new System.Drawing.Size(102, 23);
            this.lblNumRented.TabIndex = 8;
            this.lblNumRented.Text = "numRented";
            // 
            // lblTotalDaysR
            // 
            this.lblTotalDaysR.AutoSize = true;
            this.lblTotalDaysR.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalDaysR.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalDaysR.Location = new System.Drawing.Point(432, 550);
            this.lblTotalDaysR.Name = "lblTotalDaysR";
            this.lblTotalDaysR.Size = new System.Drawing.Size(96, 23);
            this.lblTotalDaysR.TabIndex = 7;
            this.lblTotalDaysR.Text = "totalDaysR";
            // 
            // lblCondition
            // 
            this.lblCondition.AutoSize = true;
            this.lblCondition.BackColor = System.Drawing.Color.Transparent;
            this.lblCondition.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCondition.Location = new System.Drawing.Point(335, 343);
            this.lblCondition.Name = "lblCondition";
            this.lblCondition.Size = new System.Drawing.Size(82, 23);
            this.lblCondition.TabIndex = 6;
            this.lblCondition.Text = "condition";
            // 
            // lblVehicleModel
            // 
            this.lblVehicleModel.AutoSize = true;
            this.lblVehicleModel.BackColor = System.Drawing.Color.Transparent;
            this.lblVehicleModel.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVehicleModel.Location = new System.Drawing.Point(382, 282);
            this.lblVehicleModel.Name = "lblVehicleModel";
            this.lblVehicleModel.Size = new System.Drawing.Size(109, 23);
            this.lblVehicleModel.TabIndex = 5;
            this.lblVehicleModel.Text = "vehicleModel";
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(534, 610);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(113, 23);
            this.lblTotalRevenue.TabIndex = 9;
            this.lblTotalRevenue.Text = "totalRevenue";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 609);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 23);
            this.label1.TabIndex = 10;
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
            this.label2.Location = new System.Drawing.Point(440, 669);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "₱";
            // 
            // lblTDC
            // 
            this.lblTDC.AutoSize = true;
            this.lblTDC.BackColor = System.Drawing.Color.Transparent;
            this.lblTDC.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTDC.Location = new System.Drawing.Point(468, 670);
            this.lblTDC.Name = "lblTDC";
            this.lblTDC.Size = new System.Drawing.Size(146, 23);
            this.lblTDC.TabIndex = 11;
            this.lblTDC.Text = "totalDamageCost";
            // 
            // Frm_CarReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CarRentalManagementSystem.Properties.Resources.carReport;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(993, 990);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTDC);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.lblNumRented);
            this.Controls.Add(this.printD);
            this.Controls.Add(this.lblTotalDaysR);
            this.Controls.Add(this.lblCondition);
            this.Controls.Add(this.lblVehicleModel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_CarReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_CarReport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl dragControlForm;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private System.Windows.Forms.Panel printD;
        private System.Windows.Forms.Label lblNumRented;
        private System.Windows.Forms.Label lblTotalDaysR;
        private System.Windows.Forms.Label lblCondition;
        private System.Windows.Forms.Label lblVehicleModel;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTDC;
    }
}