using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using University;
namespace University
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = RetrieveStudentInformation();

                IDBManager db = new MySQLDBManager();
                db.AddStudent(student);
                gridStudents.DataSource = db.RetrieveStudents();
                // EmptyControls();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private Student RetrieveStudentInformation()
        {
            Student student = new Student();
            student.id = Convert.ToInt32(txtStudentID.Text);
            student.name = txtStudentName.Text;
            student.birthdate = dateStudentBirthdate.Value;
            student.address = txtStudentAddress.Text;
            return student;
        }

        

        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = RetrieveStudentInformation();

                IDBManager db = new MySQLDBManager();
                db.UpdateStudent(student);
                gridStudents.DataSource = db.RetrieveStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                Student student = RetrieveStudentInformation();

                IDBManager db = new MySQLDBManager();
                db.DeleteStudent(student);
                gridStudents.DataSource = db.RetrieveStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            try
            {
                IDBManager db = new MySQLDBManager();

                gridStudents.DataSource = db.RetrieveStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
