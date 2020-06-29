namespace CRUD
{
    partial class UCTransaksi
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
            this.btnTrans1 = new System.Windows.Forms.Button();
            this.btnTrans2 = new System.Windows.Forms.Button();
            this.btnTrans3 = new System.Windows.Forms.Button();
            this.btnTrans4 = new System.Windows.Forms.Button();
            this.ucTrans1 = new CRUD.beliKomponen();
            this.ucTrans2 = new CRUD.ReparasiAlatElektronik();
            this.ucTrans3 = new CRUD.RestockAlatKerja();
            this.ucTrans4 = new CRUD.restockKomponen();
            this.SuspendLayout();
            // 
            // btnTrans1
            // 
            this.btnTrans1.BackColor = System.Drawing.Color.Gray;
            this.btnTrans1.Location = new System.Drawing.Point(157, 11);
            this.btnTrans1.Name = "btnTrans1";
            this.btnTrans1.Size = new System.Drawing.Size(293, 23);
            this.btnTrans1.TabIndex = 4;
            this.btnTrans1.Text = "Beli Komponen";
            this.btnTrans1.UseVisualStyleBackColor = false;
            this.btnTrans1.Click += new System.EventHandler(this.btnTrans1_Click);
            // 
            // btnTrans2
            // 
            this.btnTrans2.Location = new System.Drawing.Point(456, 11);
            this.btnTrans2.Name = "btnTrans2";
            this.btnTrans2.Size = new System.Drawing.Size(293, 23);
            this.btnTrans2.TabIndex = 5;
            this.btnTrans2.Text = "Reparasi Alat";
            this.btnTrans2.UseVisualStyleBackColor = true;
            this.btnTrans2.Click += new System.EventHandler(this.btnTrans2_Click);
            // 
            // btnTrans3
            // 
            this.btnTrans3.Location = new System.Drawing.Point(755, 11);
            this.btnTrans3.Name = "btnTrans3";
            this.btnTrans3.Size = new System.Drawing.Size(293, 23);
            this.btnTrans3.TabIndex = 6;
            this.btnTrans3.Text = "Beli Alat";
            this.btnTrans3.UseVisualStyleBackColor = true;
            this.btnTrans3.Click += new System.EventHandler(this.btnTrans3_Click);
            // 
            // btnTrans4
            // 
            this.btnTrans4.Location = new System.Drawing.Point(1054, 11);
            this.btnTrans4.Name = "btnTrans4";
            this.btnTrans4.Size = new System.Drawing.Size(293, 23);
            this.btnTrans4.TabIndex = 7;
            this.btnTrans4.Text = "Pemasokkan";
            this.btnTrans4.UseVisualStyleBackColor = true;
            this.btnTrans4.Click += new System.EventHandler(this.btnTrans4_Click);
            // 
            // ucTrans1
            // 
            this.ucTrans1.BackColor = System.Drawing.Color.White;
            this.ucTrans1.Location = new System.Drawing.Point(-2, 38);
            this.ucTrans1.Name = "ucTrans1";
            this.ucTrans1.Size = new System.Drawing.Size(1362, 528);
            this.ucTrans1.TabIndex = 11;
            // 
            // ucTrans2
            // 
            this.ucTrans2.BackColor = System.Drawing.Color.White;
            this.ucTrans2.Location = new System.Drawing.Point(-2, 38);
            this.ucTrans2.Name = "ucTrans2";
            this.ucTrans2.Size = new System.Drawing.Size(1188, 455);
            this.ucTrans2.TabIndex = 9;
            this.ucTrans2.Visible = false;
            // 
            // ucTrans3
            // 
            this.ucTrans3.BackColor = System.Drawing.Color.White;
            this.ucTrans3.Location = new System.Drawing.Point(-2, 38);
            this.ucTrans3.Name = "ucTrans3";
            this.ucTrans3.Size = new System.Drawing.Size(1362, 528);
            this.ucTrans3.TabIndex = 8;
            this.ucTrans3.Visible = false;
            // 
            // ucTrans4
            // 
            this.ucTrans4.BackColor = System.Drawing.Color.White;
            this.ucTrans4.Location = new System.Drawing.Point(-2, 40);
            this.ucTrans4.Name = "ucTrans4";
            this.ucTrans4.Size = new System.Drawing.Size(1362, 528);
            this.ucTrans4.TabIndex = 12;
            // 
            // UCTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.ucTrans4);
            this.Controls.Add(this.btnTrans4);
            this.Controls.Add(this.btnTrans3);
            this.Controls.Add(this.btnTrans2);
            this.Controls.Add(this.btnTrans1);
            this.Controls.Add(this.ucTrans2);
            this.Controls.Add(this.ucTrans3);
            this.Controls.Add(this.ucTrans1);
            this.Name = "UCTransaksi";
            this.Size = new System.Drawing.Size(1358, 564);
            this.Load += new System.EventHandler(this.UCTransaksi_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnTrans1;
        private System.Windows.Forms.Button btnTrans2;
        private System.Windows.Forms.Button btnTrans3;
        private System.Windows.Forms.Button btnTrans4;
        private RestockAlatKerja ucTrans3;
        private ReparasiAlatElektronik ucTrans2;
        private beliKomponen ucTrans1;
        private restockKomponen ucTrans4;
    }
}
