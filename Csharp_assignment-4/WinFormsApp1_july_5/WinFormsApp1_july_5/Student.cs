using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1_july_5
{
    internal class Student
    {
        public String Fname { get; set; }
        public String Lname { get; set; }
        public String email { get; set; }
        public String id { get; set; }
        public String phone { get; set; }

        public void save()
        {
            Console.WriteLine("The student is sucessfully registered");
        }
    }
}
