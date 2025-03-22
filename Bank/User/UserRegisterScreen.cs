using BusinessLayerBankSystem;
using Guna.UI2.WinForms;
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
    public partial class UserRegisterScreen : Form
    {
        public UserRegisterScreen()
        {
            InitializeComponent();
        }

        private void _RefreshDataRegister()
        {
            DataViewRegister.DataSource = ClsRegisters.ListRegisters();
            CountOfRows.Text=DataViewRegister.Rows.Count.ToString();
        }
       
        private void UserRegisterScreen_Load(object sender, EventArgs e)
        {
            _RefreshDataRegister();

            CBUserID.DropDownStyle = ComboBoxStyle.DropDown; // السماح بالكتابة
            CBUserID.DrawMode = DrawMode.OwnerDrawFixed; //
            radioUser_ID.Checked = true;
            radioDateTime.CheckedChanged += radioDateTime_CheckedChanged;
            CBUserID.SelectedIndexChanged += FilterTextBox_TextChanged;
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

        private void FillCBUserID()
        {
            CBUserID.Items.Clear();

            CBUserID.Items.Add("UserID");

            DataTable dataTable = ClsRegisters.ListRegisters();

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

        private void UpdateFilterTextBox()
        {
            CBUserID.Visible = false;
            if (radioUser_ID.Checked)
            {
                FilterTextBox.Text = radioUser_ID.Tag.ToString();
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
            else if (radioDateTime.Checked)
            {

                CBUserID.Visible = true;
                FillCBUserID();
                FilterTextBox.Text = radioDateTime.Tag?.ToString() ?? "DateTime";
                FilterTextBox.ForeColor = Color.Gray;
                FilterTextBox.Refresh();
            }
        }

        private void FilterTextBox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(FilterTextBox.Text) || FilterTextBox.Text == "UserID" || FilterTextBox.Text == "DD/MM/YYYY")
            {
                _RefreshDataRegister();
            }

            if (radioUser_ID.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "UserID")
            {
                DataViewRegister.DataSource = ClsRegisters.FindRegisterByUserID(int.Parse(FilterTextBox.Text));
            }

            if (radioDateTime.Checked && FilterTextBox.Text != "" && FilterTextBox.Text != "DD/MM/YYYY")
            {
                DateTime dateOnly;
                if (!DateTime.TryParse(FilterTextBox.Text, out dateOnly))
                {
                    return;
                }

                dateOnly = dateOnly.Date;

                if (CBUserID.SelectedItem.ToString() == "UserID")
                {
                    DataViewRegister.DataSource = ClsRegisters.FindRegisterByDate_Time(dateOnly);
                    return;
                }
                else
                {
                    DataViewRegister.DataSource = ClsRegisters.FindRegiterByUserID_DateTime(int.Parse(CBUserID.SelectedItem.ToString()), dateOnly);
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
            if ( FilterTextBox.Text == "UserID" || FilterTextBox.Text == "DD/MM/YYYY")
            {
                FilterTextBox.Text = "";
                FilterTextBox.ForeColor = Color.Black;
            }
        }

        private void radioUser_ID_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }

        private void radioDateTime_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFilterTextBox();
        }
    }
}
