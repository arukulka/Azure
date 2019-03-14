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
    public partial class rptEmployee : Form
    {
        public rptEmployee()
        {
            InitializeComponent();
        }

        private void rptEmployee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.Database1DataSet2.employee);

            this.reportViewer1.RefreshReport();
        }
    }
}
