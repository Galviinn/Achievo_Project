namespace SoftwareE1.FormsDesktop
{
    partial class Task
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            taskDataGridView = new DataGridView();
            colID = new DataGridViewTextBoxColumn();
            colDesc = new DataGridViewTextBoxColumn();
            colDiff = new DataGridViewTextBoxColumn();
            colButton = new DataGridViewButtonColumn();
            label1 = new Label();
            btDel = new Button();
            btAdd = new Button();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).BeginInit();
            SuspendLayout();
            // 
            // taskDataGridView
            // 
            taskDataGridView.AllowUserToAddRows = false;
            taskDataGridView.AllowUserToDeleteRows = false;
            taskDataGridView.AllowUserToResizeColumns = false;
            taskDataGridView.AllowUserToResizeRows = false;
            taskDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            taskDataGridView.BackgroundColor = Color.FromArgb(189, 195, 199);
            taskDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            taskDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            taskDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskDataGridView.Columns.AddRange(new DataGridViewColumn[] { colID, colDesc, colDiff, colButton });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            taskDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            taskDataGridView.GridColor = SystemColors.Control;
            taskDataGridView.Location = new Point(12, 113);
            taskDataGridView.Name = "taskDataGridView";
            taskDataGridView.ReadOnly = true;
            taskDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            taskDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            taskDataGridView.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            taskDataGridView.RowTemplate.Height = 25;
            taskDataGridView.Size = new Size(944, 337);
            taskDataGridView.TabIndex = 0;
            taskDataGridView.CellContentClick += taskDataGridView_CellContentClick;
            // 
            // colID
            // 
            colID.DataPropertyName = "ID";
            colID.FillWeight = 15F;
            colID.HeaderText = "ID";
            colID.Name = "colID";
            colID.ReadOnly = true;
            colID.Visible = false;
            // 
            // colDesc
            // 
            colDesc.DataPropertyName = "Description";
            colDesc.HeaderText = "Description";
            colDesc.Name = "colDesc";
            colDesc.ReadOnly = true;
            // 
            // colDiff
            // 
            colDiff.DataPropertyName = "Difficulty";
            colDiff.HeaderText = "Difficulty";
            colDiff.Name = "colDiff";
            colDiff.ReadOnly = true;
            // 
            // colButton
            // 
            colButton.DataPropertyName = "Done";
            colButton.FillWeight = 15F;
            colButton.HeaderText = "Done";
            colButton.Name = "colButton";
            colButton.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(249, 202, 36);
            label1.Font = new Font("1UP!", 50.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 78);
            label1.TabIndex = 1;
            label1.Text = "TASK";
            // 
            // btDel
            // 
            btDel.BackColor = Color.FromArgb(249, 202, 36);
            btDel.BackgroundImage = Properties.Resources.trashLogo;
            btDel.BackgroundImageLayout = ImageLayout.Zoom;
            btDel.Location = new Point(903, 56);
            btDel.Name = "btDel";
            btDel.Size = new Size(53, 49);
            btDel.TabIndex = 2;
            btDel.UseVisualStyleBackColor = false;
            btDel.Click += btDel_Click;
            // 
            // btAdd
            // 
            btAdd.BackColor = Color.FromArgb(249, 202, 36);
            btAdd.BackgroundImage = Properties.Resources.addLogo;
            btAdd.BackgroundImageLayout = ImageLayout.Zoom;
            btAdd.ForeColor = Color.Black;
            btAdd.Location = new Point(844, 56);
            btAdd.Name = "btAdd";
            btAdd.Size = new Size(53, 49);
            btAdd.TabIndex = 3;
            btAdd.UseVisualStyleBackColor = false;
            btAdd.Click += btAdd_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(249, 202, 36);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(968, 107);
            panel1.TabIndex = 4;
            // 
            // Task
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(968, 462);
            Controls.Add(btAdd);
            Controls.Add(btDel);
            Controls.Add(label1);
            Controls.Add(taskDataGridView);
            Controls.Add(panel1);
            Name = "Task";
            Text = "Task";
            ((System.ComponentModel.ISupportInitialize)taskDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button btDel;
        private Button btAdd;
        public DataGridView taskDataGridView;
        private DataGridViewTextBoxColumn colID;
        private DataGridViewTextBoxColumn colDesc;
        private DataGridViewTextBoxColumn colDiff;
        private DataGridViewButtonColumn colButton;
        private Panel panel1;
    }
}