namespace Jetter_App
{
    partial class VendorWindow
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
            assets = new Button();
            payments = new Button();
            welcome = new Label();
            delete = new Button();
            sign_out = new Button();
            SuspendLayout();
            // 
            // assets
            // 
            assets.Location = new Point(49, 120);
            assets.Margin = new Padding(3, 4, 3, 4);
            assets.Name = "assets";
            assets.Size = new Size(226, 44);
            assets.TabIndex = 0;
            assets.Text = "Edit assets";
            assets.UseVisualStyleBackColor = true;
            assets.Click += assets_Click;
            // 
            // payments
            // 
            payments.Location = new Point(380, 120);
            payments.Margin = new Padding(3, 4, 3, 4);
            payments.Name = "payments";
            payments.Size = new Size(226, 44);
            payments.TabIndex = 1;
            payments.Text = "View payments";
            payments.UseVisualStyleBackColor = true;
            payments.Click += payments_Click;
            // 
            // welcome
            // 
            welcome.AutoSize = true;
            welcome.Location = new Point(49, 40);
            welcome.Name = "welcome";
            welcome.Size = new Size(78, 20);
            welcome.TabIndex = 2;
            welcome.Text = "Welcome, ";
            // 
            // delete
            // 
            delete.Location = new Point(50, 215);
            delete.Margin = new Padding(3, 4, 3, 4);
            delete.Name = "delete";
            delete.Size = new Size(226, 44);
            delete.TabIndex = 3;
            delete.Text = "Delete Account";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // sign_out
            // 
            sign_out.Location = new Point(380, 215);
            sign_out.Margin = new Padding(3, 4, 3, 4);
            sign_out.Name = "sign_out";
            sign_out.Size = new Size(226, 44);
            sign_out.TabIndex = 4;
            sign_out.Text = "Sign Out";
            sign_out.UseVisualStyleBackColor = true;
            sign_out.Click += sign_out_Click;
            // 
            // VendorWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(645, 322);
            Controls.Add(sign_out);
            Controls.Add(delete);
            Controls.Add(welcome);
            Controls.Add(payments);
            Controls.Add(assets);
            Margin = new Padding(1);
            Name = "VendorWindow";
            Text = "Vendor Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button assets;
        private Button payments;
        private Label welcome;
        private Button delete;
        private Button sign_out;
    }
}