using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_WinForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btnInstructors_Click(object sender, EventArgs e)
        {
            Global.choice = "Instructors";
            openForm();
        }

        private void btnStudents_Click(object sender, EventArgs e)
        {
            Global.choice = "Students";
            openForm();
        }

        private void btnCourses_Click(object sender, EventArgs e)
        {
            Global.choice = "Courses";
            openForm();
        }

        private void btnSchedules_Click(object sender, EventArgs e)
        {
            Global.choice = "Schedules";
            openForm();
        }

        private void btnLocations_Click(object sender, EventArgs e)
        {
            Global.choice = "Locations";
            openForm();
        }

        private void openForm()
        {
            GridView form = new GridView();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
