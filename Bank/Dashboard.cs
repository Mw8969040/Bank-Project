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
    public partial class Dashboard : Form
    {
        ClsUsers _ThisUser;
        public Dashboard(ClsUsers ThisUser)
        {
            _ThisUser = ThisUser;
            InitializeComponent();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.Customer))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Form fm = new Customers(_ThisUser);
            fm.Show();
            this.Close();

        }
        public bool CheckPermission(int permission)
        {
            // إذا كنت تريد مقارنة صلاحية
            if (_ThisUser.Permission == (int)UserPermission.EnPermission.All)
            {
                return true;
            }

            if ((permission & _ThisUser.Permission) == permission)
            {
                return true;
            }

            return false;
        }

        private void _RefreshDataDashboard()
        {
            TotalCustomers.Text=ClsCustomers.TotalCustomers().ToString();
            TotalUsers.Text = ClsUsers.TotalUsers().ToString();
            TotalBalance.Text = (ClsCustomers.TotalBalance()).ToString() + " $";
            CardsNonBalance.Text=ClsCustomers.CardNonBalance().ToString();
            DepositTransactions.Text=(ClsDeposit.TotalDepositTransactionToday()).ToString();
            WithdrawTransactions.Text= (ClsWithdraw.TotalWithdrawTransactionToday()).ToString();
            TransferTransactions.Text=(ClsTransfer.TotalTransferTransactionToday()).ToString();
            RegisterProcess.Text=(ClsRegisters.TotalRegisterPerDay()).ToString();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
           _RefreshDataDashboard();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.User))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Form fm = new Users(_ThisUser);
            fm.Show();
            this.Close();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.Deposit))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Form Fm=new DepositForm(_ThisUser);
            Fm.Show();
            this.Close();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.Withdraw))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Form fm = new WithdrawForm(_ThisUser);
            fm.Show();
            this.Close();
        }

        private void CurrencyButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.Currency))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Form fm = new Currency(_ThisUser);
            fm.Show();
            this.Close();
        }

        private void ButtonLogOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure LogOut .", "LogOut", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                Form fm = new Login();
                fm.Show();
                this.Close();
            }
        }

        private void ThisUser_Click(object sender, EventArgs e)
        {
            Form fm = new CurrentUser(_ThisUser);
            fm.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.Transfer))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }
            Form fm = new Transfer(_ThisUser);
            fm.Show();
            this.Close();
        }
    }
}
