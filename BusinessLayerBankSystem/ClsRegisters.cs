using DataAccessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBankSystem
{
    public class ClsRegisters
    {
        public static DataTable ListRegisters()
        {
            return ClsDataRegister.ListRegisters();
        }

        public static bool RecordRegisterUser(int UserID)
        {
            return ClsDataRegister.RecordRegisterUser(DateTime.Now,UserID);
        }

        public static int TotalRegisterPerDay()
        {
            return ClsDataRegister.TotalRegistersToday(DateTime.Now);
        }

        public static DataTable FindRegisterByUserID(int UserID)
        {
            return ClsDataRegister.FindRegisterByUserID(UserID);
        }

        public static DataTable FindRegisterByDate_Time(DateTime Date_Time)
        {
            return ClsDataRegister.FindRegisterByDate_Time(Date_Time);
        }

        public static DataTable FindRegiterByUserID_DateTime(int UserID , DateTime Date_Time)
        {
            return ClsDataRegister.FindRegisterByDate_Time_UserID(Date_Time,UserID);
        }
    }
}
