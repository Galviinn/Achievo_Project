using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SoftwareE1
{
    public partial class Main_Menu : Form
    {
        private Form activateForm;
        public Main_Menu()
        {
            InitializeComponent();
            OpenChildForm(new FormsDesktop.Main());
        }

        private void OpenChildForm(Form childForm)
        {
            if (activateForm != null)
            {
                activateForm.Close();
            }

            activateForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktop.Controls.Add(childForm);
            this.panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }


        private void btNote_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsDesktop.Note());
        }

        private void btStore_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsDesktop.Store());
        }

        private void btCalendar_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsDesktop.Calendar());
        }

        private void btTask_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsDesktop.Task());
        }

        private void btHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormsDesktop.Main());
        }
    }
}
