using DataAccessLayerBankSystem;
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
    public class ClsUsers
    {
        enum Enmode { AddMode = 0, UpdateMode = 1 }
        Enmode Mode;
        public int ID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }

        public string ImagePath { get; set; }

        private ClsUsers(int ID, string Firstname, string Lastname, string Email, string Phone, string Username, string Password, int Permission, string imagePath)
        {
            this.ID = ID;
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Email = Email;
            this.Phone = Phone;
            this.Username = Username;
            this.Password = Password;
            this.Permission = Permission;
            Mode = Enmode.UpdateMode;
            ImagePath = imagePath;
        }

        // Default constructor for adding a new user
        public ClsUsers()
        {
            Mode = Enmode.AddMode;
            ID = -1;
            Firstname = "";
            Lastname = "";
            Email = "";
            Phone = "";
            Username = "";
            Password = "";
            Permission = 0;
        }

        public static ClsUsers Find(int ID)
        {
            string Firstname = "", Lastname = "", Email = "", Phone = "", Username = "", Password = "" , ImagePath="";
            int Permission = 0;

            if (ClsDataUsers.FindUser(ID, ref Firstname, ref Lastname, ref Email, ref Phone, ref Username, ref Password, ref Permission , ref ImagePath))
            {
                return new ClsUsers(ID, Firstname, Lastname, Email, Phone, Username, Password, Permission,ImagePath);
            }
            else
            {
                return null;
            }
        }

        public static ClsUsers Find(string Username)
        {
            string Firstname = "", Lastname = "", Email = "", Phone = "", Password = "" , ImagePath="";
            int Permission = 0 , ID =0 ;

            if (ClsDataUsers.FindUser(ref ID, ref Firstname, ref Lastname, ref Email, ref Phone, Username, ref Password, ref Permission , ref ImagePath))
            {
                return new ClsUsers(ID, Firstname, Lastname, Email, Phone, Username, Password, Permission,ImagePath);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewUser()
        {
            this.ID = ClsDataUsers.AddNewUser(this.Firstname, this.Lastname, this.Email, this.Phone, this.Username, this.Password, this.Permission,this.ImagePath);
            return this.ID != -1;
        }

        private bool _UpdateUser()
        {
            return ClsDataUsers.UpdateUser(this.ID, this.Firstname, this.Lastname, this.Email, this.Phone, this.Username, this.Password, this.Permission,this.ImagePath);
        }

        public static bool DeleteUser(int ID)
        {
            return ClsDataUsers.DeleteUser(ID);
        }

        public static bool IsUserExist(int ID)
        {
            return ClsDataUsers.IsUserExist(ID);
        }

        public static DataTable ListUsers()
        {
            return ClsDataUsers.ListUsers();
        }

        public static DataTable FindUserByUsername(string Username)
        {
            return ClsDataUsers.FindCustomerByUsername(Username);
        }

        public static bool IsPasswordExist(string Password)
        {
            return ClsDataUsers.IsPasswordExist(Password);
        }

        public static bool IsUserNameExist(string Username)
        {
            return ClsDataUsers.IsUserNameExist(Username);
        }

        public static int TotalUsers()
        {
            return ClsDataUsers.TotalUsers();
        }
        public static DataTable FindUserByPhone(string Phone)
        {
            return ClsDataUsers.FindUserByPhone(Phone);
        }

        public static DataTable FindUserByID(int ID)
        {
            return ClsDataUsers.FindUserByID(ID);
        }

        public static DataTable FindUserByFirstname(string Firstname)
        {
            return ClsDataUsers.FindUserByFirstname(Firstname);
        }



        public bool Save()
        {
            switch (Mode)
            {
                case Enmode.AddMode:
                    if (_AddNewUser())
                    {
                        Mode = Enmode.AddMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                case Enmode.UpdateMode:
                    if (_UpdateUser())
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
