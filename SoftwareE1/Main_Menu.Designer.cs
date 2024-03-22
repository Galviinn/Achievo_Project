namespace SoftwareE1
{
    partial class Main_Menu
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
            MenuPanel = new Panel();
            btHome = new PictureBox();
            btCalendar = new Button();
            btStore = new Button();
            btNote = new Button();
            btTask = new Button();
            panelDesktop = new Panel();
            MenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btHome).BeginInit();
            SuspendLayout();
            // 
            // MenuPanel
            // 
            MenuPanel.BackColor = Color.FromArgb(249, 202, 36);
            MenuPanel.BorderStyle = BorderStyle.FixedSingle;
            MenuPanel.Controls.Add(btHome);
            MenuPanel.Controls.Add(btCalendar);
            MenuPanel.Controls.Add(btStore);
            MenuPanel.Controls.Add(btNote);
            MenuPanel.Controls.Add(btTask);
            MenuPanel.Dock = DockStyle.Bottom;
            MenuPanel.Location = new Point(0, 501);
            MenuPanel.Name = "MenuPanel";
            MenuPanel.Size = new Size(984, 60);
            MenuPanel.TabIndex = 0;
            // 
            // btHome
            // 
            btHome.Image = Properties.Resources.Logo;
            btHome.Location = new Point(444, 6);
            btHome.Margin = new Padding(3, 20, 3, 3);
            btHome.Name = "btHome";
            btHome.Size = new Size(103, 48);
            btHome.SizeMode = PictureBoxSizeMode.Zoom;
            btHome.TabIndex = 5;
            btHome.TabStop = false;
            btHome.Click += btHome_Click;
            // 
            // btCalendar
            // 
            btCalendar.Dock = DockStyle.Right;
            btCalendar.FlatAppearance.BorderColor = Color.Black;
            btCalendar.FlatAppearance.BorderSize = 0;
            btCalendar.FlatStyle = FlatStyle.Flat;
            btCalendar.Font = new Font("1UP!", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btCalendar.Location = new Point(582, 0);
            btCalendar.Name = "btCalendar";
            btCalendar.Size = new Size(200, 58);
            btCalendar.TabIndex = 4;
            btCalendar.Text = "CALENDAR";
            btCalendar.UseVisualStyleBackColor = true;
            btCalendar.Click += btCalendar_Click;
            // 
            // btStore
            // 
            btStore.Dock = DockStyle.Right;
            btStore.FlatAppearance.BorderSize = 0;
            btStore.FlatStyle = FlatStyle.Flat;
            btStore.Font = new Font("1UP!", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btStore.ImageAlign = ContentAlignment.MiddleLeft;
            btStore.Location = new Point(782, 0);
            btStore.Name = "btStore";
            btStore.Padding = new Padding(2);
            btStore.Size = new Size(200, 58);
            btStore.TabIndex = 3;
            btStore.Text = "STORE";
            btStore.UseVisualStyleBackColor = true;
            btStore.Click += btStore_Click;
            // 
            // btNote
            // 
            btNote.Dock = DockStyle.Left;
            btNote.FlatAppearance.BorderSize = 0;
            btNote.FlatStyle = FlatStyle.Flat;
            btNote.Font = new Font("1UP!", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btNote.Location = new Point(200, 0);
            btNote.Name = "btNote";
            btNote.Size = new Size(200, 58);
            btNote.TabIndex = 1;
            btNote.Text = "NOTE";
            btNote.UseVisualStyleBackColor = true;
            btNote.Click += btNote_Click;
            // 
            // btTask
            // 
            btTask.Dock = DockStyle.Left;
            btTask.FlatAppearance.BorderSize = 0;
            btTask.FlatStyle = FlatStyle.Flat;
            btTask.Font = new Font("1UP!", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btTask.Location = new Point(0, 0);
            btTask.Name = "btTask";
            btTask.Size = new Size(200, 58);
            btTask.TabIndex = 0;
            btTask.Text = "TASK";
            btTask.UseVisualStyleBackColor = true;
            btTask.Click += btTask_Click;
            // 
            // panelDesktop
            // 
            panelDesktop.Dock = DockStyle.Fill;
            panelDesktop.Location = new Point(0, 0);
            panelDesktop.Name = "panelDesktop";
            panelDesktop.Size = new Size(984, 501);
            panelDesktop.TabIndex = 1;
            // 
            // Main_Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(panelDesktop);
            Controls.Add(MenuPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main_Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Achievo!";
            MenuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btHome).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel MenuPanel;
        private Button btCalendar;
        private Button btStore;
        private Button btNote;
        private Button btTask;
        private Panel panelDesktop;
        private PictureBox btHome;
    }
}