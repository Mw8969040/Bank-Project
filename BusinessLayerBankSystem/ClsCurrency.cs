using DataAccessLayerBankSystem;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayerBankSystem
{
    public class ClsCurrency
    {
        public static DataTable ListCurrency()
        {
          return ClsDataCurrency.ListCurrency();
        }

        public static float GetRate(String CurrencyCode)
        {
            return ClsDataCurrency.GetRate(CurrencyCode);
        }

        public static bool UpdateRate(int ID , decimal Rate)
        {
            return ClsDataCurrency.UpdateRate(ID, Rate);
        }

        public static DataTable FindByCountryName(string CountryName)
        {
            return ClsDataCurrency.FindByCountryName(CountryName);
        }

        public static DataTable FindByCurrencyName(string currencyName)
        {
            return ClsDataCurrency.FindByCurrencyName(currencyName);
        }

        public static DataTable FindByRate(float  Rate)
        {
            return ClsDataCurrency.FindByRate(Rate);
        }

        public static DataTable FindByCurrencyCode(String CurrencyCode)
        {
            return ClsDataCurrency.FindByCurrencyCode(CurrencyCode);
        }
    }
}
