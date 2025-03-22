using DataAccessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBankSystem
{
    public class ClsWithdraw
    {
        public static DataTable ListWithdraw()
        {
            return ClsDataWithdraw.ListWithdraw();
        }

        public static bool ConfirmWithdraw(double Balance, string Password)
        {
            return ClsDataWithdraw.ConfirmWithdraw(Balance, Password);
        }

        public static bool WithdrawTransactionRecord(double Balance, int Customer_ID, int User_ID, DateTime Date_Time)
        {
            return ClsDataWithdraw.WithdrawTransactionRecord(Balance, Customer_ID, User_ID, Date_Time);
        }

        public static int TotalWithdrawTransactionToday()
        {
            return ClsDataWithdraw.TotalWithdrawTransactionToday(DateTime.Today);
        }

        public static DataTable FindByCustomerID(int Customer_ID)
        {
            return ClsDataWithdraw.FindWithdrawTransactionByCustomerID(Customer_ID);
        }

        public static DataTable FindByUserID(int User_ID)
        {
            return ClsDataWithdraw.FindWithdrawTransactionByUserID(User_ID);
        }

        public static DataTable FindByBalance(float Balance)
        {
            return ClsDataWithdraw.FindWithdrawTransactionByBalance(Balance);
        }

        public static DataTable FindByDateTime(DateTime Date_Time)
        {
            return ClsDataWithdraw.FindWithdrawTransactionByDate_Time(Date_Time);
        }

        public static DataTable FindByDateTime_UserID(DateTime Date_Time, int UserID)
        {
            return ClsDataWithdraw.FindWithdrawTransactionByDate_Time_UserID(Date_Time, UserID);
        }

        public static DataTable FindByDateTime_CustomerID(DateTime Date_Time, int CustomerID)
        {
            return ClsDataWithdraw.FindWithdrawTransactionByDate_Time_CustomerID(Date_Time, CustomerID);
        }
        public static DataTable FindByDateTime_CustomerID_UserID(DateTime Date_Time, int CustomerID, int UserID)
        {
            return ClsDataWithdraw.FindWithdrawTransactionByDate_Time_CustomerID_UserID(Date_Time, CustomerID, UserID);
        }


    }
}
