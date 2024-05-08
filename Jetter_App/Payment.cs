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
    public partial class Payment : Form
    {
        private User user;
        public Payment(User user)
        {
            InitializeComponent();
            this.user = user;

            loadPendingPayments();
        }

        private void loadPendingPayments()
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                connection.Open();

                string query = @"
                SELECT p.BookingID AS 'Booking ID', b.AssetID AS 'Asset ID', a.AssetType AS Type, a.Location, a.DailyRate AS 'Daily Rate',
                       b.BookingStartDate AS 'Start Date', b.BookingEndDate AS 'End Date', p.Amount
                FROM Payment p
                INNER JOIN Booking b ON p.BookingID = b.BookingID
                INNER JOIN Asset a ON b.AssetID = a.AssetID
                WHERE p.PaymentStatus = 'pending'";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }
            }

             pending.DataSource = dataTable;
        }
    }
}
