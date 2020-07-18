namespace CRUD
{
    partial class DetailReparasi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailReparasi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableReparasi = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbGagal = new System.Windows.Forms.RadioButton();
            this.rbSelesai = new System.Windows.Forms.RadioButton();
            this.txtid_gudang = new System.Windows.Forms.TextBox();
            this.panelKomponen = new System.Windows.Forms.Panel();
            this.btnTambah = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtharga_total = new System.Windows.Forms.TextBox();
            this.txtjumlah = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnama_komponen = new System.Windows.Forms.TextBox();
            this.txtharga_komponen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotalHarga = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBiaya = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtkode_transaksi = new System.Windows.Forms.TextBox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSimpan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.tableKomponen = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbSortir = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tanggal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableReparasi)).BeginInit();
            this.panel2.SuspendLayout();
            this.panelKomponen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtjumlah)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKomponen)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cmbSortir);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.tableReparasi);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox4);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 374);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // tableReparasi
            // 
            this.tableReparasi.AllowUserToAddRows = false;
            this.tableReparasi.AllowUserToDeleteRows = false;
            this.tableReparasi.AllowUserToResizeColumns = false;
            this.tableReparasi.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableReparasi.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.tableReparasi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableReparasi.BackgroundColor = System.Drawing.Color.White;
            this.tableReparasi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableReparasi.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableReparasi.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableReparasi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.tableReparasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableReparasi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column7,
            this.Tanggal});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableReparasi.DefaultCellStyle = dataGridViewCellStyle9;
            this.tableReparasi.DoubleBuffered = true;
            this.tableReparasi.EnableHeadersVisualStyles = false;
            this.tableReparasi.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.tableReparasi.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.tableReparasi.HeaderForeColor = System.Drawing.Color.White;
            this.tableReparasi.Location = new System.Drawing.Point(4, 52);
            this.tableReparasi.Name = "tableReparasi";
            this.tableReparasi.ReadOnly = true;
            this.tableReparasi.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableReparasi.RowHeadersVisible = false;
            this.tableReparasi.Size = new System.Drawing.Size(1185, 317);
            this.tableReparasi.TabIndex = 28;
            this.tableReparasi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableReparasi_CellClick);
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.BackColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox4.Enabled = false;
            this.bunifuMaterialTextbox4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox4.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox4.HintText = "";
            this.bunifuMaterialTextbox4.isPassword = false;
            this.bunifuMaterialTextbox4.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox4.LineThickness = 4;
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(4, 5);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(1185, 39);
            this.bunifuMaterialTextbox4.TabIndex = 1;
            this.bunifuMaterialTextbox4.Text = "Reparasi Alat";
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.rbGagal);
            this.panel2.Controls.Add(this.rbSelesai);
            this.panel2.Controls.Add(this.txtid_gudang);
            this.panel2.Controls.Add(this.panelKomponen);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtTotalHarga);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtBiaya);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtkode_transaksi);
            this.panel2.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel2.Controls.Add(this.btnSimpan);
            this.panel2.Controls.Add(this.tableKomponen);
            this.panel2.Location = new System.Drawing.Point(3, 383);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 289);
            this.panel2.TabIndex = 1;
            // 
            // rbGagal
            // 
            this.rbGagal.AutoSize = true;
            this.rbGagal.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbGagal.Location = new System.Drawing.Point(480, 10);
            this.rbGagal.Name = "rbGagal";
            this.rbGagal.Size = new System.Drawing.Size(63, 21);
            this.rbGagal.TabIndex = 60;
            this.rbGagal.Text = "Gagal";
            this.rbGagal.UseVisualStyleBackColor = true;
            this.rbGagal.CheckedChanged += new System.EventHandler(this.rbSelesai_CheckedChanged);
            // 
            // rbSelesai
            // 
            this.rbSelesai.AutoSize = true;
            this.rbSelesai.Checked = true;
            this.rbSelesai.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSelesai.Location = new System.Drawing.Point(405, 10);
            this.rbSelesai.Name = "rbSelesai";
            this.rbSelesai.Size = new System.Drawing.Size(68, 21);
            this.rbSelesai.TabIndex = 59;
            this.rbSelesai.TabStop = true;
            this.rbSelesai.Text = "Selesai";
            this.rbSelesai.UseVisualStyleBackColor = true;
            this.rbSelesai.CheckedChanged += new System.EventHandler(this.rbSelesai_CheckedChanged);
            // 
            // txtid_gudang
            // 
            this.txtid_gudang.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtid_gudang.Location = new System.Drawing.Point(405, 45);
            this.txtid_gudang.Name = "txtid_gudang";
            this.txtid_gudang.Size = new System.Drawing.Size(144, 26);
            this.txtid_gudang.TabIndex = 58;
            this.txtid_gudang.Text = "- ID GUDANG -";
            this.txtid_gudang.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panelKomponen
            // 
            this.panelKomponen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelKomponen.Controls.Add(this.btnTambah);
            this.panelKomponen.Controls.Add(this.bunifuMaterialTextbox2);
            this.panelKomponen.Controls.Add(this.label7);
            this.panelKomponen.Controls.Add(this.txtharga_total);
            this.panelKomponen.Controls.Add(this.txtjumlah);
            this.panelKomponen.Controls.Add(this.label6);
            this.panelKomponen.Controls.Add(this.label1);
            this.panelKomponen.Controls.Add(this.label5);
            this.panelKomponen.Controls.Add(this.txtnama_komponen);
            this.panelKomponen.Controls.Add(this.txtharga_komponen);
            this.panelKomponen.Location = new System.Drawing.Point(6, 77);
            this.panelKomponen.Name = "panelKomponen";
            this.panelKomponen.Size = new System.Drawing.Size(542, 207);
            this.panelKomponen.TabIndex = 57;
            // 
            // btnTambah
            // 
            this.btnTambah.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnTambah.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnTambah.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTambah.BorderRadius = 0;
            this.btnTambah.ButtonText = "Tambah";
            this.btnTambah.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTambah.DisabledColor = System.Drawing.Color.Gray;
            this.btnTambah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnTambah.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTambah.Iconimage = null;
            this.btnTambah.Iconimage_right = null;
            this.btnTambah.Iconimage_right_Selected = null;
            this.btnTambah.Iconimage_Selected = null;
            this.btnTambah.IconMarginLeft = 0;
            this.btnTambah.IconMarginRight = 0;
            this.btnTambah.IconRightVisible = true;
            this.btnTambah.IconRightZoom = 0D;
            this.btnTambah.IconVisible = true;
            this.btnTambah.IconZoom = 90D;
            this.btnTambah.IsTab = false;
            this.btnTambah.Location = new System.Drawing.Point(0, 169);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnTambah.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnTambah.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnTambah.selected = false;
            this.btnTambah.Size = new System.Drawing.Size(540, 36);
            this.btnTambah.TabIndex = 63;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTambah.Textcolor = System.Drawing.Color.White;
            this.btnTambah.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox2.Enabled = false;
            this.bunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox2.HintText = "";
            this.bunifuMaterialTextbox2.isPassword = false;
            this.bunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox2.LineThickness = 4;
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(4, 1);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(532, 34);
            this.bunifuMaterialTextbox2.TabIndex = 62;
            this.bunifuMaterialTextbox2.Text = "Tambah Komponen Reparasi";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 24);
            this.label7.TabIndex = 60;
            this.label7.Text = "Harga total";
            // 
            // txtharga_total
            // 
            this.txtharga_total.Enabled = false;
            this.txtharga_total.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtharga_total.Location = new System.Drawing.Point(149, 140);
            this.txtharga_total.Name = "txtharga_total";
            this.txtharga_total.ReadOnly = true;
            this.txtharga_total.Size = new System.Drawing.Size(388, 26);
            this.txtharga_total.TabIndex = 61;
            this.txtharga_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtjumlah
            // 
            this.txtjumlah.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtjumlah.Location = new System.Drawing.Point(149, 108);
            this.txtjumlah.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtjumlah.Name = "txtjumlah";
            this.txtjumlah.Size = new System.Drawing.Size(65, 26);
            this.txtjumlah.TabIndex = 59;
            this.txtjumlah.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txtjumlah.ValueChanged += new System.EventHandler(this.txtjumlah_ValueChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(6, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 24);
            this.label6.TabIndex = 57;
            this.label6.Text = "Jumlah";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(6, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 24);
            this.label1.TabIndex = 49;
            this.label1.Text = "Komponen";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 24);
            this.label5.TabIndex = 55;
            this.label5.Text = "Harga";
            // 
            // txtnama_komponen
            // 
            this.txtnama_komponen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnama_komponen.Location = new System.Drawing.Point(149, 40);
            this.txtnama_komponen.Name = "txtnama_komponen";
            this.txtnama_komponen.Size = new System.Drawing.Size(387, 26);
            this.txtnama_komponen.TabIndex = 50;
            this.txtnama_komponen.TextChanged += new System.EventHandler(this.txtnama_komponen_TextChanged);
            // 
            // txtharga_komponen
            // 
            this.txtharga_komponen.Enabled = false;
            this.txtharga_komponen.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtharga_komponen.Location = new System.Drawing.Point(149, 76);
            this.txtharga_komponen.Name = "txtharga_komponen";
            this.txtharga_komponen.ReadOnly = true;
            this.txtharga_komponen.Size = new System.Drawing.Size(388, 26);
            this.txtharga_komponen.TabIndex = 56;
            this.txtharga_komponen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(939, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 27);
            this.label4.TabIndex = 53;
            this.label4.Text = "Total";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTotalHarga
            // 
            this.txtTotalHarga.Enabled = false;
            this.txtTotalHarga.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalHarga.Location = new System.Drawing.Point(1002, 216);
            this.txtTotalHarga.Name = "txtTotalHarga";
            this.txtTotalHarga.ReadOnly = true;
            this.txtTotalHarga.Size = new System.Drawing.Size(187, 26);
            this.txtTotalHarga.TabIndex = 54;
            this.txtTotalHarga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(552, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Biaya reparasi  Rp";
            // 
            // txtBiaya
            // 
            this.txtBiaya.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBiaya.Location = new System.Drawing.Point(707, 218);
            this.txtBiaya.Name = "txtBiaya";
            this.txtBiaya.Size = new System.Drawing.Size(201, 26);
            this.txtBiaya.TabIndex = 52;
            this.txtBiaya.Text = "0.00";
            this.txtBiaya.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBiaya.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBiaya_KeyPress);
            this.txtBiaya.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBiaya_KeyUp);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 47;
            this.label2.Text = "Kode reparasi";
            // 
            // txtkode_transaksi
            // 
            this.txtkode_transaksi.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtkode_transaksi.Location = new System.Drawing.Point(156, 45);
            this.txtkode_transaksi.Name = "txtkode_transaksi";
            this.txtkode_transaksi.ReadOnly = true;
            this.txtkode_transaksi.Size = new System.Drawing.Size(234, 26);
            this.txtkode_transaksi.TabIndex = 48;
            this.txtkode_transaksi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Enabled = false;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(4, 1);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(544, 39);
            this.bunifuMaterialTextbox1.TabIndex = 46;
            this.bunifuMaterialTextbox1.Text = "Detail Reparasi";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnSimpan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnSimpan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSimpan.BorderRadius = 0;
            this.btnSimpan.ButtonText = "Simpan";
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.DisabledColor = System.Drawing.Color.Gray;
            this.btnSimpan.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSimpan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnSimpan.Iconimage")));
            this.btnSimpan.Iconimage_right = null;
            this.btnSimpan.Iconimage_right_Selected = null;
            this.btnSimpan.Iconimage_Selected = null;
            this.btnSimpan.IconMarginLeft = 0;
            this.btnSimpan.IconMarginRight = 0;
            this.btnSimpan.IconRightVisible = true;
            this.btnSimpan.IconRightZoom = 0D;
            this.btnSimpan.IconVisible = true;
            this.btnSimpan.IconZoom = 90D;
            this.btnSimpan.IsTab = false;
            this.btnSimpan.Location = new System.Drawing.Point(555, 247);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnSimpan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnSimpan.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSimpan.selected = false;
            this.btnSimpan.Size = new System.Drawing.Size(634, 37);
            this.btnSimpan.TabIndex = 45;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSimpan.Textcolor = System.Drawing.Color.White;
            this.btnSimpan.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // tableKomponen
            // 
            this.tableKomponen.AllowUserToAddRows = false;
            this.tableKomponen.AllowUserToDeleteRows = false;
            this.tableKomponen.AllowUserToResizeColumns = false;
            this.tableKomponen.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tableKomponen.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.tableKomponen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableKomponen.BackgroundColor = System.Drawing.Color.White;
            this.tableKomponen.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tableKomponen.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.tableKomponen.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableKomponen.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.tableKomponen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableKomponen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.Column10,
            this.dataGridViewTextBoxColumn2,
            this.Column8,
            this.Column9});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Century Gothic", 9F);
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.tableKomponen.DefaultCellStyle = dataGridViewCellStyle12;
            this.tableKomponen.DoubleBuffered = true;
            this.tableKomponen.EnableHeadersVisualStyles = false;
            this.tableKomponen.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.tableKomponen.HeaderBgColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.tableKomponen.HeaderForeColor = System.Drawing.Color.White;
            this.tableKomponen.Location = new System.Drawing.Point(555, 5);
            this.tableKomponen.Name = "tableKomponen";
            this.tableKomponen.ReadOnly = true;
            this.tableKomponen.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tableKomponen.RowHeadersVisible = false;
            this.tableKomponen.Size = new System.Drawing.Size(635, 207);
            this.tableKomponen.TabIndex = 28;
            this.tableKomponen.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tableKomponen_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 48;
            // 
            // Column10
            // 
            this.Column10.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column10.HeaderText = "Kode";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 62;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Komponen";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column8.HeaderText = "Jumlah";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 73;
            // 
            // Column9
            // 
            this.Column9.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column9.HeaderText = "Harga";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 67;
            // 
            // cmbSortir
            // 
            this.cmbSortir.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortir.FormattingEnabled = true;
            this.cmbSortir.Items.AddRange(new object[] {
            "Semua",
            "Diproses",
            "Selesai"});
            this.cmbSortir.Location = new System.Drawing.Point(1002, 5);
            this.cmbSortir.Name = "cmbSortir";
            this.cmbSortir.Size = new System.Drawing.Size(187, 25);
            this.cmbSortir.TabIndex = 45;
            this.cmbSortir.Text = "- Pilih Sortir -";
            this.cmbSortir.SelectedIndexChanged += new System.EventHandler(this.cmbSortir_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label8.Location = new System.Drawing.Point(819, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(206, 24);
            this.label8.TabIndex = 44;
            this.label8.Text = "Kelompok berdasarkan";
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column6.HeaderText = "No";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 48;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column1.HeaderText = "Kode";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 62;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Pelanggan";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column3.HeaderText = "Jenis Alat";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 88;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column4.HeaderText = "Alat Elektronik";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 115;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.HeaderText = "Keluhan";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Column7.HeaderText = "Status";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 68;
            // 
            // Tanggal
            // 
            this.Tanggal.HeaderText = "Tanggal";
            this.Tanggal.Name = "Tanggal";
            this.Tanggal.ReadOnly = true;
            // 
            // DetailReparasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "DetailReparasi";
            this.Size = new System.Drawing.Size(1201, 675);
            this.Load += new System.EventHandler(this.DetailReparasi_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tableReparasi)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelKomponen.ResumeLayout(false);
            this.panelKomponen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtjumlah)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableKomponen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tableReparasi;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid tableKomponen;
        private Bunifu.Framework.UI.BunifuFlatButton btnSimpan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private System.Windows.Forms.Panel panelKomponen;
        private Bunifu.Framework.UI.BunifuFlatButton btnTambah;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtharga_total;
        private System.Windows.Forms.NumericUpDown txtjumlah;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnama_komponen;
        private System.Windows.Forms.TextBox txtharga_komponen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotalHarga;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBiaya;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtkode_transaksi;
        private System.Windows.Forms.TextBox txtid_gudang;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.RadioButton rbGagal;
        private System.Windows.Forms.RadioButton rbSelesai;
        private System.Windows.Forms.ComboBox cmbSortir;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tanggal;
    }
}
