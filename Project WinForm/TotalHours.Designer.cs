namespace Project_WinForm
{
    partial class TotalHours
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LocationsList = new System.Windows.Forms.ComboBox();
            this.SectionsList = new System.Windows.Forms.ComboBox();
            this.InstructorsList = new System.Windows.Forms.ComboBox();
            this.CoursesList = new System.Windows.Forms.ComboBox();
            this.StudentsList = new System.Windows.Forms.ComboBox();
            this.txtInstructorHours = new System.Windows.Forms.TextBox();
            this.txtInstructorName = new System.Windows.Forms.TextBox();
            this.txtInstructorID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSectionHours = new System.Windows.Forms.TextBox();
            this.txtSectionCapacity = new System.Windows.Forms.TextBox();
            this.txtSectionInstructorID = new System.Windows.Forms.TextBox();
            this.txtSectionID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLocationHours = new System.Windows.Forms.TextBox();
            this.txtLocationName = new System.Windows.Forms.TextBox();
            this.txtLocationID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCourseHours = new System.Windows.Forms.TextBox();
            this.txtCourseCredits = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtStudentHours = new System.Windows.Forms.TextBox();
            this.txtEnrollmentDate = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LocationsList
            // 
            this.LocationsList.FormattingEnabled = true;
            this.LocationsList.Location = new System.Drawing.Point(19, 58);
            this.LocationsList.Name = "LocationsList";
            this.LocationsList.Size = new System.Drawing.Size(121, 21);
            this.LocationsList.TabIndex = 0;
            this.LocationsList.SelectedIndexChanged += new System.EventHandler(this.LocationsList_SelectedIndexChanged);
            // 
            // SectionsList
            // 
            this.SectionsList.FormattingEnabled = true;
            this.SectionsList.Location = new System.Drawing.Point(170, 58);
            this.SectionsList.Name = "SectionsList";
            this.SectionsList.Size = new System.Drawing.Size(121, 21);
            this.SectionsList.TabIndex = 1;
            this.SectionsList.SelectedIndexChanged += new System.EventHandler(this.SectionsList_SelectedIndexChanged);
            // 
            // InstructorsList
            // 
            this.InstructorsList.FormattingEnabled = true;
            this.InstructorsList.Location = new System.Drawing.Point(321, 58);
            this.InstructorsList.Name = "InstructorsList";
            this.InstructorsList.Size = new System.Drawing.Size(121, 21);
            this.InstructorsList.TabIndex = 2;
            this.InstructorsList.SelectedIndexChanged += new System.EventHandler(this.InstructorsList_SelectedIndexChanged);
            // 
            // CoursesList
            // 
            this.CoursesList.FormattingEnabled = true;
            this.CoursesList.Location = new System.Drawing.Point(472, 58);
            this.CoursesList.Name = "CoursesList";
            this.CoursesList.Size = new System.Drawing.Size(121, 21);
            this.CoursesList.TabIndex = 3;
            this.CoursesList.SelectedIndexChanged += new System.EventHandler(this.CoursesList_SelectedIndexChanged);
            // 
            // StudentsList
            // 
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.Location = new System.Drawing.Point(623, 58);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(121, 21);
            this.StudentsList.TabIndex = 4;
            this.StudentsList.SelectedIndexChanged += new System.EventHandler(this.StudentsList_SelectedIndexChanged);
            // 
            // txtInstructorHours
            // 
            this.txtInstructorHours.Location = new System.Drawing.Point(321, 185);
            this.txtInstructorHours.Name = "txtInstructorHours";
            this.txtInstructorHours.ReadOnly = true;
            this.txtInstructorHours.Size = new System.Drawing.Size(121, 20);
            this.txtInstructorHours.TabIndex = 59;
            // 
            // txtInstructorName
            // 
            this.txtInstructorName.Location = new System.Drawing.Point(321, 146);
            this.txtInstructorName.Name = "txtInstructorName";
            this.txtInstructorName.ReadOnly = true;
            this.txtInstructorName.Size = new System.Drawing.Size(121, 20);
            this.txtInstructorName.TabIndex = 58;
            // 
            // txtInstructorID
            // 
            this.txtInstructorID.Location = new System.Drawing.Point(321, 107);
            this.txtInstructorID.Name = "txtInstructorID";
            this.txtInstructorID.ReadOnly = true;
            this.txtInstructorID.Size = new System.Drawing.Size(121, 20);
            this.txtInstructorID.TabIndex = 57;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(318, 169);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 13);
            this.label13.TabIndex = 56;
            this.label13.Text = "Average hours:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(318, 130);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 55;
            this.label14.Text = "Name:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(318, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Instructor ID:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 208);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = "Average hours:";
            // 
            // txtSectionHours
            // 
            this.txtSectionHours.Location = new System.Drawing.Point(170, 224);
            this.txtSectionHours.Name = "txtSectionHours";
            this.txtSectionHours.ReadOnly = true;
            this.txtSectionHours.Size = new System.Drawing.Size(121, 20);
            this.txtSectionHours.TabIndex = 52;
            // 
            // txtSectionCapacity
            // 
            this.txtSectionCapacity.Location = new System.Drawing.Point(170, 185);
            this.txtSectionCapacity.Name = "txtSectionCapacity";
            this.txtSectionCapacity.ReadOnly = true;
            this.txtSectionCapacity.Size = new System.Drawing.Size(121, 20);
            this.txtSectionCapacity.TabIndex = 51;
            // 
            // txtSectionInstructorID
            // 
            this.txtSectionInstructorID.Location = new System.Drawing.Point(170, 146);
            this.txtSectionInstructorID.Name = "txtSectionInstructorID";
            this.txtSectionInstructorID.ReadOnly = true;
            this.txtSectionInstructorID.Size = new System.Drawing.Size(121, 20);
            this.txtSectionInstructorID.TabIndex = 50;
            // 
            // txtSectionID
            // 
            this.txtSectionID.Location = new System.Drawing.Point(170, 107);
            this.txtSectionID.Name = "txtSectionID";
            this.txtSectionID.ReadOnly = true;
            this.txtSectionID.Size = new System.Drawing.Size(121, 20);
            this.txtSectionID.TabIndex = 49;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(167, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Capacity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(167, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Instructor ID:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(167, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 46;
            this.label8.Text = "Section ID:";
            // 
            // txtLocationHours
            // 
            this.txtLocationHours.Location = new System.Drawing.Point(19, 185);
            this.txtLocationHours.Name = "txtLocationHours";
            this.txtLocationHours.ReadOnly = true;
            this.txtLocationHours.Size = new System.Drawing.Size(121, 20);
            this.txtLocationHours.TabIndex = 45;
            // 
            // txtLocationName
            // 
            this.txtLocationName.Location = new System.Drawing.Point(19, 146);
            this.txtLocationName.Name = "txtLocationName";
            this.txtLocationName.ReadOnly = true;
            this.txtLocationName.Size = new System.Drawing.Size(121, 20);
            this.txtLocationName.TabIndex = 44;
            // 
            // txtLocationID
            // 
            this.txtLocationID.Location = new System.Drawing.Point(19, 107);
            this.txtLocationID.Name = "txtLocationID";
            this.txtLocationID.ReadOnly = true;
            this.txtLocationID.Size = new System.Drawing.Size(121, 20);
            this.txtLocationID.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Average hours:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Location name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 40;
            this.label1.Text = "Location ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Average grade:";
            // 
            // txtCourseHours
            // 
            this.txtCourseHours.Location = new System.Drawing.Point(472, 224);
            this.txtCourseHours.Name = "txtCourseHours";
            this.txtCourseHours.ReadOnly = true;
            this.txtCourseHours.Size = new System.Drawing.Size(121, 20);
            this.txtCourseHours.TabIndex = 68;
            // 
            // txtCourseCredits
            // 
            this.txtCourseCredits.Location = new System.Drawing.Point(472, 185);
            this.txtCourseCredits.Name = "txtCourseCredits";
            this.txtCourseCredits.ReadOnly = true;
            this.txtCourseCredits.Size = new System.Drawing.Size(121, 20);
            this.txtCourseCredits.TabIndex = 67;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(472, 146);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.ReadOnly = true;
            this.txtCourseTitle.Size = new System.Drawing.Size(121, 20);
            this.txtCourseTitle.TabIndex = 66;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(472, 107);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.ReadOnly = true;
            this.txtCourseID.Size = new System.Drawing.Size(121, 20);
            this.txtCourseID.TabIndex = 65;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 64;
            this.label5.Text = "Course credits:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(469, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 63;
            this.label10.Text = "Course title:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(469, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 62;
            this.label11.Text = "Course ID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(620, 208);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(80, 13);
            this.label16.TabIndex = 77;
            this.label16.Text = "Average grade:";
            // 
            // txtStudentHours
            // 
            this.txtStudentHours.Location = new System.Drawing.Point(623, 224);
            this.txtStudentHours.Name = "txtStudentHours";
            this.txtStudentHours.ReadOnly = true;
            this.txtStudentHours.Size = new System.Drawing.Size(121, 20);
            this.txtStudentHours.TabIndex = 76;
            // 
            // txtEnrollmentDate
            // 
            this.txtEnrollmentDate.Location = new System.Drawing.Point(623, 185);
            this.txtEnrollmentDate.Name = "txtEnrollmentDate";
            this.txtEnrollmentDate.ReadOnly = true;
            this.txtEnrollmentDate.Size = new System.Drawing.Size(121, 20);
            this.txtEnrollmentDate.TabIndex = 75;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(623, 146);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(121, 20);
            this.txtStudentName.TabIndex = 74;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(623, 107);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(121, 20);
            this.txtStudentID.TabIndex = 73;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(620, 169);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(83, 13);
            this.label17.TabIndex = 72;
            this.label17.Text = "Enrollment date:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(620, 130);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 71;
            this.label18.Text = "Name:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(620, 91);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(61, 13);
            this.label19.TabIndex = 70;
            this.label19.Text = "Student ID:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(318, 18);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(66, 13);
            this.label12.TabIndex = 83;
            this.label12.Text = "By Instructor";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(318, 42);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(101, 13);
            this.label20.TabIndex = 82;
            this.label20.Text = "Select an instructor:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(168, 18);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(58, 13);
            this.label21.TabIndex = 81;
            this.label21.Text = "By Section";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(167, 42);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(86, 13);
            this.label22.TabIndex = 80;
            this.label22.Text = "Select a section:";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(16, 18);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(63, 13);
            this.label23.TabIndex = 79;
            this.label23.Text = "By Location";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(16, 42);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(89, 13);
            this.label24.TabIndex = 78;
            this.label24.Text = "Select a location:";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(469, 18);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 13);
            this.label25.TabIndex = 85;
            this.label25.Text = "By Course";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(469, 42);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(84, 13);
            this.label26.TabIndex = 84;
            this.label26.Text = "Select a course:";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(620, 18);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(59, 13);
            this.label27.TabIndex = 87;
            this.label27.Text = "By Student";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.Location = new System.Drawing.Point(620, 42);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(87, 13);
            this.label28.TabIndex = 86;
            this.label28.Text = "Select a student:";
            // 
            // TotalHours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 279);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtStudentHours);
            this.Controls.Add(this.txtEnrollmentDate);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCourseHours);
            this.Controls.Add(this.txtCourseCredits);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtInstructorHours);
            this.Controls.Add(this.txtInstructorName);
            this.Controls.Add(this.txtInstructorID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSectionHours);
            this.Controls.Add(this.txtSectionCapacity);
            this.Controls.Add(this.txtSectionInstructorID);
            this.Controls.Add(this.txtSectionID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtLocationHours);
            this.Controls.Add(this.txtLocationName);
            this.Controls.Add(this.txtLocationID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.CoursesList);
            this.Controls.Add(this.InstructorsList);
            this.Controls.Add(this.SectionsList);
            this.Controls.Add(this.LocationsList);
            this.Name = "TotalHours";
            this.Text = "TotalHours";
            this.Load += new System.EventHandler(this.TotalHours_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox LocationsList;
        private System.Windows.Forms.ComboBox SectionsList;
        private System.Windows.Forms.ComboBox InstructorsList;
        private System.Windows.Forms.ComboBox CoursesList;
        private System.Windows.Forms.ComboBox StudentsList;
        private System.Windows.Forms.TextBox txtInstructorHours;
        private System.Windows.Forms.TextBox txtInstructorName;
        private System.Windows.Forms.TextBox txtInstructorID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtSectionHours;
        private System.Windows.Forms.TextBox txtSectionCapacity;
        private System.Windows.Forms.TextBox txtSectionInstructorID;
        private System.Windows.Forms.TextBox txtSectionID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLocationHours;
        private System.Windows.Forms.TextBox txtLocationName;
        private System.Windows.Forms.TextBox txtLocationID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCourseHours;
        private System.Windows.Forms.TextBox txtCourseCredits;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtStudentHours;
        private System.Windows.Forms.TextBox txtEnrollmentDate;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
    }
}