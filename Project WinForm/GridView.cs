using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CollegeBusinessObjects;

namespace Project_WinForm
{
    public partial class GridView : Form
    {
        InstructorList instructors;
        StudentList students;
        CourseList courses;
        ScheduleList schedules;
        LocationList locations;

        public GridView()
        {
            InitializeComponent();
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            if (Global.choice.Equals("Instructors", StringComparison.InvariantCultureIgnoreCase))
            {
                loadInstructors();
            }
            else if (Global.choice.Equals("Students", StringComparison.InvariantCultureIgnoreCase))
            {
                loadStudents();
            }
            else if (Global.choice.Equals("Courses", StringComparison.InvariantCultureIgnoreCase))
            {
                loadCourses();
            }
            else if (Global.choice.Equals("Schedules", StringComparison.InvariantCultureIgnoreCase))
            {
                loadSchedules();
            }
            else if (Global.choice.Equals("Locations", StringComparison.InvariantCultureIgnoreCase))
            {
                loadLocations();
            }
        }

        private void loadInstructors()
        {
            instructors = new InstructorList();
            instructors.Populate();

            dgOne.DataSource = instructors.DataTable;
        }

        private void loadStudents()
        {
            students = new StudentList();
            students.Populate();

            dgOne.DataSource = students.DataTable;
        }

        private void loadCourses()
        {
            courses = new CourseList();
            courses.Populate();

            dgOne.DataSource = courses.DataTable;
        }

        private void loadSchedules()
        {
            schedules = new ScheduleList();
            schedules.Populate();

            dgOne.DataSource = schedules.DataTable;
        }

        private void loadLocations()
        {
            locations = new LocationList();
            locations.Populate();

            dgOne.DataSource = locations.DataTable;
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            if (Global.choice.Equals("Instructors", StringComparison.InvariantCultureIgnoreCase))
            {
                addInstructor();
            }
            else if (Global.choice.Equals("Students", StringComparison.InvariantCultureIgnoreCase))
            {
                addStudents();
            }
            else if (Global.choice.Equals("Courses", StringComparison.InvariantCultureIgnoreCase))
            {
                //addCourses();
            }
        }

        private void addInstructor()
        {
            instructors = new InstructorList();
            Instructor instructor = new Instructor(instructors.GetMaxID().ToString());

            instructor.LastName = dgOne[1, dgOne.CurrentRow.Index].Value.ToString();
            instructor.FirstName = dgOne[2, dgOne.CurrentRow.Index].Value.ToString();
            instructor.HireDate = dgOne[3, dgOne.CurrentRow.Index].Value.ToString();
            instructor.Password = dgOne[4, dgOne.CurrentRow.Index].Value.ToString();

            instructors.Add(instructor);
        }

        private void addStudents()
        {

        }
    }
}
