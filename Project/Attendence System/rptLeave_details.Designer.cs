namespace Attendence_System
{
    partial class rptLeave_details
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
            this.leave_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.leaveDataSet = new Attendence_System.leaveDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.leave_detailsTableAdapter = new Attendence_System.leaveDataSetTableAdapters.leave_detailsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.leave_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // leave_detailsBindingSource
            // 
            this.leave_detailsBindingSource.DataMember = "leave_details";
            this.leave_detailsBindingSource.DataSource = this.leaveDataSet;
            // 
            // leaveDataSet
            // 
            this.leaveDataSet.DataSetName = "leaveDataSet";
            this.leaveDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "leaveDataSet_leave_details";
            reportDataSource1.Value = this.leave_detailsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Attendence_System.Leave_details Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(292, 266);
            this.reportViewer1.TabIndex = 0;
            // 
            // leave_detailsTableAdapter
            // 
            this.leave_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // rptLeave_details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptLeave_details";
            this.Text = "Leave_details Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptLeave_details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.leave_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leaveDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource leave_detailsBindingSource;
        private leaveDataSet leaveDataSet;
        private Attendence_System.leaveDataSetTableAdapters.leave_detailsTableAdapter leave_detailsTableAdapter;
    }
}