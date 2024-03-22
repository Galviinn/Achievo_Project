using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SoftwareE1.FormsDesktop
{
    public partial class AddForm : Form
    {
        Task task;
        public AddForm(Task task)
        {
            InitializeComponent();
            this.task = task;
        }

        private void btOk_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox.Text) || string.IsNullOrEmpty(comboBox.SelectedItem.ToString()))
            {
                MessageBox.Show("Please fill in all the fields.");
                return; // Stop further execution
            }
            else
            {
                DBHandler dbHandler = new DBHandler();
                string level = comboBox.SelectedItem.ToString();
                bool insertTask = dbHandler.InsertTask(textBox.Text, level);

                if (insertTask)
                {
                    // Registration failed, display an error message or take appropriate action
                    MessageBox.Show("Registration failed. Please try again.");
                }
                else
                {
                    this.Close();
                }

            }
        }

        private void btCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
