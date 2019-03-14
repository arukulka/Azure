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
    public partial class frmSalary : Form
    {

        SqlConnection conn;
        SqlDataAdapter dap;
        SqlCommandBuilder cb;
        DataSet ds = new DataSet();
        DataTable dt = new DataTable();

        string str = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=true;User Instance=True";
        string sql = "";
        int tot;
        int r;


        public frmSalary()
        {
            InitializeComponent();
        }

        private void frmSalary_Final_Load(object sender, EventArgs e)
        {

            // TODO: This line of code loads data into the 'database1DataSet2.employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.database1DataSet2.employee);
            webBrowser1.Navigate(Application.StartupPath + "\\Flash\\sc.swf", false);
            conn = new SqlConnection(str);
            sql = "select * from salary";
            dap = new SqlDataAdapter(sql, conn);
            cb = new SqlCommandBuilder(dap);
            conn.Open();
            dap.Fill(dt);

            cb.GetInsertCommand();
            cb.GetUpdateCommand();
            cb.GetDeleteCommand();

            textBox1.DataBindings.Add("Text", dt, "Salary_id");
            textBox2.DataBindings.Add("Text", dt, "Month");
            textBox3.DataBindings.Add("Text", dt, "year");
            comboBox1.DataBindings.Add("Text", dt, "Emp_code");
            comboBox2.DataBindings.Add("Text", dt, "Emp_Name");
            textBox4.DataBindings.Add("Text", dt, "W_day");
            textBox5.DataBindings.Add("Text", dt, "P_day");
            textBox6.DataBindings.Add("Text", dt, "Basic");
            textBox7.DataBindings.Add("Text", dt, "da");
            textBox8.DataBindings.Add("Text", dt, "Hra");
            textBox9.DataBindings.Add("Text", dt, "Ma");
            textBox10.DataBindings.Add("Text", dt, "Pha");
            textBox11.DataBindings.Add("Text", dt, "Hma");
            textBox12.DataBindings.Add("Text", dt, "Pf");
            textBox13.DataBindings.Add("Text", dt, "Pt");
            textBox14.DataBindings.Add("Text", dt, "Loan");
            textBox15.DataBindings.Add("Text", dt, "Oa");
            textBox16.DataBindings.Add("Text", dt, "Arriars");
            textBox17.DataBindings.Add("Text", dt, "Oded");
            textBox18.DataBindings.Add("Text", dt, "Grins");
            textBox19.DataBindings.Add("Text", dt, "Advit");
            textBox20.DataBindings.Add("Text", dt, "Gross");
            textBox21.DataBindings.Add("Text", dt, "Tot_ded");
            textBox22.DataBindings.Add("Text", dt, "Netsal");
            textBox23.DataBindings.Add("Text", dt, "Remark");



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

        //private void btnprevious_Click(object sender, EventArgs e)
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
        //    textBox2.Focus();
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

        //private void button1_Click(object sender, EventArgs e)
        //{
        // decimal basic;
        // decimal da;
        // decimal hra;
        // decimal ma;
        // decimal pha;
        // decimal hma;
        // decimal pf;
        // decimal pt;
        // //decimal loan;
        // //decimal oa;
        // //decimal arries;
        // //decimal oded;
        // //decimal grins;
        // //decimal advit;



        // decimal gross;
        // decimal totded;
        // //decimal netsalary;

        //basic = Decimal.Parse(textBox6.Text);

        //da = basic * 20 / 100;
        //hra = basic * 10 / 100;
        //ma = basic * 5 / 100;
        //pha = basic * 5 / 100;
        //hma = basic * 5 / 100;


        //pf = basic * 10 / 100;
        //pt = basic * 5 / 100;

        //textBox7.Text = da.ToString();
        //textBox8.Text = hra.ToString();
        //textBox9.Text = ma.ToString();
        //textBox10.Text = pha.ToString();
        //textBox11.Text = hma.ToString();
        //textBox12.Text = pf.ToString();
        //textBox13.Text = pt.ToString();


        //gross = basic + hra + da + ma + pha + hma;
        //totded = pf + pt;

        //textBox20.Text = gross.ToString();
        //textBox21.Text = totded.ToString();


        //button2.Enabled = true;
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //    decimal loan;
        //    decimal oa;
        //    decimal arries;
        //    decimal oded;
        //    decimal grins;
        //    decimal advit;
        //    decimal gross;


        //    decimal totded;
        //    decimal netsalary;



        //    if (textBox14.Text == "")
        //    {

        //        MessageBox.Show("Enter Loan Amount...");
        //        return;

        //    }


        //    if (textBox15.Text == "")
        //    {
        //        MessageBox.Show("Enter Other Allowance...");
        //        return;
        //    }



        //    if (textBox16.Text == "")
        //    {
        //        MessageBox.Show("Enter Arrias...");
        //        return;
        //    }



        //    if (textBox17.Text == "")
        //    {
        //        MessageBox.Show("Enter Other Deduction Amount...");
        //        return;
        //    }


        //    if (textBox18.Text == "")
        //    {
        //        MessageBox.Show("Enter Grains...");
        //        return;
        //    }


        //    if (textBox19.Text == "")
        //    {
        //        MessageBox.Show("Enter Advance IT...");
        //        return;
        //    }



        //    loan = Decimal.Parse(textBox14.Text);
        //    oa = Decimal.Parse(textBox15.Text);
        //    arries = Decimal.Parse(textBox16.Text);
        //    oded = Decimal.Parse(textBox17.Text);
        //    grins = Decimal.Parse(textBox18.Text);
        //    advit = Decimal.Parse(textBox19.Text);
        //    totded = Decimal.Parse(textBox21.Text);
        //    gross = Decimal.Parse(textBox20.Text);



        //    totded = totded + loan + oa + arries + oded + grins + advit;

        //    textBox20.Text = gross.ToString();
        //    textBox21.Text = totded.ToString();

        //    netsalary = gross - totded;

        //    textBox22.Text = netsalary.ToString();


        //    button2.Enabled = false;
        //}

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

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

        private void btnprevious_Click_1(object sender, EventArgs e)
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
            this.BindingContext[dt].Position = this.BindingContext[dt].Count-1;
        }

        private void btnclose_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
            textBox2.Focus();
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            {
                decimal basic;
                decimal da;
                decimal hra;
                decimal ma;
                decimal pha;
                decimal hma;
                decimal pf;
                decimal pt;
                //decimal loan;
                //decimal oa;
                //decimal arries;
                //decimal oded;
                //decimal grins;
                //decimal advit;



                decimal gross;
                decimal totded;
                //decimal netsalary;

                basic = Decimal.Parse(textBox6.Text);

                da = basic * 20 / 100;
                hra = basic * 10 / 100;
                ma = basic * 5 / 100;
                pha = basic * 5 / 100;
                hma = basic * 5 / 100;


                pf = basic * 10 / 100;
                pt = basic * 5 / 100;

                textBox7.Text = da.ToString();
                textBox8.Text = hra.ToString();
                textBox9.Text = ma.ToString();
                textBox10.Text = pha.ToString();
                textBox11.Text = hma.ToString();
                textBox12.Text = pf.ToString();
                textBox13.Text = pt.ToString();


                gross = basic + hra + da + ma + pha + hma;
                totded = pf + pt;

                textBox20.Text = gross.ToString();
                textBox21.Text = totded.ToString();


                button2.Enabled = true;
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            decimal loan;
            decimal oa;
            decimal arries;
            decimal oded;
            decimal grins;
            decimal advit;
            decimal gross;


            decimal totded;
            decimal netsalary;



            if (textBox14.Text == "")
            {

                MessageBox.Show("Enter Loan Amount...");
                return;

            }


            if (textBox15.Text == "")
            {
                MessageBox.Show("Enter Other Allowance...");
                return;
            }



            if (textBox16.Text == "")
            {
                MessageBox.Show("Enter Arrias...");
                return;
            }



            if (textBox17.Text == "")
            {
                MessageBox.Show("Enter Other Deduction Amount...");
                return;
            }


            if (textBox18.Text == "")
            {
                MessageBox.Show("Enter Grains...");
                return;
            }


            if (textBox19.Text == "")
            {
                MessageBox.Show("Enter Advance IT...");
                return;
            }



            loan = Decimal.Parse(textBox14.Text);
            oa = Decimal.Parse(textBox15.Text);
            arries = Decimal.Parse(textBox16.Text);
            oded = Decimal.Parse(textBox17.Text);
            grins = Decimal.Parse(textBox18.Text);
            advit = Decimal.Parse(textBox19.Text);
            totded = Decimal.Parse(textBox21.Text);
            gross = Decimal.Parse(textBox20.Text);



            totded = totded + loan + oa + arries + oded + grins + advit;

            textBox20.Text = gross.ToString();
            textBox21.Text = totded.ToString();

            netsalary = gross - totded;

            textBox22.Text = netsalary.ToString();


            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmSalary_List sl = new frmSalary_List();
            sl.ShowDialog();
        }
    }
}