using System.Text.RegularExpressions;

namespace WinFormsApp1_july_5
{
    public partial class Form1 : Form
    {
        public Form1(string user)
        {
            InitializeComponent();
        lblUser.Text = user;
        }


        private void textBox1_Leave(object sender, EventArgs e)
        {
            // txtFName.Text = txtFName.Text.ToUpper();
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            //txtLName.Text = txtLName.Text.ToUpper();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Student s = new Student();


            Regex Rname = new Regex(@"^[A-Za-z]{3,15}$");
            Regex Rphone = new Regex(@"^09[0-9]{8}$");
            Regex Remail = new Regex(@"^[A-Za-z0-9]+@[a-z]+\.com$");
            Regex Rid = new Regex(@"^[A-Za-z]{2}[0-9]{4}$");

            
             if (Rname.IsMatch(txtFName.Text) & Rname.IsMatch(txtLName.Text) & Remail.IsMatch(txtEmail.Text) & Rid.IsMatch(txtId.Text) & Rphone.IsMatch(txtPhone.Text))
            { 
                errorProvider1.Clear();

                s.Fname = txtFName.Text;
                s.Lname = txtLName.Text;
                s.email = txtEmail.Text;
                s.id = txtId.Text;
                s.phone = txtPhone.Text;

                // validating terms and services
                if (chkTerms.Checked)
                {
                    s.save();
                    //MessageBox.Show("Registered sucessfully.");
                    btnClear_Click(s, e);

                    dgv1.DataSource = null;
                    dgv1.DataSource = Student.getAllStudents();



                    //errorProvider1.SetError(txtFName, "Fix this Damn it!!");
                }
                else
                {
                    errorProvider1.SetError(chkTerms, "NO WAY !! Just check me.");
                }
                
            }

            else
            {
                if (!Rname.IsMatch(txtFName.Text))
                    errorProvider1.SetError(txtFName, "Invalid name format!");
                if (!Rname.IsMatch(txtLName.Text))
                    errorProvider1.SetError(txtLName, "Invalid name format");
                if (!Remail.IsMatch(txtEmail.Text))
                    errorProvider1.SetError(txtEmail, "Invalid E-mail format");
                if (!Rid.IsMatch(txtId.Text))
                    errorProvider1.SetError(txtId, "Invalid ID");
                if (!Rphone.IsMatch(txtPhone.Text))
                    errorProvider1.SetError(txtPhone, "Invalid phone number");
               
                //MessageBox.Show("Registration Failed :( \n FILL YOUR INFORMATION PROPERly!");
            }
            
             
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtEmail.Clear();
            txtId.Clear();
            txtPhone.Clear();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            for (int i = 0; i < 6; i++)
            {
                checkedListBox1.SetItemChecked(i, false);
            }
            chkTerms.Checked = false;
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string name;
            name = txtSearch.Text;
            Student s = new Student();
            s = null;
            if (Student.SearchByName(Name) != null)
            {
                s = Student.SearchByName(name);
            }
            if (s != null)
                txtSearch.Text = s.Fname;
            else
                txtSearch.Text = "Student not found";
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Display d = new Display();
            // d.MdiParent = this;
            d.Dock = DockStyle.Fill;
            d.Show();

            //MessageBox.Show("DISPLAYING!!!");
            //Display d = new Display();
            //d.Show();
            //Hide();
            //dgv1.DataSource = null;
            //dgv1.DataSource = Student.getAllStudents();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
