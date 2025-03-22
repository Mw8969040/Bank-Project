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
    public partial class Transfer : Form
    {

        ClsUsers _ThisUser;
        public Transfer(ClsUsers ThisUser)
        {
            InitializeComponent();
            _ThisUser = ThisUser;
        }

        private void _RefreshDataTransfer()
        {
            DataViewTransfer.DataSource = ClsTransfer.ListTransfer();
            CountOfRows.Text = (DataViewTransfer.RowCount).ToString();
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

        private void Transfer_Load(object sender, EventArgs e)
        {
            _RefreshDataTransfer();

            radioUserID.Checked = true;
            radioCustomerIDTo.CheckedChanged += radioCustomerIDTo_CheckedChanged;
            radioCustomerIDFrom.CheckedChanged += radioCustomerIDFrom_CheckedChanged;
            radioUserID.CheckedChanged += radioUserID_CheckedChanged;
            radioDateTime.CheckedChanged += radioDateTime_CheckedChanged;
            radioBalance.CheckedChanged += radioBalance_CheckedChanged;

            CBUserID.SelectedIndexChanged += FilterTextBox_TextChanged;
            CBCustomerIDFrom.SelectedIndexChanged += FilterTextBox_TextChanged;
            CBCustomerIDTo.SelectedIndexChanged += FilterTextBox_TextChanged;
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

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            Form fm = new Dashboard(_ThisUser);
            fm.Show();
            this.Close();
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

            Form fm = new DepositForm(_ThisUser);
            fm.Show();
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

        private void ButtonTransferTransaction_Click(object sender, EventArgs e)
        {
            Form fm = new LoadingDataToTransfer(_ThisUser);
            fm.ShowDialog();
            _RefreshDataTransfer();

        }

        private void FillCBCustomerIDFrom()
        {
            CBCustomerIDFrom.Items.Clear();

            CBCustomerIDFrom.Items.Add("CustomerID_From");

            DataTable dataTable = ClsTransfer.ListTransfer();

            var uniqueCustomerIDs = dataTable.AsEnumerable()
                                             .Select(row => row["CustomerIDFrom"].ToString())
                                             .Distinct();

            foreach (string customerID in uniqueCustomerIDs)
            {
                CBCustomerIDFrom.Items.Add(customerID);
            }

            CBCustomerIDFrom.Sorted = true;
            CBCustomerIDFrom.SelectedItem = "CustomerID_From";
        }

        private void FillCBCustomerIDTo()
        {
            CBCustomerIDTo.Items.Clear();

            CBCustomerIDTo.Items.Add("CustomerID_To");

            DataTable dataTable = ClsTransfer.ListTransfer();

            var uniqueCustomerIDs = dataTable.AsEnumerable()
                                             .Select(row => row["CustomerIDTo"].ToString())
                                             .Distinct();

            foreach (string customerID in uniqueCustomerIDs)
            {
                CBCustomerIDTo.Items.Add(customerID);
            }

            CBCustomerIDTo.Sorted = true;
            CBCustomerIDTo.SelectedItem = "CustomerID_To";
        }

        private void FillCBUserID()
        {
            CBUserID.Items.Clear();

            CBUserID.Items.Add("UserID");

            DataTable dataTable = ClsTransfer.ListTransfer();

            var uniqueUserIDs = dataTable.AsEnumerable()
                                         .Select(row => row["UserID"].ToString())
                                         .Distinct();

            foreach (string userID in uniqueUserIDs)
            {
                CBUserID.Items.Add(userID);
            }

            CBUserID.Sorted = true;
            CBUserID.SelectedItem = "UserID";
        }


        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterTextBox.Text) || FilterTextBox.Text == "CustomerID_To" || FilterTextBox.Text == "UserID" || FilterTextBox.Text == "Balance" || FilterTextBox.Text == "DD/MM/YYYY" || FilterTextBox.Text == "CustomerID_From")
            {
                _RefreshDataTransfer();
            }

            if (radioCustomerIDFrom.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "CustomerID_From")
            {
                DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByCustomerIDFrom(int.Parse(FilterTextBox.Text));
            }

            if (radioCustomerIDTo.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "CustomerID_To")
            {
                DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByCustomerIDTo(int.Parse(FilterTextBox.Text));
            }

            if (radioUserID.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "UserID")
            {
                DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByUserID(int.Parse(FilterTextBox.Text));
            }

            if (radioBalance.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "Balance")
            {
                DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByBalance(float.Parse(FilterTextBox.Text));
            }

            if (radioDateTime.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "DD/MM/YYYY")
            {
                DateTime dateOnly;
                if (!DateTime.TryParse(FilterTextBox.Text, out dateOnly))
                {
                    return;
                }

                dateOnly = dateOnly.Date;

                if (CBCustomerIDFrom.SelectedItem.ToString() == "CustomerID_From" && CBUserID.SelectedItem.ToString() == "UserID" && CBCustomerIDTo.SelectedItem.ToString() == "CustomerID_To")
                {
                    DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByDate_Time(dateOnly);          
                }

                if (CBCustomerIDFrom.SelectedItem.ToString() != "CustomerID_From" && CBUserID.SelectedItem.ToString() != "UserID" && CBCustomerIDTo.SelectedItem.ToString() != "CustomerID_To")
                {
                    DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByDate_Time_CustomerIDFrom_CustomerIDTo_UserID(dateOnly, int.Parse(CBCustomerIDFrom.SelectedItem.ToString()), int.Parse(CBCustomerIDTo.SelectedItem.ToString()), int.Parse(CBUserID.SelectedItem.ToString()));
                }

                else if (CBCustomerIDFrom.SelectedItem.ToString() == "CustomerID_From" && CBUserID.SelectedItem.ToString() == "UserID" && CBCustomerIDTo.SelectedItem.ToString() != "CustomerID_To")
                {
                    DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByDate_Time_CustomerIDTo(dateOnly, int.Parse(CBCustomerIDTo.SelectedItem.ToString()));
                  
                }

                else if (CBCustomerIDFrom.SelectedItem.ToString() == "CustomerID_From" && CBUserID.SelectedItem.ToString() != "UserID" && CBCustomerIDTo.SelectedItem.ToString() == "CustomerID_To")
                {
                    DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByDate_Time_UserID(dateOnly, int.Parse(CBUserID.SelectedItem.ToString()));  
                }

                else if (CBCustomerIDFrom.SelectedItem.ToString() != "CustomerID_From" && CBUserID.SelectedItem.ToString() == "UserID" && CBCustomerIDTo.SelectedItem.ToString() == "CustomerID_To")
                {
                    DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByDate_Time_CustomerIDFrom(dateOnly, int.Parse(CBCustomerIDFrom.SelectedItem.ToString()));      
                }

                else if (CBCustomerIDFrom.SelectedItem.ToString() == "CustomerID_From" && CBUserID.SelectedItem.ToString() != "UserID" && CBCustomerIDTo.SelectedItem.ToString() != "CustomerID_To")
                {
                    DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByDate_Time_CustomerIDTo_UserID(dateOnly, int.Parse(CBUserID.SelectedItem.ToString()), int.Parse(CBCustomerIDTo.SelectedItem.ToString()));
                }

                else if (CBCustomerIDFrom.SelectedItem.ToString() != "CustomerID_From" && CBUserID.SelectedItem.ToString() == "UserID" && CBCustomerIDTo.SelectedItem.ToString() != "CustomerID_To")
                {
                    DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByDate_Time_CustomerIDFrom_CustomerIDTo(dateOnly, int.Parse(CBCustomerIDFrom.SelectedItem.ToString()), int.Parse(CBCustomerIDTo.SelectedItem.ToString()));
                }

                else if (CBCustomerIDFrom.SelectedItem.ToString() != "CustomerID_From" && CBUserID.SelectedItem.ToString() != "UserID" && CBCustomerIDTo.SelectedItem.ToString() == "CustomerID_To")
                {
                    DataViewTransfer.DataSource = ClsTransfer.FindTransferTransactionByDate_Time_CustomerIDFrom_UserID(dateOnly, int.Parse(CBCustomerIDFrom.SelectedItem.ToString()), int.Parse(CBUserID.SelectedItem.ToString()));
                }
            }
        }

        private void UpdateFilterTextBox()
        {
            CBUserID.Visible = false;
            CBCustomerIDFrom.Visible = false;
            CBCustomerIDTo.Visible = false;

            if (radioCustomerIDFrom.Checked)
            {
                FilterTextBox.Text = radioCustomerIDFrom.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
            else if(radioCustomerIDTo.Checked)
            {
                FilterTextBox.Text = radioCustomerIDTo.Tag.ToString();
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
                CBCustomerIDFrom.Visible = true;
                CBUserID.Visible = true;
                CBCustomerIDTo.Visible = true;

                FillCBCustomerIDFrom();
                FillCBCustomerIDTo();
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

        private void radioCustomerIDFrom_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioCustomerIDTo_CheckedChanged(object sender, EventArgs e)
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

        private void FilterTextBox_Enter(object sender, EventArgs e)
        {
            if (FilterTextBox.Text == "CustomerID_From" || FilterTextBox.Text == "UserID" || FilterTextBox.Text == "Balance" || FilterTextBox.Text == "DD/MM/YYYY" || FilterTextBox.Text=="CustomerID_To")
            {
                FilterTextBox.Text = "";
                FilterTextBox.ForeColor = Color.Black;
            }
        }

        private void FilterTextBox_Leave(object sender, EventArgs e)
        {
            if (FilterTextBox.Text == "")
            {
                UpdateFilterTextBox();
            }
        }

        private void pictureDeposit_Click(object sender, EventArgs e)
        {

        }
    }

}
