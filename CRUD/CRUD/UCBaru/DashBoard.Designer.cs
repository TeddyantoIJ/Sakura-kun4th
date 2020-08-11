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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.rb3 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.txtInfo = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.bunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPenjualanKomponen = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnTransaksiPerbaikan = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPemasokkanAlat = new Bunifu.Framework.UI.BunifuTileButton();
            this.btnPemasokkanKomponen = new Bunifu.Framework.UI.BunifuTileButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLihat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.dateSampai = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateSejak = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox3 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.bunifuMaterialTextbox4 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtmutiara = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.rb3);
            this.panel1.Controls.Add(this.rb2);
            this.panel1.Controls.Add(this.rb1);
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox4);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1197, 553);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1055, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 17);
            this.label3.TabIndex = 51;
            this.label3.Text = "Bentuk chart :";
            // 
            // rb3
            // 
            this.rb3.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.rb3, BunifuAnimatorNS.DecorationType.None);
            this.rb3.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb3.Location = new System.Drawing.Point(1055, 308);
            this.rb3.Name = "rb3";
            this.rb3.Size = new System.Drawing.Size(47, 23);
            this.rb3.TabIndex = 50;
            this.rb3.Text = "Pie";
            this.rb3.UseVisualStyleBackColor = true;
            this.rb3.CheckedChanged += new System.EventHandler(this.rb3_CheckedChanged);
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.rb2, BunifuAnimatorNS.DecorationType.None);
            this.rb2.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb2.Location = new System.Drawing.Point(1055, 279);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(61, 23);
            this.rb2.TabIndex = 49;
            this.rb2.Text = "Garis";
            this.rb2.UseVisualStyleBackColor = true;
            this.rb2.CheckedChanged += new System.EventHandler(this.rb2_CheckedChanged);
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.bunifuTransition1.SetDecoration(this.rb1, BunifuAnimatorNS.DecorationType.None);
            this.rb1.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb1.Location = new System.Drawing.Point(1055, 250);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(137, 23);
            this.rb1.TabIndex = 48;
            this.rb1.TabStop = true;
            this.rb1.Text = "Kolom dan garis";
            this.rb1.UseVisualStyleBackColor = true;
            this.rb1.CheckedChanged += new System.EventHandler(this.rb1_CheckedChanged);
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bunifuGradientPanel1.Controls.Add(this.txtInfo);
            this.bunifuGradientPanel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.bunifuGradientPanel1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(4, 216);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(291, 86);
            this.bunifuGradientPanel1.TabIndex = 1;
            this.bunifuGradientPanel1.Click += new System.EventHandler(this.txtInfo_Click);
            // 
            // txtInfo
            // 
            this.bunifuTransition1.SetDecoration(this.txtInfo, BunifuAnimatorNS.DecorationType.None);
            this.txtInfo.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInfo.Location = new System.Drawing.Point(1, 29);
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(288, 24);
            this.txtInfo.TabIndex = 42;
            this.txtInfo.Text = "Bulan ini";
            this.txtInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txtInfo.Click += new System.EventHandler(this.txtInfo_Click);
            // 
            // pictureBox1
            // 
            this.bunifuTransition1.SetDecoration(this.pictureBox1, BunifuAnimatorNS.DecorationType.None);
            this.pictureBox1.Image = global::CRUD.Properties.Resources.Teddy_01;
            this.pictureBox1.Location = new System.Drawing.Point(4, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.bunifuMaterialTextbox2);
            this.panel3.Controls.Add(this.bunifuMaterialTextbox1);
            this.panel3.Controls.Add(this.btnPenjualanKomponen);
            this.panel3.Controls.Add(this.btnTransaksiPerbaikan);
            this.panel3.Controls.Add(this.btnPemasokkanAlat);
            this.panel3.Controls.Add(this.btnPemasokkanKomponen);
            this.bunifuTransition1.SetDecoration(this.panel3, BunifuAnimatorNS.DecorationType.None);
            this.panel3.Location = new System.Drawing.Point(304, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(883, 168);
            this.panel3.TabIndex = 1;
            // 
            // bunifuMaterialTextbox2
            // 
            this.bunifuMaterialTextbox2.BackColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox2, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuMaterialTextbox2.Location = new System.Drawing.Point(438, 3);
            this.bunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox2.Name = "bunifuMaterialTextbox2";
            this.bunifuMaterialTextbox2.Size = new System.Drawing.Size(439, 39);
            this.bunifuMaterialTextbox2.TabIndex = 53;
            this.bunifuMaterialTextbox2.Text = "Transaksi Pemasok";
            this.bunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.BackColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(5, 4);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(425, 39);
            this.bunifuMaterialTextbox1.TabIndex = 52;
            this.bunifuMaterialTextbox1.Text = "Transaksi Pelanggan";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnPenjualanKomponen
            // 
            this.btnPenjualanKomponen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.btnPenjualanKomponen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnPenjualanKomponen.color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.btnPenjualanKomponen.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(110)))));
            this.btnPenjualanKomponen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnPenjualanKomponen, BunifuAnimatorNS.DecorationType.None);
            this.btnPenjualanKomponen.Enabled = false;
            this.btnPenjualanKomponen.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnPenjualanKomponen.ForeColor = System.Drawing.Color.White;
            this.btnPenjualanKomponen.Image = global::CRUD.Properties.Resources.Income;
            this.btnPenjualanKomponen.ImagePosition = 14;
            this.btnPenjualanKomponen.ImageZoom = 50;
            this.btnPenjualanKomponen.LabelPosition = 27;
            this.btnPenjualanKomponen.LabelText = "Penjualan";
            this.btnPenjualanKomponen.Location = new System.Drawing.Point(5, 47);
            this.btnPenjualanKomponen.Margin = new System.Windows.Forms.Padding(5);
            this.btnPenjualanKomponen.Name = "btnPenjualanKomponen";
            this.btnPenjualanKomponen.Size = new System.Drawing.Size(107, 113);
            this.btnPenjualanKomponen.TabIndex = 48;
            this.btnPenjualanKomponen.Click += new System.EventHandler(this.btnPenjualanKomponen_Click);
            // 
            // btnTransaksiPerbaikan
            // 
            this.btnTransaksiPerbaikan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.btnTransaksiPerbaikan.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnTransaksiPerbaikan.color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.btnTransaksiPerbaikan.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(110)))));
            this.btnTransaksiPerbaikan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnTransaksiPerbaikan, BunifuAnimatorNS.DecorationType.None);
            this.btnTransaksiPerbaikan.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnTransaksiPerbaikan.ForeColor = System.Drawing.Color.White;
            this.btnTransaksiPerbaikan.Image = global::CRUD.Properties.Resources.Work;
            this.btnTransaksiPerbaikan.ImagePosition = 14;
            this.btnTransaksiPerbaikan.ImageZoom = 50;
            this.btnTransaksiPerbaikan.LabelPosition = 27;
            this.btnTransaksiPerbaikan.LabelText = "Perbaikan";
            this.btnTransaksiPerbaikan.Location = new System.Drawing.Point(323, 47);
            this.btnTransaksiPerbaikan.Margin = new System.Windows.Forms.Padding(5);
            this.btnTransaksiPerbaikan.Name = "btnTransaksiPerbaikan";
            this.btnTransaksiPerbaikan.Size = new System.Drawing.Size(107, 113);
            this.btnTransaksiPerbaikan.TabIndex = 49;
            this.btnTransaksiPerbaikan.Click += new System.EventHandler(this.btnTransaksiPerbaikan_Click);
            // 
            // btnPemasokkanAlat
            // 
            this.btnPemasokkanAlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.btnPemasokkanAlat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnPemasokkanAlat.color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.btnPemasokkanAlat.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(110)))));
            this.btnPemasokkanAlat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnPemasokkanAlat, BunifuAnimatorNS.DecorationType.None);
            this.btnPemasokkanAlat.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnPemasokkanAlat.ForeColor = System.Drawing.Color.White;
            this.btnPemasokkanAlat.Image = global::CRUD.Properties.Resources.AlatKerja;
            this.btnPemasokkanAlat.ImagePosition = 14;
            this.btnPemasokkanAlat.ImageZoom = 50;
            this.btnPemasokkanAlat.LabelPosition = 27;
            this.btnPemasokkanAlat.LabelText = "Alat";
            this.btnPemasokkanAlat.Location = new System.Drawing.Point(770, 46);
            this.btnPemasokkanAlat.Margin = new System.Windows.Forms.Padding(5);
            this.btnPemasokkanAlat.Name = "btnPemasokkanAlat";
            this.btnPemasokkanAlat.Size = new System.Drawing.Size(107, 113);
            this.btnPemasokkanAlat.TabIndex = 51;
            this.btnPemasokkanAlat.Click += new System.EventHandler(this.btnPemasokkanAlat_Click);
            // 
            // btnPemasokkanKomponen
            // 
            this.btnPemasokkanKomponen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.btnPemasokkanKomponen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnPemasokkanKomponen.color = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.btnPemasokkanKomponen.colorActive = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(110)))));
            this.btnPemasokkanKomponen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnPemasokkanKomponen, BunifuAnimatorNS.DecorationType.None);
            this.btnPemasokkanKomponen.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold);
            this.btnPemasokkanKomponen.ForeColor = System.Drawing.Color.White;
            this.btnPemasokkanKomponen.Image = global::CRUD.Properties.Resources.Komponen__2_;
            this.btnPemasokkanKomponen.ImagePosition = 14;
            this.btnPemasokkanKomponen.ImageZoom = 50;
            this.btnPemasokkanKomponen.LabelPosition = 27;
            this.btnPemasokkanKomponen.LabelText = "Komponen";
            this.btnPemasokkanKomponen.Location = new System.Drawing.Point(440, 46);
            this.btnPemasokkanKomponen.Margin = new System.Windows.Forms.Padding(5);
            this.btnPemasokkanKomponen.Name = "btnPemasokkanKomponen";
            this.btnPemasokkanKomponen.Size = new System.Drawing.Size(107, 113);
            this.btnPemasokkanKomponen.TabIndex = 50;
            this.btnPemasokkanKomponen.Click += new System.EventHandler(this.btnPemasokkanKomponen_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnLihat);
            this.panel2.Controls.Add(this.dateSampai);
            this.panel2.Controls.Add(this.dateSejak);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bunifuMaterialTextbox3);
            this.bunifuTransition1.SetDecoration(this.panel2, BunifuAnimatorNS.DecorationType.None);
            this.panel2.Location = new System.Drawing.Point(3, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(293, 231);
            this.panel2.TabIndex = 47;
            // 
            // btnLihat
            // 
            this.btnLihat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnLihat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnLihat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLihat.BorderRadius = 0;
            this.btnLihat.ButtonText = "Lihat";
            this.btnLihat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.btnLihat, BunifuAnimatorNS.DecorationType.None);
            this.btnLihat.DisabledColor = System.Drawing.Color.Gray;
            this.btnLihat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLihat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnLihat.Iconimage = null;
            this.btnLihat.Iconimage_right = null;
            this.btnLihat.Iconimage_right_Selected = null;
            this.btnLihat.Iconimage_Selected = null;
            this.btnLihat.IconMarginLeft = 0;
            this.btnLihat.IconMarginRight = 0;
            this.btnLihat.IconRightVisible = true;
            this.btnLihat.IconRightZoom = 0D;
            this.btnLihat.IconVisible = true;
            this.btnLihat.IconZoom = 90D;
            this.btnLihat.IsTab = false;
            this.btnLihat.Location = new System.Drawing.Point(0, 192);
            this.btnLihat.Name = "btnLihat";
            this.btnLihat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnLihat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(56)))), ((int)(((byte)(109)))));
            this.btnLihat.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLihat.selected = false;
            this.btnLihat.Size = new System.Drawing.Size(291, 37);
            this.btnLihat.TabIndex = 56;
            this.btnLihat.Text = "Lihat";
            this.btnLihat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLihat.Textcolor = System.Drawing.Color.White;
            this.btnLihat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLihat.Click += new System.EventHandler(this.btnBayar_Click);
            // 
            // dateSampai
            // 
            this.dateSampai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.dateSampai.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.dateSampai, BunifuAnimatorNS.DecorationType.None);
            this.dateSampai.ForeColor = System.Drawing.Color.White;
            this.dateSampai.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateSampai.FormatCustom = "";
            this.dateSampai.Location = new System.Drawing.Point(3, 137);
            this.dateSampai.Name = "dateSampai";
            this.dateSampai.Size = new System.Drawing.Size(285, 36);
            this.dateSampai.TabIndex = 45;
            this.dateSampai.Value = new System.DateTime(2020, 7, 20, 22, 45, 37, 581);
            this.dateSampai.onValueChanged += new System.EventHandler(this.bunifuDatepicker2_onValueChanged);
            // 
            // dateSejak
            // 
            this.dateSejak.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.dateSejak.BorderRadius = 0;
            this.bunifuTransition1.SetDecoration(this.dateSejak, BunifuAnimatorNS.DecorationType.None);
            this.dateSejak.ForeColor = System.Drawing.Color.White;
            this.dateSejak.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateSejak.FormatCustom = "";
            this.dateSejak.Location = new System.Drawing.Point(3, 71);
            this.dateSejak.Name = "dateSejak";
            this.dateSejak.Size = new System.Drawing.Size(285, 36);
            this.dateSejak.TabIndex = 44;
            this.dateSejak.Value = new System.DateTime(2020, 7, 20, 22, 45, 37, 581);
            this.dateSejak.onValueChanged += new System.EventHandler(this.dateSejak_onValueChanged);
            // 
            // label2
            // 
            this.bunifuTransition1.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(3, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 43;
            this.label2.Text = "Sampai";
            // 
            // label1
            // 
            this.bunifuTransition1.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 24);
            this.label1.TabIndex = 42;
            this.label1.Text = "Sejak";
            // 
            // bunifuMaterialTextbox3
            // 
            this.bunifuMaterialTextbox3.BackColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox3.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuMaterialTextbox3.Enabled = false;
            this.bunifuMaterialTextbox3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox3.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox3.HintText = "";
            this.bunifuMaterialTextbox3.isPassword = false;
            this.bunifuMaterialTextbox3.LineFocusedColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox3.LineThickness = 4;
            this.bunifuMaterialTextbox3.Location = new System.Drawing.Point(0, 0);
            this.bunifuMaterialTextbox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox3.Name = "bunifuMaterialTextbox3";
            this.bunifuMaterialTextbox3.Size = new System.Drawing.Size(291, 39);
            this.bunifuMaterialTextbox3.TabIndex = 3;
            this.bunifuMaterialTextbox3.Text = "Spesifik Data";
            this.bunifuMaterialTextbox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.chart1.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart1.BorderlineColor = System.Drawing.Color.Black;
            this.chart1.BorderlineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Solid;
            chartArea1.BorderColor = System.Drawing.Color.White;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.bunifuTransition1.SetDecoration(this.chart1, BunifuAnimatorNS.DecorationType.None);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(304, 221);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(745, 323);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // bunifuMaterialTextbox4
            // 
            this.bunifuMaterialTextbox4.BackColor = System.Drawing.Color.White;
            this.bunifuMaterialTextbox4.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition1.SetDecoration(this.bunifuMaterialTextbox4, BunifuAnimatorNS.DecorationType.None);
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
            this.bunifuMaterialTextbox4.Location = new System.Drawing.Point(4, 2);
            this.bunifuMaterialTextbox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bunifuMaterialTextbox4.Name = "bunifuMaterialTextbox4";
            this.bunifuMaterialTextbox4.Size = new System.Drawing.Size(1183, 39);
            this.bunifuMaterialTextbox4.TabIndex = 2;
            this.bunifuMaterialTextbox4.Text = "Transaksi";
            this.bunifuMaterialTextbox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmutiara
            // 
            this.bunifuTransition1.SetDecoration(this.txtmutiara, BunifuAnimatorNS.DecorationType.None);
            this.txtmutiara.Font = new System.Drawing.Font("Pristina", 17F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmutiara.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtmutiara.Location = new System.Drawing.Point(3, 559);
            this.txtmutiara.Name = "txtmutiara";
            this.txtmutiara.Size = new System.Drawing.Size(1200, 83);
            this.txtmutiara.TabIndex = 43;
            this.txtmutiara.Text = "Sejak";
            this.txtmutiara.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtmutiara);
            this.Controls.Add(this.panel1);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.Name = "DashBoard";
            this.Size = new System.Drawing.Size(1203, 645);
            this.VisibleChanged += new System.EventHandler(this.DashBoard_VisibleChanged);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.bunifuGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox3;
        private Bunifu.Framework.UI.BunifuDatepicker dateSampai;
        private Bunifu.Framework.UI.BunifuDatepicker dateSejak;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnLihat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuTileButton btnPemasokkanAlat;
        private Bunifu.Framework.UI.BunifuTileButton btnPemasokkanKomponen;
        private Bunifu.Framework.UI.BunifuTileButton btnTransaksiPerbaikan;
        private Bunifu.Framework.UI.BunifuTileButton btnPenjualanKomponen;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label txtInfo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label txtmutiara;
        private System.Windows.Forms.Timer timer;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.RadioButton rb3;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.Label label3;
    }
}
