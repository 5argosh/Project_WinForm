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
                instructors = new InstructorList();
                loadData(instructors);
            }
            else if (Global.choice.Equals("Students", StringComparison.InvariantCultureIgnoreCase))
            {
                students = new StudentList();
                loadData(students);
            }
            else if (Global.choice.Equals("Courses", StringComparison.InvariantCultureIgnoreCase))
            {
                courses = new CourseList();
                loadData(courses);
            }
            else if (Global.choice.Equals("Schedules", StringComparison.InvariantCultureIgnoreCase))
            {
                schedules = new ScheduleList();
                loadData(schedules);
            }
            else if (Global.choice.Equals("Locations", StringComparison.InvariantCultureIgnoreCase))
            {
                locations = new LocationList();
                loadData(locations);
            }
        }

        /* NEW */

        private void filter(DataList list, string field, string value)
        {
            this.loadBase(list, true, field, value);
        }

        private void loadData(DataList list)
        {
            this.loadBase(list, false, null, null);
        }

        private void loadBase(DataList list, bool filter, string field, string value)
        {
            Global.list = list;

            lblTitle.Text = Global.choice;

            if (filter)
            {
                list.Filter(field, value);
            }
            else
            {
                list.Populate();
            }

            dgOne.DataSource = list.DataTable;
        }

    private void btnFilter_Click(object sender, EventArgs e)
        {
            this.filter(Global.list, txtField.Text, txtValue.Text);
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
