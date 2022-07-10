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
            txtFName.Text = txtFName.Text.ToUpper();
        }

        private void txtLName_Leave(object sender, EventArgs e)
        {
            txtLName.Text = txtLName.Text.ToUpper();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Student s = new Student();
           
            if (s.Fname != null && s.phone != null) {
                 s.Fname = txtFName.Text;
            s.Lname = txtLName.Text;
            s.email = txtEmail.Text;
            s.id = txtId.Text;
            s.phone = txtPhone.Text;
            
            s.save();
                MessageBox.Show("Registered sucessfully.");
                btnClear_Click(s, e);}
            
            else
            {
                MessageBox.Show("Registration Failed :( \n FILL YOUR INFORMATION PROPERly!");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFName.Clear();
            txtLName.Clear();
            txtEmail.Clear();
            txtId.Clear();
            txtPhone.Clear();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}