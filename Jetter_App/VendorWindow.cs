using System.Data.SqlClient;

namespace Jetter_App
{
    public partial class VendorWindow : Form
    {
        private Vendor vendor;
        public VendorWindow(Vendor vendor)
        {
            InitializeComponent();
            this.vendor = vendor;
            welcome.Text += vendor.VendorName;
        }



        private void payments_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendorPayments form2 = new VendorPayments(vendor);
            form2.Show();
        }

        private void assets_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditAssets form2 = new EditAssets(vendor);
            form2.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete this vendor?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the user confirms the deletion, proceed with deletion
            if (result == DialogResult.Yes)
            {
                using (SqlConnection sqlCon = new SqlConnection(Program.getDatabase()))
                {
                    string query = "DELETE FROM Vendor WHERE VendorID = @id";
                    sqlCon.Open();

                    SqlCommand cmd = new SqlCommand(query, sqlCon);
                    cmd.Parameters.AddWithValue("@id", this.vendor.VendorID);
                    cmd.ExecuteNonQuery();

                    sqlCon.Close();

                    this.Close();

                    MessageBox.Show("Vendor deleted successfully!", "Delete Vendor", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Book.UpdateAvailability();

                    Log_In logIn = new Log_In();
                    logIn.Show();
                }


            }
        }

        private void sign_out_Click(object sender, EventArgs e)
        {
            this.Hide();
            Log_In log_In = new Log_In();
            log_In.Show();
        }
    }
}