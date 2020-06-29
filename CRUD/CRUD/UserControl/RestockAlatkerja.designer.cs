namespace CRUD
{
    partial class RestockAlatKerja
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
            this.tbTransaksi = new System.Windows.Forms.DataGridView();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBayar = new System.Windows.Forms.Button();
            this.tbSupplier = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplier = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.tbAlatKerja = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.blbHargaTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.lblAlatKerja = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.pnlDataTransaksi = new System.Windows.Forms.Panel();
            this.label20 = new System.Windows.Forms.Label();
            this.btnTambahPelayan = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPelayan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSupplier)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlatKerja)).BeginInit();
            this.pnlDataTransaksi.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbTransaksi
            // 
            this.tbTransaksi.AllowUserToAddRows = false;
            this.tbTransaksi.AllowUserToDeleteRows = false;
            this.tbTransaksi.BackgroundColor = System.Drawing.Color.Snow;
            this.tbTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column2,
            this.Supplier,
            this.harga,
            this.jumlah,
            this.total_harga});
            this.tbTransaksi.Location = new System.Drawing.Point(833, 109);
            this.tbTransaksi.Name = "tbTransaksi";
            this.tbTransaksi.ReadOnly = true;
            this.tbTransaksi.Size = new System.Drawing.Size(502, 312);
            this.tbTransaksi.TabIndex = 0;
            this.tbTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbTransaksi_CellClick);
            // 
            // No
            // 
            this.No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.No.HeaderText = "No";
            this.No.Name = "No";
            this.No.ReadOnly = true;
            this.No.Width = 46;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Komponen";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Supplier
            // 
            this.Supplier.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.ReadOnly = true;
            // 
            // harga
            // 
            this.harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.harga.HeaderText = "Harga Satuan";
            this.harga.Name = "harga";
            this.harga.ReadOnly = true;
            // 
            // jumlah
            // 
            this.jumlah.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jumlah.HeaderText = "Jumlah";
            this.jumlah.Name = "jumlah";
            this.jumlah.ReadOnly = true;
            // 
            // total_harga
            // 
            this.total_harga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.total_harga.HeaderText = "Total";
            this.total_harga.Name = "total_harga";
            this.total_harga.ReadOnly = true;
            // 
            // btnBayar
            // 
            this.btnBayar.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.Location = new System.Drawing.Point(1169, 441);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(166, 46);
            this.btnBayar.TabIndex = 5;
            this.btnBayar.Text = "Proses Transaksi";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // tbSupplier
            // 
            this.tbSupplier.AllowUserToAddRows = false;
            this.tbSupplier.AllowUserToDeleteRows = false;
            this.tbSupplier.BackgroundColor = System.Drawing.Color.Snow;
            this.tbSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbSupplier.Location = new System.Drawing.Point(234, 288);
            this.tbSupplier.Name = "tbSupplier";
            this.tbSupplier.ReadOnly = true;
            this.tbSupplier.Size = new System.Drawing.Size(586, 182);
            this.tbSupplier.TabIndex = 6;
            this.tbSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbSupplier_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "Supplier";
            // 
            // txtSupplier
            // 
            this.txtSupplier.Location = new System.Drawing.Point(4, 30);
            this.txtSupplier.Name = "txtSupplier";
            this.txtSupplier.ReadOnly = true;
            this.txtSupplier.Size = new System.Drawing.Size(119, 20);
            this.txtSupplier.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Jumlah";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(4, 75);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.ReadOnly = true;
            this.txtJumlah.Size = new System.Drawing.Size(52, 20);
            this.txtJumlah.TabIndex = 10;
            this.txtJumlah.Text = "0";
            this.txtJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(62, 69);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 31);
            this.btnPlus.TabIndex = 11;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMin.Location = new System.Drawing.Point(93, 69);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(30, 31);
            this.btnMin.TabIndex = 12;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnBatal);
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.txtSupplier);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtJumlah);
            this.panel1.Location = new System.Drawing.Point(701, 83);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(126, 182);
            this.panel1.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(73, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(50, 23);
            this.btnReset.TabIndex = 15;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Enabled = false;
            this.btnBatal.Location = new System.Drawing.Point(4, 144);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(52, 23);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(4, 115);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(119, 23);
            this.btnTambah.TabIndex = 13;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // tbAlatKerja
            // 
            this.tbAlatKerja.AllowUserToAddRows = false;
            this.tbAlatKerja.AllowUserToDeleteRows = false;
            this.tbAlatKerja.BackgroundColor = System.Drawing.Color.Snow;
            this.tbAlatKerja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbAlatKerja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.Column3,
            this.Column1});
            this.tbAlatKerja.Location = new System.Drawing.Point(234, 39);
            this.tbAlatKerja.Name = "tbAlatKerja";
            this.tbAlatKerja.ReadOnly = true;
            this.tbAlatKerja.Size = new System.Drawing.Size(461, 182);
            this.tbAlatKerja.TabIndex = 14;
            this.tbAlatKerja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbAlatKerja_CellClick);
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
            this.dataGridViewTextBoxColumn5.HeaderText = "Alat Kerja";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Jumlah";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Jumlah Rusak";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Jumlah Bagus";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data Alat Kerja";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(133, 25);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(829, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data Transaksi";
            // 
            // blbHargaTotal
            // 
            this.blbHargaTotal.AutoSize = true;
            this.blbHargaTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbHargaTotal.Location = new System.Drawing.Point(826, 462);
            this.blbHargaTotal.Name = "blbHargaTotal";
            this.blbHargaTotal.Size = new System.Drawing.Size(36, 25);
            this.blbHargaTotal.TabIndex = 19;
            this.blbHargaTotal.Text = "Rp";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(826, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "TOTAL HARGA";
            // 
            // btnCari
            // 
            this.btnCari.Enabled = false;
            this.btnCari.Location = new System.Drawing.Point(701, 38);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 25);
            this.btnCari.TabIndex = 20;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // lblAlatKerja
            // 
            this.lblAlatKerja.AutoSize = true;
            this.lblAlatKerja.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlatKerja.Location = new System.Drawing.Point(388, 260);
            this.lblAlatKerja.Name = "lblAlatKerja";
            this.lblAlatKerja.Size = new System.Drawing.Size(125, 25);
            this.lblAlatKerja.TabIndex = 21;
            this.lblAlatKerja.Text = "[Komponen]";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(868, 462);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(23, 25);
            this.lblTotal.TabIndex = 22;
            this.lblTotal.Text = "0";
            // 
            // pnlDataTransaksi
            // 
            this.pnlDataTransaksi.BackColor = System.Drawing.Color.GhostWhite;
            this.pnlDataTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDataTransaksi.Controls.Add(this.label20);
            this.pnlDataTransaksi.Controls.Add(this.btnTambahPelayan);
            this.pnlDataTransaksi.Controls.Add(this.label7);
            this.pnlDataTransaksi.Controls.Add(this.txtPelayan);
            this.pnlDataTransaksi.Controls.Add(this.label9);
            this.pnlDataTransaksi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlDataTransaksi.Location = new System.Drawing.Point(833, 39);
            this.pnlDataTransaksi.Name = "pnlDataTransaksi";
            this.pnlDataTransaksi.Size = new System.Drawing.Size(382, 40);
            this.pnlDataTransaksi.TabIndex = 39;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.Red;
            this.label20.Location = new System.Drawing.Point(290, 6);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(13, 17);
            this.label20.TabIndex = 31;
            this.label20.Text = "*";
            // 
            // btnTambahPelayan
            // 
            this.btnTambahPelayan.Location = new System.Drawing.Point(309, 6);
            this.btnTambahPelayan.Name = "btnTambahPelayan";
            this.btnTambahPelayan.Size = new System.Drawing.Size(56, 23);
            this.btnTambahPelayan.TabIndex = 30;
            this.btnTambahPelayan.Text = "Baru";
            this.btnTambahPelayan.UseVisualStyleBackColor = true;
            this.btnTambahPelayan.Click += new System.EventHandler(this.btnTambahPelayan_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(5, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 17);
            this.label7.TabIndex = 19;
            this.label7.Text = "Pelayan";
            // 
            // txtPelayan
            // 
            this.txtPelayan.Location = new System.Drawing.Point(126, 6);
            this.txtPelayan.Name = "txtPelayan";
            this.txtPelayan.Size = new System.Drawing.Size(162, 25);
            this.txtPelayan.TabIndex = 21;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(110, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = ":";
            // 
            // RestockAlatKerja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.pnlDataTransaksi);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblAlatKerja);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.blbHargaTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAlatKerja);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tbSupplier);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.tbTransaksi);
            this.Name = "RestockAlatKerja";
            this.Size = new System.Drawing.Size(1362, 528);
            ((System.ComponentModel.ISupportInitialize)(this.tbTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSupplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAlatKerja)).EndInit();
            this.pnlDataTransaksi.ResumeLayout(false);
            this.pnlDataTransaksi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tbTransaksi;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.DataGridView tbSupplier;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSupplier;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.DataGridView tbAlatKerja;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label blbHargaTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label lblAlatKerja;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Panel pnlDataTransaksi;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button btnTambahPelayan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPelayan;
        private System.Windows.Forms.Label label9;
    }
}
