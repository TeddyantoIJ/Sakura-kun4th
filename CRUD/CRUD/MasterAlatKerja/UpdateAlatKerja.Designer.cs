namespace CRUD
{
    partial class UpdateAlatKerja
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateAlatKerja));
            this.viewAlatKerja = new System.Windows.Forms.DataGridView();
            this.idalatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaalatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jumlahDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bagusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rusakDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msalatkerjaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sakuraDataDataSet2 = new CRUD.SakuraDataDataSet2();
            this.label1 = new System.Windows.Forms.Label();
            this.msalatkerjaTableAdapter = new CRUD.SakuraDataDataSet2TableAdapters.msalatkerjaTableAdapter();
            this.updateGrup = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnMinus1 = new System.Windows.Forms.Button();
            this.btnPlus1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtid_alat_kerja = new System.Windows.Forms.Label();
            this.cmbbagus = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbrusak = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtjumlah = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtnama_alat_kerja = new System.Windows.Forms.TextBox();
            this.infonama_alat_kerja = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.info_jumlah = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.infocmb1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.infocmb2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.radioButton1 = new System.Windows.Forms.CheckBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlatKerja)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msalatkerjaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakuraDataDataSet2)).BeginInit();
            this.updateGrup.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewAlatKerja
            // 
            this.viewAlatKerja.AllowUserToAddRows = false;
            this.viewAlatKerja.AllowUserToDeleteRows = false;
            this.viewAlatKerja.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewAlatKerja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewAlatKerja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewAlatKerja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalatDataGridViewTextBoxColumn,
            this.namaalatDataGridViewTextBoxColumn,
            this.jumlahDataGridViewTextBoxColumn,
            this.bagusDataGridViewTextBoxColumn,
            this.rusakDataGridViewTextBoxColumn});
            this.viewAlatKerja.DataSource = this.msalatkerjaBindingSource;
            this.viewAlatKerja.Location = new System.Drawing.Point(22, 90);
            this.viewAlatKerja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewAlatKerja.Name = "viewAlatKerja";
            this.viewAlatKerja.ReadOnly = true;
            this.viewAlatKerja.Size = new System.Drawing.Size(542, 288);
            this.viewAlatKerja.TabIndex = 0;
            this.viewAlatKerja.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAlatKerja_CellClick);
            this.viewAlatKerja.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAlatKerja_CellEnter);
            // 
            // idalatDataGridViewTextBoxColumn
            // 
            this.idalatDataGridViewTextBoxColumn.DataPropertyName = "id_alat";
            this.idalatDataGridViewTextBoxColumn.HeaderText = "ID Alat";
            this.idalatDataGridViewTextBoxColumn.Name = "idalatDataGridViewTextBoxColumn";
            this.idalatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namaalatDataGridViewTextBoxColumn
            // 
            this.namaalatDataGridViewTextBoxColumn.DataPropertyName = "nama_alat";
            this.namaalatDataGridViewTextBoxColumn.HeaderText = "Nama Alat";
            this.namaalatDataGridViewTextBoxColumn.Name = "namaalatDataGridViewTextBoxColumn";
            this.namaalatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // jumlahDataGridViewTextBoxColumn
            // 
            this.jumlahDataGridViewTextBoxColumn.DataPropertyName = "jumlah";
            this.jumlahDataGridViewTextBoxColumn.HeaderText = "Jumlah";
            this.jumlahDataGridViewTextBoxColumn.Name = "jumlahDataGridViewTextBoxColumn";
            this.jumlahDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bagusDataGridViewTextBoxColumn
            // 
            this.bagusDataGridViewTextBoxColumn.DataPropertyName = "bagus";
            this.bagusDataGridViewTextBoxColumn.HeaderText = "Bagus";
            this.bagusDataGridViewTextBoxColumn.Name = "bagusDataGridViewTextBoxColumn";
            this.bagusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rusakDataGridViewTextBoxColumn
            // 
            this.rusakDataGridViewTextBoxColumn.DataPropertyName = "rusak";
            this.rusakDataGridViewTextBoxColumn.HeaderText = "Rusak";
            this.rusakDataGridViewTextBoxColumn.Name = "rusakDataGridViewTextBoxColumn";
            this.rusakDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // msalatkerjaBindingSource
            // 
            this.msalatkerjaBindingSource.DataMember = "msalatkerja";
            this.msalatkerjaBindingSource.DataSource = this.sakuraDataDataSet2;
            // 
            // sakuraDataDataSet2
            // 
            this.sakuraDataDataSet2.DataSetName = "SakuraDataDataSet2";
            this.sakuraDataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(506, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Data Alat Kerja";
            // 
            // msalatkerjaTableAdapter
            // 
            this.msalatkerjaTableAdapter.ClearBeforeFill = true;
            // 
            // updateGrup
            // 
            this.updateGrup.BackColor = System.Drawing.Color.Transparent;
            this.updateGrup.Controls.Add(this.button1);
            this.updateGrup.Controls.Add(this.button2);
            this.updateGrup.Controls.Add(this.btnMinus1);
            this.updateGrup.Controls.Add(this.btnPlus1);
            this.updateGrup.Controls.Add(this.label7);
            this.updateGrup.Controls.Add(this.btnMinus);
            this.updateGrup.Controls.Add(this.btnPlus);
            this.updateGrup.Controls.Add(this.btnSimpan);
            this.updateGrup.Controls.Add(this.txtid_alat_kerja);
            this.updateGrup.Controls.Add(this.cmbbagus);
            this.updateGrup.Controls.Add(this.label2);
            this.updateGrup.Controls.Add(this.cmbrusak);
            this.updateGrup.Controls.Add(this.label8);
            this.updateGrup.Controls.Add(this.txtjumlah);
            this.updateGrup.Controls.Add(this.label3);
            this.updateGrup.Controls.Add(this.txtnama_alat_kerja);
            this.updateGrup.Controls.Add(this.infonama_alat_kerja);
            this.updateGrup.Controls.Add(this.label9);
            this.updateGrup.Controls.Add(this.label12);
            this.updateGrup.Controls.Add(this.label4);
            this.updateGrup.Controls.Add(this.label6);
            this.updateGrup.Controls.Add(this.info_jumlah);
            this.updateGrup.Controls.Add(this.label11);
            this.updateGrup.Controls.Add(this.infocmb1);
            this.updateGrup.Controls.Add(this.label5);
            this.updateGrup.Controls.Add(this.infocmb2);
            this.updateGrup.Controls.Add(this.label10);
            this.updateGrup.Enabled = false;
            this.updateGrup.Location = new System.Drawing.Point(604, 140);
            this.updateGrup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateGrup.Name = "updateGrup";
            this.updateGrup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateGrup.Size = new System.Drawing.Size(439, 265);
            this.updateGrup.TabIndex = 2;
            this.updateGrup.TabStop = false;
            this.updateGrup.Text = "Perbarui";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 103);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(30, 26);
            this.button1.TabIndex = 33;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 103);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(30, 26);
            this.button2.TabIndex = 32;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnMinus1
            // 
            this.btnMinus1.Location = new System.Drawing.Point(260, 186);
            this.btnMinus1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinus1.Name = "btnMinus1";
            this.btnMinus1.Size = new System.Drawing.Size(30, 26);
            this.btnMinus1.TabIndex = 31;
            this.btnMinus1.Text = "-";
            this.btnMinus1.UseVisualStyleBackColor = true;
            this.btnMinus1.Click += new System.EventHandler(this.btnMinus1_Click);
            // 
            // btnPlus1
            // 
            this.btnPlus1.Location = new System.Drawing.Point(226, 186);
            this.btnPlus1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlus1.Name = "btnPlus1";
            this.btnPlus1.Size = new System.Drawing.Size(30, 26);
            this.btnPlus1.TabIndex = 30;
            this.btnPlus1.Text = "+";
            this.btnPlus1.UseVisualStyleBackColor = true;
            this.btnPlus1.Click += new System.EventHandler(this.btnPlus1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(226, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 29;
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(260, 145);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 26);
            this.btnMinus.TabIndex = 28;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(226, 145);
            this.btnPlus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(30, 26);
            this.btnPlus.TabIndex = 27;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(339, 227);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(87, 30);
            this.btnSimpan.TabIndex = 23;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtid_alat_kerja
            // 
            this.txtid_alat_kerja.AutoSize = true;
            this.txtid_alat_kerja.Location = new System.Drawing.Point(141, 33);
            this.txtid_alat_kerja.Name = "txtid_alat_kerja";
            this.txtid_alat_kerja.Size = new System.Drawing.Size(61, 17);
            this.txtid_alat_kerja.TabIndex = 26;
            this.txtid_alat_kerja.Text = "Generate";
            // 
            // cmbbagus
            // 
            this.cmbbagus.Enabled = false;
            this.cmbbagus.FormattingEnabled = true;
            this.cmbbagus.Location = new System.Drawing.Point(141, 145);
            this.cmbbagus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbbagus.MaxDropDownItems = 5;
            this.cmbbagus.Name = "cmbbagus";
            this.cmbbagus.Size = new System.Drawing.Size(67, 25);
            this.cmbbagus.TabIndex = 11;
            this.cmbbagus.TextChanged += new System.EventHandler(this.cmbbagus_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Alat Kerja";
            // 
            // cmbrusak
            // 
            this.cmbrusak.Enabled = false;
            this.cmbrusak.FormattingEnabled = true;
            this.cmbrusak.Location = new System.Drawing.Point(141, 187);
            this.cmbrusak.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbrusak.MaxDropDownItems = 5;
            this.cmbrusak.Name = "cmbrusak";
            this.cmbrusak.Size = new System.Drawing.Size(67, 25);
            this.cmbrusak.TabIndex = 15;
            this.cmbrusak.TextChanged += new System.EventHandler(this.cmbrusak_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(121, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = ":";
            // 
            // txtjumlah
            // 
            this.txtjumlah.Enabled = false;
            this.txtjumlah.Location = new System.Drawing.Point(141, 105);
            this.txtjumlah.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(67, 25);
            this.txtjumlah.TabIndex = 9;
            this.txtjumlah.TextChanged += new System.EventHandler(this.txtjumlah_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nama Alat Kerja";
            // 
            // txtnama_alat_kerja
            // 
            this.txtnama_alat_kerja.Location = new System.Drawing.Point(141, 64);
            this.txtnama_alat_kerja.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_alat_kerja.MaxLength = 50;
            this.txtnama_alat_kerja.Name = "txtnama_alat_kerja";
            this.txtnama_alat_kerja.Size = new System.Drawing.Size(187, 25);
            this.txtnama_alat_kerja.TabIndex = 7;
            this.txtnama_alat_kerja.TextChanged += new System.EventHandler(this.txtnama_alat_kerja_TextChanged);
            this.txtnama_alat_kerja.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnama_alat_kerja_KeyUp);
            // 
            // infonama_alat_kerja
            // 
            this.infonama_alat_kerja.AutoSize = true;
            this.infonama_alat_kerja.Location = new System.Drawing.Point(336, 71);
            this.infonama_alat_kerja.Name = "infonama_alat_kerja";
            this.infonama_alat_kerja.Size = new System.Drawing.Size(0, 17);
            this.infonama_alat_kerja.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(121, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 14;
            this.label9.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(121, 154);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 17);
            this.label12.TabIndex = 25;
            this.label12.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Jumlah";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 154);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 17);
            this.label6.TabIndex = 24;
            this.label6.Text = "Bagus";
            // 
            // info_jumlah
            // 
            this.info_jumlah.AutoSize = true;
            this.info_jumlah.Location = new System.Drawing.Point(222, 150);
            this.info_jumlah.Name = "info_jumlah";
            this.info_jumlah.Size = new System.Drawing.Size(0, 17);
            this.info_jumlah.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(121, 195);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = ":";
            // 
            // infocmb1
            // 
            this.infocmb1.AutoSize = true;
            this.infocmb1.Location = new System.Drawing.Point(216, 149);
            this.infocmb1.Name = "infocmb1";
            this.infocmb1.Size = new System.Drawing.Size(0, 17);
            this.infocmb1.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 21;
            this.label5.Text = "Rusak";
            // 
            // infocmb2
            // 
            this.infocmb2.AutoSize = true;
            this.infocmb2.Location = new System.Drawing.Point(216, 191);
            this.infocmb2.Name = "infocmb2";
            this.infocmb2.Size = new System.Drawing.Size(0, 17);
            this.infocmb2.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 17);
            this.label10.TabIndex = 17;
            this.label10.Text = ":";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(604, 90);
            this.btnRefresh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(87, 30);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "&Segarkan";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Enabled = false;
            this.btnBatal.Location = new System.Drawing.Point(714, 90);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(87, 30);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(824, 90);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Perbarui";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Location = new System.Drawing.Point(22, 413);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 17);
            this.label13.TabIndex = 6;
            this.label13.Text = "Pencarian";
            // 
            // txtCari
            // 
            this.txtCari.Enabled = false;
            this.txtCari.Location = new System.Drawing.Point(22, 434);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(219, 25);
            this.txtCari.TabIndex = 7;
            this.txtCari.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyUp);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(27, 512);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(87, 30);
            this.btnKembali.TabIndex = 8;
            this.btnKembali.Text = "&Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(248, 436);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(15, 14);
            this.radioButton1.TabIndex = 10;
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.radioButton1);
            this.bunifuGradientPanel1.Controls.Add(this.viewAlatKerja);
            this.bunifuGradientPanel1.Controls.Add(this.btnKembali);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.txtCari);
            this.bunifuGradientPanel1.Controls.Add(this.updateGrup);
            this.bunifuGradientPanel1.Controls.Add(this.label13);
            this.bunifuGradientPanel1.Controls.Add(this.btnRefresh);
            this.bunifuGradientPanel1.Controls.Add(this.btnUpdate);
            this.bunifuGradientPanel1.Controls.Add(this.btnBatal);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1077, 557);
            this.bunifuGradientPanel1.TabIndex = 11;
            // 
            // UpdateAlatKerja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 557);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateAlatKerja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UpdateAlatKerja_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAlatKerja)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msalatkerjaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakuraDataDataSet2)).EndInit();
            this.updateGrup.ResumeLayout(false);
            this.updateGrup.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewAlatKerja;
        private System.Windows.Forms.Label label1;
        private SakuraDataDataSet2 sakuraDataDataSet2;
        private System.Windows.Forms.BindingSource msalatkerjaBindingSource;
        private SakuraDataDataSet2TableAdapters.msalatkerjaTableAdapter msalatkerjaTableAdapter;
        private System.Windows.Forms.GroupBox updateGrup;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Label txtid_alat_kerja;
        private System.Windows.Forms.ComboBox cmbbagus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbrusak;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtjumlah;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtnama_alat_kerja;
        private System.Windows.Forms.Label infonama_alat_kerja;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label info_jumlah;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label infocmb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label infocmb2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus1;
        private System.Windows.Forms.Button btnPlus1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.CheckBox radioButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaalatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jumlahDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bagusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rusakDataGridViewTextBoxColumn;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}