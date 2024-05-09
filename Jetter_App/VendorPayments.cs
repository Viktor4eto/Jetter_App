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
    public partial class VendorPayments : Form
    {
        private Vendor vendor;
        public VendorPayments(Vendor vendor)
        {
            InitializeComponent();
            this.vendor = vendor;
            PopulateDataGridView();
            pending_amount.Text += GetPendingPaymentsInfoForVendor().PendingSum;
            pending_count.Text += GetPendingPaymentsInfoForVendor().PendingCount;

            confirmed_amount.Text += GetConfirmedPaymentsInfoForVendor().ConfirmedSum;
            confirmed_count.Text += GetConfirmedPaymentsInfoForVendor().ConfirmedCount;
        }

        private void PopulateDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                string query = @"SELECT p.PaymentID, p.BookingID, p.Amount, p.PaymentDate, p.PaymentStatus, p.PaymentMethod
                                 FROM Payment p
                                 INNER JOIN Booking b ON p.BookingID = b.BookingID
                                 INNER JOIN VendorAsset va ON b.AssetID = va.AssetID
                                 INNER JOIN Vendor v ON va.VendorID = v.VendorID
                                 WHERE v.VendorID = @VendorID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VendorID", this.vendor.VendorID);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    display.DataSource = dataTable;
                }
            }
        }
        public (int PendingCount, decimal PendingSum) GetPendingPaymentsInfoForVendor()
        {
            int pendingCount = 0;
            decimal pendingSum = 0;

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                string query = @"SELECT 
                                COUNT(*) AS PendingCount,
                                SUM(p.Amount) AS PendingSum
                             FROM Payment p
                             INNER JOIN Booking b ON p.BookingID = b.BookingID
                             INNER JOIN VendorAsset va ON b.AssetID = va.AssetID
                             WHERE p.PaymentStatus = 'pending' AND va.VendorID = @VendorID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VendorID", this.vendor.VendorID);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        pendingCount = Convert.ToInt32(reader["PendingCount"]);
                        if (reader["PendingSum"] != DBNull.Value)
                        {
                            pendingSum = Convert.ToDecimal(reader["PendingSum"]);
                        }
                    }
                }
            }

            return (pendingCount, pendingSum);
        }

        // Method to get count and sum of amounts for confirmed payments for a specific vendor
        public (int ConfirmedCount, decimal ConfirmedSum) GetConfirmedPaymentsInfoForVendor()
        {
            int confirmedCount = 0;
            decimal confirmedSum = 0;

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                string query = @"SELECT 
                                COUNT(*) AS ConfirmedCount,
                                SUM(p.Amount) AS ConfirmedSum
                             FROM Payment p
                             INNER JOIN Booking b ON p.BookingID = b.BookingID
                             INNER JOIN VendorAsset va ON b.AssetID = va.AssetID
                             WHERE p.PaymentStatus = 'successful' AND va.VendorID = @VendorID;";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VendorID", this.vendor.VendorID);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        confirmedCount = Convert.ToInt32(reader["ConfirmedCount"]);
                        if (reader["ConfirmedSum"] != DBNull.Value)
                        {
                            confirmedSum = Convert.ToDecimal(reader["ConfirmedSum"]);
                        }
                    }
                }
            }

            return (confirmedCount, confirmedSum);
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendorWindow vendorWindow = new VendorWindow(this.vendor);
            vendorWindow.Show();
        }
    }



}
