namespace Attendence_System
{
    partial class rptScale
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
            this.scaleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departmentDataSet = new Attendence_System.departmentDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.scaleTableAdapter = new Attendence_System.departmentDataSetTableAdapters.scaleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.scaleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // scaleBindingSource
            // 
            this.scaleBindingSource.DataMember = "scale";
            this.scaleBindingSource.DataSource = this.departmentDataSet;
            // 
            // departmentDataSet
            // 
            this.departmentDataSet.DataSetName = "departmentDataSet";
            this.departmentDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "departmentDataSet_scale";
            reportDataSource1.Value = this.scaleBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Attendence_System.Scale Report.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(292, 266);
            this.reportViewer1.TabIndex = 0;
            // 
            // scaleTableAdapter
            // 
            this.scaleTableAdapter.ClearBeforeFill = true;
            // 
            // rptScale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 266);
            this.Controls.Add(this.reportViewer1);
            this.Name = "rptScale";
            this.Text = "Scale Report";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.rptScale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.scaleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departmentDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource scaleBindingSource;
        private departmentDataSet departmentDataSet;
        private Attendence_System.departmentDataSetTableAdapters.scaleTableAdapter scaleTableAdapter;
    }
}