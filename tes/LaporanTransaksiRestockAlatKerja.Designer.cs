namespace CRUD
{
    partial class LaporanTransaksiRestockAlatKerja
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.label1 = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtFrom = new System.Windows.Forms.DateTimePicker();
            this.dtTo = new System.Windows.Forms.DateTimePicker();
            this.trestockalatkerjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dstRestockAlatKerja = new CRUD.dstRestockAlatKerja();
            this.trestockalatkerjaTableAdapter = new CRUD.dstRestockAlatKerjaTableAdapters.trestockalatkerjaTableAdapter();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trestockalatkerjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstRestockAlatKerja)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(177, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(440, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Laporan Transaksi Restock Alat Kerja";
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "dsRestockAlatKerja";
            reportDataSource1.Value = this.trestockalatkerjaBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CRUD.rwRestockAlatKerja.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(80, 109);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(634, 490);
            this.reportViewer1.TabIndex = 1;
            // 
            // dtFrom
            // 
            this.dtFrom.Location = new System.Drawing.Point(157, 83);
            this.dtFrom.Name = "dtFrom";
            this.dtFrom.Size = new System.Drawing.Size(200, 20);
            this.dtFrom.TabIndex = 2;
            this.dtFrom.ValueChanged += new System.EventHandler(this.dtFrom_ValueChanged);
            // 
            // dtTo
            // 
            this.dtTo.Location = new System.Drawing.Point(521, 83);
            this.dtTo.Name = "dtTo";
            this.dtTo.Size = new System.Drawing.Size(200, 20);
            this.dtTo.TabIndex = 3;
            this.dtTo.ValueChanged += new System.EventHandler(this.dtTo_ValueChanged);
            // 
            // trestockalatkerjaBindingSource
            // 
            this.trestockalatkerjaBindingSource.DataMember = "trestockalatkerja";
            this.trestockalatkerjaBindingSource.DataSource = this.dstRestockAlatKerja;
            // 
            // dstRestockAlatKerja
            // 
            this.dstRestockAlatKerja.DataSetName = "dstRestockAlatKerja";
            this.dstRestockAlatKerja.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // trestockalatkerjaTableAdapter
            // 
            this.trestockalatkerjaTableAdapter.ClearBeforeFill = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dari Tanggal : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(422, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sampai Tanggal : ";
            // 
            // LaporanTransaksiRestockAlatKerja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtTo);
            this.Controls.Add(this.dtFrom);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.label1);
            this.Name = "LaporanTransaksiRestockAlatKerja";
            this.Size = new System.Drawing.Size(795, 625);
            ((System.ComponentModel.ISupportInitialize)(this.trestockalatkerjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dstRestockAlatKerja)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource trestockalatkerjaBindingSource;
        private dstRestockAlatKerja dstRestockAlatKerja;
        private dstRestockAlatKerjaTableAdapters.trestockalatkerjaTableAdapter trestockalatkerjaTableAdapter;
        private System.Windows.Forms.DateTimePicker dtFrom;
        private System.Windows.Forms.DateTimePicker dtTo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
