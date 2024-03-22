namespace SoftwareE1.FormsDesktop
{
    partial class AddForm
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
            DesLabel = new Label();
            DiffLabel = new Label();
            textBox = new TextBox();
            comboBox = new ComboBox();
            btOk = new Button();
            btCancel = new Button();
            rewardsList = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // DesLabel
            // 
            DesLabel.AutoSize = true;
            DesLabel.Font = new Font("1UP!", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DesLabel.Location = new Point(12, 43);
            DesLabel.Name = "DesLabel";
            DesLabel.Size = new Size(179, 22);
            DesLabel.TabIndex = 0;
            DesLabel.Text = "Description";
            // 
            // DiffLabel
            // 
            DiffLabel.AutoSize = true;
            DiffLabel.Font = new Font("1UP!", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            DiffLabel.Location = new Point(12, 110);
            DiffLabel.Name = "DiffLabel";
            DiffLabel.Size = new Size(162, 22);
            DiffLabel.TabIndex = 1;
            DiffLabel.Text = "Difficulty";
            // 
            // textBox
            // 
            textBox.BackColor = SystemColors.ControlLightLight;
            textBox.BorderStyle = BorderStyle.FixedSingle;
            textBox.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox.Location = new Point(198, 35);
            textBox.Name = "textBox";
            textBox.Size = new Size(200, 38);
            textBox.TabIndex = 2;
            // 
            // comboBox
            // 
            comboBox.BackColor = SystemColors.Control;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FlatStyle = FlatStyle.System;
            comboBox.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "Easy", "Medium", "Hard" });
            comboBox.Location = new Point(198, 101);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(200, 39);
            comboBox.TabIndex = 3;
            // 
            // btOk
            // 
            btOk.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btOk.Location = new Point(307, 155);
            btOk.Name = "btOk";
            btOk.Size = new Size(91, 41);
            btOk.TabIndex = 4;
            btOk.Text = "OK";
            btOk.UseVisualStyleBackColor = true;
            btOk.Click += btOk_Click;
            // 
            // btCancel
            // 
            btCancel.Font = new Font("Montserrat", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            btCancel.Location = new Point(307, 208);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(91, 41);
            btCancel.TabIndex = 5;
            btCancel.Text = "CANCEL";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // rewardsList
            // 
            rewardsList.AutoSize = true;
            rewardsList.BorderStyle = BorderStyle.FixedSingle;
            rewardsList.Font = new Font("1UP!", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            rewardsList.Location = new Point(3, 175);
            rewardsList.Name = "rewardsList";
            rewardsList.Size = new Size(221, 74);
            rewardsList.TabIndex = 6;
            rewardsList.Text = "Easy =     25\r\nMedium =     50\r\nHard =     75";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.coinGif;
            pictureBox2.Location = new Point(155, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(22, 18);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.coinGif;
            pictureBox1.Location = new Point(124, 178);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(22, 18);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.coinGif;
            pictureBox3.Location = new Point(124, 226);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(22, 18);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 300);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox2);
            Controls.Add(rewardsList);
            Controls.Add(btCancel);
            Controls.Add(btOk);
            Controls.Add(comboBox);
            Controls.Add(textBox);
            Controls.Add(DiffLabel);
            Controls.Add(DesLabel);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(436, 300);
            MinimizeBox = false;
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label DesLabel;
        private Label DiffLabel;
        private TextBox textBox;
        private ComboBox comboBox;
        private Button btOk;
        private Button btCancel;
        private Label rewardsList;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}