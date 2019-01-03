using System;
using System.Reflection;
using System.Windows.Forms;
using CollegeBusinessObjects;

namespace Project_WinForm
{
    public partial class AverageGrade : Form
    {
        //Declaration of class level variables.
        SectionStudentList sectionStudents;

        SectionList sections;
        CourseList courses;
        StudentList students;

        Section section;
        Course course;
        Student student;

        public AverageGrade()
        {
            InitializeComponent();
        }

        private void AverageGrade_Load(object sender, EventArgs e)
        {
            //Populating the lists.
            sectionStudents = new SectionStudentList();

            sections = new SectionList();
            sections.Populate();

            courses = new CourseList();
            courses.Populate();

            students = new StudentList();
            students.Populate();

            //Setting DataSource of the ComboBoxes as the populated lists.
            SectionsList.DataSource = null;
            SectionsList.DataSource = sections.List;

            StudentsList.DataSource = null;
            StudentsList.DataSource = students.List;

            CoursesList.DataSource = null;
            CoursesList.DataSource = courses.List;

            //Calling methods which load the textboxes with data.
            ShowGradesBySection();
            ShowGradesByStudent();
            ShowGradesByCourse();
        }

        //Loads the textboxes under Section with the data for Section.
        private void ShowGradesBySection()
        {
            //SectionID is set to the section object so that it can be able to call Populate(section)
            //and fill the rest of the object's data, which is then used to fill the textboxes.
            section = new Section
            {
                SectionID = SectionsList.SelectedValue.ToString()
            };

            sections.Populate(section);

            txtSectionID.Text = section.SectionID;
            txtSectionCapacity.Text = section.Capacity;
            txtSectionGrade.Text = sectionStudents.AverageValue("Grade", "SectionID", section.SectionID).ToString();
        }

        //Same as above for Student.
        private void ShowGradesByStudent()
        {
            student = new Student
            {
                StudentID = StudentsList.SelectedValue.ToString()
            };

            students.Populate(student);

            txtStudentID.Text = student.StudentID;
            txtStudentName.Text = student.FirstName + " " + student.LastName;
            txtEnrollmentDate.Text = student.EnrollmentDate;
            txtStudentGrade.Text = sectionStudents.AverageValue("Grade", "StudentID", student.StudentID).ToString();
        }

        //Same as above for Course.
        private void ShowGradesByCourse()
        {
            course = new Course
            {
                CourseID = CoursesList.SelectedValue.ToString()
            };

            courses.Populate(course);

            txtCourseID.Text = course.CourseID;
            txtCourseTitle.Text = course.Title;
            txtCourseCredits.Text = course.Credits;
            txtCourseGrade.Text = sectionStudents.AverageValue("Grade", "CourseID", course.CourseID, "Section", "TaughtCourse", "SectionID", "TaughtCourseID").ToString();
        }
        
        //These three methods refresh the textbox data after new ID is selected from the combobox.
        private void SectionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGradesBySection();
        }

        private void CoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGradesByCourse();
        }

        private void StudentsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowGradesByStudent();
        }
    }
}
