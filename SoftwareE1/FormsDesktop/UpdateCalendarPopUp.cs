using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareE1.FormsDesktop
{
    public partial class UpdateCalendarPopUp : Form
    {
        DBHandler dbHandler = new DBHandler();
        public UpdateCalendarPopUp()
        {
            InitializeComponent();
        }

        private void updateEventBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEvent.Text))
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool x = dbHandler.UpdateEvent(tbDate.Text, tbEvent.Text);
                if (x)
                {
                    MessageBox.Show("Event Updated!", "Update an Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Update!", "Update an Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }  
        }

        private void UpdateCalendarPopUp_Load(object sender, EventArgs e)
        {
            tbDate.Text = daysUserControl.static_day + "/" + Calendar.static_month + "/" + Calendar.static_year;
        }

        private void deleteEventBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure want to delete this Event?", "Confirm Event Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.Yes)
            {
                bool x = dbHandler.DeleteEvent(tbDate.Text);
                if (x)
                {
                    MessageBox.Show("Event Deleted!", "Delete an Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Deleted!", "Delete an Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
