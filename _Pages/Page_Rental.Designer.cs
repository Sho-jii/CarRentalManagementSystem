namespace CarRentalManagementSystem._Pages
{
    partial class Page_Rental
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
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.dgvRental = new Guna.UI2.WinForms.Guna2DataGridView();
            this.refreshTable = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.car_rentalDataSet3 = new CarRentalManagementSystem.car_rentalDataSet3();
            this.vehicleRentalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vehicleRentalsTableAdapter = new CarRentalManagementSystem.car_rentalDataSet3TableAdapters.vehicleRentalsTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleModelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionBeforeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conditionAfterDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.returnDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyHirePriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.daysDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damageFeeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateAddedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cancel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rentalDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRentalsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.cmbStatus.BorderThickness = 3;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.cmbStatus.ForeColor = System.Drawing.Color.Black;
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Status (All)",
            "In-Possession",
            "Returned",
            "Lost",
            "Damaged"});
            this.cmbStatus.Location = new System.Drawing.Point(373, 18);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(226, 36);
            this.cmbStatus.StartIndex = 0;
            this.cmbStatus.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbStatus.TabIndex = 71;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
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
            this.txtSearch.Location = new System.Drawing.Point(13, 18);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderText = "Search Client...";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(302, 36);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 69;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // dgvRental
            // 
            this.dgvRental.AllowUserToAddRows = false;
            this.dgvRental.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRental.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRental.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRental.AutoGenerateColumns = false;
            this.dgvRental.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvRental.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRental.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRental.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.vehicleIDDataGridViewTextBoxColumn,
            this.clientIDDataGridViewTextBoxColumn,
            this.rentDateDataGridViewTextBoxColumn,
            this.vehicleModelDataGridViewTextBoxColumn,
            this.clientNameDataGridViewTextBoxColumn,
            this.conditionBeforeDataGridViewTextBoxColumn,
            this.conditionAfterDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.returnDateDataGridViewTextBoxColumn,
            this.dailyHirePriceDataGridViewTextBoxColumn,
            this.daysDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.damageFeeDataGridViewTextBoxColumn,
            this.dateAddedDataGridViewTextBoxColumn,
            this.Cancel});
            this.dgvRental.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvRental.DataSource = this.vehicleRentalsBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRental.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRental.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.dgvRental.Location = new System.Drawing.Point(13, 71);
            this.dgvRental.Name = "dgvRental";
            this.dgvRental.ReadOnly = true;
            this.dgvRental.RowHeadersVisible = false;
            this.dgvRental.RowHeadersWidth = 51;
            dataGridViewCellStyle4.NullValue = "❌";
            this.dgvRental.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvRental.RowTemplate.Height = 24;
            this.dgvRental.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvRental.Size = new System.Drawing.Size(1045, 622);
            this.dgvRental.TabIndex = 67;
            this.dgvRental.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRental.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRental.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRental.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRental.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRental.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvRental.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.dgvRental.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRental.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRental.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRental.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvRental.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvRental.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvRental.ThemeStyle.ReadOnly = true;
            this.dgvRental.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRental.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRental.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvRental.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRental.ThemeStyle.RowsStyle.Height = 24;
            this.dgvRental.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRental.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRental.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRental_CellContentClick);
            this.dgvRental.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvRental_CellFormatting);
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
            this.btnRefresh.Location = new System.Drawing.Point(321, 18);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 36);
            this.btnRefresh.TabIndex = 72;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // car_rentalDataSet3
            // 
            this.car_rentalDataSet3.DataSetName = "car_rentalDataSet3";
            this.car_rentalDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehicleRentalsBindingSource
            // 
            this.vehicleRentalsBindingSource.DataMember = "vehicleRentals";
            this.vehicleRentalsBindingSource.DataSource = this.car_rentalDataSet3;
            // 
            // vehicleRentalsTableAdapter
            // 
            this.vehicleRentalsTableAdapter.ClearBeforeFill = true;
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
            // conditionAfterDataGridViewTextBoxColumn
            // 
            this.conditionAfterDataGridViewTextBoxColumn.DataPropertyName = "ConditionAfter";
            this.conditionAfterDataGridViewTextBoxColumn.HeaderText = "ConditionAfter";
            this.conditionAfterDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.conditionAfterDataGridViewTextBoxColumn.Name = "conditionAfterDataGridViewTextBoxColumn";
            this.conditionAfterDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // returnDateDataGridViewTextBoxColumn
            // 
            this.returnDateDataGridViewTextBoxColumn.DataPropertyName = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.HeaderText = "ReturnDate";
            this.returnDateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.returnDateDataGridViewTextBoxColumn.Name = "returnDateDataGridViewTextBoxColumn";
            this.returnDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // damageFeeDataGridViewTextBoxColumn
            // 
            this.damageFeeDataGridViewTextBoxColumn.DataPropertyName = "DamageFee";
            this.damageFeeDataGridViewTextBoxColumn.HeaderText = "DamageFee";
            this.damageFeeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.damageFeeDataGridViewTextBoxColumn.Name = "damageFeeDataGridViewTextBoxColumn";
            this.damageFeeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateAddedDataGridViewTextBoxColumn
            // 
            this.dateAddedDataGridViewTextBoxColumn.DataPropertyName = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.HeaderText = "DateAdded";
            this.dateAddedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateAddedDataGridViewTextBoxColumn.Name = "dateAddedDataGridViewTextBoxColumn";
            this.dateAddedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Cancel
            // 
            this.Cancel.HeaderText = "Cancel";
            this.Cancel.MinimumWidth = 6;
            this.Cancel.Name = "Cancel";
            this.Cancel.ReadOnly = true;
            // 
            // Page_Rental
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvRental);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.Name = "Page_Rental";
            this.Size = new System.Drawing.Size(1071, 710);
            this.Load += new System.EventHandler(this.Page_Rental_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRental)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rentalDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleRentalsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRental;
        private System.Windows.Forms.Timer refreshTable;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleModelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionBeforeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn conditionAfterDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn returnDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyHirePriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn daysDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damageFeeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateAddedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cancel;
        private System.Windows.Forms.BindingSource vehicleRentalsBindingSource;
        private car_rentalDataSet3 car_rentalDataSet3;
        private car_rentalDataSet3TableAdapters.vehicleRentalsTableAdapter vehicleRentalsTableAdapter;
    }
}
