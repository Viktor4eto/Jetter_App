namespace Jetter_App
{
    partial class Book
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
            startDate = new MonthCalendar();
            endDate = new MonthCalendar();
            assetId = new TextBox();
            start_label = new Label();
            end_label = new Label();
            booking = new Button();
            toPayment = new Button();
            SuspendLayout();
            // 
            // startDate
            // 
            startDate.Location = new Point(98, 125);
            startDate.MaxDate = new DateTime(2030, 5, 8, 0, 0, 0, 0);
            startDate.MinDate = new DateTime(2024, 5, 8, 0, 0, 0, 0);
            startDate.Name = "startDate";
            startDate.TabIndex = 0;
            // 
            // endDate
            // 
            endDate.Location = new Point(435, 125);
            endDate.MaxDate = new DateTime(2030, 5, 8, 0, 0, 0, 0);
            endDate.MinDate = new DateTime(2024, 5, 8, 0, 0, 0, 0);
            endDate.Name = "endDate";
            endDate.TabIndex = 1;
            // 
            // assetId
            // 
            assetId.Location = new Point(99, 54);
            assetId.Name = "assetId";
            assetId.PlaceholderText = "Asset ID";
            assetId.Size = new Size(261, 27);
            assetId.TabIndex = 2;
            // 
            // start_label
            // 
            start_label.AutoSize = true;
            start_label.Location = new Point(98, 96);
            start_label.Name = "start_label";
            start_label.Size = new Size(76, 20);
            start_label.TabIndex = 3;
            start_label.Text = "Start Date";
            // 
            // end_label
            // 
            end_label.AutoSize = true;
            end_label.Location = new Point(435, 96);
            end_label.Name = "end_label";
            end_label.Size = new Size(70, 20);
            end_label.TabIndex = 4;
            end_label.Text = "End Date";
            // 
            // booking
            // 
            booking.Location = new Point(331, 357);
            booking.Name = "booking";
            booking.Size = new Size(129, 33);
            booking.TabIndex = 5;
            booking.Text = "Book";
            booking.UseVisualStyleBackColor = true;
            booking.Click += booking_Click;
            // 
            // toPayment
            // 
            toPayment.Location = new Point(659, 405);
            toPayment.Name = "toPayment";
            toPayment.Size = new Size(129, 33);
            toPayment.TabIndex = 6;
            toPayment.Text = "Payment";
            toPayment.UseVisualStyleBackColor = true;
            toPayment.Click += toPayment_Click;
            // 
            // Book
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toPayment);
            Controls.Add(booking);
            Controls.Add(end_label);
            Controls.Add(start_label);
            Controls.Add(assetId);
            Controls.Add(endDate);
            Controls.Add(startDate);
            Name = "Book";
            Text = "Book";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar startDate;
        private MonthCalendar endDate;
        private TextBox assetId;
        private Label start_label;
        private Label end_label;
        private Button booking;
        private Button toPayment;
    }
}