namespace Attendence_System
{
    partial class rpt_1
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
            this.Database1DataSet8 = new Attendence_System.Database1DataSet8();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.attendanceTableAdapter = new Attendence_System.Database1DataSet8TableAdapters.attendanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet8)).BeginInit();
            this.SuspendLayout();
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "attendance";
            this.attendanceBindingSource.DataSource = this.Database1DataSet8;
            // 
            // Database1DataSet8
            // 
            this.Database1DataSet8.DataSetName = "Database1DataSet8";
            this.Database1DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Database1DataSet8_attendance";
            reportDataSource1.Value = this.attendanceBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Attendence_System.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(292, 266);
            this.reportViewer1.TabIndex = 0;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // rpt_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rpt_1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rpt_1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet8)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
        private Database1DataSet8 Database1DataSet8;
        private Attendence_System.Database1DataSet8TableAdapters.attendanceTableAdapter attendanceTableAdapter;
    }
}