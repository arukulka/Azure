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
    public partial class frmHoliday : Form
    {
        SqlConnection conn;
        SqlDataAdapter dap;
        SqlCommandBuilder cb;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=true;User Instance=True";
        string sql = "";
        public frmHoliday()
        {
            InitializeComponent();
        }

        private void frmHoliday_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Flash\\hd.swf",false);
            conn = new SqlConnection(str);
            sql = "select * from Holiday";
            dap = new SqlDataAdapter(sql, conn);
            cb = new SqlCommandBuilder(dap);
            conn.Open();
            dap.Fill(dt);

            cb.GetInsertCommand();
            cb.GetUpdateCommand();
            cb.GetDeleteCommand();

            textBox1.DataBindings.Add("Text", dt, "Holi_id");
            textBox2.DataBindings.Add("Text", dt, "Year");
            textBox3.DataBindings.Add("Text", dt, "Month");
            dateTimePicker1.DataBindings.Add("Text", dt, "Date");
            textBox4.DataBindings.Add("Text", dt, "Details");
            conn.Close();

            Lock_Btn(true);
        }

        //private void btnfirst_Click(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].Position = 0;
        //}

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (((e.KeyChar) >= 65 && (e.KeyChar) <= 90) || ((e.KeyChar) >= 97 && (e.KeyChar) <= 122))
            {
                e.Handled = true; // numeric
            }
            else
            {
                //e.Handled = true;// text
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (((e.KeyChar) >= 65 && (e.KeyChar) <= 90) || ((e.KeyChar) >= 97 && (e.KeyChar) <= 122))
            {
                e.Handled = true; // numeric
            }
            else
            {
                //e.Handled = true;// text
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 8)
            {
                return;
            }
            if (((e.KeyChar) >= 65 && (e.KeyChar) <= 90) || ((e.KeyChar) >= 97 && (e.KeyChar) <= 122))
            {
                //e.Handled = true; // numeric
            }
            else
            {
                e.Handled = true;// text
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 10)
            {
                return;
            }
            if (((e.KeyChar) >= 65 && (e.KeyChar) <= 90) || ((e.KeyChar) >= 97 && (e.KeyChar) <= 122))
            {
                //e.Handled = true; // numeric
            }
            else
            {
                e.Handled = true;// text
            }
        }

        //private void btnnext_Click_1(object sender, EventArgs e)
        //{
        //    if (this.BindingContext[dt].Position == this.BindingContext[dt].Count - 1)
        //    {
        //        MessageBox.Show("This is Last Record...", "Message");
        //    }
        //    else
        //    {
        //        this.BindingContext[dt].Position += 1;
        //    }

        //}

        //private void btnprivious_Click_1(object sender, EventArgs e)
        //{
        //    if (this.BindingContext[dt].Position == 0)
        //    {
        //        MessageBox.Show("This is First Record...", "Message");
        //    }
        //    else
        //    {
        //        this.BindingContext[dt].Position -= 1;
        //    }

        //}

        //private void btnlast_Click_1(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].Position = this.BindingContext[dt].Count;

        //}

        //private void btnclose_Click_1(object sender, EventArgs e)
        //{
        //    this.Close();

        //}

        //private void btnadd_Click_1(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].AddNew();
        //    textBox1.Focus();

        //    Lock_Btn(false);

        //}

        //private void btndelete_Click_1(object sender, EventArgs e)
        //{
        //    DialogResult ans;
        //    ans = MessageBox.Show("Do You Want to Delete This record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        //    if (ans == DialogResult.Yes)
        //    {
        //        this.BindingContext[dt].RemoveAt(this.BindingContext[dt].Position);
        //        dap.Update(dt);
        //        MessageBox.Show("Record Deleted...", "Message");
        //    }
        //}

        //private void btnsave_Click_1(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].EndCurrentEdit();
        //    dap.Update(dt);
        //    MessageBox.Show("Data Save....", "Message");
        //    Lock_Btn(true);

        //}

        //private void btncancel_Click_1(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].CancelCurrentEdit();
        //    Lock_Btn(true);
        //}

        public void Lock_Btn(bool f)
        {

            btnfirst.Enabled = f;
            btnnext.Enabled = f;
            btnprevious.Enabled = f;
            btnlast.Enabled = f;
            btnadd.Enabled = f;
            btnedit.Enabled = f;
            btndelete.Enabled = f;
            btnclose.Enabled = f;



            btnsave.Enabled = !f;
            btncancel.Enabled = !f;

        }

        //private void btnedit_Click(object sender, EventArgs e)
        //{
        //    Lock_Btn(false);
        //    textBox2.Focus();
        //}

        private void btnfirst_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position = 0;
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[dt].Position == this.BindingContext[dt].Count - 1)
            {
                MessageBox.Show("This is Last Record...", "Message");
            }
            else
            {
                this.BindingContext[dt].Position += 1;
            }

        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            if (this.BindingContext[dt].Position == 0)
            {
                MessageBox.Show("This is First Record...", "Message");
            }
            else
            {
                this.BindingContext[dt].Position -= 1;
            }
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position = this.BindingContext[dt].Count;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].AddNew();
            textBox1.Focus();

            Lock_Btn(false);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult ans;
            ans = MessageBox.Show("Do You Want to Delete This record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ans == DialogResult.Yes)
            {
                this.BindingContext[dt].RemoveAt(this.BindingContext[dt].Position);
                dap.Update(dt);
                MessageBox.Show("Record Deleted...", "Message");
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].EndCurrentEdit();
            dap.Update(dt);
            MessageBox.Show("Data Save....", "Message");
            Lock_Btn(true);
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].CancelCurrentEdit();
            Lock_Btn(true);
        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {

            Lock_Btn(false);
            textBox2.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmHoliday_List hl = new frmHoliday_List();
            hl.ShowDialog();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }
       
    }
}
