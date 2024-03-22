namespace SoftwareE1.FormsDesktop
{
    partial class Main
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
            mainPanel = new Panel();
            logoutBtn = new PictureBox();
            pictureBox1 = new PictureBox();
            userCoins = new Label();
            mainBackground = new PictureBox();
            mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)logoutBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)mainBackground).BeginInit();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(logoutBtn);
            mainPanel.Controls.Add(pictureBox1);
            mainPanel.Controls.Add(userCoins);
            mainPanel.Controls.Add(mainBackground);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(969, 466);
            mainPanel.TabIndex = 0;
            // 
            // logoutBtn
            // 
            logoutBtn.BackColor = Color.FromArgb(80, 180, 228);
            logoutBtn.Image = Properties.Resources.exitLogo;
            logoutBtn.Location = new Point(913, 12);
            logoutBtn.Name = "logoutBtn";
            logoutBtn.Size = new Size(44, 43);
            logoutBtn.SizeMode = PictureBoxSizeMode.Zoom;
            logoutBtn.TabIndex = 3;
            logoutBtn.TabStop = false;
            logoutBtn.Click += logoutBtn_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(80, 180, 228);
            pictureBox1.Image = Properties.Resources.coinGif;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // userCoins
            // 
            userCoins.AutoSize = true;
            userCoins.BackColor = Color.FromArgb(80, 180, 228);
            userCoins.Font = new Font("1UP!", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            userCoins.ForeColor = Color.Black;
            userCoins.Location = new Point(38, 12);
            userCoins.Name = "userCoins";
            userCoins.Size = new Size(95, 24);
            userCoins.TabIndex = 1;
            userCoins.Text = "Coins";
            // 
            // mainBackground
            // 
            mainBackground.BackColor = Color.Transparent;
            mainBackground.BackgroundImageLayout = ImageLayout.Stretch;
            mainBackground.Dock = DockStyle.Fill;
            mainBackground.Image = Properties.Resources.chievyBGMale;
            mainBackground.Location = new Point(0, 0);
            mainBackground.Name = "mainBackground";
            mainBackground.Size = new Size(969, 466);
            mainBackground.SizeMode = PictureBoxSizeMode.StretchImage;
            mainBackground.TabIndex = 0;
            mainBackground.TabStop = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(969, 466);
            Controls.Add(mainPanel);
            Name = "Main";
            Text = "Main Menu";
            Load += Main_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)logoutBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)mainBackground).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private PictureBox btSettings;
        private PictureBox btExit;
        private PictureBox mainBackground;
        private Label userCoins;
        private PictureBox pictureBox1;
        private PictureBox logoutBtn;
    }
}