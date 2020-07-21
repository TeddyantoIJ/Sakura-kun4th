namespace CRUD
{
    partial class AlatSupplier
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
            this.button2 = new System.Windows.Forms.Button();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBaruAlat = new System.Windows.Forms.Button();
            this.txtnama_alat = new System.Windows.Forms.TextBox();
            this.btnBaruSupplier = new System.Windows.Forms.Button();
            this.txtnama_supplier = new System.Windows.Forms.TextBox();
            this.txtharga = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.info_harga = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.infonama_supplier = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid_supplier = new System.Windows.Forms.Label();
            this.txtid_alat = new System.Windows.Forms.Label();
            this.infonamakomponen = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 328);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(87, 30);
            this.button2.TabIndex = 25;
            this.button2.Text = "&Batal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSimpan
            // 
            this.btnSimpan.Enabled = false;
            this.btnSimpan.Location = new System.Drawing.Point(120, 328);
            this.btnSimpan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(87, 30);
            this.btnSimpan.TabIndex = 24;
            this.btnSimpan.Text = "&Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBaruAlat
            // 
            this.btnBaruAlat.Enabled = false;
            this.btnBaruAlat.Location = new System.Drawing.Point(281, 133);
            this.btnBaruAlat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaruAlat.Name = "btnBaruAlat";
            this.btnBaruAlat.Size = new System.Drawing.Size(87, 30);
            this.btnBaruAlat.TabIndex = 23;
            this.btnBaruAlat.Text = "&Baru";
            this.btnBaruAlat.UseVisualStyleBackColor = true;
            this.btnBaruAlat.Click += new System.EventHandler(this.btnBaruKomponen_Click);
            // 
            // txtnama_alat
            // 
            this.txtnama_alat.Location = new System.Drawing.Point(142, 97);
            this.txtnama_alat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_alat.Name = "txtnama_alat";
            this.txtnama_alat.Size = new System.Drawing.Size(226, 25);
            this.txtnama_alat.TabIndex = 7;
            this.txtnama_alat.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnama_alat_KeyUp);
            // 
            // btnBaruSupplier
            // 
            this.btnBaruSupplier.Enabled = false;
            this.btnBaruSupplier.Location = new System.Drawing.Point(281, 216);
            this.btnBaruSupplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBaruSupplier.Name = "btnBaruSupplier";
            this.btnBaruSupplier.Size = new System.Drawing.Size(87, 30);
            this.btnBaruSupplier.TabIndex = 21;
            this.btnBaruSupplier.Text = "&Baru";
            this.btnBaruSupplier.UseVisualStyleBackColor = true;
            this.btnBaruSupplier.Click += new System.EventHandler(this.btnBaruSupplier_Click);
            // 
            // txtnama_supplier
            // 
            this.txtnama_supplier.Location = new System.Drawing.Point(142, 182);
            this.txtnama_supplier.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnama_supplier.Name = "txtnama_supplier";
            this.txtnama_supplier.Size = new System.Drawing.Size(226, 25);
            this.txtnama_supplier.TabIndex = 19;
            this.txtnama_supplier.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtnama_supplier_KeyUp);
            // 
            // txtharga
            // 
            this.txtharga.Location = new System.Drawing.Point(180, 255);
            this.txtharga.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtharga.Name = "txtharga";
            this.txtharga.Size = new System.Drawing.Size(188, 25);
            this.txtharga.TabIndex = 22;
            this.txtharga.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtharga.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtharga_KeyPress);
            this.txtharga.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtharga_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(120, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(11, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(120, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(11, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = ":";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(142, 259);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 17);
            this.label8.TabIndex = 16;
            this.label8.Text = "Rp.";
            // 
            // info_harga
            // 
            this.info_harga.AutoSize = true;
            this.info_harga.Location = new System.Drawing.Point(381, 264);
            this.info_harga.Name = "info_harga";
            this.info_harga.Size = new System.Drawing.Size(0, 17);
            this.info_harga.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Harga";
            // 
            // infonama_supplier
            // 
            this.infonama_supplier.AutoSize = true;
            this.infonama_supplier.Location = new System.Drawing.Point(381, 187);
            this.infonama_supplier.Name = "infonama_supplier";
            this.infonama_supplier.Size = new System.Drawing.Size(0, 17);
            this.infonama_supplier.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(121, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(11, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = ":";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Nama Supplier";
            // 
            // txtid_supplier
            // 
            this.txtid_supplier.AutoSize = true;
            this.txtid_supplier.Location = new System.Drawing.Point(142, 222);
            this.txtid_supplier.Name = "txtid_supplier";
            this.txtid_supplier.Size = new System.Drawing.Size(0, 17);
            this.txtid_supplier.TabIndex = 10;
            // 
            // txtid_alat
            // 
            this.txtid_alat.AutoSize = true;
            this.txtid_alat.Location = new System.Drawing.Point(142, 140);
            this.txtid_alat.Name = "txtid_alat";
            this.txtid_alat.Size = new System.Drawing.Size(0, 17);
            this.txtid_alat.TabIndex = 9;
            // 
            // infonamakomponen
            // 
            this.infonamakomponen.AutoSize = true;
            this.infonamakomponen.Location = new System.Drawing.Point(381, 101);
            this.infonamakomponen.Name = "infonamakomponen";
            this.infonamakomponen.Size = new System.Drawing.Size(0, 17);
            this.infonamakomponen.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nama Alat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Tambah Alat Supplier";
            // 
            // AlatSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 411);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBaruAlat);
            this.Controls.Add(this.txtnama_alat);
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
            this.Controls.Add(this.txtid_alat);
            this.Controls.Add(this.infonamakomponen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AlatSupplier";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AlatSupplier";
            this.Activated += new System.EventHandler(this.AlatSupplier_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBaruAlat;
        private System.Windows.Forms.TextBox txtnama_alat;
        private System.Windows.Forms.Button btnBaruSupplier;
        private System.Windows.Forms.TextBox txtnama_supplier;
        private System.Windows.Forms.TextBox txtharga;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label info_harga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label infonama_supplier;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtid_supplier;
        private System.Windows.Forms.Label txtid_alat;
        private System.Windows.Forms.Label infonamakomponen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}