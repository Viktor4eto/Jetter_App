using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Jetter_App
{
    internal class authenticate
    {
        public static User authenticatedUser(string username, string password)
        {
            using (SqlConnection sqlCon = new SqlConnection(Program.getDatabase()))
            {
                sqlCon.Open();


                string loginQuery = "SELECT * FROM [User] Where Username=@Username AND Password=@Password";

                using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                {

                    loginCmd.CommandType = CommandType.Text;

                    loginCmd.Parameters.AddWithValue("@Username", username);
                    loginCmd.Parameters.AddWithValue("@Password", password);

                    SqlDataReader reader = loginCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        User user = new User
                        {
                            UserID = Convert.ToInt32(reader["UserID"]),
                            Username = Convert.ToString(reader["Username"]),
                            Password = Convert.ToString(reader["Password"]),
                            Email = Convert.ToString(reader["Email"]),
                            Role = Convert.ToString(reader["Role"]),
                            FirstName = Convert.ToString(reader["FirstName"]),
                            LastName = Convert.ToString(reader["LastName"]),
                            PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                            Address = Convert.ToString(reader["Address"]),
                            PaymentDetails = Convert.ToString(reader["PaymentDetails"])
                        };

                        return user;
                        


                    }

                    return null;
                }

            }

        }

        public static Vendor authenticatedVendor(string vendor, string email, string password)
        {
            using (SqlConnection sqlCon = new SqlConnection(Program.getDatabase()))
            {
                sqlCon.Open();


                string loginQuery = "SELECT * FROM Vendor Where VendorName=@VendorName AND Email=@Email AND VendorPassword=@VendorPassword";

                using (SqlCommand loginCmd = new SqlCommand(loginQuery, sqlCon))
                {

                    loginCmd.CommandType = CommandType.Text;

                    loginCmd.Parameters.AddWithValue("@VendorName", vendor);
                    loginCmd.Parameters.AddWithValue("@Email", email);
                    loginCmd.Parameters.AddWithValue("@VendorPassword", password);

                    SqlDataReader reader = loginCmd.ExecuteReader();

                    if (reader.Read())
                    {
                        Vendor Vendor = new Vendor()
                        {

                            VendorID = Convert.ToInt32(reader["VendorID"]),
                            VendorName = Convert.ToString(reader["VendorName"]),
                            ContactPerson = Convert.ToString(reader["ContactPerson"]),
                            Email = Convert.ToString(reader["Email"]),
                            PhoneNumber = Convert.ToString(reader["PhoneNumber"]),
                            Address = Convert.ToString(reader["Address"]),
                            VendorPassword = Convert.ToString(reader["VendorPassword"]),
                            
                        };

                        return Vendor;



                    }

                    return null;
                }

            }

        }
    }
}

