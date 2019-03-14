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
    public partial class frmDepartment : Form
    {
        SqlConnection conn;
        SqlDataAdapter dap;
        SqlCommandBuilder cb;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=true;User Instance=True";
        string sql = "";
        public frmDepartment()
        {
            InitializeComponent();
        }

        private void frmDepartment_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Flash\\de.swf",false);
            
            conn = new SqlConnection(str);
            sql = "select * from Department";
            dap = new SqlDataAdapter(sql, conn);
            cb = new SqlCommandBuilder(dap);
            conn.Open();
            dap.Fill(dt);

            cb.GetInsertCommand();
            cb.GetUpdateCommand();
            cb.GetDeleteCommand();

            textBox1.DataBindings.Add("Text", dt, "Dep_id");
            textBox2.DataBindings.Add("Text", dt, "Dep_code");
            textBox3.DataBindings.Add("Text", dt, "Dep_name");

            conn.Close();
            Lock_Btn(true);

        }

        //private void btnfirst_Click(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].Position = 0;
        //}

        //private void btnnext_Click(object sender, EventArgs e)
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

        //private void btnprivious_Click(object sender, EventArgs e)
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

        //private void btnlast_Click(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].Position = this.BindingContext[dt].Count;

        //}

        //private void btnclose_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        //private void btnadd_Click(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].AddNew();
        //    textBox1.Focus();
        //    Lock_Btn(false);

        //}

        //private void btnedit_Click(object sender, EventArgs e)
        //{
        //    Lock_Btn(false);
        //}

        //private void btndelete_Click(object sender, EventArgs e)
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

        //private void btnsave_Click(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].EndCurrentEdit();
        //    dap.Update(dt);
        //    MessageBox.Show("Data Save....", "Message");
        //    Lock_Btn(true);
        //}

        //private void btncancel_Click(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].CancelCurrentEdit();
        //    Lock_Btn(true);
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
            if (e.KeyChar == 8)
            {
                return;
            }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
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

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnfirst_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position = 0;
        }

        private void btnnext_Click_1(object sender, EventArgs e)
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

        private void btnlast_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position = this.BindingContext[dt].Count;

        }

        private void btnadd_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dt].AddNew();
            textBox1.Focus();
            Lock_Btn(false);

        }

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            Lock_Btn(false);
        }

        private void btndelete_Click_1(object sender, EventArgs e)
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

        private void btnsave_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dt].EndCurrentEdit();
            dap.Update(dt);
            MessageBox.Show("Data Save....", "Message");
            Lock_Btn(true);
        }

        private void btncancel_Click_1(object sender, EventArgs e)
        {
            this.BindingContext[dt].CancelCurrentEdit();
            Lock_Btn(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDepartment_List  de = new frmDepartment_List();
            de.ShowDialog();
        }

       
    }
}
