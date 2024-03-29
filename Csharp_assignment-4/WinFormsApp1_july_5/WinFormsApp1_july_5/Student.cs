﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp1_july_5
{
    internal class Student
    {
        static List<Student> students = new List<Student>();
        string connectionString = @"Data Source=.; Initial Catalog=student; Integreted Security = true";
        public static List<Student> getAllStudents()
        {
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
        } 
            public static Student SearchByName(string name)
            {
                Student p = new Student();
                return students.Find(p => p.Fname == name);
            }
    }
}
