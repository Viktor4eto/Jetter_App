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
    public partial class Bookings : Form
    {
        private User user;
        public Bookings(User user)
        {
            InitializeComponent();
            this.user = user;
        }

        private string searchBy_Handler()
        {
            string defaultColumn = "AssetType";

            if (searchBy.SelectedItem != null) 
            {
                string selectedText = searchBy.SelectedItem.ToString();


                switch (selectedText)
                {
                    case "Type":
                        return "AssetType";
                    case "AnotherColumn": 
                        return "AnotherColumn";
                    default:
                        return selectedText;
                }
            }

            return defaultColumn;
        }


        private void display_Load (object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(Program.getDatabase()))
            {
                sqlCon.Open();

                string query = "SELECT * FROM Asset WHERE " + searchBy_Handler() + " LIKE @text";

                DataTable dataTable = new DataTable();

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    command.Parameters.AddWithValue("@text", "%" + search.Text + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dataTable);
                        display.DataSource = dataTable;
                    }
                }

            }
        }

    }
}
