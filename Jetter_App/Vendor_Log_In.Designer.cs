using Microsoft.VisualBasic.Logging;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Windows.Forms;

namespace Jetter_App
{
    partial class Vendor_Log_In
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
            register_label = new Label();
            vendorName = new TextBox();
            password = new TextBox();
            logIn = new Button();
            pictureBox1 = new PictureBox();
            password_state = new PictureBox();
            email = new TextBox();
            back = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)password_state).BeginInit();
            SuspendLayout();
            // 
            // register_label
            // 
            register_label.Location = new Point(728, 1034);
            register_label.Name = "register_label";
            register_label.Size = new Size(235, 82);
            register_label.TabIndex = 0;
            register_label.Text = "Not registered as a vendor?";
            register_label.TextAlign = ContentAlignment.TopCenter;
            register_label.Click += registered_Click;
            // 
            // vendorName
            // 
            vendorName.Location = new Point(229, 761);
            vendorName.Name = "vendorName";
            vendorName.PlaceholderText = "Vendor Name";
            vendorName.Size = new Size(568, 47);
            vendorName.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(229, 877);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(515, 47);
            password.TabIndex = 4;
            // 
            // logIn
            // 
            logIn.Location = new Point(353, 936);
            logIn.Name = "logIn";
            logIn.Size = new Size(297, 51);
            logIn.TabIndex = 1;
            logIn.Text = "Log In";
            logIn.UseVisualStyleBackColor = true;
            logIn.Click += log_in_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(130, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(742, 673);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // password_state
            // 
            password_state.Image = Properties.Resources.not_hidden;
            password_state.Location = new Point(750, 877);
            password_state.Name = "password_state";
            password_state.Size = new Size(61, 47);
            password_state.SizeMode = PictureBoxSizeMode.Zoom;
            password_state.TabIndex = 6;
            password_state.TabStop = false;
            password_state.Click += password_state_Click;
            // 
            // email
            // 
            email.Location = new Point(229, 820);
            email.Name = "email";
            email.PlaceholderText = "E-Mail";
            email.Size = new Size(568, 47);
            email.TabIndex = 3;
            // 
            // back
            // 
            back.AutoSize = true;
            back.Location = new Point(48, 1060);
            back.Name = "back";
            back.Size = new Size(126, 41);
            back.TabIndex = 18;
            back.Text = "Go Back";
            back.Click += back_Click;
            // 
            // Vendor_Log_In
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(988, 1151);
            Controls.Add(back);
            Controls.Add(email);
            Controls.Add(password_state);
            Controls.Add(pictureBox1);
            Controls.Add(logIn);
            Controls.Add(password);
            Controls.Add(vendorName);
            Controls.Add(register_label);
            Name = "Vendor_Log_In";
            Text = "Vendor Log In";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)password_state).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label register_label;
        private TextBox vendorName;
        private TextBox password;
        private Button logIn;
        private PictureBox pictureBox1;
        private PictureBox password_state;
        private TextBox email;
        private Label back;
    }
}