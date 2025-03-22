using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerBankSystem;

namespace DataAccessLayerBankSystem
{
    public class ClsDataUsers
    {
        public static bool FindUser(int ID, ref string Firstname, ref string Lastname, ref string Email, ref string Phone, ref string Username, ref string Password, ref int Permission, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Users where ID=@ID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    Firstname = reader["Firstname"].ToString();
                    Lastname = reader["Lastname"].ToString();
                    Email = reader["Email"].ToString();
                    Phone = reader["Phone"].ToString();
                    Username = reader["Username"].ToString();
                    Password = reader["Password"].ToString();
                    Permission = int.Parse(reader["Permissions"].ToString());
                    ImagePath = reader["ImagePath"].ToString();

                }
                reader.Close();
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

        public static bool FindUser(ref int ID, ref string Firstname, ref string Lastname, ref string Email, ref string Phone, string Username, ref string Password, ref int Permission, ref string ImagePath)
        {
            bool IsFound = false;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Users where Username=@Username";

            SqlCommand command = new SqlCommand(Query, connection);

            command.Parameters.AddWithValue("@Username", Username);

            try
            {
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    IsFound = true;
                    ID = (int) reader["ID"];
                    Firstname = reader["Firstname"].ToString();
                    Lastname = reader["Lastname"].ToString();
                    Email = reader["Email"].ToString();
                    Phone = reader["Phone"].ToString();
                    Password = reader["Password"].ToString();
                    Permission = int.Parse(reader["Permissions"].ToString());
                    ImagePath = reader["ImagePath"].ToString();

                }
                reader.Close();
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



        public static int AddNewUser(string Firstname, string Lastname, string Email, string Phone, string Username, string Password, int Permission, string ImagePath)
        {
            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"INSERT INTO Users (Firstname, Lastname, Email, Phone, Username, Password, ImagePath, Permissions)
                     VALUES (@Firstname, @Lastname, @Email, @Phone, @Username, @Password, @ImagePath, @Permissions);
                     SELECT SCOPE_IDENTITY();";

                  SqlCommand command = new SqlCommand(Query, connection);
                  command.Parameters.AddWithValue("@Firstname", Firstname);
                  command.Parameters.AddWithValue("@Lastname", Lastname);
                  command.Parameters.AddWithValue("@Email", Email);
                  command.Parameters.AddWithValue("@Phone", Phone);
                  command.Parameters.AddWithValue("@Username", Username);
                  command.Parameters.AddWithValue("@Password", Password);
                  command.Parameters.AddWithValue("@ImagePath", ImagePath);
                  command.Parameters.AddWithValue("@Permissions", Permission);

            try
            {
                connection.Open();
                object result = command.ExecuteScalar();
                connection.Close();

                if (result != null && int.TryParse(result.ToString(), out int resultID))
                {
                    return resultID;
                }
            }
            catch (Exception ex)
            {
               
                return -1;
            }

            return -1;
        }


        public static bool UpdateUser(int ID, string Firstname, string Lastname, string Email, string Phone, string Username, string Password, int Permissions ,string ImagePath)
        {
            int rowsAffected = 0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"UPDATE Users 
                             SET Firstname = @Firstname, Lastname = @Lastname, Email = @Email, Phone = @Phone, 
                                 Username = @Username, Password = @Password, Permissions = @Permissions , ImagePath=@ImagePath
                             WHERE ID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Firstname", Firstname);
            command.Parameters.AddWithValue("@Lastname", Lastname);
            command.Parameters.AddWithValue("@Email", Email);
            command.Parameters.AddWithValue("@Phone", Phone);
            command.Parameters.AddWithValue("@Username", Username);
            command.Parameters.AddWithValue("@Password", Password);
            command.Parameters.AddWithValue("@Permissions", Permissions);
            command.Parameters.AddWithValue("@ImagePath", ImagePath);
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

        public static bool DeleteUser(int ID)
        {
            int rowsAffected = 0;
            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"DELETE FROM Users WHERE ID = @ID";

            SqlCommand command = new SqlCommand(Query, connection);
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

        public static bool IsUserExist(int ID)
        {
            bool isFound = false;
            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string query = "SELECT COUNT(1) FROM Users WHERE ID = @ID";

            SqlCommand command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@ID", ID);

            try
            {
                connection.Open();
                int result = Convert.ToInt32(command.ExecuteScalar());
                if (result > 0)
                {
                    isFound = true;
                }
            }
            catch (Exception ex)
            {
                isFound = false;
            }
            finally
            {
                connection.Close();
            }

            return isFound;
        }

        public static DataTable ListUsers()
        {
            DataTable dt = new DataTable();
            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string query = @"select  ID ,Firstname , Lastname , Email ,Phone , Username , Password ,Permissions from Users";

            SqlCommand command = new SqlCommand(query, connection);

            try
            {
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    dt.Load(reader);
                }
                reader.Close();
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

        public static DataTable FindUserByPhone(string Phone)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Users Where Phone like @Phone";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Phone", Phone + "%");
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

        public static DataTable FindUserByID(int ID)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Users Where ID = @ID";

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

        public static DataTable FindUserByFirstname(string Firstname)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Users Where Firstname like @Firstname";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Firstname", Firstname + "%");
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

        public static DataTable FindCustomerByUsername(string Username)
        {
            DataTable dt = new DataTable();

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select * from Users Where Username like @Username";

            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@Username", Username + "%");
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


        public static bool IsUserNameExist(string UserName)
        {
            bool IsFound = false;
            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);

            string Query = "Select found=1 from Users where UserName=@UserName";
            SqlCommand Command = new SqlCommand(Query, connection);
            Command.Parameters.AddWithValue("@UserName", UserName);

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

            string Query = "Select found=1 from Users where Password=@Password";
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

        public static int TotalUsers()
        {
            int Total = 0;

            SqlConnection connection = new SqlConnection(DataAccess.ConnectionString);
            string Query = @"Select Count(ID) AS total_Users from Users ";

            SqlCommand command = new SqlCommand(Query, connection);

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




    }

}
