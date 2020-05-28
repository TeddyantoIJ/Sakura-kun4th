namespace CRUD
{
    partial class KomponenSupplier
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtid_komponen = new System.Windows.Forms.Label();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.txtid_supplier = new System.Windows.Forms.Label();
            this.txtnama_supplier = new System.Windows.Forms.TextBox();
            this.btnBaruSupplier = new System.Windows.Forms.Button();
            this.infonama_supplier = new System.Windows.Forms.Label();
            this.txtnama_komponen = new System.Windows.Forms.TextBox();
            this.btnBaruKomponen = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.infonamakomponen = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.info_harga = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tambah Komponen Supplier";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama Komponen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "Nama Supplier";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "Harga";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(124, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(122, 166);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 17);
            this.label6.TabIndex = 1;
            this.label6.Text = ":";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(122, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 1;
            this.label7.Text = ":";
            // 
            // txtid_komponen
            // 
            this.txtid_komponen.AutoSize = true;
            this.txtid_komponen.Location = new System.Drawing.Point(145, 119);
            this.txtid_komponen.Name = "txtid_komponen";
            this.txtid_komponen.Size = new System.Drawing.Size(0, 17);
            this.txtid_komponen.TabIndex = 1;
            this.txtid_komponen.TextChanged += new System.EventHandler(this.txtid_komponen_TextChanged);
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(182, 234);
            this.txtharga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(188, 25);
            this.txtharga.TabIndex = 3;
            this.txtharga.TextChanged += new System.EventHandler(this.txtharga_TextChanged);
            this.txtharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtharga_KeyPress);
            this.txtharga.Leave += new System.EventHandler(this.txtharga_Leave);
            // 
            // txtid_supplier
            // 
            this.txtid_supplier.AutoSize = true;
            this.txtid_supplier.Location = new System.Drawing.Point(145, 201);
            this.txtid_supplier.Name = "txtid_supplier";
            this.txtid_supplier.Size = new System.Drawing.Size(0, 17);
            this.txtid_supplier.TabIndex = 1;
            this.txtid_supplier.TextChanged += new System.EventHandler(this.txtid_supplier_TextChanged);
            // 
            // txtnama_supplier
            // 
            this.txtnama_supplier.Location = new System.Drawing.Point(145, 161);
            this.txtnama_supplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_supplier.Name = "txtnama_supplier";
            this.txtnama_supplier.Size = new System.Drawing.Size(226, 25);
            this.txtnama_supplier.TabIndex = 1;
            this.txtnama_supplier.TextChanged += new System.EventHandler(this.txtnama_supplier_TextChanged);
            this.txtnama_supplier.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnama_supplier_KeyPress);
            this.txtnama_supplier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnama_supplier_KeyUp);
            this.txtnama_supplier.Leave += new System.EventHandler(this.txtnama_supplier_Leave);
            // 
            // btnBaruSupplier
            // 
            this.btnBaruSupplier.Enabled = false;
            this.btnBaruSupplier.Location = new System.Drawing.Point(283, 195);
            this.btnBaruSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaruSupplier.Name = "btnBaruSupplier";
            this.btnBaruSupplier.Size = new System.Drawing.Size(87, 30);
            this.btnBaruSupplier.TabIndex = 2;
            this.btnBaruSupplier.Text = "&Baru";
            this.btnBaruSupplier.UseVisualStyleBackColor = true;
            this.btnBaruSupplier.Click += new System.EventHandler(this.btnBaruSupplier_Click);
            // 
            // infonama_supplier
            // 
            this.infonama_supplier.AutoSize = true;
            this.infonama_supplier.Location = new System.Drawing.Point(384, 166);
            this.infonama_supplier.Name = "infonama_supplier";
            this.infonama_supplier.Size = new System.Drawing.Size(0, 17);
            this.infonama_supplier.TabIndex = 1;
            // 
            // txtnama_komponen
            // 
            this.txtnama_komponen.Location = new System.Drawing.Point(145, 76);
            this.txtnama_komponen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_komponen.Name = "txtnama_komponen";
            this.txtnama_komponen.Size = new System.Drawing.Size(226, 25);
            this.txtnama_komponen.TabIndex = 0;
            this.txtnama_komponen.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtnama_komponen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnama_komponen_KeyPress);
            this.txtnama_komponen.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnama_komponen_KeyUp);
            this.txtnama_komponen.Leave += new System.EventHandler(this.txtnama_komponen_Leave);
            // 
            // btnBaruKomponen
            // 
            this.btnBaruKomponen.Enabled = false;
            this.btnBaruKomponen.Location = new System.Drawing.Point(283, 112);
            this.btnBaruKomponen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaruKomponen.Name = "btnBaruKomponen";
            this.btnBaruKomponen.Size = new System.Drawing.Size(87, 30);
            this.btnBaruKomponen.TabIndex = 4;
            this.btnBaruKomponen.Text = "&Baru";
            this.btnBaruKomponen.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(145, 238);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 1;
            this.label8.Text = "Rp.";
            // 
            // infonamakomponen
            // 
            this.infonamakomponen.AutoSize = true;
            this.infonamakomponen.Location = new System.Drawing.Point(384, 80);
            this.infonamakomponen.Name = "infonamakomponen";
            this.infonamakomponen.Size = new System.Drawing.Size(0, 17);
            this.infonamakomponen.TabIndex = 1;
            // 
            // btnSimpan
            // 
            this.btnSimpan.Enabled = false;
            this.btnSimpan.Location = new System.Drawing.Point(122, 307);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(87, 30);
            this.btnSimpan.TabIndex = 5;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(283, 307);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 5;
            this.button2.Text = "&Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // info_harga
            // 
            this.info_harga.AutoSize = true;
            this.info_harga.Location = new System.Drawing.Point(384, 243);
            this.info_harga.Name = "info_harga";
            this.info_harga.Size = new System.Drawing.Size(0, 17);
            this.info_harga.TabIndex = 1;
            // 
            // KomponenSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 391);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBaruKomponen);
            this.Controls.Add(this.txtnama_komponen);
            this.Controls.Add(this.btnBaruSupplier);
            this.Controls.Add(this.txtnama_supplier);
            this.Controls.Add(this.txtharga);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.info_harga);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.infonama_supplier);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid_supplier);
            this.Controls.Add(this.txtid_komponen);
            this.Controls.Add(this.infonamakomponen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "KomponenSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KomponenSupplier";
            this.Activated += new System.EventHandler(this.KomponenSupplier_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label txtid_komponen;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Label txtid_supplier;
        private System.Windows.Forms.TextBox txtnama_supplier;
        private System.Windows.Forms.Button btnBaruSupplier;
        private System.Windows.Forms.Label infonama_supplier;
        private System.Windows.Forms.TextBox txtnama_komponen;
        private System.Windows.Forms.Button btnBaruKomponen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label infonamakomponen;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label info_harga;
    }
}