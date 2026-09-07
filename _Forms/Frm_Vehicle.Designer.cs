namespace CarRentalManagementSystem._Forms
{
    partial class Frm_Vehicle
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Vehicle));
            this.dragControlForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelDrag = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtFuelType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.dateAdded = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDailyHirePrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtColor = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYOM = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtModel = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRegistration = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtCapacity = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTransmission = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCondition = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panelDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dragControlForm
            // 
            this.dragControlForm.DockIndicatorTransparencyValue = 0.6D;
            this.dragControlForm.TargetControl = this.panelDrag;
            this.dragControlForm.UseTransparentDrag = true;
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
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(973, 42);
            this.panelDrag.TabIndex = 31;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::CarRentalManagementSystem.Properties.Resources.Logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(5, -8);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(55, 55);
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
            this.label3.Location = new System.Drawing.Point(63, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Vehicle";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.IconColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(923, 4);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(47, 35);
            this.exitBtn.TabIndex = 1;
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
            this.btnCancel.Location = new System.Drawing.Point(662, 395);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 45);
            this.btnCancel.TabIndex = 53;
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
            this.btnSave.Location = new System.Drawing.Point(816, 395);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 45);
            this.btnSave.TabIndex = 52;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtFuelType
            // 
            this.txtFuelType.BackColor = System.Drawing.Color.Transparent;
            this.txtFuelType.BorderColor = System.Drawing.Color.Teal;
            this.txtFuelType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtFuelType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtFuelType.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtFuelType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuelType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFuelType.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtFuelType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFuelType.ItemHeight = 30;
            this.txtFuelType.Items.AddRange(new object[] {
            "Petrol",
            "Deisel",
            "Hybrid",
            "Electric"});
            this.txtFuelType.Location = new System.Drawing.Point(652, 70);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(302, 36);
            this.txtFuelType.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtFuelType.TabIndex = 51;
            // 
            // dateAdded
            // 
            this.dateAdded.Animated = true;
            this.dateAdded.BackColor = System.Drawing.Color.Transparent;
            this.dateAdded.BorderColor = System.Drawing.Color.Teal;
            this.dateAdded.Checked = true;
            this.dateAdded.Enabled = false;
            this.dateAdded.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dateAdded.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.dateAdded.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dateAdded.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateAdded.IndicateFocus = true;
            this.dateAdded.Location = new System.Drawing.Point(652, 335);
            this.dateAdded.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dateAdded.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dateAdded.Name = "dateAdded";
            this.dateAdded.Size = new System.Drawing.Size(302, 36);
            this.dateAdded.TabIndex = 50;
            this.dateAdded.UseTransparentBackground = true;
            this.dateAdded.Value = new System.DateTime(2024, 11, 17, 17, 53, 18, 126);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(517, 344);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(98, 21);
            this.label12.TabIndex = 49;
            this.label12.Text = "Date Added:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(533, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 21);
            this.label10.TabIndex = 45;
            this.label10.Text = "Condition:";
            // 
            // txtDailyHirePrice
            // 
            this.txtDailyHirePrice.Animated = true;
            this.txtDailyHirePrice.BorderColor = System.Drawing.Color.Teal;
            this.txtDailyHirePrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDailyHirePrice.DefaultText = "";
            this.txtDailyHirePrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDailyHirePrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDailyHirePrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDailyHirePrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDailyHirePrice.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtDailyHirePrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDailyHirePrice.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtDailyHirePrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDailyHirePrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDailyHirePrice.Location = new System.Drawing.Point(652, 192);
            this.txtDailyHirePrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDailyHirePrice.Name = "txtDailyHirePrice";
            this.txtDailyHirePrice.PasswordChar = '\0';
            this.txtDailyHirePrice.PlaceholderText = "";
            this.txtDailyHirePrice.SelectedText = "";
            this.txtDailyHirePrice.Size = new System.Drawing.Size(302, 44);
            this.txtDailyHirePrice.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtDailyHirePrice.TabIndex = 44;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(490, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(125, 21);
            this.label9.TabIndex = 43;
            this.label9.Text = "Daily Hire Price:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(532, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Fuel Type:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 339);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 21);
            this.label6.TabIndex = 39;
            this.label6.Text = "Capacity:";
            // 
            // txtColor
            // 
            this.txtColor.Animated = true;
            this.txtColor.BorderColor = System.Drawing.Color.Teal;
            this.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColor.DefaultText = "";
            this.txtColor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtColor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtColor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtColor.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtColor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColor.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtColor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtColor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtColor.Location = new System.Drawing.Point(147, 257);
            this.txtColor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtColor.Name = "txtColor";
            this.txtColor.PasswordChar = '\0';
            this.txtColor.PlaceholderText = "Enter color...";
            this.txtColor.SelectedText = "";
            this.txtColor.Size = new System.Drawing.Size(302, 44);
            this.txtColor.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtColor.TabIndex = 38;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(64, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 21);
            this.label5.TabIndex = 37;
            this.label5.Text = "Color:";
            // 
            // txtYOM
            // 
            this.txtYOM.Animated = true;
            this.txtYOM.BorderColor = System.Drawing.Color.Teal;
            this.txtYOM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYOM.DefaultText = "";
            this.txtYOM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYOM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYOM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYOM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYOM.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtYOM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYOM.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtYOM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtYOM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYOM.Location = new System.Drawing.Point(146, 192);
            this.txtYOM.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtYOM.Name = "txtYOM";
            this.txtYOM.PasswordChar = '\0';
            this.txtYOM.PlaceholderText = "Enter Year of Manufacture...";
            this.txtYOM.SelectedText = "";
            this.txtYOM.Size = new System.Drawing.Size(302, 44);
            this.txtYOM.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtYOM.TabIndex = 36;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 21);
            this.label4.TabIndex = 35;
            this.label4.Text = "YOM:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 142);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 21);
            this.label8.TabIndex = 33;
            this.label8.Text = "Transmission:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 21);
            this.label2.TabIndex = 32;
            this.label2.Text = "Registration:";
            // 
            // txtModel
            // 
            this.txtModel.Animated = true;
            this.txtModel.BackColor = System.Drawing.Color.Transparent;
            this.txtModel.BorderColor = System.Drawing.Color.Teal;
            this.txtModel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtModel.DefaultText = "";
            this.txtModel.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtModel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtModel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModel.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtModel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtModel.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModel.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtModel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtModel.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtModel.Location = new System.Drawing.Point(146, 62);
            this.txtModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtModel.Name = "txtModel";
            this.txtModel.PasswordChar = '\0';
            this.txtModel.PlaceholderText = "Enter model...";
            this.txtModel.SelectedText = "";
            this.txtModel.Size = new System.Drawing.Size(302, 44);
            this.txtModel.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtModel.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 21);
            this.label1.TabIndex = 29;
            this.label1.Text = "Model:";
            // 
            // txtRegistration
            // 
            this.txtRegistration.Animated = true;
            this.txtRegistration.BackColor = System.Drawing.Color.Transparent;
            this.txtRegistration.BorderColor = System.Drawing.Color.Teal;
            this.txtRegistration.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRegistration.DefaultText = "";
            this.txtRegistration.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtRegistration.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtRegistration.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegistration.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtRegistration.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtRegistration.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegistration.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtRegistration.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRegistration.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtRegistration.Location = new System.Drawing.Point(146, 127);
            this.txtRegistration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtRegistration.Name = "txtRegistration";
            this.txtRegistration.PasswordChar = '\0';
            this.txtRegistration.PlaceholderText = "Enter Registration...";
            this.txtRegistration.SelectedText = "";
            this.txtRegistration.Size = new System.Drawing.Size(302, 44);
            this.txtRegistration.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtRegistration.TabIndex = 54;
            // 
            // txtCapacity
            // 
            this.txtCapacity.Animated = true;
            this.txtCapacity.BorderColor = System.Drawing.Color.Teal;
            this.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacity.DefaultText = "";
            this.txtCapacity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCapacity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCapacity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCapacity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCapacity.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCapacity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCapacity.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCapacity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCapacity.Location = new System.Drawing.Point(146, 327);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.PasswordChar = '\0';
            this.txtCapacity.PlaceholderText = "Enter capacity...";
            this.txtCapacity.SelectedText = "";
            this.txtCapacity.Size = new System.Drawing.Size(302, 44);
            this.txtCapacity.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCapacity.TabIndex = 55;
            // 
            // txtTransmission
            // 
            this.txtTransmission.BackColor = System.Drawing.Color.Transparent;
            this.txtTransmission.BorderColor = System.Drawing.Color.Teal;
            this.txtTransmission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtTransmission.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtTransmission.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransmission.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTransmission.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtTransmission.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTransmission.ItemHeight = 30;
            this.txtTransmission.Items.AddRange(new object[] {
            "Automatic",
            "Manual",
            "Cvt",
            "Electric"});
            this.txtTransmission.Location = new System.Drawing.Point(652, 135);
            this.txtTransmission.Name = "txtTransmission";
            this.txtTransmission.Size = new System.Drawing.Size(302, 36);
            this.txtTransmission.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtTransmission.TabIndex = 56;
            // 
            // txtCondition
            // 
            this.txtCondition.BackColor = System.Drawing.Color.Transparent;
            this.txtCondition.BorderColor = System.Drawing.Color.Teal;
            this.txtCondition.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtCondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtCondition.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtCondition.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCondition.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCondition.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtCondition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCondition.ItemHeight = 30;
            this.txtCondition.Items.AddRange(new object[] {
            "BrandNew",
            "VeryGood",
            "Good",
            "Fair",
            "Bad",
            "VeryBad",
            "Damaged"});
            this.txtCondition.Location = new System.Drawing.Point(652, 265);
            this.txtCondition.Name = "txtCondition";
            this.txtCondition.Size = new System.Drawing.Size(302, 36);
            this.txtCondition.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtCondition.TabIndex = 57;
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
            "Available",
            "Unavailable"});
            this.txtStatus.Location = new System.Drawing.Point(146, 404);
            this.txtStatus.Name = "txtStatus";
            this.txtStatus.Size = new System.Drawing.Size(302, 36);
            this.txtStatus.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtStatus.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 419);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 21);
            this.label11.TabIndex = 58;
            this.label11.Text = "Status:";
            // 
            // Frm_Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(973, 455);
            this.Controls.Add(this.txtStatus);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtCondition);
            this.Controls.Add(this.txtTransmission);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.txtRegistration);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.dateAdded);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtDailyHirePrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtYOM);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelDrag);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Vehicle";
            this.Load += new System.EventHandler(this.Frm_Vehicle_Load);
            this.panelDrag.ResumeLayout(false);
            this.panelDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl dragControlForm;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelDrag;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ControlBox exitBtn;
        private Guna.UI2.WinForms.Guna2GradientButton btnCancel;
        private Guna.UI2.WinForms.Guna2GradientButton btnSave;
        private Guna.UI2.WinForms.Guna2ComboBox txtFuelType;
        private Guna.UI2.WinForms.Guna2DateTimePicker dateAdded;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtDailyHirePrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtColor;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtYOM;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtModel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtRegistration;
        private Guna.UI2.WinForms.Guna2TextBox txtCapacity;
        private Guna.UI2.WinForms.Guna2ComboBox txtTransmission;
        private Guna.UI2.WinForms.Guna2ComboBox txtCondition;
        private Guna.UI2.WinForms.Guna2ComboBox txtStatus;
        private System.Windows.Forms.Label label11;
    }
}