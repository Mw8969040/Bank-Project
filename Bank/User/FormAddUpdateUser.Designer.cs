namespace Bank
{
    partial class FormAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddUpdateUser));
            this.LblUser = new System.Windows.Forms.Label();
            this.BottomPanel = new System.Windows.Forms.Panel();
            this.SaveButton = new Guna.UI2.WinForms.Guna2Button();
            this.CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.PictureUser = new System.Windows.Forms.PictureBox();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.llRemove = new System.Windows.Forms.LinkLabel();
            this.IISetImage = new System.Windows.Forms.LinkLabel();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.TopPanel = new System.Windows.Forms.Panel();
            this.Permission = new System.Windows.Forms.Label();
            this.PASSWORD = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.ACCOUNTNUMBER = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.PHONE = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.EMAIL = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.Lastname = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.FirstName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.ButtonAddPermissions = new Guna.UI2.WinForms.Guna2Button();
            this.lblPermission = new System.Windows.Forms.Label();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).BeginInit();
            this.TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.ForeColor = System.Drawing.Color.White;
            this.LblUser.Location = new System.Drawing.Point(202, 22);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(214, 33);
            this.LblUser.TabIndex = 56;
            this.LblUser.Text = "Add New User";
            this.LblUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BottomPanel
            // 
            this.BottomPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BottomPanel.Controls.Add(this.SaveButton);
            this.BottomPanel.Controls.Add(this.CloseButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 548);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(602, 63);
            this.BottomPanel.TabIndex = 89;
            // 
            // SaveButton
            // 
            this.SaveButton.Animated = true;
            this.SaveButton.AutoRoundedCorners = true;
            this.SaveButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.SaveButton.BorderRadius = 21;
            this.SaveButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.SaveButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.SaveButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.SaveButton.FillColor = System.Drawing.Color.White;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.Black;
            this.SaveButton.Location = new System.Drawing.Point(143, 9);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(108, 45);
            this.SaveButton.TabIndex = 60;
            this.SaveButton.Text = "Save";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Animated = true;
            this.CloseButton.AutoRoundedCorners = true;
            this.CloseButton.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CloseButton.BorderRadius = 21;
            this.CloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButton.FillColor = System.Drawing.Color.White;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.Black;
            this.CloseButton.Location = new System.Drawing.Point(362, 9);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(108, 45);
            this.CloseButton.TabIndex = 59;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.PictureUser;
            // 
            // PictureUser
            // 
            this.PictureUser.BackColor = System.Drawing.SystemColors.Control;
            this.PictureUser.Location = new System.Drawing.Point(387, 221);
            this.PictureUser.Name = "PictureUser";
            this.PictureUser.Size = new System.Drawing.Size(192, 167);
            this.PictureUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PictureUser.TabIndex = 86;
            this.PictureUser.TabStop = false;
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // llRemove
            // 
            this.llRemove.AutoSize = true;
            this.llRemove.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llRemove.LinkColor = System.Drawing.Color.Black;
            this.llRemove.Location = new System.Drawing.Point(511, 176);
            this.llRemove.Name = "llRemove";
            this.llRemove.Size = new System.Drawing.Size(68, 20);
            this.llRemove.TabIndex = 88;
            this.llRemove.TabStop = true;
            this.llRemove.Text = "Remove";
            this.llRemove.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llRemove_LinkClicked);
            // 
            // IISetImage
            // 
            this.IISetImage.AutoSize = true;
            this.IISetImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IISetImage.LinkColor = System.Drawing.Color.Black;
            this.IISetImage.Location = new System.Drawing.Point(383, 176);
            this.IISetImage.Name = "IISetImage";
            this.IISetImage.Size = new System.Drawing.Size(83, 20);
            this.IISetImage.TabIndex = 87;
            this.IISetImage.TabStop = true;
            this.IISetImage.Text = "Set Image";
            this.IISetImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.IISetImage_LinkClicked);
            // 
            // Close
            // 
            this.Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(572, 7);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 55;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TopPanel.Controls.Add(this.LblUser);
            this.TopPanel.Controls.Add(this.Close);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(602, 61);
            this.TopPanel.TabIndex = 90;
            // 
            // Permission
            // 
            this.Permission.AutoSize = true;
            this.Permission.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Permission.Location = new System.Drawing.Point(15, 503);
            this.Permission.Name = "Permission";
            this.Permission.Size = new System.Drawing.Size(118, 25);
            this.Permission.TabIndex = 85;
            this.Permission.Text = "Permission";
            // 
            // PASSWORD
            // 
            this.PASSWORD.AutoSize = true;
            this.PASSWORD.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PASSWORD.Location = new System.Drawing.Point(17, 450);
            this.PASSWORD.Name = "PASSWORD";
            this.PASSWORD.Size = new System.Drawing.Size(106, 25);
            this.PASSWORD.TabIndex = 82;
            this.PASSWORD.Text = "Password";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gray;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Location = new System.Drawing.Point(158, 467);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 2);
            this.panel6.TabIndex = 81;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(162, 443);
            this.txtPassword.MaxLength = 50;
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(201, 26);
            this.txtPassword.TabIndex = 80;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // ACCOUNTNUMBER
            // 
            this.ACCOUNTNUMBER.AutoSize = true;
            this.ACCOUNTNUMBER.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ACCOUNTNUMBER.Location = new System.Drawing.Point(16, 391);
            this.ACCOUNTNUMBER.Name = "ACCOUNTNUMBER";
            this.ACCOUNTNUMBER.Size = new System.Drawing.Size(113, 25);
            this.ACCOUNTNUMBER.TabIndex = 79;
            this.ACCOUNTNUMBER.Text = "UserName";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Location = new System.Drawing.Point(157, 408);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 2);
            this.panel5.TabIndex = 78;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(161, 384);
            this.txtUsername.MaxLength = 50;
            this.txtUsername.Multiline = true;
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(201, 26);
            this.txtUsername.TabIndex = 77;
            this.txtUsername.Leave += new System.EventHandler(this.txtUsername_Leave);
            // 
            // PHONE
            // 
            this.PHONE.AutoSize = true;
            this.PHONE.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PHONE.Location = new System.Drawing.Point(17, 331);
            this.PHONE.Name = "PHONE";
            this.PHONE.Size = new System.Drawing.Size(74, 25);
            this.PHONE.TabIndex = 76;
            this.PHONE.Text = "Phone";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Location = new System.Drawing.Point(158, 348);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 2);
            this.panel4.TabIndex = 75;
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(162, 324);
            this.txtPhone.MaxLength = 50;
            this.txtPhone.Multiline = true;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(201, 26);
            this.txtPhone.TabIndex = 74;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // EMAIL
            // 
            this.EMAIL.AutoSize = true;
            this.EMAIL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EMAIL.Location = new System.Drawing.Point(16, 274);
            this.EMAIL.Name = "EMAIL";
            this.EMAIL.Size = new System.Drawing.Size(65, 25);
            this.EMAIL.TabIndex = 73;
            this.EMAIL.Text = "Email";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Location = new System.Drawing.Point(157, 292);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 2);
            this.panel3.TabIndex = 72;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(161, 268);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(201, 26);
            this.txtEmail.TabIndex = 71;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // Lastname
            // 
            this.Lastname.AutoSize = true;
            this.Lastname.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lastname.Location = new System.Drawing.Point(15, 218);
            this.Lastname.Name = "Lastname";
            this.Lastname.Size = new System.Drawing.Size(109, 25);
            this.Lastname.TabIndex = 70;
            this.Lastname.Text = "LastName";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Location = new System.Drawing.Point(157, 238);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 2);
            this.panel2.TabIndex = 69;
            // 
            // txtLastName
            // 
            this.txtLastName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(161, 214);
            this.txtLastName.MaxLength = 50;
            this.txtLastName.Multiline = true;
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(201, 26);
            this.txtLastName.TabIndex = 68;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserID.Location = new System.Drawing.Point(154, 118);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(40, 24);
            this.lblUserID.TabIndex = 67;
            this.lblUserID.Text = "???";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(19, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 24);
            this.label8.TabIndex = 66;
            this.label8.Text = "UserID";
            // 
            // FirstName
            // 
            this.FirstName.AutoSize = true;
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstName.Location = new System.Drawing.Point(17, 164);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(110, 25);
            this.FirstName.TabIndex = 65;
            this.FirstName.Text = "FirstName";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(159, 184);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 2);
            this.panel1.TabIndex = 64;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(163, 160);
            this.txtFirstName.MaxLength = 50;
            this.txtFirstName.Multiline = true;
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(201, 26);
            this.txtFirstName.TabIndex = 63;
            // 
            // ButtonAddPermissions
            // 
            this.ButtonAddPermissions.Animated = true;
            this.ButtonAddPermissions.AutoRoundedCorners = true;
            this.ButtonAddPermissions.BorderRadius = 21;
            this.ButtonAddPermissions.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddPermissions.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonAddPermissions.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonAddPermissions.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonAddPermissions.FillColor = System.Drawing.SystemColors.ControlText;
            this.ButtonAddPermissions.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAddPermissions.ForeColor = System.Drawing.Color.White;
            this.ButtonAddPermissions.Location = new System.Drawing.Point(157, 495);
            this.ButtonAddPermissions.Name = "ButtonAddPermissions";
            this.ButtonAddPermissions.Size = new System.Drawing.Size(180, 45);
            this.ButtonAddPermissions.TabIndex = 92;
            this.ButtonAddPermissions.Tag = "-1";
            this.ButtonAddPermissions.Text = "Add Permission";
            this.ButtonAddPermissions.Click += new System.EventHandler(this.ButtonAddPermissions_Click);
            // 
            // lblPermission
            // 
            this.lblPermission.AutoSize = true;
            this.lblPermission.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermission.Location = new System.Drawing.Point(155, 503);
            this.lblPermission.Name = "lblPermission";
            this.lblPermission.Size = new System.Drawing.Size(40, 24);
            this.lblPermission.TabIndex = 93;
            this.lblPermission.Text = "???";
            // 
            // FormAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(602, 611);
            this.Controls.Add(this.ButtonAddPermissions);
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.PictureUser);
            this.Controls.Add(this.llRemove);
            this.Controls.Add(this.IISetImage);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.Permission);
            this.Controls.Add(this.PASSWORD);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.ACCOUNTNUMBER);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.PHONE);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.EMAIL);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.Lastname);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblPermission);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAddUser";
            this.Load += new System.EventHandler(this.FormAddUser_Load);
            this.BottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureUser)).EndInit();
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Panel BottomPanel;
        private Guna.UI2.WinForms.Guna2Button SaveButton;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.PictureBox PictureUser;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.LinkLabel llRemove;
        private System.Windows.Forms.LinkLabel IISetImage;
        private Guna.UI2.WinForms.Guna2Button Close;
        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label Permission;
        private System.Windows.Forms.Label PASSWORD;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label ACCOUNTNUMBER;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label PHONE;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label EMAIL;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label Lastname;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblUserID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label FirstName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtFirstName;
        private Guna.UI2.WinForms.Guna2Button ButtonAddPermissions;
        private System.Windows.Forms.Label lblPermission;
    }
}