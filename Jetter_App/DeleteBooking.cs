using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jetter_App
{
    public partial class DeleteBooking : Form
    {
        public DeleteBooking(User user)
        {
            InitializeComponent();

            List<int> bookingIDs = new List<int>();

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                connection.Open();

                string query = "SELECT BookingID FROM Booking WHERE UserID = @userId";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@userId", user.UserID);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bookingIDs.Add(reader.GetInt32(0));
                        }
                    }
                }
            }

            foreach (int bookingID in bookingIDs)
            {
                comboBox1.Items.Add(bookingID);
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
                {
                    connection.Open();

                    string deleteBookingQuery = "DELETE FROM Booking WHERE BookingID = @bookingID";

                    string deletePaymentQuery = "DELETE FROM Payment WHERE BookingID = @bookingID";

                    using (SqlCommand command = new SqlCommand(deletePaymentQuery, connection))
                    {
                        command.Parameters.AddWithValue("@bookingID", comboBox1.SelectedItem);
                        command.ExecuteNonQuery();
                    }

                    using (SqlCommand command = new SqlCommand(deleteBookingQuery, connection))
                    {
                        command.Parameters.AddWithValue("@bookingID", comboBox1.SelectedItem);
                        command.ExecuteNonQuery();
                    }

                    Book.UpdateAvailability();

                     
                }
            }
        }
    }
}
