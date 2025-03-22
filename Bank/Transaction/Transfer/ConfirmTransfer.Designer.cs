namespace Bank
{
    partial class ConfirmTransfer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfirmTransfer));
            this.TopPanel = new System.Windows.Forms.Panel();
            this.LblFullname = new System.Windows.Forms.Label();
            this.Close = new Guna.UI2.WinForms.Guna2Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.CustomerFromName = new System.Windows.Forms.Label();
            this.CustomerToName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtBalance = new Guna.UI2.WinForms.Guna2TextBox();
            this.ButtonConfirm = new Guna.UI2.WinForms.Guna2Button();
            this.panelTo = new System.Windows.Forms.Panel();
            this.panelFrom = new System.Windows.Forms.Panel();
            this.TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.DarkSlateGray;
            this.TopPanel.Controls.Add(this.LblFullname);
            this.TopPanel.Controls.Add(this.Close);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopPanel.Location = new System.Drawing.Point(0, 0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(584, 61);
            this.TopPanel.TabIndex = 91;
            // 
            // LblFullname
            // 
            this.LblFullname.AutoSize = true;
            this.LblFullname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFullname.ForeColor = System.Drawing.Color.White;
            this.LblFullname.Location = new System.Drawing.Point(171, 14);
            this.LblFullname.Name = "LblFullname";
            this.LblFullname.Size = new System.Drawing.Size(242, 33);
            this.LblFullname.TabIndex = 56;
            this.LblFullname.Text = "ConfirmTransfer";
            this.LblFullname.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Close.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.Close.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.Close.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.Close.FillColor = System.Drawing.Color.DarkSlateGray;
            this.Close.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Close.ForeColor = System.Drawing.Color.White;
            this.Close.Image = ((System.Drawing.Image)(resources.GetObject("Close.Image")));
            this.Close.Location = new System.Drawing.Point(547, 5);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(23, 23);
            this.Close.TabIndex = 55;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 483);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(584, 33);
            this.panel4.TabIndex = 98;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(213, 77);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(147, 139);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 99;
            this.guna2PictureBox1.TabStop = false;
            // 
            // CustomerFromName
            // 
            this.CustomerFromName.AutoSize = true;
            this.CustomerFromName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerFromName.Location = new System.Drawing.Point(8, 152);
            this.CustomerFromName.Name = "CustomerFromName";
            this.CustomerFromName.Size = new System.Drawing.Size(207, 18);
            this.CustomerFromName.TabIndex = 100;
            this.CustomerFromName.Text = "Abdelrahman Abdelrahman";
            // 
            // CustomerToName
            // 
            this.CustomerToName.AutoSize = true;
            this.CustomerToName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerToName.Location = new System.Drawing.Point(358, 152);
            this.CustomerToName.Name = "CustomerToName";
            this.CustomerToName.Size = new System.Drawing.Size(207, 18);
            this.CustomerToName.TabIndex = 101;
            this.CustomerToName.Text = "Abdelrahman Abdelrahman";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(85, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 102;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(445, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "To";
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtPassword.BorderRadius = 7;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "Sender’s Password";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FillColor = System.Drawing.SystemColors.InfoText;
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPassword.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(175, 278);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '\0';
            this.txtPassword.PlaceholderText = "";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(218, 36);
            this.txtPassword.TabIndex = 104;
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // txtBalance
            // 
            this.txtBalance.BackColor = System.Drawing.Color.White;
            this.txtBalance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.txtBalance.BorderRadius = 7;
            this.txtBalance.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBalance.DefaultText = "Balance";
            this.txtBalance.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtBalance.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtBalance.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtBalance.FillColor = System.Drawing.SystemColors.InfoText;
            this.txtBalance.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtBalance.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtBalance.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtBalance.Location = new System.Drawing.Point(175, 354);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.PasswordChar = '\0';
            this.txtBalance.PlaceholderText = "";
            this.txtBalance.SelectedText = "";
            this.txtBalance.Size = new System.Drawing.Size(218, 36);
            this.txtBalance.TabIndex = 105;
            this.txtBalance.Enter += new System.EventHandler(this.txtBalance_Enter);
            this.txtBalance.Leave += new System.EventHandler(this.txtBalance_Leave);
            // 
            // ButtonConfirm
            // 
            this.ButtonConfirm.Animated = true;
            this.ButtonConfirm.AutoRoundedCorners = true;
            this.ButtonConfirm.BackColor = System.Drawing.Color.White;
            this.ButtonConfirm.BorderRadius = 26;
            this.ButtonConfirm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ButtonConfirm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ButtonConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ButtonConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ButtonConfirm.FillColor = System.Drawing.Color.Black;
            this.ButtonConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonConfirm.ForeColor = System.Drawing.Color.Lavender;
            this.ButtonConfirm.Location = new System.Drawing.Point(218, 412);
            this.ButtonConfirm.Name = "ButtonConfirm";
            this.ButtonConfirm.Size = new System.Drawing.Size(121, 55);
            this.ButtonConfirm.TabIndex = 106;
            this.ButtonConfirm.Text = "Confirm";
            this.ButtonConfirm.Click += new System.EventHandler(this.ButtonConfirm_Click);
            // 
            // panelTo
            // 
            this.panelTo.Location = new System.Drawing.Point(350, 67);
            this.panelTo.Name = "panelTo";
            this.panelTo.Size = new System.Drawing.Size(234, 153);
            this.panelTo.TabIndex = 107;
            // 
            // panelFrom
            // 
            this.panelFrom.Location = new System.Drawing.Point(0, 67);
            this.panelFrom.Name = "panelFrom";
            this.panelFrom.Size = new System.Drawing.Size(231, 153);
            this.panelFrom.TabIndex = 108;
            // 
            // ConfirmTransfer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 516);
            this.Controls.Add(this.ButtonConfirm);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CustomerToName);
            this.Controls.Add(this.CustomerFromName);
            this.Controls.Add(this.guna2PictureBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TopPanel);
            this.Controls.Add(this.panelTo);
            this.Controls.Add(this.panelFrom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConfirmTransfer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "0";
            this.Text = "ConfirmTransfer";
            this.Load += new System.EventHandler(this.ConfirmTransfer_Load);
            this.TopPanel.ResumeLayout(false);
            this.TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopPanel;
        private System.Windows.Forms.Label LblFullname;
        private Guna.UI2.WinForms.Guna2Button Close;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label CustomerFromName;
        private System.Windows.Forms.Label CustomerToName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtBalance;
        private Guna.UI2.WinForms.Guna2Button ButtonConfirm;
        private System.Windows.Forms.Panel panelTo;
        private System.Windows.Forms.Panel panelFrom;
    }
}