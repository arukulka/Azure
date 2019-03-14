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
    public partial class frmLeave_List : Form
    {
        SqlConnection conn;
        SqlDataAdapter dap;
        SqlCommandBuilder cb;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=true;User Instance=True";
        string sql = "";

        public frmLeave_List()
        {
            InitializeComponent();
        }

        private void frmLeave_List_Load(object sender, EventArgs e)
        {
            
            webBrowser1.Navigate(Application.StartupPath + "\\Flash\\ll.swf",false);
            conn = new SqlConnection(str);
            sql = "select * from leave_details";
            dap = new SqlDataAdapter(sql, conn);
            conn.Open();
            dap.Fill(ds, "leave_details");
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        //private void btnclose_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    textBox1.Text = "";
        //}

        //private void textBox1_TextChanged(object sender, EventArgs e)
        //{
        //    if (comboBox1.Text == "")
        //    {
        //        MessageBox.Show("select search field", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        return;
        //    }
        //    if (comboBox1.Text == "Leave ID")
        //    {
        //        sql = "select * from leave_details where leave_id like'" + textBox1.Text + "%'";
        //    }
            
        //    if (comboBox1.Text == "Employee ID")
        //    {
        //        sql = "select * from leave_details where emp_id like'" + textBox1.Text + "%'";
        //    }
        //    if (comboBox1.Text == "Employee Name")
        //    {
        //        sql = "select * from leave_details where emp_name like'" + textBox1.Text + "%'";
        //    }
            
        //    conn.Open();
        //    dap = new SqlDataAdapter(sql, conn);
        //    dt = new DataTable();
        //    dap.Fill(ds, "leave_details");
        //    dap.Fill(dt);
        //    dataGridView1.DataSource = dt;
        //    conn.Close();
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    rptLeave_details rleave = new rptLeave_details();
        //    rleave.ShowDialog();
        //}

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    frmLeave leave = new frmLeave();
        //    leave.ShowDialog();
        //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            rptLeave_details rleave = new rptLeave_details();
            rleave.ShowDialog();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frmLeave leave = new frmLeave();
            leave.ShowDialog();
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("select search field", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboBox1.Text == "Leave ID")
            {
                sql = "select * from leave_details where leave_id like'" + textBox1.Text + "%'";
            }

            if (comboBox1.Text == "Employee ID")
            {
                sql = "select * from leave_details where emp_id like'" + textBox1.Text + "%'";
            }
            if (comboBox1.Text == "Employee Name")
            {
                sql = "select * from leave_details where emp_name like'" + textBox1.Text + "%'";
            }

            conn.Open();
            dap = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dap.Fill(ds, "leave_details");
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
    }
}
