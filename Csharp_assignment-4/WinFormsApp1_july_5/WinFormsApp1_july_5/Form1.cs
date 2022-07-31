using System.Text.RegularExpressions;

namespace WinFormsApp1_july_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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


            Regex name = new Regex(@"^[a-z]$");
            Regex phone = new Regex(@"^09[0-9]{8}$");
            Regex email = new Regex(@"^[a-z]@gmail.com $");
            Regex id = new Regex(@"^[a-z] {2} [0-9] {4} $");

            if (name.IsMatch(txtFName.Text) & name.IsMatch(txtFName.Text) & name.IsMatch(txtLName.Text) & phone.IsMatch(txtPhone.Text) & id.IsMatch(txtId.Text) & email.IsMatch(txtEmail.Text))
            { //
                errorProvider1.Clear();

                s.Fname = txtFName.Text;
                s.Lname = txtLName.Text;
                s.email = txtEmail.Text;
                s.id = txtId.Text;
                s.phone = txtPhone.Text;

                s.save();
                //MessageBox.Show("Registered sucessfully.");
                btnClear_Click(s, e);

                dgv1.DataSource = null;
                dgv1.DataSource = Student.getAllStudents();
                //                errorProvider1.SetError(txtFName, "Fix this Damn it!!");
            }

            else
            {
                if (!name.IsMatch(txtFName.Text))
                    errorProvider1.SetError(txtFName, "Invalid name format!");
               /* if (!name.IsMatch(txtLName.Text))
                    errorProvider1.SetError(txtLName, "Invalid name format");
                if (!email.IsMatch(txtEmail.Text))
                    errorProvider1.SetError(txtEmail, "Invalid E-mail format");
                if (!id.IsMatch(txtId.Text))
                    errorProvider1.SetError(txtId, "Invalid ID");
                if (!phone.IsMatch(txtPhone.Text))
                    errorProvider1.SetError(txtPhone, "Invalid phone number");
               */

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
        }
    }
}
