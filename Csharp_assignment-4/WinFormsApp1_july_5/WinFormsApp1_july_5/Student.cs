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
            conn.open();
            string select = "select * from studentTable";
            ExecuteReader er = new ExecuteReader(select);

            List<Student> temp = new List<Student>();

            while (er.Read())
            {
                Student s = new Student();
                s.Fname = er["fname"];
                s.Lname = er["fname"];
                s.email = er["fname"];
                s.id = er["id"];
                s.phone = er["phone"];
                temp.Add(s);
            }
            return temp;

           // return students;
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
                    conn.open();
                    MessageBox.Show("Connected");
                }
                catch (Exception e)
                {
                    MessageBox.Show("Unable to Connect");
                }

            string query = "insert into studentTable values ( '+ this.fname + "','" + this.Fname + "','" + this.Lname + "','" + this.email + "','" + this.id + "','" + this.phone  ') ";
            ExecuteNonQuery enq = new ExecuteNonQuery(query);

        }

        public static Student SearchByName(string name)
        {
            //Product p = new Product();
            return students.Find(p => p.Fname == name);
        }
    }
}
