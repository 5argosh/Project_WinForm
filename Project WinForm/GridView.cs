using System;
using System.Reflection;
using System.Windows.Forms;
using CollegeBusinessObjects;

namespace Project_WinForm
{
    public partial class GridView : Form
    {
        //Declaring these variables at class level since they may be used in several methods
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
            //The choice from the previous window is remembered through this global variable
            choice = Global.choice;

            //An if conditional is used so that the appropriate data is loaded based on
            //the user's choice.
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
            else if (choice == "Sections")
            {
                sections = new SectionList();
                item = new Section();

                loadData(sections);
            }
        }

        //For initially loading data, takes a parameter that determines the type
        //of data to load.
        //Sets the local DataList variable as one of the child types based on the user choice.
        //This allows us to use a single form for all the datalist types.
        //Calls loadBase which finally calls Populate.
        private void loadData(DataList list)
        {
            this.list = list;
            this.loadBase(list, false, null, null);
        }

        //Calls populate is boolean filter is false. If true, filter method is called.
        //Sets the DataSource of the DataGrid as the DataTable of the current DataList variable.
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

        //Calls filter method.
        private void btnFilter_Click(object sender, EventArgs e)
        {
            this.filter(list, txtField.Text, txtValue.Text);
        }

        //Calls loadBase, passing in boolean Filter as TRUE so that the Filter method is called.
        private void filter(DataList list, string field, string value)
        {
            this.list = list;
            this.loadBase(list, true, field, value);
        }

        //If Add button is clicked, and choice is Courses, the ID must be added manually.
        //Otherwise it will be added using GetMadID + 1.
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

        //Creates an item object which will be of the type the user chose (this was set
        //in the Form Load method.
        //PropertyInfo is looped to set values.
        //For each property, if the manual boolean is false, the ID is added using GetMaxID + 1,
        //otherwise it is added manually (taken from the user input) because it is Courses which
        //requires specific ID (for example, IDs beginning in 2 means on the second floor).
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

            //This code is to prevent double scheduling.
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

                //Checking is record exists and storing in the booleans
                bool exists = list.Exists("Day", day, "Time", time, "SectionID", sectionID);

                bool scheduled = list.Exists("Section", "Day", day, "Time", time, "InstructorID", section.InstructorID, "SectionID");

                bool capacityExcceded = int.Parse(section.Capacity) > int.Parse(location.Capacity);

                if (exists)
                {
                    MessageBox.Show("The location is already scheduled at this day and time.");
                    return;
                }
                else if (scheduled)
                {
                    MessageBox.Show("The instructor is already scheduled at this day and time.");
                    return;
                }
                else if (capacityExcceded)
                {
                    MessageBox.Show("The capacity of the section exceeds the capacity of the location.");
                    return;
                }
            }

            //Adds the item
            list.Add(localItem);
        }

        //Creates an item object which will be of the type the user chose (this was set
        //in the Form Load method.
        //PropertyInfo is looped to set values.
        //List is updated with the new Item.
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

        //Calls the EditItem method and reloads the data.
        private void btnEditOne_Click(object sender, EventArgs e)
        {
            EditItem();
            loadData(this.list);
        }

        //Calls the DeleteItem method and reloads the data.
        private void btnDeleteOne_Click(object sender, EventArgs e)
        {
            DeleteItem();
            loadData(this.list);
        }

        //DeleteItem method. The sequence of deletion is depending on the ERD of the Database.
        //If a student is to be deleted, first its foreign key in SectionStudent must be deleted.
        //This is done using Delete(column, value).
        //Then the student record can be deleted using Delete(item).
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
            //If a section is to be deleted, it is a similar process to the above.
            //Foreign keys must first be deleted from SectionStudent and Schedule.
            //Then the section is deleted.
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
            //If an instructor is to be deleted, record in Section must be deleted.
            //But to do so requires deleting records which have foreign keys of Section,
            //which are in Schedule and SectionStudent.
            //Once all this is done the Instuctor record may be deleted without issue.
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
            //Deleting a TaughtCourse follows the same process as deleting Instructor.
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
            //Else, delete the record normally.
            else
            {
                item.setID(dgOne[0, dgOne.CurrentRow.Index].Value.ToString());
                list.Delete(item);
            }
        }
        
    }
}
