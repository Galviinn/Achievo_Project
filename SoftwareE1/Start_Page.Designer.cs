namespace SoftwareE1
{
    partial class Start_Page
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
            GetStarted = new Button();
            Login = new Button();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // GetStarted
            // 
            GetStarted.BackColor = Color.FromArgb(249, 202, 36);
            GetStarted.FlatAppearance.BorderColor = Color.Black;
            GetStarted.FlatAppearance.BorderSize = 2;
            GetStarted.FlatStyle = FlatStyle.Flat;
            GetStarted.Font = new Font("Montserrat", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            GetStarted.ForeColor = Color.Black;
            GetStarted.Location = new Point(100, 424);
            GetStarted.Name = "GetStarted";
            GetStarted.Size = new Size(235, 52);
            GetStarted.TabIndex = 0;
            GetStarted.Text = "Get Started";
            GetStarted.UseVisualStyleBackColor = false;
            GetStarted.Click += GetStarted_Click;
            // 
            // Login
            // 
            Login.BackColor = Color.FromArgb(249, 202, 36);
            Login.FlatAppearance.BorderColor = Color.Black;
            Login.FlatAppearance.BorderSize = 2;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Montserrat", 17.9999981F, FontStyle.Regular, GraphicsUnit.Point);
            Login.ForeColor = Color.Black;
            Login.Location = new Point(100, 345);
            Login.Name = "Login";
            Login.Size = new Size(235, 52);
            Login.TabIndex = 1;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoAchievo;
            pictureBox1.Location = new Point(-124, -68);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(685, 500);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(434, 339);
            panel1.TabIndex = 3;
            // 
            // Start_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(249, 202, 36);
            ClientSize = new Size(434, 561);
            Controls.Add(panel1);
            Controls.Add(Login);
            Controls.Add(GetStarted);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximumSize = new Size(450, 600);
            MinimumSize = new Size(450, 600);
            Name = "Start_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome to Achievo!";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button GetStarted;
        private Button Login;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}