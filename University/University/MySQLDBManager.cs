using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace University
{
    public class MySQLDBManager : IDBManager
    {
        private string connString;

        public MySQLDBManager()
        {
            connString = "datasource=127.0.0.1;port=3306;username=root;password=;database=university;";
        }

        public IList<Student> RetrieveStudents()
        {
            IList<Student> studentList = new List<Student>();

            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                string statement = "SELECT * FROM student";

                MySqlCommand cmd = new MySqlCommand(statement, conn);
                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        Student student = new Student();
                        student.id = reader.GetInt32("idStudent");
                        student.name = reader.GetString("Name");
                        student.birthdate = reader.GetDateTime("BirthDate");
                        student.address = reader.GetString("Address");
                        studentList.Add(student);
                    }
                }
            }

            return studentList;
        }

        public void AddStudent(Student student)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "INSERT INTO student(idStudent, name, birthdate, address) VALUES(@ID, @name, @birthdate, @address)";
                cmd.Prepare();

                cmd.Parameters.AddWithValue("@ID", student.id);
                cmd.Parameters.AddWithValue("@name", student.name);
                cmd.Parameters.AddWithValue("@birthdate", student.birthdate);
                cmd.Parameters.AddWithValue("@address", student.address);
                cmd.ExecuteNonQuery();
            }
        }

        public void UpdateStudent(Student student)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
               // cmd.CommandType = CommandType.StoredProcedure;

                cmd.CommandText = "UPDATE student SET name=@name, birthdate=@birthdate, address= @address WHERE idStudent=@ID";
                cmd.Prepare();

                cmd.Parameters.Add(new MySqlParameter("@ID", student.id));
                cmd.Parameters.Add(new MySqlParameter("@name", student.name));
                cmd.Parameters.Add(new MySqlParameter("@birthdate", student.birthdate));
                cmd.Parameters.Add(new MySqlParameter("@address", student.address));

                cmd.ExecuteNonQuery();
            }
        }

        public void DeleteStudent(Student student)
        {
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE from student where idStudent=@ID;";
                cmd.Parameters.AddWithValue("@ID", student.id);
                cmd.Prepare();

                cmd.ExecuteNonQuery();
            }
        }

    }
}
