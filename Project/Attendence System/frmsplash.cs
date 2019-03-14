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
    public partial class frmsplash : Form
    {
        public frmsplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value>=100)
            {
                this.Close();
            }
            else
            {
                progressBar1.Value = progressBar1.Value + 1;
                label6.Text = "Loading...." + progressBar1.Value + "%";
            }
        }

        private void frmsplash_Load(object sender, EventArgs e)
        {
          webBrowser1.Navigate(Application.StartupPath+"\\Flash\\spl.swf",false);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
