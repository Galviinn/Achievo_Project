using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareE1.FormsDesktop
{
    public partial class Note : Form
    {
        DBHandler dbHandler = new DBHandler();
        public Note()
        {
            InitializeComponent();
            cbFont.SelectedIndex = 0;
            loadNote();
        }

        public void loadNote()
        {

            dbHandler.GetNoteData(noteDataGridView);

        }

        private void cbFont_TextChanged(object sender, EventArgs e)
        {
            try
            {
                rtbNote.SelectionFont = new Font(
                cbFont.Text,
                rtbNote.SelectionFont.Size,
                rtbNote.SelectionFont.Style);
            }
            catch (Exception)
            {

            }
            return;
        }

        private void btFontSize_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                rtbNote.SelectionFont = new Font(
                rtbNote.SelectionFont.FontFamily,
                (float)btFontSize.Value,
                rtbNote.SelectionFont.Style);
            }
            catch
            {
                //catch
            }

        }

        private void btBold_Click(object sender, EventArgs e)
        {
            if (rtbNote.SelectionFont.Style == FontStyle.Bold)
            {
                rtbNote.SelectionFont = new Font(
                    rtbNote.SelectionFont.FontFamily,
                    rtbNote.SelectionFont.Size,
                    FontStyle.Regular);
            }

            else
            {
                rtbNote.SelectionFont = new Font(
                    rtbNote.SelectionFont.FontFamily,
                    rtbNote.SelectionFont.Size,
                    FontStyle.Bold);
            }
        }

        private void btItalic_Click(object sender, EventArgs e)
        {
            if (rtbNote.SelectionFont.Style == FontStyle.Italic)
            {
                rtbNote.SelectionFont = new Font(
                    rtbNote.SelectionFont.FontFamily,
                    rtbNote.SelectionFont.Size,
                    FontStyle.Regular);
            }

            else
            {
                rtbNote.SelectionFont = new Font(
                    rtbNote.SelectionFont.FontFamily,
                    rtbNote.SelectionFont.Size,
                    FontStyle.Italic);
            }
        }

        private void btUnderline_Click(object sender, EventArgs e)
        {
            if (rtbNote.SelectionFont.Style == FontStyle.Underline)
            {
                rtbNote.SelectionFont = new Font(
                    rtbNote.SelectionFont.FontFamily,
                    rtbNote.SelectionFont.Size,
                    FontStyle.Regular);
            }

            else
            {
                rtbNote.SelectionFont = new Font(
                    rtbNote.SelectionFont.FontFamily,
                    rtbNote.SelectionFont.Size,
                    FontStyle.Underline);
            }
        }

        private void colorPanel_Click(object sender, EventArgs e)
        {
            colorDialog.AllowFullOpen = false;
            colorDialog.ShowHelp = true;
            colorDialog.Color = colorPanel.BackColor;
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                colorPanel.BackColor = colorDialog.Color;
                rtbNote.SelectionColor = colorPanel.BackColor;
                borderPanel.BackColor = colorPanel.BackColor;
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            tbTitle.Clear();
            rtbNote.Clear();

            noteDataGridView.ClearSelection();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            string Title = tbTitle.Text;
            saveFileDialog.Filter = "Rich Text Format (*.rtf)|*.rtf";
            saveFileDialog.FileName = Title;

            if (noteDataGridView.SelectedCells.Count == 1)
            {
                DataGridViewCell selectedCell = noteDataGridView.SelectedCells[0];
                int selectedRow = selectedCell.RowIndex;
                int selectedColumn = selectedCell.ColumnIndex;

                // Get the ID from the first column of the selected row
                int id = Convert.ToInt32(noteDataGridView.Rows[selectedRow].Cells[0].Value);
                string path = noteDataGridView.Rows[selectedRow].Cells[2].Value.ToString();

                dbHandler.updateNote(Title, id);
                rtbNote.SaveFile(path, RichTextBoxStreamType.RichText);
                MessageBox.Show($"Note '{Title}' has been successfully updated!", "A Task has been updated!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadNote();

            }
            else
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    rtbNote.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    string filePath = saveFileDialog.FileName;
                    dbHandler.newNote(Title, filePath);

                    btNew.PerformClick();
                    loadNote();
                }
            }

            noteDataGridView.ClearSelection();
        }

        private void btDelete_Click(object sender, EventArgs e)
        {

            if (noteDataGridView.SelectedCells.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete this note?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //Delete through iteration
                    for (int i = noteDataGridView.SelectedCells.Count - 1; i >= 0; i--)
                    {
                        int rowIndex = noteDataGridView.SelectedCells[i].RowIndex;
                        int id = Convert.ToInt32(noteDataGridView.Rows[rowIndex].Cells[0].Value);
                        noteDataGridView.Rows.RemoveAt(rowIndex);
                        dbHandler.DeleteNote(id);

                        //Clearing text fields
                        tbTitle.Text = "";
                        rtbNote.Text = "";
                    }

                    MessageBox.Show("Selected rows have been deleted.", "Delete Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadNote();
                }
            }
            else
            {
                MessageBox.Show("No cells are selected.", "Delete Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            noteDataGridView.ClearSelection();
        }

        private void Note_Load(object sender, EventArgs e)
        {
            noteDataGridView.ClearSelection();
        }

        private void noteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                DataGridViewCell clickedCell = noteDataGridView.Rows[e.RowIndex].Cells[0];

                //Getting ID
                int id = Convert.ToInt32(clickedCell.Value);
                (string Title, string Path) = dbHandler.readNote(id);

                tbTitle.Text = Title;
                rtbNote.LoadFile(Path, RichTextBoxStreamType.RichText);

            }
        }
    }
}
