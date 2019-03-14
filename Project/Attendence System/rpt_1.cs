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
    public partial class rpt_1 : Form
    {
        public rpt_1()
        {
            InitializeComponent();
        }

        private void rpt_1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet8.attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.Database1DataSet8.attendance);

            this.reportViewer1.RefreshReport();
        }
    }
}
