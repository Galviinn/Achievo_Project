namespace SoftwareE1.FormsDesktop
{
    partial class UpdateCalendarPopUp
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
            updateEventBtn = new PictureBox();
            titleLabel = new Label();
            eventLabel = new Label();
            dateLabel = new Label();
            tbEvent = new TextBox();
            tbDate = new TextBox();
            bgColorPanel = new Panel();
            deleteEventBtn = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)updateEventBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)deleteEventBtn).BeginInit();
            SuspendLayout();
            // 
            // updateEventBtn
            // 
            updateEventBtn.Image = Properties.Resources.updateLogo;
            updateEventBtn.Location = new Point(362, 122);
            updateEventBtn.Name = "updateEventBtn";
            updateEventBtn.Size = new Size(34, 33);
            updateEventBtn.SizeMode = PictureBoxSizeMode.Zoom;
            updateEventBtn.TabIndex = 12;
            updateEventBtn.TabStop = false;
            updateEventBtn.Click += updateEventBtn_Click;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.BackColor = Color.FromArgb(249, 202, 36);
            titleLabel.Font = new Font("1UP!", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            titleLabel.Location = new Point(90, 11);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(228, 24);
            titleLabel.TabIndex = 11;
            titleLabel.Text = "Update Event";
            // 
            // eventLabel
            // 
            eventLabel.AutoSize = true;
            eventLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            eventLabel.Location = new Point(84, 130);
            eventLabel.Name = "eventLabel";
            eventLabel.Size = new Size(42, 16);
            eventLabel.TabIndex = 10;
            eventLabel.Text = "Event";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dateLabel.Location = new Point(84, 66);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new Size(36, 16);
            dateLabel.TabIndex = 9;
            dateLabel.Text = "Date";
            // 
            // tbEvent
            // 
            tbEvent.Location = new Point(84, 149);
            tbEvent.Name = "tbEvent";
            tbEvent.Size = new Size(240, 23);
            tbEvent.TabIndex = 0;
            // 
            // tbDate
            // 
            tbDate.Location = new Point(84, 85);
            tbDate.Name = "tbDate";
            tbDate.Size = new Size(240, 23);
            tbDate.TabIndex = 1;
            // 
            // bgColorPanel
            // 
            bgColorPanel.BackColor = Color.FromArgb(249, 202, 36);
            bgColorPanel.Dock = DockStyle.Top;
            bgColorPanel.Location = new Point(0, 0);
            bgColorPanel.Name = "bgColorPanel";
            bgColorPanel.Size = new Size(408, 46);
            bgColorPanel.TabIndex = 13;
            // 
            // deleteEventBtn
            // 
            deleteEventBtn.Image = Properties.Resources.trashLogo;
            deleteEventBtn.Location = new Point(362, 161);
            deleteEventBtn.Name = "deleteEventBtn";
            deleteEventBtn.Size = new Size(34, 33);
            deleteEventBtn.SizeMode = PictureBoxSizeMode.Zoom;
            deleteEventBtn.TabIndex = 14;
            deleteEventBtn.TabStop = false;
            deleteEventBtn.Click += deleteEventBtn_Click;
            // 
            // UpdateCalendarPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 206);
            Controls.Add(deleteEventBtn);
            Controls.Add(updateEventBtn);
            Controls.Add(titleLabel);
            Controls.Add(eventLabel);
            Controls.Add(dateLabel);
            Controls.Add(tbEvent);
            Controls.Add(tbDate);
            Controls.Add(bgColorPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UpdateCalendarPopUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Update an Event";
            Load += UpdateCalendarPopUp_Load;
            ((System.ComponentModel.ISupportInitialize)updateEventBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)deleteEventBtn).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox updateEventBtn;
        private Label titleLabel;
        private Label eventLabel;
        private Label dateLabel;
        private TextBox tbEvent;
        private TextBox tbDate;
        private Panel bgColorPanel;
        private PictureBox deleteEventBtn;
    }
}