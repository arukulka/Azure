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
    public partial class rptWorkingday : Form
    {
        public rptWorkingday()
        {
            InitializeComponent();
        }

        private void rptWorkingday_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentDataSet.working_day' table. You can move, or remove it, as needed.
            this.working_dayTableAdapter.Fill(this.departmentDataSet.working_day);

            this.reportViewer1.RefreshReport();
        }
    }
}
