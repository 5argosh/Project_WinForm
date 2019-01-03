namespace Project_WinForm
{
    partial class AverageGrade
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
            this.SectionsList = new System.Windows.Forms.ComboBox();
            this.CoursesList = new System.Windows.Forms.ComboBox();
            this.StudentsList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSectionID = new System.Windows.Forms.TextBox();
            this.txtSectionCapacity = new System.Windows.Forms.TextBox();
            this.txtSectionGrade = new System.Windows.Forms.TextBox();
            this.txtEnrollmentDate = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtStudentGrade = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCourseGrade = new System.Windows.Forms.TextBox();
            this.txtCourseCredits = new System.Windows.Forms.TextBox();
            this.txtCourseTitle = new System.Windows.Forms.TextBox();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SectionsList
            // 
            this.SectionsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SectionsList.FormattingEnabled = true;
            this.SectionsList.Location = new System.Drawing.Point(26, 60);
            this.SectionsList.Name = "SectionsList";
            this.SectionsList.Size = new System.Drawing.Size(121, 21);
            this.SectionsList.TabIndex = 3;
            this.SectionsList.SelectedIndexChanged += new System.EventHandler(this.SectionsList_SelectedIndexChanged);
            // 
            // CoursesList
            // 
            this.CoursesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CoursesList.FormattingEnabled = true;
            this.CoursesList.Location = new System.Drawing.Point(341, 60);
            this.CoursesList.Name = "CoursesList";
            this.CoursesList.Size = new System.Drawing.Size(121, 21);
            this.CoursesList.TabIndex = 4;
            this.CoursesList.SelectedIndexChanged += new System.EventHandler(this.CoursesList_SelectedIndexChanged);
            // 
            // StudentsList
            // 
            this.StudentsList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StudentsList.FormattingEnabled = true;
            this.StudentsList.Location = new System.Drawing.Point(183, 60);
            this.StudentsList.Name = "StudentsList";
            this.StudentsList.Size = new System.Drawing.Size(121, 21);
            this.StudentsList.TabIndex = 5;
            this.StudentsList.SelectedIndexChanged += new System.EventHandler(this.StudentsList_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Section ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Capacity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Average grade:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Select a section:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(23, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "By Section";
            // 
            // txtSectionID
            // 
            this.txtSectionID.Location = new System.Drawing.Point(26, 106);
            this.txtSectionID.Name = "txtSectionID";
            this.txtSectionID.ReadOnly = true;
            this.txtSectionID.Size = new System.Drawing.Size(121, 20);
            this.txtSectionID.TabIndex = 19;
            // 
            // txtSectionCapacity
            // 
            this.txtSectionCapacity.Location = new System.Drawing.Point(26, 145);
            this.txtSectionCapacity.Name = "txtSectionCapacity";
            this.txtSectionCapacity.ReadOnly = true;
            this.txtSectionCapacity.Size = new System.Drawing.Size(121, 20);
            this.txtSectionCapacity.TabIndex = 20;
            // 
            // txtSectionGrade
            // 
            this.txtSectionGrade.Location = new System.Drawing.Point(26, 184);
            this.txtSectionGrade.Name = "txtSectionGrade";
            this.txtSectionGrade.ReadOnly = true;
            this.txtSectionGrade.Size = new System.Drawing.Size(121, 20);
            this.txtSectionGrade.TabIndex = 21;
            // 
            // txtEnrollmentDate
            // 
            this.txtEnrollmentDate.Location = new System.Drawing.Point(183, 184);
            this.txtEnrollmentDate.Name = "txtEnrollmentDate";
            this.txtEnrollmentDate.ReadOnly = true;
            this.txtEnrollmentDate.Size = new System.Drawing.Size(121, 20);
            this.txtEnrollmentDate.TabIndex = 27;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(183, 145);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(121, 20);
            this.txtStudentName.TabIndex = 26;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(183, 106);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.ReadOnly = true;
            this.txtStudentID.Size = new System.Drawing.Size(121, 20);
            this.txtStudentID.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(180, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Enrollment date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(180, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(180, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Student ID:";
            // 
            // txtStudentGrade
            // 
            this.txtStudentGrade.Location = new System.Drawing.Point(183, 223);
            this.txtStudentGrade.Name = "txtStudentGrade";
            this.txtStudentGrade.ReadOnly = true;
            this.txtStudentGrade.Size = new System.Drawing.Size(121, 20);
            this.txtStudentGrade.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(180, 207);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Average grade:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(180, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Select a student:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(180, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 31;
            this.label11.Text = "By Student";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(338, 207);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(80, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Average grade:";
            // 
            // txtCourseGrade
            // 
            this.txtCourseGrade.Location = new System.Drawing.Point(341, 223);
            this.txtCourseGrade.Name = "txtCourseGrade";
            this.txtCourseGrade.ReadOnly = true;
            this.txtCourseGrade.Size = new System.Drawing.Size(121, 20);
            this.txtCourseGrade.TabIndex = 38;
            // 
            // txtCourseCredits
            // 
            this.txtCourseCredits.Location = new System.Drawing.Point(341, 184);
            this.txtCourseCredits.Name = "txtCourseCredits";
            this.txtCourseCredits.ReadOnly = true;
            this.txtCourseCredits.Size = new System.Drawing.Size(121, 20);
            this.txtCourseCredits.TabIndex = 37;
            // 
            // txtCourseTitle
            // 
            this.txtCourseTitle.Location = new System.Drawing.Point(341, 145);
            this.txtCourseTitle.Name = "txtCourseTitle";
            this.txtCourseTitle.ReadOnly = true;
            this.txtCourseTitle.Size = new System.Drawing.Size(121, 20);
            this.txtCourseTitle.TabIndex = 36;
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(341, 106);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.ReadOnly = true;
            this.txtCourseID.Size = new System.Drawing.Size(121, 20);
            this.txtCourseID.TabIndex = 35;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(338, 168);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 34;
            this.label13.Text = "Course credits:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(338, 129);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(62, 13);
            this.label14.TabIndex = 33;
            this.label14.Text = "Course title:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(338, 90);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(57, 13);
            this.label15.TabIndex = 32;
            this.label15.Text = "Course ID:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(338, 16);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(55, 13);
            this.label16.TabIndex = 41;
            this.label16.Text = "By Course";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(338, 42);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 40;
            this.label17.Text = "Select a course:";
            // 
            // AverageGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 279);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtCourseGrade);
            this.Controls.Add(this.txtCourseCredits);
            this.Controls.Add(this.txtCourseTitle);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtStudentGrade);
            this.Controls.Add(this.txtEnrollmentDate);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSectionGrade);
            this.Controls.Add(this.txtSectionCapacity);
            this.Controls.Add(this.txtSectionID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentsList);
            this.Controls.Add(this.CoursesList);
            this.Controls.Add(this.SectionsList);
            this.Name = "AverageGrade";
            this.Text = "AverageGrade";
            this.Load += new System.EventHandler(this.AverageGrade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox SectionsList;
        private System.Windows.Forms.ComboBox CoursesList;
        private System.Windows.Forms.ComboBox StudentsList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSectionID;
        private System.Windows.Forms.TextBox txtSectionCapacity;
        private System.Windows.Forms.TextBox txtSectionGrade;
        private System.Windows.Forms.TextBox txtEnrollmentDate;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtStudentGrade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCourseGrade;
        private System.Windows.Forms.TextBox txtCourseCredits;
        private System.Windows.Forms.TextBox txtCourseTitle;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
    }
}