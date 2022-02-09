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
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void sTUDENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.instituteDataSet);

        }

        private void Students_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'instituteDataSet.DEPARTMENTS' table. You can move, or remove it, as needed.
            this.dEPARTMENTSTableAdapter.Fill(this.instituteDataSet.DEPARTMENTS);
            // TODO: This line of code loads data into the 'instituteDataSet.STUDENTS' table. You can move, or remove it, as needed.
            this.sTUDENTSTableAdapter.Fill(this.instituteDataSet.STUDENTS);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Departments obj = new Departments();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subjects obj = new Subjects();
            obj.Show();
        }

        private void std_subTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
