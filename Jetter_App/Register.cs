using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Jetter_App
{
    public partial class Register : Form
    {

        public Register()
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

        private void username_Validated(object sender, EventArgs e)
        {
            string Username = username.Text;

            if (isDistinctUsername(Username) && Username != "")
            {
                label2.Text = "Great username choice!";
                label2.Visible = true;
                label2.ForeColor = Color.Green;
            }
            else if (Username == "")
            {
                MessageBox.Show($"Please enter a username.", "Username Empty", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username.Focus();
            }
            else
            {
                MessageBox.Show($"The username '{Username}' is already taken.", "Username Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                username.Focus();

            }
        }

        private bool isDistinctUsername(string username)
        {
            string query = "SELECT COUNT(*) FROM [User] WHERE Username = @Username";

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);

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

            if(password.Text == "")
            {
                label3.ForeColor = Color.Red;
                label4.ForeColor = Color.Red;
                label5.ForeColor = Color.Red;
            }

        }

        private void password_Validating(object sender, EventArgs e)
        {
            string Password = password.Text;

            if (Password.Length >= 8)
            {
                label3.ForeColor = Color.Green;
            }
            else
            {
               label3.ForeColor = Color.Red;
            }

            if (!Password.ToLower().Equals(Password))
            {
                label4.ForeColor = Color.Green;
            }
            else
            {
                label4.ForeColor = Color.Red;
            }

            if (Regex.IsMatch(Password, @"\d"))
            {
                label5.ForeColor = Color.Green;
            }
            else
            {
                label6.ForeColor = Color.Red;
            }
        }

        private void re_password_Focus(object sender, EventArgs e)
        {
            label6.Text = "The password and re-password must match!";
            label6.Visible = true;

            if(re_password.Text == "")
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

            if (username.Text == "")
            {
                MessageBox.Show("Please enter a username.", "Missing Username", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            if (firstName.Text == "")
            {
                MessageBox.Show("Please enter your first name.", "Missing First Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (lastName.Text == "")
            {
                MessageBox.Show("Please enter your last name.", "Missing Last Name", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

            string query = "INSERT INTO [User] (Username, Password, Email, Role, FirstName, LastName, PhoneNumber, Address) VALUES (@Username, @Password, @Email, @Role, @FirstName, @LastName, @PhoneNumber, @Address)";

            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username.Text);
                    command.Parameters.AddWithValue("@Password", password.Text);
                    command.Parameters.AddWithValue("@Email", email.Text);
                    command.Parameters.AddWithValue("@Role", "customer");
                    command.Parameters.AddWithValue("@FirstName", firstName.Text);
                    command.Parameters.AddWithValue("@LastName", lastName.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", phone.Text);
                    command.Parameters.AddWithValue("@Address", address.Text);

                    connection.Open();
                    int rowsAffected = command.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("You successfully registered to Jetters!", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Log_In log_In = new Log_In();
                        log_In.Show();
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
            Log_In log_In = new Log_In();
            log_In.Show();
            this.Hide();
        }
    }
}
