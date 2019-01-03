using System;
using System.Reflection;
using System.Windows.Forms;
using CollegeBusinessObjects;

namespace Project_WinForm
{
    public partial class TotalHours : Form
    {
        //Declaration of class level variables.
        LocationList locations;
        SectionList sections;
        ScheduleList schedules;
        InstructorList instructors;
        CourseList courses;
        StudentList students;

        Location location;
        Section section;
        Instructor instructor;
        Course course;
        Student student;

        public TotalHours()
        {
            InitializeComponent();
        }

        private void TotalHours_Load(object sender, EventArgs e)
        {
            //Populating the lists.
            locations = new LocationList();
            locations.Populate();

            sections = new SectionList();
            sections.Populate();

            instructors = new InstructorList();
            instructors.Populate();

            courses = new CourseList();
            courses.Populate();

            students = new StudentList();
            students.Populate();

            //Setting DataSource of the ComboBoxes as the populated lists.
            LocationsList.DataSource = null;
            LocationsList.DataSource = locations.List;

            SectionsList.DataSource = null;
            SectionsList.DataSource = sections.List;

            InstructorsList.DataSource = null;
            InstructorsList.DataSource = instructors.List;

            CoursesList.DataSource = null;
            CoursesList.DataSource = courses.List;

            StudentsList.DataSource = null;
            StudentsList.DataSource = students.List;

            //Calling methods which load the textboxes with data.
            ShowHoursByLocation();
            ShowHoursBySection();
            ShowHoursByInstructor();
            ShowHoursByCourse();
            ShowHoursByStudent();
        }

        //Loads the textboxes under Location with the data for Location.
        //SectionID is set to the section object so that it can be able to call Populate(section)
        //and fill the rest of the object's data, which is then used to fill the textboxes.
        protected void ShowHoursByLocation()
        {
            //schedules list is used to call the TotalValue method below.
            schedules = new ScheduleList();

            location = new Location
            {
                LocationID = LocationsList.SelectedValue.ToString()
            };

            locations.Populate(location);

            txtLocationID.Text = location.LocationID;
            txtLocationName.Text = location.Name;
            txtLocationHours.Text = schedules.TotalValue("Duration", "LocationID", location.LocationID).ToString();
        }

        //Same as above for Section.
        protected void ShowHoursBySection()
        {
            sections = new SectionList();

            section = new Section
            {
                SectionID = SectionsList.SelectedValue.ToString()
            };

            sections.Populate(section);

            txtSectionID.Text = section.SectionID;
            txtSectionInstructorID.Text = section.InstructorID;
            txtSectionCapacity.Text = section.Capacity;
            txtSectionHours.Text = schedules.TotalValue("Duration", "SectionID", section.SectionID).ToString();
        }

        //Same as above for Instructor.
        protected void ShowHoursByInstructor()
        {
            instructors = new InstructorList();

            instructor = new Instructor
            {
                InstructorID = InstructorsList.SelectedValue.ToString()
            };

            instructors.Populate(instructor);

            txtInstructorID.Text = instructor.InstructorID;
            txtInstructorName.Text = instructor.FirstName + " " + instructor.LastName;
            txtInstructorHours.Text = schedules.TotalValue("Duration", "InstructorID", instructor.InstructorID, "Section", "SectionID").ToString();
        }

        //Same as above for Course.
        protected void ShowHoursByCourse()
        {
            schedules = new ScheduleList();

            course = new Course
            {
                CourseID = CoursesList.SelectedValue.ToString()
            };

            courses.Populate(course);

            txtCourseID.Text = course.CourseID;
            txtCourseTitle.Text = course.Title;
            txtCourseCredits.Text = course.Credits;
            txtCourseHours.Text = schedules.TotalValue("Duration", "CourseID", course.CourseID, "Section", "TaughtCourse", "SectionID", "TaughtCourseID").ToString();

        }

        //Same as above for Student.
        protected void ShowHoursByStudent()
        {
            schedules = new ScheduleList();

            student = new Student
            {
                StudentID = StudentsList.SelectedValue.ToString()
            };

            students.Populate(student);

            txtStudentID.Text = student.StudentID;
            txtStudentName.Text = student.FirstName + " " + student.LastName;
            txtEnrollmentDate.Text = student.EnrollmentDate;
            txtStudentHours.Text = schedules.TotalValue("Duration", "StudentID", student.StudentID, "SectionStudent", "SectionID").ToString();
        }

        //These three methods refresh the textbox data after new ID is selected from the combobox.
        private void LocationsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHoursByLocation();
        }

        private void SectionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHoursBySection();
        }

        private void InstructorsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHoursByInstructor();
        }

        private void CoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHoursByCourse();
        }

        private void StudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowHoursByStudent();
        }
    }
}

