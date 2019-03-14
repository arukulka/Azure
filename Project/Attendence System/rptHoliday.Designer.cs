namespace Attendence_System
{
    partial class rptHoliday
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
            this.holidayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Database1DataSet = new Attendence_System.Database1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.holidayTableAdapter = new Attendence_System.Database1DataSetTableAdapters.holidayTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.holidayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // holidayBindingSource
            // 
            this.holidayBindingSource.DataMember = "holiday";
            this.holidayBindingSource.DataSource = this.Database1DataSet;
            // 
            // Database1DataSet
            // 
            this.Database1DataSet.DataSetName = "Database1DataSet";
            this.Database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Database1DataSet_holiday";
            reportDataSource1.Value = this.holidayBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Attendence_System.Holiday Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(292, 266);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.UseWaitCursor = true;
            // 
            // holidayTableAdapter
            // 
            this.holidayTableAdapter.ClearBeforeFill = true;
            // 
            // rptHoliday
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptHoliday";
            this.Text = "Holiday Report";
            this.UseWaitCursor = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptHoliday_Load);
            ((System.ComponentModel.ISupportInitialize)(this.holidayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource holidayBindingSource;
        private Database1DataSet Database1DataSet;
        private Attendence_System.Database1DataSetTableAdapters.holidayTableAdapter holidayTableAdapter;
    }
}