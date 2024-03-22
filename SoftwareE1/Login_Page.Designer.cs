namespace SoftwareE1
{
    partial class Login_page
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
            Username = new TextBox();
            Password = new TextBox();
            LoginForm = new Button();
            panel1 = new Panel();
            btRegister = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel3 = new Panel();
            panel2 = new Panel();
            panel5 = new Panel();
            pictureBox4 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // Username
            // 
            Username.BackColor = Color.FromArgb(249, 202, 36);
            Username.BorderStyle = BorderStyle.None;
            Username.Font = new Font("Montserrat", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            Username.Location = new Point(129, 246);
            Username.Name = "Username";
            Username.PlaceholderText = " Username";
            Username.Size = new Size(235, 30);
            Username.TabIndex = 0;
            // 
            // Password
            // 
            Password.BackColor = Color.FromArgb(249, 202, 36);
            Password.BorderStyle = BorderStyle.None;
            Password.Font = new Font("Montserrat", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            Password.ImeMode = ImeMode.NoControl;
            Password.Location = new Point(129, 306);
            Password.Name = "Password";
            Password.PlaceholderText = " Password";
            Password.Size = new Size(235, 30);
            Password.TabIndex = 1;
            Password.UseSystemPasswordChar = true;
            // 
            // LoginForm
            // 
            LoginForm.BackColor = Color.FromArgb(249, 202, 36);
            LoginForm.FlatAppearance.BorderColor = Color.Black;
            LoginForm.FlatAppearance.BorderSize = 2;
            LoginForm.FlatStyle = FlatStyle.Flat;
            LoginForm.Font = new Font("Montserrat", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            LoginForm.ForeColor = Color.Black;
            LoginForm.Location = new Point(100, 412);
            LoginForm.Name = "LoginForm";
            LoginForm.Size = new Size(235, 52);
            LoginForm.TabIndex = 3;
            LoginForm.Text = "Login";
            LoginForm.UseVisualStyleBackColor = false;
            LoginForm.Click += Login_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 202, 36);
            panel1.Controls.Add(btRegister);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 539);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 22);
            panel1.TabIndex = 5;
            // 
            // btRegister
            // 
            btRegister.AutoSize = true;
            btRegister.Font = new Font("Montserrat", 8.999999F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btRegister.Location = new Point(253, 3);
            btRegister.Name = "btRegister";
            btRegister.Size = new Size(75, 16);
            btRegister.TabIndex = 1;
            btRegister.Text = "create one";
            btRegister.Click += label3_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(95, 3);
            label2.Name = "label2";
            label2.Size = new Size(163, 16);
            label2.TabIndex = 0;
            label2.Text = "If you don't have account,";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.pngwing_com__1_;
            pictureBox1.Location = new Point(83, 246);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 36);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.passwordLogo2;
            pictureBox3.Location = new Point(83, 306);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 36);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 13;
            pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Location = new Point(129, 281);
            panel3.Name = "panel3";
            panel3.Size = new Size(235, 1);
            panel3.TabIndex = 14;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Location = new Point(129, 341);
            panel2.Name = "panel2";
            panel2.Size = new Size(235, 1);
            panel2.TabIndex = 15;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox4);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(434, 204);
            panel5.TabIndex = 19;
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
            // Login_page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 202, 36);
            ClientSize = new Size(434, 561);
            Controls.Add(panel5);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            Controls.Add(LoginForm);
            Controls.Add(Password);
            Controls.Add(Username);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(450, 600);
            MinimumSize = new Size(450, 600);
            Name = "Login_page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Please Log In!";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button LoginForm;
        protected TextBox Username;
        private Panel panel1;
        private Label btRegister;
        private Label label2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Panel panel3;
        private Panel panel2;
        private Panel panel5;
        private PictureBox pictureBox4;
        protected TextBox Password;
    }
}