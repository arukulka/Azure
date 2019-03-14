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
    public partial class rptAttendance : Form
    {
        public rptAttendance()
        {
            InitializeComponent();
        }

        private void rptAttendance_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.holiday' table. You can move, or remove it, as needed.
            //this.holidayTableAdapter.Fill(this.Database1DataSet.holiday);
            //TODO: This line of code loads data into the 'departmentDataSet.attendence' table. You can move, or remove it, as needed.
            //this.attendenceTableAdapter.Fill(this.departmentDataSet.attendence);

            //this.reportViewer1.RefreshReport();
        }
    }
}
