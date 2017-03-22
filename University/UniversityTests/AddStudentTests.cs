using Microsoft.VisualStudio.TestTools.UnitTesting;
using University;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University.Tests
{
    [TestClass()]
    public class AddStudentTests
    {
        [TestMethod()]
        public void AddTest()
        {
            Student s = new Student();
            s.id = 15;
            s.name = "Marghescu Luminita";
            s.birthdate = new DateTime(1995,02,22,0,0,0);
            s.address = "Str. Observatorului";

            IList<Student> studentList1 = new List<Student>();
            IList<Student> studentList2 = new List<Student>();

            IDBManager db = new MySQLDBManager();

            studentList1 = db.RetrieveStudents();
            
            db.AddStudent(s);

            studentList2 = db.RetrieveStudents();

            Assert.AreNotEqual(studentList1, studentList2);
        }
    }
}