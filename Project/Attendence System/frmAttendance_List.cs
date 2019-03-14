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
    public partial class frmAttendance_List : Form
    {
        SqlConnection conn;
        SqlDataAdapter dap;
        SqlCommandBuilder cb;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=true;User Instance=True";
        string sql = "";
        public frmAttendance_List()
        {
            InitializeComponent();
        }

        private void frmAttendance_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet6.attendance' table. You can move, or remove it, as needed.
            this.attendanceTableAdapter.Fill(this.database1DataSet6.attendance);
            webBrowser1.Navigate(Application.StartupPath + "\\Flash\\al.swf", false);
            conn = new SqlConnection(str);
            sql = "select * from attendance";
            dap = new SqlDataAdapter(sql, conn);
            conn.Open();
            dap.Fill(ds, "attendance");
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // frmAttendance1 att = new frmAttendance1();
           // att.ShowDialog();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {

            rpt_1 ratt = new rpt_1();
            ratt.ShowDialog();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.Text == "")
            {
                MessageBox.Show("select search field", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (comboBox1.Text == "Attendance ID")
            {
                sql = "select * from attendance where Attendence_id like'" + textBox1.Text + "%'";
            }

            if (comboBox1.Text == "Employee Code")
            {
                sql = "select * from attendance where Emp_code like'" + textBox1.Text + "%'";
            }

            conn.Open();
            dap = new SqlDataAdapter(sql, conn);
            dt = new DataTable();
            dap.Fill(ds, "attendance");
            dap.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            frmAttendance att = new frmAttendance();
            att.ShowDialog();
        }
    }
}
