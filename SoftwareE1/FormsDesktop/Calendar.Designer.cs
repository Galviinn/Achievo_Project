namespace SoftwareE1.FormsDesktop
{
    partial class Calendar
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
            tableLayoutPanel1 = new TableLayoutPanel();
            container = new Panel();
            sundayLabel = new Label();
            saturdayLabel = new Label();
            fridayLabel = new Label();
            thursdayLabel = new Label();
            wednesdayLabel = new Label();
            tuesdayLabel = new Label();
            mondayLabel = new Label();
            prevBtn = new PictureBox();
            nextBtn = new PictureBox();
            calendarContainer = new FlowLayoutPanel();
            topContainerPanel = new Panel();
            topLayout = new TableLayoutPanel();
            Title = new Label();
            monthYearLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nextBtn).BeginInit();
            topContainerPanel.SuspendLayout();
            topLayout.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(container, 0, 1);
            tableLayoutPanel1.Controls.Add(topContainerPanel, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 85F));
            tableLayoutPanel1.Size = new Size(968, 462);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // container
            // 
            container.BackColor = Color.FromArgb(204, 204, 204);
            container.Controls.Add(sundayLabel);
            container.Controls.Add(saturdayLabel);
            container.Controls.Add(fridayLabel);
            container.Controls.Add(thursdayLabel);
            container.Controls.Add(wednesdayLabel);
            container.Controls.Add(tuesdayLabel);
            container.Controls.Add(mondayLabel);
            container.Controls.Add(prevBtn);
            container.Controls.Add(nextBtn);
            container.Controls.Add(calendarContainer);
            container.Dock = DockStyle.Fill;
            container.Location = new Point(3, 72);
            container.Name = "container";
            container.Size = new Size(962, 387);
            container.TabIndex = 2;
            // 
            // sundayLabel
            // 
            sundayLabel.AutoSize = true;
            sundayLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            sundayLabel.ForeColor = Color.Red;
            sundayLabel.Location = new Point(44, 9);
            sundayLabel.Name = "sundayLabel";
            sundayLabel.Size = new Size(52, 16);
            sundayLabel.TabIndex = 9;
            sundayLabel.Text = "Sunday";
            // 
            // saturdayLabel
            // 
            saturdayLabel.AutoSize = true;
            saturdayLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            saturdayLabel.Location = new Point(857, 9);
            saturdayLabel.Name = "saturdayLabel";
            saturdayLabel.Size = new Size(61, 16);
            saturdayLabel.TabIndex = 8;
            saturdayLabel.Text = "Saturday";
            // 
            // fridayLabel
            // 
            fridayLabel.AutoSize = true;
            fridayLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            fridayLabel.Location = new Point(728, 9);
            fridayLabel.Name = "fridayLabel";
            fridayLabel.Size = new Size(45, 16);
            fridayLabel.TabIndex = 7;
            fridayLabel.Text = "Friday";
            // 
            // thursdayLabel
            // 
            thursdayLabel.AutoSize = true;
            thursdayLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            thursdayLabel.Location = new Point(581, 9);
            thursdayLabel.Name = "thursdayLabel";
            thursdayLabel.Size = new Size(63, 16);
            thursdayLabel.TabIndex = 6;
            thursdayLabel.Text = "Thursday";
            // 
            // wednesdayLabel
            // 
            wednesdayLabel.AutoSize = true;
            wednesdayLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            wednesdayLabel.Location = new Point(441, 9);
            wednesdayLabel.Name = "wednesdayLabel";
            wednesdayLabel.Size = new Size(77, 16);
            wednesdayLabel.TabIndex = 5;
            wednesdayLabel.Text = "Wednesday";
            // 
            // tuesdayLabel
            // 
            tuesdayLabel.AutoSize = true;
            tuesdayLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            tuesdayLabel.Location = new Point(315, 9);
            tuesdayLabel.Name = "tuesdayLabel";
            tuesdayLabel.Size = new Size(57, 16);
            tuesdayLabel.TabIndex = 4;
            tuesdayLabel.Text = "Tuesday";
            // 
            // mondayLabel
            // 
            mondayLabel.AutoSize = true;
            mondayLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            mondayLabel.Location = new Point(176, 9);
            mondayLabel.Name = "mondayLabel";
            mondayLabel.Size = new Size(56, 16);
            mondayLabel.TabIndex = 3;
            mondayLabel.Text = "Monday";
            // 
            // prevBtn
            // 
            prevBtn.Image = Properties.Resources.Arrow_Previous;
            prevBtn.Location = new Point(893, 354);
            prevBtn.Name = "prevBtn";
            prevBtn.Size = new Size(30, 33);
            prevBtn.SizeMode = PictureBoxSizeMode.Zoom;
            prevBtn.TabIndex = 2;
            prevBtn.TabStop = false;
            prevBtn.Click += prevBtn_Click;
            // 
            // nextBtn
            // 
            nextBtn.Image = Properties.Resources.Arrow;
            nextBtn.Location = new Point(929, 354);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(30, 33);
            nextBtn.SizeMode = PictureBoxSizeMode.Zoom;
            nextBtn.TabIndex = 1;
            nextBtn.TabStop = false;
            nextBtn.Click += nextBtn_Click;
            // 
            // calendarContainer
            // 
            calendarContainer.BackColor = Color.FromArgb(204, 204, 204);
            calendarContainer.Location = new Point(3, 31);
            calendarContainer.Name = "calendarContainer";
            calendarContainer.Size = new Size(956, 319);
            calendarContainer.TabIndex = 0;
            // 
            // topContainerPanel
            // 
            topContainerPanel.BackColor = Color.FromArgb(249, 202, 36);
            topContainerPanel.Controls.Add(topLayout);
            topContainerPanel.Dock = DockStyle.Fill;
            topContainerPanel.Location = new Point(3, 3);
            topContainerPanel.Name = "topContainerPanel";
            topContainerPanel.Size = new Size(962, 63);
            topContainerPanel.TabIndex = 3;
            // 
            // topLayout
            // 
            topLayout.BackColor = Color.FromArgb(249, 202, 36);
            topLayout.ColumnCount = 2;
            topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            topLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            topLayout.Controls.Add(Title, 0, 0);
            topLayout.Controls.Add(monthYearLabel, 1, 0);
            topLayout.Dock = DockStyle.Fill;
            topLayout.Location = new Point(0, 0);
            topLayout.Name = "topLayout";
            topLayout.RowCount = 1;
            topLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            topLayout.Size = new Size(962, 63);
            topLayout.TabIndex = 0;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("1UP!", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            Title.Location = new Point(3, 0);
            Title.Name = "Title";
            Title.Size = new Size(403, 62);
            Title.TabIndex = 1;
            Title.Text = "CALENDAR";
            // 
            // monthYearLabel
            // 
            monthYearLabel.AutoSize = true;
            monthYearLabel.Dock = DockStyle.Right;
            monthYearLabel.Font = new Font("1UP!", 18F, FontStyle.Regular, GraphicsUnit.Point);
            monthYearLabel.ForeColor = Color.Black;
            monthYearLabel.Location = new Point(745, 0);
            monthYearLabel.Name = "monthYearLabel";
            monthYearLabel.Size = new Size(214, 63);
            monthYearLabel.TabIndex = 2;
            monthYearLabel.Text = "Month Year";
            monthYearLabel.TextAlign = ContentAlignment.BottomRight;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 462);
            Controls.Add(tableLayoutPanel1);
            Name = "Calendar";
            Text = "Calendar";
            Load += Calendar_Load;
            tableLayoutPanel1.ResumeLayout(false);
            container.ResumeLayout(false);
            container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)prevBtn).EndInit();
            ((System.ComponentModel.ISupportInitialize)nextBtn).EndInit();
            topContainerPanel.ResumeLayout(false);
            topLayout.ResumeLayout(false);
            topLayout.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel1;
        private Panel container;
        private Label tuesdayLabel;
        private Label mondayLabel;
        private PictureBox prevBtn;
        private PictureBox nextBtn;
        private FlowLayoutPanel calendarContainer;
        private Label sundayLabel;
        private Label saturdayLabel;
        private Label fridayLabel;
        private Label thursdayLabel;
        private Label wednesdayLabel;
        private Panel topContainerPanel;
        private TableLayoutPanel topLayout;
        private Label Title;
        private Label monthYearLabel;
    }
}