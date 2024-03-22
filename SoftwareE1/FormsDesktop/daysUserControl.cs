using MySql.Data.MySqlClient;
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
    public partial class daysUserControl : UserControl
    {
        public static string static_day;
        DBHandler dbHandler = new DBHandler();
        public daysUserControl()
        {
            InitializeComponent();
        }

        private void daysUserControl_Load(object sender, EventArgs e)
        {
            UCTimer.Start();
        }

        public void days(int numday)
        {
            daysLabel.Text = numday + "";
        }

        private void daysUserControl_Click(object sender, EventArgs e)
        {
            static_day = daysLabel.Text;

            if (string.IsNullOrEmpty(eventLabel.Text))
            {
                NewCalendarPopUp newPop = new NewCalendarPopUp();
                newPop.Show();
            }
            else
            {
                UpdateCalendarPopUp updatePop = new UpdateCalendarPopUp();
                updatePop.Show();
            }

        }

        public void UCTimer_Tick(object sender, EventArgs e)
        {
            static_day = daysLabel.Text;
            string calendarEvent = dbHandler.LoadEvents(static_day, Calendar.static_month, Calendar.static_year);
            eventLabel.Text = calendarEvent;

            if (string.IsNullOrEmpty(eventLabel.Text))
            {
                eventLabel.Visible = false;
            }
            else
            {
                eventLabel.Visible = true;
            }
        }
    }
}
