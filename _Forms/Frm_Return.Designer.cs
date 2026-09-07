namespace CarRentalManagementSystem._Forms
{
    partial class Frm_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Return));
            this.panelDrag = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dragControlForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtConditionAfter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRentDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.txtDHP = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtReturnDate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDays = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTotal = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
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
            this.panelDrag.TabIndex = 34;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::CarRentalManagementSystem.Properties.Resources.Logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, -2);
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
            this.label3.Location = new System.Drawing.Point(64, 17);
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
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(306, 616);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 45);
            this.btnCancel.TabIndex = 42;
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
            this.btnSave.Location = new System.Drawing.Point(410, 616);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 45);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtConditionAfter
            // 
            this.txtConditionAfter.BackColor = System.Drawing.Color.Transparent;
            this.txtConditionAfter.BorderColor = System.Drawing.Color.Teal;
            this.txtConditionAfter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtConditionAfter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtConditionAfter.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtConditionAfter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConditionAfter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtConditionAfter.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtConditionAfter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConditionAfter.ItemHeight = 30;
            this.txtConditionAfter.Items.AddRange(new object[] {
            "BrandNew",
            "VeryGood",
            "Good",
            "Fair",
            "Bad",
            "VeryBad",
            "Damaged"});
            this.txtConditionAfter.Location = new System.Drawing.Point(206, 166);
            this.txtConditionAfter.Name = "txtConditionAfter";
            this.txtConditionAfter.Size = new System.Drawing.Size(302, 36);
            this.txtConditionAfter.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtConditionAfter.TabIndex = 40;
            this.txtConditionAfter.SelectedIndexChanged += new System.EventHandler(this.txtConditionAfter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Condtion After     :";
            // 
            // txtRentDate
            // 
            this.txtRentDate.Animated = true;
            this.txtRentDate.BackColor = System.Drawing.Color.Transparent;
            this.txtRentDate.BorderColor = System.Drawing.Color.Teal;
            this.txtRentDate.Checked = true;
            this.txtRentDate.Enabled = false;
            this.txtRentDate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtRentDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtRentDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRentDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtRentDate.IndicateFocus = true;
            this.txtRentDate.Location = new System.Drawing.Point(206, 94);
            this.txtRentDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtRentDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtRentDate.Name = "txtRentDate";
            this.txtRentDate.Size = new System.Drawing.Size(302, 36);
            this.txtRentDate.TabIndex = 38;
            this.txtRentDate.UseTransparentBackground = true;
            this.txtRentDate.Value = new System.DateTime(2024, 11, 17, 17, 53, 18, 126);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(72, 104);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(106, 21);
            this.label12.TabIndex = 37;
            this.label12.Text = "Rent Date     :";
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
            this.txtDHP.Location = new System.Drawing.Point(206, 388);
            this.txtDHP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDHP.Name = "txtDHP";
            this.txtDHP.PasswordChar = '\0';
            this.txtDHP.PlaceholderText = "";
            this.txtDHP.SelectedText = "";
            this.txtDHP.Size = new System.Drawing.Size(302, 44);
            this.txtDHP.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDHP.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(33, 398);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(145, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Daily Hire Price     :";
            // 
            // txtStatus
            // 
            this.txtStatus.BackColor = System.Drawing.Color.Transparent;
            this.txtStatus.BorderColor = System.Drawing.Color.Teal;
            this.txtStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtStatus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtStatus.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtStatus.ItemHeight = 30;
            this.txtStatus.Items.AddRange(new object[] {
            "Returned",
            "Lost",
            "Damaged"});
            this.txtStatus.Location = new System.Drawing.Point(206, 240);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(302, 36);
            this.txtStatus.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtStatus.TabIndex = 44;
            // 
            // txtReturnDate
            // 
            this.txtReturnDate.Animated = true;
            this.txtReturnDate.BackColor = System.Drawing.Color.Transparent;
            this.txtReturnDate.BorderColor = System.Drawing.Color.Teal;
            this.txtReturnDate.Checked = true;
            this.txtReturnDate.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtReturnDate.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtReturnDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtReturnDate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtReturnDate.IndicateFocus = true;
            this.txtReturnDate.Location = new System.Drawing.Point(206, 312);
            this.txtReturnDate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtReturnDate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtReturnDate.Name = "txtReturnDate";
            this.txtReturnDate.Size = new System.Drawing.Size(302, 36);
            this.txtReturnDate.TabIndex = 46;
            this.txtReturnDate.UseTransparentBackground = true;
            this.txtReturnDate.Value = new System.DateTime(2024, 11, 17, 17, 53, 18, 126);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 321);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 21);
            this.label4.TabIndex = 45;
            this.label4.Text = "Return Date     :";
            // 
            // txtDays
            // 
            this.txtDays.Animated = true;
            this.txtDays.BorderColor = System.Drawing.Color.Teal;
            this.txtDays.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDays.DefaultText = "";
            this.txtDays.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDays.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDays.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDays.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDays.Enabled = false;
            this.txtDays.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDays.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDays.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtDays.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDays.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDays.Location = new System.Drawing.Point(206, 467);
            this.txtDays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDays.Name = "txtDays";
            this.txtDays.PasswordChar = '\0';
            this.txtDays.PlaceholderText = "";
            this.txtDays.SelectedText = "";
            this.txtDays.Size = new System.Drawing.Size(302, 44);
            this.txtDays.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDays.TabIndex = 48;
            // 
            // txtTotal
            // 
            this.txtTotal.Animated = true;
            this.txtTotal.BorderColor = System.Drawing.Color.Teal;
            this.txtTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTotal.DefaultText = "";
            this.txtTotal.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTotal.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTotal.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTotal.Enabled = false;
            this.txtTotal.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTotal.Location = new System.Drawing.Point(206, 548);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.PasswordChar = '\0';
            this.txtTotal.PlaceholderText = "";
            this.txtTotal.SelectedText = "";
            this.txtTotal.Size = new System.Drawing.Size(302, 44);
            this.txtTotal.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTotal.TabIndex = 50;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 252);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 51;
            this.label1.Text = "Status     :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(108, 480);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Days     :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 561);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 21);
            this.label6.TabIndex = 53;
            this.label6.Text = "Total     :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(52, 626);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 21);
            this.label7.TabIndex = 54;
            this.label7.Text = "Damage Fee     :";
            // 
            // Frm_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(554, 673);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.txtReturnDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.panelDrag);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConditionAfter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRentDate);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtDHP);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Return";
            this.Load += new System.EventHandler(this.Frm_Return_Load);
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
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox txtConditionAfter;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtRentDate;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtDHP;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DragControl dragControlForm;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtReturnDate;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox txtStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtTotal;
        private Guna.UI2.WinForms.Guna2TextBox txtDays;
        private System.Windows.Forms.Label label7;
    }
}