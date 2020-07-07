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
            this.txtHello = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPanelKiri = new Bunifu.Framework.UI.BunifuImageButton();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.panelKiri1 = new System.Windows.Forms.Panel();
            this.btnBeliAlat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBeliKomponen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReparasi = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMenuUtama = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnRestockKomponen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnLaporan = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnKelolaData = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelKiri = new System.Windows.Forms.Panel();
            this.panelAtas = new System.Windows.Forms.Panel();
            this.tanggal = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.jam = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnExit = new Bunifu.Framework.UI.BunifuImageButton();
            this.karyawan_nama = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panelUtama = new System.Windows.Forms.Panel();
            this.panelBawah = new System.Windows.Forms.Panel();
            this.bKomponen = new CRUD.UCBaru.BKomponen();
            this.pemasokan_v2 = new CRUD.UCBaru.Pemasokan_v2();
            this.dashBoard = new CRUD.DashBoard();
            this.bunifuTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnPanelKiri)).BeginInit();
            this.panelKiri1.SuspendLayout();
            this.panelKiri.SuspendLayout();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelUtama.SuspendLayout();
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
            // btnPanelKiri
            // 
            this.btnPanelKiri.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPanelKiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(0)))), ((int)(((byte)(102)))));
            this.bunifuTransition.SetDecoration(this.btnPanelKiri, BunifuAnimatorNS.DecorationType.None);
            this.btnPanelKiri.Image = ((System.Drawing.Image)(resources.GetObject("btnPanelKiri.Image")));
            this.btnPanelKiri.ImageActive = null;
            this.btnPanelKiri.Location = new System.Drawing.Point(122, 3);
            this.btnPanelKiri.Name = "btnPanelKiri";
            this.btnPanelKiri.Size = new System.Drawing.Size(36, 29);
            this.btnPanelKiri.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnPanelKiri.TabIndex = 0;
            this.btnPanelKiri.TabStop = false;
            this.btnPanelKiri.Zoom = 10;
            this.btnPanelKiri.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // clock
            // 
            this.clock.Enabled = true;
            this.clock.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // panelKiri1
            // 
            this.panelKiri1.Controls.Add(this.btnBeliAlat);
            this.panelKiri1.Controls.Add(this.btnBeliKomponen);
            this.panelKiri1.Controls.Add(this.btnReparasi);
            this.panelKiri1.Controls.Add(this.bunifuFlatButton2);
            this.panelKiri1.Controls.Add(this.btnMenuUtama);
            this.panelKiri1.Controls.Add(this.btnRestockKomponen);
            this.panelKiri1.Controls.Add(this.btnLaporan);
            this.panelKiri1.Controls.Add(this.btnKelolaData);
            this.panelKiri1.Controls.Add(this.txtHello);
            this.bunifuTransition.SetDecoration(this.panelKiri1, BunifuAnimatorNS.DecorationType.None);
            this.panelKiri1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelKiri1.Location = new System.Drawing.Point(0, 38);
            this.panelKiri1.Name = "panelKiri1";
            this.panelKiri1.Size = new System.Drawing.Size(161, 727);
            this.panelKiri1.TabIndex = 5;
            this.panelKiri1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelKiri1_Paint);
            // 
            // btnBeliAlat
            // 
            this.btnBeliAlat.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.btnBeliAlat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnBeliAlat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBeliAlat.BorderRadius = 0;
            this.btnBeliAlat.ButtonText = "Beli Alat";
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
            this.btnBeliAlat.Location = new System.Drawing.Point(0, 263);
            this.btnBeliAlat.Name = "btnBeliAlat";
            this.btnBeliAlat.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnBeliAlat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnBeliAlat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnBeliAlat.selected = false;
            this.btnBeliAlat.Size = new System.Drawing.Size(161, 29);
            this.btnBeliAlat.TabIndex = 20;
            this.btnBeliAlat.Text = "Beli Alat";
            this.btnBeliAlat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBeliAlat.Textcolor = System.Drawing.Color.White;
            this.btnBeliAlat.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnBeliKomponen.Location = new System.Drawing.Point(0, 118);
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
            this.btnReparasi.ButtonText = "Reparasi";
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
            this.btnReparasi.Location = new System.Drawing.Point(0, 83);
            this.btnReparasi.Name = "btnReparasi";
            this.btnReparasi.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.btnReparasi.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.btnReparasi.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReparasi.selected = false;
            this.btnReparasi.Size = new System.Drawing.Size(161, 29);
            this.btnReparasi.TabIndex = 3;
            this.btnReparasi.Text = "Reparasi";
            this.btnReparasi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReparasi.Textcolor = System.Drawing.Color.White;
            this.btnReparasi.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReparasi.Click += new System.EventHandler(this.bunifuFlatButton1_Click_2);
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(70)))));
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Transaksi";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition.SetDecoration(this.bunifuFlatButton2, BunifuAnimatorNS.DecorationType.None);
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Black;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = false;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(0, 337);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(150)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(161, 29);
            this.bunifuFlatButton2.TabIndex = 18;
            this.bunifuFlatButton2.Text = "Transaksi";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
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
            this.btnMenuUtama.Iconcolor = System.Drawing.Color.Black;
            this.btnMenuUtama.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnMenuUtama.Iconimage")));
            this.btnMenuUtama.Iconimage_right = null;
            this.btnMenuUtama.Iconimage_right_Selected = null;
            this.btnMenuUtama.Iconimage_Selected = null;
            this.btnMenuUtama.IconMarginLeft = 0;
            this.btnMenuUtama.IconMarginRight = 0;
            this.btnMenuUtama.IconRightVisible = true;
            this.btnMenuUtama.IconRightZoom = 0D;
            this.btnMenuUtama.IconVisible = false;
            this.btnMenuUtama.IconZoom = 90D;
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
            this.btnRestockKomponen.Location = new System.Drawing.Point(0, 228);
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
            this.btnLaporan.Location = new System.Drawing.Point(0, 373);
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
            this.btnKelolaData.Location = new System.Drawing.Point(0, 301);
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
            // panelKiri
            // 
            this.panelKiri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.panelKiri.Controls.Add(this.panelKiri1);
            this.panelKiri.Controls.Add(this.btnPanelKiri);
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
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
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
            this.panelUtama.Controls.Add(this.bKomponen);
            this.panelUtama.Controls.Add(this.pemasokan_v2);
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
            // dashBoard
            // 
            this.dashBoard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.bunifuTransition.SetDecoration(this.dashBoard, BunifuAnimatorNS.DecorationType.None);
            this.dashBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dashBoard.Location = new System.Drawing.Point(0, 0);
            this.dashBoard.Name = "dashBoard";
            this.dashBoard.Size = new System.Drawing.Size(1203, 727);
            this.dashBoard.TabIndex = 0;
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
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 765);
            this.Controls.Add(this.panelUtama);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelKiri);
            this.bunifuTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Utama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu_Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.btnPanelKiri)).EndInit();
            this.panelKiri1.ResumeLayout(false);
            this.panelKiri.ResumeLayout(false);
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelUtama.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Bunifu.Framework.UI.BunifuImageButton btnPanelKiri;
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
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnReparasi;
        private Bunifu.Framework.UI.BunifuFlatButton btnBeliKomponen;
        private Bunifu.Framework.UI.BunifuFlatButton btnBeliAlat;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition;
        private UCBaru.BKomponen bKomponen;
    }
}