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
    public partial class LoadingDataCustomer : Form
    {

       
        ClsCustomers _Customer =new ClsCustomers();
        string _TransactionType;
        ClsUsers _ThisUser;
        public LoadingDataCustomer(ClsUsers ThisUser , string TransactionType)
        {
            InitializeComponent();
            _ThisUser = ThisUser;
            _TransactionType = TransactionType;
            LblTransaction.Text = TransactionType+" "+"Transaction";
            ButtonTransactions.Text = TransactionType;
        }

        private void AccountNumber_Enter(object sender, EventArgs e)
        {
            if(TxtAccountNumber.Text=="AccountNumber")
            {
                TxtAccountNumber.Text = "";
                TxtAccountNumber.ForeColor = Color.Black;
            }
        }

        private void AccountNumber_Leave(object sender, EventArgs e)
        {
            if(TxtAccountNumber.Text=="")
            {
                TxtAccountNumber.Text = "AccountNumber";
                TxtAccountNumber.ForeColor= Color.Gray;
            }
        }

        private void LoadingDataCustomer_Load(object sender, EventArgs e)
        {
            EnableTools(false, false, false, false, false);
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnableTools(bool Firstname, bool Lastname, bool Email, bool Phone, bool Amount)
        {
            txtFirstName.Enabled = Firstname;
            txtLastName.Enabled = Lastname;
            txtEmail.Enabled = Email;
            txtPhone.Enabled = Phone;
            txtAmount.Enabled = Amount;

        }

        private void ButtonSearch_Click(object sender, EventArgs e)
        {
           DataTable Dt=ClsCustomers.FindCusomerByA_Number(TxtAccountNumber.Text);

            if (Dt != null && Dt.Rows.Count != 0)
            {
                int customerId;
                if (int.TryParse(Dt.Rows[0]["ID"].ToString(), out customerId))
                {
                    _Customer.ID = customerId;
                }
                txtFirstName.Text = Dt.Rows[0]["Firstname"].ToString();
                txtLastName.Text = Dt.Rows[0]["Lastname"].ToString();
                txtPhone.Text = Dt.Rows[0]["Phone"].ToString();
                txtEmail.Text = Dt.Rows[0]["Email"].ToString();
                txtAmount.Text = Dt.Rows[0]["Amount"].ToString();
                PictureCustomer.Load(Dt.Rows[0]["ImagePath"].ToString());
                _Customer.Password = ClsDecryption.Decryption(Dt.Rows[0]["Password"].ToString());

               
                _Customer.Firstname=txtFirstName.Text;
                _Customer.Lastname=txtLastName.Text;
                _Customer.Amount = float.Parse(txtAmount.Text.ToString());
                
                return;
            }

            else
            {
                MessageBox.Show("Customer is not found, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAccountNumber.Focus();
            }
        }

        private void ButtonTransactions_Click(object sender, EventArgs e)
        {
            if(txtFirstName.Text=="" || txtLastName.Text=="" )
            {
                MessageBox.Show("There is no data for the Customer .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_TransactionType == "Deposit")
            {
                ConfirmTransaction fm = new ConfirmTransaction(_Customer,_TransactionType);
                fm.ShowDialog();

                if (fm.Tag.ToString() != "0")
                {
                    ClsDeposit.DepositTransactionRecord(double.Parse(fm.Tag.ToString()), _Customer.ID, _ThisUser.ID, DateTime.Now);
                }
            }

            else if (_TransactionType == "Withdraw")
            {
                ConfirmTransaction fm = new ConfirmTransaction(_Customer, _TransactionType);
                fm.ShowDialog();

                if (fm.Tag.ToString() != "0")
                {
                    ClsWithdraw.WithdrawTransactionRecord(double.Parse(fm.Tag.ToString()), _Customer.ID, _ThisUser.ID, DateTime.Now);
                }
            }
        }
    }
}
