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
            this.lreparasialatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Report = new CRUD.Report();
            this.lrestock1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lbelikomponenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelReport = new System.Windows.Forms.Panel();
            this.lrestock1TableAdapter = new CRUD.ReportTableAdapters.lrestock1TableAdapter();
            this.lbelikomponenTableAdapter = new CRUD.ReportTableAdapters.lbelikomponenTableAdapter();
            this.lreparasialatTableAdapter = new CRUD.ReportTableAdapters.lreparasialatTableAdapter();
            this.lrestockalatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lrestockalatTableAdapter = new CRUD.ReportTableAdapters.lrestockalatTableAdapter();
            this.bKomponen1 = new CRUD.UCBaru.BKomponen();
            ((System.ComponentModel.ISupportInitialize)(this.lreparasialatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrestock1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbelikomponenBindingSource)).BeginInit();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lrestockalatBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lreparasialatBindingSource
            // 
            this.lreparasialatBindingSource.DataMember = "lreparasialat";
            this.lreparasialatBindingSource.DataSource = this.Report;
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
            // lbelikomponenBindingSource
            // 
            this.lbelikomponenBindingSource.DataMember = "lbelikomponen";
            this.lbelikomponenBindingSource.DataSource = this.Report;
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelReport.Controls.Add(this.bKomponen1);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 0);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(1364, 705);
            this.panelReport.TabIndex = 5;
            // 
            // lrestock1TableAdapter
            // 
            this.lrestock1TableAdapter.ClearBeforeFill = true;
            // 
            // lbelikomponenTableAdapter
            // 
            this.lbelikomponenTableAdapter.ClearBeforeFill = true;
            // 
            // lreparasialatTableAdapter
            // 
            this.lreparasialatTableAdapter.ClearBeforeFill = true;
            // 
            // lrestockalatBindingSource
            // 
            this.lrestockalatBindingSource.DataMember = "lrestockalat";
            this.lrestockalatBindingSource.DataSource = this.Report;
            // 
            // lrestockalatTableAdapter
            // 
            this.lrestockalatTableAdapter.ClearBeforeFill = true;
            // 
            // bKomponen1
            // 
            this.bKomponen1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bKomponen1.Location = new System.Drawing.Point(46, 18);
            this.bKomponen1.Name = "bKomponen1";
            this.bKomponen1.Size = new System.Drawing.Size(1201, 675);
            this.bKomponen1.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.lreparasialatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lrestock1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbelikomponenBindingSource)).EndInit();
            this.panelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lrestockalatBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelReport;
        private Report Report;
        private System.Windows.Forms.BindingSource lrestock1BindingSource;
        private ReportTableAdapters.lrestock1TableAdapter lrestock1TableAdapter;
        private System.Windows.Forms.BindingSource lbelikomponenBindingSource;
        private ReportTableAdapters.lbelikomponenTableAdapter lbelikomponenTableAdapter;
        private System.Windows.Forms.BindingSource lreparasialatBindingSource;
        private ReportTableAdapters.lreparasialatTableAdapter lreparasialatTableAdapter;
        private System.Windows.Forms.BindingSource lrestockalatBindingSource;
        private ReportTableAdapters.lrestockalatTableAdapter lrestockalatTableAdapter;
        private UCBaru.BKomponen bKomponen1;
    }
}