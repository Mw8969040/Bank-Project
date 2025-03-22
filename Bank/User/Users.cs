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
    public partial class Users : Form
    {
        ClsUsers _ThisUser;
        public Users(ClsUsers ThisUser)
        {
            _ThisUser = ThisUser;
            InitializeComponent();
        }

        UserPermission Permissions=new UserPermission();

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
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK,  MessageBoxIcon.Asterisk);
                return;
            }

            Form fm = new Customers(_ThisUser);
            fm.Show();
            this.Close();
        }

        private void _RefreshDataUsers()
        {
            DataViewUsers.DataSource = ClsUsers.ListUsers();
            CountOfRows.Text = (DataViewUsers.RowCount).ToString();
        }

        public bool CheckPermission(int permission)
        {
            // إذا كنت تريد مقارنة صلاحية
            if (_ThisUser.Permission== (int)UserPermission.EnPermission.All)
            {
               return true;
            }

            if (( permission & _ThisUser.Permission) == permission)
            {
                return true;
            }

            return false;
        }

       

        private void Users_Load(object sender, EventArgs e)
        {

            radioF_Name.Checked = true;

            radioF_Name.CheckedChanged +=  new EventHandler(radioF_Name_CheckedChanged);
            radioID.CheckedChanged += new EventHandler(radioID_CheckedChanged);
            radioUser_Name.CheckedChanged += new EventHandler(radioUser_Name_CheckedChanged);
            radioPhone.CheckedChanged += new EventHandler(radioPhone_CheckedChanged);

            _RefreshDataUsers();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            Form fm = new FormAddUpdateUser(-1,"0");
             fm.ShowDialog();
            _RefreshDataUsers();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new FormAddUpdateUser((int)DataViewUsers.CurrentRow.Cells[0].Value,"0");
            fm.ShowDialog();
            _RefreshDataUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure to delete this User?", "Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                ClsUsers.DeleteUser((int)DataViewUsers.CurrentRow.Cells[0].Value);
                MessageBox.Show("User is deleted successfully", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _RefreshDataUsers();
            }
            else
            {
                MessageBox.Show("User not deleted", "Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new FormAddUpdateUser((int)DataViewUsers.CurrentRow.Cells[0].Value, "2");
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

        private void UpdateFilterTextBox()
        {
            if(radioID.Checked)
            {
                FilterTextBox.Text=radioID.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }

            if(radioF_Name.Checked)
            {
                FilterTextBox.Text= radioF_Name.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }

            if(radioPhone.Checked)
            {
                FilterTextBox.Text= radioPhone.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }

            if (radioUser_Name.Checked)
            {
                FilterTextBox.Text= radioUser_Name.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
        }

        private void FilterTextBox_Enter(object sender, EventArgs e)
        {

            if (FilterTextBox.Text == "PhoneNumber" || FilterTextBox.Text == "UserName" || FilterTextBox.Text == "ID" || FilterTextBox.Text == "FirstName")
            {
                FilterTextBox.Text = "";
                FilterTextBox.ForeColor = Color.Black;
            }
        }

        private void FilterTextBox_Leave(object sender, EventArgs e)
        {
            if(FilterTextBox.Text=="")
            {
                UpdateFilterTextBox();
            }
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterTextBox.Text) || FilterTextBox.Text == "PhoneNumber" || FilterTextBox.Text == "UserName" || FilterTextBox.Text == "ID" || FilterTextBox.Text == "FirstName")
            {
                _RefreshDataUsers();
            }

            if (radioPhone.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "PhoneNumber")
            {
                DataViewUsers.DataSource = ClsUsers.FindUserByPhone(FilterTextBox.Text);

            }

            else if (radioUser_Name.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "UserName")
            {
                DataViewUsers.DataSource = ClsUsers.FindUserByUsername(FilterTextBox.Text);
            }

            else if (radioID.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "ID")
            {
                DataViewUsers.DataSource = ClsUsers.FindUserByID(int.Parse(FilterTextBox.Text));
            }

            else if (radioF_Name.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "FirstName")
            {
                DataViewUsers.DataSource = ClsUsers.FindUserByFirstname(FilterTextBox.Text);
            }
        }

        private void radioF_Name_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioUser_Name_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioPhone_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void DepositButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.Deposit))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK,  MessageBoxIcon.Asterisk);
                return;
            }

            Form Fm = new DepositForm(_ThisUser);
            Fm.Show();
            this.Close();
        }

        private void WithdrawButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.Withdraw))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK,  MessageBoxIcon.Asterisk);
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
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK,  MessageBoxIcon.Asterisk);
                return;
            }

            Form fm = new Transfer(_ThisUser);
            fm.Show();
            this.Close();
        }

        private void ViewRegisterButton_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.LoginRegister))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Form fm = new UserRegisterScreen();
            fm.ShowDialog();
        }
    }
}
