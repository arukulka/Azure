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
    public partial class rptHoliday : Form
    {
        public rptHoliday()
        {
            InitializeComponent();
        }

        private void rptHoliday_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Database1DataSet.holiday' table. You can move, or remove it, as needed.
            this.holidayTableAdapter.Fill(this.Database1DataSet.holiday);

            this.reportViewer1.RefreshReport();
        }
    }
}
