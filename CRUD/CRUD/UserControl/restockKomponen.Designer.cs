namespace CRUD
{
    partial class restockKomponen
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
            this.tableTransaksi = new System.Windows.Forms.DataGridView();
            this.btnBayar = new System.Windows.Forms.Button();
            this.tableSupplier = new System.Windows.Forms.DataGridView();
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
            this.tableKomponen = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.blbHargaTotal = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtKomponen = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlah = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total_harga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tableTransaksi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSupplier)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableKomponen)).BeginInit();
            this.SuspendLayout();
            // 
            // tableTransaksi
            // 
            this.tableTransaksi.AllowUserToAddRows = false;
            this.tableTransaksi.AllowUserToDeleteRows = false;
            this.tableTransaksi.BackgroundColor = System.Drawing.Color.Snow;
            this.tableTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableTransaksi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.No,
            this.Column2,
            this.Supplier,
            this.harga,
            this.jumlah,
            this.total_harga});
            this.tableTransaksi.Location = new System.Drawing.Point(857, 152);
            this.tableTransaksi.Name = "tableTransaksi";
            this.tableTransaksi.ReadOnly = true;
            this.tableTransaksi.Size = new System.Drawing.Size(502, 312);
            this.tableTransaksi.TabIndex = 0;
            this.tableTransaksi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableTransaksi_CellClick);
            // 
            // btnBayar
            // 
            this.btnBayar.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayar.Location = new System.Drawing.Point(1193, 119);
            this.btnBayar.Name = "btnBayar";
            this.btnBayar.Size = new System.Drawing.Size(166, 27);
            this.btnBayar.TabIndex = 5;
            this.btnBayar.Text = "Proses Transaksi";
            this.btnBayar.UseVisualStyleBackColor = true;
            this.btnBayar.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // tableSupplier
            // 
            this.tableSupplier.AllowUserToAddRows = false;
            this.tableSupplier.AllowUserToDeleteRows = false;
            this.tableSupplier.BackgroundColor = System.Drawing.Color.Snow;
            this.tableSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableSupplier.Location = new System.Drawing.Point(176, 282);
            this.tableSupplier.Name = "tableSupplier";
            this.tableSupplier.ReadOnly = true;
            this.tableSupplier.Size = new System.Drawing.Size(502, 182);
            this.tableSupplier.TabIndex = 6;
            this.tableSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableSupplier_CellClick);
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
            this.txtSupplier.Size = new System.Drawing.Size(160, 20);
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
            this.txtJumlah.Size = new System.Drawing.Size(88, 20);
            this.txtJumlah.TabIndex = 10;
            this.txtJumlah.Text = "0";
            this.txtJumlah.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPlus
            // 
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(98, 69);
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
            this.btnMin.Location = new System.Drawing.Point(134, 69);
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
            this.panel1.Location = new System.Drawing.Point(684, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(167, 182);
            this.panel1.TabIndex = 13;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(89, 144);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
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
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 14;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(4, 115);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(160, 23);
            this.btnTambah.TabIndex = 13;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
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
            this.dataGridViewTextBoxColumn6,
            this.Column1});
            this.tableKomponen.Location = new System.Drawing.Point(176, 36);
            this.tableKomponen.Name = "tableKomponen";
            this.tableKomponen.ReadOnly = true;
            this.tableKomponen.Size = new System.Drawing.Size(502, 182);
            this.tableKomponen.TabIndex = 14;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Data Komponen";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(865, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Data Transaksi";
            // 
            // blbHargaTotal
            // 
            this.blbHargaTotal.AutoSize = true;
            this.blbHargaTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blbHargaTotal.Location = new System.Drawing.Point(864, 80);
            this.blbHargaTotal.Name = "blbHargaTotal";
            this.blbHargaTotal.Size = new System.Drawing.Size(51, 25);
            this.blbHargaTotal.TabIndex = 19;
            this.blbHargaTotal.Text = "Rp. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(853, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 18;
            this.label2.Text = "TOTAL HARGA";
            // 
            // btnCari
            // 
            this.btnCari.Enabled = false;
            this.btnCari.Location = new System.Drawing.Point(688, 193);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(75, 25);
            this.btnCari.TabIndex = 20;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtKomponen
            // 
            this.txtKomponen.AutoSize = true;
            this.txtKomponen.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKomponen.Location = new System.Drawing.Point(292, 256);
            this.txtKomponen.Name = "txtKomponen";
            this.txtKomponen.Size = new System.Drawing.Size(106, 21);
            this.txtKomponen.TabIndex = 21;
            this.txtKomponen.Text = "[Komponen]";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(921, 79);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(23, 26);
            this.txtTotal.TabIndex = 22;
            this.txtTotal.Text = "0";
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
            this.harga.HeaderText = "Harga";
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
            // restockKomponen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtKomponen);
            this.Controls.Add(this.btnCari);
            this.Controls.Add(this.blbHargaTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableKomponen);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableSupplier);
            this.Controls.Add(this.btnBayar);
            this.Controls.Add(this.tableTransaksi);
            this.Name = "restockKomponen";
            this.Size = new System.Drawing.Size(1362, 528);
            ((System.ComponentModel.ISupportInitialize)(this.tableTransaksi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableSupplier)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableKomponen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tableTransaksi;
        private System.Windows.Forms.Button btnBayar;
        private System.Windows.Forms.DataGridView tableSupplier;
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
        private System.Windows.Forms.DataGridView tableKomponen;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label blbHargaTotal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.Label txtKomponen;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn harga;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlah;
        private System.Windows.Forms.DataGridViewTextBoxColumn total_harga;
    }
}
