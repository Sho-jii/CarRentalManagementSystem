namespace CarRentalManagementSystem._Pages
{
    partial class Page_Vehicle
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

        #region Component Designer generated code

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
            this.dgvVehicles = new Guna.UI2.WinForms.Guna2DataGridView();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yOMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fuelTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transmissionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyHirePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleInventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_rentalDataSet1 = new CarRentalManagementSystem.car_rentalDataSet1();
            this.vehicleInventoryTableAdapter = new CarRentalManagementSystem.car_rentalDataSet1TableAdapters.vehicleInventoryTableAdapter();
            this.cmbTransmission = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.refreshTable = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleInventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rentalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVehicles
            // 
            this.dgvVehicles.AllowUserToAddRows = false;
            this.dgvVehicles.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvVehicles.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVehicles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVehicles.AutoGenerateColumns = false;
            this.dgvVehicles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvVehicles.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvVehicles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleIDDataGridViewTextBoxColumn,
            this.modelDataGridViewTextBoxColumn,
            this.registrationDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.yOMDataGridViewTextBoxColumn,
            this.colorDataGridViewTextBoxColumn,
            this.capacityDataGridViewTextBoxColumn,
            this.fuelTypeDataGridViewTextBoxColumn,
            this.transmissionDataGridViewTextBoxColumn,
            this.dailyHirePriceDataGridViewTextBoxColumn,
            this.conditionDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dgvVehicles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvVehicles.DataSource = this.vehicleInventoryBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvVehicles.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvVehicles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.dgvVehicles.Location = new System.Drawing.Point(13, 74);
            this.dgvVehicles.Name = "dgvVehicles";
            this.dgvVehicles.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVehicles.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvVehicles.RowHeadersVisible = false;
            this.dgvVehicles.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVehicles.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvVehicles.RowTemplate.Height = 24;
            this.dgvVehicles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVehicles.Size = new System.Drawing.Size(1045, 622);
            this.dgvVehicles.TabIndex = 4;
            this.dgvVehicles.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehicles.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvVehicles.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvVehicles.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvVehicles.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvVehicles.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvVehicles.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.dgvVehicles.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvVehicles.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvVehicles.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.dgvVehicles.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvVehicles.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVehicles.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvVehicles.ThemeStyle.ReadOnly = true;
            this.dgvVehicles.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvVehicles.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvVehicles.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.dgvVehicles.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVehicles.ThemeStyle.RowsStyle.Height = 24;
            this.dgvVehicles.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvVehicles.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvVehicles.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehicles_CellContentClick);
            this.dgvVehicles.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvVehicles_CellFormatting);
            // 
            // vehicleIDDataGridViewTextBoxColumn
            // 
            this.vehicleIDDataGridViewTextBoxColumn.DataPropertyName = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.vehicleIDDataGridViewTextBoxColumn.HeaderText = "VehicleID";
            this.vehicleIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.vehicleIDDataGridViewTextBoxColumn.Name = "vehicleIDDataGridViewTextBoxColumn";
            this.vehicleIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.vehicleIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // modelDataGridViewTextBoxColumn
            // 
            this.modelDataGridViewTextBoxColumn.DataPropertyName = "Model";
            this.modelDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.modelDataGridViewTextBoxColumn.HeaderText = "Model";
            this.modelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelDataGridViewTextBoxColumn.Name = "modelDataGridViewTextBoxColumn";
            this.modelDataGridViewTextBoxColumn.ReadOnly = true;
            this.modelDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // registrationDataGridViewTextBoxColumn
            // 
            this.registrationDataGridViewTextBoxColumn.DataPropertyName = "Registration";
            this.registrationDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.registrationDataGridViewTextBoxColumn.HeaderText = "Registration";
            this.registrationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.registrationDataGridViewTextBoxColumn.Name = "registrationDataGridViewTextBoxColumn";
            this.registrationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yOMDataGridViewTextBoxColumn
            // 
            this.yOMDataGridViewTextBoxColumn.DataPropertyName = "YOM";
            this.yOMDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.yOMDataGridViewTextBoxColumn.HeaderText = "YOM";
            this.yOMDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.yOMDataGridViewTextBoxColumn.Name = "yOMDataGridViewTextBoxColumn";
            this.yOMDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // colorDataGridViewTextBoxColumn
            // 
            this.colorDataGridViewTextBoxColumn.DataPropertyName = "Color";
            this.colorDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.colorDataGridViewTextBoxColumn.HeaderText = "Color";
            this.colorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.colorDataGridViewTextBoxColumn.Name = "colorDataGridViewTextBoxColumn";
            this.colorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // capacityDataGridViewTextBoxColumn
            // 
            this.capacityDataGridViewTextBoxColumn.DataPropertyName = "Capacity";
            this.capacityDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.capacityDataGridViewTextBoxColumn.HeaderText = "Capacity";
            this.capacityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.capacityDataGridViewTextBoxColumn.Name = "capacityDataGridViewTextBoxColumn";
            this.capacityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fuelTypeDataGridViewTextBoxColumn
            // 
            this.fuelTypeDataGridViewTextBoxColumn.DataPropertyName = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.fuelTypeDataGridViewTextBoxColumn.HeaderText = "FuelType";
            this.fuelTypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fuelTypeDataGridViewTextBoxColumn.Name = "fuelTypeDataGridViewTextBoxColumn";
            this.fuelTypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // transmissionDataGridViewTextBoxColumn
            // 
            this.transmissionDataGridViewTextBoxColumn.DataPropertyName = "Transmission";
            this.transmissionDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.transmissionDataGridViewTextBoxColumn.HeaderText = "Transmission";
            this.transmissionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.transmissionDataGridViewTextBoxColumn.Name = "transmissionDataGridViewTextBoxColumn";
            this.transmissionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dailyHirePriceDataGridViewTextBoxColumn
            // 
            this.dailyHirePriceDataGridViewTextBoxColumn.DataPropertyName = "DailyHirePrice";
            this.dailyHirePriceDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.dailyHirePriceDataGridViewTextBoxColumn.HeaderText = "DailyHirePrice";
            this.dailyHirePriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dailyHirePriceDataGridViewTextBoxColumn.Name = "dailyHirePriceDataGridViewTextBoxColumn";
            this.dailyHirePriceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // conditionDataGridViewTextBoxColumn
            // 
            this.conditionDataGridViewTextBoxColumn.DataPropertyName = "Condition";
            this.conditionDataGridViewTextBoxColumn.FillWeight = 53.67039F;
            this.conditionDataGridViewTextBoxColumn.HeaderText = "Condition";
            this.conditionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conditionDataGridViewTextBoxColumn.Name = "conditionDataGridViewTextBoxColumn";
            this.conditionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            this.dateAddedDataGridViewTextBoxColumn.Visible = false;
            this.dateAddedDataGridViewTextBoxColumn.Width = 150;
            // 
            // Edit
            // 
            this.Edit.FillWeight = 53.67039F;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FillWeight = 53.67039F;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            // 
            // vehicleInventoryBindingSource
            // 
            this.vehicleInventoryBindingSource.DataMember = "vehicleInventory";
            this.vehicleInventoryBindingSource.DataSource = this.car_rentalDataSet1;
            // 
            // car_rentalDataSet1
            // 
            this.car_rentalDataSet1.DataSetName = "car_rentalDataSet1";
            this.car_rentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleInventoryTableAdapter
            // 
            this.vehicleInventoryTableAdapter.ClearBeforeFill = true;
            // 
            // cmbTransmission
            // 
            this.cmbTransmission.BackColor = System.Drawing.Color.Transparent;
            this.cmbTransmission.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.cmbTransmission.BorderThickness = 3;
            this.cmbTransmission.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbTransmission.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTransmission.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbTransmission.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTransmission.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbTransmission.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.cmbTransmission.ForeColor = System.Drawing.Color.Black;
            this.cmbTransmission.ItemHeight = 30;
            this.cmbTransmission.Items.AddRange(new object[] {
            "Transmission (All)",
            "Automatic",
            "Manual",
            "CVT",
            "Electric"});
            this.cmbTransmission.Location = new System.Drawing.Point(373, 21);
            this.cmbTransmission.Name = "cmbTransmission";
            this.cmbTransmission.Size = new System.Drawing.Size(226, 36);
            this.cmbTransmission.StartIndex = 0;
            this.cmbTransmission.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbTransmission.TabIndex = 58;
            this.cmbTransmission.SelectedIndexChanged += new System.EventHandler(this.cmbTransmission_SelectedIndexChanged);
            // 
            // txtSearch
            // 
            this.txtSearch.Animated = true;
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.txtSearch.BorderRadius = 2;
            this.txtSearch.BorderThickness = 3;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(13, 21);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(302, 36);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 60;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Animated = true;
            this.btnAdd.BorderColor = System.Drawing.Color.Transparent;
            this.btnAdd.BorderRadius = 2;
            this.btnAdd.BorderThickness = 2;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.btnAdd.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.btnAdd.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 12F);
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.btnAdd.Location = new System.Drawing.Point(944, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(114, 36);
            this.btnAdd.TabIndex = 61;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
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
            this.btnRefresh.Location = new System.Drawing.Point(321, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 36);
            this.btnRefresh.TabIndex = 73;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Page_Vehicle
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.cmbTransmission);
            this.Controls.Add(this.dgvVehicles);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.Name = "Page_Vehicle";
            this.Size = new System.Drawing.Size(1071, 710);
            this.Load += new System.EventHandler(this.Page_Vehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehicles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleInventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rentalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView dgvVehicles;
        private System.Windows.Forms.BindingSource vehicleInventoryBindingSource;
        private car_rentalDataSet1 car_rentalDataSet1;
        private car_rentalDataSet1TableAdapters.vehicleInventoryTableAdapter vehicleInventoryTableAdapter;
        private Guna.UI2.WinForms.Guna2ComboBox cmbTransmission;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yOMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn colorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fuelTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn transmissionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyHirePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
        private System.Windows.Forms.Timer refreshTable;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
