using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerBankSystem
{
    public class ClsDataDeposite
    {

        public static DataTable ListDeposit()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Deposit";

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


        public static bool ConfirmDeposit(double Balance, string Password)
        {
            int RowEffected;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);

           
            string Query = @"UPDATE Customers SET Amount = Amount + @Balance WHERE Password = @Password";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Balance", Balance);
            command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                RowEffected = command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                
                RowEffected = 0;
            }

        
            return RowEffected > 0;
        }


        public static bool DepositTransactionRecord(double  Balance,int Customer_ID , int User_ID ,DateTime Date_Time)
        {
            int RowEffected=0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);        

            string Query = @"Insert into Deposit values (@Balance , @Customer_ID , @User_ID , @Date_Time)";

            SqlCommand Command= new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@Balance", Balance);
            Command.Parameters.AddWithValue("@Customer_ID", Customer_ID);
            Command.Parameters.AddWithValue("@User_ID", User_ID);
            Command.Parameters.AddWithValue("@Date_Time", Date_Time);

            try
            {
                connection.Open();

                 RowEffected = Command.ExecuteNonQuery();

                connection.Close() ;
            }

            catch(Exception ex)
            {

            }

            return RowEffected > 0;
        }


        public static int TotalDepositTransactionToday(DateTime DateTimeToday)
        {
            int Total = 0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select Count(*) AS total_DepositTranactions from Deposit Where Cast([Date&Time] as Date)=@DateTimeToday";

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

        public static DataTable FindDepositTransactionByCustomerID(int CustomerID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Deposit Where Customer_ID = @CustomerID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@CustomerID", CustomerID);
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

        public static DataTable FindDepositTransactionByUserID(int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Deposit Where User_ID = @UserID";

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

        public static DataTable FindDepositTransactionByBalance(float Balance)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Deposit Where Amount Like @Balance";

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

        public static DataTable FindDepositTransactionByDate_Time(DateTime Date_Time)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Deposit Where Cast([Date&Time] as Date) = @Date_Time";

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

        public static DataTable FindDepositTransactionByDate_Time_CustomerID(DateTime Date_Time , int CustomerID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Deposit  Where Cast([Date&Time] as Date) = @Date_Time and Customer_ID = @CustomerID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Date_Time", Date_Time.Date);
            command.Parameters.AddWithValue("@CustomerID",CustomerID);
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

        public static DataTable FindDepositTransactionByDate_Time_UserID(DateTime Date_Time, int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Deposit Where   Cast([Date&Time] as Date) = @Date_Time and User_ID = @UserID";

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

        public static DataTable FindDepositTransactionByDate_Time_CustomerID_UserID(DateTime Date_Time, int CustomerID , int UserID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Deposit  Where Cast([Date&Time] as Date) = @Date_Time and Customer_ID = @CustomerID and User_ID = @UserID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Date_Time", Date_Time.Date);
            command.Parameters.AddWithValue("@CustomerID", CustomerID );
            command.Parameters.AddWithValue("@UserID",UserID );
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
