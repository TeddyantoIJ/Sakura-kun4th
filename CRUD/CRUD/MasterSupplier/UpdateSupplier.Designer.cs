namespace CRUD
{
    partial class UpdateSupplier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateSupplier));
            this.viewSupplier = new System.Windows.Forms.DataGridView();
            this.idsupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namasupplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactpersonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noteleponDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alamatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.keteranganDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mssupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sakuraDataDataSet = new CRUD.SakuraDataDataSet();
            this.mssupplierTableAdapter = new CRUD.SakuraDataDataSetTableAdapters.mssupplierTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtketerangan = new System.Windows.Forms.TextBox();
            this.txtalamat = new System.Windows.Forms.TextBox();
            this.txtno_telepon = new System.Windows.Forms.TextBox();
            this.txtcontact_person = new System.Windows.Forms.TextBox();
            this.txtnama_supplier = new System.Windows.Forms.TextBox();
            this.txtid_supplier = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.infoalamat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.infono_telepon = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.infocontact_person = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infonama_supplier = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.updateGrup = new System.Windows.Forms.GroupBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbTriger = new System.Windows.Forms.ComboBox();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.viewSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssupplierBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakuraDataDataSet)).BeginInit();
            this.updateGrup.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // viewSupplier
            // 
            this.viewSupplier.AllowUserToAddRows = false;
            this.viewSupplier.AllowUserToDeleteRows = false;
            this.viewSupplier.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewSupplier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsupplierDataGridViewTextBoxColumn,
            this.namasupplierDataGridViewTextBoxColumn,
            this.contactpersonDataGridViewTextBoxColumn,
            this.noteleponDataGridViewTextBoxColumn,
            this.alamatDataGridViewTextBoxColumn,
            this.keteranganDataGridViewTextBoxColumn});
            this.viewSupplier.DataSource = this.mssupplierBindingSource;
            this.viewSupplier.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.viewSupplier.Location = new System.Drawing.Point(12, 117);
            this.viewSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewSupplier.Name = "viewSupplier";
            this.viewSupplier.ReadOnly = true;
            this.viewSupplier.Size = new System.Drawing.Size(598, 276);
            this.viewSupplier.TabIndex = 0;
            this.viewSupplier.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewSupplier_CellClick);
            this.viewSupplier.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewSupplier_CellEnter);
            // 
            // idsupplierDataGridViewTextBoxColumn
            // 
            this.idsupplierDataGridViewTextBoxColumn.DataPropertyName = "id_supplier";
            this.idsupplierDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idsupplierDataGridViewTextBoxColumn.Name = "idsupplierDataGridViewTextBoxColumn";
            this.idsupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // namasupplierDataGridViewTextBoxColumn
            // 
            this.namasupplierDataGridViewTextBoxColumn.DataPropertyName = "nama_supplier";
            this.namasupplierDataGridViewTextBoxColumn.HeaderText = "Nama";
            this.namasupplierDataGridViewTextBoxColumn.Name = "namasupplierDataGridViewTextBoxColumn";
            this.namasupplierDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // contactpersonDataGridViewTextBoxColumn
            // 
            this.contactpersonDataGridViewTextBoxColumn.DataPropertyName = "contact_person";
            this.contactpersonDataGridViewTextBoxColumn.HeaderText = "Contact Person";
            this.contactpersonDataGridViewTextBoxColumn.Name = "contactpersonDataGridViewTextBoxColumn";
            this.contactpersonDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noteleponDataGridViewTextBoxColumn
            // 
            this.noteleponDataGridViewTextBoxColumn.DataPropertyName = "no_telepon";
            this.noteleponDataGridViewTextBoxColumn.HeaderText = "No Telepon";
            this.noteleponDataGridViewTextBoxColumn.Name = "noteleponDataGridViewTextBoxColumn";
            this.noteleponDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // alamatDataGridViewTextBoxColumn
            // 
            this.alamatDataGridViewTextBoxColumn.DataPropertyName = "alamat";
            this.alamatDataGridViewTextBoxColumn.HeaderText = "Alamat";
            this.alamatDataGridViewTextBoxColumn.Name = "alamatDataGridViewTextBoxColumn";
            this.alamatDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // keteranganDataGridViewTextBoxColumn
            // 
            this.keteranganDataGridViewTextBoxColumn.DataPropertyName = "keterangan";
            this.keteranganDataGridViewTextBoxColumn.HeaderText = "Keterangan";
            this.keteranganDataGridViewTextBoxColumn.Name = "keteranganDataGridViewTextBoxColumn";
            this.keteranganDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mssupplierBindingSource
            // 
            this.mssupplierBindingSource.DataMember = "mssupplier";
            this.mssupplierBindingSource.DataSource = this.sakuraDataDataSet;
            // 
            // sakuraDataDataSet
            // 
            this.sakuraDataDataSet.DataSetName = "SakuraDataDataSet";
            this.sakuraDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mssupplierTableAdapter
            // 
            this.mssupplierTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "DATA PEMASOK";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(637, 117);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "&Perbarui";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(637, 193);
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
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.Enabled = false;
            this.btnBatal.Location = new System.Drawing.Point(637, 155);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(87, 30);
            this.btnBatal.TabIndex = 4;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(12, 535);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(87, 30);
            this.button4.TabIndex = 5;
            this.button4.Text = "&Kembali";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSimpan.Location = new System.Drawing.Point(393, 409);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(87, 30);
            this.btnSimpan.TabIndex = 61;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtketerangan
            // 
            this.txtketerangan.Location = new System.Drawing.Point(169, 331);
            this.txtketerangan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtketerangan.MaxLength = 100;
            this.txtketerangan.Multiline = true;
            this.txtketerangan.Name = "txtketerangan";
            this.txtketerangan.Size = new System.Drawing.Size(234, 72);
            this.txtketerangan.TabIndex = 60;
            // 
            // txtalamat
            // 
            this.txtalamat.Location = new System.Drawing.Point(169, 238);
            this.txtalamat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtalamat.MaxLength = 100;
            this.txtalamat.Multiline = true;
            this.txtalamat.Name = "txtalamat";
            this.txtalamat.Size = new System.Drawing.Size(234, 72);
            this.txtalamat.TabIndex = 59;
            this.txtalamat.Leave += new System.EventHandler(this.txtalamat_Leave);
            // 
            // txtno_telepon
            // 
            this.txtno_telepon.Location = new System.Drawing.Point(169, 180);
            this.txtno_telepon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtno_telepon.MaxLength = 15;
            this.txtno_telepon.Name = "txtno_telepon";
            this.txtno_telepon.Size = new System.Drawing.Size(234, 25);
            this.txtno_telepon.TabIndex = 58;
            this.txtno_telepon.Leave += new System.EventHandler(this.txtno_telepon_Leave);
            // 
            // txtcontact_person
            // 
            this.txtcontact_person.Location = new System.Drawing.Point(169, 128);
            this.txtcontact_person.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcontact_person.MaxLength = 25;
            this.txtcontact_person.Name = "txtcontact_person";
            this.txtcontact_person.Size = new System.Drawing.Size(234, 25);
            this.txtcontact_person.TabIndex = 57;
            this.txtcontact_person.Leave += new System.EventHandler(this.txtcontact_person_Leave);
            // 
            // txtnama_supplier
            // 
            this.txtnama_supplier.Location = new System.Drawing.Point(169, 76);
            this.txtnama_supplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_supplier.MaxLength = 25;
            this.txtnama_supplier.Name = "txtnama_supplier";
            this.txtnama_supplier.Size = new System.Drawing.Size(234, 25);
            this.txtnama_supplier.TabIndex = 56;
            this.txtnama_supplier.Leave += new System.EventHandler(this.txtnama_supplier_Leave);
            // 
            // txtid_supplier
            // 
            this.txtid_supplier.AutoSize = true;
            this.txtid_supplier.Location = new System.Drawing.Point(166, 33);
            this.txtid_supplier.Name = "txtid_supplier";
            this.txtid_supplier.Size = new System.Drawing.Size(61, 17);
            this.txtid_supplier.TabIndex = 55;
            this.txtid_supplier.Text = "Generate";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(141, 331);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 17);
            this.label13.TabIndex = 54;
            this.label13.Text = ":";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(141, 242);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(11, 17);
            this.label12.TabIndex = 51;
            this.label12.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 53;
            this.label7.Text = "Keterangan";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(141, 190);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(11, 17);
            this.label11.TabIndex = 49;
            this.label11.Text = ":";
            // 
            // infoalamat
            // 
            this.infoalamat.AutoSize = true;
            this.infoalamat.Location = new System.Drawing.Point(411, 263);
            this.infoalamat.Name = "infoalamat";
            this.infoalamat.Size = new System.Drawing.Size(0, 17);
            this.infoalamat.TabIndex = 50;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 17);
            this.label6.TabIndex = 52;
            this.label6.Text = "Alamat";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(141, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 17);
            this.label10.TabIndex = 46;
            this.label10.Text = ":";
            // 
            // infono_telepon
            // 
            this.infono_telepon.AutoSize = true;
            this.infono_telepon.Location = new System.Drawing.Point(411, 184);
            this.infono_telepon.Name = "infono_telepon";
            this.infono_telepon.Size = new System.Drawing.Size(0, 17);
            this.infono_telepon.TabIndex = 48;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "No Telepon";
            // 
            // infocontact_person
            // 
            this.infocontact_person.AutoSize = true;
            this.infocontact_person.Location = new System.Drawing.Point(411, 132);
            this.infocontact_person.Name = "infocontact_person";
            this.infocontact_person.Size = new System.Drawing.Size(0, 17);
            this.infocontact_person.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(141, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 43;
            this.label9.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 44;
            this.label4.Text = "Penanggung Jawab";
            // 
            // infonama_supplier
            // 
            this.infonama_supplier.AutoSize = true;
            this.infonama_supplier.Location = new System.Drawing.Point(411, 80);
            this.infonama_supplier.Name = "infonama_supplier";
            this.infonama_supplier.Size = new System.Drawing.Size(0, 17);
            this.infonama_supplier.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(141, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(11, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 41;
            this.label3.Text = "Nama Pemasok";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 40;
            this.label2.Text = "ID Pemasok";
            // 
            // updateGrup
            // 
            this.updateGrup.BackColor = System.Drawing.Color.Transparent;
            this.updateGrup.Controls.Add(this.label2);
            this.updateGrup.Controls.Add(this.btnSimpan);
            this.updateGrup.Controls.Add(this.label3);
            this.updateGrup.Controls.Add(this.txtketerangan);
            this.updateGrup.Controls.Add(this.label8);
            this.updateGrup.Controls.Add(this.txtalamat);
            this.updateGrup.Controls.Add(this.infonama_supplier);
            this.updateGrup.Controls.Add(this.txtno_telepon);
            this.updateGrup.Controls.Add(this.label4);
            this.updateGrup.Controls.Add(this.txtcontact_person);
            this.updateGrup.Controls.Add(this.label9);
            this.updateGrup.Controls.Add(this.txtnama_supplier);
            this.updateGrup.Controls.Add(this.infocontact_person);
            this.updateGrup.Controls.Add(this.txtid_supplier);
            this.updateGrup.Controls.Add(this.label5);
            this.updateGrup.Controls.Add(this.label13);
            this.updateGrup.Controls.Add(this.infono_telepon);
            this.updateGrup.Controls.Add(this.label12);
            this.updateGrup.Controls.Add(this.label10);
            this.updateGrup.Controls.Add(this.label7);
            this.updateGrup.Controls.Add(this.label6);
            this.updateGrup.Controls.Add(this.label11);
            this.updateGrup.Controls.Add(this.infoalamat);
            this.updateGrup.Enabled = false;
            this.updateGrup.Location = new System.Drawing.Point(742, 117);
            this.updateGrup.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateGrup.Name = "updateGrup";
            this.updateGrup.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateGrup.Size = new System.Drawing.Size(486, 447);
            this.updateGrup.TabIndex = 62;
            this.updateGrup.TabStop = false;
            this.updateGrup.Text = "Perbarui";
            // 
            // txtCari
            // 
            this.txtCari.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtCari.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCari.Location = new System.Drawing.Point(161, 439);
            this.txtCari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(249, 25);
            this.txtCari.TabIndex = 63;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            this.txtCari.Enter += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Location = new System.Drawing.Point(12, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 64;
            this.label14.Text = "Pencarian";
            // 
            // cmbTriger
            // 
            this.cmbTriger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbTriger.FormattingEnabled = true;
            this.cmbTriger.Items.AddRange(new object[] {
            "ID Supplier",
            "Nama Supplier",
            "Contact Person",
            "No Telepon",
            "Alamat",
            "Keterangan"});
            this.cmbTriger.Location = new System.Drawing.Point(13, 439);
            this.cmbTriger.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbTriger.Name = "cmbTriger";
            this.cmbTriger.Size = new System.Drawing.Size(140, 25);
            this.cmbTriger.TabIndex = 65;
            this.cmbTriger.Text = "- Pilih Pencarian -";
            this.cmbTriger.SelectedIndexChanged += new System.EventHandler(this.cmbTriger_SelectedIndexChanged);
            this.cmbTriger.TextChanged += new System.EventHandler(this.comboBox1_TextChanged);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.cmbTriger);
            this.bunifuGradientPanel1.Controls.Add(this.viewSupplier);
            this.bunifuGradientPanel1.Controls.Add(this.label14);
            this.bunifuGradientPanel1.Controls.Add(this.label1);
            this.bunifuGradientPanel1.Controls.Add(this.txtCari);
            this.bunifuGradientPanel1.Controls.Add(this.btnUpdate);
            this.bunifuGradientPanel1.Controls.Add(this.updateGrup);
            this.bunifuGradientPanel1.Controls.Add(this.btnRefresh);
            this.bunifuGradientPanel1.Controls.Add(this.button4);
            this.bunifuGradientPanel1.Controls.Add(this.btnBatal);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(1245, 575);
            this.bunifuGradientPanel1.TabIndex = 66;
            // 
            // UpdateSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1245, 575);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.UpdateSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mssupplierBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakuraDataDataSet)).EndInit();
            this.updateGrup.ResumeLayout(false);
            this.updateGrup.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView viewSupplier;
        private SakuraDataDataSet sakuraDataDataSet;
        private System.Windows.Forms.BindingSource mssupplierBindingSource;
        private SakuraDataDataSetTableAdapters.mssupplierTableAdapter mssupplierTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namasupplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactpersonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noteleponDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alamatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn keteranganDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtketerangan;
        private System.Windows.Forms.TextBox txtalamat;
        private System.Windows.Forms.TextBox txtno_telepon;
        private System.Windows.Forms.TextBox txtcontact_person;
        private System.Windows.Forms.TextBox txtnama_supplier;
        private System.Windows.Forms.Label txtid_supplier;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label infoalamat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label infono_telepon;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label infocontact_person;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label infonama_supplier;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox updateGrup;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cmbTriger;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
    }
}