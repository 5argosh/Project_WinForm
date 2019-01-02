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
        SectionList sections;
        ToughtCourseList toughtCourses;

        Section section;
        Location location;

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

                this.btnAddOne.Enabled = false;
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
                this.btnAddOne.Enabled = false;
            }
            else if (choice == "TaughtCourses")
            {
                toughtCourses = new ToughtCourseList();
                item = new ToughtCourse();

                loadData(toughtCourses);
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

            loadData(this.list);
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

            if (choice == "Schedules")
            {
                string day = props[3].GetValue(item).ToString();
                string time = props[4].GetValue(item).ToString();
                string sectionID = props[1].GetValue(item).ToString();
                string locationID = props[2].GetValue(item).ToString();

                section = new Section();
                section.SectionID = sectionID;

                sections = new SectionList();
                sections.Populate(section);

                location = new Location();
                location.LocationID = locationID;

                locations = new LocationList();
                locations.Populate(location);


                bool exists = list.Exists("Day", day, "Time", time, "SectionID", sectionID);

                bool scheduled = list.Exists("Section", "Day", day, "Time", time, "InstructorID", section.InstructorID, "SectionID");

                bool capacityExcceded = int.Parse(section.Capacity) > int.Parse(location.Capacity);

                if (exists)
                {
                    MessageBox.Show("The location is already scheduled");
                    return;
                }
                else if (scheduled)
                {
                    MessageBox.Show("Bla Bla");
                    return;
                }
                else if (capacityExcceded)
                {
                    MessageBox.Show("Bla Bla");
                    return;
                }
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
            loadData(this.list);
        }

        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            DeleteItem();
            loadData(this.list);
        }

        private void DeleteItem()
        {
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

                string column = "SectionID";
                string value = item.getID();

                sectionStudents = new SectionStudentList();

                sectionStudents.Delete(column, value);

                schedules = new ScheduleList();

                schedules.Delete(column, value);

                list.Delete(item);
            }
            else if (choice == "Instructors")
            {
                item.setID(dgOne[0, dgOne.CurrentRow.Index].Value.ToString());

                string column = "InstructorID";
                string key = "SectionID";
                string value = item.getID();

                sections = new SectionList();
                sectionStudents = new SectionStudentList();
                schedules = new ScheduleList();

                schedules.Delete("Section", column, key, value);
                sectionStudents.Delete("Section", column, key, value);
                sections.Delete(column, value);

                list.Delete(item);
            }
            else if (choice == "TaughtCourses")
            {
                item.setID(dgOne[0, dgOne.CurrentRow.Index].Value.ToString());

                string column = "TaughtCourseID";
                string key = "SectionID";
                string value = item.getID();

                sections = new SectionList();
                sectionStudents = new SectionStudentList();
                schedules = new ScheduleList();

                schedules.Delete("Section", column, key, value);
                sectionStudents.Delete("Section", column, key, value);
                sections.Delete(column, value);

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
