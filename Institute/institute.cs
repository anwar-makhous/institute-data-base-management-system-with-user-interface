using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Institute
{
    public partial class institute : Form
    {
        public institute()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Students obj = new Students();
            obj.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Teachers obj = new Teachers();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Employees obj = new Employees();
            obj.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Employees_Jobs obj = new Employees_Jobs();
            obj.Show();
        }
    }
}
