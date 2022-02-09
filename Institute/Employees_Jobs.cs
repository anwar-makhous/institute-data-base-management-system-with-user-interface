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
    public partial class Employees_Jobs : Form
    {
        public Employees_Jobs()
        {
            InitializeComponent();
        }

        private void eMPLOYEES_JOBSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eMPLOYEES_JOBSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.instituteDataSet);

        }

        private void Employees_Jobs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'instituteDataSet.EMPLOYEES_JOBS' table. You can move, or remove it, as needed.
            this.eMPLOYEES_JOBSTableAdapter.Fill(this.instituteDataSet.EMPLOYEES_JOBS);

        }
    }
}
