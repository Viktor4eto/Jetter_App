namespace Jetter_App
{
    partial class YourBookings
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
            personalBookings = new DataGridView();
            back = new Button();
            delete = new Button();
            reload = new Button();
            ((System.ComponentModel.ISupportInitialize)personalBookings).BeginInit();
            SuspendLayout();
            // 
            // personalBookings
            // 
            personalBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            personalBookings.Location = new Point(76, 75);
            personalBookings.Name = "personalBookings";
            personalBookings.RowHeadersWidth = 51;
            personalBookings.RowTemplate.Height = 29;
            personalBookings.Size = new Size(636, 334);
            personalBookings.TabIndex = 0;
            // 
            // back
            // 
            back.Location = new Point(12, 485);
            back.Name = "back";
            back.Size = new Size(134, 38);
            back.TabIndex = 1;
            back.Text = "Back";
            back.UseVisualStyleBackColor = true;
            back.Click += back_Click;
            // 
            // delete
            // 
            delete.Location = new Point(654, 485);
            delete.Name = "delete";
            delete.Size = new Size(134, 38);
            delete.TabIndex = 2;
            delete.Text = "Delete a Booking";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // reload
            // 
            reload.Location = new Point(330, 485);
            reload.Name = "reload";
            reload.Size = new Size(134, 38);
            reload.TabIndex = 3;
            reload.Text = "Reload";
            reload.UseVisualStyleBackColor = true;
            reload.Click += this.Load;
            // 
            // YourBookings
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 535);
            Controls.Add(reload);
            Controls.Add(delete);
            Controls.Add(back);
            Controls.Add(personalBookings);
            Name = "YourBookings";
            Text = "YourBookings";
            ((System.ComponentModel.ISupportInitialize)personalBookings).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView personalBookings;
        private Button back;
        private Button delete;
        private Button reload;
    }
}