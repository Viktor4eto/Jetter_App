using Microsoft.Identity.Client.NativeInterop;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Jetter_App
{
    public partial class Book : Form
    {
        private User user;
        public Book(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private bool GetAvailabilityForAsset()
        {
            bool availability = false;

            string query = "SELECT Availability FROM Asset WHERE AssetID = @AssetID";

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AssetID", assetId.Text);

                connection.Open();
                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    availability = (bool)result;
                }
            }

            return availability;
        }

        public static void UpdateAvailability()
        {
            string query = @"UPDATE Asset
                            SET Availability = CASE 
                                WHEN (
                                    SELECT COUNT(*)
                                    FROM Booking b
                                    WHERE b.AssetID = Asset.AssetID AND DATEADD(day, 1, b.BookingEndDate) > GETDATE()
                                ) >= (
                                    SELECT QuantityAvailable
                                    FROM VendorAsset va
                                    WHERE va.AssetID = Asset.AssetID
                                )
                                THEN 0 ELSE 1 
                            END";

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        private decimal getTotalAmount()
        {
            decimal dailyRate = 0;
            string query = "SELECT [DailyRate] FROM [Jetter].[dbo].[Asset] WHERE [AssetID] = @AssetID";

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AssetID", assetId.Text);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    dailyRate = Convert.ToDecimal(reader["DailyRate"]);
                }
                reader.Close();
            }

            TimeSpan difference = endDate.SelectionStart.Subtract(startDate.SelectionStart);
            int dif = difference.Days + 1;

            return dailyRate * dif;
        }

        private void booking_Click(object sender, EventArgs e)
        {
            UpdateAvailability();

            using (SqlConnection sqlCon = new SqlConnection(Program.getDatabase()))
            {
                sqlCon.Open();

                string idExists = "SELECT COUNT(*) FROM Asset WHERE AssetID = @AssetID";
                string available = "SELECT Availability FROM Asset WHERE AssetID = @AssetID";
                string insert = "INSERT INTO Booking (UserID, AssetID, BookingStartDate, BookingEndDate, TotalAmount, BookingStatus) " +
                "OUTPUT INSERTED.BookingID " + 
                "VALUES (@UserID, @AssetID, @BookingStartDate, @BookingEndDate, @TotalAmount, @BookingStatus)";
                string payment = "INSERT INTO Payment (BookingID, Amount, PaymentStatus) " +
               "VALUES (@BookingID, @Amount, @PaymentStatus)";


                using (SqlCommand command = new SqlCommand(idExists, sqlCon))
                {
                    command.Parameters.AddWithValue("@AssetID", assetId.Text);

                    int count = (int)command.ExecuteScalar();

                    if (count > 0)
                    {


                        if (GetAvailabilityForAsset())
                        {
                            decimal amount = getTotalAmount();

                            SqlCommand com = new SqlCommand(insert, sqlCon);
                            com.Parameters.AddWithValue("@UserID", this.user.UserID);
                            com.Parameters.AddWithValue("@AssetID", assetId.Text);
                            com.Parameters.AddWithValue("@BookingStartDate", startDate.SelectionStart);
                            com.Parameters.AddWithValue("@BookingEndDate", endDate.SelectionStart);
                            com.Parameters.AddWithValue("@TotalAmount", amount);
                            com.Parameters.AddWithValue("@BookingStatus", "pending");

                            int bookingID = (int)com.ExecuteScalar();

                            MessageBox.Show("Please consider paying as your booking is not confirmed until you do so.", "Asset booked.", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            UpdateAvailability();

                            SqlCommand cmd = new SqlCommand(payment, sqlCon);
                            cmd.Parameters.AddWithValue("@BookingID", bookingID);
                            cmd.Parameters.AddWithValue("@Amount", amount);
                            cmd.Parameters.AddWithValue("@PaymentStatus", "pending");

                            cmd.ExecuteNonQuery();
                        }
                        else
                        {
                            MessageBox.Show("Asset is not available. Try with a different Asset.", "Asset is not available", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }



                    }
                    else
                    {
                        MessageBox.Show("Asset ID doesn't exist. Try with a different Asset ID.", "Asset ID doesn't exist", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void toPayment_Click(object sender, EventArgs e)
        {
            Payment toPay = new Payment(this.user);
            toPay.Show();
        }
    }
}
