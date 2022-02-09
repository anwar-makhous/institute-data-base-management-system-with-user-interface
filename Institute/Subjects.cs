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
    public partial class Subjects : Form
    {
        public Subjects()
        {
            InitializeComponent();
        }

        private void sUBJECTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sUBJECTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.instituteDataSet);

        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'instituteDataSet.TEACHERS' table. You can move, or remove it, as needed.
            this.tEACHERSTableAdapter.Fill(this.instituteDataSet.TEACHERS);
            // TODO: This line of code loads data into the 'instituteDataSet.DEPARTMENTS' table. You can move, or remove it, as needed.
            this.dEPARTMENTSTableAdapter.Fill(this.instituteDataSet.DEPARTMENTS);
            // TODO: This line of code loads data into the 'instituteDataSet.SUBJECTS' table. You can move, or remove it, as needed.
            this.sUBJECTSTableAdapter.Fill(this.instituteDataSet.SUBJECTS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teachers obj = new Teachers();
            obj.Show();
        }
    }
}
