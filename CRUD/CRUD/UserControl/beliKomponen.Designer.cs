namespace CRUD
{
    partial class beliKomponen
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
            this.tableKomponen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTambah = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPelayan = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPelanggan = new System.Windows.Forms.TextBox();
            this.btnTambahPelanggan = new System.Windows.Forms.Button();
            this.picPelanggan = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblFoto = new System.Windows.Forms.Label();
            this.tableDaftarBeli = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label8 = new System.Windows.Forms.Label();
            this.txtJumlah = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.txtKomponen = new System.Windows.Forms.TextBox();
            this.panelDeskripsi = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtTotal = new System.Windows.Forms.Label();
            this.blbHargaTotal = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLanjutkan = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableKomponen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelanggan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDaftarBeli)).BeginInit();
            this.panelDeskripsi.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data Komponen";
            // 
            // tableKomponen
            // 
            this.tableKomponen.AllowUserToAddRows = false;
            this.tableKomponen.AllowUserToDeleteRows = false;
            this.tableKomponen.BackgroundColor = System.Drawing.Color.Snow;
            this.tableKomponen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableKomponen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.Column2,
            this.dataGridViewTextBoxColumn6,
            this.Column1});
            this.tableKomponen.Location = new System.Drawing.Point(200, 38);
            this.tableKomponen.Name = "tableKomponen";
            this.tableKomponen.ReadOnly = true;
            this.tableKomponen.Size = new System.Drawing.Size(627, 182);
            this.tableKomponen.TabIndex = 16;
            this.tableKomponen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableKomponen_CellClick);
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
            this.dataGridViewTextBoxColumn5.HeaderText = "Komponen";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Barang";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn6.HeaderText = "Harga Satuan";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Jumlah";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(3, 120);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(100, 59);
            this.btnTambah.TabIndex = 18;
            this.btnTambah.Text = "Tambah Ke Daftar";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pelayan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nama pelanggan";
            // 
            // txtPelayan
            // 
            this.txtPelayan.Location = new System.Drawing.Point(108, 6);
            this.txtPelayan.Name = "txtPelayan";
            this.txtPelayan.ReadOnly = true;
            this.txtPelayan.Size = new System.Drawing.Size(162, 20);
            this.txtPelayan.TabIndex = 21;
            this.txtPelayan.Text = "Jessica Rich Girl";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = ":";
            // 
            // txtPelanggan
            // 
            this.txtPelanggan.Location = new System.Drawing.Point(108, 33);
            this.txtPelanggan.Name = "txtPelanggan";
            this.txtPelanggan.Size = new System.Drawing.Size(162, 20);
            this.txtPelanggan.TabIndex = 24;
            this.txtPelanggan.TextChanged += new System.EventHandler(this.txtPelanggan_TextChanged);
            // 
            // btnTambahPelanggan
            // 
            this.btnTambahPelanggan.Location = new System.Drawing.Point(276, 30);
            this.btnTambahPelanggan.Name = "btnTambahPelanggan";
            this.btnTambahPelanggan.Size = new System.Drawing.Size(56, 23);
            this.btnTambahPelanggan.TabIndex = 25;
            this.btnTambahPelanggan.Text = "Daftar";
            this.btnTambahPelanggan.UseVisualStyleBackColor = true;
            this.btnTambahPelanggan.Click += new System.EventHandler(this.btnTambahPelanggan_Click);
            // 
            // picPelanggan
            // 
            this.picPelanggan.Location = new System.Drawing.Point(108, 59);
            this.picPelanggan.Name = "picPelanggan";
            this.picPelanggan.Size = new System.Drawing.Size(162, 119);
            this.picPelanggan.TabIndex = 26;
            this.picPelanggan.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Foto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = ":";
            // 
            // lblFoto
            // 
            this.lblFoto.AutoSize = true;
            this.lblFoto.Location = new System.Drawing.Point(108, 59);
            this.lblFoto.Name = "lblFoto";
            this.lblFoto.Size = new System.Drawing.Size(68, 13);
            this.lblFoto.TabIndex = 29;
            this.lblFoto.Text = "[Keterangan]";
            // 
            // tableDaftarBeli
            // 
            this.tableDaftarBeli.AllowUserToAddRows = false;
            this.tableDaftarBeli.AllowUserToDeleteRows = false;
            this.tableDaftarBeli.BackgroundColor = System.Drawing.Color.Snow;
            this.tableDaftarBeli.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableDaftarBeli.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.Column3});
            this.tableDaftarBeli.Location = new System.Drawing.Point(200, 285);
            this.tableDaftarBeli.Name = "tableDaftarBeli";
            this.tableDaftarBeli.ReadOnly = true;
            this.tableDaftarBeli.Size = new System.Drawing.Size(627, 182);
            this.tableDaftarBeli.TabIndex = 30;
            this.tableDaftarBeli.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableDaftarBeli_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 46;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Komponen";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Barang";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn7.HeaderText = "Harga Satuan";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn8.HeaderText = "Jumlah";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Harga Total";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(196, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 21);
            this.label8.TabIndex = 31;
            this.label8.Text = "Daftar Beli Komponen";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(3, 65);
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.ReadOnly = true;
            this.txtJumlah.Size = new System.Drawing.Size(100, 20);
            this.txtJumlah.TabIndex = 32;
            this.txtJumlah.Text = "0";
            this.txtJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 33;
            this.label9.Text = "Jumlah";
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(3, 91);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(51, 23);
            this.btnPlus.TabIndex = 34;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMin
            // 
            this.btnMin.Location = new System.Drawing.Point(52, 91);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(51, 23);
            this.btnMin.TabIndex = 35;
            this.btnMin.Text = "-";
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // txtKomponen
            // 
            this.txtKomponen.Location = new System.Drawing.Point(3, 26);
            this.txtKomponen.Name = "txtKomponen";
            this.txtKomponen.ReadOnly = true;
            this.txtKomponen.Size = new System.Drawing.Size(100, 20);
            this.txtKomponen.TabIndex = 36;
            this.txtKomponen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelDeskripsi
            // 
            this.panelDeskripsi.BackColor = System.Drawing.Color.GhostWhite;
            this.panelDeskripsi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelDeskripsi.Controls.Add(this.picPelanggan);
            this.panelDeskripsi.Controls.Add(this.label2);
            this.panelDeskripsi.Controls.Add(this.label3);
            this.panelDeskripsi.Controls.Add(this.txtPelayan);
            this.panelDeskripsi.Controls.Add(this.label4);
            this.panelDeskripsi.Controls.Add(this.label5);
            this.panelDeskripsi.Controls.Add(this.txtPelanggan);
            this.panelDeskripsi.Controls.Add(this.btnTambahPelanggan);
            this.panelDeskripsi.Controls.Add(this.lblFoto);
            this.panelDeskripsi.Controls.Add(this.label6);
            this.panelDeskripsi.Controls.Add(this.label7);
            this.panelDeskripsi.Location = new System.Drawing.Point(964, 38);
            this.panelDeskripsi.Name = "panelDeskripsi";
            this.panelDeskripsi.Size = new System.Drawing.Size(349, 182);
            this.panelDeskripsi.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 5);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "DESKRIPSI";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnTambah);
            this.panel1.Controls.Add(this.txtJumlah);
            this.panel1.Controls.Add(this.txtKomponen);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.btnMin);
            this.panel1.Controls.Add(this.btnPlus);
            this.panel1.Location = new System.Drawing.Point(833, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 182);
            this.panel1.TabIndex = 39;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(908, 443);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(23, 26);
            this.txtTotal.TabIndex = 42;
            this.txtTotal.Text = "0";
            // 
            // blbHargaTotal
            // 
            this.blbHargaTotal.AutoSize = true;
            this.blbHargaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbHargaTotal.Location = new System.Drawing.Point(851, 442);
            this.blbHargaTotal.Name = "blbHargaTotal";
            this.blbHargaTotal.Size = new System.Drawing.Size(51, 25);
            this.blbHargaTotal.TabIndex = 41;
            this.blbHargaTotal.Text = "Rp. ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(852, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 24);
            this.label11.TabIndex = 40;
            this.label11.Text = "TOTAL HARGA";
            // 
            // btnBatal
            // 
            this.btnBatal.Enabled = false;
            this.btnBatal.Location = new System.Drawing.Point(711, 261);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(116, 21);
            this.btnBatal.TabIndex = 43;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(589, 261);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(116, 21);
            this.btnReset.TabIndex = 44;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnLanjutkan
            // 
            this.btnLanjutkan.Location = new System.Drawing.Point(1195, 418);
            this.btnLanjutkan.Name = "btnLanjutkan";
            this.btnLanjutkan.Size = new System.Drawing.Size(118, 49);
            this.btnLanjutkan.TabIndex = 45;
            this.btnLanjutkan.Text = "Lanjutkan";
            this.btnLanjutkan.UseVisualStyleBackColor = true;
            this.btnLanjutkan.Click += new System.EventHandler(this.btnLanjutkan_Click);
            // 
            // beliKomponen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnLanjutkan);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.blbHargaTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDeskripsi);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tableDaftarBeli);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableKomponen);
            this.Name = "beliKomponen";
            this.Size = new System.Drawing.Size(1362, 528);
            this.Load += new System.EventHandler(this.beliKomponen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableKomponen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelanggan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableDaftarBeli)).EndInit();
            this.panelDeskripsi.ResumeLayout(false);
            this.panelDeskripsi.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView tableKomponen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPelayan;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPelanggan;
        private System.Windows.Forms.Button btnTambahPelanggan;
        private System.Windows.Forms.PictureBox picPelanggan;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblFoto;
        private System.Windows.Forms.DataGridView tableDaftarBeli;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtJumlah;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.TextBox txtKomponen;
        private System.Windows.Forms.Panel panelDeskripsi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label blbHargaTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLanjutkan;
    }
}
