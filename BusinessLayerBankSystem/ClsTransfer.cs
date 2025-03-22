using DataAccessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBankSystem
{
    public class ClsTransfer
    {
        public static DataTable ListTransfer()
        {
            return ClsDataTransfer.ListTransfer();
        }

        public static bool TransferTransactionRecord(double Balance, int CustomerIDFrom, int CustomerIDTo, int User_ID, DateTime Date_Time)
        {
            return ClsDataTransfer.TransferTransactionRecord(Balance, CustomerIDFrom, CustomerIDTo, User_ID, Date_Time);
        }

        public static int TotalTransferTransactionToday()
        {
            return ClsDataTransfer.TotalTransferTransactionToday(DateTime.Today);
        }

        public static DataTable FindTransferTransactionByCustomerIDFrom(int CustomerIDFrom)
        {
            return ClsDataTransfer.FindTransferTransactionByCustomerIDFrom(CustomerIDFrom);
        }

        public static DataTable FindTransferTransactionByCustomerIDTo(int CustomerIDTo)
        {
            return ClsDataTransfer.FindTransferTransactionByCustomerIDTo(CustomerIDTo);
        }
        public static DataTable FindTransferTransactionByUserID(int UserID)
        {
            return ClsDataTransfer.FindTransferTransactionByUserID((UserID));
        }

        public static DataTable FindTransferTransactionByBalance(float Balance)
        {
            return ClsDataTransfer.FindTransferTransactionByBalance(Balance);
        }

        public static DataTable FindTransferTransactionByDate_Time(DateTime Date_Time)
        {
            return ClsDataTransfer.FindTransferTransactionByDate_Time(Date_Time);
        }

        public static DataTable FindTransferTransactionByDate_Time_CustomerIDFrom_CustomerIDTo_UserID(DateTime Date_Time, int CustomerIDFrom, int CustomerIDTo, int UserID)
        {
            return ClsDataTransfer.FindTransferTransactionByDate_Time_CustomerIDFrom_CustomerIDTo_UserID(Date_Time, CustomerIDFrom, CustomerIDTo, UserID);
        }

        public static DataTable FindTransferTransactionByDate_Time_CustomerIDFrom_CustomerIDTo(DateTime Date_Time, int CustomerIDFrom, int CustomerIDTo)
        {
            return ClsDataTransfer.FindTransferTransactionByDate_Time_CustomerIDFrom_CustomerIDTo(Date_Time, CustomerIDFrom, CustomerIDTo);
        }

        public static DataTable FindTransferTransactionByDate_Time_CustomerIDFrom_UserID(DateTime Date_Time, int CustomerIDFrom, int UserID)
        {
            return ClsDataTransfer.FindTransferTransactionByDate_Time_CustomerIDFrom_UserID(Date_Time, CustomerIDFrom, UserID);
        }

        public static DataTable FindTransferTransactionByDate_Time_CustomerIDTo_UserID(DateTime Date_Time, int CustomerIDTo, int UserID)
        {
            return ClsDataTransfer.FindTransferTransactionByDate_Time_CustomerIDTo_UserID(Date_Time, CustomerIDTo, UserID);
        }

        public static DataTable FindTransferTransactionByDate_Time_CustomerIDTo(DateTime Date_Time, int CustomerIDTo)
        {
            return ClsDataTransfer.FindTransferTransactionByDate_Time_CustomerIDTo(Date_Time, CustomerIDTo);
        }

        public static DataTable FindTransferTransactionByDate_Time_CustomerIDFrom(DateTime Date_Time, int CustomerIDFrom)
        {
            return ClsDataTransfer.FindTransferTransactionByDate_Time_CustomerIDFrom(Date_Time, CustomerIDFrom);
        }

        public static DataTable FindTransferTransactionByDate_Time_UserID(DateTime Date_Time, int UserID)
        {
            return ClsDataTransfer.FindTransferTransactionByDate_Time_UserID(Date_Time, UserID);
        }
    }
}
