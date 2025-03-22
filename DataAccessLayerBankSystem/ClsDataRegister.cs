using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerBankSystem
{
    public class ClsDataRegister
    {

        public static DataTable ListRegisters()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Registers";

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

        public static bool RecordRegisterUser(DateTime Date_Time , int UserID)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);

            string Query = @"Insert into Registers values (@DateTime , @UserID)";

            SqlCommand Command = new SqlCommand(Query, connection);
           
            Command.Parameters.AddWithValue("@UserID", UserID);
            Command.Parameters.AddWithValue("@DateTime", Date_Time);

            try
            {
                connection.Open();

                RowEffected = Command.ExecuteNonQuery();

                connection.Close();
            }

            catch (Exception ex)
            {

            }

            return RowEffected > 0;
        }

        public static int TotalRegistersToday(DateTime DateTimeToday)
        {
            int Total = 0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select Count(*) AS total_Registers from Registers Where Cast(DateTime as Date)=@DateTimeToday";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@DateTimeToday", DateTimeToday.Date);

            try
            {
                connection.Open();

                object reslult = command.ExecuteScalar();

                if (reslult != null)
                {
                    Total = Convert.ToInt32(reslult);
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

            return Total;
        }
        public static DataTable FindRegisterByUserID(int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Registers Where UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@UserID", UserID);
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

        public static DataTable FindRegisterByDate_Time(DateTime Date_Time)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Registers Where Cast(DateTime as Date) = @Date_Time";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Date_Time", Date_Time.Date);
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

        public static DataTable FindRegisterByDate_Time_UserID(DateTime Date_Time, int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Registers Where   Cast(DateTime as Date) = @Date_Time and UserID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Date_Time", Date_Time.Date);
            command.Parameters.AddWithValue("@UserID", UserID);
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

