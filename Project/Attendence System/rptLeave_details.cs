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
    public partial class rptLeave_details : Form
    {
        public rptLeave_details()
        {
            InitializeComponent();
        }

        private void rptLeave_details_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'leaveDataSet.leave_details' table. You can move, or remove it, as needed.
            this.leave_detailsTableAdapter.Fill(this.leaveDataSet.leave_details);

            this.reportViewer1.RefreshReport();
        }

       
    }
}
