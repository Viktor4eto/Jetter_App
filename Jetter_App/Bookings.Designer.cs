namespace Jetter_App
{
    partial class Bookings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            display = new DataGridView();
            searchBy = new ComboBox();
            search = new TextBox();
            location = new ComboBox();
            manufacturer = new ComboBox();
            type = new ComboBox();
            model = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)display).BeginInit();
            SuspendLayout();
            // 
            // display
            // 
            display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            display.Location = new Point(100, 134);
            display.Name = "display";
            display.RowHeadersWidth = 51;
            display.RowTemplate.Height = 29;
            display.Size = new Size(636, 346);
            display.TabIndex = 0;
            // 
            // searchBy
            // 
            searchBy.DropDownStyle = ComboBoxStyle.DropDownList;
            searchBy.FormattingEnabled = true;
            searchBy.Items.AddRange(new object[] { "Type", "Location ", "Manufacturer", "Model" });
            searchBy.Location = new Point(529, 100);
            searchBy.Name = "searchBy";
            searchBy.Size = new Size(207, 28);
            searchBy.TabIndex = 1;
            // 
            // search
            // 
            search.Location = new Point(100, 101);
            search.Name = "search";
            search.Size = new Size(427, 27);
            search.TabIndex = 2;
            search.TextChanged += display_Load;
            // 
            // location
            // 
            location.FormattingEnabled = true;
            location.Location = new Point(264, 505);
            location.Name = "location";
            location.Size = new Size(155, 28);
            location.TabIndex = 3;
            // 
            // manufacturer
            // 
            manufacturer.FormattingEnabled = true;
            manufacturer.Location = new Point(425, 505);
            manufacturer.Name = "manufacturer";
            manufacturer.Size = new Size(155, 28);
            manufacturer.TabIndex = 4;
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.Location = new Point(100, 505);
            type.Name = "type";
            type.Size = new Size(158, 28);
            type.TabIndex = 5;
            // 
            // model
            // 
            model.FormattingEnabled = true;
            model.Location = new Point(586, 505);
            model.Name = "model";
            model.Size = new Size(150, 28);
            model.TabIndex = 6;
            // 
            // Bookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 612);
            Controls.Add(model);
            Controls.Add(type);
            Controls.Add(manufacturer);
            Controls.Add(location);
            Controls.Add(search);
            Controls.Add(searchBy);
            Controls.Add(display);
            Name = "Bookings";
            Text = "Bookings";
            ((System.ComponentModel.ISupportInitialize)display).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView display;
        private ComboBox searchBy;
        private TextBox search;
        private ComboBox location;
        private ComboBox manufacturer;
        private ComboBox type;
        private ComboBox model;
    }
}