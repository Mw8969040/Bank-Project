using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerBankSystem
{
    public class ClsDataCurrency
    {
        public static DataTable ListCurrency()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Currency";

            SqlCommand command = new SqlCommand(Query, connection);
            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception (optional)
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


        public static float GetRate(string Currency_Code)
        {

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select exchange_rate as rate from Currency Where Currency_Code = @CurrencyCode";
            float Rate=0;

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyCode", Currency_Code);

            try
            {
                connection.Open();

                object Result = command.ExecuteScalar();

                if( Result != null  && float.TryParse(Result.ToString(),out float rate))
                {
                    Rate=rate;
                }
            }
            catch (Exception ex)
            {
                // Handle exception (optional)
            }
            finally
            {
                connection.Close();
            }

            return Rate;
        }

      public static bool UpdateRate(int ID , decimal Rate)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"UPDATE Currency 
                             SET exchange_rate = @Rate
                             WHERE ID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Rate", Rate);
            command.Parameters.AddWithValue("@ID", ID);
            

            try
            {
                connection.Open();
                rowsAffected = command.ExecuteNonQuery();
                
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }
           

            return (rowsAffected > 0);
      }


        public static DataTable FindByCountryName(string CountryName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Currency Where Country_Name like @CountryName";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CountryName", CountryName + "%");
            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception (optional)
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

         public static DataTable FindByCurrencyName(string CurrencyName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Currency Where Currency_Name like @CurrencyName";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyName", CurrencyName + "%");
            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception (optional)
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

         public static DataTable FindByRate(float Rate)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Currency Where Exchange_Rate like @Rate";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Rate", Rate + "%");
            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception (optional)
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }

         public static DataTable FindByCurrencyCode(string CurrencyCode)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Currency Where Currency_Code like @CurrencyCode";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CurrencyCode", CurrencyCode + "%");
            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if (Reader.HasRows)
                {
                    dt.Load(Reader);
                }

                Reader.Close();
            }
            catch (Exception ex)
            {
                // Handle exception (optional)
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }


    }

}

