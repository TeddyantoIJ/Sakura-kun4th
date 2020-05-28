namespace CRUD
{
    partial class UpdateAlatKomponenSupplier
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.viewAlatSupplier = new System.Windows.Forms.DataGridView();
            this.viewKomponenSupplier = new System.Windows.Forms.DataGridView();
            this.komponenSupplier = new CRUD.komponenSupplier();
            this.mskomponensupplierBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mskomponensupplierTableAdapter = new CRUD.komponenSupplierTableAdapters.mskomponensupplierTableAdapter();
            this.cbAlat = new System.Windows.Forms.CheckBox();
            this.cbKomponen = new System.Windows.Forms.CheckBox();
            this.btnKembali = new System.Windows.Forms.Button();
            this.pembaruanAlat = new System.Windows.Forms.GroupBox();
            this.txtnama_alat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnama_supplier = new System.Windows.Forms.TextBox();
            this.txtid_alat = new System.Windows.Forms.Label();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtid_supplier = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pembaruanKomponen = new System.Windows.Forms.GroupBox();
            this.txtnama_komponen = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtnama_supplier1 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtharga1 = new System.Windows.Forms.TextBox();
            this.txtid_komponen = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtid_supplier1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewAlatSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKomponenSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponenSupplier)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mskomponensupplierBindingSource)).BeginInit();
            this.pembaruanAlat.SuspendLayout();
            this.pembaruanKomponen.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(319, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pengelolaan Data Supplier";
            // 
            // viewAlatSupplier
            // 
            this.viewAlatSupplier.AllowUserToAddRows = false;
            this.viewAlatSupplier.AllowUserToDeleteRows = false;
            this.viewAlatSupplier.AllowUserToResizeColumns = false;
            this.viewAlatSupplier.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewAlatSupplier.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewAlatSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.viewAlatSupplier.DefaultCellStyle = dataGridViewCellStyle2;
            this.viewAlatSupplier.Location = new System.Drawing.Point(14, 103);
            this.viewAlatSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewAlatSupplier.Name = "viewAlatSupplier";
            this.viewAlatSupplier.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.viewAlatSupplier.Size = new System.Drawing.Size(401, 290);
            this.viewAlatSupplier.TabIndex = 1;
            this.viewAlatSupplier.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewAlatSupplier_CellEnter);
            // 
            // viewKomponenSupplier
            // 
            this.viewKomponenSupplier.AllowUserToAddRows = false;
            this.viewKomponenSupplier.AllowUserToDeleteRows = false;
            this.viewKomponenSupplier.AllowUserToResizeColumns = false;
            this.viewKomponenSupplier.AllowUserToResizeRows = false;
            this.viewKomponenSupplier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewKomponenSupplier.Enabled = false;
            this.viewKomponenSupplier.Location = new System.Drawing.Point(469, 103);
            this.viewKomponenSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.viewKomponenSupplier.Name = "viewKomponenSupplier";
            this.viewKomponenSupplier.Size = new System.Drawing.Size(401, 290);
            this.viewKomponenSupplier.TabIndex = 2;
            this.viewKomponenSupplier.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.viewKomponenSupplier_CellEnter);
            // 
            // komponenSupplier
            // 
            this.komponenSupplier.DataSetName = "komponenSupplier";
            this.komponenSupplier.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // mskomponensupplierBindingSource
            // 
            this.mskomponensupplierBindingSource.DataMember = "mskomponensupplier";
            this.mskomponensupplierBindingSource.DataSource = this.komponenSupplier;
            // 
            // mskomponensupplierTableAdapter
            // 
            this.mskomponensupplierTableAdapter.ClearBeforeFill = true;
            // 
            // cbAlat
            // 
            this.cbAlat.AutoSize = true;
            this.cbAlat.Checked = true;
            this.cbAlat.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbAlat.Location = new System.Drawing.Point(14, 73);
            this.cbAlat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbAlat.Name = "cbAlat";
            this.cbAlat.Size = new System.Drawing.Size(101, 21);
            this.cbAlat.TabIndex = 3;
            this.cbAlat.Text = "Alat Supplier";
            this.cbAlat.UseVisualStyleBackColor = true;
            this.cbAlat.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbKomponen
            // 
            this.cbKomponen.AutoSize = true;
            this.cbKomponen.Location = new System.Drawing.Point(469, 73);
            this.cbKomponen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbKomponen.Name = "cbKomponen";
            this.cbKomponen.Size = new System.Drawing.Size(143, 21);
            this.cbKomponen.TabIndex = 4;
            this.cbKomponen.Text = "Komponen Supplier";
            this.cbKomponen.UseVisualStyleBackColor = true;
            this.cbKomponen.CheckedChanged += new System.EventHandler(this.cbKomponen_CheckedChanged);
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(14, 662);
            this.btnKembali.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(87, 30);
            this.btnKembali.TabIndex = 5;
            this.btnKembali.Text = "&Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // pembaruanAlat
            // 
            this.pembaruanAlat.Controls.Add(this.txtnama_alat);
            this.pembaruanAlat.Controls.Add(this.label2);
            this.pembaruanAlat.Controls.Add(this.txtnama_supplier);
            this.pembaruanAlat.Controls.Add(this.txtid_alat);
            this.pembaruanAlat.Controls.Add(this.txtharga);
            this.pembaruanAlat.Controls.Add(this.txtid_supplier);
            this.pembaruanAlat.Controls.Add(this.label7);
            this.pembaruanAlat.Controls.Add(this.label3);
            this.pembaruanAlat.Controls.Add(this.label6);
            this.pembaruanAlat.Controls.Add(this.label5);
            this.pembaruanAlat.Controls.Add(this.label8);
            this.pembaruanAlat.Controls.Add(this.label4);
            this.pembaruanAlat.Location = new System.Drawing.Point(14, 401);
            this.pembaruanAlat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pembaruanAlat.Name = "pembaruanAlat";
            this.pembaruanAlat.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pembaruanAlat.Size = new System.Drawing.Size(401, 234);
            this.pembaruanAlat.TabIndex = 6;
            this.pembaruanAlat.TabStop = false;
            this.pembaruanAlat.Text = "Pembaruan Alat";
            this.pembaruanAlat.EnabledChanged += new System.EventHandler(this.pembaruanAlat_EnabledChanged);
            // 
            // txtnama_alat
            // 
            this.txtnama_alat.Enabled = false;
            this.txtnama_alat.Location = new System.Drawing.Point(131, 33);
            this.txtnama_alat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_alat.Name = "txtnama_alat";
            this.txtnama_alat.Size = new System.Drawing.Size(226, 25);
            this.txtnama_alat.TabIndex = 35;
            this.txtnama_alat.TextChanged += new System.EventHandler(this.txtnama_alat_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 45;
            this.label2.Text = "Nama Alat";
            // 
            // txtnama_supplier
            // 
            this.txtnama_supplier.Enabled = false;
            this.txtnama_supplier.Location = new System.Drawing.Point(131, 118);
            this.txtnama_supplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_supplier.Name = "txtnama_supplier";
            this.txtnama_supplier.Size = new System.Drawing.Size(226, 25);
            this.txtnama_supplier.TabIndex = 44;
            this.txtnama_supplier.TextChanged += new System.EventHandler(this.txtnama_supplier_TextChanged);
            // 
            // txtid_alat
            // 
            this.txtid_alat.AutoSize = true;
            this.txtid_alat.Location = new System.Drawing.Point(131, 76);
            this.txtid_alat.Name = "txtid_alat";
            this.txtid_alat.Size = new System.Drawing.Size(0, 17);
            this.txtid_alat.TabIndex = 36;
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(168, 191);
            this.txtharga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(188, 25);
            this.txtharga.TabIndex = 46;
            this.txtharga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtharga_KeyUp);
            // 
            // txtid_supplier
            // 
            this.txtid_supplier.AutoSize = true;
            this.txtid_supplier.Location = new System.Drawing.Point(131, 158);
            this.txtid_supplier.Name = "txtid_supplier";
            this.txtid_supplier.Size = new System.Drawing.Size(0, 17);
            this.txtid_supplier.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(108, 196);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 43;
            this.label7.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "Nama Supplier";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(108, 123);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 17);
            this.label6.TabIndex = 42;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(131, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 41;
            this.label8.Text = "Rp.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 40;
            this.label4.Text = "Harga";
            // 
            // pembaruanKomponen
            // 
            this.pembaruanKomponen.Controls.Add(this.txtnama_komponen);
            this.pembaruanKomponen.Controls.Add(this.label14);
            this.pembaruanKomponen.Controls.Add(this.txtnama_supplier1);
            this.pembaruanKomponen.Controls.Add(this.label16);
            this.pembaruanKomponen.Controls.Add(this.txtharga1);
            this.pembaruanKomponen.Controls.Add(this.txtid_komponen);
            this.pembaruanKomponen.Controls.Add(this.label9);
            this.pembaruanKomponen.Controls.Add(this.txtid_supplier1);
            this.pembaruanKomponen.Controls.Add(this.label10);
            this.pembaruanKomponen.Controls.Add(this.label13);
            this.pembaruanKomponen.Controls.Add(this.label11);
            this.pembaruanKomponen.Controls.Add(this.label12);
            this.pembaruanKomponen.Enabled = false;
            this.pembaruanKomponen.Location = new System.Drawing.Point(469, 401);
            this.pembaruanKomponen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pembaruanKomponen.Name = "pembaruanKomponen";
            this.pembaruanKomponen.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pembaruanKomponen.Size = new System.Drawing.Size(401, 234);
            this.pembaruanKomponen.TabIndex = 7;
            this.pembaruanKomponen.TabStop = false;
            this.pembaruanKomponen.Text = "Pembaruan Komponen";
            this.pembaruanKomponen.EnabledChanged += new System.EventHandler(this.pembaruanKomponen_EnabledChanged);
            // 
            // txtnama_komponen
            // 
            this.txtnama_komponen.Enabled = false;
            this.txtnama_komponen.Location = new System.Drawing.Point(125, 29);
            this.txtnama_komponen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_komponen.Name = "txtnama_komponen";
            this.txtnama_komponen.Size = new System.Drawing.Size(226, 25);
            this.txtnama_komponen.TabIndex = 8;
            this.txtnama_komponen.TextChanged += new System.EventHandler(this.txtnama_komponen_TextChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(95, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Nama Supplier";
            // 
            // txtnama_supplier1
            // 
            this.txtnama_supplier1.Enabled = false;
            this.txtnama_supplier1.Location = new System.Drawing.Point(125, 114);
            this.txtnama_supplier1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_supplier1.Name = "txtnama_supplier1";
            this.txtnama_supplier1.Size = new System.Drawing.Size(226, 25);
            this.txtnama_supplier1.TabIndex = 9;
            this.txtnama_supplier1.TextChanged += new System.EventHandler(this.txtnama_supplier1_TextChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(111, 17);
            this.label16.TabIndex = 18;
            this.label16.Text = "Nama Komponen";
            // 
            // txtharga1
            // 
            this.txtharga1.Location = new System.Drawing.Point(162, 187);
            this.txtharga1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtharga1.Name = "txtharga1";
            this.txtharga1.Size = new System.Drawing.Size(188, 25);
            this.txtharga1.TabIndex = 19;
            this.txtharga1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtharga1_KeyUp);
            // 
            // txtid_komponen
            // 
            this.txtid_komponen.AutoSize = true;
            this.txtid_komponen.Location = new System.Drawing.Point(125, 72);
            this.txtid_komponen.Name = "txtid_komponen";
            this.txtid_komponen.Size = new System.Drawing.Size(0, 17);
            this.txtid_komponen.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(11, 17);
            this.label9.TabIndex = 10;
            this.label9.Text = ":";
            // 
            // txtid_supplier1
            // 
            this.txtid_supplier1.AutoSize = true;
            this.txtid_supplier1.Location = new System.Drawing.Point(125, 154);
            this.txtid_supplier1.Name = "txtid_supplier1";
            this.txtid_supplier1.Size = new System.Drawing.Size(0, 17);
            this.txtid_supplier1.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(103, 119);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(11, 17);
            this.label10.TabIndex = 11;
            this.label10.Text = ":";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(104, 33);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(11, 17);
            this.label13.TabIndex = 14;
            this.label13.Text = ":";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(125, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 17);
            this.label11.TabIndex = 12;
            this.label11.Text = "Rp.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 192);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 17);
            this.label12.TabIndex = 13;
            this.label12.Text = "Harga";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(784, 662);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "&Simpan";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Enabled = false;
            this.btnBatal.Location = new System.Drawing.Point(689, 662);
            this.btnBatal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(87, 30);
            this.btnBatal.TabIndex = 9;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // UpdateAlatKomponenSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 696);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pembaruanKomponen);
            this.Controls.Add(this.pembaruanAlat);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.cbKomponen);
            this.Controls.Add(this.cbAlat);
            this.Controls.Add(this.viewKomponenSupplier);
            this.Controls.Add(this.viewAlatSupplier);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "UpdateAlatKomponenSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateAlatKomponenSupplier";
            this.Load += new System.EventHandler(this.UpdateAlatKomponenSupplier_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewAlatSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewKomponenSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.komponenSupplier)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mskomponensupplierBindingSource)).EndInit();
            this.pembaruanAlat.ResumeLayout(false);
            this.pembaruanAlat.PerformLayout();
            this.pembaruanKomponen.ResumeLayout(false);
            this.pembaruanKomponen.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewAlatSupplier;
        private System.Windows.Forms.DataGridView viewKomponenSupplier;
        private komponenSupplier komponenSupplier;
        private System.Windows.Forms.BindingSource mskomponensupplierBindingSource;
        private komponenSupplierTableAdapters.mskomponensupplierTableAdapter mskomponensupplierTableAdapter;
        private System.Windows.Forms.CheckBox cbAlat;
        private System.Windows.Forms.CheckBox cbKomponen;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.GroupBox pembaruanAlat;
        private System.Windows.Forms.TextBox txtnama_alat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnama_supplier;
        private System.Windows.Forms.Label txtid_alat;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Label txtid_supplier;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox pembaruanKomponen;
        private System.Windows.Forms.TextBox txtnama_komponen;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtnama_supplier1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtharga1;
        private System.Windows.Forms.Label txtid_komponen;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtid_supplier1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnBatal;
    }
}