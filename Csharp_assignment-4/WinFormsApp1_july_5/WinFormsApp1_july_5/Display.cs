using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1_july_5
{
    public partial class Display : Form
    {
        public Display()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void studentCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Card Clicked.");
        }

        private void Display_Load(object sender, EventArgs e)
        {
            foreach (var stud in Student.getAllStudents())
            {
                studentCard s = new studentCard();
                s.sname = stud.Fname;
                s.sid = stud.id;
                s.semail = stud.email;

                s.Click += studentCard_Click;
               flowLayoutPanel1.Controls.Add(s);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
