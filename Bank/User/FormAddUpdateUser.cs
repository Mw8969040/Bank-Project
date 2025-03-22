using BusinessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bank
{
    public partial class FormAddUpdateUser : Form
    {
        Form AddingStatus = new AddingStatus();
        enum Enmode {AddUser=0 ,UpdateUser=1 , InfoUser=2 }
        Enmode enmode = Enmode.AddUser;

        ClsUsers _User;
        int _UserID;
        public FormAddUpdateUser(int UserID, string Tag)
        {
            this.Tag = Tag;
            _UserID = UserID;

            if(UserID==-1)
            {
                enmode = Enmode.AddUser;
            }

            else if(this.Tag.ToString()=="2")
            {
                enmode = Enmode.InfoUser;
            }

            else
            {
                enmode = Enmode.UpdateUser;
            }

            InitializeComponent();
        }
        private void StatusOFTools(bool Save, bool Close, bool Remove, bool Set, bool TxtFirstname, bool TxtLastname, bool TxtEmail, bool TextPhone, bool TxtUserName, bool TxtPassword, bool ButtonPermission)
        {
            IISetImage.Visible = Set;
            llRemove.Visible = Remove;
            SaveButton.Visible = Save;
            CloseButton.Visible = Close;
            txtFirstName.Enabled = TxtFirstname;
            txtLastName.Enabled = TxtLastname;
            txtEmail.Enabled = TxtEmail;
            txtPhone.Enabled = TextPhone;
            txtUsername.Enabled = TxtUserName;
            txtPassword.Enabled = TxtPassword;
            ButtonAddPermissions.Visible = ButtonPermission;
        }

        public void _LoadDataUser()
        {
            StatusOFTools(true, true, true, true, true, true, true, true, true, true,true);

            BottomPanel.BackColor = Color.DarkSlateGray;
            TopPanel.BackColor = Color.DarkSlateGray;
            Close.FillColor = Color.DarkSlateGray;
            LblUser.ForeColor = Color.White;

            if(enmode==Enmode.AddUser)
            {
                AddingStatus.Tag = "User Added Successfully !";
                LblUser.Text = "Add New User";
                _User =new ClsUsers();
                return;
            }

            _User = ClsUsers.Find(_UserID);

            if (_User == null)
            {
                MessageBox.Show("The User is not found ! ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(enmode==Enmode.InfoUser)
            {
                LblUser.Text =_User.Firstname  + "  " + _User.Lastname;
                lblUserID.Text = _User.ID.ToString();
                txtFirstName.Text = _User.Firstname;
                txtLastName.Text = _User.Lastname;
                txtEmail.Text = _User.Email;
                txtPhone.Text = _User.Phone;
                txtPassword.Text=ClsDecryption.Decryption( _User.Password);
                txtUsername.Text= _User.Username;
                lblPermission.Text = _User.Permission.ToString();
                PictureUser.Load(_User.ImagePath);


                StatusOFTools(false, false, false, false, false, false, false, false, false, false, false);
                BottomPanel.BackColor = SystemColors.ControlLight;
                TopPanel.BackColor = SystemColors.ControlLight;
                Close.FillColor = SystemColors.ControlLight;
                LblUser.ForeColor = Color.Black;

                return;
            }

            AddingStatus.Tag = "User Updated Successfully !";
            LblUser.Text = "Edit User ID = " + _User.ID.ToString();
            lblUserID.Text = _User.ID.ToString();
            txtFirstName.Text = _User.Firstname;
            txtLastName.Text = _User.Lastname;
            txtEmail.Text = _User.Email;
            txtPhone.Text = _User.Phone;
            txtUsername.Text = _User.Username;
            txtPassword.Text = ClsDecryption.Decryption(_User.Password);
            lblPermission.Text = _User.Permission.ToString();

            if (_User.ImagePath != "")
            {
                PictureUser.Load(_User.ImagePath);
            }

            llRemove.Visible = (PictureUser.ImageLocation != null);

        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ButtonAddPermissions_Click(object sender, EventArgs e)
        {
            UserPermission permissionForm = new UserPermission();

            permissionForm.ShowDialog();
            ButtonAddPermissions.Tag = permissionForm.Tag;
        }

        private void FormAddUser_Load(object sender, EventArgs e)
        {
            _LoadDataUser();
            LblUser.Location = new Point((this.ClientSize.Width - LblUser.Width) / 2, 15);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            _User.Firstname = txtFirstName.Text;
            _User.Lastname = txtLastName.Text;
            _User.Email = txtEmail.Text;
            _User.Phone = txtPhone.Text;
            _User.Username = txtUsername.Text;  
            _User.Password =ClsEncryption.Encryption( txtPassword.Text);
            

            _User.Permission=int.Parse(ButtonAddPermissions.Tag.ToString());

            if (PictureUser.ImageLocation != null)
            {
                _User.ImagePath = PictureUser.ImageLocation;
            }
            else
            {
                _User.ImagePath = @"C:\Users\Mr.Lap\OneDrive\Pictures\businessman.png";
            }



            if (_User.Save())
            {
                AddingStatus.ShowDialog();
            }
            else
            {
                 MessageBox.Show("Error in Saved  User ", "Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }


            enmode = Enmode.UpdateUser;
            LblUser.Text = "Edit User ID = " + _User.ID.ToString();
            lblUserID.Text = _User.ID.ToString();
        }

        private void IISetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if(openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                string path=openFileDialog1.FileName;
                PictureUser.Load(path);
                llRemove.Visible = true;
            }
        }

        private void llRemove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PictureUser.ImageLocation = null;
            llRemove.Visible= false;
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            string phoneNumber = txtPhone.Text;

            if(string.IsNullOrEmpty(phoneNumber))
            {
                return;
            }

            if (phoneNumber.Length != 11)
            {
                MessageBox.Show("Please enter exactly 11 digits.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
            }
            else if (!phoneNumber.All(char.IsDigit))
            {
                MessageBox.Show("Please enter digits only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhone.Focus();
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {

            string Password = txtPassword.Text;

            if (enmode == Enmode.UpdateUser)
            {
                return;
            }

            if (!Password.All(char.IsDigit))
            {
                MessageBox.Show("Please enter digits only.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }

            if (ClsUsers.IsPasswordExist(ClsEncryption.Encryption( Password)))
            {
                MessageBox.Show("This Password is Exist Really.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
            }       
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if(enmode==Enmode.UpdateUser)
            {
                return;
            }

            if (ClsUsers.IsUserNameExist(txtUsername.Text))
            {
                MessageBox.Show("This UserName is Exist Really .", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
            }
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
                MessageBox.Show("Please enter valid Email.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
            }
        }
    }
}
