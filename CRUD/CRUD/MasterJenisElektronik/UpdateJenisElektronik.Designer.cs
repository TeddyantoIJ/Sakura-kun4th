namespace CRUD
{
    partial class UpdateJenisElektronik
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateJenisElektronik));
            this.label1 = new System.Windows.Forms.Label();
            this.dgAlatElektronik = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namajenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msjeniselektronikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataJenisElektronik = new CRUD.DataJenisElektronik();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            this.cmbPencarian = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSegarkan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnPerbarui = new System.Windows.Forms.Button();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.msjeniselektronikTableAdapter = new CRUD.DataJenisElektronikTableAdapters.msjeniselektronikTableAdapter();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlatElektronik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msjeniselektronikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataJenisElektronik)).BeginInit();
            this.gbUpdate.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Jenis ELektronik";
            // 
            // dgAlatElektronik
            // 
            this.dgAlatElektronik.AutoGenerateColumns = false;
            this.dgAlatElektronik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlatElektronik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.namajenisDataGridViewTextBoxColumn});
            this.dgAlatElektronik.DataSource = this.msjeniselektronikBindingSource;
            this.dgAlatElektronik.Location = new System.Drawing.Point(12, 56);
            this.dgAlatElektronik.Name = "dgAlatElektronik";
            this.dgAlatElektronik.Size = new System.Drawing.Size(291, 224);
            this.dgAlatElektronik.TabIndex = 1;
            this.dgAlatElektronik.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlatElektronik_CellEnter);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_jenis";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID Jenis";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // namajenisDataGridViewTextBoxColumn
            // 
            this.namajenisDataGridViewTextBoxColumn.DataPropertyName = "nama_jenis";
            this.namajenisDataGridViewTextBoxColumn.HeaderText = "Nama Jenis";
            this.namajenisDataGridViewTextBoxColumn.Name = "namajenisDataGridViewTextBoxColumn";
            this.namajenisDataGridViewTextBoxColumn.Width = 150;
            // 
            // msjeniselektronikBindingSource
            // 
            this.msjeniselektronikBindingSource.DataMember = "msjeniselektronik";
            this.msjeniselektronikBindingSource.DataSource = this.dataJenisElektronik;
            // 
            // dataJenisElektronik
            // 
            this.dataJenisElektronik.DataSetName = "DataJenisElektronik";
            this.dataJenisElektronik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(474, 74);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(147, 23);
            this.txtPencarian.TabIndex = 10;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            // 
            // cmbPencarian
            // 
            this.cmbPencarian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPencarian.FormattingEnabled = true;
            this.cmbPencarian.Items.AddRange(new object[] {
            "ID Alat",
            "Nama Jenis Elektronik"});
            this.cmbPencarian.Location = new System.Drawing.Point(318, 74);
            this.cmbPencarian.Name = "cmbPencarian";
            this.cmbPencarian.Size = new System.Drawing.Size(150, 23);
            this.cmbPencarian.TabIndex = 9;
            this.cmbPencarian.TextChanged += new System.EventHandler(this.cmbPencarian_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(315, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pencarian";
            // 
            // btnSegarkan
            // 
            this.btnSegarkan.Location = new System.Drawing.Point(315, 197);
            this.btnSegarkan.Name = "btnSegarkan";
            this.btnSegarkan.Size = new System.Drawing.Size(75, 23);
            this.btnSegarkan.TabIndex = 13;
            this.btnSegarkan.Text = "Segarkan";
            this.btnSegarkan.UseVisualStyleBackColor = true;
            this.btnSegarkan.Click += new System.EventHandler(this.btnSegarkan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(315, 164);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.Location = new System.Drawing.Point(315, 131);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Size = new System.Drawing.Size(75, 23);
            this.btnPerbarui.TabIndex = 11;
            this.btnPerbarui.Text = "Perbarui";
            this.btnPerbarui.UseVisualStyleBackColor = true;
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
            // 
            // gbUpdate
            // 
            this.gbUpdate.BackColor = System.Drawing.Color.Transparent;
            this.gbUpdate.Controls.Add(this.btnSimpan);
            this.gbUpdate.Controls.Add(this.txtNama);
            this.gbUpdate.Controls.Add(this.lblId);
            this.gbUpdate.Controls.Add(this.label2);
            this.gbUpdate.Controls.Add(this.label8);
            this.gbUpdate.Controls.Add(this.label3);
            this.gbUpdate.Controls.Add(this.label5);
            this.gbUpdate.Location = new System.Drawing.Point(396, 114);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(387, 115);
            this.gbUpdate.TabIndex = 14;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Perbarui";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(291, 83);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(192, 52);
            this.txtNama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(174, 23);
            this.txtNama.TabIndex = 19;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(188, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(18, 15);
            this.lblId.TabIndex = 18;
            this.lblId.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(172, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "ID Jenis";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(172, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(10, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Jenis Elektronik";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(704, 257);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 15;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // msjeniselektronikTableAdapter
            // 
            this.msjeniselektronikTableAdapter.ClearBeforeFill = true;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnKembali);
            this.bunifuGradientPanel1.Controls.Add(this.dgAlatElektronik);
            this.bunifuGradientPanel1.Controls.Add(this.gbUpdate);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.btnSegarkan);
            this.bunifuGradientPanel1.Controls.Add(this.label4);
            this.bunifuGradientPanel1.Controls.Add(this.btnBatal);
            this.bunifuGradientPanel1.Controls.Add(this.cmbPencarian);
            this.bunifuGradientPanel1.Controls.Add(this.btnPerbarui);
            this.bunifuGradientPanel1.Controls.Add(this.txtPencarian);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(803, 292);
            this.bunifuGradientPanel1.TabIndex = 16;
            // 
            // UpdateJenisElektronik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 292);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateJenisElektronik";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UpdateJenisElektronik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlatElektronik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msjeniselektronikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataJenisElektronik)).EndInit();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgAlatElektronik;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaalatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtPencarian;
        private System.Windows.Forms.ComboBox cmbPencarian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSegarkan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnPerbarui;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKembali;
        private DataJenisElektronik dataJenisElektronik;
        private System.Windows.Forms.BindingSource msjeniselektronikBindingSource;
        private DataJenisElektronikTableAdapters.msjeniselektronikTableAdapter msjeniselektronikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namajenisDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}