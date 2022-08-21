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
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private void UserControl1_Load(object sender, EventArgs e)
        {

        }
        private string _Uname;

        public string UserName
        {
            get { return _Uname; }
            set { _Uname = value; lbl_user.Text = value; }
        }

        private string _name;


        public string NameOfUser
        {
            get { return _name; }
            set { _name = value; lbl_name.Text = value; }
        }
    }
}
