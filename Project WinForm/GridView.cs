using System;
using System.Reflection;
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
                Global.item = new Instructor();

                loadData(instructors);
            }
            else if (Global.choice.Equals("Students", StringComparison.InvariantCultureIgnoreCase))
            {
                Global.item = new Student();
                students = new StudentList();

                loadData(students);
            }
            else if (Global.choice.Equals("Courses", StringComparison.InvariantCultureIgnoreCase))
            {
                courses = new CourseList();
                Global.item = new Course();

                loadData(courses);
            }
            else if (Global.choice.Equals("Schedules", StringComparison.InvariantCultureIgnoreCase))
            {
                schedules = new ScheduleList();
                Global.item = new Schedule();

                loadData(schedules);
            }
            else if (Global.choice.Equals("Locations", StringComparison.InvariantCultureIgnoreCase))
            {
                locations = new LocationList();
                Global.item = new Location();

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
            if (Global.choice == "Courses")
            {
                AddItem(true);
            } else
            {
                AddItem(false);
            }
        }


        private void AddItem(bool manual)
        {
            var item = Global.item;

            var type = item.GetType();
            PropertyInfo[] props = type.GetProperties();

            var count = 0;

            foreach (PropertyInfo prop in props)
            {
                if (manual == false && count == 0)
                {
                    prop.SetValue(item, (Global.list.GetMaxID() + 1).ToString());
                }
                else
                {
                    prop.SetValue(item, dgOne[count, dgOne.CurrentRow.Index].Value.ToString());
                }

                count++;
            }

            Global.list.Add(item);
        }

        private void EditItem()
        {
            var item = Global.item;

            var type = item.GetType();
            PropertyInfo[] props = type.GetProperties();

            var count = 0;

            foreach (PropertyInfo prop in props)
            {
                if (count != 0)
                {
                    prop.SetValue(item, dgOne[count, dgOne.CurrentRow.Index].Value.ToString());
                }

                count++;
            }

            Global.list.Update(item);
        }

    }
}
