namespace CRUD.Baru
{
    partial class Menu_Utama
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Utama));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.txtHello = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.panelKiri1 = new System.Windows.Forms.Panel();
            this.btnAlatMasuk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBarangMasuk = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBayarReparasi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReparasiSelesai = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBeliAlat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBeliKomponen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReparasi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuUtama = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRestockKomponen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLaporan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKelolaData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator5 = new Bunifu.Framework.UI.BunifuSeparator();
            this.panelKiri = new System.Windows.Forms.Panel();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.tanggal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.jam = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.karyawan_nama = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelUtama = new System.Windows.Forms.Panel();
            this.panelBawah = new System.Windows.Forms.Panel();
            this.dashBoard = new CRUD.DashBoard();
            this.reportna = new CRUD.Reportna();
            this.pemasokan_v2 = new CRUD.UCBaru.Pemasokan_v2();
            this.bKomponen = new CRUD.UCBaru.BKomponen();
            this.detailReparasi = new CRUD.DetailReparasi();
            this.bayarReparasi = new CRUD.BayarReparasi();
            this.reparasi = new CRUD.Reparasi();
            this.barangmasuk_v2 = new CRUD.barangmasuk_v2();
            this.alatMasuk_v2 = new CRUD.AlatMasuk_v2();
            this.restockAlatKerja_v2 = new CRUD.RestockAlatKerja_v2();
            this.cruD_v2 = new CRUD.CRUD_v2();
            this.bunifuTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panelKiri1.SuspendLayout();
            this.panelKiri.SuspendLayout();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelUtama.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtHello
            // 
            this.txtHello.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition.SetDecoration(this.txtHello, BunifuAnimatorNS.DecorationType.None);
            this.txtHello.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtHello.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHello.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.txtHello.HintForeColor = System.Drawing.Color.Empty;
            this.txtHello.HintText = "";
            this.txtHello.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.txtHello.isPassword = false;
            this.txtHello.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.txtHello.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.txtHello.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.txtHello.LineThickness = 3;
            this.txtHello.Location = new System.Drawing.Point(0, 0);
            this.txtHello.Margin = new System.Windows.Forms.Padding(4);
            this.txtHello.Name = "txtHello";
            this.txtHello.Size = new System.Drawing.Size(161, 41);
            this.txtHello.TabIndex = 1;
            this.txtHello.TabStop = false;
            this.txtHello.Text = "Sakura Reparation";
            this.txtHello.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // panelKiri1
            // 
            this.panelKiri1.Controls.Add(this.btnAlatMasuk);
            this.panelKiri1.Controls.Add(this.btnBarangMasuk);
            this.panelKiri1.Controls.Add(this.btnBayarReparasi);
            this.panelKiri1.Controls.Add(this.btnReparasiSelesai);
            this.panelKiri1.Controls.Add(this.btnBeliAlat);
            this.panelKiri1.Controls.Add(this.btnBeliKomponen);
            this.panelKiri1.Controls.Add(this.btnReparasi);
            this.panelKiri1.Controls.Add(this.btnMenuUtama);
            this.panelKiri1.Controls.Add(this.btnRestockKomponen);
            this.panelKiri1.Controls.Add(this.btnLaporan);
            this.panelKiri1.Controls.Add(this.btnKelolaData);
            this.panelKiri1.Controls.Add(this.txtHello);
            this.panelKiri1.Controls.Add(this.bunifuSeparator1);
            this.panelKiri1.Controls.Add(this.bunifuSeparator2);
            this.panelKiri1.Controls.Add(this.bunifuSeparator3);
            this.panelKiri1.Controls.Add(this.bunifuSeparator4);
            this.panelKiri1.Controls.Add(this.bunifuSeparator5);
            this.bunifuTransition.SetDecoration(this.panelKiri1, BunifuAnimatorNS.DecorationType.None);
            this.panelKiri1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelKiri1.Location = new System.Drawing.Point(0, 38);
            this.panelKiri1.Name = "panelKiri1";
            this.panelKiri1.Size = new System.Drawing.Size(161, 727);
            this.panelKiri1.TabIndex = 5;
            this.panelKiri1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKiri1_Paint);
            // 
            // btnAlatMasuk
            // 
            this.btnAlatMasuk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnAlatMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnAlatMasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAlatMasuk.BorderRadius = 0;
            this.btnAlatMasuk.ButtonText = "Alat Masuk";
            this.btnAlatMasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnAlatMasuk, BunifuAnimatorNS.DecorationType.None);
            this.btnAlatMasuk.DisabledColor = System.Drawing.Color.Gray;
            this.btnAlatMasuk.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnAlatMasuk.ForeColor = System.Drawing.Color.Black;
            this.btnAlatMasuk.Iconcolor = System.Drawing.Color.Black;
            this.btnAlatMasuk.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAlatMasuk.Iconimage")));
            this.btnAlatMasuk.Iconimage_right = null;
            this.btnAlatMasuk.Iconimage_right_Selected = null;
            this.btnAlatMasuk.Iconimage_Selected = null;
            this.btnAlatMasuk.IconMarginLeft = 0;
            this.btnAlatMasuk.IconMarginRight = 0;
            this.btnAlatMasuk.IconRightVisible = true;
            this.btnAlatMasuk.IconRightZoom = 0D;
            this.btnAlatMasuk.IconVisible = false;
            this.btnAlatMasuk.IconZoom = 90D;
            this.btnAlatMasuk.IsTab = false;
            this.btnAlatMasuk.Location = new System.Drawing.Point(0, 311);
            this.btnAlatMasuk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAlatMasuk.Name = "btnAlatMasuk";
            this.btnAlatMasuk.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnAlatMasuk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnAlatMasuk.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.btnAlatMasuk.selected = false;
            this.btnAlatMasuk.Size = new System.Drawing.Size(161, 29);
            this.btnAlatMasuk.TabIndex = 27;
            this.btnAlatMasuk.Text = "Alat Masuk";
            this.btnAlatMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAlatMasuk.Textcolor = System.Drawing.Color.White;
            this.btnAlatMasuk.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlatMasuk.Click += new System.EventHandler(this.btnAlatMasuk_Click);
            // 
            // btnBarangMasuk
            // 
            this.btnBarangMasuk.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnBarangMasuk.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnBarangMasuk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBarangMasuk.BorderRadius = 0;
            this.btnBarangMasuk.ButtonText = "Komponen Masuk";
            this.btnBarangMasuk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnBarangMasuk, BunifuAnimatorNS.DecorationType.None);
            this.btnBarangMasuk.DisabledColor = System.Drawing.Color.Gray;
            this.btnBarangMasuk.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnBarangMasuk.ForeColor = System.Drawing.Color.Black;
            this.btnBarangMasuk.Iconcolor = System.Drawing.Color.Black;
            this.btnBarangMasuk.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBarangMasuk.Iconimage")));
            this.btnBarangMasuk.Iconimage_right = null;
            this.btnBarangMasuk.Iconimage_right_Selected = null;
            this.btnBarangMasuk.Iconimage_Selected = null;
            this.btnBarangMasuk.IconMarginLeft = 0;
            this.btnBarangMasuk.IconMarginRight = 0;
            this.btnBarangMasuk.IconRightVisible = true;
            this.btnBarangMasuk.IconRightZoom = 0D;
            this.btnBarangMasuk.IconVisible = false;
            this.btnBarangMasuk.IconZoom = 90D;
            this.btnBarangMasuk.IsTab = false;
            this.btnBarangMasuk.Location = new System.Drawing.Point(0, 348);
            this.btnBarangMasuk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBarangMasuk.Name = "btnBarangMasuk";
            this.btnBarangMasuk.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnBarangMasuk.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnBarangMasuk.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.btnBarangMasuk.selected = false;
            this.btnBarangMasuk.Size = new System.Drawing.Size(161, 29);
            this.btnBarangMasuk.TabIndex = 25;
            this.btnBarangMasuk.Text = "Komponen Masuk";
            this.btnBarangMasuk.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBarangMasuk.Textcolor = System.Drawing.Color.White;
            this.btnBarangMasuk.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBarangMasuk.Click += new System.EventHandler(this.btnBarangMasuk_Click);
            // 
            // btnBayarReparasi
            // 
            this.btnBayarReparasi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnBayarReparasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnBayarReparasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBayarReparasi.BorderRadius = 0;
            this.btnBayarReparasi.ButtonText = "Bayar Reparasi";
            this.btnBayarReparasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnBayarReparasi, BunifuAnimatorNS.DecorationType.None);
            this.btnBayarReparasi.DisabledColor = System.Drawing.Color.Gray;
            this.btnBayarReparasi.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnBayarReparasi.ForeColor = System.Drawing.Color.Black;
            this.btnBayarReparasi.Iconcolor = System.Drawing.Color.Black;
            this.btnBayarReparasi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBayarReparasi.Iconimage")));
            this.btnBayarReparasi.Iconimage_right = null;
            this.btnBayarReparasi.Iconimage_right_Selected = null;
            this.btnBayarReparasi.Iconimage_Selected = null;
            this.btnBayarReparasi.IconMarginLeft = 0;
            this.btnBayarReparasi.IconMarginRight = 0;
            this.btnBayarReparasi.IconRightVisible = true;
            this.btnBayarReparasi.IconRightZoom = 0D;
            this.btnBayarReparasi.IconVisible = false;
            this.btnBayarReparasi.IconZoom = 90D;
            this.btnBayarReparasi.IsTab = false;
            this.btnBayarReparasi.Location = new System.Drawing.Point(0, 162);
            this.btnBayarReparasi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBayarReparasi.Name = "btnBayarReparasi";
            this.btnBayarReparasi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnBayarReparasi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnBayarReparasi.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.btnBayarReparasi.selected = false;
            this.btnBayarReparasi.Size = new System.Drawing.Size(161, 29);
            this.btnBayarReparasi.TabIndex = 22;
            this.btnBayarReparasi.Text = "Bayar Reparasi";
            this.btnBayarReparasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBayarReparasi.Textcolor = System.Drawing.Color.White;
            this.btnBayarReparasi.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBayarReparasi.Click += new System.EventHandler(this.btnBayarReparasi_Click);
            // 
            // btnReparasiSelesai
            // 
            this.btnReparasiSelesai.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnReparasiSelesai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnReparasiSelesai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReparasiSelesai.BorderRadius = 0;
            this.btnReparasiSelesai.ButtonText = "Reparasi Selesai";
            this.btnReparasiSelesai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnReparasiSelesai, BunifuAnimatorNS.DecorationType.None);
            this.btnReparasiSelesai.DisabledColor = System.Drawing.Color.Gray;
            this.btnReparasiSelesai.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnReparasiSelesai.ForeColor = System.Drawing.Color.Black;
            this.btnReparasiSelesai.Iconcolor = System.Drawing.Color.Black;
            this.btnReparasiSelesai.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReparasiSelesai.Iconimage")));
            this.btnReparasiSelesai.Iconimage_right = null;
            this.btnReparasiSelesai.Iconimage_right_Selected = null;
            this.btnReparasiSelesai.Iconimage_Selected = null;
            this.btnReparasiSelesai.IconMarginLeft = 0;
            this.btnReparasiSelesai.IconMarginRight = 0;
            this.btnReparasiSelesai.IconRightVisible = true;
            this.btnReparasiSelesai.IconRightZoom = 0D;
            this.btnReparasiSelesai.IconVisible = false;
            this.btnReparasiSelesai.IconZoom = 90D;
            this.btnReparasiSelesai.IsTab = false;
            this.btnReparasiSelesai.Location = new System.Drawing.Point(0, 274);
            this.btnReparasiSelesai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReparasiSelesai.Name = "btnReparasiSelesai";
            this.btnReparasiSelesai.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnReparasiSelesai.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnReparasiSelesai.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.btnReparasiSelesai.selected = false;
            this.btnReparasiSelesai.Size = new System.Drawing.Size(161, 29);
            this.btnReparasiSelesai.TabIndex = 21;
            this.btnReparasiSelesai.Text = "Reparasi Selesai";
            this.btnReparasiSelesai.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReparasiSelesai.Textcolor = System.Drawing.Color.White;
            this.btnReparasiSelesai.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparasiSelesai.Click += new System.EventHandler(this.btnReparasiSelesai_Click);
            // 
            // btnBeliAlat
            // 
            this.btnBeliAlat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnBeliAlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnBeliAlat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeliAlat.BorderRadius = 0;
            this.btnBeliAlat.ButtonText = "Restock Alat Kerja";
            this.btnBeliAlat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnBeliAlat, BunifuAnimatorNS.DecorationType.None);
            this.btnBeliAlat.DisabledColor = System.Drawing.Color.Gray;
            this.btnBeliAlat.Iconcolor = System.Drawing.Color.Black;
            this.btnBeliAlat.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBeliAlat.Iconimage")));
            this.btnBeliAlat.Iconimage_right = null;
            this.btnBeliAlat.Iconimage_right_Selected = null;
            this.btnBeliAlat.Iconimage_Selected = null;
            this.btnBeliAlat.IconMarginLeft = 0;
            this.btnBeliAlat.IconMarginRight = 0;
            this.btnBeliAlat.IconRightVisible = true;
            this.btnBeliAlat.IconRightZoom = 0D;
            this.btnBeliAlat.IconVisible = false;
            this.btnBeliAlat.IconZoom = 90D;
            this.btnBeliAlat.IsTab = false;
            this.btnBeliAlat.Location = new System.Drawing.Point(0, 201);
            this.btnBeliAlat.Name = "btnBeliAlat";
            this.btnBeliAlat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnBeliAlat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnBeliAlat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBeliAlat.selected = false;
            this.btnBeliAlat.Size = new System.Drawing.Size(161, 29);
            this.btnBeliAlat.TabIndex = 20;
            this.btnBeliAlat.Text = "Restock Alat Kerja";
            this.btnBeliAlat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeliAlat.Textcolor = System.Drawing.Color.White;
            this.btnBeliAlat.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeliAlat.Click += new System.EventHandler(this.btnBeliAlat_Click);
            // 
            // btnBeliKomponen
            // 
            this.btnBeliKomponen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnBeliKomponen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnBeliKomponen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeliKomponen.BorderRadius = 0;
            this.btnBeliKomponen.ButtonText = "Beli komponen";
            this.btnBeliKomponen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnBeliKomponen, BunifuAnimatorNS.DecorationType.None);
            this.btnBeliKomponen.DisabledColor = System.Drawing.Color.Gray;
            this.btnBeliKomponen.Iconcolor = System.Drawing.Color.Black;
            this.btnBeliKomponen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnBeliKomponen.Iconimage")));
            this.btnBeliKomponen.Iconimage_right = null;
            this.btnBeliKomponen.Iconimage_right_Selected = null;
            this.btnBeliKomponen.Iconimage_Selected = null;
            this.btnBeliKomponen.IconMarginLeft = 0;
            this.btnBeliKomponen.IconMarginRight = 0;
            this.btnBeliKomponen.IconRightVisible = true;
            this.btnBeliKomponen.IconRightZoom = 0D;
            this.btnBeliKomponen.IconVisible = false;
            this.btnBeliKomponen.IconZoom = 90D;
            this.btnBeliKomponen.IsTab = false;
            this.btnBeliKomponen.Location = new System.Drawing.Point(0, 119);
            this.btnBeliKomponen.Name = "btnBeliKomponen";
            this.btnBeliKomponen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnBeliKomponen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnBeliKomponen.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBeliKomponen.selected = false;
            this.btnBeliKomponen.Size = new System.Drawing.Size(161, 29);
            this.btnBeliKomponen.TabIndex = 19;
            this.btnBeliKomponen.Text = "Beli komponen";
            this.btnBeliKomponen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeliKomponen.Textcolor = System.Drawing.Color.White;
            this.btnBeliKomponen.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBeliKomponen.Click += new System.EventHandler(this.btnBeliKomponen_Click);
            // 
            // btnReparasi
            // 
            this.btnReparasi.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnReparasi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnReparasi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReparasi.BorderRadius = 0;
            this.btnReparasi.ButtonText = "Reparasi Alat";
            this.btnReparasi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnReparasi, BunifuAnimatorNS.DecorationType.None);
            this.btnReparasi.DisabledColor = System.Drawing.Color.Gray;
            this.btnReparasi.Iconcolor = System.Drawing.Color.Black;
            this.btnReparasi.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReparasi.Iconimage")));
            this.btnReparasi.Iconimage_right = null;
            this.btnReparasi.Iconimage_right_Selected = null;
            this.btnReparasi.Iconimage_Selected = null;
            this.btnReparasi.IconMarginLeft = 0;
            this.btnReparasi.IconMarginRight = 0;
            this.btnReparasi.IconRightVisible = true;
            this.btnReparasi.IconRightZoom = 0D;
            this.btnReparasi.IconVisible = false;
            this.btnReparasi.IconZoom = 90D;
            this.btnReparasi.IsTab = false;
            this.btnReparasi.Location = new System.Drawing.Point(0, 84);
            this.btnReparasi.Name = "btnReparasi";
            this.btnReparasi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnReparasi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnReparasi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReparasi.selected = false;
            this.btnReparasi.Size = new System.Drawing.Size(161, 29);
            this.btnReparasi.TabIndex = 3;
            this.btnReparasi.Text = "Reparasi Alat";
            this.btnReparasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReparasi.Textcolor = System.Drawing.Color.White;
            this.btnReparasi.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparasi.Click += new System.EventHandler(this.bunifuFlatButton1_Click_2);
            // 
            // btnMenuUtama
            // 
            this.btnMenuUtama.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnMenuUtama.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnMenuUtama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMenuUtama.BorderRadius = 0;
            this.btnMenuUtama.ButtonText = "Menu Utama";
            this.btnMenuUtama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnMenuUtama, BunifuAnimatorNS.DecorationType.None);
            this.btnMenuUtama.DisabledColor = System.Drawing.Color.Gray;
            this.btnMenuUtama.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnMenuUtama.ForeColor = System.Drawing.Color.Black;
            this.btnMenuUtama.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMenuUtama.Iconimage = null;
            this.btnMenuUtama.Iconimage_right = null;
            this.btnMenuUtama.Iconimage_right_Selected = null;
            this.btnMenuUtama.Iconimage_Selected = null;
            this.btnMenuUtama.IconMarginLeft = 0;
            this.btnMenuUtama.IconMarginRight = 0;
            this.btnMenuUtama.IconRightVisible = true;
            this.btnMenuUtama.IconRightZoom = 0D;
            this.btnMenuUtama.IconVisible = false;
            this.btnMenuUtama.IconZoom = 80D;
            this.btnMenuUtama.IsTab = false;
            this.btnMenuUtama.Location = new System.Drawing.Point(0, 48);
            this.btnMenuUtama.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenuUtama.Name = "btnMenuUtama";
            this.btnMenuUtama.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnMenuUtama.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnMenuUtama.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.btnMenuUtama.selected = false;
            this.btnMenuUtama.Size = new System.Drawing.Size(161, 29);
            this.btnMenuUtama.TabIndex = 16;
            this.btnMenuUtama.Text = "Menu Utama";
            this.btnMenuUtama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuUtama.Textcolor = System.Drawing.Color.White;
            this.btnMenuUtama.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuUtama.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // btnRestockKomponen
            // 
            this.btnRestockKomponen.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnRestockKomponen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnRestockKomponen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestockKomponen.BorderRadius = 0;
            this.btnRestockKomponen.ButtonText = "Restock Komponen";
            this.btnRestockKomponen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnRestockKomponen, BunifuAnimatorNS.DecorationType.None);
            this.btnRestockKomponen.DisabledColor = System.Drawing.Color.Gray;
            this.btnRestockKomponen.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnRestockKomponen.ForeColor = System.Drawing.Color.Black;
            this.btnRestockKomponen.Iconcolor = System.Drawing.Color.Black;
            this.btnRestockKomponen.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnRestockKomponen.Iconimage")));
            this.btnRestockKomponen.Iconimage_right = null;
            this.btnRestockKomponen.Iconimage_right_Selected = null;
            this.btnRestockKomponen.Iconimage_Selected = null;
            this.btnRestockKomponen.IconMarginLeft = 0;
            this.btnRestockKomponen.IconMarginRight = 0;
            this.btnRestockKomponen.IconRightVisible = true;
            this.btnRestockKomponen.IconRightZoom = 0D;
            this.btnRestockKomponen.IconVisible = false;
            this.btnRestockKomponen.IconZoom = 90D;
            this.btnRestockKomponen.IsTab = false;
            this.btnRestockKomponen.Location = new System.Drawing.Point(0, 237);
            this.btnRestockKomponen.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestockKomponen.Name = "btnRestockKomponen";
            this.btnRestockKomponen.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnRestockKomponen.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnRestockKomponen.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.btnRestockKomponen.selected = false;
            this.btnRestockKomponen.Size = new System.Drawing.Size(161, 29);
            this.btnRestockKomponen.TabIndex = 13;
            this.btnRestockKomponen.Text = "Restock Komponen";
            this.btnRestockKomponen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRestockKomponen.Textcolor = System.Drawing.Color.White;
            this.btnRestockKomponen.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestockKomponen.Click += new System.EventHandler(this.btnTransaksi_Click);
            // 
            // btnLaporan
            // 
            this.btnLaporan.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnLaporan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnLaporan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLaporan.BorderRadius = 0;
            this.btnLaporan.ButtonText = "Laporan";
            this.btnLaporan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnLaporan, BunifuAnimatorNS.DecorationType.None);
            this.btnLaporan.DisabledColor = System.Drawing.Color.Gray;
            this.btnLaporan.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnLaporan.ForeColor = System.Drawing.Color.Black;
            this.btnLaporan.Iconcolor = System.Drawing.Color.Black;
            this.btnLaporan.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnLaporan.Iconimage")));
            this.btnLaporan.Iconimage_right = null;
            this.btnLaporan.Iconimage_right_Selected = null;
            this.btnLaporan.Iconimage_Selected = null;
            this.btnLaporan.IconMarginLeft = 0;
            this.btnLaporan.IconMarginRight = 0;
            this.btnLaporan.IconRightVisible = true;
            this.btnLaporan.IconRightZoom = 0D;
            this.btnLaporan.IconVisible = false;
            this.btnLaporan.IconZoom = 90D;
            this.btnLaporan.IsTab = false;
            this.btnLaporan.Location = new System.Drawing.Point(0, 431);
            this.btnLaporan.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLaporan.Name = "btnLaporan";
            this.btnLaporan.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnLaporan.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnLaporan.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.btnLaporan.selected = false;
            this.btnLaporan.Size = new System.Drawing.Size(161, 29);
            this.btnLaporan.TabIndex = 14;
            this.btnLaporan.Text = "Laporan";
            this.btnLaporan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLaporan.Textcolor = System.Drawing.Color.White;
            this.btnLaporan.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLaporan.Click += new System.EventHandler(this.btnLaporan_Click);
            // 
            // btnKelolaData
            // 
            this.btnKelolaData.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnKelolaData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnKelolaData.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKelolaData.BorderRadius = 0;
            this.btnKelolaData.ButtonText = "Kelola Data";
            this.btnKelolaData.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnKelolaData, BunifuAnimatorNS.DecorationType.None);
            this.btnKelolaData.DisabledColor = System.Drawing.Color.Gray;
            this.btnKelolaData.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btnKelolaData.ForeColor = System.Drawing.Color.Black;
            this.btnKelolaData.Iconcolor = System.Drawing.Color.Black;
            this.btnKelolaData.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnKelolaData.Iconimage")));
            this.btnKelolaData.Iconimage_right = null;
            this.btnKelolaData.Iconimage_right_Selected = null;
            this.btnKelolaData.Iconimage_Selected = null;
            this.btnKelolaData.IconMarginLeft = 0;
            this.btnKelolaData.IconMarginRight = 0;
            this.btnKelolaData.IconRightVisible = true;
            this.btnKelolaData.IconRightZoom = 0D;
            this.btnKelolaData.IconVisible = false;
            this.btnKelolaData.IconZoom = 90D;
            this.btnKelolaData.IsTab = false;
            this.btnKelolaData.Location = new System.Drawing.Point(0, 394);
            this.btnKelolaData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKelolaData.Name = "btnKelolaData";
            this.btnKelolaData.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnKelolaData.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnKelolaData.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.btnKelolaData.selected = false;
            this.btnKelolaData.Size = new System.Drawing.Size(161, 29);
            this.btnKelolaData.TabIndex = 13;
            this.btnKelolaData.Text = "Kelola Data";
            this.btnKelolaData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKelolaData.Textcolor = System.Drawing.Color.White;
            this.btnKelolaData.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKelolaData.Click += new System.EventHandler(this.btnKelolaData_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition.SetDecoration(this.bunifuSeparator1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 3;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 62);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(161, 35);
            this.bunifuSeparator1.TabIndex = 11;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition.SetDecoration(this.bunifuSeparator2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 3;
            this.bunifuSeparator2.Location = new System.Drawing.Point(0, 138);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(161, 35);
            this.bunifuSeparator2.TabIndex = 23;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition.SetDecoration(this.bunifuSeparator3, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator3.LineThickness = 3;
            this.bunifuSeparator3.Location = new System.Drawing.Point(-3, 179);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(161, 35);
            this.bunifuSeparator3.TabIndex = 12;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition.SetDecoration(this.bunifuSeparator4, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator4.LineThickness = 3;
            this.bunifuSeparator4.Location = new System.Drawing.Point(0, 253);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(161, 35);
            this.bunifuSeparator4.TabIndex = 24;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // bunifuSeparator5
            // 
            this.bunifuSeparator5.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTransition.SetDecoration(this.bunifuSeparator5, BunifuAnimatorNS.DecorationType.None);
            this.bunifuSeparator5.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator5.LineThickness = 3;
            this.bunifuSeparator5.Location = new System.Drawing.Point(0, 369);
            this.bunifuSeparator5.Name = "bunifuSeparator5";
            this.bunifuSeparator5.Size = new System.Drawing.Size(161, 35);
            this.bunifuSeparator5.TabIndex = 26;
            this.bunifuSeparator5.Transparency = 255;
            this.bunifuSeparator5.Vertical = false;
            // 
            // panelKiri
            // 
            this.panelKiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.panelKiri.Controls.Add(this.panelKiri1);
            this.bunifuTransition.SetDecoration(this.panelKiri, BunifuAnimatorNS.DecorationType.None);
            this.panelKiri.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelKiri.Location = new System.Drawing.Point(0, 0);
            this.panelKiri.Name = "panelKiri";
            this.panelKiri.Size = new System.Drawing.Size(161, 765);
            this.panelKiri.TabIndex = 0;
            this.panelKiri.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelKiri_MouseClick);
            // 
            // panelAtas
            // 
            this.panelAtas.AutoSize = true;
            this.panelAtas.BackColor = System.Drawing.Color.White;
            this.panelAtas.Controls.Add(this.tanggal);
            this.panelAtas.Controls.Add(this.jam);
            this.panelAtas.Controls.Add(this.btnExit);
            this.panelAtas.Controls.Add(this.karyawan_nama);
            this.bunifuTransition.SetDecoration(this.panelAtas, BunifuAnimatorNS.DecorationType.None);
            this.panelAtas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAtas.Location = new System.Drawing.Point(161, 0);
            this.panelAtas.Name = "panelAtas";
            this.panelAtas.Size = new System.Drawing.Size(1203, 38);
            this.panelAtas.TabIndex = 8;
            // 
            // tanggal
            // 
            this.tanggal.AutoSize = true;
            this.tanggal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition.SetDecoration(this.tanggal, BunifuAnimatorNS.DecorationType.None);
            this.tanggal.Enabled = false;
            this.tanggal.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.tanggal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.tanggal.HintForeColor = System.Drawing.Color.Empty;
            this.tanggal.HintText = "";
            this.tanggal.isPassword = false;
            this.tanggal.LineFocusedColor = System.Drawing.Color.Blue;
            this.tanggal.LineIdleColor = System.Drawing.Color.Gray;
            this.tanggal.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tanggal.LineThickness = 3;
            this.tanggal.Location = new System.Drawing.Point(7, 3);
            this.tanggal.Margin = new System.Windows.Forms.Padding(4);
            this.tanggal.Name = "tanggal";
            this.tanggal.Size = new System.Drawing.Size(174, 30);
            this.tanggal.TabIndex = 10;
            this.tanggal.Text = "Tanggal";
            this.tanggal.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // jam
            // 
            this.jam.AutoSize = true;
            this.jam.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition.SetDecoration(this.jam, BunifuAnimatorNS.DecorationType.None);
            this.jam.Enabled = false;
            this.jam.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.jam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.jam.HintForeColor = System.Drawing.Color.Empty;
            this.jam.HintText = "";
            this.jam.isPassword = false;
            this.jam.LineFocusedColor = System.Drawing.Color.Blue;
            this.jam.LineIdleColor = System.Drawing.Color.Gray;
            this.jam.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.jam.LineThickness = 3;
            this.jam.Location = new System.Drawing.Point(189, 4);
            this.jam.Margin = new System.Windows.Forms.Padding(4);
            this.jam.Name = "jam";
            this.jam.Size = new System.Drawing.Size(107, 30);
            this.jam.TabIndex = 9;
            this.jam.Text = "Waktu";
            this.jam.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.btnExit, BunifuAnimatorNS.DecorationType.None);
            this.btnExit.Image = global::CRUD.Properties.Resources.Exit__2_;
            this.btnExit.ImageActive = null;
            this.btnExit.Location = new System.Drawing.Point(1158, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(42, 30);
            this.btnExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnExit.TabIndex = 8;
            this.btnExit.TabStop = false;
            this.btnExit.Zoom = 5;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // karyawan_nama
            // 
            this.karyawan_nama.Activecolor = System.Drawing.SystemColors.ActiveCaption;
            this.karyawan_nama.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.karyawan_nama.BackColor = System.Drawing.Color.Transparent;
            this.karyawan_nama.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.karyawan_nama.BorderRadius = 0;
            this.karyawan_nama.ButtonText = "Profil";
            this.karyawan_nama.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.karyawan_nama, BunifuAnimatorNS.DecorationType.None);
            this.karyawan_nama.DisabledColor = System.Drawing.Color.Gray;
            this.karyawan_nama.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.karyawan_nama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.karyawan_nama.Iconcolor = System.Drawing.Color.Transparent;
            this.karyawan_nama.Iconimage = ((System.Drawing.Image)(resources.GetObject("karyawan_nama.Iconimage")));
            this.karyawan_nama.Iconimage_right = null;
            this.karyawan_nama.Iconimage_right_Selected = null;
            this.karyawan_nama.Iconimage_Selected = null;
            this.karyawan_nama.IconMarginLeft = 0;
            this.karyawan_nama.IconMarginRight = 0;
            this.karyawan_nama.IconRightVisible = true;
            this.karyawan_nama.IconRightZoom = 0D;
            this.karyawan_nama.IconVisible = true;
            this.karyawan_nama.IconZoom = 90D;
            this.karyawan_nama.IsTab = false;
            this.karyawan_nama.Location = new System.Drawing.Point(1002, 4);
            this.karyawan_nama.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.karyawan_nama.Name = "karyawan_nama";
            this.karyawan_nama.Normalcolor = System.Drawing.Color.Transparent;
            this.karyawan_nama.OnHovercolor = System.Drawing.Color.Transparent;
            this.karyawan_nama.OnHoverTextColor = System.Drawing.SystemColors.ActiveCaption;
            this.karyawan_nama.selected = false;
            this.karyawan_nama.Size = new System.Drawing.Size(150, 30);
            this.karyawan_nama.TabIndex = 7;
            this.karyawan_nama.Text = "Profil";
            this.karyawan_nama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.karyawan_nama.Textcolor = System.Drawing.Color.DimGray;
            this.karyawan_nama.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // panelUtama
            // 
            this.panelUtama.Controls.Add(this.panelBawah);
            this.panelUtama.Controls.Add(this.dashBoard);
            this.panelUtama.Controls.Add(this.reportna);
            this.panelUtama.Controls.Add(this.pemasokan_v2);
            this.panelUtama.Controls.Add(this.bKomponen);
            this.panelUtama.Controls.Add(this.detailReparasi);
            this.panelUtama.Controls.Add(this.bayarReparasi);
            this.panelUtama.Controls.Add(this.reparasi);
            this.panelUtama.Controls.Add(this.barangmasuk_v2);
            this.panelUtama.Controls.Add(this.alatMasuk_v2);
            this.panelUtama.Controls.Add(this.restockAlatKerja_v2);
            this.panelUtama.Controls.Add(this.cruD_v2);
            this.bunifuTransition.SetDecoration(this.panelUtama, BunifuAnimatorNS.DecorationType.None);
            this.panelUtama.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelUtama.Location = new System.Drawing.Point(161, 38);
            this.panelUtama.Name = "panelUtama";
            this.panelUtama.Size = new System.Drawing.Size(1203, 727);
            this.panelUtama.TabIndex = 9;
            // 
            // panelBawah
            // 
            this.panelBawah.BackColor = System.Drawing.Color.White;
            this.bunifuTransition.SetDecoration(this.panelBawah, BunifuAnimatorNS.DecorationType.None);
            this.panelBawah.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBawah.Location = new System.Drawing.Point(0, 680);
            this.panelBawah.Name = "panelBawah";
            this.panelBawah.Size = new System.Drawing.Size(1203, 47);
            this.panelBawah.TabIndex = 2;
            // 
            // dashBoard
            // 
            this.dashBoard.BackColor = System.Drawing.Color.White;
            this.dashBoard.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition.SetDecoration(this.dashBoard, BunifuAnimatorNS.DecorationType.None);
            this.dashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoard.Location = new System.Drawing.Point(0, 0);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(1203, 727);
            this.dashBoard.TabIndex = 0;
            // 
            // reportna
            // 
            this.reportna.BackColor = System.Drawing.Color.White;
            this.bunifuTransition.SetDecoration(this.reportna, BunifuAnimatorNS.DecorationType.None);
            this.reportna.Location = new System.Drawing.Point(0, 0);
            this.reportna.Name = "reportna";
            this.reportna.Size = new System.Drawing.Size(1200, 675);
            this.reportna.TabIndex = 22;
            // 
            // pemasokan_v2
            // 
            this.pemasokan_v2.BackColor = System.Drawing.Color.Silver;
            this.pemasokan_v2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bunifuTransition.SetDecoration(this.pemasokan_v2, BunifuAnimatorNS.DecorationType.None);
            this.pemasokan_v2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pemasokan_v2.Location = new System.Drawing.Point(0, 0);
            this.pemasokan_v2.Name = "pemasokan_v2";
            this.pemasokan_v2.Size = new System.Drawing.Size(1203, 727);
            this.pemasokan_v2.TabIndex = 1;
            // 
            // bKomponen
            // 
            this.bKomponen.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuTransition.SetDecoration(this.bKomponen, BunifuAnimatorNS.DecorationType.None);
            this.bKomponen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bKomponen.Location = new System.Drawing.Point(0, 0);
            this.bKomponen.Name = "bKomponen";
            this.bKomponen.Size = new System.Drawing.Size(1203, 727);
            this.bKomponen.TabIndex = 3;
            this.bKomponen.Visible = false;
            // 
            // detailReparasi
            // 
            this.detailReparasi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuTransition.SetDecoration(this.detailReparasi, BunifuAnimatorNS.DecorationType.None);
            this.detailReparasi.Location = new System.Drawing.Point(0, 0);
            this.detailReparasi.Name = "detailReparasi";
            this.detailReparasi.Size = new System.Drawing.Size(1201, 675);
            this.detailReparasi.TabIndex = 6;
            // 
            // bayarReparasi
            // 
            this.bayarReparasi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuTransition.SetDecoration(this.bayarReparasi, BunifuAnimatorNS.DecorationType.None);
            this.bayarReparasi.Location = new System.Drawing.Point(0, 0);
            this.bayarReparasi.Name = "bayarReparasi";
            this.bayarReparasi.Size = new System.Drawing.Size(1201, 675);
            this.bayarReparasi.TabIndex = 7;
            // 
            // reparasi
            // 
            this.reparasi.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuTransition.SetDecoration(this.reparasi, BunifuAnimatorNS.DecorationType.None);
            this.reparasi.Location = new System.Drawing.Point(0, 0);
            this.reparasi.Name = "reparasi";
            this.reparasi.Size = new System.Drawing.Size(1201, 675);
            this.reparasi.TabIndex = 5;
            // 
            // barangmasuk_v2
            // 
            this.barangmasuk_v2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuTransition.SetDecoration(this.barangmasuk_v2, BunifuAnimatorNS.DecorationType.None);
            this.barangmasuk_v2.Location = new System.Drawing.Point(0, 0);
            this.barangmasuk_v2.Name = "barangmasuk_v2";
            this.barangmasuk_v2.Size = new System.Drawing.Size(1201, 675);
            this.barangmasuk_v2.TabIndex = 8;
            // 
            // alatMasuk_v2
            // 
            this.alatMasuk_v2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuTransition.SetDecoration(this.alatMasuk_v2, BunifuAnimatorNS.DecorationType.None);
            this.alatMasuk_v2.Location = new System.Drawing.Point(0, 0);
            this.alatMasuk_v2.Name = "alatMasuk_v2";
            this.alatMasuk_v2.Size = new System.Drawing.Size(1201, 675);
            this.alatMasuk_v2.TabIndex = 10;
            // 
            // restockAlatKerja_v2
            // 
            this.restockAlatKerja_v2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuTransition.SetDecoration(this.restockAlatKerja_v2, BunifuAnimatorNS.DecorationType.None);
            this.restockAlatKerja_v2.Location = new System.Drawing.Point(0, 0);
            this.restockAlatKerja_v2.Name = "restockAlatKerja_v2";
            this.restockAlatKerja_v2.Size = new System.Drawing.Size(1201, 675);
            this.restockAlatKerja_v2.TabIndex = 9;
            // 
            // cruD_v2
            // 
            this.cruD_v2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.bunifuTransition.SetDecoration(this.cruD_v2, BunifuAnimatorNS.DecorationType.None);
            this.cruD_v2.Location = new System.Drawing.Point(0, 0);
            this.cruD_v2.Name = "cruD_v2";
            this.cruD_v2.Size = new System.Drawing.Size(1200, 675);
            this.cruD_v2.TabIndex = 11;
            // 
            // bunifuTransition
            // 
            this.bunifuTransition.AnimationType = BunifuAnimatorNS.AnimationType.VertSlide;
            this.bunifuTransition.Cursor = null;
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
            this.bunifuTransition.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.reportViewer2);
            this.bunifuTransition.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(161, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1203, 727);
            this.panel1.TabIndex = 10;
            // 
            // reportViewer2
            // 
            this.bunifuTransition.SetDecoration(this.reportViewer2, BunifuAnimatorNS.DecorationType.None);
            reportDataSource1.Name = "Restock";
            reportDataSource1.Value = null;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CRUD.ReportRestock1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 62);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1203, 632);
            this.reportViewer2.TabIndex = 0;
            // 
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 765);
            this.Controls.Add(this.panelUtama);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelKiri);
            this.bunifuTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Menu_Utama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu_Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Utama_Load);
            this.panelKiri1.ResumeLayout(false);
            this.panelKiri.ResumeLayout(false);
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelUtama.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtHello;
        private System.Windows.Forms.Timer clock;
        private System.Windows.Forms.Panel panelKiri1;
        private System.Windows.Forms.Panel panelKiri;
        private System.Windows.Forms.Panel panelAtas;
        private Bunifu.Framework.UI.BunifuImageButton btnExit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox tanggal;
        private Bunifu.Framework.UI.BunifuMaterialTextbox jam;
        private Bunifu.Framework.UI.BunifuFlatButton karyawan_nama;
        private Bunifu.Framework.UI.BunifuFlatButton btnLaporan;
        private Bunifu.Framework.UI.BunifuFlatButton btnKelolaData;
        private Bunifu.Framework.UI.BunifuFlatButton btnMenuUtama;
        private Bunifu.Framework.UI.BunifuFlatButton btnRestockKomponen;
        private System.Windows.Forms.Panel panelUtama;
        private UCBaru.Pemasokan_v2 pemasokan_v2;
        private DashBoard dashBoard;
        private System.Windows.Forms.Panel panelBawah;
        private Bunifu.Framework.UI.BunifuFlatButton btnReparasi;
        private Bunifu.Framework.UI.BunifuFlatButton btnBeliKomponen;
        private Bunifu.Framework.UI.BunifuFlatButton btnBeliAlat;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition;
        private UCBaru.BKomponen bKomponen;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Reparasi reparasi;
        private Bunifu.Framework.UI.BunifuFlatButton btnReparasiSelesai;
        private DetailReparasi detailReparasi;
        private Bunifu.Framework.UI.BunifuFlatButton btnBayarReparasi;
        private BayarReparasi bayarReparasi;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator5;
        private Bunifu.Framework.UI.BunifuFlatButton btnBarangMasuk;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private barangmasuk_v2 barangmasuk_v2;
        private RestockAlatKerja_v2 restockAlatKerja_v2;
        private Bunifu.Framework.UI.BunifuFlatButton btnAlatMasuk;
        private AlatMasuk_v2 alatMasuk_v2;
        private CRUD_v2 cruD_v2;
        private Reportna reportna;
    }
}