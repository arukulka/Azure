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
    public partial class rptAttendance1 : Form
    {
        public rptAttendance1()
        {
            InitializeComponent();
        }

        private void rptAttendance1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet7.attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.Database1DataSet7.attendance);
            // TODO: This line of code loads data into the 'departmentDataSet.attendence' table. You can move, or remove it, as needed.
            //this.attendenceTableAdapter.Fill(this.departmentDataSet.attendence);
            // TODO: This line of code loads data into the 'Database1DataSet2.employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.Database1DataSet2.employee);

            this.reportViewer1.RefreshReport();
            
        }
    }
}
