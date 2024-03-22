using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareE1.FormsDesktop
{
    public partial class Calendar : Form
    {
        int month, year;
        public static int static_month, static_year;

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            displayDays();
        }

        //Displaying current calendar
        private void displayDays()
        {
            DateTime now = DateTime.Now;
            month = now.Month;
            year = now.Year;

            static_month = month;
            static_year = year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearLabel.Text = monthName + " " + year;

            //Get the first day of the month.
            DateTime monthStart = new DateTime(year, month, 1);

            //Days in the reffered month
            int days = DateTime.DaysInMonth(year, month);

            //Start of thye month to integer
            int dayofweek = Convert.ToInt32(monthStart.DayOfWeek.ToString("d"));

            //blankUserControl.cs config
            for (int i = 1; i <= dayofweek; i++)
            {
                blankUserControl blank = new blankUserControl();
                calendarContainer.Controls.Add(blank);
            }

            //dayUserControl.cs config
            for (int i = 1; i <= days; i++)
            {
                daysUserControl daysUC = new daysUserControl();
                daysUC.days(i);
                calendarContainer.Controls.Add(daysUC);
            }


        }

        //Displaying previous calendar
        private void nextBtn_Click(object sender, EventArgs e)
        {
            //Clear calendarContainer
            calendarContainer.Controls.Clear();

            //inc to Month next
            month++;

            if (month > 12)
            {
                year++;
                month = 1;
            }

            static_month = month;
            static_year = year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearLabel.Text = monthName + " " + year;

            //Get the first day of the month.
            DateTime monthStart = new DateTime(year, month, 1);

            //Days in the reffered month
            int days = DateTime.DaysInMonth(year, month);

            //Start of thye month to integer
            int dayofweek = Convert.ToInt32(monthStart.DayOfWeek.ToString("d"));

            //blankUserControl.cs config
            for (int i = 1; i <= dayofweek; i++)
            {
                blankUserControl blank = new blankUserControl();
                calendarContainer.Controls.Add(blank);
            }

            //dayUserControl.cs config
            for (int i = 1; i <= days; i++)
            {
                daysUserControl daysUC = new daysUserControl();
                daysUC.days(i);
                calendarContainer.Controls.Add(daysUC);
            }
        }

        //Displaying next calendar
        private void prevBtn_Click(object sender, EventArgs e)
        {
            //Clear calendarContainer
            calendarContainer.Controls.Clear();

            //dec to Month prev
            month--;

            if (month < 1)
            {
                year--;
                month = 12;
            }

            static_month = month;
            static_year = year;

            String monthName = DateTimeFormatInfo.CurrentInfo.GetMonthName(month);
            monthYearLabel.Text = monthName + " " + year;

            //Get the first day of the month.
            DateTime monthStart = new DateTime(year, month, 1);

            //Days in the reffered month
            int days = DateTime.DaysInMonth(year, month);

            //Start of thye month to integer
            int dayofweek = Convert.ToInt32(monthStart.DayOfWeek.ToString("d"));

            //blankUserControl.cs config
            for (int i = 1; i <= dayofweek; i++)
            {
                blankUserControl blank = new blankUserControl();
                calendarContainer.Controls.Add(blank);
            }

            //dayUserControl.cs config
            for (int i = 1; i <= days; i++)
            {
                daysUserControl daysUC = new daysUserControl();
                daysUC.days(i);
                calendarContainer.Controls.Add(daysUC);
            }
        }
    }
}
