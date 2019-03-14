using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Attendence_System
{
    public partial class MDIParent1 : Form
    {
        

        public MDIParent1()
        {
            InitializeComponent();
        }

        

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin log = new frmLogin();
            //log.MdiParent = this;
            log.ShowDialog ();
 
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");

        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");

        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("sol.exe");

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.Text == "Welcome To Attendance System   Devlop By.  Reena And Aarti")
            {
                this.Text = " Date : " + DateTime.Now.ToLongDateString();
            }
            else
            {
                this.Text = "Welcome To Attendance System   Devlop By.  Reena And Aarti";
            }

        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void notepadToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void createNewUserToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmCreateNewUser creat = new frmCreateNewUser();
            creat.MdiParent = this;
            creat.Show();
        }

        private void exitFromSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("calc.exe");


        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("notepad.exe");


        }

        private void gameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("sol.exe");

        }

        private void changePasswordToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmChangePassword chang = new frmChangePassword();
            chang.MdiParent = this;
            chang.Show();

        }

        

        private void deToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendance  Attn = new frmAttendance();
            Attn.MdiParent = this;
            Attn.Show();

        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment  Dep = new frmDepartment ();
            Dep.MdiParent = this;
            Dep.Show();

        }

        private void holidayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee  emp = new frmEmployee ();
            emp.MdiParent = this;
            emp.Show();

        }

        private void leaveDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoliday  holi = new frmHoliday ();
            holi.MdiParent = this;
            holi.Show();

        }

        private void salaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void scaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void workingdayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeave  leave = new frmLeave();
            leave.MdiParent = this;
            leave.Show();

        }

        private void attendanceListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAttendance_List Attn_list = new frmAttendance_List();
            Attn_list.MdiParent = this;
            Attn_list.Show();

        }

        private void departmentListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDepartment_List dep_list = new frmDepartment_List();
            dep_list.MdiParent = this;
            dep_list.Show();

        }

        private void employeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee_List emp_list = new frmEmployee_List();
            emp_list.MdiParent = this;
            emp_list.Show();

        }

        private void holidayListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoliday_List holi_list = new frmHoliday_List();
            holi_list.MdiParent = this;
            holi_list.Show();


        }

        private void leaveListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLeave_List leave_list = new frmLeave_List();
            leave_list.MdiParent = this;
            leave_list.Show();

        }

        private void salaryListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSalary_List salary_list = new frmSalary_List();
            salary_list.MdiParent = this;
            salary_list.Show();

        }

        private void scaleListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmScale_List scale_list = new frmScale_List();
            scale_list.MdiParent = this;
            scale_list.Show();

        }

        private void workingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWorking_List working_list = new frmWorking_List();
            working_list.MdiParent = this;
            working_list.Show();

        }

        

        

        private void salaryToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSalary salary = new frmSalary();
            salary.MdiParent = this;
            salary.Show();

        }

        private void scaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmScale Scale = new frmScale();
            Scale.MdiParent = this;
            Scale.Show();

        }

        private void attendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
             rpt_1 ratt = new rpt_1();
             ratt.ShowDialog();
        }

        private void departmentReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptDepartment dep = new rptDepartment();
            dep.ShowDialog();

        }

        private void employeeReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptEmployee emp1 = new rptEmployee();
            emp1.ShowDialog();
        }

        private void holidayReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptHoliday holi = new rptHoliday();
            holi.ShowDialog();
        }

        private void leaveReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptLeave_details leave = new rptLeave_details();
            leave.ShowDialog();
        }

        private void salaryReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptSalary salary = new rptSalary();
            salary.ShowDialog();
        }

        private void scaleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptScale scale = new rptScale();
            scale.ShowDialog();
        }

        private void workingReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rptWorkingday work = new rptWorkingday();
            work.ShowDialog();
        }

        private void systemLockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSystemlock system = new frmSystemlock();
            
            system.ShowDialog();
        }

        private void exitFromSystemToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmexit exit = new frmexit();
            exit.MdiParent = this;
            exit.Show();
        }

       
        

        private void workingdayToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmWorking work = new frmWorking();
            work.MdiParent = this;
            work.Show();
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAttendance_List al = new frmAttendance_List();
            al.MdiParent = this;
            al.Show();
        }


    }
}
