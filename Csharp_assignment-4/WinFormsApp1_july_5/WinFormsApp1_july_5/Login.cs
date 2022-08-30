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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            //Form1 form = new Form1(txtUsername.Text); //this was for the lojin button to open the main form(Form1)


            if (txtPassword.Text == "admin" && txtUsername.Text == "admin")
            {
                MDIcontainer container = new MDIcontainer();
                container.Show();
                Hide();

                //form.Show(); //This was also for the main form(Form1)
            }   
            // this.Hide(); //this was for the login form to hide
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
