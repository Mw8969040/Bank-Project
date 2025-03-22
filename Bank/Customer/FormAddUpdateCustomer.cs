using BusinessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class FormAddUpdateCustomer : Form
    {
        enum EnMode { AddMode = 0, UpdateMode = 1, InfoMode = 2 }
        EnMode Mode = EnMode.AddMode;
        Form AddingStatus = new AddingStatus();

        ClsCustomers _Customer;
        int _CustomerID;
        public FormAddUpdateCustomer(int CustomerID , string Tag)
        {
            InitializeComponent();

            _CustomerID = CustomerID;
            this.Tag = Tag;

            if (this.Tag.ToString() == "2")
            {
                Mode = EnMode.InfoMode;
            }

            else if (_CustomerID == -1)
            {
                Mode = EnMode.AddMode;
            }
            
            else
            {
                Mode = EnMode.UpdateMode;
            }
        }

        private void StatusOFTools(bool Save, bool Close, bool Remove, bool Set, bool TxtFirstname, bool TxtLastname, bool TxtEmail, bool TextPhone, bool TxtAccountNumber, bool TxtPassword ,bool TxtAmount)
        {
            IISetImage.Visible = Set;
            llRemove.Visible = Remove;
            SaveButton.Visible = Save;
            CloseButton.Visible = Close;
            txtFirstName.Enabled = TxtFirstname;
            txtLastName.Enabled = TxtLastname;
            txtEmail.Enabled = TxtEmail;
            txtPhone.Enabled = TextPhone;
            txtAcountNumber.Enabled = TxtAccountNumber;
            txtPassword.Enabled = TxtPassword;
            txtAmount.Enabled = TxtAmount;
        }

        private void _LoadData()
        {
            StatusOFTools(true, true, true, true ,true , true , true , true , true, true, true);

            BottomPanel.BackColor = Color.DarkSlateGray;
            TopPanel.BackColor = Color.DarkSlateGray;
            Close.FillColor = Color.DarkSlateGray;
            LblCustomer.ForeColor = Color.White;

            if (Mode == EnMode.AddMode)
            {
                AddingStatus.Tag =" Customer Added Successfully !";
                LblCustomer.Text = "Add New Customer";
                _Customer = new ClsCustomers();
                return;
            }

            _Customer = ClsCustomers.Find(_CustomerID);

            if (_Customer == null)
            {
                MessageBox.Show("The Customer is not found ! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (Mode == EnMode.InfoMode)
            {
                LblCustomer.Text = _Customer.Firstname+"  "+ _Customer.Lastname ;
                lblCustomerID.Text = _Customer.ID.ToString();
                txtFirstName.Text = _Customer.Firstname;
                txtLastName.Text = _Customer.Lastname;
                txtEmail.Text = _Customer.Email;
                txtPhone.Text = _Customer.Phone;
                txtAcountNumber.Text = _Customer.AccountNumber;
                txtPassword.Text = ClsDecryption.Decryption(_Customer.Password);
                txtAmount.Text = _Customer.Amount.ToString();       
                PictureCustomer.Load(_Customer.ImagePath);

                StatusOFTools(false,false,false,false,false,false,false,false,false,false,false);

                BottomPanel.BackColor = SystemColors.ControlLight;
                TopPanel.BackColor = SystemColors.ControlLight;
                Close.FillColor = SystemColors.ControlLight;
                LblCustomer.ForeColor = Color.Black;

                this.Tag = 0;
                return;
            }

            AddingStatus.Tag = "Customer Updated Successfully !";
            LblCustomer.Text = "Edit Customer ID = " + _Customer.ID.ToString();
            lblCustomerID.Text = _Customer.ID.ToString();
            txtFirstName.Text = _Customer.Firstname;
            txtLastName.Text = _Customer.Lastname;
            txtEmail.Text = _Customer.Email;
            txtPhone.Text = _Customer.Phone;
            txtAcountNumber.Text = _Customer.AccountNumber;
            txtPassword.Text =ClsDecryption.Decryption(_Customer.Password);
            txtAmount.Text = _Customer.Amount.ToString();

            if (_Customer.ImagePath != "")
            {
                PictureCustomer.Load(_Customer.ImagePath);
            }

            llRemove.Visible = (PictureCustomer.ImageLocation != null);
        }
    

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IISetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                string Path=openFileDialog1.FileName;
                PictureCustomer.Load(Path);
                llRemove.Visible = true;
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureCustomer.ImageLocation = null;
            llRemove.Visible= false;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAddCustomer_Load(object sender, EventArgs e)
        {
            _LoadData();
            LblCustomer.Location = new Point((this.ClientSize.Width - LblCustomer.Width) / 2, 15);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            _Customer.Firstname=txtFirstName.Text;
            _Customer.Lastname=txtLastName.Text;
            _Customer.Email=txtEmail.Text;
            _Customer.Phone=txtPhone.Text;
            _Customer.AccountNumber=txtAcountNumber.Text;
            _Customer.Password = ClsEncryption.Encryption(txtPassword.Text);
            
            if (txtAmount.Text == "")
            {
                _Customer.Amount = 0;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(txtAmount.Text) || !Decimal.TryParse(txtAmount.Text, out decimal result))
                {
                    MessageBox.Show("Please enter a valid amount .", "Status", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtAmount.Focus();
                    return;
                }
                else
                {
                    _Customer.Amount = float.Parse(txtAmount.Text);
                }
            }

            if (PictureCustomer.ImageLocation !=null)
            {
                _Customer.ImagePath= PictureCustomer.ImageLocation;
            }
            else
            {
                _Customer.ImagePath = @"C:\Users\Mr.Lap\OneDrive\Pictures\businessman.png";
            }


            if (_Customer.Save())
            {
                AddingStatus.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error in Saved Customer .", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
            Mode=EnMode.UpdateMode;
            LblCustomer.Text = "Edit Customer ID = " + _Customer.ID.ToString();
            lblCustomerID.Text = _Customer.ID.ToString();
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            if (string.IsNullOrEmpty(email))
            {
                return;
            }


            if (!Regex.IsMatch(email, emailPattern))
            {
                MessageBox.Show("Please enter valid Email.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtEmail.Focus(); 
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text;

            if (string.IsNullOrEmpty(phoneNumber))
            {
                return;
            }


            if (phoneNumber.Length != 11)
            {
                MessageBox.Show("Please enter exactly 11 digits.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtPhone.Focus(); 
            }
            else if (!phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter digits only.","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtPhone.Focus(); 
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            string amount = txtAmount.Text;

            if(string.IsNullOrEmpty(amount))
            {
                return;
            }

            if (!Decimal.TryParse(amount, out decimal result))
            {
                MessageBox.Show("Please enter a valid amount .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAmount.Focus();
            }
        }

        private void txtAcountNumber_Leave(object sender, EventArgs e)
        {

            if(Mode==EnMode.UpdateMode)
            {
                return;
            }

            if(ClsCustomers.IsAccountNumberExist(txtAcountNumber.Text))
            {
                MessageBox.Show("This AccountNumber is Exist Really .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAcountNumber.Focus();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            string Password = txtPassword.Text;

            if (Mode == EnMode.UpdateMode)
            {
                return;
            }

            if (!Password.All(char.IsDigit))
            {
                MessageBox.Show("Please enter digits only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            string EncryptedPassword = Password;
            if (ClsCustomers.IsPasswordExist(ClsEncryption.Encryption(EncryptedPassword)))
            {
                MessageBox.Show("This Password is Exist Really.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }

        }
        
    }
}
