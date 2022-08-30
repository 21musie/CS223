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
    public partial class MDIcontainer : Form
    {
        public MDIcontainer()
        {
            InitializeComponent();
        }

        private void aDDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Form1 form = new Form1("admin");
            form.MdiParent = this;
            form.Dock = DockStyle.Fill;
            form.Show();
        }

        private void displayAllStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild != null)
            {
                ActiveMdiChild.Close();
            }
            Display d= new Display();
            d.MdiParent = this;
            d.Dock = DockStyle.Fill;
            d.Show();

        }
    }
}
