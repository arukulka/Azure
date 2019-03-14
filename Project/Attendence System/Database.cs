using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
namespace Attendence_System
{
    class Database
    {
     string cnStr  = @"Data Source=.\SQLEXPRESS;AttachDbFilename=|Datadirectory|\Database1.mdf;Integrated Security=True;User Instance=True";
     SqlConnection con;
     SqlCommand cmd;
     SqlDataAdapter dap;
     DataTable dt;

        public void ConOpen()
        {
         con = new SqlConnection(cnStr);   
         con.Open();
        }
        public void ConClose()
        {            
            con.Close();
        }

        public void Insert(string query)
        {
            cmd =new SqlCommand(query,con);
            cmd.ExecuteNonQuery();
        }

        public void Delete(string query)
        {
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }


        public void Update(string query)
        {
            cmd = new SqlCommand(query, con);
            cmd.ExecuteNonQuery();
        }

        public int getUniqueID(string query)
        {
            int a;
            
            cmd=new SqlCommand(query,con);
            object c = cmd.ExecuteScalar();
            
            if( c.ToString() != "" )
            {
                a=Int32.Parse(c.ToString());
                a = a + 1;
            }

            else
            {
                a=1;
            }
            return a;            
        }

        public string getName(string query )
        {
            string a;        
            cmd=new SqlCommand(query,con);
        a = cmd.ExecuteScalar().ToString() ;
        return a;

        }


        public string getMark(string query)
        {
            string a;
            cmd = new SqlCommand(query, con);
            a = cmd.ExecuteScalar().ToString();
            return a;
        }

        public DataTable DisplayGrid(string query)
        {
           cmd=new SqlCommand(query,con);
           dap=new SqlDataAdapter(cmd);           
           dt = new DataTable();
           dap.Fill(dt);
           return dt;
        }


        public string getRollNo(string query)
        {
            string a;

            cmd = new SqlCommand(query, con);
            a = cmd.ExecuteScalar().ToString();

            if (a.ToString() != "")
            {
                a = a.ToString();
                a = a + 1;
            }

            else
            {
                a = "1";
            }
            return a;    
        }





    }

    
}
