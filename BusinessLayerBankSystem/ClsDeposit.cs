using DataAccessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBankSystem
{
    public class ClsDeposit
    {
       
        public static DataTable ListDeposit()
        {
            return ClsDataDeposite.ListDeposit();
        }

        public static bool ConfirmDopsit(double Balance, string Password)
        {
            return ClsDataDeposite.ConfirmDeposit(Balance, Password);
        }

        public static bool DepositTransactionRecord(double Balance, int Customer_ID, int User_ID, DateTime Date_Time)
        {
            return ClsDataDeposite.DepositTransactionRecord(Balance, Customer_ID, User_ID, Date_Time);
        }

        public static int TotalDepositTransactionToday()
        {
            return ClsDataDeposite.TotalDepositTransactionToday(DateTime.Today);
        }

        public static DataTable FindByCustomerID(int Customer_ID)
        {
            return  ClsDataDeposite.FindDepositTransactionByCustomerID(Customer_ID);
        }

        public static DataTable FindByUserID(int User_ID)
        {
            return  ClsDataDeposite.FindDepositTransactionByUserID(User_ID);
        }

        public static DataTable FindByBalance(float Balance)
        {
            return  ClsDataDeposite.FindDepositTransactionByBalance(Balance);
        }

        public static DataTable FindByDateTime(DateTime Date_Time)
        {
            return ClsDataDeposite.FindDepositTransactionByDate_Time(Date_Time);
        }

        public static DataTable FindByDateTime_UserID(DateTime Date_Time, int UserID)
        {
            return ClsDataDeposite.FindDepositTransactionByDate_Time_UserID(Date_Time, UserID);
        }

        public static DataTable FindByDateTime_CustomerID(DateTime Date_Time, int CustomerID)
        {
            return ClsDataDeposite.FindDepositTransactionByDate_Time_CustomerID(Date_Time , CustomerID);
        }
        public static DataTable FindByDateTime_CustomerID_UserID(DateTime Date_Time, int CustomerID, int UserID)
        {
            return ClsDataDeposite.FindDepositTransactionByDate_Time_CustomerID_UserID(Date_Time , CustomerID , UserID);
        }

    }
}
