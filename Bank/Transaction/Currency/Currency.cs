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
    public partial class Currency : Form
    {
        ClsUsers _ThisUser;

        public Currency(ClsUsers ThisUser)
        {
            _ThisUser = ThisUser;
            InitializeComponent();
        }

       
        public void _RefreshDataCurrency()
        {
            DataViewCurrency.DataSource = ClsCurrency.ListCurrency();
            CountOfRows.Text=(DataViewCurrency.RowCount).ToString();
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
            Form fm= new Dashboard(_ThisUser);
            fm.Show();
            this.Close();
        }

        private void Currency_Load(object sender, EventArgs e)
        {
            _RefreshDataCurrency();


            radioCurrency_Code.Checked = true;
            radioCountry_Name.CheckedChanged +=new EventHandler(radioCountry_Name_CheckedChanged);
            radioCurrency_Code.CheckedChanged +=new EventHandler(radioCurrency_Code_CheckedChanged);
            radioCurrency_Name.CheckedChanged +=new EventHandler(radioCurrency_Name_CheckedChanged);
            radioRate.CheckedChanged +=new EventHandler(radioRate_CheckedChanged);

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

        private void CurrencyCalculatorButton_Click(object sender, EventArgs e)
        {
            Form fm = new CalculateCurrency();
            fm.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible = true;
            TxtRate.Text = "Rate";

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            panelUpdate.Visible=false;
        }

        private void TxtRate_Enter(object sender, EventArgs e)
        {
            if(TxtRate.Text=="Rate")
            {
                TxtRate.Text = "";
                TxtRate.ForeColor = Color.Black;
            }
        }

        private void TxtRate_Leave(object sender, EventArgs e)
        {
            if(TxtRate.Text=="")
            {

                TxtRate.Text = "Rate";
                TxtRate.ForeColor = Color.Gray;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            if(TxtRate.Text=="" || TxtRate.Text=="Rate" || !decimal.TryParse(TxtRate.Text, out decimal balance) || balance < 0)
            {
                MessageBox.Show("Please enter valid Rate .","Warnning",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtRate.Focus();
                return;
            }

            else if(ClsCurrency.UpdateRate((int)DataViewCurrency.CurrentRow.Cells[0].Value, decimal.Parse(TxtRate.Text)))
            {
                AddingStatus fm =new AddingStatus();
                fm.Tag = $"Rate of {DataViewCurrency.CurrentRow.Cells[2].Value.ToString()} Updated Successfully !";
                fm.ShowDialog();
            }
            _RefreshDataCurrency();
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

            if (radioCountry_Name.Checked)
            {

                FilterTextBox.Text = radioCountry_Name.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
            else if (radioCurrency_Name.Checked)
            {
                FilterTextBox.Text = radioCurrency_Name.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
            else if (radioCurrency_Code.Checked)
            {
                FilterTextBox.Text = radioCurrency_Code.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
            else if (radioRate.Checked)
            {
                FilterTextBox.Text = radioRate.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
        }


        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterTextBox.Text) || FilterTextBox.Text == "CountryName" || FilterTextBox.Text == "CurrencyCode" || FilterTextBox.Text == "CurrencyName" || FilterTextBox.Text == "Rate")
            {
                _RefreshDataCurrency();
            }

            if (radioCountry_Name.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "CountryName")
            {
                DataViewCurrency.DataSource = ClsCurrency.FindByCountryName(FilterTextBox.Text);

            }

            if (radioCurrency_Name.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "CurrencyName")
            {
                DataViewCurrency.DataSource = ClsCurrency.FindByCurrencyName(FilterTextBox.Text);

            }

            if (radioCurrency_Code.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "CurrencyCode")
            {
                DataViewCurrency.DataSource = ClsCurrency.FindByCurrencyCode(FilterTextBox.Text);

            }

            if (radioRate.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "Rate")
            {
                DataViewCurrency.DataSource = ClsCurrency.FindByRate(float.Parse(FilterTextBox.Text));

            }

        }

        private void radioCountry_Name_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioCurrency_Name_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioCurrency_Code_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioRate_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void FilterTextBox_Leave(object sender, EventArgs e)
        {
            if(FilterTextBox.Text=="")
            {
                UpdateFilterTextBox(); 
            }
        }

        private void FilterTextBox_Enter(object sender, EventArgs e)
        {
            if (FilterTextBox.Text ==radioCountry_Name.Tag.ToString()|| FilterTextBox.Text == radioCurrency_Name.Tag.ToString() || FilterTextBox.Text ==radioCurrency_Code.Tag.ToString() || FilterTextBox.Text == radioRate.Tag.ToString())
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
            Form fm=new CurrentUser(_ThisUser);
            fm.ShowDialog();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (!CheckPermission((int)UserPermission.EnPermission.Transfer))
            {
                MessageBox.Show("Sorry Do not have permission to this Screen, Call Admin", "Permissions", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            Form fm=new Transfer(_ThisUser);
            fm.Show();
            this.Close();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
