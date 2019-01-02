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
        SectionStudentList sectionStudents;

        DataList list;
        string choice;
        Item item;

        public GridView()
        {
            InitializeComponent();
        }

        private void GridView_Load(object sender, EventArgs e)
        {
            choice = Global.choice;

            if (choice == "Instructors")
            {
                instructors = new InstructorList();
                item = new Instructor();

                loadData(instructors);
            }
            else if (choice == "Students")
            {
                item = new Student();
                students = new StudentList();

                loadData(students);
            }
            else if (choice == "Courses")
            {
                courses = new CourseList();
                item = new Course();

                loadData(courses);
            }
            else if (choice == "Schedules")
            {
                schedules = new ScheduleList();
                item = new Schedule();

                loadData(schedules);
            }
            else if (choice == "Locations")
            {
                locations = new LocationList();
                item = new Location();

                loadData(locations);
            }
        }

        private void filter(DataList list, string field, string value)
        {
            this.list = list;
            this.loadBase(list, true, field, value);
        }

        private void loadData(DataList list)
        {
            this.list = list;
            this.loadBase(list, false, null, null);
        }

        private void loadBase(DataList list, bool filter, string field, string value)
        {
            lblTitle.Text = choice;

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
            this.filter(list, txtField.Text, txtValue.Text);
        }

        private void btnAddOne_Click(object sender, EventArgs e)
        {
            if (choice == "Courses")
            {
                AddItem(true);
            }
            else
            {
                AddItem(false);
            }
        }

        private void AddItem(bool manual)
        {
            var localItem = item;

            var type = localItem.GetType();
            PropertyInfo[] props = type.GetProperties();

            var count = 0;

            foreach (PropertyInfo prop in props)
            {
                if (manual == false && count == 0)
                {
                    prop.SetValue(localItem, (list.GetMaxID() + 1).ToString());
                }
                else
                {
                    prop.SetValue(localItem, dgOne[count, dgOne.CurrentRow.Index].Value.ToString());
                }

                count++;
            }

            list.Add(localItem);
        }

        private void EditItem()
        {
            var localItem = item;

            var type = localItem.GetType();
            PropertyInfo[] props = type.GetProperties();

            var count = 0;

            foreach (PropertyInfo prop in props)
            {
                if (count != 0)
                {
                    prop.SetValue(localItem, dgOne[count, dgOne.CurrentRow.Index].Value.ToString());
                }

                count++;
            }

            list.Update(localItem);
        }

        private void btnEditOne_Click(object sender, EventArgs e)
        {
            EditItem();
        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            DeleteItem();
        }

        private void DeleteItem()
        {
            Item item = new Item();

            if (choice == "Students")
            {
                
                item.setID(dgOne[0, dgOne.CurrentRow.Index].Value.ToString());

                string column = "StudentID";
                string value = item.getID();

                sectionStudents = new SectionStudentList();

                sectionStudents.Delete(column, value);

                list.Delete(item);
            }
            else if (choice == "Sections")
            {
                item.setID(dgOne[0, dgOne.CurrentRow.Index].Value.ToString());

                string table2 = "Schedule";
                string key = "SectionID";
                string column = "ScheduleID";
                string value = item.getID();

                list.Delete(table2, key, column, value);


                list.Delete(column, value);

                list.Delete(item);
            }
            else
            {
                item.setID(dgOne[0, dgOne.CurrentRow.Index].Value.ToString());

                list.Delete(item);
            }
        }
        
    }
}
