namespace CRUD
{
    partial class UpdateAlatElektronik
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgAlatElektronik = new System.Windows.Forms.DataGridView();
            this.idalatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namaalatDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idjenisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msalatelektronikBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataAlatElektronik = new CRUD.DataAlatElektronik();
            this.msalatelektronikTableAdapter = new CRUD.DataAlatElektronikTableAdapters.msalatelektronikTableAdapter();
            this.cmbPencarian = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSegarkan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.btnPerbarui = new System.Windows.Forms.Button();
            this.gbUpdate = new System.Windows.Forms.GroupBox();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBaru = new System.Windows.Forms.Button();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.txtJenis = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKembali = new System.Windows.Forms.Button();
            this.txtPencarian = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlatElektronik)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msalatelektronikBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlatElektronik)).BeginInit();
            this.gbUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(439, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Alat ELektronik";
            // 
            // dgAlatElektronik
            // 
            this.dgAlatElektronik.AutoGenerateColumns = false;
            this.dgAlatElektronik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlatElektronik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idalatDataGridViewTextBoxColumn,
            this.namaalatDataGridViewTextBoxColumn,
            this.idjenisDataGridViewTextBoxColumn});
            this.dgAlatElektronik.DataSource = this.msalatelektronikBindingSource;
            this.dgAlatElektronik.Location = new System.Drawing.Point(24, 56);
            this.dgAlatElektronik.Name = "dgAlatElektronik";
            this.dgAlatElektronik.Size = new System.Drawing.Size(542, 224);
            this.dgAlatElektronik.TabIndex = 1;
            this.dgAlatElektronik.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlatElektronik_CellEnter);
            // 
            // idalatDataGridViewTextBoxColumn
            // 
            this.idalatDataGridViewTextBoxColumn.DataPropertyName = "id_alat";
            this.idalatDataGridViewTextBoxColumn.HeaderText = "ID Alat";
            this.idalatDataGridViewTextBoxColumn.Name = "idalatDataGridViewTextBoxColumn";
            // 
            // namaalatDataGridViewTextBoxColumn
            // 
            this.namaalatDataGridViewTextBoxColumn.DataPropertyName = "nama_alat";
            this.namaalatDataGridViewTextBoxColumn.HeaderText = "Nama Alat Elektronik";
            this.namaalatDataGridViewTextBoxColumn.Name = "namaalatDataGridViewTextBoxColumn";
            this.namaalatDataGridViewTextBoxColumn.Width = 200;
            // 
            // idjenisDataGridViewTextBoxColumn
            // 
            this.idjenisDataGridViewTextBoxColumn.DataPropertyName = "id_jenis";
            this.idjenisDataGridViewTextBoxColumn.HeaderText = "Nama Jenis Elektronik";
            this.idjenisDataGridViewTextBoxColumn.Name = "idjenisDataGridViewTextBoxColumn";
            this.idjenisDataGridViewTextBoxColumn.Width = 200;
            // 
            // msalatelektronikBindingSource
            // 
            this.msalatelektronikBindingSource.DataMember = "msalatelektronik";
            this.msalatelektronikBindingSource.DataSource = this.dataAlatElektronik;
            // 
            // dataAlatElektronik
            // 
            this.dataAlatElektronik.DataSetName = "DataAlatElektronik";
            this.dataAlatElektronik.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // msalatelektronikTableAdapter
            // 
            this.msalatelektronikTableAdapter.ClearBeforeFill = true;
            // 
            // cmbPencarian
            // 
            this.cmbPencarian.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPencarian.FormattingEnabled = true;
            this.cmbPencarian.Items.AddRange(new object[] {
            "ID Alat",
            "Nama Alat Elektronik",
            "Nama Jenis Elektronik"});
            this.cmbPencarian.Location = new System.Drawing.Point(26, 307);
            this.cmbPencarian.Name = "cmbPencarian";
            this.cmbPencarian.Size = new System.Drawing.Size(150, 23);
            this.cmbPencarian.TabIndex = 9;
            this.cmbPencarian.TextChanged += new System.EventHandler(this.cmbPencarian_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Pencarian";
            // 
            // btnSegarkan
            // 
            this.btnSegarkan.Location = new System.Drawing.Point(572, 122);
            this.btnSegarkan.Name = "btnSegarkan";
            this.btnSegarkan.Size = new System.Drawing.Size(75, 23);
            this.btnSegarkan.TabIndex = 13;
            this.btnSegarkan.Text = "Segarkan";
            this.btnSegarkan.UseVisualStyleBackColor = true;
            this.btnSegarkan.Click += new System.EventHandler(this.btnSegarkan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(572, 89);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(75, 23);
            this.btnBatal.TabIndex = 12;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // btnPerbarui
            // 
            this.btnPerbarui.Location = new System.Drawing.Point(572, 56);
            this.btnPerbarui.Name = "btnPerbarui";
            this.btnPerbarui.Size = new System.Drawing.Size(75, 23);
            this.btnPerbarui.TabIndex = 11;
            this.btnPerbarui.Text = "Perbarui";
            this.btnPerbarui.UseVisualStyleBackColor = true;
            this.btnPerbarui.Click += new System.EventHandler(this.btnPerbarui_Click);
            // 
            // gbUpdate
            // 
            this.gbUpdate.Controls.Add(this.btnSimpan);
            this.gbUpdate.Controls.Add(this.btnBaru);
            this.gbUpdate.Controls.Add(this.txtNama);
            this.gbUpdate.Controls.Add(this.lblId);
            this.gbUpdate.Controls.Add(this.txtJenis);
            this.gbUpdate.Controls.Add(this.label7);
            this.gbUpdate.Controls.Add(this.label2);
            this.gbUpdate.Controls.Add(this.label8);
            this.gbUpdate.Controls.Add(this.label3);
            this.gbUpdate.Controls.Add(this.label6);
            this.gbUpdate.Controls.Add(this.label5);
            this.gbUpdate.Location = new System.Drawing.Point(653, 56);
            this.gbUpdate.Name = "gbUpdate";
            this.gbUpdate.Size = new System.Drawing.Size(387, 150);
            this.gbUpdate.TabIndex = 14;
            this.gbUpdate.TabStop = false;
            this.gbUpdate.Text = "Perbarui";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(290, 24);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(75, 23);
            this.btnSimpan.TabIndex = 15;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBaru
            // 
            this.btnBaru.Location = new System.Drawing.Point(291, 110);
            this.btnBaru.Name = "btnBaru";
            this.btnBaru.Size = new System.Drawing.Size(75, 27);
            this.btnBaru.TabIndex = 21;
            this.btnBaru.Text = "Baru";
            this.btnBaru.UseVisualStyleBackColor = true;
            this.btnBaru.Click += new System.EventHandler(this.btnBaru_Click);
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
            // txtJenis
            // 
            this.txtJenis.Location = new System.Drawing.Point(191, 81);
            this.txtJenis.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtJenis.Name = "txtJenis";
            this.txtJenis.Size = new System.Drawing.Size(174, 23);
            this.txtJenis.TabIndex = 20;
            this.txtJenis.TextChanged += new System.EventHandler(this.txtJenis_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 15);
            this.label7.TabIndex = 14;
            this.label7.Text = "Jenis Alat Elektronik";
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
            this.label8.Size = new System.Drawing.Size(42, 15);
            this.label8.TabIndex = 12;
            this.label8.Text = "ID Alat";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(10, 15);
            this.label6.TabIndex = 17;
            this.label6.Text = ":";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Alat Elektronik";
            // 
            // btnKembali
            // 
            this.btnKembali.Location = new System.Drawing.Point(24, 342);
            this.btnKembali.Name = "btnKembali";
            this.btnKembali.Size = new System.Drawing.Size(75, 23);
            this.btnKembali.TabIndex = 15;
            this.btnKembali.Text = "Kembali";
            this.btnKembali.UseVisualStyleBackColor = true;
            this.btnKembali.Click += new System.EventHandler(this.btnKembali_Click);
            // 
            // txtPencarian
            // 
            this.txtPencarian.Location = new System.Drawing.Point(182, 307);
            this.txtPencarian.Name = "txtPencarian";
            this.txtPencarian.Size = new System.Drawing.Size(145, 23);
            this.txtPencarian.TabIndex = 10;
            this.txtPencarian.TextChanged += new System.EventHandler(this.txtPencarian_TextChanged);
            // 
            // UpdateAlatElektronik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 377);
            this.Controls.Add(this.txtPencarian);
            this.Controls.Add(this.btnKembali);
            this.Controls.Add(this.gbUpdate);
            this.Controls.Add(this.btnSegarkan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.btnPerbarui);
            this.Controls.Add(this.cmbPencarian);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgAlatElektronik);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "UpdateAlatElektronik";
            this.Text = "Update Alat Elektronik";
            this.Load += new System.EventHandler(this.UpdateAlatElektronik_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgAlatElektronik)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msalatelektronikBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataAlatElektronik)).EndInit();
            this.gbUpdate.ResumeLayout(false);
            this.gbUpdate.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgAlatElektronik;
        private DataAlatElektronik dataAlatElektronik;
        private System.Windows.Forms.BindingSource msalatelektronikBindingSource;
        private DataAlatElektronikTableAdapters.msalatelektronikTableAdapter msalatelektronikTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idalatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namaalatDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idjenisDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox cmbPencarian;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSegarkan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Button btnPerbarui;
        private System.Windows.Forms.GroupBox gbUpdate;
        private System.Windows.Forms.Button btnBaru;
        private System.Windows.Forms.TextBox txtJenis;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnKembali;
        private System.Windows.Forms.TextBox txtPencarian;
    }
}