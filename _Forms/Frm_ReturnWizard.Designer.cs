namespace CarRentalManagementSystem._Forms
{
    partial class Frm_ReturnWizard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ReturnWizard));
            this.dragControlForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelDrag = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.btnReturn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtSearchVehicle = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.dgvRentals = new Guna.UI2.WinForms.Guna2DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionBeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyHirePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleRentalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_rentalDataSet = new CarRentalManagementSystem.car_rentalDataSet();
            this.refreshTable = new System.Windows.Forms.Timer(this.components);
            this.vehicleRentalsTableAdapter = new CarRentalManagementSystem.car_rentalDataSetTableAdapters.vehicleRentalsTableAdapter();
            this.panelDrag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRentalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rentalDataSet)).BeginInit();
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
            this.panelDrag.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.panelDrag.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.panelDrag.FillColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.panelDrag.FillColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.panelDrag.Location = new System.Drawing.Point(0, 0);
            this.panelDrag.Name = "panelDrag";
            this.panelDrag.Size = new System.Drawing.Size(1094, 42);
            this.panelDrag.TabIndex = 7;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = global::CarRentalManagementSystem.Properties.Resources.Logo;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(4, -4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(54, 50);
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
            this.label3.Location = new System.Drawing.Point(61, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Return Vehicle";
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.FillColor = System.Drawing.Color.Transparent;
            this.exitBtn.IconColor = System.Drawing.Color.Black;
            this.exitBtn.Location = new System.Drawing.Point(1044, 4);
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
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReturn.Animated = true;
            this.btnReturn.BorderColor = System.Drawing.Color.Transparent;
            this.btnReturn.BorderRadius = 2;
            this.btnReturn.BorderThickness = 2;
            this.btnReturn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnReturn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnReturn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnReturn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.btnReturn.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.btnReturn.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.btnReturn.ForeColor = System.Drawing.Color.Black;
            this.btnReturn.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnReturn.Location = new System.Drawing.Point(880, 431);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(202, 36);
            this.btnReturn.TabIndex = 77;
            this.btnReturn.Text = "✔ RETURN VEHICLE";
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // txtSearchVehicle
            // 
            this.txtSearchVehicle.Animated = true;
            this.txtSearchVehicle.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchVehicle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.txtSearchVehicle.BorderRadius = 2;
            this.txtSearchVehicle.BorderThickness = 3;
            this.txtSearchVehicle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchVehicle.DefaultText = "";
            this.txtSearchVehicle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchVehicle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchVehicle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchVehicle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchVehicle.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearchVehicle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchVehicle.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtSearchVehicle.ForeColor = System.Drawing.Color.Black;
            this.txtSearchVehicle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchVehicle.Location = new System.Drawing.Point(9, 61);
            this.txtSearchVehicle.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearchVehicle.Name = "txtSearchVehicle";
            this.txtSearchVehicle.PasswordChar = '\0';
            this.txtSearchVehicle.PlaceholderText = "Search...";
            this.txtSearchVehicle.SelectedText = "";
            this.txtSearchVehicle.Size = new System.Drawing.Size(302, 36);
            this.txtSearchVehicle.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearchVehicle.TabIndex = 80;
            this.txtSearchVehicle.TextChanged += new System.EventHandler(this.txtSearchVehicle_TextChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Animated = true;
            this.btnRefresh.BackColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderColor = System.Drawing.Color.Transparent;
            this.btnRefresh.BorderRadius = 1;
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = global::CarRentalManagementSystem.Properties.Resources.refresh;
            this.btnRefresh.Location = new System.Drawing.Point(317, 61);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 36);
            this.btnRefresh.TabIndex = 79;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRentals.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRentals.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRentals.AutoGenerateColumns = false;
            this.dgvRentals.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRentals.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentals.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRentals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.conditionAfterDataGridViewTextBoxColumn,
            this.rentDateDataGridViewTextBoxColumn,
            this.vehicleModelDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.conditionBeforeDataGridViewTextBoxColumn,
            this.dailyHirePriceDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn});
            this.dgvRentals.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRentals.DataSource = this.vehicleRentalsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRentals.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRentals.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.dgvRentals.Location = new System.Drawing.Point(0, 113);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRentals.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRentals.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvRentals.RowTemplate.Height = 24;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRentals.Size = new System.Drawing.Size(1094, 304);
            this.dgvRentals.TabIndex = 78;
            this.dgvRentals.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRentals.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRentals.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRentals.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRentals.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRentals.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRentals.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.dgvRentals.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRentals.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRentals.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.dgvRentals.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRentals.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRentals.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvRentals.ThemeStyle.ReadOnly = true;
            this.dgvRentals.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRentals.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRentals.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.dgvRentals.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRentals.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRentals.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRentals.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRentals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRentals_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            this.idDataGridViewTextBoxColumn.Visible = false;
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // clientIDDataGridViewTextBoxColumn
            // 
            this.clientIDDataGridViewTextBoxColumn.DataPropertyName = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.HeaderText = "ClientID";
            this.clientIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientIDDataGridViewTextBoxColumn.Name = "clientIDDataGridViewTextBoxColumn";
            this.clientIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.clientIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // conditionAfterDataGridViewTextBoxColumn
            // 
            this.conditionAfterDataGridViewTextBoxColumn.DataPropertyName = "ConditionAfter";
            this.conditionAfterDataGridViewTextBoxColumn.HeaderText = "ConditionAfter";
            this.conditionAfterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conditionAfterDataGridViewTextBoxColumn.Name = "conditionAfterDataGridViewTextBoxColumn";
            this.conditionAfterDataGridViewTextBoxColumn.ReadOnly = true;
            this.conditionAfterDataGridViewTextBoxColumn.Visible = false;
            // 
            // rentDateDataGridViewTextBoxColumn
            // 
            this.rentDateDataGridViewTextBoxColumn.DataPropertyName = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.HeaderText = "RentDate";
            this.rentDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rentDateDataGridViewTextBoxColumn.Name = "rentDateDataGridViewTextBoxColumn";
            this.rentDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vehicleModelDataGridViewTextBoxColumn
            // 
            this.vehicleModelDataGridViewTextBoxColumn.DataPropertyName = "VehicleModel";
            this.vehicleModelDataGridViewTextBoxColumn.HeaderText = "VehicleModel";
            this.vehicleModelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleModelDataGridViewTextBoxColumn.Name = "vehicleModelDataGridViewTextBoxColumn";
            this.vehicleModelDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // clientNameDataGridViewTextBoxColumn
            // 
            this.clientNameDataGridViewTextBoxColumn.DataPropertyName = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.HeaderText = "ClientName";
            this.clientNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.clientNameDataGridViewTextBoxColumn.Name = "clientNameDataGridViewTextBoxColumn";
            this.clientNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionBeforeDataGridViewTextBoxColumn
            // 
            this.conditionBeforeDataGridViewTextBoxColumn.DataPropertyName = "ConditionBefore";
            this.conditionBeforeDataGridViewTextBoxColumn.HeaderText = "ConditionBefore";
            this.conditionBeforeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conditionBeforeDataGridViewTextBoxColumn.Name = "conditionBeforeDataGridViewTextBoxColumn";
            this.conditionBeforeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dailyHirePriceDataGridViewTextBoxColumn
            // 
            this.dailyHirePriceDataGridViewTextBoxColumn.DataPropertyName = "DailyHirePrice";
            this.dailyHirePriceDataGridViewTextBoxColumn.HeaderText = "DailyHirePrice";
            this.dailyHirePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dailyHirePriceDataGridViewTextBoxColumn.Name = "dailyHirePriceDataGridViewTextBoxColumn";
            this.dailyHirePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // daysDataGridViewTextBoxColumn
            // 
            this.daysDataGridViewTextBoxColumn.DataPropertyName = "Days";
            this.daysDataGridViewTextBoxColumn.HeaderText = "Days";
            this.daysDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.daysDataGridViewTextBoxColumn.Name = "daysDataGridViewTextBoxColumn";
            this.daysDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            this.statusDataGridViewTextBoxColumn.Visible = false;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.ReadOnly = true;
            this.returnDateDataGridViewTextBoxColumn.Visible = false;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAddedDataGridViewTextBoxColumn.Visible = false;
            // 
            // vehicleRentalsBindingSource
            // 
            this.vehicleRentalsBindingSource.DataMember = "vehicleRentals";
            this.vehicleRentalsBindingSource.DataSource = this.car_rentalDataSet;
            // 
            // car_rentalDataSet
            // 
            this.car_rentalDataSet.DataSetName = "car_rentalDataSet";
            this.car_rentalDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleRentalsTableAdapter
            // 
            this.vehicleRentalsTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_ReturnWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(1094, 479);
            this.Controls.Add(this.txtSearchVehicle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.panelDrag);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_ReturnWizard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_ReturnWizard";
            this.Load += new System.EventHandler(this.Frm_ReturnWizard_Load);
            this.panelDrag.ResumeLayout(false);
            this.panelDrag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRentalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rentalDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl dragControlForm;
        private Guna.UI2.WinForms.Guna2BorderlessForm borderlessForm;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel panelDrag;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ControlBox exitBtn;
        private Guna.UI2.WinForms.Guna2GradientButton btnReturn;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchVehicle;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRentals;
        private System.Windows.Forms.Timer refreshTable;
        private car_rentalDataSet car_rentalDataSet;
        private System.Windows.Forms.BindingSource vehicleRentalsBindingSource;
        private car_rentalDataSetTableAdapters.vehicleRentalsTableAdapter vehicleRentalsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionBeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyHirePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
    }
}