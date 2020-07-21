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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(testing));
            this.panelReport = new System.Windows.Forms.Panel();
            this.btnCari = new Bunifu.Framework.UI.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTahun = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBulan = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbReparasi = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBeliKomponen = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbRestockKomponen = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbRestockAlat = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.reportRestockAlat = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.panelReport.Controls.Add(this.btnCari);
            this.panelReport.Controls.Add(this.label7);
            this.panelReport.Controls.Add(this.cmbTahun);
            this.panelReport.Controls.Add(this.label6);
            this.panelReport.Controls.Add(this.cmbBulan);
            this.panelReport.Controls.Add(this.flowLayoutPanel1);
            this.panelReport.Controls.Add(this.bunifuMaterialTextbox1);
            this.panelReport.Controls.Add(this.reportRestockAlat);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 0);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(1364, 705);
            this.panelReport.TabIndex = 5;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.btnCari.Image = ((System.Drawing.Image)(resources.GetObject("btnCari.Image")));
            this.btnCari.ImageActive = null;
            this.btnCari.Location = new System.Drawing.Point(1159, 3);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(32, 33);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCari.TabIndex = 17;
            this.btnCari.TabStop = false;
            this.btnCari.Zoom = 10;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1007, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tahun";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTahun
            // 
            this.cmbTahun.FormattingEnabled = true;
            this.cmbTahun.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.cmbTahun.Location = new System.Drawing.Point(1068, 8);
            this.cmbTahun.Name = "cmbTahun";
            this.cmbTahun.Size = new System.Drawing.Size(69, 21);
            this.cmbTahun.TabIndex = 15;
            this.cmbTahun.Text = "- Tahun -";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(823, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bulan";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBulan
            // 
            this.cmbBulan.FormattingEnabled = true;
            this.cmbBulan.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cmbBulan.Location = new System.Drawing.Point(899, 8);
            this.cmbBulan.Name = "cmbBulan";
            this.cmbBulan.Size = new System.Drawing.Size(102, 21);
            this.cmbBulan.TabIndex = 13;
            this.cmbBulan.Text = "- Bulan -";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.rbReparasi);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.rbBeliKomponen);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.rbRestockKomponen);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.rbRestockAlat);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 33);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Laporan :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbReparasi
            // 
            this.rbReparasi.Checked = true;
            this.rbReparasi.Location = new System.Drawing.Point(79, 3);
            this.rbReparasi.Name = "rbReparasi";
            this.rbReparasi.Size = new System.Drawing.Size(18, 27);
            this.rbReparasi.TabIndex = 13;
            this.rbReparasi.TabStop = true;
            this.rbReparasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbReparasi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reparasi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbBeliKomponen
            // 
            this.rbBeliKomponen.Location = new System.Drawing.Point(179, 3);
            this.rbBeliKomponen.Name = "rbBeliKomponen";
            this.rbBeliKomponen.Size = new System.Drawing.Size(18, 27);
            this.rbBeliKomponen.TabIndex = 14;
            this.rbBeliKomponen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBeliKomponen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Beli Komponen";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbRestockKomponen
            // 
            this.rbRestockKomponen.Location = new System.Drawing.Point(321, 3);
            this.rbRestockKomponen.Name = "rbRestockKomponen";
            this.rbRestockKomponen.Size = new System.Drawing.Size(18, 27);
            this.rbRestockKomponen.TabIndex = 15;
            this.rbRestockKomponen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRestockKomponen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(345, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Restock Komponen";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbRestockAlat
            // 
            this.rbRestockAlat.Location = new System.Drawing.Point(489, 3);
            this.rbRestockAlat.Name = "rbRestockAlat";
            this.rbRestockAlat.Size = new System.Drawing.Size(18, 27);
            this.rbRestockAlat.TabIndex = 16;
            this.rbRestockAlat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRestockAlat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(513, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Restock Alat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(1364, 41);
            this.bunifuMaterialTextbox1.TabIndex = 2;
            this.bunifuMaterialTextbox1.TabStop = false;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reportRestockAlat
            // 
            this.reportRestockAlat.LocalReport.ReportEmbeddedResource = "CRUD.Laporan.PenjualanKomponen.rdlc";
            this.reportRestockAlat.Location = new System.Drawing.Point(125, 48);
            this.reportRestockAlat.Name = "reportRestockAlat";
            this.reportRestockAlat.ServerReport.BearerToken = null;
            this.reportRestockAlat.Size = new System.Drawing.Size(643, 617);
            this.reportRestockAlat.TabIndex = 20;
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
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel panelReport;
        private Bunifu.Framework.UI.BunifuImageButton btnCari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTahun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBulan;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbReparasi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbBeliKomponen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbRestockKomponen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbRestockAlat;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportRestockAlat;
    }
}