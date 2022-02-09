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
    public partial class Departments : Form
    {
        public Departments()
        {
            InitializeComponent();
        }

        private void dEPARTMENTSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.dEPARTMENTSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.instituteDataSet);

        }

        private void Departments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'instituteDataSet.DEPARTMENTS' table. You can move, or remove it, as needed.
            this.dEPARTMENTSTableAdapter.Fill(this.instituteDataSet.DEPARTMENTS);

        }
    }
}
