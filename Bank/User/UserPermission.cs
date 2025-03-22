using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Caching;
using System.Windows.Forms;

namespace Bank
{
    public partial class UserPermission : Form
    {
         int TotalPermissions;
        
        public UserPermission()
        {
            TotalPermissions = 0;
            InitializeComponent();
        }

        public  enum EnPermission { All = -1, Customer = 1, User = 2, Deposit = 4, Withdraw = 8, Transfer = 16, Currency = 32, LoginRegister = 64 };
        private void AllPer_Click(object sender, EventArgs e)
        {
            if (AllPer.Tag.ToString() == "0") // Zero means no permission
            {
                AllPer.Tag = 1;
                CustomerPer.Tag = 1;
                UserPer.Tag = 1;
                DepositPer.Tag = 1;
                WithdrawPer.Tag = 1;
                TransferPer.Tag = 1;
                CurrencyPer.Tag = 1;
                RegisterPer.Tag = 1;

                AllPer.ImageAlign = HorizontalAlignment.Left;
                AllPer.FillColor = Color.Gray;

                CustomerPer.ImageAlign = HorizontalAlignment.Left;
                CustomerPer.FillColor = Color.Gray;

                UserPer.ImageAlign = HorizontalAlignment.Left;
                UserPer.FillColor = Color.Gray;

                DepositPer.ImageAlign = HorizontalAlignment.Left;
                DepositPer.FillColor = Color.Gray;

                WithdrawPer.ImageAlign = HorizontalAlignment.Left;
                WithdrawPer.FillColor = Color.Gray;

                RegisterPer.ImageAlign = HorizontalAlignment.Left;
                RegisterPer.FillColor = Color.Gray;

                TransferPer.ImageAlign= HorizontalAlignment.Left;
                TransferPer.FillColor = Color.Gray;

                CurrencyPer.ImageAlign=HorizontalAlignment.Left;
                CurrencyPer.FillColor = Color.Gray;
            }

            else if(AllPer.Tag.ToString() == "1")
            {
                AllPer.Tag = 0;
                CustomerPer.Tag = 0;
                UserPer.Tag = 0;
                DepositPer.Tag = 0;
                WithdrawPer.Tag = 0;
                TransferPer.Tag = 0;
                CurrencyPer.Tag = 0;
                RegisterPer.Tag = 0;

                AllPer.ImageAlign= HorizontalAlignment.Right;
                AllPer.FillColor = Color.Silver;

                CustomerPer.ImageAlign = HorizontalAlignment.Right;
                CustomerPer.FillColor = Color.Silver;

                UserPer.ImageAlign = HorizontalAlignment.Right;
                UserPer.FillColor = Color.Silver;

                 DepositPer.ImageAlign = HorizontalAlignment.Right;
                DepositPer.FillColor = Color.Silver;

                WithdrawPer.ImageAlign = HorizontalAlignment.Right;
                WithdrawPer.FillColor = Color.Silver;

                RegisterPer.ImageAlign = HorizontalAlignment.Right;
                RegisterPer.FillColor = Color.Silver;

                TransferPer.ImageAlign = HorizontalAlignment.Right;
                TransferPer.FillColor = Color.Silver;

                CurrencyPer.ImageAlign = HorizontalAlignment.Right;
                CurrencyPer.FillColor = Color.Silver;
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CustomerPer_Click(object sender, EventArgs e)
        {
            if(CustomerPer.Tag.ToString()=="0")
            {
                CustomerPer.Tag = 1;
                CustomerPer.ImageAlign = HorizontalAlignment.Left;
                CustomerPer.FillColor = Color.Gray;
            }

            else if(CustomerPer.Tag.ToString()=="1")
            {
                CustomerPer.Tag = 0;
                CustomerPer.ImageAlign = HorizontalAlignment.Right;
                CustomerPer.FillColor = Color.Silver;
            }
        }

        private void UserPer_Click(object sender, EventArgs e)
        {
            if (UserPer.Tag.ToString() == "0")
            {
                UserPer.Tag = 1;
                UserPer.ImageAlign = HorizontalAlignment.Left;
                UserPer.FillColor = Color.Gray;
            }

            else if (UserPer.Tag.ToString() == "1")
            {
                UserPer.Tag = 0;
                UserPer.ImageAlign = HorizontalAlignment.Right;
                UserPer.FillColor = Color.Silver;
            }
        }

        private void DepositPer_Click(object sender, EventArgs e)
        {
            if (DepositPer.Tag.ToString() == "0")
            {
                DepositPer.Tag = 1;
                DepositPer.ImageAlign = HorizontalAlignment.Left;
                DepositPer.FillColor = Color.Gray;
            }

            else if (DepositPer.Tag.ToString() == "1")
            {
                DepositPer.Tag = 0;
                DepositPer.ImageAlign = HorizontalAlignment.Right;
                DepositPer.FillColor = Color.Silver;
            }
        }

        private void TransferPer_Click(object sender, EventArgs e)
        {
            if (TransferPer.Tag.ToString() == "0")
            {
                TransferPer.Tag = 1;
                TransferPer.ImageAlign = HorizontalAlignment.Left;
                TransferPer.FillColor = Color.Gray;
            }

            else if (TransferPer.Tag.ToString() == "1")
            {
                TransferPer.Tag = 0;
                TransferPer.ImageAlign = HorizontalAlignment.Right;
                TransferPer.FillColor = Color.Silver;
            }
        }

        private void CurrencyPer_Click(object sender, EventArgs e)
        {
            if (CurrencyPer.Tag.ToString() == "0")
            {
                CurrencyPer.Tag = 1;
                CurrencyPer.ImageAlign = HorizontalAlignment.Left;
                CurrencyPer.FillColor = Color.Gray;
            }

            else if (CurrencyPer.Tag.ToString() == "1")
            {
                CurrencyPer.Tag = 0;
                CurrencyPer.ImageAlign = HorizontalAlignment.Right;
                CurrencyPer.FillColor = Color.Silver;
            }
        }

        private void WithdrawPer_Click(object sender, EventArgs e)
        {
            if (WithdrawPer.Tag.ToString() == "0")
            {
                WithdrawPer.Tag = 1;
                WithdrawPer.ImageAlign = HorizontalAlignment.Left;
                WithdrawPer.FillColor = Color.Gray;
            }

            else if (WithdrawPer.Tag.ToString() == "1")
            {
                WithdrawPer.Tag = 0;
                WithdrawPer.ImageAlign = HorizontalAlignment.Right;
                WithdrawPer.FillColor = Color.Silver;
            }
        }

        private void RegisterPer_Click(object sender, EventArgs e)
        {
            if (RegisterPer.Tag.ToString() == "0")
            {
                RegisterPer.Tag = 1;
                RegisterPer.ImageAlign = HorizontalAlignment.Left;
                RegisterPer.FillColor = Color.Gray;
            }

            else if (RegisterPer.Tag.ToString() == "1")
            {
                RegisterPer.Tag = 0;
                RegisterPer.ImageAlign = HorizontalAlignment.Right;
                RegisterPer.FillColor = Color.Silver;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            if(AllPer.Tag.ToString()=="1")
            {
                TotalPermissions = (int)EnPermission.All;
            }
            else
            {
                if(CustomerPer.Tag.ToString() == "1")
                {
                    TotalPermissions += (int)EnPermission.Customer;
                }
                if(UserPer.Tag.ToString()=="1")
                {
                    TotalPermissions += (int)EnPermission.User;
                }
                if(DepositPer.Tag.ToString() == "1")
                {
                    TotalPermissions += (int)EnPermission.Deposit;
                }
                if(WithdrawPer.Tag.ToString()=="1")
                {
                    TotalPermissions += (int)EnPermission.Withdraw;
                }
                if(TransferPer.Tag.ToString() == "1")
                {
                    TotalPermissions += (int)EnPermission.Transfer;
                }
                if(CurrencyPer.Tag.ToString()=="1")
                {
                    TotalPermissions += (int)EnPermission.Currency;
                }
                if(RegisterPer.Tag.ToString()=="1")
                {
                    TotalPermissions += (int)EnPermission.LoginRegister;
                }
            }
            this.Tag = TotalPermissions;
            this.Close();
        }
    }
}
