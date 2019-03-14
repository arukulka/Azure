using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;




namespace Attendence_System
{
    static class Program
    {
        public static Boolean flag = false;
        public static bool login = false;
        public static string password = "online";
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            //Application.Run(new rpt_1());

            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmsplash());
            Application.Run(new frmLogin());
            if (flag == true)
            { Application.Run(new MDIParent1()); }
            //Application.Run(new Attendance());
            //Application.Run(new frmAttendence());
            //Application.Run(new frmAttendance_List());
            //Application.Run(new frmChangePassword());
            //Application.Run(new frmCreateNewUser());

            //Application.Run(new frmDepartment());
            //Application.Run(new frmDepartment_List());
            //Application.Run(new frmEmployee());
            //Application.Run(new frmEmployee_List());
            //Application.Run(new frmHoliday());
            //Application.Run(new frmHoliday_List());
            //Application.Run(new frmLeave());
            //Application.Run(new frmLeave_List());
            //Application.Run(new frmSalary());
            //Application.Run(new frmSalary_List());
            //Application.Run(new frmScale());
            //Application.Run(new frmScale_List());
            //Application.Run(new frmWorking());
            //Application.Run(new frmWorking_List());

            //Application.Run(new rpt_employee());







        }

    }
}

