using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
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
            fill_type();
            this.user = user;
        }

        private void fill_type()
        {
            ComboBox[] comboBoxes = { type, location, manufacturer, model };
            foreach (ComboBox comboBox in comboBoxes)
            {
                comboBox.Items.Clear();
                using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
                {
                    connection.Open();

                    string column = comboBox.Name;
                    column = char.ToUpper(column[0]) + column.Substring(1);

                    if (column.Equals("Type"))
                        column = "AssetType";

                    string query = "SELECT DISTINCT " + column + " FROM Asset";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string assetType = reader.GetString(0);
                                assetType = char.ToUpper(assetType[0]) + assetType.Substring(1);
                                comboBox.Items.Add(assetType);
                            }
                        }
                    }
                }
            }
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
                    default:
                        return selectedText;
                }
            }

            return defaultColumn;
        }


        private void display_Load(object sender, EventArgs e)
        {

            using (SqlConnection sqlCon = new SqlConnection(Program.getDatabase()))
            {
                sqlCon.Open();

                string query = "SELECT AssetID AS 'Asset ID', AssetType AS Type, AssetName AS Name, Description, Manufacturer, DailyRate AS 'Daily Rate', Availability, Location" +
                                " FROM Asset WHERE " + searchBy_Handler() + " LIKE @text";

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

        private void display_comboBox_Load(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(Program.getDatabase()))
            {
                sqlCon.Open(); // Open SQL connection

                string query = "SELECT AssetID AS 'Asset ID', AssetType AS Type, AssetName AS Name, Description, Manufacturer, DailyRate AS 'Daily Rate', Availability, Location" +
                    " FROM Asset WHERE 1 = 1";

                List<string> conditions = new List<string>();

                if (type.SelectedItem != null)
                    conditions.Add("AssetType = @type");

                if (location.SelectedItem != null)
                    conditions.Add("Location = @location");

                if (manufacturer.SelectedItem != null)
                    conditions.Add("Manufacturer = @manufacturer");

                if (model.SelectedItem != null)
                    conditions.Add("Model = @model");

                if (conditions.Count > 0)
                {
                    query += " AND " + string.Join(" AND ", conditions);
                }

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                if (type.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@type", type.SelectedItem.ToString());

                if (location.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@location", location.SelectedItem.ToString());

                if (manufacturer.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@manufacturer", manufacturer.SelectedItem.ToString());

                if (model.SelectedItem != null)
                    cmd.Parameters.AddWithValue("@model", model.SelectedItem.ToString());


                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    display.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }
        private void clear_Click(object sender, EventArgs e)
        {
            type.SelectedIndex = -1;
            location.SelectedIndex = -1;
            manufacturer.SelectedIndex = -1;
            model.SelectedIndex = -1;
            display.DataSource = null;


        }

        private void compare_Click(object sender, EventArgs e)
        {
            Bookings comparison = new Bookings(this.user);
            comparison.Show();
        }

        private void book_Click(object sender, EventArgs e)
        {
            Book form = new Book(this.user);
            form.Show();
        }

        private void viewAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(Program.getDatabase()))
            {
                sqlCon.Open(); // Open SQL connection

                string query = "SELECT AssetID AS 'Asset ID', AssetType AS Type, AssetName AS Name, Description, Manufacturer, DailyRate AS 'Daily Rate', Availability, Location" +
                    " FROM Asset";

                SqlCommand cmd = new SqlCommand(query, sqlCon);

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    display.DataSource = ds.Tables.Count > 0 ? ds.Tables[0] : null;
                }
            }
        }
    }
}
