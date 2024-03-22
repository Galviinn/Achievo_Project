namespace SoftwareE1.FormsDesktop
{
    partial class NewCalendarPopUp
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
            tbDate = new TextBox();
            tbEvent = new TextBox();
            dateLabel = new Label();
            eventLabel = new Label();
            titleLabel = new Label();
            addEventBtn = new PictureBox();
            bgColorPanel = new Panel();
            ((System.ComponentModel.ISupportInitialize)addEventBtn).BeginInit();
            SuspendLayout();
            // 
            // tbDate
            // 
            tbDate.Location = new Point(84, 79);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(240, 23);
            tbDate.TabIndex = 1;
            // 
            // tbEvent
            // 
            tbEvent.Location = new Point(84, 143);
            tbEvent.Name = "tbEvent";
            tbEvent.Size = new Size(240, 23);
            tbEvent.TabIndex = 0;
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(84, 60);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(36, 16);
            dateLabel.TabIndex = 2;
            dateLabel.Text = "Date";
            // 
            // eventLabel
            // 
            eventLabel.AutoSize = true;
            eventLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            eventLabel.Location = new Point(84, 124);
            eventLabel.Name = "eventLabel";
            eventLabel.Size = new Size(42, 16);
            eventLabel.TabIndex = 3;
            eventLabel.Text = "Event";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.FromArgb(249, 202, 36);
            titleLabel.Font = new Font("1UP!", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(119, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(171, 24);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Add Event";
            // 
            // addEventBtn
            // 
            addEventBtn.Image = Properties.Resources.addLogo;
            addEventBtn.Location = new Point(362, 161);
            addEventBtn.Name = "addEventBtn";
            addEventBtn.Size = new Size(34, 33);
            addEventBtn.SizeMode = PictureBoxSizeMode.Zoom;
            addEventBtn.TabIndex = 5;
            addEventBtn.TabStop = false;
            addEventBtn.Click += addEventBtn_Click;
            // 
            // bgColorPanel
            // 
            bgColorPanel.BackColor = Color.FromArgb(249, 202, 36);
            bgColorPanel.Dock = DockStyle.Top;
            bgColorPanel.Location = new Point(0, 0);
            bgColorPanel.Name = "bgColorPanel";
            bgColorPanel.Size = new Size(408, 46);
            bgColorPanel.TabIndex = 6;
            // 
            // NewCalendarPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 206);
            Controls.Add(addEventBtn);
            Controls.Add(titleLabel);
            Controls.Add(eventLabel);
            Controls.Add(dateLabel);
            Controls.Add(tbEvent);
            Controls.Add(tbDate);
            Controls.Add(bgColorPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "NewCalendarPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add an Event";
            Load += CalendarPopUp_Load;
            ((System.ComponentModel.ISupportInitialize)addEventBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbDate;
        private TextBox tbEvent;
        private Label dateLabel;
        private Label eventLabel;
        private Label titleLabel;
        private PictureBox addEventBtn;
        private Panel bgColorPanel;
    }
}