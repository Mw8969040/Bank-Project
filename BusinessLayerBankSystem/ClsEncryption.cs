using DataAccessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBankSystem
{
    public class ClsEncryption
    {
        public static string Encryption(string Password, string Key = "2468")
        {
            string EncryptedPassword = "";

            for (int i = 0; i < Password.Length; i++)
            {
                // تحويل الرقم إلى قيمة عددية صحيحة
                int passwordDigit = int.Parse(Password[i].ToString());

                // الحصول على قيمة المفتاح للدور الحالي
                int keyDigit = int.Parse(Key[i].ToString());

                // إضافة قيمة المفتاح إلى الرقم المحول
                int encryptedValue = (passwordDigit + keyDigit) %10;

                EncryptedPassword += encryptedValue;
            }

            return EncryptedPassword;
        }


    }
}
