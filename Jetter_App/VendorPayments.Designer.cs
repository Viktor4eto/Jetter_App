namespace Jetter_App
{
    partial class VendorPayments
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
            confirmed_count = new Label();
            confirmed_amount = new Label();
            pending_amount = new Label();
            pending_count = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)display).BeginInit();
            SuspendLayout();
            // 
            // display
            // 
            display.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            display.Location = new Point(198, 70);
            display.Margin = new Padding(6);
            display.Name = "display";
            display.RowHeadersWidth = 51;
            display.RowTemplate.Height = 40;
            display.Size = new Size(1273, 691);
            display.TabIndex = 0;
            // 
            // confirmed_count
            // 
            confirmed_count.AutoSize = true;
            confirmed_count.Location = new Point(198, 797);
            confirmed_count.Margin = new Padding(6, 0, 6, 0);
            confirmed_count.Name = "confirmed_count";
            confirmed_count.Size = new Size(416, 41);
            confirmed_count.TabIndex = 1;
            confirmed_count.Text = "Confirmed Payments (Count): ";
            // 
            // confirmed_amount
            // 
            confirmed_amount.AutoSize = true;
            confirmed_amount.Location = new Point(198, 857);
            confirmed_amount.Margin = new Padding(6, 0, 6, 0);
            confirmed_amount.Name = "confirmed_amount";
            confirmed_amount.Size = new Size(442, 41);
            confirmed_amount.TabIndex = 2;
            confirmed_amount.Text = "Confirmed Payments (Amount): ";
            // 
            // pending_amount
            // 
            pending_amount.AutoSize = true;
            pending_amount.Location = new Point(999, 857);
            pending_amount.Margin = new Padding(6, 0, 6, 0);
            pending_amount.Name = "pending_amount";
            pending_amount.Size = new Size(411, 41);
            pending_amount.TabIndex = 4;
            pending_amount.Text = "Pending Payments (Amount): ";
            // 
            // pending_count
            // 
            pending_count.AutoSize = true;
            pending_count.Location = new Point(999, 797);
            pending_count.Margin = new Padding(6, 0, 6, 0);
            pending_count.Name = "pending_count";
            pending_count.Size = new Size(385, 41);
            pending_count.TabIndex = 3;
            pending_count.Text = "Pending Payments (Count): ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 915);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(126, 41);
            label1.TabIndex = 5;
            label1.Text = "Go Back";
            label1.Click += back_Click;
            // 
            // VendorPayments
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1679, 986);
            Controls.Add(label1);
            Controls.Add(pending_amount);
            Controls.Add(pending_count);
            Controls.Add(confirmed_amount);
            Controls.Add(confirmed_count);
            Controls.Add(display);
            Margin = new Padding(6);
            Name = "VendorPayments";
            Text = "VendorPayments";
            ((System.ComponentModel.ISupportInitialize)display).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView display;
        private Label confirmed_count;
        private Label confirmed_amount;
        private Label pending_amount;
        private Label pending_count;
        private Label label1;
    }
}