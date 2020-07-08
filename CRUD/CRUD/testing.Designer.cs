namespace CRUD
{
    partial class testing
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.panelReport = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lbelikomponenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Report = new CRUD.Report();
            this.lrestock1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lrestock1TableAdapter = new CRUD.ReportTableAdapters.lrestock1TableAdapter();
            this.lbelikomponenTableAdapter = new CRUD.ReportTableAdapters.lbelikomponenTableAdapter();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lbelikomponenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrestock1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelReport.Controls.Add(this.reportViewer2);
            this.panelReport.Controls.Add(this.reportViewer1);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 0);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(1364, 705);
            this.panelReport.TabIndex = 5;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "BeliKomponen";
            reportDataSource1.Value = this.lbelikomponenBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CRUD.ReportBeliKomponen.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1203, 617);
            this.reportViewer2.TabIndex = 1;
            // 
            // reportViewer1
            // 
            reportDataSource2.Name = "Restock";
            reportDataSource2.Value = this.lrestock1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD.ReportRestock1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(700, 27);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(543, 632);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Visible = false;
            // 
            // lbelikomponenBindingSource
            // 
            this.lbelikomponenBindingSource.DataMember = "lbelikomponen";
            this.lbelikomponenBindingSource.DataSource = this.Report;
            // 
            // Report
            // 
            this.Report.DataSetName = "Report";
            this.Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lrestock1BindingSource
            // 
            this.lrestock1BindingSource.DataMember = "lrestock1";
            this.lrestock1BindingSource.DataSource = this.Report;
            // 
            // lrestock1TableAdapter
            // 
            this.lrestock1TableAdapter.ClearBeforeFill = true;
            // 
            // lbelikomponenTableAdapter
            // 
            this.lbelikomponenTableAdapter.ClearBeforeFill = true;
            // 
            // testing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1364, 705);
            this.Controls.Add(this.panelReport);
            this.Name = "testing";
            this.Text = "testing";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.testing_Load);
            this.panelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lbelikomponenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrestock1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelReport;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Report Report;
        private System.Windows.Forms.BindingSource lrestock1BindingSource;
        private ReportTableAdapters.lrestock1TableAdapter lrestock1TableAdapter;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource lbelikomponenBindingSource;
        private ReportTableAdapters.lbelikomponenTableAdapter lbelikomponenTableAdapter;
    }
}