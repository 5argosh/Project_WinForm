namespace Project_WinForm
{
    partial class GridView
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
            this.dgOne = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.dgTwo = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddTwo = new System.Windows.Forms.Button();
            this.btnEditTwo = new System.Windows.Forms.Button();
            this.btnDeleteTwo = new System.Windows.Forms.Button();
            this.btnDeleteOne = new System.Windows.Forms.Button();
            this.btnEditOne = new System.Windows.Forms.Button();
            this.btnAddOne = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOne
            // 
            this.dgOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOne.Location = new System.Drawing.Point(12, 29);
            this.dgOne.Name = "dgOne";
            this.dgOne.Size = new System.Drawing.Size(776, 193);
            this.dgOne.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students";
            // 
            // dgTwo
            // 
            this.dgTwo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgTwo.Location = new System.Drawing.Point(12, 300);
            this.dgTwo.Name = "dgTwo";
            this.dgTwo.Size = new System.Drawing.Size(776, 173);
            this.dgTwo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Student Courses";
            // 
            // btnAddTwo
            // 
            this.btnAddTwo.Location = new System.Drawing.Point(545, 491);
            this.btnAddTwo.Name = "btnAddTwo";
            this.btnAddTwo.Size = new System.Drawing.Size(75, 23);
            this.btnAddTwo.TabIndex = 4;
            this.btnAddTwo.Text = "Add";
            this.btnAddTwo.UseVisualStyleBackColor = true;
            // 
            // btnEditTwo
            // 
            this.btnEditTwo.Location = new System.Drawing.Point(626, 491);
            this.btnEditTwo.Name = "btnEditTwo";
            this.btnEditTwo.Size = new System.Drawing.Size(75, 23);
            this.btnEditTwo.TabIndex = 5;
            this.btnEditTwo.Text = "Edit";
            this.btnEditTwo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTwo
            // 
            this.btnDeleteTwo.Location = new System.Drawing.Point(713, 491);
            this.btnDeleteTwo.Name = "btnDeleteTwo";
            this.btnDeleteTwo.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTwo.TabIndex = 6;
            this.btnDeleteTwo.Text = "Delete";
            this.btnDeleteTwo.UseVisualStyleBackColor = true;
            // 
            // btnDeleteOne
            // 
            this.btnDeleteOne.Location = new System.Drawing.Point(707, 239);
            this.btnDeleteOne.Name = "btnDeleteOne";
            this.btnDeleteOne.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteOne.TabIndex = 9;
            this.btnDeleteOne.Text = "Delete";
            this.btnDeleteOne.UseVisualStyleBackColor = true;
            // 
            // btnEditOne
            // 
            this.btnEditOne.Location = new System.Drawing.Point(626, 239);
            this.btnEditOne.Name = "btnEditOne";
            this.btnEditOne.Size = new System.Drawing.Size(75, 23);
            this.btnEditOne.TabIndex = 8;
            this.btnEditOne.Text = "Edit";
            this.btnEditOne.UseVisualStyleBackColor = true;
            // 
            // btnAddOne
            // 
            this.btnAddOne.Location = new System.Drawing.Point(545, 239);
            this.btnAddOne.Name = "btnAddOne";
            this.btnAddOne.Size = new System.Drawing.Size(75, 23);
            this.btnAddOne.TabIndex = 7;
            this.btnAddOne.Text = "Add";
            this.btnAddOne.UseVisualStyleBackColor = true;
            this.btnAddOne.Click += new System.EventHandler(this.btnAddOne_Click);
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 524);
            this.Controls.Add(this.btnDeleteOne);
            this.Controls.Add(this.btnEditOne);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.btnDeleteTwo);
            this.Controls.Add(this.btnEditTwo);
            this.Controls.Add(this.btnAddTwo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgTwo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgOne);
            this.Name = "GridView";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgTwo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAddTwo;
        private System.Windows.Forms.Button btnEditTwo;
        private System.Windows.Forms.Button btnDeleteTwo;
        private System.Windows.Forms.Button btnDeleteOne;
        private System.Windows.Forms.Button btnEditOne;
        private System.Windows.Forms.Button btnAddOne;
    }
}