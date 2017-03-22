namespace University
{
    partial class Form1
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
            this.lblStudentID = new System.Windows.Forms.Label();
            this.lblStundetName = new System.Windows.Forms.Label();
            this.lblStudentBirthdate = new System.Windows.Forms.Label();
            this.lblStudentAddress = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.dateStudentBirthdate = new System.Windows.Forms.DateTimePicker();
            this.txtStudentAddress = new System.Windows.Forms.TextBox();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.btnUpdateStudent = new System.Windows.Forms.Button();
            this.btnDeleteStudent = new System.Windows.Forms.Button();
            this.lblCourseID = new System.Windows.Forms.Label();
            this.lblCourseName = new System.Windows.Forms.Label();
            this.lblCourseTeacher = new System.Windows.Forms.Label();
            this.lblCourseStudyYear = new System.Windows.Forms.Label();
            this.txtCourseID = new System.Windows.Forms.TextBox();
            this.txtCourseName = new System.Windows.Forms.TextBox();
            this.txtCourseTeacher = new System.Windows.Forms.TextBox();
            this.txtCourseStudyYear = new System.Windows.Forms.TextBox();
            this.btnAddCourse = new System.Windows.Forms.Button();
            this.btnUpdaeCourse = new System.Windows.Forms.Button();
            this.btnDeleteCourse = new System.Windows.Forms.Button();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gridCourses = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRetrieve = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(23, 17);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(58, 13);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID";
            // 
            // lblStundetName
            // 
            this.lblStundetName.AutoSize = true;
            this.lblStundetName.Location = new System.Drawing.Point(23, 49);
            this.lblStundetName.Name = "lblStundetName";
            this.lblStundetName.Size = new System.Drawing.Size(75, 13);
            this.lblStundetName.TabIndex = 1;
            this.lblStundetName.Text = "Student Name";
            // 
            // lblStudentBirthdate
            // 
            this.lblStudentBirthdate.AutoSize = true;
            this.lblStudentBirthdate.Location = new System.Drawing.Point(23, 80);
            this.lblStudentBirthdate.Name = "lblStudentBirthdate";
            this.lblStudentBirthdate.Size = new System.Drawing.Size(89, 13);
            this.lblStudentBirthdate.TabIndex = 2;
            this.lblStudentBirthdate.Text = "Student Birthdate";
            // 
            // lblStudentAddress
            // 
            this.lblStudentAddress.AutoSize = true;
            this.lblStudentAddress.Location = new System.Drawing.Point(23, 108);
            this.lblStudentAddress.Name = "lblStudentAddress";
            this.lblStudentAddress.Size = new System.Drawing.Size(85, 13);
            this.lblStudentAddress.TabIndex = 3;
            this.lblStudentAddress.Text = "Student Address";
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(149, 17);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(136, 20);
            this.txtStudentID.TabIndex = 4;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(149, 46);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.Size = new System.Drawing.Size(136, 20);
            this.txtStudentName.TabIndex = 5;
            // 
            // dateStudentBirthdate
            // 
            this.dateStudentBirthdate.Location = new System.Drawing.Point(151, 75);
            this.dateStudentBirthdate.Name = "dateStudentBirthdate";
            this.dateStudentBirthdate.Size = new System.Drawing.Size(134, 20);
            this.dateStudentBirthdate.TabIndex = 7;
            // 
            // txtStudentAddress
            // 
            this.txtStudentAddress.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.txtStudentAddress.Location = new System.Drawing.Point(149, 108);
            this.txtStudentAddress.Multiline = true;
            this.txtStudentAddress.Name = "txtStudentAddress";
            this.txtStudentAddress.Size = new System.Drawing.Size(222, 49);
            this.txtStudentAddress.TabIndex = 13;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Location = new System.Drawing.Point(12, 178);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(86, 22);
            this.btnAddStudent.TabIndex = 14;
            this.btnAddStudent.Text = "Add Student";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // btnUpdateStudent
            // 
            this.btnUpdateStudent.Location = new System.Drawing.Point(104, 178);
            this.btnUpdateStudent.Name = "btnUpdateStudent";
            this.btnUpdateStudent.Size = new System.Drawing.Size(95, 22);
            this.btnUpdateStudent.TabIndex = 15;
            this.btnUpdateStudent.Text = "Update Student";
            this.btnUpdateStudent.UseVisualStyleBackColor = true;
            this.btnUpdateStudent.Click += new System.EventHandler(this.btnUpdateStudent_Click);
            // 
            // btnDeleteStudent
            // 
            this.btnDeleteStudent.Location = new System.Drawing.Point(210, 178);
            this.btnDeleteStudent.Name = "btnDeleteStudent";
            this.btnDeleteStudent.Size = new System.Drawing.Size(90, 22);
            this.btnDeleteStudent.TabIndex = 16;
            this.btnDeleteStudent.Text = "Delete Student";
            this.btnDeleteStudent.UseVisualStyleBackColor = true;
            this.btnDeleteStudent.Click += new System.EventHandler(this.btnDeleteStudent_Click);
            // 
            // lblCourseID
            // 
            this.lblCourseID.AutoSize = true;
            this.lblCourseID.Location = new System.Drawing.Point(459, 18);
            this.lblCourseID.Name = "lblCourseID";
            this.lblCourseID.Size = new System.Drawing.Size(54, 13);
            this.lblCourseID.TabIndex = 17;
            this.lblCourseID.Text = "Course ID";
            // 
            // lblCourseName
            // 
            this.lblCourseName.AutoSize = true;
            this.lblCourseName.Location = new System.Drawing.Point(459, 46);
            this.lblCourseName.Name = "lblCourseName";
            this.lblCourseName.Size = new System.Drawing.Size(71, 13);
            this.lblCourseName.TabIndex = 18;
            this.lblCourseName.Text = "Course Name";
            // 
            // lblCourseTeacher
            // 
            this.lblCourseTeacher.AutoSize = true;
            this.lblCourseTeacher.Location = new System.Drawing.Point(459, 75);
            this.lblCourseTeacher.Name = "lblCourseTeacher";
            this.lblCourseTeacher.Size = new System.Drawing.Size(83, 13);
            this.lblCourseTeacher.TabIndex = 19;
            this.lblCourseTeacher.Text = "Course Teacher";
            // 
            // lblCourseStudyYear
            // 
            this.lblCourseStudyYear.AutoSize = true;
            this.lblCourseStudyYear.Location = new System.Drawing.Point(459, 99);
            this.lblCourseStudyYear.Name = "lblCourseStudyYear";
            this.lblCourseStudyYear.Size = new System.Drawing.Size(95, 13);
            this.lblCourseStudyYear.TabIndex = 20;
            this.lblCourseStudyYear.Text = "Course Study Year";
            // 
            // txtCourseID
            // 
            this.txtCourseID.Location = new System.Drawing.Point(569, 14);
            this.txtCourseID.Name = "txtCourseID";
            this.txtCourseID.Size = new System.Drawing.Size(133, 20);
            this.txtCourseID.TabIndex = 21;
            // 
            // txtCourseName
            // 
            this.txtCourseName.Location = new System.Drawing.Point(569, 42);
            this.txtCourseName.Name = "txtCourseName";
            this.txtCourseName.Size = new System.Drawing.Size(133, 20);
            this.txtCourseName.TabIndex = 22;
            // 
            // txtCourseTeacher
            // 
            this.txtCourseTeacher.Location = new System.Drawing.Point(569, 72);
            this.txtCourseTeacher.Name = "txtCourseTeacher";
            this.txtCourseTeacher.Size = new System.Drawing.Size(133, 20);
            this.txtCourseTeacher.TabIndex = 23;
            // 
            // txtCourseStudyYear
            // 
            this.txtCourseStudyYear.Location = new System.Drawing.Point(569, 96);
            this.txtCourseStudyYear.Name = "txtCourseStudyYear";
            this.txtCourseStudyYear.Size = new System.Drawing.Size(133, 20);
            this.txtCourseStudyYear.TabIndex = 24;
            // 
            // btnAddCourse
            // 
            this.btnAddCourse.Location = new System.Drawing.Point(462, 178);
            this.btnAddCourse.Name = "btnAddCourse";
            this.btnAddCourse.Size = new System.Drawing.Size(97, 21);
            this.btnAddCourse.TabIndex = 26;
            this.btnAddCourse.Text = "Add Course";
            this.btnAddCourse.UseVisualStyleBackColor = true;
            // 
            // btnUpdaeCourse
            // 
            this.btnUpdaeCourse.Location = new System.Drawing.Point(569, 179);
            this.btnUpdaeCourse.Name = "btnUpdaeCourse";
            this.btnUpdaeCourse.Size = new System.Drawing.Size(93, 20);
            this.btnUpdaeCourse.TabIndex = 27;
            this.btnUpdaeCourse.Text = "Update Course";
            this.btnUpdaeCourse.UseVisualStyleBackColor = true;
            // 
            // btnDeleteCourse
            // 
            this.btnDeleteCourse.Location = new System.Drawing.Point(672, 179);
            this.btnDeleteCourse.Name = "btnDeleteCourse";
            this.btnDeleteCourse.Size = new System.Drawing.Size(89, 20);
            this.btnDeleteCourse.TabIndex = 28;
            this.btnDeleteCourse.Text = "Delete Course";
            this.btnDeleteCourse.UseVisualStyleBackColor = true;
            // 
            // gridStudents
            // 
            this.gridStudents.AllowUserToAddRows = false;
            this.gridStudents.AllowUserToDeleteRows = false;
            this.gridStudents.AllowUserToResizeColumns = false;
            this.gridStudents.AllowUserToResizeRows = false;
            this.gridStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.gridStudents.Location = new System.Drawing.Point(26, 206);
            this.gridStudents.MultiSelect = false;
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.RowHeadersVisible = false;
            this.gridStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridStudents.Size = new System.Drawing.Size(345, 202);
            this.gridStudents.TabIndex = 4;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Birthdate";
            this.Column3.HeaderText = "Birth date";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Address";
            this.Column4.HeaderText = "Address";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // gridCourses
            // 
            this.gridCourses.AllowUserToAddRows = false;
            this.gridCourses.AllowUserToDeleteRows = false;
            this.gridCourses.AllowUserToResizeColumns = false;
            this.gridCourses.AllowUserToResizeRows = false;
            this.gridCourses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCourses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCourses.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.gridCourses.Location = new System.Drawing.Point(449, 206);
            this.gridCourses.MultiSelect = false;
            this.gridCourses.Name = "gridCourses";
            this.gridCourses.RowHeadersVisible = false;
            this.gridCourses.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCourses.Size = new System.Drawing.Size(333, 202);
            this.gridCourses.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "idCourse";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Teacher";
            this.dataGridViewTextBoxColumn3.HeaderText = "Teacher";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Study Year";
            this.dataGridViewTextBoxColumn4.HeaderText = "Study Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // btnRetrieve
            // 
            this.btnRetrieve.Location = new System.Drawing.Point(317, 178);
            this.btnRetrieve.Name = "btnRetrieve";
            this.btnRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btnRetrieve.TabIndex = 34;
            this.btnRetrieve.Text = "Retrieve";
            this.btnRetrieve.UseVisualStyleBackColor = true;
            this.btnRetrieve.Click += new System.EventHandler(this.btnRetrieve_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 436);
            this.Controls.Add(this.btnRetrieve);
            this.Controls.Add(this.gridCourses);
            this.Controls.Add(this.gridStudents);
            this.Controls.Add(this.btnDeleteCourse);
            this.Controls.Add(this.btnUpdaeCourse);
            this.Controls.Add(this.btnAddCourse);
            this.Controls.Add(this.txtCourseStudyYear);
            this.Controls.Add(this.txtCourseTeacher);
            this.Controls.Add(this.txtCourseName);
            this.Controls.Add(this.txtCourseID);
            this.Controls.Add(this.lblCourseStudyYear);
            this.Controls.Add(this.lblCourseTeacher);
            this.Controls.Add(this.lblCourseName);
            this.Controls.Add(this.lblCourseID);
            this.Controls.Add(this.btnDeleteStudent);
            this.Controls.Add(this.btnUpdateStudent);
            this.Controls.Add(this.btnAddStudent);
            this.Controls.Add(this.txtStudentAddress);
            this.Controls.Add(this.dateStudentBirthdate);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblStudentAddress);
            this.Controls.Add(this.lblStudentBirthdate);
            this.Controls.Add(this.lblStundetName);
            this.Controls.Add(this.lblStudentID);
            this.Name = "Form1";
            this.Text = "University";
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridCourses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudentID;
        private System.Windows.Forms.Label lblStundetName;
        private System.Windows.Forms.Label lblStudentBirthdate;
        private System.Windows.Forms.Label lblStudentAddress;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.DateTimePicker dateStudentBirthdate;
        private System.Windows.Forms.TextBox txtStudentAddress;
        private System.Windows.Forms.Button btnAddStudent;
        private System.Windows.Forms.Button btnUpdateStudent;
        private System.Windows.Forms.Button btnDeleteStudent;
        private System.Windows.Forms.Label lblCourseID;
        private System.Windows.Forms.Label lblCourseName;
        private System.Windows.Forms.Label lblCourseTeacher;
        private System.Windows.Forms.Label lblCourseStudyYear;
        private System.Windows.Forms.TextBox txtCourseID;
        private System.Windows.Forms.TextBox txtCourseName;
        private System.Windows.Forms.TextBox txtCourseTeacher;
        private System.Windows.Forms.TextBox txtCourseStudyYear;
        private System.Windows.Forms.Button btnAddCourse;
        private System.Windows.Forms.Button btnUpdaeCourse;
        private System.Windows.Forms.Button btnDeleteCourse;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.DataGridView gridCourses;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button btnRetrieve;
    }
}