using System;
using System.Windows.Forms;

namespace Project_WinForm
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        /*
          When the user clicks on one of the buttons for the types, that type is stored
          in a variable in Global class, this is so that the choice is remembered
          in the next window.
          The selected window then opens by calling openForm() method.
        */

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

        private void btnToughtCourses_Click(object sender, EventArgs e)
        {
            Global.choice = "TaughtCourses";
            openForm();
        }
        
        private void btnSections_Click(object sender, EventArgs e)
        {
            Global.choice = "Sections";
            openForm();
        }

        //Following OO principles this code was put in a method since it is needed several times
        private void openForm()
        {
            GridView form = new GridView();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        //To open the Average Grade Report
        private void btnAvgGrade_Click(object sender, EventArgs e)
        {
            AverageGrade form = new AverageGrade();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }

        //To open the Total Scheduled Hours Report
        private void btnTotalHours_Click(object sender, EventArgs e)
        {
            TotalHours form = new TotalHours();
            form.StartPosition = FormStartPosition.CenterScreen;
            form.Show();
        }
    }
}
