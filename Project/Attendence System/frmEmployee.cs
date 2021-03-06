﻿using System;
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
    public partial class frmEmployee : Form
    {
        SqlConnection conn;
        SqlDataAdapter dap;
        SqlCommandBuilder cb;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=true;User Instance=True";
        string sql = "";
        public frmEmployee()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate (Application.StartupPath + "\\Flash\\em.swf",false);
            conn = new SqlConnection(str);
            sql = "select * from Employee";
            dap = new SqlDataAdapter(sql, conn);
            cb = new SqlCommandBuilder(dap);
            conn.Open();
            dap.Fill(dt);

            cb.GetInsertCommand();
            cb.GetUpdateCommand();
            cb.GetDeleteCommand();

            textBox1.DataBindings.Add("Text", dt, "Emp_id");
            textBox2.DataBindings.Add("Text", dt, "Emp_code");
            textBox3.DataBindings.Add("Text", dt, "Name");
            textBox4.DataBindings.Add("Text", dt, "Address");
            textBox5.DataBindings.Add("Text", dt, "City");
            textBox6.DataBindings.Add("Text", dt, "Pincode");
            textBox7.DataBindings.Add("Text", dt, "Phone");
            textBox8.DataBindings.Add("Text", dt, "Mobile");
            textBox9.DataBindings.Add("Text", dt, "Email");
            textBox10.DataBindings.Add("Text", dt, "Bloodgroup");
            textBox11.DataBindings.Add("Text", dt, "Designation");
            textBox12.DataBindings.Add("Text", dt, "Basic");
            dateTimePicker1.DataBindings.Add("Text", dt, "Birthdate");
            dateTimePicker3.DataBindings.Add("Text", dt, "Joindate");
            textBox13.DataBindings.Add("Text", dt, "Bank_ac");
            textBox14.DataBindings.Add("Text", dt, "Scale");
            textBox36.DataBindings.Add("Text", dt, "category");
            textBox35.DataBindings.Add("Text", dt, "Gpfno");
            textBox34.DataBindings.Add("Text", dt, "Emp_type");
            textBox33.DataBindings.Add("Text", dt, "Last_institutename");
            textBox30.DataBindings.Add("Text", dt, "Qualification");
            textBox40.DataBindings.Add("Text", dt, "Experience");
            textBox39.DataBindings.Add("Text", dt, "Phy_hand");
            textBox38.DataBindings.Add("Text", dt, "Remark");
            textBox37.DataBindings.Add("Text", dt, "Pan_no");
            textBox32.DataBindings.Add("Text", dt, "Department");
            



            conn.Close();
            Lock_Btn(true);

        }



        private void btnfirst_Click(object sender, EventArgs e)
        {
            this.BindingContext[dt].Position = 0;
        }

        
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

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox36_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox35_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox34_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox33_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox30_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox40_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox39_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox38_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox37_KeyPress(object sender, KeyPressEventArgs e)
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

        private void textBox32_KeyPress(object sender, KeyPressEventArgs e)
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

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        //private void btnadd_Click_1(object sender, EventArgs e)
        //{
        //    this.BindingContext[dt].AddNew();
        //    textBox1.Focus();
        //    Lock_Btn(false);


        //}

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

        private void btnedit_Click(object sender, EventArgs e)
        {
            Lock_Btn(false);

        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

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

        private void btnedit_Click_1(object sender, EventArgs e)
        {
            Lock_Btn(false);
            textBox2.Focus();
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

        private void button1_Click(object sender, EventArgs e)
        {
            frmEmployee_List el = new frmEmployee_List();
            el.ShowDialog();
        }


        
    }
}
