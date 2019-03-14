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
    public partial class Attendance : Form
    {
        Database d1 = new Database();
        SqlDataAdapter dap;
        DataTable dt;

        string a;
        string b;


        public Attendance()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            d1.ConOpen();
            dt = d1.DisplayGrid("select emp_code,name,department from employee");
            DataGridView1.DataSource=dt;
            d1.ConClose();
            generate();            
          //data();
            int t;
            for (t = 0; t <= DataGridView1.Columns.Count-1;t++)
            {
                DataGridView1.Columns[t].SortMode = DataGridViewColumnSortMode.NotSortable;
                DataGridView1.Columns[t].ReadOnly = true;
                DataGridView1.Columns[t].DefaultCellStyle.BackColor = Color.White;
            }

            data();

        
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            d1.ConOpen();
            int t;
            DateTime d;

            d = DateTime.Parse(a);
            string s = d.Month + "-" + d.Day+ "-" + d.Year;

            for (t = 0; t <= DataGridView1.Rows.Count - 1; t++)
            {
                d1.Delete("delete from attendence where no=" + DataGridView1.Rows[t].Cells["emp_code"].Value.ToString() + " and convert(varchar,d,101)='" + d.ToString() + "'");
            }

            for (t = 0; t <= DataGridView1.Rows.Count - 1; t++)
            {
                d1.Insert("Insert into attendance (att_date,emp_code,is_present) values('" + s + "'," + DataGridView1.Rows[t].Cells["emp_code"].Value.ToString() + "," + "1" + ")");
            }

            
            MessageBox.Show("Complate Fill Attendence");
            d1.ConClose();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }


        public void  data()
        {        
        d1.ConOpen();
        int t ;
        int u ;
        //DateTime dt1 ;
       string dt1="";
        for (u = 3; u <= DataGridView1.Columns.Count - 5; u++)
        {
            dt1 = DateTime.Parse(DataGridView1.Columns[u].HeaderText).ToShortDateString();

            DataTable dt = new DataTable();
            dt = d1.DisplayGrid("select * from attendence where convert(varchar,d,101)='" + dt1.ToString() + "'");



            if (dt.Rows.Count > 0)
            {
                for (t = 0; t < dt.Columns.Count; t++)
                {

                    if (dt.Rows[t]["status"].ToString() != "True")
                    {
                        DataGridView1.Rows[t].Cells[u].Value = true;
                    }
                    else
                    {
                        DataGridView1.Rows[t].Cells[u].Value = false;
                    }
                }
            }

        }
    
        d1.ConClose();
        //return 0;
        }


        public void generate()
        {
         DateTime i;
         DateTime j;
         string s;
         int t;
         int[] a = new int[4];

         DataTable dt1;

         dt1 = d1.DisplayGrid("select convert(varchar,SDate,101) ,convert(varchar,EDate,101) from semester");
        i = DateTime.Parse(dt1.Rows[0][0].ToString());
        j = DateTime.Parse(dt1.Rows[0][1].ToString());
        
      
    
         
            while ( i.CompareTo(j)!=0)
            {

              
                   
                                                
                       DataGridViewCheckBoxColumn dg = new DataGridViewCheckBoxColumn();
                       dg.HeaderText = i.Day  + "/"  + i.Month + "/"  + i.Year ;
                       dg.Width = 30;
                       DataGridView1.Columns.Add(dg);
                  i = i.Date.AddDays(1);
                }
               DataGridView1.Columns.Add("Total", "Total");
            }
            

      
        

        private void DataGridView1_Scroll(object sender, ScrollEventArgs e)
        {
            int t;
            for(t=0;t<=1;t++)
            {
                DataGridView1.Columns[t].Frozen = true;
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
        int i ;
        int u ;
        int k;
        
        for( i = 0 ;i<= DataGridView1.Rows.Count - 1;i++)
        {
            k = 0;
            for(u = 3 ;u<= DataGridView1.Columns.Count-5;u++)
            {
                if (DataGridView1.Rows[i].Cells[u].Value!=null  )
                {
                    k = k + 1;
                }
            }
            if (k == 0)
            {
                DataGridView1.Rows[i].Cells["Total"].Value = 0;
            }
            else
            {
                DataGridView1.Rows[i].Cells["Total"].Value = k;
            }

        }
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
         a = DataGridView1.Columns[e.ColumnIndex].HeaderText;
         b = e.ColumnIndex.ToString();
         int t;
         
         for(t = 0 ;t<=DataGridView1.Columns.Count - 2;t++)
         {
             if (DataGridView1.Columns[t].HeaderText == DataGridView1.Columns[e.ColumnIndex].HeaderText)
             {
                 DataGridView1.Columns[t].ReadOnly = false;
                 DataGridView1.Columns[t].DefaultCellStyle.BackColor = Color.DarkTurquoise;
             }
            else
            {
                DataGridView1.Columns[t].ReadOnly = true;
                DataGridView1.Columns[t].DefaultCellStyle.BackColor = Color.White;
            }
         }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if ((CheckBox1.Checked))
            {
              int t;
              for (t = 3;t<=DataGridView1.Columns.Count -5 ;t++)
              {
                  string g = DataGridView1.Columns[t].HeaderText.ToString();

                 DateTime d;
                d = DateTime.Parse(DataGridView1.Columns[t].HeaderText);
                if (g.CompareTo(a)==0)
                {
                    int i;
                    for (i = 0 ;i<= DataGridView1.Rows.Count - 1;i++)
                    {
                        DataGridView1.Rows[i].Cells[t].Value = true;
                    }
                }
              }
            }
        else
            {
             int t;
             for(t = 3 ;t<=DataGridView1.Columns.Count -5;t++)
                {
                DateTime d;
                d = DateTime.Parse(DataGridView1.Columns[t].HeaderText);
                string g = DataGridView1.Columns[t].HeaderText.ToString();
                if (g.CompareTo(a)==0)
                    {
                     int i;
                     for (i = 0 ;i<= DataGridView1.Rows.Count - 1;i++)
                        {
                            DataGridView1.Rows[i].Cells[t].Value = false;
                        }
                    }
                }
            }
        }

        private void CheckedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

                


    }
}
