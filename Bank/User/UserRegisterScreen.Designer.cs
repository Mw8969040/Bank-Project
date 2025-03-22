namespace Bank
{
    partial class UserRegisterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserRegisterScreen));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.ControlBox = new Guna.UI2.WinForms.Guna2ControlBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.DataViewRegister = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PictureRegister_User = new System.Windows.Forms.PictureBox();
            this.ButtomPanel = new System.Windows.Forms.Panel();
            this.panelFilter = new System.Windows.Forms.Panel();
            this.radioDateTime = new System.Windows.Forms.RadioButton();
            this.radioUser_ID = new System.Windows.Forms.RadioButton();
            this.Filter = new Guna.UI2.WinForms.Guna2Button();
            this.FilterTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.CBUserID = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.CountOfRows = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRegister)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRegister_User)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TopPanel.Controls.Add(this.ControlBox);
            this.TopPanel.Controls.Add(this.lblUser);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(625, 65);
            this.TopPanel.TabIndex = 60;
            // 
            // ControlBox
            // 
            this.ControlBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox.Animated = true;
            this.ControlBox.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ControlBox.BorderRadius = 5;
            this.ControlBox.FillColor = System.Drawing.Color.Black;
            this.ControlBox.HoverState.FillColor = System.Drawing.Color.Red;
            this.ControlBox.IconColor = System.Drawing.Color.White;
            this.ControlBox.Location = new System.Drawing.Point(590, 4);
            this.ControlBox.Name = "ControlBox";
            this.ControlBox.Size = new System.Drawing.Size(32, 29);
            this.ControlBox.TabIndex = 64;
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Segoe UI Semibold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(141, 8);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(332, 45);
            this.lblUser.TabIndex = 50;
            this.lblUser.Text = "Register_User  Screen";
            // 
            // DataViewRegister
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.DataViewRegister.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataViewRegister.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataViewRegister.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.DataViewRegister.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableWithoutHeaderText;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataViewRegister.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataViewRegister.ColumnHeadersHeight = 30;
            this.DataViewRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataViewRegister.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataViewRegister.GridColor = System.Drawing.Color.DarkGray;
            this.DataViewRegister.Location = new System.Drawing.Point(81, 352);
            this.DataViewRegister.Name = "DataViewRegister";
            this.DataViewRegister.ReadOnly = true;
            this.DataViewRegister.RowHeadersVisible = false;
            this.DataViewRegister.Size = new System.Drawing.Size(455, 274);
            this.DataViewRegister.TabIndex = 79;
            this.DataViewRegister.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewRegister.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DataViewRegister.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DataViewRegister.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DataViewRegister.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DataViewRegister.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.DataViewRegister.ThemeStyle.GridColor = System.Drawing.Color.DarkGray;
            this.DataViewRegister.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.DataViewRegister.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataViewRegister.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewRegister.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DataViewRegister.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DataViewRegister.ThemeStyle.HeaderStyle.Height = 30;
            this.DataViewRegister.ThemeStyle.ReadOnly = true;
            this.DataViewRegister.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DataViewRegister.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DataViewRegister.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataViewRegister.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.DataViewRegister.ThemeStyle.RowsStyle.Height = 22;
            this.DataViewRegister.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.DataViewRegister.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // PictureRegister_User
            // 
            this.PictureRegister_User.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureRegister_User.Image = ((System.Drawing.Image)(resources.GetObject("PictureRegister_User.Image")));
            this.PictureRegister_User.Location = new System.Drawing.Point(194, 90);
            this.PictureRegister_User.Name = "PictureRegister_User";
            this.PictureRegister_User.Size = new System.Drawing.Size(217, 175);
            this.PictureRegister_User.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureRegister_User.TabIndex = 80;
            this.PictureRegister_User.TabStop = false;
            // 
            // ButtomPanel
            // 
            this.ButtomPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ButtomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ButtomPanel.Location = new System.Drawing.Point(0, 632);
            this.ButtomPanel.Name = "ButtomPanel";
            this.ButtomPanel.Size = new System.Drawing.Size(625, 33);
            this.ButtomPanel.TabIndex = 81;
            // 
            // panelFilter
            // 
            this.panelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelFilter.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panelFilter.Controls.Add(this.radioDateTime);
            this.panelFilter.Controls.Add(this.radioUser_ID);
            this.panelFilter.Location = new System.Drawing.Point(93, 228);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(90, 69);
            this.panelFilter.TabIndex = 82;
            this.panelFilter.Visible = false;
            // 
            // radioDateTime
            // 
            this.radioDateTime.AutoSize = true;
            this.radioDateTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDateTime.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioDateTime.Location = new System.Drawing.Point(6, 43);
            this.radioDateTime.Name = "radioDateTime";
            this.radioDateTime.Size = new System.Drawing.Size(79, 17);
            this.radioDateTime.TabIndex = 3;
            this.radioDateTime.Tag = "DD/MM/YYYY";
            this.radioDateTime.Text = "DateTime";
            this.radioDateTime.UseVisualStyleBackColor = true;
            this.radioDateTime.CheckedChanged += new System.EventHandler(this.radioDateTime_CheckedChanged);
            // 
            // radioUser_ID
            // 
            this.radioUser_ID.AutoSize = true;
            this.radioUser_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioUser_ID.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.radioUser_ID.Location = new System.Drawing.Point(6, 10);
            this.radioUser_ID.Name = "radioUser_ID";
            this.radioUser_ID.Size = new System.Drawing.Size(64, 17);
            this.radioUser_ID.TabIndex = 2;
            this.radioUser_ID.Tag = "UserID";
            this.radioUser_ID.Text = "UserID";
            this.radioUser_ID.UseVisualStyleBackColor = true;
            this.radioUser_ID.CheckedChanged += new System.EventHandler(this.radioUser_ID_CheckedChanged);
            // 
            // Filter
            // 
            this.Filter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Filter.Animated = true;
            this.Filter.AutoRoundedCorners = true;
            this.Filter.BorderRadius = 16;
            this.Filter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Filter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Filter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Filter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Filter.FillColor = System.Drawing.SystemColors.Desktop;
            this.Filter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Filter.ForeColor = System.Drawing.Color.White;
            this.Filter.Image = ((System.Drawing.Image)(resources.GetObject("Filter.Image")));
            this.Filter.Location = new System.Drawing.Point(221, 310);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(42, 34);
            this.Filter.TabIndex = 84;
            this.Filter.Tag = "1";
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FilterTextBox.AutoRoundedCorners = true;
            this.FilterTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.FilterTextBox.BorderRadius = 17;
            this.FilterTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FilterTextBox.DefaultText = "";
            this.FilterTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.FilterTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.FilterTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FilterTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.FilterTextBox.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FilterTextBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FilterTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.FilterTextBox.Location = new System.Drawing.Point(4, 308);
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.PasswordChar = '\0';
            this.FilterTextBox.PlaceholderText = "";
            this.FilterTextBox.SelectedText = "";
            this.FilterTextBox.Size = new System.Drawing.Size(200, 36);
            this.FilterTextBox.TabIndex = 83;
            this.FilterTextBox.TextChanged += new System.EventHandler(this.FilterTextBox_TextChanged);
            this.FilterTextBox.Enter += new System.EventHandler(this.FilterTextBox_Enter);
            this.FilterTextBox.Leave += new System.EventHandler(this.FilterTextBox_Leave);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 20;
            this.guna2Elipse1.TargetControl = this.panelFilter;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // CBUserID
            // 
            this.CBUserID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CBUserID.BackColor = System.Drawing.Color.Transparent;
            this.CBUserID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CBUserID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUserID.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.CBUserID.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBUserID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CBUserID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.CBUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CBUserID.ItemHeight = 30;
            this.CBUserID.Location = new System.Drawing.Point(363, 308);
            this.CBUserID.Name = "CBUserID";
            this.CBUserID.Size = new System.Drawing.Size(140, 36);
            this.CBUserID.TabIndex = 90;
            this.CBUserID.Visible = false;
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 20;
            this.guna2Elipse2.TargetControl = this.CBUserID;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.Location = new System.Drawing.Point(535, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 24);
            this.label7.TabIndex = 99;
            this.label7.Text = ":";
            // 
            // CountOfRows
            // 
            this.CountOfRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CountOfRows.AutoSize = true;
            this.CountOfRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CountOfRows.Location = new System.Drawing.Point(556, 271);
            this.CountOfRows.Name = "CountOfRows";
            this.CountOfRows.Size = new System.Drawing.Size(18, 20);
            this.CountOfRows.TabIndex = 98;
            this.CountOfRows.Text = "0";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.Location = new System.Drawing.Point(432, 271);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 20);
            this.label6.TabIndex = 97;
            this.label6.Text = "Rows Count";
            // 
            // UserRegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 665);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.CountOfRows);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBUserID);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.ButtomPanel);
            this.Controls.Add(this.PictureRegister_User);
            this.Controls.Add(this.DataViewRegister);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserRegisterScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserRegisterScreen";
            this.Load += new System.EventHandler(this.UserRegisterScreen_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataViewRegister)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureRegister_User)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBox;
        private System.Windows.Forms.Label lblUser;
        private Guna.UI2.WinForms.Guna2DataGridView DataViewRegister;
        private System.Windows.Forms.PictureBox PictureRegister_User;
        private System.Windows.Forms.Panel ButtomPanel;
        private System.Windows.Forms.Panel panelFilter;
        private System.Windows.Forms.RadioButton radioDateTime;
        private System.Windows.Forms.RadioButton radioUser_ID;
        private Guna.UI2.WinForms.Guna2Button Filter;
        private Guna.UI2.WinForms.Guna2TextBox FilterTextBox;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2ComboBox CBUserID;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label CountOfRows;
        private System.Windows.Forms.Label label6;
    }
}