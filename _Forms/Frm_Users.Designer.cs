namespace CarRentalManagementSystem._Forms
{
    partial class Frm_Users
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Users));
            this.panelDrag = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.exitBtn = new Guna.UI2.WinForms.Guna2ControlBox();
            this.borderlessForm = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.dragControlForm = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.btnCancel = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btnSave = new Guna.UI2.WinForms.Guna2GradientButton();
            this.cmbStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
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
            this.guna2PictureBox1.Image = global::CarRentalManagementSystem.Properties.Resources.user_2_;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(9, 1);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(48, 59);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
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
            this.label3.Location = new System.Drawing.Point(58, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Users";
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
            this.btnCancel.Location = new System.Drawing.Point(293, 313);
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
            this.btnSave.Location = new System.Drawing.Point(397, 313);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 45);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cmbStatus
            // 
            this.cmbStatus.BackColor = System.Drawing.Color.Transparent;
            this.cmbStatus.BorderColor = System.Drawing.Color.Teal;
            this.cmbStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.FillColor = System.Drawing.Color.WhiteSmoke;
            this.cmbStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbStatus.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cmbStatus.ItemHeight = 30;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Inactive"});
            this.cmbStatus.Location = new System.Drawing.Point(193, 243);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(302, 36);
            this.cmbStatus.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.cmbStatus.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 21);
            this.label2.TabIndex = 39;
            this.label2.Text = "Password:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(75, 103);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(88, 21);
            this.label12.TabIndex = 37;
            this.label12.Text = "Username:";
            // 
            // txtPassword
            // 
            this.txtPassword.Animated = true;
            this.txtPassword.BorderColor = System.Drawing.Color.Teal;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(193, 168);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(302, 44);
            this.txtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtPassword.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(103, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 21);
            this.label11.TabIndex = 35;
            this.label11.Text = "Status:";
            // 
            // txtUsername
            // 
            this.txtUsername.Animated = true;
            this.txtUsername.BorderColor = System.Drawing.Color.Teal;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FillColor = System.Drawing.Color.WhiteSmoke;
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F);
            this.txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(193, 80);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderText = "";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(302, 44);
            this.txtUsername.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtUsername.TabIndex = 43;
            // 
            // Frm_Users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(554, 380);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.panelDrag);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label11);
            this.Font = new System.Drawing.Font("Franklin Gothic Medium", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Frm_Users";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_Users";
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
        private Guna.UI2.WinForms.Guna2ComboBox cmbStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2DragControl dragControlForm;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
    }
}