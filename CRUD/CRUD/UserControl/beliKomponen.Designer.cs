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
            ((System.ComponentModel.ISupportInitialize)(this.tableKomponen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelanggan)).BeginInit();
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
            this.btnTambah.Location = new System.Drawing.Point(833, 38);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(75, 58);
            this.btnTambah.TabIndex = 18;
            this.btnTambah.Text = "Tambah Ke Daftar";
            this.btnTambah.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(953, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Pelayan";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(953, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Nama pelanggan";
            // 
            // txtPelayan
            // 
            this.txtPelayan.Location = new System.Drawing.Point(1056, 31);
            this.txtPelayan.Name = "txtPelayan";
            this.txtPelayan.ReadOnly = true;
            this.txtPelayan.Size = new System.Drawing.Size(162, 20);
            this.txtPelayan.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1040, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1040, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = ":";
            // 
            // txtPelanggan
            // 
            this.txtPelanggan.Location = new System.Drawing.Point(1056, 58);
            this.txtPelanggan.Name = "txtPelanggan";
            this.txtPelanggan.Size = new System.Drawing.Size(162, 20);
            this.txtPelanggan.TabIndex = 24;
            this.txtPelanggan.TextChanged += new System.EventHandler(this.txtPelanggan_TextChanged);
            // 
            // btnTambahPelanggan
            // 
            this.btnTambahPelanggan.Location = new System.Drawing.Point(1224, 55);
            this.btnTambahPelanggan.Name = "btnTambahPelanggan";
            this.btnTambahPelanggan.Size = new System.Drawing.Size(56, 23);
            this.btnTambahPelanggan.TabIndex = 25;
            this.btnTambahPelanggan.Text = "Daftar";
            this.btnTambahPelanggan.UseVisualStyleBackColor = true;
            this.btnTambahPelanggan.Click += new System.EventHandler(this.btnTambahPelanggan_Click);
            // 
            // picPelanggan
            // 
            this.picPelanggan.Location = new System.Drawing.Point(1056, 84);
            this.picPelanggan.Name = "picPelanggan";
            this.picPelanggan.Size = new System.Drawing.Size(162, 119);
            this.picPelanggan.TabIndex = 26;
            this.picPelanggan.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(953, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "Foto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1040, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(10, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = ":";
            // 
            // beliKomponen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.picPelanggan);
            this.Controls.Add(this.btnTambahPelanggan);
            this.Controls.Add(this.txtPelanggan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtPelayan);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTambah);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableKomponen);
            this.Name = "beliKomponen";
            this.Size = new System.Drawing.Size(1362, 528);
            this.Load += new System.EventHandler(this.beliKomponen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tableKomponen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picPelanggan)).EndInit();
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
    }
}
