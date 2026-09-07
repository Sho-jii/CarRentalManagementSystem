namespace CarRentalManagementSystem._Forms
{
    partial class Frm_Issue
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Issue));
            this.panelDrag = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dragControlForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.dtpRentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbCB = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.panelDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDrag
            // 
            this.panelDrag.BackColor = System.Drawing.Color.Transparent;
            this.panelDrag.Controls.Add(this.guna2PictureBox1);
            this.panelDrag.Controls.Add(this.label3);
            this.panelDrag.Controls.Add(this.exitBtn);
            this.panelDrag.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDrag.FillColor = System.Drawing.Color.Teal;
            this.panelDrag.FillColor2 = System.Drawing.Color.Teal;
            this.panelDrag.FillColor3 = System.Drawing.Color.Teal;
            this.panelDrag.FillColor4 = System.Drawing.Color.Teal;
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(554, 53);
            this.panelDrag.TabIndex = 7;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::CarRentalManagementSystem.Properties.Resources.Logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(3, -2);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(56, 59);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.guna2PictureBox1.TabIndex = 6;
            this.guna2PictureBox1.TabStop = false;
            this.guna2PictureBox1.UseTransparentBackground = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Heavy", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(63, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Issue";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.IconColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(498, 5);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(53, 46);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
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
            // dragControlForm
            // 
            this.dragControlForm.DockIndicatorTransparencyValue = 0.6D;
            this.dragControlForm.TargetControl = this.panelDrag;
            this.dragControlForm.UseTransparentDrag = true;
            // 
            // dtpRentDate
            // 
            this.dtpRentDate.Animated = true;
            this.dtpRentDate.BackColor = System.Drawing.Color.Transparent;
            this.dtpRentDate.BorderColor = System.Drawing.Color.Teal;
            this.dtpRentDate.Checked = true;
            this.dtpRentDate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dtpRentDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.dtpRentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpRentDate.IndicateFocus = true;
            this.dtpRentDate.Location = new System.Drawing.Point(213, 87);
            this.dtpRentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpRentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpRentDate.Name = "dtpRentDate";
            this.dtpRentDate.Size = new System.Drawing.Size(302, 36);
            this.dtpRentDate.TabIndex = 29;
            this.dtpRentDate.UseTransparentBackground = true;
            this.dtpRentDate.Value = new System.DateTime(2024, 11, 17, 17, 53, 18, 126);
            this.dtpRentDate.Validated += new System.EventHandler(this.dtpRentDate_Validated);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(79, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 21);
            this.label12.TabIndex = 28;
            this.label12.Text = "Rent Date:";
            // 
            // txtDHP
            // 
            this.txtDHP.Animated = true;
            this.txtDHP.BorderColor = System.Drawing.Color.Teal;
            this.txtDHP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDHP.DefaultText = "";
            this.txtDHP.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDHP.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDHP.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDHP.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDHP.Enabled = false;
            this.txtDHP.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDHP.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDHP.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtDHP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDHP.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDHP.Location = new System.Drawing.Point(213, 236);
            this.txtDHP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDHP.Name = "txtDHP";
            this.txtDHP.PasswordChar = '\0';
            this.txtDHP.PlaceholderText = "";
            this.txtDHP.SelectedText = "";
            this.txtDHP.Size = new System.Drawing.Size(302, 44);
            this.txtDHP.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDHP.TabIndex = 27;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(40, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "Daily Hire Price:";
            // 
            // cmbCB
            // 
            this.cmbCB.BackColor = System.Drawing.Color.Transparent;
            this.cmbCB.BorderColor = System.Drawing.Color.Teal;
            this.cmbCB.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCB.Enabled = false;
            this.cmbCB.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbCB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCB.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbCB.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.cmbCB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbCB.ItemHeight = 30;
            this.cmbCB.Items.AddRange(new object[] {
            "BrandNew",
            "VeryGood",
            "Good",
            "Fair",
            "Bad",
            "VeryBad",
            "Damaged"});
            this.cmbCB.Location = new System.Drawing.Point(213, 159);
            this.cmbCB.Name = "cmbCB";
            this.cmbCB.Size = new System.Drawing.Size(302, 36);
            this.cmbCB.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbCB.TabIndex = 31;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 21);
            this.label2.TabIndex = 30;
            this.label2.Text = "Condtion Before:";
            // 
            // btnCancel
            // 
            this.btnCancel.Animated = true;
            this.btnCancel.BorderColor = System.Drawing.Color.Teal;
            this.btnCancel.BorderRadius = 1;
            this.btnCancel.BorderThickness = 2;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.btnCancel.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnCancel.Location = new System.Drawing.Point(313, 323);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 45);
            this.btnCancel.TabIndex = 33;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Animated = true;
            this.btnSave.BorderColor = System.Drawing.Color.Teal;
            this.btnSave.BorderRadius = 1;
            this.btnSave.BorderThickness = 2;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Black;
            this.btnSave.FillColor2 = System.Drawing.Color.Black;
            this.btnSave.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnSave.Location = new System.Drawing.Point(417, 323);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 45);
            this.btnSave.TabIndex = 32;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Frm_Issue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(554, 380);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtpRentDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDHP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panelDrag);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Issue";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Issue";
            this.Load += new System.EventHandler(this.Frm_Issue_Load);
            this.panelDrag.ResumeLayout(false);
            this.panelDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelDrag;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ControlBox exitBtn;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private Guna.UI2.WinForms.Guna2DragControl dragControlForm;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpRentDate;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtDHP;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2ComboBox cmbCB;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
    }
}