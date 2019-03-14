namespace Attendence_System
{
    partial class rptAttendance
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
            this.attendenceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentDataSet = new Attendence_System.departmentDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.attendenceTableAdapter = new Attendence_System.departmentDataSetTableAdapters.attendenceTableAdapter();
            this.R_attenanceDataSet = new Attendence_System.R_attenanceDataSet();
            this.Database1DataSet = new Attendence_System.Database1DataSet();
            this.holidayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.holidayTableAdapter = new Attendence_System.Database1DataSetTableAdapters.holidayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.attendenceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_attenanceDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "departmentDataSet_attendence";
            reportDataSource1.Value = this.attendenceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Attendence_System.Attenance Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(292, 266);
            this.reportViewer1.TabIndex = 0;
            // 
            // attendenceTableAdapter
            // 
            this.attendenceTableAdapter.ClearBeforeFill = true;
            // 
            // R_attenanceDataSet
            // 
            this.R_attenanceDataSet.DataSetName = "R_attenanceDataSet";
            this.R_attenanceDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // holidayBindingSource
            // 
            this.holidayBindingSource.DataMember = "holiday";
            this.holidayBindingSource.DataSource = this.Database1DataSet;
            // 
            // holidayTableAdapter
            // 
            this.holidayTableAdapter.ClearBeforeFill = true;
            // 
            // rptAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptAttendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendenceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.R_attenanceDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.holidayBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource attendenceBindingSource;
        private departmentDataSet departmentDataSet;
        private Attendence_System.departmentDataSetTableAdapters.attendenceTableAdapter attendenceTableAdapter;
        private R_attenanceDataSet R_attenanceDataSet;
        private System.Windows.Forms.BindingSource holidayBindingSource;
        private Database1DataSet Database1DataSet;
        private Attendence_System.Database1DataSetTableAdapters.holidayTableAdapter holidayTableAdapter;
    }
}