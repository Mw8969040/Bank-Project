using BusinessLayerBankSystem;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bank
{
    public partial class DepositForm : Form
    {
        ClsUsers _ThisUser;

        public DepositForm(ClsUsers ThisUser)
        {
            _ThisUser = ThisUser;
            InitializeComponent();
        }

        private void _RefreshDataDeposit()
        {
            DataViewDeposit.DataSource = ClsDeposit.ListDeposit();
            CountOfRows.Text = (DataViewDeposit.RowCount).ToString();
        }

       
        private void DepositForm_Load(object sender, EventArgs e)
        {
            _RefreshDataDeposit();

            radioUserID.Checked = true;
            radioCustomerID.CheckedChanged += radioCustomerID_CheckedChanged;
            radioUserID.CheckedChanged += radioUserID_CheckedChanged;
            radioDateTime.CheckedChanged += radioDateTime_CheckedChanged;
            radioBalance.CheckedChanged += radioBalance_CheckedChanged;

            CBUserID.SelectedIndexChanged += FilterTextBox_TextChanged;
            CBCustomerID.SelectedIndexChanged += FilterTextBox_TextChanged;

            
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



        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            Form Fm = new Dashboard(_ThisUser);
            Fm.Show();
            this.Close();
        }

        private void CustomerButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.Customer))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Form Fm = new Customers(_ThisUser);
            Fm.Show();
            this.Close();
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.User))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Form form = new Users(_ThisUser);
            form.Show();
            this.Close();
        }

        private void ButtonAddDepistTransaction_Click(object sender, EventArgs e)
        {
            Form Fm = new LoadingDataCustomer(_ThisUser, "Deposit");
            Fm.ShowDialog();
            _RefreshDataDeposit();
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

        private void Filter_Click(object sender, EventArgs e)
        {
            if (Filter.Tag.ToString() == "1")
            {
                panelFilter.Visible = true;
                Filter.Tag = 2;
            }
            else if (Filter.Tag.ToString() == "2")
            {
                panelFilter.Visible = false;
                Filter.Tag = 1;
            }
        }

        private void FillCBCustomerID()
        {
            CBCustomerID.Items.Clear();

            CBCustomerID.Items.Add("CustomerID");

            DataTable dataTable = ClsDeposit.ListDeposit();

            var uniqueCustomerIDs = dataTable.AsEnumerable()
                                             .Select(row => row["Customer_ID"].ToString())
                                             .Distinct();

            foreach (string customerID in uniqueCustomerIDs)
            {
                CBCustomerID.Items.Add(customerID);
            }

            CBCustomerID.Sorted = true;
            CBCustomerID.SelectedItem= "CustomerID";
        }

        private void FillCBUserID()
        {
            CBUserID.Items.Clear();

            CBUserID.Items.Add("UserID");

            DataTable dataTable = ClsDeposit.ListDeposit();

            var uniqueUserIDs = dataTable.AsEnumerable()
                                         .Select(row => row["User_ID"].ToString())
                                         .Distinct();

            foreach (string userID in uniqueUserIDs)
            {
                CBUserID.Items.Add(userID);
            }

            CBUserID.Sorted = true;
            CBUserID.SelectedItem = "UserID";
        }

        private void UpdateFilterTextBox()
        {
            CBUserID.Visible = false;
            CBCustomerID.Visible = false;

            if (radioCustomerID.Checked)
            {
                FilterTextBox.Text = radioCustomerID.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
            else if (radioUserID.Checked)
            {
                FilterTextBox.Text = radioUserID.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
            else if (radioDateTime.Checked)
            {
                CBCustomerID.Visible = true;
                CBUserID.Visible = true;
             

                FillCBCustomerID();
                FillCBUserID();
                FilterTextBox.Text = radioDateTime.Tag?.ToString() ?? "DateTime";
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
            else if (radioBalance.Checked)
            {
                FilterTextBox.Text = radioBalance.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
        }

        private void radioUserID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioCustomerID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioDateTime_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioBalance_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterTextBox.Text) || FilterTextBox.Text == "CustomerID" || FilterTextBox.Text == "UserID" || FilterTextBox.Text == "Balance" || FilterTextBox.Text == "DD/MM/YYYY")
            {
                _RefreshDataDeposit();
            }

            if (radioCustomerID.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "CustomerID")
            {
                DataViewDeposit.DataSource = ClsDeposit.FindByCustomerID(int.Parse(FilterTextBox.Text));
            }

            if (radioUserID.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "UserID")
            {
                DataViewDeposit.DataSource = ClsDeposit.FindByUserID(int.Parse(FilterTextBox.Text));
            }

            if (radioBalance.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "Balance")
            {
                DataViewDeposit.DataSource = ClsDeposit.FindByBalance(float.Parse(FilterTextBox.Text));
            }

            if (radioDateTime.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "DD/MM/YYYY")
            {
                DateTime dateOnly;
                if (!DateTime.TryParse(FilterTextBox.Text, out dateOnly))
                {
                    return;
                }

                dateOnly = dateOnly.Date;

                if (CBCustomerID.SelectedItem.ToString() == "CustomerID" && CBUserID.SelectedItem.ToString() == "UserID")
                {
                    DataViewDeposit.DataSource = ClsDeposit.FindByDateTime(dateOnly);
                }
                else if (CBCustomerID.SelectedItem.ToString() != "CustomerID" && CBUserID.SelectedItem.ToString() == "UserID")
                {
                    DataViewDeposit.DataSource = ClsDeposit.FindByDateTime_CustomerID(dateOnly, int.Parse(CBCustomerID.SelectedItem.ToString()));
                }
                else if (CBCustomerID.SelectedItem.ToString() == "CustomerID" && CBUserID.SelectedItem.ToString() != "UserID")
                {
                    DataViewDeposit.DataSource = ClsDeposit.FindByDateTime_UserID(dateOnly, int.Parse(CBUserID.SelectedItem.ToString()));
                }
                else if (CBCustomerID.SelectedItem.ToString() != "CustomerID" && CBUserID.SelectedItem.ToString() != "UserID")
                {
                    DataViewDeposit.DataSource = ClsDeposit.FindByDateTime_CustomerID_UserID(dateOnly, int.Parse(CBCustomerID.SelectedItem.ToString()), int.Parse(CBUserID.SelectedItem.ToString())) ;
                }

            }
        }

        private void FilterTextBox_Leave(object sender, EventArgs e)
        {
            if (FilterTextBox.Text == "")
            {
                UpdateFilterTextBox();
            }
        }

        private void FilterTextBox_Enter(object sender, EventArgs e)
        {
            if (FilterTextBox.Text == "CustomerID" || FilterTextBox.Text == "UserID" || FilterTextBox.Text == "Balance" || FilterTextBox.Text == "DD/MM/YYYY")
            {
                FilterTextBox.Text = "";
                FilterTextBox.ForeColor = Color.Black;
            }
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
