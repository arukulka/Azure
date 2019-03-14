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
    public partial class rptSalary : Form
    {
        public rptSalary()
        {
            InitializeComponent();
        }

        private void rptSalary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'SalaryDataSet.salary' table. You can move, or remove it, as needed.
           this.salaryTableAdapter.Fill(this.SalaryDataSet.salary);

            this.reportViewer1.RefreshReport();
        }
    }
}
