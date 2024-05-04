using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jetter_App
{
    public partial class RegisterVendor : Form
    {
        public RegisterVendor()
        {
            InitializeComponent();
        }

        private void password_state_Click(object sender, EventArgs e)
        {


            bool isPasswordVisible = (password.PasswordChar == '*');

            password.PasswordChar = isPasswordVisible ? '\0' : '*';
            re_password.PasswordChar = password.PasswordChar;

            password_state.Image = isPasswordVisible ? Properties.Resources.hidden : Properties.Resources.not_hidden;
            re_password_state.Image = isPasswordVisible ? Properties.Resources.hidden : Properties.Resources.not_hidden;
        }

        private bool isValidEmail(string email)
        {
            // Regular expression pattern for validating email addresses
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

            // Use Regex.IsMatch method to check if the email matches the pattern
            return Regex.IsMatch(email, pattern);
        }

        private void email_Validated(object sender, EventArgs e)
        {
            string Email = email.Text;
            if (!isValidEmail(Email))
            {
                MessageBox.Show($"The email address '{Email}' is invalid.", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                email.Focus();
            }
        }

        private void vendorName_Validated(object sender, EventArgs e)
        {
            string vendorName = this.vendorName.Text;

            if (isDistinctVendorName(vendorName) && vendorName != "")
            {
                label2.Text = "Welcome " + vendorName;
                label2.Visible = true;
                label2.ForeColor = Color.Green;
            }
            else if (vendorName == "")
            {
                MessageBox.Show($"Please enter a username.", "Username Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.vendorName.Focus();
            }
            else
            {
                MessageBox.Show($"The username '{vendorName}' is already taken.", "Username Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.vendorName.Focus();

            }
        }

        private bool isDistinctVendorName(string vendorName)
        {
            string query = "SELECT COUNT(*) FROM Vendor WHERE VendorName = @VendorName";

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VendorName", vendorName);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    return count == 0;
                }
            }
        }

        private bool IsValidPassword(string password)
        {
            string pattern = @"^(?=.*[A-Z])(?=.*\d).{8,}$";

            return Regex.IsMatch(password, pattern);
        }

        private void password_Validated(object sender, EventArgs e)
        {
            string Password = password.Text;

            if (!IsValidPassword(Password))
            {
                MessageBox.Show($"The password is invalid.", "Invalid Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                password.Focus();
            }
        }

        private void password_Focused(object sender, EventArgs e)
        {
            label3.Text = "Password must be at least 8 characters!";
            label4.Text = "Password must contain a capital letter!";
            label5.Text = "Password must have a number!";

            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;

            label3.ForeColor = Color.Red;
            label4.ForeColor = Color.Red;
            label5.ForeColor = Color.Red;
        }

        private void password_Validating(object sender, EventArgs e)
        {
            string Password = password.Text;

            if (Password.Length >= 8)
            {
                label3.ForeColor = Color.Green;
            }

            if (!Password.ToLower().Equals(Password))
            {
                label4.ForeColor = Color.Green;
            }

            if (Regex.IsMatch(Password, @"\d"))
            {
                label5.ForeColor = Color.Green;
            }
        }

        private void re_password_Focus(object sender, EventArgs e)
        {
            label6.Text = "The password and re-password must match!";
            label6.Visible = true;
            label6.ForeColor = Color.Red;
        }

        private void re_password_Validating(object sender, EventArgs e)
        {
            string RePassword = re_password.Text;
            string Password = password.Text;

            if (RePassword.Equals(Password))
            {
                label6.ForeColor = Color.Green;
            }
            else
            {
                label6.ForeColor = Color.Red;
            }
        }

        private void register_Clicked(object sender, EventArgs e)
        {
            string RePassword = re_password.Text;
            string Password = password.Text;

            if (vendorName.Text == "")
            {
                MessageBox.Show("Please enter a vendor name.", "Missing Vendor Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (email.Text == "")
            {
                MessageBox.Show("Please enter an email.", "Missing Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (password.Text == "")
            {
                MessageBox.Show("Please enter a password.", "Missing Password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!RePassword.Equals(Password))
            {
                MessageBox.Show("The password and the re-entering of the password do not match!", "Re-enter your password", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (contactPerson.Text == "")
            {
                MessageBox.Show("Please enter a contact person.", "Missing Contact Person", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (phone.Text == "")
            {
                MessageBox.Show("Please enter your phone number.", "Missing Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (address.Text == "")
            {
                MessageBox.Show("Please enter your address", "Missing Address", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Vendor (VendorName, ContactPerson, Email, PhoneNumber, Address, VendorPassword) VALUES (@VendorName, @ContactPerson, @Email, @PhoneNumber, @Address, @VendorPassword)";

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VendorName", vendorName.Text);
                    command.Parameters.AddWithValue("@ContactPerson", contactPerson.Text);
                    command.Parameters.AddWithValue("@Email", email.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", phone.Text);
                    command.Parameters.AddWithValue("@Address", address.Text);
                    command.Parameters.AddWithValue("@VendorPassword", password.Text);


                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("You are officially a vendor at Jetters!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Vendor_Log_In vendor_log_In = new Vendor_Log_In();
                        vendor_log_In.Show();
                        this.Hide();

                    }

                }
            }
        }

        private bool IsValidPhoneNumber(string phoneNumber)
        {

            string pattern = @"^\+?(\d{1,2}\s?)?\(?\d{3}\)?[\s.-]?\d{3}[\s.-]?\d{4}$";

            return Regex.IsMatch(phoneNumber, pattern);
        }

        private void phone_Validated(object sender, EventArgs e)
        {
            string phoneNumber = phone.Text;

            if (!IsValidPhoneNumber(phoneNumber))
            {
                MessageBox.Show("Please enter a valid phone number.", "Invaid Phone Number", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                phone.Focus();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            Vendor_Log_In vendor_log_In = new Vendor_Log_In();
            vendor_log_In.Show();
            this.Hide();
        }
    }
}
