using BusinessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class ConfirmTransaction : Form
    {

        ClsCustomers _Customer;
        string _TrnsactionType;
        public ConfirmTransaction(ClsCustomers Customer,string TrnsactionType)
        {

            InitializeComponent();
            _TrnsactionType = TrnsactionType;
            _Customer = Customer;
        }

        Form fm = new AddingStatus();
        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConfirmTransaction_Load(object sender, EventArgs e)
        {
            this.Tag = 0;
            LblFullname.Text=_Customer.Firstname+"  "+_Customer.Lastname;
            LblFullname.Location = new Point((this.ClientSize.Width - LblFullname.Width) / 2, 15);
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if(txtPassword.Text =="Password")
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if(txtPassword.Text =="")
            {
                txtPassword.Text = "Password";
            }
        }


        private void txtBalance_Leave(object sender, EventArgs e)
        {
            if(txtBalance.Text =="")
            {
                txtBalance.Text= "Balance";
            }
        }

        private void txtBalance_Enter(object sender, EventArgs e)
        {
            if(txtBalance.Text =="Balance")
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

            if (_Customer.Password != txtPassword.Text)
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


            if (_TrnsactionType == "Deposit")
            {
                ClsDeposit.ConfirmDopsit(double.Parse(txtBalance.Text), ClsEncryption.Encryption(_Customer.Password));
                fm.Tag = "Deposit Successfully Completed !";
                fm.ShowDialog();
                this.Tag = txtBalance.Text;
            }

            if(_TrnsactionType == "Withdraw")
            {
                if(_Customer.Amount<float.Parse(txtBalance.Text))
                {
                    MessageBox.Show("Amount more than amount actually available .", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ClsWithdraw.ConfirmWithdraw(double.Parse(txtBalance.Text), ClsEncryption.Encryption(_Customer.Password));
                fm.Tag = "Withdraw Successfully Completed !";
                fm.ShowDialog();
                this.Tag = txtBalance.Text;
            }
        }
    }
}
