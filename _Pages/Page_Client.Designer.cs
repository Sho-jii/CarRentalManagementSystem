namespace CarRentalManagementSystem._Pages
{
    partial class Page_Client
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvClient = new Guna.UI2.WinForms.Guna2DataGridView();
            this.clientIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genderDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ordersDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inPossessionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.damagedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientProfilesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.car_rentalDataSet1 = new CarRentalManagementSystem.car_rentalDataSet1();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmbGender = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2GradientButton();
            this.clientProfilesTableAdapter = new CarRentalManagementSystem.car_rentalDataSet1TableAdapters.clientProfilesTableAdapter();
            this.refreshTable = new System.Windows.Forms.Timer(this.components);
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientProfilesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rentalDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dgvClient.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvClient.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvClient.AutoGenerateColumns = false;
            this.dgvClient.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClient.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clientIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.genderDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.ordersDataGridViewTextBoxColumn,
            this.inPossessionDataGridViewTextBoxColumn,
            this.damagedDataGridViewTextBoxColumn,
            this.lostDataGridViewTextBoxColumn,
            this.spentDataGridViewTextBoxColumn,
            this.Edit,
            this.Delete});
            this.dgvClient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvClient.DataSource = this.clientProfilesBindingSource;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.dgvClient.Location = new System.Drawing.Point(13, 74);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.RowHeadersVisible = false;
            this.dgvClient.RowHeadersWidth = 51;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClient.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClient.RowTemplate.Height = 24;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvClient.Size = new System.Drawing.Size(1045, 622);
            this.dgvClient.TabIndex = 5;
            this.dgvClient.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClient.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvClient.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvClient.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvClient.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvClient.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.dgvClient.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.dgvClient.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvClient.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvClient.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClient.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvClient.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvClient.ThemeStyle.HeaderStyle.Height = 23;
            this.dgvClient.ThemeStyle.ReadOnly = true;
            this.dgvClient.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvClient.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvClient.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvClient.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClient.ThemeStyle.RowsStyle.Height = 24;
            this.dgvClient.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvClient.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellContentClick);
            this.dgvClient.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvClient_CellFormatting);
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // genderDataGridViewTextBoxColumn
            // 
            this.genderDataGridViewTextBoxColumn.DataPropertyName = "Gender";
            this.genderDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.genderDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genderDataGridViewTextBoxColumn.Name = "genderDataGridViewTextBoxColumn";
            this.genderDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            this.phoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            this.addressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ordersDataGridViewTextBoxColumn
            // 
            this.ordersDataGridViewTextBoxColumn.DataPropertyName = "Orders";
            this.ordersDataGridViewTextBoxColumn.HeaderText = "Orders";
            this.ordersDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ordersDataGridViewTextBoxColumn.Name = "ordersDataGridViewTextBoxColumn";
            this.ordersDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // inPossessionDataGridViewTextBoxColumn
            // 
            this.inPossessionDataGridViewTextBoxColumn.DataPropertyName = "In_Possession";
            this.inPossessionDataGridViewTextBoxColumn.HeaderText = "In_Possession";
            this.inPossessionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.inPossessionDataGridViewTextBoxColumn.Name = "inPossessionDataGridViewTextBoxColumn";
            this.inPossessionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // damagedDataGridViewTextBoxColumn
            // 
            this.damagedDataGridViewTextBoxColumn.DataPropertyName = "Damaged";
            this.damagedDataGridViewTextBoxColumn.HeaderText = "Damaged";
            this.damagedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.damagedDataGridViewTextBoxColumn.Name = "damagedDataGridViewTextBoxColumn";
            this.damagedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // lostDataGridViewTextBoxColumn
            // 
            this.lostDataGridViewTextBoxColumn.DataPropertyName = "Lost";
            this.lostDataGridViewTextBoxColumn.HeaderText = "Lost";
            this.lostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lostDataGridViewTextBoxColumn.Name = "lostDataGridViewTextBoxColumn";
            this.lostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // spentDataGridViewTextBoxColumn
            // 
            this.spentDataGridViewTextBoxColumn.DataPropertyName = "Spent";
            this.spentDataGridViewTextBoxColumn.HeaderText = "Spent";
            this.spentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.spentDataGridViewTextBoxColumn.Name = "spentDataGridViewTextBoxColumn";
            this.spentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // Edit
            // 
            this.Edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Edit.HeaderText = "Edit";
            this.Edit.MinimumWidth = 6;
            this.Edit.Name = "Edit";
            this.Edit.ReadOnly = true;
            this.Edit.Width = 64;
            // 
            // Delete
            // 
            this.Delete.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Delete.HeaderText = "Delete";
            this.Delete.MinimumWidth = 6;
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Width = 84;
            // 
            // clientProfilesBindingSource
            // 
            this.clientProfilesBindingSource.DataMember = "clientProfiles";
            this.clientProfilesBindingSource.DataSource = this.car_rentalDataSet1;
            // 
            // car_rentalDataSet1
            // 
            this.car_rentalDataSet1.DataSetName = "car_rentalDataSet1";
            this.car_rentalDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.txtSearch.TabIndex = 64;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // cmbGender
            // 
            this.cmbGender.BackColor = System.Drawing.Color.Transparent;
            this.cmbGender.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(172)))), ((int)(((byte)(65)))));
            this.cmbGender.BorderThickness = 3;
            this.cmbGender.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbGender.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGender.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbGender.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.cmbGender.ForeColor = System.Drawing.Color.Black;
            this.cmbGender.ItemHeight = 30;
            this.cmbGender.Items.AddRange(new object[] {
            "Gender (All)",
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(375, 21);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(226, 36);
            this.cmbGender.StartIndex = 0;
            this.cmbGender.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbGender.TabIndex = 66;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
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
            this.btnAdd.TabIndex = 67;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // clientProfilesTableAdapter
            // 
            this.clientProfilesTableAdapter.ClearBeforeFill = true;
            // 
            // refreshTable
            // 
            this.refreshTable.Tick += new System.EventHandler(this.refreshTable_Tick);
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
            this.btnRefresh.Location = new System.Drawing.Point(323, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(46, 36);
            this.btnRefresh.TabIndex = 73;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Page_Client
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbGender);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvClient);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.Name = "Page_Client";
            this.Size = new System.Drawing.Size(1071, 710);
            this.Load += new System.EventHandler(this.Page_Client_Load);
            this.Leave += new System.EventHandler(this.Page_Client_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientProfilesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.car_rentalDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DataGridView dgvClient;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmbGender;
        private Guna.UI2.WinForms.Guna2GradientButton btnAdd;
        private System.Windows.Forms.BindingSource clientProfilesBindingSource;
        private car_rentalDataSet1 car_rentalDataSet1;
        private car_rentalDataSet1TableAdapters.clientProfilesTableAdapter clientProfilesTableAdapter;
        private System.Windows.Forms.Timer refreshTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genderDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ordersDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inPossessionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn damagedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Delete;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}
