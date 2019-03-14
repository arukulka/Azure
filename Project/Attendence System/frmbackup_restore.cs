using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Attendence_System
{
    public partial class frmbackup_restore : Form
    {
        public frmbackup_restore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
              saveFileDialog1.ShowDialog();
              if (File.Exists(saveFileDialog1.FileName))
                {
                    File.Delete(saveFileDialog1.FileName);
                }
                File.Copy(Application.StartupPath + "\\Database1.mdf", saveFileDialog1.FileName);
                MessageBox.Show("Backup Successfull...");
            }
            catch
            {
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
            openFileDialog1.ShowDialog();
            
                MessageBox.Show(openFileDialog1.FileName.ToString());

                if (File.Exists(Application.StartupPath + "\\Database1.mdf"))
                {
                    File.Delete(Application.StartupPath + "\\Database1.mdf");
                }
                File.Copy(openFileDialog1.FileName.ToString(), Application.StartupPath + "\\Database1.mdf");
                MessageBox.Show("Restore Successfull...");
            }
            catch
            {
            }
        }

        private void frmbackup_restore_Load(object sender, EventArgs e)
        {

        }
    }
}
