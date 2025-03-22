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
    public partial class CurrentUser : Form
    {
        ClsUsers _ThisUser;
        public CurrentUser(ClsUsers ThisUser)
        {
            InitializeComponent();
            _ThisUser = ThisUser;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CurrentUser_Load(object sender, EventArgs e)
        {
            PictureUser.Load(_ThisUser.ImagePath);
            FullName.Text = _ThisUser.Firstname +"  "+ _ThisUser.Lastname;
            FullName.Location = new Point((this.ClientSize.Width - FullName.Width) / 2, 8);
            Phone.Text = _ThisUser.Phone;
            Username.Text = _ThisUser.Username;
            Gmail.Text = _ThisUser.Email;
            Permissions.Text = _ThisUser.Permission.ToString();

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if(Username.Text=="Admin")
            {
                MessageBox.Show("Admin Can not Delete .", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                if (MessageBox.Show("Are you sure you want to delete this user account?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    ClsUsers.DeleteUser(_ThisUser.ID);
                    LogOut_Click(sender, e);
                }
            }
        }

        private void LogOut_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Are you sure LogOut .", "LogOut", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk) == DialogResult.OK)
            {
                // إنشاء نموذج تسجيل الدخول الجديد
                Form fm = new Login();



                // التكرار العكسي على النماذج المفتوحة
                for (int i = Application.OpenForms.Count - 1; i >= 1; i--)
                {
                    Form form = Application.OpenForms[i];
                    if (form != fm) // تجاهل نموذج تسجيل الدخول الجديد
                    {
                        form.Close();
                    }
                }

                // عرض نموذج تسجيل الدخول الجديد
                fm.Show();
            }
        }
    }
}
