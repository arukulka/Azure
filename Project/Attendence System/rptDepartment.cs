using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Attendence_System
{
    public partial class rptDepartment : Form
    {
        public rptDepartment()
        {
            InitializeComponent();
        }

        private void rptDepartment_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.department' table. You can move, or remove it, as needed.
            this.departmentTableAdapter.Fill(this.Database1DataSet.department);

            this.reportViewer1.RefreshReport();
        }
    }
}
