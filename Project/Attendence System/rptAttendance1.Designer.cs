namespace Attendence_System
{
    partial class rptAttendance1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet7 = new Attendence_System.Database1DataSet7();
            this.attendenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentDataSet = new Attendence_System.departmentDataSet();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet2 = new Attendence_System.Database1DataSet2();
            this.employeeTableAdapter = new Attendence_System.Database1DataSet2TableAdapters.employeeTableAdapter();
            this.attendenceTableAdapter = new Attendence_System.departmentDataSetTableAdapters.attendenceTableAdapter();
            this.attendanceTableAdapter = new Attendence_System.Database1DataSet7TableAdapters.attendanceTableAdapter();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet = new Attendence_System.Database1DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "attendance";
            this.attendanceBindingSource.DataSource = this.Database1DataSet7;
            // 
            // Database1DataSet7
            // 
            this.Database1DataSet7.DataSetName = "Database1DataSet7";
            this.Database1DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendenceBindingSource
            // 
            this.attendenceBindingSource.DataMember = "attendence";
            this.attendenceBindingSource.DataSource = this.departmentDataSet;
            // 
            // departmentDataSet
            // 
            this.departmentDataSet.DataSetName = "departmentDataSet";
            this.departmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "employee";
            this.employeeBindingSource.DataSource = this.Database1DataSet2;
            // 
            // Database1DataSet2
            // 
            this.Database1DataSet2.DataSetName = "Database1DataSet2";
            this.Database1DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // attendenceTableAdapter
            // 
            this.attendenceTableAdapter.ClearBeforeFill = true;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Database1DataSet_attendence";
            reportDataSource1.Value = this.attendenceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Attendence_System.Attendance Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(292, 266);
            this.reportViewer1.TabIndex = 0;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rptAttendance1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptAttendance1";
            this.Text = "Attendance Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptAttendance1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource employeeBindingSource;
        private Database1DataSet2 Database1DataSet2;
        private Attendence_System.Database1DataSet2TableAdapters.employeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.BindingSource attendenceBindingSource;
        private departmentDataSet departmentDataSet;
        private Attendence_System.departmentDataSetTableAdapters.attendenceTableAdapter attendenceTableAdapter;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private Database1DataSet7 Database1DataSet7;
        private Attendence_System.Database1DataSet7TableAdapters.attendanceTableAdapter attendanceTableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Database1DataSet Database1DataSet;
    }
}