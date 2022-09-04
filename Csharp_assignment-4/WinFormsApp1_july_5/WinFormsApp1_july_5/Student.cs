using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace WinFormsApp1_july_5
{
    internal class Student
    { 
        static List<Student> students = new List<Student>();

        public static List<Student> getAllStudents()
        {
            string connectionString = @"Data Source=.; Initial Catalog=student; Integrated Security=true";
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string select = "select * from studentTable";
            //ExecuteReader er = new ExecuteReader(insert);
            SqlCommand cmd = new SqlCommand( select , conn);
            SqlDataReader sqlDataReader = cmd.ExecuteReader();


            List<Student> temp = new List<Student>();

            while (sqlDataReader.Read())
            {
               // Student s = new Student();
              //  s.Fname = sqlDataReader["fname"];
              // s.Lname = sqlDataReader["fname"];
              //  s.email = sqlDataReader["fname"];
              //  s.id = sqlDataReader["id"];
              //  s.phone = sqlDataReader["phone"];
               // temp.Add(s);
            }
            return temp;

            return students;
        }
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String email { get; set; }
        public String id { get; set; }
        public String phone { get; set; }

        public void save()
        {
            Console.WriteLine("The student is sucessfully registered");
            students.Add(this);

            string connectionString = @"Data Source=.; Initial Catalog=student; Integreted Security = true";

            try
            {
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception e)
            {
                MessageBox.Show("Unable to Connect");
            }


            string query = "insert into studentTable values ( '+ this.fname + ',' + this.Fname + ',' + this.Lname + ',' + this.email + ',' + this.id + ',' + this.phone ') ";
            
            //ExecuteNonQuery enq = new ExecuteNonQuery(query);

        }

        public static Student SearchByName(string name)
        {
            //Product p = new Product();
            return students.Find(p => p.Fname == name);
        }
    }
}
