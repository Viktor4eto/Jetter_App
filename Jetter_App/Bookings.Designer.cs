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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            reset = new Button();
            book = new Button();
            compare = new Button();
            viewAll = new Button();
            viewBookings = new Button();
            delete = new Button();
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
            searchBy.SelectedIndexChanged += display_Load;
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
            location.SelectedIndexChanged += display_comboBox_Load;
            // 
            // manufacturer
            // 
            manufacturer.FormattingEnabled = true;
            manufacturer.Location = new Point(425, 505);
            manufacturer.Name = "manufacturer";
            manufacturer.Size = new Size(155, 28);
            manufacturer.TabIndex = 4;
            manufacturer.SelectedIndexChanged += display_comboBox_Load;
            // 
            // type
            // 
            type.FormattingEnabled = true;
            type.Location = new Point(100, 505);
            type.Name = "type";
            type.Size = new Size(158, 28);
            type.TabIndex = 5;
            type.SelectedIndexChanged += display_comboBox_Load;
            // 
            // model
            // 
            model.FormattingEnabled = true;
            model.Location = new Point(586, 505);
            model.Name = "model";
            model.Size = new Size(150, 28);
            model.TabIndex = 6;
            model.SelectedIndexChanged += display_comboBox_Load;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(530, 77);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 7;
            label1.Text = "Search By:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(100, 482);
            label2.Name = "label2";
            label2.Size = new Size(43, 20);
            label2.TabIndex = 8;
            label2.Text = "Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(264, 483);
            label3.Name = "label3";
            label3.Size = new Size(69, 20);
            label3.TabIndex = 9;
            label3.Text = "Location:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(425, 482);
            label4.Name = "label4";
            label4.Size = new Size(100, 20);
            label4.TabIndex = 10;
            label4.Text = "Manufacturer:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(586, 482);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 11;
            label5.Text = "Model:";
            // 
            // reset
            // 
            reset.Location = new Point(356, 579);
            reset.Name = "reset";
            reset.Size = new Size(131, 34);
            reset.TabIndex = 12;
            reset.Text = "Reset";
            reset.UseVisualStyleBackColor = true;
            reset.Click += clear_Click;
            // 
            // book
            // 
            book.Location = new Point(672, 579);
            book.Name = "book";
            book.Size = new Size(133, 34);
            book.TabIndex = 13;
            book.Text = "Book Now!";
            book.UseVisualStyleBackColor = true;
            book.Click += book_Click;
            // 
            // compare
            // 
            compare.Location = new Point(12, 579);
            compare.Name = "compare";
            compare.Size = new Size(131, 34);
            compare.TabIndex = 14;
            compare.Text = "Compare";
            compare.UseVisualStyleBackColor = true;
            compare.Click += compare_Click;
            // 
            // viewAll
            // 
            viewAll.Location = new Point(356, 539);
            viewAll.Name = "viewAll";
            viewAll.Size = new Size(131, 34);
            viewAll.TabIndex = 15;
            viewAll.Text = "View All";
            viewAll.UseVisualStyleBackColor = true;
            viewAll.Click += viewAll_Click;
            // 
            // viewBookings
            // 
            viewBookings.Location = new Point(12, 12);
            viewBookings.Name = "viewBookings";
            viewBookings.Size = new Size(189, 32);
            viewBookings.TabIndex = 16;
            viewBookings.Text = "View Your Bookings";
            viewBookings.UseVisualStyleBackColor = true;
            viewBookings.Click += viewBookings_Click;
            // 
            // delete
            // 
            delete.Location = new Point(616, 12);
            delete.Name = "delete";
            delete.Size = new Size(189, 32);
            delete.TabIndex = 17;
            delete.Text = "Delete This User";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // Bookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 625);
            Controls.Add(delete);
            Controls.Add(viewBookings);
            Controls.Add(viewAll);
            Controls.Add(compare);
            Controls.Add(book);
            Controls.Add(reset);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button reset;
        private Button book;
        private Button compare;
        private Button viewAll;
        private Button viewBookings;
        private Button delete;
    }
}