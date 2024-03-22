namespace SoftwareE1.FormsDesktop
{
    partial class daysUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            daysLabel = new Label();
            eventLabel = new Label();
            UCTimer = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // daysLabel
            // 
            daysLabel.AutoSize = true;
            daysLabel.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            daysLabel.Location = new Point(2, 2);
            daysLabel.Name = "daysLabel";
            daysLabel.Size = new Size(32, 22);
            daysLabel.TabIndex = 0;
            daysLabel.Text = "00";
            // 
            // eventLabel
            // 
            eventLabel.BackColor = Color.FromArgb(249, 202, 36);
            eventLabel.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            eventLabel.Location = new Point(3, 33);
            eventLabel.Name = "eventLabel";
            eventLabel.Size = new Size(124, 23);
            eventLabel.TabIndex = 1;
            eventLabel.TextAlign = ContentAlignment.MiddleCenter;
            eventLabel.Visible = false;
            // 
            // UCTimer
            // 
            UCTimer.Tick += UCTimer_Tick;
            // 
            // daysUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(eventLabel);
            Controls.Add(daysLabel);
            Name = "daysUserControl";
            Size = new Size(130, 57);
            Load += daysUserControl_Load;
            Click += daysUserControl_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label daysLabel;
        private Label eventLabel;
        private System.Windows.Forms.Timer UCTimer;
    }
}
