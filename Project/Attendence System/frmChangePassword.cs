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
    public partial class frmChangePassword : Form
    {

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=true;User Instance=True";
        string sql = "";

        string login_id;
        string username;
        string password;

        string newpassword;
        string confirmpass;



        public frmChangePassword()
        {
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Flash\\cn.swf", false);
            conn = new SqlConnection(str);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;
            newpassword = textBox3.Text;
            confirmpass = textBox4.Text;



            if (textBox1.Text != "")
            {
                sql = "select Username from login where Username='" + username + "' and Password='" + password + "' ";
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                object c = cmd.ExecuteScalar();
                conn.Close();
                if (c != null)
                {
                    sql = "update login set password = '" + newpassword + "' where username ='" + username + "' ";
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {

                        MessageBox.Show("Your Password is Changed...");
                    }
                    else
                    {
                        MessageBox.Show("Wrong User or Password");
                    }
                }
                else
                {
                    Program.flag = false;
                    MessageBox.Show("Wrong Username OR Password");
                    this.Close();
                }
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 8)
            //{
            //    return;
            //}
            //if (((e.KeyChar) >= 65 && (e.KeyChar) <= 90) || ((e.KeyChar) >= 97 && (e.KeyChar) <= 122))
            //{
            //    //e.Handled = true; // numeric
            //}
            //else
            //{
            //   e.Handled = true;// text
            //}
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 8)
            //{
            //    return;
            //}
            //if (((e.KeyChar) >= 65 && (e.KeyChar) <= 90) || ((e.KeyChar) >= 97 && (e.KeyChar) <= 122))
            //{
            //    //e.Handled = true; // numeric
            //}
            //else
            //{
            //    e.Handled = true;// text
            //}

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 8)
            //{
            //    return;
            //}
            //if (((e.KeyChar) >= 65 && (e.KeyChar) <= 90) || ((e.KeyChar) >= 97 && (e.KeyChar) <= 122))
            //{
            //    //e.Handled = true; // numeric
            //}
            //else
            //{
            //    e.Handled = true;// text
            //}

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == 8)
            //{
            //    return;
            //}
            //if (((e.KeyChar) >= 65 && (e.KeyChar) <= 90) || ((e.KeyChar) >= 97 && (e.KeyChar) <= 122))
            //{
            //    //e.Handled = true; // numeric
            //}
            //else
            //{
            //    e.Handled = true;// text
            //}
        }

       
        

        private void button1_Click_1(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;
            newpassword = textBox3.Text;
            confirmpass = textBox4.Text;



            if (textBox1.Text != "")
            {
                sql = "select Username from login where Username='" + username + "' and Password='" + password + "' ";
                cmd = new SqlCommand(sql, conn);
                conn.Open();
                object c = cmd.ExecuteScalar();
                conn.Close();
                if (c != null)
                {
                    sql = "update login set password = '" + newpassword + "' where username ='" + username + "' ";
                    cmd = new SqlCommand(sql, conn);
                    conn.Open();
                    int i = cmd.ExecuteNonQuery();
                    conn.Close();
                    if (i > 0)
                    {

                        MessageBox.Show("Your Password is Changed...");
                    }
                    else
                    {
                        MessageBox.Show("Wrong User or Password");
                    }
                }
                else
                {
                    Program.flag = false;
                    MessageBox.Show("Wrong Username OR Password");
                    this.Close();
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
                this.Close();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        
    }
}
