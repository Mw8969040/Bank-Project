using DataAccessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBankSystem
{
    public class ClsDecryption
    {
        public static string Decryption(string Password, string Key = "2468")
        {
            string DecryptedPassword = "";

            for (int i = 0; i < Password.Length; i++)
            {
                // تحويل الرقم إلى قيمة عددية صحيحة
                int passwordDigit = int.Parse(Password[i].ToString());

                // الحصول على قيمة المفتاح للدور الحالي
                int keyDigit = int.Parse(Key[i].ToString());

                int decryptedDigit =(passwordDigit - keyDigit + 10) %10 ;

                DecryptedPassword+= decryptedDigit.ToString();
            }

            return DecryptedPassword;
        }

    }
}
