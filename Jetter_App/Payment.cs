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
using System.Transactions;
using System.Windows.Forms;

namespace Jetter_App
{
    public partial class Payment : Form
    {
        private User user;
        private bool isValid = true;
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
                SELECT p.PaymentID AS 'Payment ID', p.BookingID AS 'Booking ID', b.AssetID AS 'Asset ID', a.AssetType AS Type, a.Location, a.DailyRate AS 'Daily Rate',
                       b.BookingStartDate AS 'Start Date', b.BookingEndDate AS 'End Date', p.Amount
                FROM Payment p
                INNER JOIN Booking b ON p.BookingID = b.BookingID
                INNER JOIN Asset a ON b.AssetID = a.AssetID
                WHERE p.PaymentStatus = 'pending' AND b.UserID=@UserID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@UserID", this.user.UserID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);
                }

            }

            pending.DataSource = dataTable;
        }

        private void method_Changed(object sender, EventArgs e)
        {
            if (method.SelectedIndex == 2)
            {
                changing.PlaceholderText = "Username";
            }
            else
            {
                changing.PlaceholderText = "Card Number";
            }
        }

        private bool paymentId_InTable()
        {
            string query = @"
                SELECT PaymentStatus 
                FROM Payment 
                WHERE PaymentID = @PaymentID";

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                connection.Open();
            
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@PaymentID", paymentId.Text);
                    string status = (string)cmd.ExecuteScalar();
                    if (status == "pending")
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }


            }

        private void card_Validate(object sender, EventArgs e)
        {
            if (changing.PlaceholderText == "Card Number")
            {
                string cardNumber = changing.Text;

                this.isValid = CardValidator.ValidateCardNumber(cardNumber);

                if (isValid)
                {
                    MessageBox.Show("The card number is valid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("The card number is invalid.", "Validation Result", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void pay_Click(object sender, EventArgs e)
        {
            if(this.isValid && paymentId_InTable())
            {
                string query = @"UPDATE Payment
                                 SET PaymentMethod = @method, PaymentStatus = 'successful', PaymentDate=GETDATE()
                                 WHERE PaymentID = @paymentId";


                using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@method", method.SelectedItem.ToString().ToLower());
                        cmd.Parameters.AddWithValue("@PaymentID", paymentId.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("The payment has been successful.", "Payment Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }

                string updateBookingQuery = @"
                UPDATE Booking
                SET BookingStatus = 'confirmed'
                WHERE BookingID = (SELECT BookingID FROM Payment WHERE PaymentID = @PaymentID)";

                    using (SqlCommand bookingCommand = new SqlCommand(updateBookingQuery, connection))
                    {
                        bookingCommand.Parameters.AddWithValue("@PaymentID", paymentId.Text);

                        bookingCommand.ExecuteNonQuery();
                        MessageBox.Show("The booking has been confirmed.", "Booking Status", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

                loadPendingPayments();
            }
        }
    }
}
