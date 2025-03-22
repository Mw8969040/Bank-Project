using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerBankSystem
{
    public class ClsDataCustomers
    {
        public static bool FindCustomer(int ID , ref string Firstname , ref string Lastname , ref string Email , ref string Phone , ref string AccountNumber , ref string Password , ref float Amount , ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection=new SqlConnection(DataAccess.ConnectionString);

            string Query = @"Select * from Customers where ID=@ID";

            SqlCommand Commmand=new SqlCommand(Query,connection);

            Commmand.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();

                SqlDataReader Reader = Commmand.ExecuteReader();

                if(Reader.Read()) // تحقق من وجود صف بيانات
{
                    IsFound = true;
                    Firstname = Reader["Firstname"].ToString(); // استخدم اسم العمود بدلاً من الفهرس
                    Lastname = Reader["Lastname"].ToString();
                    Email = Reader["Email"].ToString();
                    Phone = Reader["Phone"].ToString();
                    AccountNumber = Reader["AccountNumber"].ToString();
                    Password = Reader["Password"].ToString();
                    Amount = Convert.ToSingle(Reader["Amount"]); // Convert To Float
                    ImagePath = Reader["ImagePath"].ToString();
                }

                else
                {
                    IsFound = false;
                }

                Reader.Close();
            }

            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }

            return IsFound;
        }

        public static int AddNewCustomer(string Firstname , string Lastname , string Email , string Phone , string AccountNumber , string Password , float Amount , string ImagePath)
        {
           SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);

            string Query= @"insert into Customers values (@Firstname , @Lastname , @Email , @Phone , @AccountNumber , @Password , @Amount , @ImagePath)
                             SELECT SCOPE_IDENTITY();";

            SqlCommand command = new SqlCommand(Query,connection);

            command.Parameters.AddWithValue("@Firstname", Firstname);
            command.Parameters.AddWithValue("@Lastname", Lastname);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);


            try
            {
                connection.Open();

                object Result= command.ExecuteScalar();

                connection.Close() ;

                if (Result != null && int.TryParse(Result.ToString(), out int ResultID))
                {
                    return ResultID;
                }

            }

            catch(Exception ex)
            {
                return -1;
            }

            return -1;
        }

        public static bool UpdateCustomer(int ID, string Firstname, string Lastname, string Email, string Phone, string AccountNumber, string Password, float Amount , string ImagePath)
        {
            int RowEffected = 0;

          SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);

            string Query = @"UPDATE Customers 
                 SET
                     Firstname=@Firstname,
                     Lastname=@Lastname,
                     Email=@Email,
                     Phone=@Phone,
                     AccountNumber=@AccountNumber,
                     Password=@Password,
                     Amount=@Amount,
                     ImagePath=@ImagePath
                 WHERE ID=@ID";

            SqlCommand command = new SqlCommand(Query,connection);
            command.Parameters.AddWithValue ("@ID", ID);
            command.Parameters.AddWithValue("@Firstname", Firstname);
            command.Parameters.AddWithValue("@Lastname", Lastname);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber);
            command.Parameters.AddWithValue ("@Password", Password);
            command.Parameters.AddWithValue("@Amount", Amount);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);

            try
            {
                connection.Open();

                RowEffected = command.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowEffected > 0);
        }

        public static bool DeleteCustomer(int ID)
        {

            int RowAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);

            string Qurey = @"Delete Customers 
                                  Where ID=@ID";

            SqlCommand Command = new SqlCommand(Qurey, connection);
            Command.Parameters.AddWithValue("@ID", ID);


            try
            {
                connection.Open();
                RowAffected = Command.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                connection.Close();
            }

            return (RowAffected > 0);
        }

        public static bool IsCustomerExist(int ID)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);

            string Query = "Select found=1 from Customers where ID=@ID";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                object Reslult = Command.ExecuteScalar();

                if (Reslult != null)
                {
                    IsFound = true;
                }

            }

            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool IsPasswordExist(string Password)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);

            string Query = "Select found=1 from Customers where Password=@Password";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@Password", Password);

            try
            {
                connection.Open();
                object Reslult = Command.ExecuteScalar();

                if (Reslult != null)
                {
                    IsFound = true;
                }

            }

            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }

        public static bool IsAccountNumberExist(string AccountNumber)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);

            string Query = "Select found=1 from Customers where AccountNumber=@AccountNumber";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@AccountNumber", AccountNumber);

            try
            {
                connection.Open();
                object Reslult = Command.ExecuteScalar();

                if (Reslult != null)
                {
                    IsFound = true;
                }

            }

            catch (Exception ex)
            {
                IsFound = false;
            }
            finally
            {
                connection.Close();
            }
            return IsFound;
        }


        public static DataTable FindCustomerByPhone(string Phone)
        {
            DataTable dt = new DataTable();

            SqlConnection connection =new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Customers Where Phone like @Phone";

            SqlCommand command =new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Phone",Phone + "%");
            try
            {
                connection.Open();

                SqlDataReader Reader = command.ExecuteReader();

                if(Reader.HasRows)
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


        public static DataTable FindCustomerByID(int ID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Customers Where ID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);
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

        public static DataTable FindCustomerByA_Number (string AccountNumber)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Customers Where AccountNumber Like @AccountNumber";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AccountNumber", AccountNumber + "%");
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

        public static DataTable FindCustomerByFirstName(string FirstName)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Customers Where FirstName like @FirstName";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@FirstName", FirstName + "%");  

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

        public static int TotalCustomers()
        {
            int Total = 0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select Count(ID) AS total_Coustomers from Customers ";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

               object reslult= command.ExecuteScalar();

                if(reslult != null)
                {
                    Total= Convert.ToInt32(reslult);
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



        public static double SumBalance()
        {
            double Total = 0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select sum(Amount) AS Total_Amount from Customers ";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object reslult = command.ExecuteScalar();

                if (reslult != null)
                {
                    Total = Convert.ToDouble(reslult);
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

        public static int CardNonBalance()
        {
            int CardZeroBalance = 0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select count(ID) AS CardNonBalance from Customers Where Amount=0";

            SqlCommand command = new SqlCommand(Query, connection);

            try
            {
                connection.Open();

                object reslult = command.ExecuteScalar();

                if (reslult != null)
                {
                    CardZeroBalance = Convert.ToInt32(reslult);
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

            return CardZeroBalance;
        }

        public static DataTable ListCustomers()
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select ID , Firstname , Lastname ,Email , Phone ,AccountNumber , Password ,Amount from Customers";

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
    }
}
