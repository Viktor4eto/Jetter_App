using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jetter_App
{
    public partial class Vendor_Log_In : Form
    {
        public Vendor_Log_In()
        {
            InitializeComponent();
        }


        private void registered_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterVendor register = new RegisterVendor();
            register.Show();
        }

        private void log_in_Click(object sender, EventArgs e)
        {
            string Vendor = vendorName.Text;
            string Email = email.Text;
            string Password = password.Text;

            Vendor vendor = authenticate.authenticatedVendor(Vendor, Email, Password);

            if (vendor != null)
            {
                VendorWindow vendorWindow = new VendorWindow(vendor);
                vendorWindow.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("No such vendor exists.", "Invalid Vendor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void password_state_Click(object sender, EventArgs e)
        {

            bool isPasswordVisible = (password.PasswordChar == '*');

            password.PasswordChar = isPasswordVisible ? '\0' : '*';

            password_state.Image = isPasswordVisible ? Properties.Resources.hidden : Properties.Resources.not_hidden;
        }

        private void back_Click(object sender, EventArgs e)
        {
            Log_In log_in = new Log_In();
            log_in.Show();
            this.Hide();
        }
    }
}
