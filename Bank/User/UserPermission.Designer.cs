namespace Bank
{
    partial class UserPermission
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserPermission));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LblCustomer = new System.Windows.Forms.Label();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CloseButton = new Guna.UI2.WinForms.Guna2Button();
            this.ButtonSave = new Guna.UI2.WinForms.Guna2Button();
            this.label6 = new System.Windows.Forms.Label();
            this.RegisterPer = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.CurrencyPer = new Guna.UI2.WinForms.Guna2Button();
            this.label4 = new System.Windows.Forms.Label();
            this.TransferPer = new Guna.UI2.WinForms.Guna2Button();
            this.Withdraw = new System.Windows.Forms.Label();
            this.WithdrawPer = new Guna.UI2.WinForms.Guna2Button();
            this.Deposit = new System.Windows.Forms.Label();
            this.DepositPer = new Guna.UI2.WinForms.Guna2Button();
            this.label3 = new System.Windows.Forms.Label();
            this.UserPer = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CustomerPer = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AllPer = new Guna.UI2.WinForms.Guna2Button();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.TopPanel.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TopPanel.Controls.Add(this.LblCustomer);
            this.TopPanel.Controls.Add(this.Close);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(559, 63);
            this.TopPanel.TabIndex = 63;
            // 
            // LblCustomer
            // 
            this.LblCustomer.AutoSize = true;
            this.LblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCustomer.ForeColor = System.Drawing.Color.White;
            this.LblCustomer.Location = new System.Drawing.Point(167, 15);
            this.LblCustomer.Name = "LblCustomer";
            this.LblCustomer.Size = new System.Drawing.Size(234, 33);
            this.LblCustomer.TabIndex = 56;
            this.LblCustomer.Text = "Add Permission";
            this.LblCustomer.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Close
            // 
            this.Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close.FillColor = System.Drawing.Color.RoyalBlue;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(577, 3);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(22, 22);
            this.Close.TabIndex = 55;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.AllPer);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(559, 387);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Permission";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.RegisterPer);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CurrencyPer);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TransferPer);
            this.panel1.Controls.Add(this.Withdraw);
            this.panel1.Controls.Add(this.WithdrawPer);
            this.panel1.Controls.Add(this.Deposit);
            this.panel1.Controls.Add(this.DepositPer);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.UserPer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.CustomerPer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(553, 315);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.CloseButton);
            this.panel2.Controls.Add(this.ButtonSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 262);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(553, 53);
            this.panel2.TabIndex = 62;
            // 
            // CloseButton
            // 
            this.CloseButton.Animated = true;
            this.CloseButton.AutoRoundedCorners = true;
            this.CloseButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.CloseButton.BorderRadius = 21;
            this.CloseButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CloseButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CloseButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CloseButton.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.CloseButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseButton.ForeColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(397, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(108, 45);
            this.CloseButton.TabIndex = 60;
            this.CloseButton.Text = "Close";
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Animated = true;
            this.ButtonSave.AutoRoundedCorners = true;
            this.ButtonSave.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ButtonSave.BorderRadius = 21;
            this.ButtonSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonSave.FillColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ButtonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.ForeColor = System.Drawing.Color.White;
            this.ButtonSave.Location = new System.Drawing.Point(52, 5);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(108, 45);
            this.ButtonSave.TabIndex = 61;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(146, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 16;
            this.label6.Text = "Login Register";
            // 
            // RegisterPer
            // 
            this.RegisterPer.Animated = true;
            this.RegisterPer.AutoRoundedCorners = true;
            this.RegisterPer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.RegisterPer.BorderRadius = 9;
            this.RegisterPer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.RegisterPer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.RegisterPer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.RegisterPer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.RegisterPer.FillColor = System.Drawing.Color.Silver;
            this.RegisterPer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RegisterPer.ForeColor = System.Drawing.Color.White;
            this.RegisterPer.Image = ((System.Drawing.Image)(resources.GetObject("RegisterPer.Image")));
            this.RegisterPer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.RegisterPer.ImageSize = new System.Drawing.Size(13, 13);
            this.RegisterPer.Location = new System.Drawing.Point(339, 215);
            this.RegisterPer.Name = "RegisterPer";
            this.RegisterPer.Size = new System.Drawing.Size(59, 20);
            this.RegisterPer.TabIndex = 15;
            this.RegisterPer.Tag = "0";
            this.RegisterPer.Click += new System.EventHandler(this.RegisterPer_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(324, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Currency";
            // 
            // CurrencyPer
            // 
            this.CurrencyPer.Animated = true;
            this.CurrencyPer.AutoRoundedCorners = true;
            this.CurrencyPer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CurrencyPer.BorderRadius = 9;
            this.CurrencyPer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CurrencyPer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CurrencyPer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CurrencyPer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CurrencyPer.FillColor = System.Drawing.Color.Silver;
            this.CurrencyPer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CurrencyPer.ForeColor = System.Drawing.Color.White;
            this.CurrencyPer.Image = ((System.Drawing.Image)(resources.GetObject("CurrencyPer.Image")));
            this.CurrencyPer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CurrencyPer.ImageSize = new System.Drawing.Size(13, 13);
            this.CurrencyPer.Location = new System.Drawing.Point(470, 86);
            this.CurrencyPer.Name = "CurrencyPer";
            this.CurrencyPer.Size = new System.Drawing.Size(59, 20);
            this.CurrencyPer.TabIndex = 13;
            this.CurrencyPer.Tag = "0";
            this.CurrencyPer.Click += new System.EventHandler(this.CurrencyPer_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(324, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Transfer";
            // 
            // TransferPer
            // 
            this.TransferPer.Animated = true;
            this.TransferPer.AutoRoundedCorners = true;
            this.TransferPer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TransferPer.BorderRadius = 9;
            this.TransferPer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.TransferPer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.TransferPer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.TransferPer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.TransferPer.FillColor = System.Drawing.Color.Silver;
            this.TransferPer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TransferPer.ForeColor = System.Drawing.Color.White;
            this.TransferPer.Image = ((System.Drawing.Image)(resources.GetObject("TransferPer.Image")));
            this.TransferPer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TransferPer.ImageSize = new System.Drawing.Size(13, 13);
            this.TransferPer.Location = new System.Drawing.Point(470, 27);
            this.TransferPer.Name = "TransferPer";
            this.TransferPer.Size = new System.Drawing.Size(59, 20);
            this.TransferPer.TabIndex = 11;
            this.TransferPer.Tag = "0";
            this.TransferPer.Click += new System.EventHandler(this.TransferPer_Click);
            // 
            // Withdraw
            // 
            this.Withdraw.AutoSize = true;
            this.Withdraw.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Withdraw.ForeColor = System.Drawing.SystemColors.Control;
            this.Withdraw.Location = new System.Drawing.Point(318, 135);
            this.Withdraw.Name = "Withdraw";
            this.Withdraw.Size = new System.Drawing.Size(99, 25);
            this.Withdraw.TabIndex = 10;
            this.Withdraw.Text = "Withdraw";
            // 
            // WithdrawPer
            // 
            this.WithdrawPer.Animated = true;
            this.WithdrawPer.AutoRoundedCorners = true;
            this.WithdrawPer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.WithdrawPer.BorderRadius = 9;
            this.WithdrawPer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.WithdrawPer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.WithdrawPer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.WithdrawPer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.WithdrawPer.FillColor = System.Drawing.Color.Silver;
            this.WithdrawPer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.WithdrawPer.ForeColor = System.Drawing.Color.White;
            this.WithdrawPer.Image = ((System.Drawing.Image)(resources.GetObject("WithdrawPer.Image")));
            this.WithdrawPer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WithdrawPer.ImageSize = new System.Drawing.Size(13, 13);
            this.WithdrawPer.Location = new System.Drawing.Point(470, 140);
            this.WithdrawPer.Name = "WithdrawPer";
            this.WithdrawPer.Size = new System.Drawing.Size(59, 20);
            this.WithdrawPer.TabIndex = 9;
            this.WithdrawPer.Tag = "0";
            this.WithdrawPer.Click += new System.EventHandler(this.WithdrawPer_Click);
            // 
            // Deposit
            // 
            this.Deposit.AutoSize = true;
            this.Deposit.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deposit.ForeColor = System.Drawing.SystemColors.Control;
            this.Deposit.Location = new System.Drawing.Point(22, 140);
            this.Deposit.Name = "Deposit";
            this.Deposit.Size = new System.Drawing.Size(80, 25);
            this.Deposit.TabIndex = 8;
            this.Deposit.Text = "Deposit";
            // 
            // DepositPer
            // 
            this.DepositPer.Animated = true;
            this.DepositPer.AutoRoundedCorners = true;
            this.DepositPer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.DepositPer.BorderRadius = 9;
            this.DepositPer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DepositPer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DepositPer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DepositPer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DepositPer.FillColor = System.Drawing.Color.Silver;
            this.DepositPer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DepositPer.ForeColor = System.Drawing.Color.White;
            this.DepositPer.Image = ((System.Drawing.Image)(resources.GetObject("DepositPer.Image")));
            this.DepositPer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DepositPer.ImageSize = new System.Drawing.Size(13, 13);
            this.DepositPer.Location = new System.Drawing.Point(151, 144);
            this.DepositPer.Name = "DepositPer";
            this.DepositPer.Size = new System.Drawing.Size(59, 20);
            this.DepositPer.TabIndex = 7;
            this.DepositPer.Tag = "0";
            this.DepositPer.Click += new System.EventHandler(this.DepositPer_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(22, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Users";
            // 
            // UserPer
            // 
            this.UserPer.Animated = true;
            this.UserPer.AutoRoundedCorners = true;
            this.UserPer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.UserPer.BorderRadius = 9;
            this.UserPer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UserPer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UserPer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UserPer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UserPer.FillColor = System.Drawing.Color.Silver;
            this.UserPer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserPer.ForeColor = System.Drawing.Color.White;
            this.UserPer.Image = ((System.Drawing.Image)(resources.GetObject("UserPer.Image")));
            this.UserPer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.UserPer.ImageSize = new System.Drawing.Size(13, 13);
            this.UserPer.Location = new System.Drawing.Point(151, 86);
            this.UserPer.Name = "UserPer";
            this.UserPer.Size = new System.Drawing.Size(59, 20);
            this.UserPer.TabIndex = 5;
            this.UserPer.Tag = "0";
            this.UserPer.Click += new System.EventHandler(this.UserPer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(22, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Customer";
            // 
            // CustomerPer
            // 
            this.CustomerPer.Animated = true;
            this.CustomerPer.AutoRoundedCorners = true;
            this.CustomerPer.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CustomerPer.BorderRadius = 9;
            this.CustomerPer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.CustomerPer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.CustomerPer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.CustomerPer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.CustomerPer.FillColor = System.Drawing.Color.Silver;
            this.CustomerPer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CustomerPer.ForeColor = System.Drawing.Color.White;
            this.CustomerPer.Image = ((System.Drawing.Image)(resources.GetObject("CustomerPer.Image")));
            this.CustomerPer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CustomerPer.ImageSize = new System.Drawing.Size(13, 13);
            this.CustomerPer.Location = new System.Drawing.Point(151, 27);
            this.CustomerPer.Name = "CustomerPer";
            this.CustomerPer.Size = new System.Drawing.Size(59, 20);
            this.CustomerPer.TabIndex = 3;
            this.CustomerPer.Tag = "0";
            this.CustomerPer.Click += new System.EventHandler(this.CustomerPer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "ALL";
            // 
            // AllPer
            // 
            this.AllPer.Animated = true;
            this.AllPer.AutoRoundedCorners = true;
            this.AllPer.BackColor = System.Drawing.SystemColors.ControlLight;
            this.AllPer.BorderRadius = 9;
            this.AllPer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AllPer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AllPer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AllPer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AllPer.FillColor = System.Drawing.Color.Silver;
            this.AllPer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AllPer.ForeColor = System.Drawing.Color.White;
            this.AllPer.Image = ((System.Drawing.Image)(resources.GetObject("AllPer.Image")));
            this.AllPer.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.AllPer.ImageSize = new System.Drawing.Size(13, 13);
            this.AllPer.Location = new System.Drawing.Point(313, 30);
            this.AllPer.Name = "AllPer";
            this.AllPer.Size = new System.Drawing.Size(79, 20);
            this.AllPer.TabIndex = 0;
            this.AllPer.Tag = "0";
            this.AllPer.Click += new System.EventHandler(this.AllPer_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.panel1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // Permission
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.TopPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Permission";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permission";
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label LblCustomer;
        private Guna.UI2.WinForms.Guna2Button Close;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2Button AllPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Deposit;
        private Guna.UI2.WinForms.Guna2Button DepositPer;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2Button UserPer;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button CustomerPer;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2Button TransferPer;
        private System.Windows.Forms.Label Withdraw;
        private Guna.UI2.WinForms.Guna2Button WithdrawPer;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Button RegisterPer;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2Button CurrencyPer;
        private Guna.UI2.WinForms.Guna2Button CloseButton;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Button ButtonSave;
    }
}