namespace CRUD
{
    partial class UpdateKomponen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateKomponen));
            this.label1 = new System.Windows.Forms.Label();
            this.dgKomponen = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idkomponenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namakomponenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hargajualDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idalatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSegarkan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnPerbarui = new System.Windows.Forms.Button();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.txtJumlah = new System.Windows.Forms.NumericUpDown();
            this.btnBaru = new System.Windows.Forms.Button();
            this.txtTempat = new System.Windows.Forms.TextBox();
            this.txtAlat = new System.Windows.Forms.TextBox();
            this.txtHarga = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnKembali = new System.Windows.Forms.Button();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgKomponen)).BeginInit();
            this.gbUpdate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlah)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(435, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Komponen";
            // 
            // dgKomponen
            // 
            this.dgKomponen.AllowUserToAddRows = false;
            this.dgKomponen.AllowUserToDeleteRows = false;
            this.dgKomponen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgKomponen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idkomponenDataGridViewTextBoxColumn,
            this.namakomponenDataGridViewTextBoxColumn,
            this.jumlahDataGridViewTextBoxColumn,
            this.hargajualDataGridViewTextBoxColumn,
            this.idalatDataGridViewTextBoxColumn,
            this.tempatDataGridViewTextBoxColumn});
            this.dgKomponen.Location = new System.Drawing.Point(12, 73);
            this.dgKomponen.Name = "dgKomponen";
            this.dgKomponen.ReadOnly = true;
            this.dgKomponen.Size = new System.Drawing.Size(544, 243);
            this.dgKomponen.TabIndex = 1;
            this.dgKomponen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKomponen_CellClick);
            this.dgKomponen.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgKomponen_CellEnter);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "No";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 48;
            // 
            // idkomponenDataGridViewTextBoxColumn
            // 
            this.idkomponenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.idkomponenDataGridViewTextBoxColumn.DataPropertyName = "id_komponen";
            this.idkomponenDataGridViewTextBoxColumn.HeaderText = "ID Komponen";
            this.idkomponenDataGridViewTextBoxColumn.Name = "idkomponenDataGridViewTextBoxColumn";
            this.idkomponenDataGridViewTextBoxColumn.ReadOnly = true;
            this.idkomponenDataGridViewTextBoxColumn.Width = 96;
            // 
            // namakomponenDataGridViewTextBoxColumn
            // 
            this.namakomponenDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.namakomponenDataGridViewTextBoxColumn.DataPropertyName = "nama_komponen";
            this.namakomponenDataGridViewTextBoxColumn.HeaderText = "Nama Komponen";
            this.namakomponenDataGridViewTextBoxColumn.Name = "namakomponenDataGridViewTextBoxColumn";
            this.namakomponenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jumlahDataGridViewTextBoxColumn
            // 
            this.jumlahDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.jumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah";
            this.jumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            this.jumlahDataGridViewTextBoxColumn.Name = "jumlahDataGridViewTextBoxColumn";
            this.jumlahDataGridViewTextBoxColumn.ReadOnly = true;
            this.jumlahDataGridViewTextBoxColumn.Width = 70;
            // 
            // hargajualDataGridViewTextBoxColumn
            // 
            this.hargajualDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.hargajualDataGridViewTextBoxColumn.DataPropertyName = "harga_jual";
            this.hargajualDataGridViewTextBoxColumn.HeaderText = "Harga Jual";
            this.hargajualDataGridViewTextBoxColumn.Name = "hargajualDataGridViewTextBoxColumn";
            this.hargajualDataGridViewTextBoxColumn.ReadOnly = true;
            this.hargajualDataGridViewTextBoxColumn.Width = 80;
            // 
            // idalatDataGridViewTextBoxColumn
            // 
            this.idalatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idalatDataGridViewTextBoxColumn.DataPropertyName = "id_alat";
            this.idalatDataGridViewTextBoxColumn.HeaderText = "Alat Elektronik";
            this.idalatDataGridViewTextBoxColumn.Name = "idalatDataGridViewTextBoxColumn";
            this.idalatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tempatDataGridViewTextBoxColumn
            // 
            this.tempatDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tempatDataGridViewTextBoxColumn.DataPropertyName = "tempat";
            this.tempatDataGridViewTextBoxColumn.HeaderText = "Tempat";
            this.tempatDataGridViewTextBoxColumn.Name = "tempatDataGridViewTextBoxColumn";
            this.tempatDataGridViewTextBoxColumn.ReadOnly = true;
            this.tempatDataGridViewTextBoxColumn.Width = 72;
            // 
            // btnSegarkan
            // 
            this.btnSegarkan.Location = new System.Drawing.Point(564, 196);
            this.btnSegarkan.Name = "btnSegarkan";
            this.btnSegarkan.Size = new System.Drawing.Size(75, 23);
            this.btnSegarkan.TabIndex = 16;
            this.btnSegarkan.Text = "Segarkan";
            this.btnSegarkan.UseVisualStyleBackColor = true;
            this.btnSegarkan.Click += new System.EventHandler(this.btnSegarkan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(564, 163);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 15;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.Location = new System.Drawing.Point(564, 130);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Size = new System.Drawing.Size(75, 23);
            this.btnPerbarui.TabIndex = 14;
            this.btnPerbarui.Text = "Perbarui";
            this.btnPerbarui.UseVisualStyleBackColor = true;
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
            // 
            // gbUpdate
            // 
            this.gbUpdate.BackColor = System.Drawing.Color.Transparent;
            this.gbUpdate.Controls.Add(this.txtJumlah);
            this.gbUpdate.Controls.Add(this.btnBaru);
            this.gbUpdate.Controls.Add(this.txtTempat);
            this.gbUpdate.Controls.Add(this.txtAlat);
            this.gbUpdate.Controls.Add(this.txtHarga);
            this.gbUpdate.Controls.Add(this.label14);
            this.gbUpdate.Controls.Add(this.txtNama);
            this.gbUpdate.Controls.Add(this.lblId);
            this.gbUpdate.Controls.Add(this.label13);
            this.gbUpdate.Controls.Add(this.label12);
            this.gbUpdate.Controls.Add(this.label11);
            this.gbUpdate.Controls.Add(this.label10);
            this.gbUpdate.Controls.Add(this.label9);
            this.gbUpdate.Controls.Add(this.label8);
            this.gbUpdate.Controls.Add(this.label7);
            this.gbUpdate.Controls.Add(this.label6);
            this.gbUpdate.Controls.Add(this.label5);
            this.gbUpdate.Controls.Add(this.label2);
            this.gbUpdate.Controls.Add(this.label3);
            this.gbUpdate.Controls.Add(this.label15);
            this.gbUpdate.Location = new System.Drawing.Point(645, 117);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(367, 230);
            this.gbUpdate.TabIndex = 17;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Perbarui";
            // 
            // txtJumlah
            // 
            this.txtJumlah.Location = new System.Drawing.Point(206, 80);
            this.txtJumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtJumlah.Name = "txtJumlah";
            this.txtJumlah.Size = new System.Drawing.Size(136, 23);
            this.txtJumlah.TabIndex = 39;
            this.txtJumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(267, 167);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(75, 23);
            this.btnBaru.TabIndex = 19;
            this.btnBaru.Text = "Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
            // 
            // txtTempat
            // 
            this.txtTempat.Location = new System.Drawing.Point(206, 196);
            this.txtTempat.Name = "txtTempat";
            this.txtTempat.Size = new System.Drawing.Size(51, 23);
            this.txtTempat.TabIndex = 38;
            // 
            // txtAlat
            // 
            this.txtAlat.Location = new System.Drawing.Point(206, 138);
            this.txtAlat.Name = "txtAlat";
            this.txtAlat.Size = new System.Drawing.Size(136, 23);
            this.txtAlat.TabIndex = 37;
            this.txtAlat.TextChanged += new System.EventHandler(this.txtAlat_TextChanged);
            // 
            // txtHarga
            // 
            this.txtHarga.Location = new System.Drawing.Point(230, 109);
            this.txtHarga.Name = "txtHarga";
            this.txtHarga.Size = new System.Drawing.Size(112, 23);
            this.txtHarga.TabIndex = 36;
            this.txtHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtHarga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtHarga_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(203, 113);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(21, 15);
            this.label14.TabIndex = 35;
            this.label14.Text = "Rp";
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(206, 51);
            this.txtNama.MaxLength = 30;
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(136, 23);
            this.txtNama.TabIndex = 33;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(203, 30);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 32;
            this.lblId.Text = "ID";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(187, 200);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(10, 15);
            this.label13.TabIndex = 31;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(187, 141);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(10, 15);
            this.label12.TabIndex = 30;
            this.label12.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(187, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(10, 15);
            this.label11.TabIndex = 29;
            this.label11.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(187, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(10, 15);
            this.label10.TabIndex = 28;
            this.label10.Text = ":";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(187, 54);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(10, 15);
            this.label9.TabIndex = 27;
            this.label9.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(187, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(10, 15);
            this.label8.TabIndex = 26;
            this.label8.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 15);
            this.label7.TabIndex = 25;
            this.label7.Text = "Tempat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 15);
            this.label6.TabIndex = 24;
            this.label6.Text = "Komponen Alat Elektronik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Harga Jual";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 22;
            this.label2.Text = "Jumlah";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Nama Komponen";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(29, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 15);
            this.label15.TabIndex = 20;
            this.label15.Text = "ID Komponen";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(931, 351);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 18;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(12, 338);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 18;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnKembali);
            this.bunifuGradientPanel1.Controls.Add(this.dgKomponen);
            this.bunifuGradientPanel1.Controls.Add(this.gbUpdate);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.btnSimpan);
            this.bunifuGradientPanel1.Controls.Add(this.btnSegarkan);
            this.bunifuGradientPanel1.Controls.Add(this.btnBatal);
            this.bunifuGradientPanel1.Controls.Add(this.btnPerbarui);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1025, 390);
            this.bunifuGradientPanel1.TabIndex = 19;
            // 
            // UpdateKomponen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 390);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateKomponen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateJenisElektronik";
            this.Load += new System.EventHandler(this.UpdateAlatElektronik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgKomponen)).EndInit();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtJumlah)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgKomponen;
        private System.Windows.Forms.Button btnSegarkan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnPerbarui;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.TextBox txtTempat;
        private System.Windows.Forms.TextBox txtAlat;
        private System.Windows.Forms.TextBox txtHarga;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idkomponenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namakomponenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hargajualDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempatDataGridViewTextBoxColumn;
        private System.Windows.Forms.NumericUpDown txtJumlah;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}