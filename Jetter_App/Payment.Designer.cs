namespace Jetter_App
{
    partial class Payment
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
            pending = new DataGridView();
            method = new ComboBox();
            changing = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pending).BeginInit();
            SuspendLayout();
            // 
            // pending
            // 
            pending.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            pending.Location = new Point(97, 25);
            pending.Name = "pending";
            pending.RowHeadersWidth = 51;
            pending.RowTemplate.Height = 29;
            pending.Size = new Size(611, 295);
            pending.TabIndex = 0;
            // 
            // method
            // 
            method.FormattingEnabled = true;
            method.Items.AddRange(new object[] { "Credit card", "Debit card", "Paypal" });
            method.Location = new Point(97, 354);
            method.Name = "method";
            method.Size = new Size(177, 28);
            method.TabIndex = 1;
            // 
            // changing
            // 
            changing.Location = new Point(285, 354);
            changing.Name = "changing";
            changing.Size = new Size(423, 27);
            changing.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 329);
            label1.Name = "label1";
            label1.Size = new Size(121, 20);
            label1.TabIndex = 3;
            label1.Text = "Payment Method";
            // 
            // Payment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(changing);
            Controls.Add(method);
            Controls.Add(pending);
            Name = "Payment";
            Text = "Payment";
            ((System.ComponentModel.ISupportInitialize)pending).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView pending;
        private ComboBox method;
        private TextBox changing;
        private Label label1;
    }
}