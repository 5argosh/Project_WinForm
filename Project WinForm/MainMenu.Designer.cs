﻿namespace Project_WinForm
{
    partial class MainMenu
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
            this.btnStudents = new System.Windows.Forms.Button();
            this.btnInstructors = new System.Windows.Forms.Button();
            this.btnCourses = new System.Windows.Forms.Button();
            this.btnSchedules = new System.Windows.Forms.Button();
            this.btnLocations = new System.Windows.Forms.Button();
            this.btnToughtCourses = new System.Windows.Forms.Button();
            this.btnAvgGrade = new System.Windows.Forms.Button();
            this.btnTotalHours = new System.Windows.Forms.Button();
            this.btnSections = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStudents
            // 
            this.btnStudents.Location = new System.Drawing.Point(52, 83);
            this.btnStudents.Name = "btnStudents";
            this.btnStudents.Size = new System.Drawing.Size(114, 46);
            this.btnStudents.TabIndex = 0;
            this.btnStudents.Text = "Students";
            this.btnStudents.UseVisualStyleBackColor = true;
            this.btnStudents.Click += new System.EventHandler(this.btnStudents_Click);
            // 
            // btnInstructors
            // 
            this.btnInstructors.Location = new System.Drawing.Point(52, 31);
            this.btnInstructors.Name = "btnInstructors";
            this.btnInstructors.Size = new System.Drawing.Size(114, 46);
            this.btnInstructors.TabIndex = 1;
            this.btnInstructors.Text = "Instructors";
            this.btnInstructors.UseVisualStyleBackColor = true;
            this.btnInstructors.Click += new System.EventHandler(this.btnInstructors_Click);
            // 
            // btnCourses
            // 
            this.btnCourses.Location = new System.Drawing.Point(52, 135);
            this.btnCourses.Name = "btnCourses";
            this.btnCourses.Size = new System.Drawing.Size(114, 46);
            this.btnCourses.TabIndex = 2;
            this.btnCourses.Text = "Courses";
            this.btnCourses.UseVisualStyleBackColor = true;
            this.btnCourses.Click += new System.EventHandler(this.btnCourses_Click);
            // 
            // btnSchedules
            // 
            this.btnSchedules.Location = new System.Drawing.Point(52, 187);
            this.btnSchedules.Name = "btnSchedules";
            this.btnSchedules.Size = new System.Drawing.Size(114, 46);
            this.btnSchedules.TabIndex = 3;
            this.btnSchedules.Text = "Schedules";
            this.btnSchedules.UseVisualStyleBackColor = true;
            this.btnSchedules.Click += new System.EventHandler(this.btnSchedules_Click);
            // 
            // btnLocations
            // 
            this.btnLocations.Location = new System.Drawing.Point(52, 239);
            this.btnLocations.Name = "btnLocations";
            this.btnLocations.Size = new System.Drawing.Size(114, 46);
            this.btnLocations.TabIndex = 4;
            this.btnLocations.Text = "Locations";
            this.btnLocations.UseVisualStyleBackColor = true;
            this.btnLocations.Click += new System.EventHandler(this.btnLocations_Click);
            // 
            // btnToughtCourses
            // 
            this.btnToughtCourses.Location = new System.Drawing.Point(52, 291);
            this.btnToughtCourses.Name = "btnToughtCourses";
            this.btnToughtCourses.Size = new System.Drawing.Size(114, 46);
            this.btnToughtCourses.TabIndex = 5;
            this.btnToughtCourses.Text = "Taught Courses";
            this.btnToughtCourses.UseVisualStyleBackColor = true;
            this.btnToughtCourses.Click += new System.EventHandler(this.btnToughtCourses_Click);
            // 
            // btnAvgGrade
            // 
            this.btnAvgGrade.Location = new System.Drawing.Point(52, 395);
            this.btnAvgGrade.Name = "btnAvgGrade";
            this.btnAvgGrade.Size = new System.Drawing.Size(114, 46);
            this.btnAvgGrade.TabIndex = 6;
            this.btnAvgGrade.Text = "Average Grade Report";
            this.btnAvgGrade.UseVisualStyleBackColor = true;
            this.btnAvgGrade.Click += new System.EventHandler(this.btnAvgGrade_Click);
            // 
            // btnTotalHours
            // 
            this.btnTotalHours.Location = new System.Drawing.Point(52, 447);
            this.btnTotalHours.Name = "btnTotalHours";
            this.btnTotalHours.Size = new System.Drawing.Size(114, 46);
            this.btnTotalHours.TabIndex = 7;
            this.btnTotalHours.Text = "Total Scheduled Hours Report";
            this.btnTotalHours.UseVisualStyleBackColor = true;
            this.btnTotalHours.Click += new System.EventHandler(this.btnTotalHours_Click);
            // 
            // btnSections
            // 
            this.btnSections.Location = new System.Drawing.Point(52, 343);
            this.btnSections.Name = "btnSections";
            this.btnSections.Size = new System.Drawing.Size(114, 46);
            this.btnSections.TabIndex = 8;
            this.btnSections.Text = "Sections";
            this.btnSections.UseVisualStyleBackColor = true;
            this.btnSections.Click += new System.EventHandler(this.btnSections_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 532);
            this.Controls.Add(this.btnSections);
            this.Controls.Add(this.btnTotalHours);
            this.Controls.Add(this.btnAvgGrade);
            this.Controls.Add(this.btnToughtCourses);
            this.Controls.Add(this.btnLocations);
            this.Controls.Add(this.btnSchedules);
            this.Controls.Add(this.btnCourses);
            this.Controls.Add(this.btnInstructors);
            this.Controls.Add(this.btnStudents);
            this.Name = "MainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStudents;
        private System.Windows.Forms.Button btnInstructors;
        private System.Windows.Forms.Button btnCourses;
        private System.Windows.Forms.Button btnSchedules;
        private System.Windows.Forms.Button btnLocations;
        private System.Windows.Forms.Button btnToughtCourses;
        private System.Windows.Forms.Button btnAvgGrade;
        private System.Windows.Forms.Button btnTotalHours;
        private System.Windows.Forms.Button btnSections;
    }
}

