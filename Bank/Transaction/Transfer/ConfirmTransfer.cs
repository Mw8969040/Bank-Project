using BusinessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class ConfirmTransfer : Form
    {
        ClsCustomers _CustomerFrom;
        ClsCustomers _CustomerTo;
        Form fm = new AddingStatus();
        public ConfirmTransfer(ClsCustomers CustomerFrom , ClsCustomers CustomerTo)
        {
            InitializeComponent();
            _CustomerFrom = CustomerFrom;
            _CustomerTo = CustomerTo;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text=="")
            {
                txtPassword.Text = "Sender’s Password";
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text== "Sender’s Password")
            {
                txtPassword.Text = "";
            }
        }

        private void txtBalance_Leave(object sender, EventArgs e)
        {
            if(txtBalance.Text=="")
            {
                txtBalance.Text = "Balance";
            }
        }

        private void txtBalance_Enter(object sender, EventArgs e)
        {
            if(txtBalance.Text=="Balance")
            {
                txtBalance.Text = "";
            }
        }

        private void ButtonConfirm_Click(object sender, EventArgs e)
        {
            if (txtBalance.Text == "" || txtPassword.Text == "" || txtPassword.Text == "Password" || txtBalance.Text == "Balance")
            {
                MessageBox.Show("Please enter Data .", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (_CustomerFrom.Password != txtPassword.Text)
            {
                MessageBox.Show("Password does not match .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }

            if (!decimal.TryParse(txtBalance.Text, out decimal balance) || balance < 0)
            {
                MessageBox.Show("Please enter a valid amount.", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtBalance.Focus();
                return;
            }

            if (_CustomerFrom.Amount < float.Parse(txtBalance.Text))
            {
                MessageBox.Show("Amount more than amount actually available .", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                ClsWithdraw.ConfirmWithdraw(double.Parse(txtBalance.Text), ClsEncryption.Encryption(_CustomerFrom.Password));
                ClsDeposit.ConfirmDopsit(double.Parse(txtBalance.Text), ClsEncryption.Encryption(_CustomerTo.Password));
                fm.Tag = "Transfer Successfully Completed !";
                fm.ShowDialog();
                this.Tag = txtBalance.Text;
            }
        }

        private void ConfirmTransfer_Load(object sender, EventArgs e)
        {
            CustomerFromName.Text = _CustomerFrom.Firstname + "  " + _CustomerFrom.Lastname;
            CustomerToName.Text = _CustomerTo.Firstname + "  " + _CustomerTo.Lastname;

            CustomerFromName.Location = new Point(
                 (panelFrom.Width - CustomerFromName.Width) / 2,
                 (panelFrom.Height - CustomerFromName.Height) / 2+80 );
                
            // توسيط CustomerToName داخل panelTo
            CustomerToName.Location = new Point(
                (panelTo.Width - CustomerToName.Width) / 2+353,
                (panelTo.Height - CustomerToName.Height) / 2+80);


        }
    }
}
