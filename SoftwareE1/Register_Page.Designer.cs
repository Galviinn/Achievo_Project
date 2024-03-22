namespace SoftwareE1
{
    partial class Get_Started
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
            Password = new TextBox();
            Register = new Button();
            panel1 = new Panel();
            log_in = new Label();
            label = new Label();
            panel3 = new Panel();
            Eaddress = new TextBox();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            panel2 = new Panel();
            Username = new TextBox();
            pictureBox4 = new PictureBox();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            rbMale = new RadioButton();
            rbFemale = new RadioButton();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            SuspendLayout();
            // 
            // Password
            // 
            Password.Anchor = AnchorStyles.Left;
            Password.BackColor = Color.FromArgb(249, 202, 36);
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Montserrat", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ImeMode = ImeMode.NoControl;
            Password.Location = new Point(129, 296);
            Password.MaxLength = 100;
            Password.Name = "Password";
            Password.PlaceholderText = "Password";
            Password.Size = new Size(235, 30);
            Password.TabIndex = 3;
            Password.UseSystemPasswordChar = true;
            // 
            // Register
            // 
            Register.BackColor = Color.FromArgb(249, 202, 36);
            Register.FlatAppearance.BorderColor = Color.Black;
            Register.FlatAppearance.BorderSize = 2;
            Register.FlatStyle = FlatStyle.Flat;
            Register.Font = new Font("Montserrat", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            Register.ForeColor = Color.Black;
            Register.Location = new Point(100, 468);
            Register.Name = "Register";
            Register.Size = new Size(235, 52);
            Register.TabIndex = 5;
            Register.Text = "Register";
            Register.UseVisualStyleBackColor = false;
            Register.Click += Login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 202, 36);
            panel1.Controls.Add(log_in);
            panel1.Controls.Add(label);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 539);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 22);
            panel1.TabIndex = 6;
            // 
            // log_in
            // 
            log_in.AutoSize = true;
            log_in.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            log_in.Location = new Point(252, 3);
            log_in.Name = "log_in";
            log_in.Size = new Size(45, 16);
            log_in.TabIndex = 1;
            log_in.Text = "Log In";
            log_in.Click += log_in_Click;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Montserrat", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label.Location = new Point(109, 3);
            label.Name = "label";
            label.Size = new Size(147, 16);
            label.TabIndex = 0;
            label.Text = "If you have an account,";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(129, 331);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 1);
            panel3.TabIndex = 8;
            // 
            // Eaddress
            // 
            Eaddress.BackColor = Color.FromArgb(249, 202, 36);
            Eaddress.BorderStyle = BorderStyle.None;
            Eaddress.Font = new Font("Montserrat", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            Eaddress.Location = new Point(129, 355);
            Eaddress.MaxLength = 100;
            Eaddress.Name = "Eaddress";
            Eaddress.PlaceholderText = "Email Address";
            Eaddress.Size = new Size(235, 30);
            Eaddress.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Location = new Point(129, 391);
            panel4.Name = "panel4";
            panel4.Size = new Size(235, 1);
            panel4.TabIndex = 9;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.pngwing_com;
            pictureBox2.Location = new Point(83, 356);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 36);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.passwordLogo2;
            pictureBox3.Location = new Point(83, 296);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 12;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com__1_;
            pictureBox1.Location = new Point(83, 236);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(129, 271);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 1);
            panel2.TabIndex = 7;
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(249, 202, 36);
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Montserrat", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(129, 236);
            Username.MaxLength = 15;
            Username.Name = "Username";
            Username.PlaceholderText = "Username";
            Username.Size = new Size(235, 30);
            Username.TabIndex = 2;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Dock = DockStyle.Bottom;
            pictureBox4.Image = Properties.Resources.Logo;
            pictureBox4.Location = new Point(0, 69);
            pictureBox4.Margin = new Padding(0);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(434, 135);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 17;
            pictureBox4.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(434, 204);
            panel5.TabIndex = 18;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.genderLogo;
            pictureBox5.Location = new Point(83, 417);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(40, 36);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 21;
            pictureBox5.TabStop = false;
            // 
            // rbMale
            // 
            rbMale.AutoSize = true;
            rbMale.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbMale.Location = new Point(129, 422);
            rbMale.Name = "rbMale";
            rbMale.Size = new Size(66, 26);
            rbMale.TabIndex = 22;
            rbMale.TabStop = true;
            rbMale.Text = "Male";
            rbMale.UseVisualStyleBackColor = true;
            rbMale.CheckedChanged += rbMale_CheckedChanged;
            // 
            // rbFemale
            // 
            rbFemale.AutoSize = true;
            rbFemale.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            rbFemale.Location = new Point(209, 422);
            rbFemale.Name = "rbFemale";
            rbFemale.Size = new Size(88, 26);
            rbFemale.TabIndex = 23;
            rbFemale.TabStop = true;
            rbFemale.Text = "Female";
            rbFemale.UseVisualStyleBackColor = true;
            rbFemale.CheckedChanged += rbFemale_CheckedChanged;
            // 
            // Get_Started
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 202, 36);
            ClientSize = new Size(434, 561);
            Controls.Add(rbFemale);
            Controls.Add(rbMale);
            Controls.Add(pictureBox5);
            Controls.Add(panel5);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(Register);
            Controls.Add(Password);
            Controls.Add(panel3);
            Controls.Add(Username);
            Controls.Add(panel2);
            Controls.Add(Eaddress);
            Controls.Add(panel4);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(450, 600);
            MinimizeBox = false;
            MinimumSize = new Size(450, 600);
            Name = "Get_Started";
            ShowInTaskbar = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox Password;
        private Button Register;
        private Panel panel1;
        private Label log_in;
        private Label label;
        private Panel panel3;
        protected TextBox Eaddress;
        private Panel panel4;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private Panel panel2;
        protected TextBox Username;
        private PictureBox pictureBox4;
        private Panel panel5;
        private PictureBox pictureBox5;
        private RadioButton rbMale;
        private RadioButton rbFemale;
    }
}