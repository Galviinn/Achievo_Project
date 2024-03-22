using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SoftwareE1.FormsDesktop
{
    public partial class NewCalendarPopUp : Form
    {
        DBHandler dbHandler = new DBHandler();
        public NewCalendarPopUp()
        {
            InitializeComponent();
        }

        private void addEventBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbEvent.Text))
            {
                MessageBox.Show("Please fill all fields!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool x = dbHandler.NewEvent(tbDate.Text, tbEvent.Text);
                if (x)
                {
                    MessageBox.Show("Event Added!", "Add an Event", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Failed to Add!", "Add an Event", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CalendarPopUp_Load(object sender, EventArgs e)
        {
            tbDate.Text = daysUserControl.static_day + "/" + Calendar.static_month + "/" + Calendar.static_year;
        }
    }
}
