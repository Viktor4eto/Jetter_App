namespace Jetter_App
{
    partial class Log_In
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            register_label = new Label();
            username = new TextBox();
            password = new TextBox();
            vendor_label = new Label();
            logIn = new Button();
            pictureBox1 = new PictureBox();
            password_state = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)password_state).BeginInit();
            SuspendLayout();
            // 
            // register_label
            // 
            register_label.AutoSize = true;
            register_label.Location = new Point(335, 521);
            register_label.Margin = new Padding(1, 0, 1, 0);
            register_label.Name = "register_label";
            register_label.Size = new Size(112, 20);
            register_label.TabIndex = 0;
            register_label.Text = "Not registered?";
            register_label.Click += registered_Click;
            // 
            // username
            // 
            username.Location = new Point(107, 366);
            username.Margin = new Padding(1, 1, 1, 1);
            username.Name = "username";
            username.PlaceholderText = "Username";
            username.Size = new Size(269, 27);
            username.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(107, 410);
            password.Margin = new Padding(1, 1, 1, 1);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(244, 27);
            password.TabIndex = 3;
            // 
            // vendor_label
            // 
            vendor_label.AutoSize = true;
            vendor_label.Location = new Point(36, 521);
            vendor_label.Margin = new Padding(1, 0, 1, 0);
            vendor_label.Name = "vendor_label";
            vendor_label.Size = new Size(129, 20);
            vendor_label.TabIndex = 3;
            vendor_label.Text = "Are you a vendor?";
            vendor_label.Click += vendor_label_Click;
            // 
            // logIn
            // 
            logIn.Location = new Point(166, 457);
            logIn.Margin = new Padding(1, 1, 1, 1);
            logIn.Name = "logIn";
            logIn.Size = new Size(140, 31);
            logIn.TabIndex = 1;
            logIn.Text = "Log In";
            logIn.UseVisualStyleBackColor = true;
            logIn.Click += log_in_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(61, 15);
            pictureBox1.Margin = new Padding(1, 1, 1, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 328);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // password_state
            // 
            password_state.Image = Properties.Resources.not_hidden;
            password_state.Location = new Point(352, 410);
            password_state.Margin = new Padding(1, 1, 1, 1);
            password_state.Name = "password_state";
            password_state.Size = new Size(29, 23);
            password_state.SizeMode = PictureBoxSizeMode.Zoom;
            password_state.TabIndex = 6;
            password_state.TabStop = false;
            password_state.Click += password_state_Click;
            // 
            // Log_In
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(465, 561);
            Controls.Add(password_state);
            Controls.Add(pictureBox1);
            Controls.Add(logIn);
            Controls.Add(vendor_label);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(register_label);
            Margin = new Padding(1, 1, 1, 1);
            Name = "Log_In";
            Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)password_state).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label register_label;
        private TextBox username;
        private TextBox password;
        private Label vendor_label;
        private Button logIn;
        private PictureBox pictureBox1;
        private PictureBox password_state;
    }
}