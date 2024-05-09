namespace Jetter_App
{
    partial class RegisterVendor
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
            label1 = new Label();
            vendorName = new TextBox();
            email = new TextBox();
            password = new TextBox();
            re_password = new TextBox();
            contactPerson = new TextBox();
            phone = new TextBox();
            address = new TextBox();
            register_button = new Button();
            password_state = new PictureBox();
            re_password_state = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            back = new Label();
            ((System.ComponentModel.ISupportInitialize)password_state).BeginInit();
            ((System.ComponentModel.ISupportInitialize)re_password_state).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new Point(26, 17);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(429, 51);
            label1.TabIndex = 0;
            label1.Text = "Welcome to Jetters! Fill out this form to register as a vendor and start renting out your assests!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // vendorName
            // 
            vendorName.Location = new Point(88, 123);
            vendorName.Margin = new Padding(1, 1, 1, 1);
            vendorName.Name = "vendorName";
            vendorName.PlaceholderText = "Vendor Name";
            vendorName.Size = new Size(304, 27);
            vendorName.TabIndex = 2;
            vendorName.Validated += vendorName_Validated;
            // 
            // email
            // 
            email.Location = new Point(88, 154);
            email.Margin = new Padding(1, 1, 1, 1);
            email.Name = "email";
            email.PlaceholderText = "E-Mail Address";
            email.Size = new Size(304, 27);
            email.TabIndex = 3;
            email.Validated += email_Validated;
            // 
            // password
            // 
            password.Location = new Point(88, 186);
            password.Margin = new Padding(1, 1, 1, 1);
            password.Name = "password";
            password.PasswordChar = '*';
            password.PlaceholderText = "Password";
            password.Size = new Size(278, 27);
            password.TabIndex = 4;
            password.TextChanged += password_Validating;
            password.Enter += password_Focused;
            password.Validated += password_Validated;
            // 
            // re_password
            // 
            re_password.Location = new Point(88, 219);
            re_password.Margin = new Padding(1, 1, 1, 1);
            re_password.Name = "re_password";
            re_password.PasswordChar = '*';
            re_password.PlaceholderText = "Re-enter Password";
            re_password.Size = new Size(278, 27);
            re_password.TabIndex = 5;
            re_password.TextChanged += re_password_Validating;
            re_password.Enter += re_password_Focus;
            // 
            // contactPerson
            // 
            contactPerson.Location = new Point(88, 250);
            contactPerson.Margin = new Padding(1, 1, 1, 1);
            contactPerson.Name = "contactPerson";
            contactPerson.PlaceholderText = "Contact Person";
            contactPerson.Size = new Size(304, 27);
            contactPerson.TabIndex = 6;
            // 
            // phone
            // 
            phone.Location = new Point(88, 282);
            phone.Margin = new Padding(1, 1, 1, 1);
            phone.Name = "phone";
            phone.PlaceholderText = "Phone Number";
            phone.Size = new Size(304, 27);
            phone.TabIndex = 8;
            phone.Validated += phone_Validated;
            // 
            // address
            // 
            address.Location = new Point(88, 314);
            address.Margin = new Padding(1, 1, 1, 1);
            address.Name = "address";
            address.PlaceholderText = "Address";
            address.Size = new Size(304, 27);
            address.TabIndex = 9;
            address.TextChanged += re_password_Validating;
            // 
            // register_button
            // 
            register_button.Location = new Point(126, 358);
            register_button.Margin = new Padding(1, 1, 1, 1);
            register_button.Name = "register_button";
            register_button.Size = new Size(202, 34);
            register_button.TabIndex = 1;
            register_button.Text = "Register";
            register_button.UseVisualStyleBackColor = true;
            register_button.Click += register_Clicked;
            // 
            // password_state
            // 
            password_state.Image = Properties.Resources.not_hidden;
            password_state.Location = new Point(368, 186);
            password_state.Margin = new Padding(1, 1, 1, 1);
            password_state.Name = "password_state";
            password_state.Size = new Size(29, 23);
            password_state.SizeMode = PictureBoxSizeMode.Zoom;
            password_state.TabIndex = 10;
            password_state.TabStop = false;
            password_state.Click += password_state_Click;
            // 
            // re_password_state
            // 
            re_password_state.Image = Properties.Resources.not_hidden;
            re_password_state.Location = new Point(368, 219);
            re_password_state.Margin = new Padding(1, 1, 1, 1);
            re_password_state.Name = "re_password_state";
            re_password_state.Size = new Size(29, 23);
            re_password_state.SizeMode = PictureBoxSizeMode.Zoom;
            re_password_state.TabIndex = 11;
            re_password_state.TabStop = false;
            re_password_state.Click += password_state_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(186, 410);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 12;
            label2.Text = "label2";
            label2.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(186, 430);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 13;
            label3.Text = "label3";
            label3.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 450);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(50, 20);
            label4.TabIndex = 14;
            label4.Text = "label4";
            label4.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 470);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 15;
            label5.Text = "label5";
            label5.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(186, 490);
            label6.Margin = new Padding(1, 0, 1, 0);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 16;
            label6.Text = "label6";
            label6.Visible = false;
            // 
            // back
            // 
            back.AutoSize = true;
            back.Location = new Point(26, 499);
            back.Margin = new Padding(1, 0, 1, 0);
            back.Name = "back";
            back.Size = new Size(63, 20);
            back.TabIndex = 17;
            back.Text = "Go Back";
            back.Click += back_Click;
            // 
            // RegisterVendor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(469, 538);
            Controls.Add(back);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(re_password_state);
            Controls.Add(password_state);
            Controls.Add(register_button);
            Controls.Add(address);
            Controls.Add(phone);
            Controls.Add(contactPerson);
            Controls.Add(re_password);
            Controls.Add(password);
            Controls.Add(email);
            Controls.Add(vendorName);
            Controls.Add(label1);
            Margin = new Padding(1, 1, 1, 1);
            Name = "RegisterVendor";
            Text = "Register";
            ((System.ComponentModel.ISupportInitialize)password_state).EndInit();
            ((System.ComponentModel.ISupportInitialize)re_password_state).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox vendorName;
        private TextBox email;
        private TextBox password;
        private TextBox re_password;
        private TextBox contactPerson;
        private TextBox phone;
        private TextBox address;
        private Button register_button;
        private PictureBox password_state;
        private PictureBox re_password_state;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label back;
    }
}