namespace CRUD
{
    partial class UpdateCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.viewcustomer = new System.Windows.Forms.DataGridView();
            this.idcustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namacustomerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totaltransaksiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mscustomerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sakuraDataDataSet1 = new CRUD.SakuraDataDataSet1();
            this.sakuraDataDataSet = new CRUD.SakuraDataDataSet();
            this.sakuraDataDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mscustomerTableAdapter = new CRUD.SakuraDataDataSet1TableAdapters.mscustomerTableAdapter();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.updateGrup = new System.Windows.Forms.GroupBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.txtnama_customer = new System.Windows.Forms.TextBox();
            this.infonama_customer = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txttotal_transaksi = new System.Windows.Forms.Label();
            this.txtid_customer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTriger = new System.Windows.Forms.ComboBox();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.btnKembali = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.viewcustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mscustomerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakuraDataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakuraDataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakuraDataDataSetBindingSource)).BeginInit();
            this.updateGrup.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Customer";
            // 
            // viewcustomer
            // 
            this.viewcustomer.AllowUserToAddRows = false;
            this.viewcustomer.AllowUserToDeleteRows = false;
            this.viewcustomer.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.viewcustomer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.viewcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viewcustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcustomerDataGridViewTextBoxColumn,
            this.namacustomerDataGridViewTextBoxColumn,
            this.totaltransaksiDataGridViewTextBoxColumn});
            this.viewcustomer.DataSource = this.mscustomerBindingSource;
            this.viewcustomer.Location = new System.Drawing.Point(12, 73);
            this.viewcustomer.Name = "viewcustomer";
            this.viewcustomer.ReadOnly = true;
            this.viewcustomer.Size = new System.Drawing.Size(319, 264);
            this.viewcustomer.TabIndex = 1;
            this.viewcustomer.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // idcustomerDataGridViewTextBoxColumn
            // 
            this.idcustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idcustomerDataGridViewTextBoxColumn.DataPropertyName = "id_customer";
            this.idcustomerDataGridViewTextBoxColumn.HeaderText = "ID Customer";
            this.idcustomerDataGridViewTextBoxColumn.Name = "idcustomerDataGridViewTextBoxColumn";
            this.idcustomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcustomerDataGridViewTextBoxColumn.Width = 83;
            // 
            // namacustomerDataGridViewTextBoxColumn
            // 
            this.namacustomerDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.namacustomerDataGridViewTextBoxColumn.DataPropertyName = "nama_customer";
            this.namacustomerDataGridViewTextBoxColumn.HeaderText = "Nama Customer";
            this.namacustomerDataGridViewTextBoxColumn.Name = "namacustomerDataGridViewTextBoxColumn";
            this.namacustomerDataGridViewTextBoxColumn.ReadOnly = true;
            this.namacustomerDataGridViewTextBoxColumn.Width = 98;
            // 
            // totaltransaksiDataGridViewTextBoxColumn
            // 
            this.totaltransaksiDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.totaltransaksiDataGridViewTextBoxColumn.DataPropertyName = "total_transaksi";
            this.totaltransaksiDataGridViewTextBoxColumn.HeaderText = "Total Transaksi";
            this.totaltransaksiDataGridViewTextBoxColumn.Name = "totaltransaksiDataGridViewTextBoxColumn";
            this.totaltransaksiDataGridViewTextBoxColumn.ReadOnly = true;
            this.totaltransaksiDataGridViewTextBoxColumn.Width = 96;
            // 
            // mscustomerBindingSource
            // 
            this.mscustomerBindingSource.DataMember = "mscustomer";
            this.mscustomerBindingSource.DataSource = this.sakuraDataDataSet1;
            // 
            // sakuraDataDataSet1
            // 
            this.sakuraDataDataSet1.DataSetName = "SakuraDataDataSet1";
            this.sakuraDataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sakuraDataDataSet
            // 
            this.sakuraDataDataSet.DataSetName = "SakuraDataDataSet";
            this.sakuraDataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // sakuraDataDataSetBindingSource
            // 
            this.sakuraDataDataSetBindingSource.DataSource = this.sakuraDataDataSet;
            this.sakuraDataDataSetBindingSource.Position = 0;
            // 
            // mscustomerTableAdapter
            // 
            this.mscustomerTableAdapter.ClearBeforeFill = true;
            // 
            // btnBatal
            // 
            this.btnBatal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBatal.Enabled = false;
            this.btnBatal.Location = new System.Drawing.Point(457, 73);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 7;
            this.btnBatal.Text = "&Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRefresh.Location = new System.Drawing.Point(356, 73);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "&Segarkan";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(558, 73);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "&Perbarui";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // updateGrup
            // 
            this.updateGrup.Controls.Add(this.btnSimpan);
            this.updateGrup.Controls.Add(this.txtnama_customer);
            this.updateGrup.Controls.Add(this.infonama_customer);
            this.updateGrup.Controls.Add(this.label8);
            this.updateGrup.Controls.Add(this.label2);
            this.updateGrup.Controls.Add(this.txttotal_transaksi);
            this.updateGrup.Controls.Add(this.txtid_customer);
            this.updateGrup.Controls.Add(this.label6);
            this.updateGrup.Controls.Add(this.label5);
            this.updateGrup.Controls.Add(this.label4);
            this.updateGrup.Controls.Add(this.label3);
            this.updateGrup.Enabled = false;
            this.updateGrup.Location = new System.Drawing.Point(343, 102);
            this.updateGrup.Name = "updateGrup";
            this.updateGrup.Size = new System.Drawing.Size(428, 128);
            this.updateGrup.TabIndex = 8;
            this.updateGrup.TabStop = false;
            this.updateGrup.Text = "Perbarui Customer";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(232, 19);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 16;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // txtnama_customer
            // 
            this.txtnama_customer.Location = new System.Drawing.Point(127, 61);
            this.txtnama_customer.MaxLength = 50;
            this.txtnama_customer.Name = "txtnama_customer";
            this.txtnama_customer.Size = new System.Drawing.Size(180, 20);
            this.txtnama_customer.TabIndex = 14;
            this.txtnama_customer.TextChanged += new System.EventHandler(this.txtnama_customer_TextChanged);
            this.txtnama_customer.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnama_customer_KeyPress);
            this.txtnama_customer.Leave += new System.EventHandler(this.txtnama_customer_Leave);
            // 
            // infonama_customer
            // 
            this.infonama_customer.AutoSize = true;
            this.infonama_customer.Location = new System.Drawing.Point(314, 65);
            this.infonama_customer.Name = "infonama_customer";
            this.infonama_customer.Size = new System.Drawing.Size(0, 13);
            this.infonama_customer.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Transaksi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "ID Customer";
            // 
            // txttotal_transaksi
            // 
            this.txttotal_transaksi.AutoSize = true;
            this.txttotal_transaksi.Location = new System.Drawing.Point(126, 96);
            this.txttotal_transaksi.Name = "txttotal_transaksi";
            this.txttotal_transaksi.Size = new System.Drawing.Size(0, 13);
            this.txttotal_transaksi.TabIndex = 10;
            // 
            // txtid_customer
            // 
            this.txtid_customer.AutoSize = true;
            this.txtid_customer.Location = new System.Drawing.Point(126, 27);
            this.txtid_customer.Name = "txtid_customer";
            this.txtid_customer.Size = new System.Drawing.Size(0, 13);
            this.txtid_customer.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(110, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(10, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(10, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nama Customer";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(349, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Pencarian";
            // 
            // cmbTriger
            // 
            this.cmbTriger.AutoCompleteCustomSource.AddRange(new string[] {
            "ID Customer",
            "Nama Customer"});
            this.cmbTriger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.cmbTriger.FormattingEnabled = true;
            this.cmbTriger.Items.AddRange(new object[] {
            "ID Customer",
            "Nama Customer"});
            this.cmbTriger.Location = new System.Drawing.Point(352, 274);
            this.cmbTriger.Name = "cmbTriger";
            this.cmbTriger.Size = new System.Drawing.Size(121, 21);
            this.cmbTriger.TabIndex = 18;
            this.cmbTriger.Text = "- Pilih Kategori -";
            this.cmbTriger.TextChanged += new System.EventHandler(this.cmbTriger_TextChanged);
            this.cmbTriger.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbTriger_KeyPress);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(480, 274);
            this.txtCari.MaxLength = 50;
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(201, 20);
            this.txtCari.TabIndex = 19;
            this.txtCari.TextChanged += new System.EventHandler(this.txtCari_TextChanged);
            // 
            // btnKembali
            // 
            this.btnKembali.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKembali.Enabled = false;
            this.btnKembali.Location = new System.Drawing.Point(352, 314);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 20;
            this.btnKembali.Text = "&Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // UpdateCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.txtCari);
            this.Controls.Add(this.cmbTriger);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.updateGrup);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.viewcustomer);
            this.Controls.Add(this.label1);
            this.Name = "UpdateCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpdateCustomer";
            this.Load += new System.EventHandler(this.UpdateCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viewcustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mscustomerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakuraDataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakuraDataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sakuraDataDataSetBindingSource)).EndInit();
            this.updateGrup.ResumeLayout(false);
            this.updateGrup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView viewcustomer;
        private System.Windows.Forms.BindingSource sakuraDataDataSetBindingSource;
        private SakuraDataDataSet sakuraDataDataSet;
        private SakuraDataDataSet1 sakuraDataDataSet1;
        private System.Windows.Forms.BindingSource mscustomerBindingSource;
        private SakuraDataDataSet1TableAdapters.mscustomerTableAdapter mscustomerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namacustomerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totaltransaksiDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox updateGrup;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.TextBox txtnama_customer;
        private System.Windows.Forms.Label infonama_customer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label txtid_customer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label txttotal_transaksi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTriger;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.Button btnKembali;
    }
}