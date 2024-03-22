namespace SoftwareE1.FormsDesktop
{
    partial class Note
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
            panel1 = new Panel();
            panel3 = new Panel();
            btDelete = new Button();
            btSave = new Button();
            btNew = new Button();
            noteDataGridView = new DataGridView();
            noteID = new DataGridViewTextBoxColumn();
            Title = new DataGridViewTextBoxColumn();
            notePath = new DataGridViewTextBoxColumn();
            label2 = new Label();
            panel4 = new Panel();
            colorDialog = new ColorDialog();
            tableLayoutPanel1 = new TableLayoutPanel();
            FontGroupBox = new GroupBox();
            borderPanel = new Panel();
            colorPanel = new Panel();
            btUnderline = new Button();
            btItalic = new Button();
            btBold = new Button();
            btFontSize = new NumericUpDown();
            cbFont = new ComboBox();
            rtbNote = new RichTextBox();
            label3 = new Label();
            panel2 = new Panel();
            tbTitle = new TextBox();
            label1 = new Label();
            saveFileDialog = new SaveFileDialog();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)noteDataGridView).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            FontGroupBox.SuspendLayout();
            borderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btFontSize).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(noteDataGridView);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(panel4);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(599, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(369, 462);
            panel1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(btDelete);
            panel3.Controls.Add(btSave);
            panel3.Controls.Add(btNew);
            panel3.Location = new Point(3, 421);
            panel3.Margin = new Padding(0);
            panel3.Name = "panel3";
            panel3.Size = new Size(363, 29);
            panel3.TabIndex = 6;
            // 
            // btDelete
            // 
            btDelete.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btDelete.Location = new Point(144, 3);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(75, 23);
            btDelete.TabIndex = 6;
            btDelete.Text = "Delete";
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // btSave
            // 
            btSave.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btSave.Location = new Point(274, 3);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 5;
            btSave.Text = "Save";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btNew
            // 
            btNew.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            btNew.Location = new Point(14, 3);
            btNew.Name = "btNew";
            btNew.Size = new Size(75, 23);
            btNew.TabIndex = 3;
            btNew.Text = "Clear";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // noteDataGridView
            // 
            noteDataGridView.AllowUserToAddRows = false;
            noteDataGridView.AllowUserToDeleteRows = false;
            noteDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            noteDataGridView.BackgroundColor = Color.FromArgb(189, 195, 199);
            noteDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            noteDataGridView.ColumnHeadersVisible = false;
            noteDataGridView.Columns.AddRange(new DataGridViewColumn[] { noteID, Title, notePath });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(249, 202, 36);
            dataGridViewCellStyle1.SelectionForeColor = Color.Black;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            noteDataGridView.DefaultCellStyle = dataGridViewCellStyle1;
            noteDataGridView.Location = new Point(3, 71);
            noteDataGridView.Name = "noteDataGridView";
            noteDataGridView.ReadOnly = true;
            noteDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle2.Font = new Font("Montserrat", 8.249999F, FontStyle.Regular, GraphicsUnit.Point);
            noteDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            noteDataGridView.RowTemplate.Height = 25;
            noteDataGridView.Size = new Size(363, 344);
            noteDataGridView.TabIndex = 2;
            noteDataGridView.CellClick += noteDataGridView_CellClick;
            // 
            // noteID
            // 
            noteID.DataPropertyName = "ID";
            noteID.HeaderText = "ID";
            noteID.Name = "noteID";
            noteID.ReadOnly = true;
            noteID.Visible = false;
            // 
            // Title
            // 
            Title.DataPropertyName = "Title";
            Title.HeaderText = "Title";
            Title.Name = "Title";
            Title.ReadOnly = true;
            // 
            // notePath
            // 
            notePath.DataPropertyName = "Path";
            notePath.HeaderText = "Path";
            notePath.Name = "notePath";
            notePath.ReadOnly = true;
            notePath.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(249, 202, 36);
            label2.Font = new Font("1UP!", 21.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(54, 19);
            label2.Name = "label2";
            label2.Size = new Size(261, 34);
            label2.TabIndex = 1;
            label2.Text = "SAVED NOTE";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(249, 202, 36);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(369, 68);
            panel4.TabIndex = 7;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(FontGroupBox, 0, 2);
            tableLayoutPanel1.Controls.Add(rtbNote, 0, 3);
            tableLayoutPanel1.Controls.Add(label3, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.95221F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 65F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 81.04779F));
            tableLayoutPanel1.Size = new Size(599, 462);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // FontGroupBox
            // 
            FontGroupBox.Controls.Add(borderPanel);
            FontGroupBox.Controls.Add(btUnderline);
            FontGroupBox.Controls.Add(btItalic);
            FontGroupBox.Controls.Add(btBold);
            FontGroupBox.Controls.Add(btFontSize);
            FontGroupBox.Controls.Add(cbFont);
            FontGroupBox.Dock = DockStyle.Left;
            FontGroupBox.Font = new Font("Montserrat", 8.999999F, FontStyle.Regular, GraphicsUnit.Point);
            FontGroupBox.Location = new Point(3, 106);
            FontGroupBox.Name = "FontGroupBox";
            FontGroupBox.Size = new Size(322, 59);
            FontGroupBox.TabIndex = 1;
            FontGroupBox.TabStop = false;
            FontGroupBox.Text = "Font";
            // 
            // borderPanel
            // 
            borderPanel.BackColor = Color.Black;
            borderPanel.Controls.Add(colorPanel);
            borderPanel.Location = new Point(293, 28);
            borderPanel.Name = "borderPanel";
            borderPanel.Size = new Size(23, 23);
            borderPanel.TabIndex = 5;
            // 
            // colorPanel
            // 
            colorPanel.BackColor = Color.Black;
            colorPanel.Location = new Point(3, 3);
            colorPanel.Name = "colorPanel";
            colorPanel.Size = new Size(17, 17);
            colorPanel.TabIndex = 0;
            colorPanel.Click += colorPanel_Click;
            // 
            // btUnderline
            // 
            btUnderline.Font = new Font("Gadugi", 9F, FontStyle.Underline, GraphicsUnit.Point);
            btUnderline.Location = new Point(260, 28);
            btUnderline.Name = "btUnderline";
            btUnderline.Size = new Size(27, 23);
            btUnderline.TabIndex = 4;
            btUnderline.Text = "U";
            btUnderline.UseVisualStyleBackColor = true;
            btUnderline.Click += btUnderline_Click;
            // 
            // btItalic
            // 
            btItalic.Font = new Font("Gadugi", 9F, FontStyle.Italic, GraphicsUnit.Point);
            btItalic.Location = new Point(227, 28);
            btItalic.Name = "btItalic";
            btItalic.Size = new Size(27, 23);
            btItalic.TabIndex = 3;
            btItalic.Text = "I";
            btItalic.UseVisualStyleBackColor = true;
            btItalic.Click += btItalic_Click;
            // 
            // btBold
            // 
            btBold.Font = new Font("Gadugi", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btBold.Location = new Point(194, 28);
            btBold.Name = "btBold";
            btBold.Size = new Size(27, 23);
            btBold.TabIndex = 2;
            btBold.Text = "B";
            btBold.UseVisualStyleBackColor = true;
            btBold.Click += btBold_Click;
            // 
            // btFontSize
            // 
            btFontSize.Location = new Point(133, 28);
            btFontSize.Name = "btFontSize";
            btFontSize.Size = new Size(55, 22);
            btFontSize.TabIndex = 1;
            btFontSize.Value = new decimal(new int[] { 8, 0, 0, 0 });
            btFontSize.ValueChanged += btFontSize_ValueChanged;
            // 
            // cbFont
            // 
            cbFont.FormattingEnabled = true;
            cbFont.Items.AddRange(new object[] { "", "Algerian", "Arial", "Calibri", "Comic Sans MS", "Impact", "Times New Roman" });
            cbFont.Location = new Point(6, 28);
            cbFont.Name = "cbFont";
            cbFont.Size = new Size(121, 24);
            cbFont.TabIndex = 0;
            cbFont.TextChanged += cbFont_TextChanged;
            // 
            // rtbNote
            // 
            rtbNote.Dock = DockStyle.Fill;
            rtbNote.Location = new Point(3, 171);
            rtbNote.Name = "rtbNote";
            rtbNote.Size = new Size(593, 288);
            rtbNote.TabIndex = 2;
            rtbNote.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(249, 202, 36);
            label3.Dock = DockStyle.Fill;
            label3.Font = new Font("1UP!", 39.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(593, 68);
            label3.TabIndex = 4;
            label3.Text = "NOTE";
            // 
            // panel2
            // 
            panel2.Controls.Add(tbTitle);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 68);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Size = new Size(599, 35);
            panel2.TabIndex = 3;
            // 
            // tbTitle
            // 
            tbTitle.Font = new Font("Gadugi", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            tbTitle.Location = new Point(50, 5);
            tbTitle.Name = "tbTitle";
            tbTitle.Size = new Size(284, 25);
            tbTitle.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 9.749999F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(9, 7);
            label1.Name = "label1";
            label1.Size = new Size(37, 18);
            label1.TabIndex = 0;
            label1.Text = "Title:";
            // 
            // Note
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(968, 462);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel1);
            MaximumSize = new Size(984, 501);
            Name = "Note";
            Text = "Note";
            Load += Note_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)noteDataGridView).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            FontGroupBox.ResumeLayout(false);
            borderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btFontSize).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Label label2;
        private ColorDialog colorDialog;
        private DataGridView noteDataGridView;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox FontGroupBox;
        private Panel borderPanel;
        private Panel colorPanel;
        private Button btUnderline;
        private Button btItalic;
        private Button btBold;
        private NumericUpDown btFontSize;
        private ComboBox cbFont;
        private RichTextBox rtbNote;
        private Panel panel2;
        private Label label1;
        private TextBox tbTitle;
        private Label label3;
        private Button btNew;
        private Panel panel3;
        private Button btSave;
        private Button btDelete;
        private SaveFileDialog saveFileDialog;
        private DataGridViewTextBoxColumn noteID;
        private DataGridViewTextBoxColumn Title;
        private DataGridViewTextBoxColumn notePath;
        private Panel panel4;
    }
}