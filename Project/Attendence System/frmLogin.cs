using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Attendence_System
{
    public partial class frmLogin : Form
    {
        String str=@"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True";
        string sql = "";
        SqlConnection conn;
        SqlCommand cmd;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate(Application.StartupPath + "\\Flash\\lo.swf", false);
            
            conn = new SqlConnection(str);
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

       

        private void webBrowser1_DocumentCompleted_1(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //login
            sql = "select Username from login where Username='" + textBox13.Text + "' and Password='" + textBox12.Text + "' ";
            cmd = new SqlCommand(sql, conn);
            conn.Open();
            object c = cmd.ExecuteScalar();
            conn.Close();
            if (c != null)
            {
                MessageBox.Show("Welcome");
                Program.flag = true;
                this.Close();

                
            }
            else
            {
                Program.flag = false;
                MessageBox.Show("Wrong Username OR Password");
                
            }
           



        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.BindingContext[dt].CancelCurrentEdit();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
