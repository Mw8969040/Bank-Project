using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerBankSystem
{
    public class ClsDataTransfer
    {

        public static DataTable ListTransfer()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer";

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

        public static bool TransferTransactionRecord(double Balance, int CustomerIDFrom,int CustomerIDTo, int User_ID,DateTime Date_Time)
        {
            int RowEffected = 0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);

            string Query = @"Insert into Transfer values (@CustomerIDFrom ,@CustomerIDTo , @Balance ,  @UserID , @Date_Time)";

            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@CustomerIDTo", CustomerIDTo);
            Command.Parameters.AddWithValue("@CustomerIDFrom", CustomerIDFrom);
            Command.Parameters.AddWithValue("@Balance", Balance);
            Command.Parameters.AddWithValue("@UserID", User_ID);
            Command.Parameters.AddWithValue("@Date_Time", Date_Time);

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


        public static int TotalTransferTransactionToday(DateTime dateTimeToday)
        {
            int total = 0;

            string query = @"
                     SELECT COUNT(*) AS total_TransferTransactions 
                     FROM Transfer 
                     WHERE CAST([Date&Time] AS DATE) = @DateOnly";

            using (SqlConnection connection = new SqlConnection(DataAccess.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@DateOnly", dateTimeToday.Date);

                    try
                    {
                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            total = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        //Handle as you like
                    }
                }
            }

            return total;
        }

        public static DataTable FindTransferTransactionByCustomerIDFrom(int CustomerIDFrom)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer Where CustomerIDFrom = @CustomerIDFrom";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerIDFrom", CustomerIDFrom);
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
        public static DataTable FindTransferTransactionByCustomerIDTo(int CustomerIDTo)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer Where CustomerIDTo = @CustomerIDTo";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerIDTo", CustomerIDTo);
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

        public static DataTable FindTransferTransactionByUserID(int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer Where UserID = @UserID";

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

        public static DataTable FindTransferTransactionByBalance(float Balance)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer Where Amount Like @Balance";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Balance", Balance + "%");
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

        public static DataTable FindTransferTransactionByDate_Time(DateTime Date_Time)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer Where Cast([Date&Time] as Date) = @Date_Time";

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

        public static DataTable FindTransferTransactionByDate_Time_CustomerIDFrom_CustomerIDTo_UserID(DateTime Date_Time, int CustomerIDFrom , int CustomerIDTo , int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer  Where Cast([Date&Time] as Date) = @Date_Time and CustomerIDFrom = @CustomerIDFrom and CustomerIDTo =@CustomerIDTo and UserID=@UserID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Date_Time", Date_Time.Date);
            command.Parameters.AddWithValue("@CustomerIDTo", CustomerIDTo);
            command.Parameters.AddWithValue("@CustomerIDFrom", CustomerIDFrom);
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

        public static DataTable FindTransferTransactionByDate_Time_CustomerIDFrom_CustomerIDTo(DateTime Date_Time, int CustomerIDFrom, int CustomerIDTo)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer  Where Cast([Date&Time] as Date) = @Date_Time and CustomerIDFrom = @CustomerIDFrom and CustomerIDTo =@CustomerIDTo";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Date_Time", Date_Time.Date);
            command.Parameters.AddWithValue("@CustomerIDTo", CustomerIDTo);
            command.Parameters.AddWithValue("@CustomerIDFrom", CustomerIDFrom);

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


        public static DataTable FindTransferTransactionByDate_Time_CustomerIDFrom_UserID(DateTime Date_Time, int CustomerIDFrom, int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer  Where Cast([Date&Time] as Date) = @Date_Time and CustomerIDFrom = @CustomerIDFrom and UserID=@UserID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Date_Time", Date_Time.Date);
            command.Parameters.AddWithValue("@CustomerIDFrom", CustomerIDFrom);
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

        public static DataTable FindTransferTransactionByDate_Time_CustomerIDTo_UserID(DateTime Date_Time, int CustomerIDTo, int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer  Where Cast([Date&Time] as Date) = @Date_Time and CustomerIDTo = @CustomerIDTo and UserID=@UserID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Date_Time", Date_Time.Date);
            command.Parameters.AddWithValue("@CustomerIDTo", CustomerIDTo);
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
        public static DataTable FindTransferTransactionByDate_Time_CustomerIDTo(DateTime Date_Time, int CustomerIDTo)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer  Where Cast([Date&Time] as Date) = @Date_Time and CustomerIDTo = @CustomerIDTo";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Date_Time", Date_Time.Date);
            command.Parameters.AddWithValue("@CustomerIDTo", CustomerIDTo);

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

        public static DataTable FindTransferTransactionByDate_Time_CustomerIDFrom(DateTime Date_Time, int CustomerIDFrom)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer  Where Cast([Date&Time] as Date) = @Date_Time and CustomerIDFrom = @CustomerIDFrom";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Date_Time", Date_Time.Date);
            command.Parameters.AddWithValue("@CustomerIDFrom", CustomerIDFrom);

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

        public static DataTable FindTransferTransactionByDate_Time_UserID(DateTime Date_Time, int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Transfer  Where Cast([Date&Time] as Date) = @Date_Time and UserID = @UserID";

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
