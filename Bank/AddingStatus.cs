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
    public partial class AddingStatus : Form
    {
        public AddingStatus()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddingStatus_Load(object sender, EventArgs e)
        {
            // if(this.Tag.ToString()=="1")
            // {
            //     LabelStatus.Text = "Customer Added Successfully !";
            // }
            //else if(this.Tag.ToString()=="2")
            // {
            //     LabelStatus.Text = "Customer Updated Successfully !";
            // }
           
            LabelStatus.Text = this.Tag.ToString();
            LabelStatus.Location = new Point((this.ClientSize.Width - LabelStatus.Width) / 2, 15);
        }
    }
}
