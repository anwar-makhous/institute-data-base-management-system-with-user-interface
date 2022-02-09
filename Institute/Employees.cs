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
    public partial class Employees : Form
    {
        public Employees()
        {
            InitializeComponent();
        }

        private void eMPOLYEESBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPOLYEESBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.instituteDataSet);

        }

        private void Employees_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'instituteDataSet.DEPARTMENTS' table. You can move, or remove it, as needed.
            this.dEPARTMENTSTableAdapter.Fill(this.instituteDataSet.DEPARTMENTS);
            // TODO: This line of code loads data into the 'instituteDataSet.EMPLOYEES_JOBS' table. You can move, or remove it, as needed.
            this.eMPLOYEES_JOBSTableAdapter.Fill(this.instituteDataSet.EMPLOYEES_JOBS);
            // TODO: This line of code loads data into the 'instituteDataSet.EMPOLYEES' table. You can move, or remove it, as needed.
            this.eMPOLYEESTableAdapter.Fill(this.instituteDataSet.EMPOLYEES);

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employees_Jobs obj = new Employees_Jobs();
            obj.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
            obj.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
            obj.Show();
        }
    }
}
