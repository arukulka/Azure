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
    public partial class rptScale : Form
    {
        public rptScale()
        {
            InitializeComponent();
        }

        private void rptScale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'departmentDataSet.scale' table. You can move, or remove it, as needed.
            this.scaleTableAdapter.Fill(this.departmentDataSet.scale);

            this.reportViewer1.RefreshReport();
        }
    }
}
