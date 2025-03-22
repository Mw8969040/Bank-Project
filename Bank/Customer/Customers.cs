using BusinessLayerBankSystem;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Bank
{
    public partial class Customers : Form
    {
        private bool isFirstLoad = true;

        ClsUsers _ThisUser;
        public Customers(ClsUsers ThisUser)
        {
            _ThisUser = ThisUser;
            InitializeComponent();
        }

        private void DashBoardButton_Click(object sender, EventArgs e)
        {
            Form form = new Dashboard(_ThisUser);
            form.Show();
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


        private void _RefreshDataForCustomers()
        {
            DataViewCustomer.DataSource = ClsCustomers.ListCustomers();
            CountOfRows.Text=(DataViewCustomer.RowCount) .ToString();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
            _RefreshDataForCustomers();

           
             radioF_Name.Checked = true;
          
            
            //عند تحديد او الغاء الراديو بوتون يتم استدعاء هذه الداله لكى يحدث استجابه و يتم تنفيذ مهامه بدونها لن يحث استجابه و لن يتم تنفيذ مهامه
            radioID.CheckedChanged += new EventHandler(radioID_CheckedChanged);
            radioPhone.CheckedChanged += new EventHandler(radioPhone_CheckedChanged);
            radioA_Number.CheckedChanged += new EventHandler(radioA_Number_CheckedChanged);
            radioF_Name.CheckedChanged += new EventHandler(radioF_Name_CheckedChanged);
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

        private void AddUserButton_Click(object sender, EventArgs e)
        {
            Form fm = new FormAddUpdateCustomer(-1, "0");
            fm.ShowDialog();
            _RefreshDataForCustomers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new FormAddUpdateCustomer((int)DataViewCustomer.CurrentRow.Cells[0].Value, "0");
            fm.ShowDialog();
            _RefreshDataForCustomers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this customer?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ClsCustomers.DeleteCustomer((int)DataViewCustomer.CurrentRow.Cells[0].Value);
                MessageBox.Show("Customer is deleted successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataForCustomers();
            }
            else
            {
                MessageBox.Show("Customer not deleted", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new FormAddUpdateCustomer((int)DataViewCustomer.CurrentRow.Cells[0].Value, "2");
            fm.ShowDialog();
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

        private void FilterTextBox_Enter(object sender, EventArgs e)
        {
            if (FilterTextBox.Text == "PhoneNumber" || FilterTextBox.Text == "AccountNumber" || FilterTextBox.Text == "ID" || FilterTextBox.Text=="FirstName")
            {
                FilterTextBox.Text = "";
                FilterTextBox.ForeColor = Color.Black;
            }
        }

        private void UpdateFilterTextBox()
        {
           
                if (radioID.Checked)
                {

                    FilterTextBox.Text = radioID.Tag.ToString();
                    FilterTextBox.ForeColor = Color.Gray;
                    FilterTextBox.Refresh();
                }
                else if (radioPhone.Checked)
                { 
                    FilterTextBox.Text =radioPhone.Tag.ToString();
                    FilterTextBox.ForeColor = Color.Gray;
                    FilterTextBox.Refresh();
                }
                else if (radioA_Number.Checked)
                {
                    FilterTextBox.Text =radioA_Number.Tag.ToString();
                    FilterTextBox.ForeColor = Color.Gray;
                    FilterTextBox.Refresh();
                }
                else if (radioF_Name.Checked)
                {
                   FilterTextBox.Text = radioF_Name.Tag.ToString();
                   FilterTextBox.ForeColor = Color.Gray;
                   FilterTextBox.Refresh();
                }
        }       

        private void radioID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioPhone_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox(); 
        }

        private void radioA_Number_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioF_Name_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void FilterTextBox_Leave(object sender, EventArgs e)
        {
            if (FilterTextBox.Text == "")
            {
                UpdateFilterTextBox();
            }
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterTextBox.Text) || FilterTextBox.Text == "PhoneNumber" || FilterTextBox.Text == "AccountNumber" || FilterTextBox.Text == "ID" || FilterTextBox.Text == "FirstName")
            {
                _RefreshDataForCustomers();
            }

            if (radioPhone.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "PhoneNumber")
            {
                DataViewCustomer.DataSource = ClsCustomers.FindCusomerByPhone(FilterTextBox.Text);

            }

            else if (radioA_Number.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "AccountNumber")
            {
                DataViewCustomer.DataSource = ClsCustomers.FindCusomerByA_Number(FilterTextBox.Text);
            }

            else if (radioID.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "ID")
            {
                DataViewCustomer.DataSource = ClsCustomers.FindCusomerByID(int.Parse(FilterTextBox.Text));
            }

            else if (radioF_Name.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "FirstName")
            {
                DataViewCustomer.DataSource = ClsCustomers.FindCusomerByFirstName(FilterTextBox.Text);
            }
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {

            if (!CheckPermission((int)UserPermission.EnPermission.Deposit))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Form Fm =new DepositForm(_ThisUser);
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
