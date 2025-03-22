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
    public partial class Login : Form
    {
        ClsUsers ThisUser;
        public Login()
        {
            InitializeComponent();
        }

        private bool isPasswordVisible = true;

        private void Username_Enter(object sender, EventArgs e)
        {
            if (Username.Text == "Username")
            {
                Username.Text = "";
                Username.ForeColor = Color.Black;
            }
        }

        private void Username_Leave(object sender, EventArgs e)
        {
            if (Username.Text == "")
            {
                Username.Text = "Username";
                Username.ForeColor = Color.Gray;
            }
        }

        private void Password_Enter(object sender, EventArgs e)
        {
            if (Password.Text == "Password")
            {
                Password.Text = "";
                if (isPasswordVisible)
                {
                    Password.PasswordChar = '*';
                }
                else
                {
                    Password.PasswordChar = '\0';
                }
                Password.ForeColor = Color.Black;
            }
        }

        private void Password_Leave(object sender, EventArgs e)
        {
            if (Password.Text == "")
            {
                Password.Text = "Password";
                Password.PasswordChar = '\0';
                Password.ForeColor = Color.Gray;
            }
        }

        private bool CheckUsername_Password()
        {

            if (Password.Text == "Password" || Username.Text == "Username")
            {
                return false;
            }

            ClsUsers User = ClsUsers.Find(Username.Text);

            if (User == null || ClsDecryption.Decryption( User.Password) != Password.Text.Trim())
            {
                return false;
            }

            ThisUser = User;
            return true;
        }
    
        private void SignIN_Click(object sender, EventArgs e)
        {
               
            if (CheckUsername_Password())
            {
                Form fm = new Dashboard(ThisUser);
                this.Hide();
                fm.ShowDialog();

            }

            else
            {
                MessageBox.Show("Error in Password or Username , try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                Username.Text = "";
                Password.Text = "Password";
                Password.PasswordChar = '\0';
                Password.ForeColor = Color.Gray;
                Username.ForeColor = Color.Black;
                Username.Focus();
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       

        private void ShowHide_Click(object sender, EventArgs e)
        {
            if (isPasswordVisible)
            {
                ShowHide.Image = Properties.Resources.eye__1_; 
                isPasswordVisible = false;
                Password.PasswordChar = '\0';
            }
            else
            {
                ShowHide.Image = Properties.Resources.eye__2_; 
                isPasswordVisible = true;
                if (Password.Text != "Password")
                {
                    Password.PasswordChar = '*';
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
            
            
        }
    }
}
