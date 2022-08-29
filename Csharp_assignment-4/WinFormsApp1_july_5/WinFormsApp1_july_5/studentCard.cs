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
    public partial class studentCard : UserControl
    {
        public studentCard()
        {
            InitializeComponent();
        }

        private void studentCard_Load(object sender, EventArgs e)
        {
            
        }
        private string _sname;

        public string sname
        {
            get { return _sname; }
            set { _sname = value; lbl_sname.Text = value; }
        }

        private string _sid;

        public string sid
        {
            get { return _sid; }
            set { _sid = value; lbl_sid.Text = value; }
        }

        private string _semail;
        public string semail
        {
            get { return _semail; }
            set { _semail = value; lbl_semail.Text = value; }
        }

        private void studentCard_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Card Clicked.");
        }
    }
}
