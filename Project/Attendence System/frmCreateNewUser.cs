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
    public partial class frmCreateNewUser : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=true;User Instance=True";
        string sql = "";




        
        string username;
        string password;
        string confipassword;


        public frmCreateNewUser()
        {
            InitializeComponent();
        }

        private void frmCreateNewUser_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(str);
            webBrowser1.Navigate(Application.StartupPath + "\\Flash\\cp.swf", false);
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    textBox1.Text = "";
        //    textBox2.Text = "";
        //    textBox3.Text = "";
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{

        //    username = textBox1.Text;
        //    password = textBox2.Text;
        //    confipassword = textBox3.Text;

        //    if (textBox2.Text == textBox3.Text && textBox2.Text != "")
        //    {
        //        sql = "insert into login (username,password,role)values ('" + username + "','" + password + "','User')";
        //        cmd = new SqlCommand(sql, conn);
                
        //        conn.Open();
        //        int i= cmd.ExecuteNonQuery();
        //        conn.Close();


        //        if (i > 0)
        //        {
        //            MessageBox.Show("New User Created");
        //        }
        //        else
        //        {
        //            MessageBox.Show("Wrong Username or Password...");
        //        }

        //    }
        //}

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
            //    e.Handled = true;// text
            //}
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
        //    if (e.KeyChar == 8)
        //    {
        //        return;
        //    }
        //    if (((e.KeyChar) >= 65 && (e.KeyChar) <= 90) || ((e.KeyChar) >= 97 && (e.KeyChar) <= 122))
        //    {
        //        //e.Handled = true; // numeric
        //    }
        //    else
        //    {
        //        e.Handled = true;// text
        //    }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            username = textBox1.Text;
            password = textBox2.Text;
            confipassword = textBox3.Text;

            if (textBox2.Text == textBox3.Text && textBox2.Text != "")
            {
                sql = "insert into login (username,password,role)values ('" + username + "','" + password + "','User')";
                cmd = new SqlCommand(sql, conn);

                conn.Open();
                int i = cmd.ExecuteNonQuery();
                conn.Close();


                if (i > 0)
                {
                    MessageBox.Show("New User Created");
                }
                else
                {
                    MessageBox.Show("Wrong Username or Password...");
                }

            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = ""; 
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
