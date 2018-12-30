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
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnDeleteOne = new System.Windows.Forms.Button();
            this.btnEditOne = new System.Windows.Forms.Button();
            this.btnAddOne = new System.Windows.Forms.Button();
            this.txtField = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgOne)).BeginInit();
            this.SuspendLayout();
            // 
            // dgOne
            // 
            this.dgOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgOne.Location = new System.Drawing.Point(12, 35);
            this.dgOne.Name = "dgOne";
            this.dgOne.Size = new System.Drawing.Size(776, 193);
            this.dgOne.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(13, 13);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(49, 13);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Students";
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
            // txtField
            // 
            this.txtField.Location = new System.Drawing.Point(447, 6);
            this.txtField.Name = "txtField";
            this.txtField.Size = new System.Drawing.Size(101, 20);
            this.txtField.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Field";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(553, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Value";
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(592, 7);
            this.txtValue.Name = "txtValue";
            this.txtValue.Size = new System.Drawing.Size(101, 20);
            this.txtValue.TabIndex = 12;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(704, 5);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(75, 23);
            this.btnFilter.TabIndex = 14;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // GridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 277);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtField);
            this.Controls.Add(this.btnDeleteOne);
            this.Controls.Add(this.btnEditOne);
            this.Controls.Add(this.btnAddOne);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dgOne);
            this.Name = "GridView";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.GridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgOne;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnDeleteOne;
        private System.Windows.Forms.Button btnEditOne;
        private System.Windows.Forms.Button btnAddOne;
        private System.Windows.Forms.TextBox txtField;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Button btnFilter;
    }
}