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
    public partial class frmSystemlock : Form
    {
        public frmSystemlock()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.ToLower() == Program.password.ToLower())
            {
                                              
                this.Close();
            }
            else
            {

                textBox1.Text = "";
            }


            


        }

        private void frmSystemlock_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
