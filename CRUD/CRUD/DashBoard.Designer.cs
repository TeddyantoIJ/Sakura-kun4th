namespace CRUD
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnKonfirmasiBarang = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.barangmasuk = new CRUD.barangmasuk();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 247);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(278, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnKonfirmasiBarang
            // 
            this.btnKonfirmasiBarang.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnKonfirmasiBarang.Location = new System.Drawing.Point(19, 3);
            this.btnKonfirmasiBarang.Name = "btnKonfirmasiBarang";
            this.btnKonfirmasiBarang.Size = new System.Drawing.Size(213, 23);
            this.btnKonfirmasiBarang.TabIndex = 1;
            this.btnKonfirmasiBarang.Text = "Konfirmasi barang masuk";
            this.btnKonfirmasiBarang.UseVisualStyleBackColor = true;
            this.btnKonfirmasiBarang.Click += new System.EventHandler(this.btnKonfirmasiBarang_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnKonfirmasiBarang);
            this.panel1.Location = new System.Drawing.Point(-17, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(237, 31);
            this.panel1.TabIndex = 2;
            // 
            // barangmasuk
            // 
            this.barangmasuk.BackColor = System.Drawing.Color.White;
            this.barangmasuk.Location = new System.Drawing.Point(-162, 123);
            this.barangmasuk.Name = "barangmasuk";
            this.barangmasuk.Size = new System.Drawing.Size(1362, 528);
            this.barangmasuk.TabIndex = 3;
            this.barangmasuk.Visible = false;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.barangmasuk);
            this.MaximumSize = new System.Drawing.Size(1203, 651);
            this.MinimumSize = new System.Drawing.Size(1203, 651);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(1203, 651);
            this.VisibleChanged += new System.EventHandler(this.DashBoard_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnKonfirmasiBarang;
        private System.Windows.Forms.Panel panel1;
        private barangmasuk barangmasuk;
    }
}
