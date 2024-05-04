namespace Jetter_App
{
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
        }

        private void vendor_label_Click(object sender, EventArgs e)
        {
            this.Hide();
            Vendor_Log_In vendor_Log_In = new Vendor_Log_In();
            vendor_Log_In.Show();
        }

        private void registered_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.Show();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            string Username = username.Text;
            string Password = password.Text;

            User user = authenticate.authenticatedUser(Username, Password);

            if (user != null)
            {
                if (user.Role == "customer")
                {
                    Bookings bookings = new Bookings(user);
                    bookings.Show();
                    this.Hide();
                }
                else
                {
                    AdminWindow adminWindow = new AdminWindow(user);
                    adminWindow.Show();
                    this.Hide();
                }

            }
            else
            {
                MessageBox.Show("No such user exists.", "Invalid User", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void password_state_Click(object sender, EventArgs e)
        {

            bool isPasswordVisible = (password.PasswordChar == '*');

            password.PasswordChar = isPasswordVisible ? '\0' : '*';

            password_state.Image = isPasswordVisible ? Properties.Resources.hidden : Properties.Resources.not_hidden;
        }
    }
}