using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Numerics;

namespace Jetter_App
{
    public partial class EditAssets : Form
    {
        private Vendor vendor;
        public EditAssets(Vendor vendor)
        {
            InitializeComponent();
            this.vendor = vendor;
        }

        private void EditAssets_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Get the selected asset type from the ComboBox
            string selectedAssetType = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedAssetType))
            {
                MessageBox.Show("Please select an asset type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string newQuantity = quantitytext.Text.Trim();
            string newLocation = locationtext.Text.Trim();

            if (string.IsNullOrEmpty(newQuantity) && string.IsNullOrEmpty(newLocation))
            {
                MessageBox.Show("Nothing new to update.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Formulate the SQL update query
            string updateQuery = "UPDATE VendorAsset SET ";
            bool hasUpdates = false;

            if (!string.IsNullOrEmpty(newQuantity))
            {
                updateQuery += $"QuantityAvailable = '{newQuantity}'";
                hasUpdates = true;
            }

            if (!string.IsNullOrEmpty(newLocation))
            {
                if (hasUpdates)
                {
                    updateQuery += ", ";
                }
                updateQuery += $"RentalLocations = '{newLocation}'";
                hasUpdates = true;
            }

            updateQuery += $" WHERE VendorID = @VendorID AND AssetID = (SELECT AssetID FROM Asset WHERE AssetID = @AssetID)";

            // Execute the SQL update query
            using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
            using (SqlCommand command = new SqlCommand(updateQuery, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@VendorID", vendor.VendorID);
                command.Parameters.AddWithValue("@AssetID", selectedAssetType);
                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Update successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGrid();
                    quantitytext.Text = "";
                    locationtext.Text = "";
                }
                else
                {
                    MessageBox.Show("Update failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void UpdateGrid()
        {
            SqlConnection sqlCon = new SqlConnection(Program.getDatabase());

            // SQL query to select data
            string query = @"
                SELECT
                    Asset.Description AS Description,
                    Asset.DailyRate AS 'Daly Rate',
                    Asset.AssetID AS 'Asset ID',
                    Vendor.VendorName AS 'Vendor Name',
                    Asset.AssetType AS 'Asset Type',
                    VendorAsset.QuantityAvailable AS 'Quantity Available',
                    VendorAsset.RentalLocations AS 'Rental Location'
                FROM
                    VendorAsset
                INNER JOIN
                    Vendor ON VendorAsset.VendorID = Vendor.VendorID
                INNER JOIN
                    Asset ON VendorAsset.AssetID = Asset.AssetID
                WHERE
                    Vendor.VendorName = @VendorName;
     
            ";

            using (sqlCon)
            {
                sqlCon.Open();
                SqlCommand command = new SqlCommand(query, sqlCon);
                command.Parameters.AddWithValue("@VendorName", vendor.VendorName);

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                SqlDataReader reader = command.ExecuteReader();
                dataGridView1.DataSource = dataTable;
                while (reader.Read())
                {
                    string assetType = reader["Asset ID"].ToString();
                    comboBox1.Items.Add(assetType); // Add asset type to ComboBox
                }

                reader.Close();
            }
        }

        private void add_Click(object sender, EventArgs e)
        {
            try
            {
                // Check for empty text boxes
                if (string.IsNullOrWhiteSpace(assettext.Text) ||
                    string.IsNullOrWhiteSpace(nametext.Text) ||
                    string.IsNullOrWhiteSpace(destext.Text) ||
                    string.IsNullOrWhiteSpace(mantext.Text) ||
                    string.IsNullOrWhiteSpace(modeltext.Text) ||
                    string.IsNullOrWhiteSpace(yeartext.Text) ||
                    string.IsNullOrWhiteSpace(houtext.Text) ||
                    string.IsNullOrWhiteSpace(daytext.Text) ||
                    string.IsNullOrWhiteSpace(avaitext.Text) ||
                    string.IsNullOrWhiteSpace(loctext.Text))
                {
                    MessageBox.Show("Please fill in all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Year
                int year;
                if (!int.TryParse(yeartext.Text.Trim(), out year) || year <= 0)
                {
                    MessageBox.Show("Please enter a valid positive integer for Year.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Hourly Rate
                decimal hourlyRate;
                if (!decimal.TryParse(houtext.Text.Trim(), out hourlyRate) || hourlyRate <= 0)
                {
                    MessageBox.Show("Please enter a valid positive decimal number for Hourly Rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Daily Rate
                decimal dailyRate;
                if (!decimal.TryParse(daytext.Text.Trim(), out dailyRate) || dailyRate <= 0)
                {
                    MessageBox.Show("Please enter a valid positive decimal number for Daily Rate.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Validate Availability
                int availability;
                if (!int.TryParse(avaitext.Text.Trim(), out availability) || (availability != 0 && availability != 1))
                {
                    MessageBox.Show("Please enter either 0 or 1 for Availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Retrieve data from text boxes
                string assetType = assettext.Text.Trim();
                string assetName = nametext.Text.Trim();
                string description = destext.Text.Trim();
                string manufacturer = mantext.Text.Trim();
                string model = modeltext.Text.Trim();
                int Year = Convert.ToInt32(yeartext.Text.Trim());
                decimal hour = Convert.ToDecimal(houtext.Text.Trim());
                decimal day = Convert.ToDecimal(daytext.Text.Trim());
                string avai = avaitext.Text.Trim();
                string location = loctext.Text.Trim();

                // Insert into Asset table
                string insertAssetQuery = @"
        INSERT INTO Asset (AssetType, AssetName, Description, Manufacturer, Model, Year, HourlyRate, DailyRate, Availability, Location)
        VALUES (@AssetType, @AssetName, @Description, @Manufacturer, @Model, @Year, @HourlyRate, @DailyRate, @Availability, @Location);
        SELECT SCOPE_IDENTITY();"; // Retrieve the ID of the newly inserted asset

                using (SqlConnection connection = new SqlConnection(Program.getDatabase()))
                using (SqlCommand command = new SqlCommand(insertAssetQuery, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@AssetType", assetType);
                    command.Parameters.AddWithValue("@AssetName", assetName);
                    command.Parameters.AddWithValue("@Description", description);
                    command.Parameters.AddWithValue("@Manufacturer", manufacturer);
                    command.Parameters.AddWithValue("@Model", model);
                    command.Parameters.AddWithValue("@Year", Year);
                    command.Parameters.AddWithValue("@HourlyRate", hour);
                    command.Parameters.AddWithValue("@DailyRate", day);
                    command.Parameters.AddWithValue("@Availability", avai);
                    command.Parameters.AddWithValue("@Location", location);

                    // Execute the insert query and retrieve the ID of the newly inserted asset
                    int assetID = Convert.ToInt32(command.ExecuteScalar());

                    // Insert into VendorAsset table
                    string insertVendorAssetQuery = @"
            INSERT INTO VendorAsset (VendorID, AssetID, QuantityAvailable, RentalLocations)
            VALUES (@VendorID, @AssetID, 0, '');"; // Assuming initial quantity available is 0 and no rental locations specified

                    using (SqlCommand vendorAssetCommand = new SqlCommand(insertVendorAssetQuery, connection))
                    {
                        vendorAssetCommand.Parameters.AddWithValue("@VendorID", vendor.VendorID); // Assuming 'vendor' is the object representing the current vendor
                        vendorAssetCommand.Parameters.AddWithValue("@AssetID", assetID);
                        vendorAssetCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Asset added successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UpdateGrid();
                    assettext.Clear();
                    nametext.Clear();
                    destext.Clear();
                    mantext.Clear();
                    modeltext.Clear();
                    yeartext.Clear();
                    houtext.Clear();
                    daytext.Clear();
                    avaitext.Clear();
                    loctext.Clear();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numeric values for Year, Hourly Rate, Daily Rate, and Availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            VendorWindow vendorWindow = new VendorWindow(this.vendor);
            vendorWindow.Show();
        }
    }
}
