using  DataAccessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBankSystem
{
    public class ClsCustomers
    {


        enum Enmode { AddMode = 0, UpdateMode = 1 }
        Enmode Mode;
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AccountNumber { get; set; }
        public string Password { get; set; }
        public float Amount { get; set; }

        public string ImagePath { get; set; }

        private ClsCustomers(int ID, string Firstname, string Lastname, string Email, string Phone, string AccountNumber, string Password, float Amount , string ImagePath)
        {
            this.ID = ID;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Phone = Phone;
            this.AccountNumber = AccountNumber;
            this.Password = Password;
            this.Amount = Amount;
            this.ImagePath = ImagePath;
            Mode = Enmode.UpdateMode;
        }

        public ClsCustomers()
        {
            Mode = Enmode.AddMode;
            ID = -1;
            Firstname = "";
            Lastname = "";
            Email = "";
            Phone = "";
            AccountNumber = "";
            Password = "";
            Amount = 0;
            ImagePath = "";
        }


        public static ClsCustomers Find(int ID)
        {
            string Firstname = "";
            string Lastname = "";
            string Email = "";
            string Phone = "";
            string AccountNumber = "";
            string Password = "";
            float Amount = 0;
            string ImagePath = "";
            if (ClsDataCustomers.FindCustomer(ID, ref Firstname, ref Lastname, ref Email, ref Phone, ref AccountNumber, ref Password, ref Amount , ref ImagePath))
            {
                return new ClsCustomers(ID, Firstname, Lastname, Email, Phone, AccountNumber, Password, Amount , ImagePath);
            }

            else
            {
                return null;
            }
        }

        private bool _AddNewCustomer()
        {
            this.ID = ClsDataCustomers.AddNewCustomer(this.Firstname, this.Lastname, this.Email, this.Phone, this.AccountNumber, this.Password, this.Amount , this.ImagePath);
            return this.ID != -1;
        }

        private bool _UpdateCustomer()
        {
            return ClsDataCustomers.UpdateCustomer(this.ID, this.Firstname, this.Lastname, this.Email, this.Phone, this.AccountNumber, this.Password, this.Amount ,this.ImagePath);
        }

        public static bool DeleteCustomer(int ID)
        {
            return ClsDataCustomers.DeleteCustomer(ID);
        }

        public static bool IsCustomerExist(int ID)
        {
            return ClsDataCustomers.IsCustomerExist(ID);
        }

        public static bool IsPasswordExist(string Password)
        {
            return ClsDataCustomers.IsPasswordExist(Password);
        }
        public static bool IsAccountNumberExist(string AccountNumber)
        {
           return ClsDataCustomers.IsAccountNumberExist(AccountNumber);
        }

        public static DataTable FindCusomerByPhone(string Phone)
        {
            return ClsDataCustomers.FindCustomerByPhone(Phone);
        }

        public static DataTable FindCusomerByID(int ID)
        {
            return ClsDataCustomers.FindCustomerByID(ID);
        }

        public static DataTable FindCusomerByA_Number(string A_Number)
        {
            return ClsDataCustomers.FindCustomerByA_Number(A_Number);
        }

        public static DataTable FindCusomerByFirstName(string FirstName)
        {
            return ClsDataCustomers.FindCustomerByFirstName(FirstName);
        }

        public static DataTable ListCustomers()
        {
            return ClsDataCustomers.ListCustomers();
        }


        public static int TotalCustomers()
        {
            return ClsDataCustomers.TotalCustomers();
        }

        public static int CardNonBalance()
        {
           return ClsDataCustomers.CardNonBalance();
        }

        public static double TotalBalance()
        {
            return ClsDataCustomers.SumBalance();
        }

        public bool Save()
        {
            switch (Mode)
            {
                case Enmode.AddMode:

                    if (_AddNewCustomer())
                    {
                        Mode = Enmode.AddMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case Enmode.UpdateMode:

                    if (_UpdateCustomer())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
            return false;
        }
    }
}
