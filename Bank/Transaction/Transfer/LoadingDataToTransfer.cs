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
    public partial class LoadingDataToTransfer : Form
    {

        ClsUsers _ThisUser;
        public LoadingDataToTransfer(ClsUsers ThisUser)
        {
            InitializeComponent();
            _ThisUser = ThisUser;
        }

        ClsCustomers _CustomerFrom=new ClsCustomers();
        ClsCustomers _CustomerTo=new ClsCustomers();

        private void LblTransaction_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonSearch_CustomerFrom_Click(object sender, EventArgs e)
        {

            DataTable Dt = ClsCustomers.FindCusomerByA_Number(TxtAccountNumber_From.Text);

            if (Dt != null && Dt.Rows.Count != 0)
            {
                int customerId;
                if (int.TryParse(Dt.Rows[0]["ID"].ToString(), out customerId))
                {
                    _CustomerFrom.ID = customerId;
                }
                txtFirstNameFrom.Text = Dt.Rows[0]["Firstname"].ToString();
                txtLastNameFrom.Text = Dt.Rows[0]["Lastname"].ToString();
                txtPhoneFrom.Text = Dt.Rows[0]["Phone"].ToString();
                txtEmailFrom.Text = Dt.Rows[0]["Email"].ToString();
                txtAmountFrom.Text = Dt.Rows[0]["Amount"].ToString();
                pictureBoxFrom.Load(Dt.Rows[0]["ImagePath"].ToString());
                _CustomerFrom.Password = ClsDecryption.Decryption(Dt.Rows[0]["Password"].ToString());


                _CustomerFrom.Firstname = txtFirstNameFrom.Text;
                _CustomerFrom.Lastname = txtLastNameFrom.Text;
               _CustomerFrom.Amount = float.Parse(txtAmountFrom.Text.ToString());

                return;
            }

            else
            {
                MessageBox.Show("Customer is not found, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAccountNumber_From.Focus();
            }
        }

        private void ButtonSearchCustomer_To_Click(object sender, EventArgs e)
        {

            DataTable Dt = ClsCustomers.FindCusomerByA_Number(TxtAccountNumber_To.Text);

            if (Dt != null && Dt.Rows.Count != 0)
            {
                int customerId;
                if (int.TryParse(Dt.Rows[0]["ID"].ToString(), out customerId))
                {
                    _CustomerTo.ID = customerId;
                }
                txtFirstNameTo.Text = Dt.Rows[0]["Firstname"].ToString();
                txtLastNameTo.Text = Dt.Rows[0]["Lastname"].ToString();
                txtPhoneTo.Text = Dt.Rows[0]["Phone"].ToString();
                txtEmailTo.Text = Dt.Rows[0]["Email"].ToString();
                txtAmountTo.Text = Dt.Rows[0]["Amount"].ToString();
                pictureBoxTo.Load(Dt.Rows[0]["ImagePath"].ToString());
                _CustomerTo.Password = ClsDecryption.Decryption(Dt.Rows[0]["Password"].ToString());


                _CustomerTo.Firstname = txtFirstNameTo.Text;
                _CustomerTo.Lastname = txtLastNameTo.Text;
                _CustomerTo.Amount = float.Parse(txtAmountTo.Text.ToString());

                return;
            }

            else
            {
                MessageBox.Show("Customer is not found, try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                TxtAccountNumber_To.Focus();
            }
        }

        private void TxtAccountNumber_From_Leave(object sender, EventArgs e)
        {
            if(TxtAccountNumber_From.Text=="")
            {
                TxtAccountNumber_From.Text = "AccountNumber";
                TxtAccountNumber_From.ForeColor = Color.Gray;
            }

        }

        private void TxtAccountNumber_From_Enter(object sender, EventArgs e)
        {
            if(TxtAccountNumber_From.Text=="AccountNumber")
            {
                TxtAccountNumber_From.Text = "";
                TxtAccountNumber_From.ForeColor = Color.Black;
            }
        }

        private void TxtAccountNumber_To_Enter(object sender, EventArgs e)
        {
            if (TxtAccountNumber_To.Text == "AccountNumber")
            {
                TxtAccountNumber_To.Text = "";
                TxtAccountNumber_To.ForeColor = Color.Black;
            }
        }

        private void TxtAccountNumber_To_Leave(object sender, EventArgs e)
        {
            if (TxtAccountNumber_To.Text == "")
            {
                TxtAccountNumber_To.Text = "AccountNumber";
                TxtAccountNumber_To.ForeColor = Color.Gray;
            }
        }

        private void ButtonTransactions_Click(object sender, EventArgs e)
        {
            if (txtFirstNameFrom.Text == "FirstName" || txtLastNameTo.Text == "LastName")
            {
                MessageBox.Show("There is no data for the Customers .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (TxtAccountNumber_From.Text ==  TxtAccountNumber_To.Text)
            {
                MessageBox.Show("Can not Send to the Same User .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            ConfirmTransfer fm = new ConfirmTransfer(_CustomerFrom, _CustomerTo);
            fm.ShowDialog();

            if (fm.Tag.ToString() != "0")
            {
                ClsTransfer.TransferTransactionRecord(double.Parse(fm.Tag.ToString()), _CustomerFrom.ID, _CustomerTo.ID, _ThisUser.ID, DateTime.Now);
            }
        }
    }
}
