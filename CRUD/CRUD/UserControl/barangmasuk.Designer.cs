namespace CRUD
{
    partial class barangmasuk
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
            this.label1 = new System.Windows.Forms.Label();
            this.tableRestock = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnSukses = new System.Windows.Forms.Button();
            this.btnGagal = new System.Windows.Forms.Button();
            this.cmbSortir = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNomor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tableRestock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "Data Restock";
            // 
            // tableRestock
            // 
            this.tableRestock.AllowUserToAddRows = false;
            this.tableRestock.AllowUserToDeleteRows = false;
            this.tableRestock.BackgroundColor = System.Drawing.Color.Snow;
            this.tableRestock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableRestock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column1,
            this.Column2});
            this.tableRestock.Location = new System.Drawing.Point(208, 62);
            this.tableRestock.Name = "tableRestock";
            this.tableRestock.ReadOnly = true;
            this.tableRestock.Size = new System.Drawing.Size(578, 267);
            this.tableRestock.TabIndex = 27;
            this.tableRestock.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableRestock_CellClick);
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.HeaderText = "No";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn5.HeaderText = "Tanggal";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Jenis Komponen";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Total Barang";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Harga";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // tableDetail
            // 
            this.tableDetail.AllowUserToAddRows = false;
            this.tableDetail.AllowUserToDeleteRows = false;
            this.tableDetail.BackgroundColor = System.Drawing.Color.Snow;
            this.tableDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tableDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.tableDetail.Location = new System.Drawing.Point(792, 140);
            this.tableDetail.Name = "tableDetail";
            this.tableDetail.ReadOnly = true;
            this.tableDetail.Size = new System.Drawing.Size(560, 189);
            this.tableDetail.TabIndex = 29;
            this.tableDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDetail_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Tanggal";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.HeaderText = "Jenis Komponen";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Total Barang";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Harga";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // btnCheck
            // 
            this.btnCheck.Location = new System.Drawing.Point(792, 62);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(86, 72);
            this.btnCheck.TabIndex = 30;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSukses
            // 
            this.btnSukses.Location = new System.Drawing.Point(1111, 103);
            this.btnSukses.Name = "btnSukses";
            this.btnSukses.Size = new System.Drawing.Size(241, 31);
            this.btnSukses.TabIndex = 31;
            this.btnSukses.Text = "Sukses";
            this.btnSukses.UseVisualStyleBackColor = true;
            this.btnSukses.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGagal
            // 
            this.btnGagal.Location = new System.Drawing.Point(884, 103);
            this.btnGagal.Name = "btnGagal";
            this.btnGagal.Size = new System.Drawing.Size(221, 31);
            this.btnGagal.TabIndex = 32;
            this.btnGagal.Text = "Gagal";
            this.btnGagal.UseVisualStyleBackColor = true;
            this.btnGagal.Click += new System.EventHandler(this.btnGagal_Click);
            // 
            // cmbSortir
            // 
            this.cmbSortir.FormattingEnabled = true;
            this.cmbSortir.Items.AddRange(new object[] {
            "Semua",
            "Terkonfirmasi",
            "Belum dikonfirmasi",
            "Gagal"});
            this.cmbSortir.Location = new System.Drawing.Point(651, 39);
            this.cmbSortir.Name = "cmbSortir";
            this.cmbSortir.Size = new System.Drawing.Size(135, 21);
            this.cmbSortir.TabIndex = 33;
            this.cmbSortir.Text = "- Pilih Sortir -";
            this.cmbSortir.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(882, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 14);
            this.label2.TabIndex = 34;
            this.label2.Text = "KONFIRMASI DETAIL NOMOR :";
            // 
            // lblNomor
            // 
            this.lblNomor.AutoSize = true;
            this.lblNomor.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomor.Location = new System.Drawing.Point(1049, 75);
            this.lblNomor.Name = "lblNomor";
            this.lblNomor.Size = new System.Drawing.Size(58, 14);
            this.lblNomor.TabIndex = 35;
            this.lblNomor.Text = "[NOMOR]";
            // 
            // barangmasuk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.lblNomor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbSortir);
            this.Controls.Add(this.btnGagal);
            this.Controls.Add(this.btnSukses);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.tableDetail);
            this.Controls.Add(this.tableRestock);
            this.Controls.Add(this.label1);
            this.Name = "barangmasuk";
            this.Size = new System.Drawing.Size(1362, 528);
            ((System.ComponentModel.ISupportInitialize)(this.tableRestock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableRestock;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridView tableDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnSukses;
        private System.Windows.Forms.Button btnGagal;
        private System.Windows.Forms.ComboBox cmbSortir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNomor;
    }
}
