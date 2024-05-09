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
    public partial class YourBookings : Form
    {
        private User user;
        public YourBookings(User user)
        {
            InitializeComponent();
            this.user = user;
            Load(null, null);
            
        }

        public void Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                connection.Open();


                string query = @"
                SELECT b.BookingID AS 'Booking ID', b.AssetID AS 'Asset ID', a.AssetType AS Type, a.Location, a.DailyRate AS 'Daily Rate',
                       b.BookingStartDate AS 'Start Date', b.BookingEndDate AS 'End Date', b.TotalAmount, b.BookingStatus
                FROM  Booking b
                INNER JOIN Asset a ON b.AssetID = a.AssetID
                WHERE b.UserID=@UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", this.user.UserID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }

            }

            personalBookings.DataSource = dataTable;
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Bookings book = new Bookings(user);
            book.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DeleteBooking deleteBooking = new DeleteBooking(this.user);
            deleteBooking.Show();
        }

    }
}
