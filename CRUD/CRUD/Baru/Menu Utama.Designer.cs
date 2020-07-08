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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Utama));
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.lrestock1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Report = new CRUD.Report();
            this.lbelikomponenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtHello = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnPanelKiri = new Bunifu.Framework.UI.BunifuImageButton();
            this.clock = new System.Windows.Forms.Timer(this.components);
            this.panelKiri1 = new System.Windows.Forms.Panel();
            this.btnBeliAlat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnBeliKomponen = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReparasi = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panelReport = new System.Windows.Forms.Panel();
            this.reportBeliKomponen = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnCari = new Bunifu.Framework.UI.BunifuImageButton();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTahun = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbBulan = new System.Windows.Forms.ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbReparasi = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBeliKomponen = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rbRestockKomponen = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.rbRestockAlat = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.reportRestock = new Microsoft.Reporting.WinForms.ReportViewer();
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuTransition = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lrestock1TableAdapter = new CRUD.ReportTableAdapters.lrestock1TableAdapter();
            this.lbelikomponenTableAdapter = new CRUD.ReportTableAdapters.lbelikomponenTableAdapter();
            this.bKomponen = new CRUD.UCBaru.BKomponen();
            this.pemasokan_v2 = new CRUD.UCBaru.Pemasokan_v2();
            this.dashBoard = new CRUD.DashBoard();
            ((System.ComponentModel.ISupportInitialize)(this.lrestock1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbelikomponenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPanelKiri)).BeginInit();
            this.panelKiri1.SuspendLayout();
            this.panelKiri.SuspendLayout();
            this.panelAtas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            this.panelUtama.SuspendLayout();
            this.panelReport.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lrestock1BindingSource
            // 
            this.lrestock1BindingSource.DataMember = "lrestock1";
            this.lrestock1BindingSource.DataSource = this.Report;
            // 
            // Report
            // 
            this.Report.DataSetName = "Report";
            this.Report.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lbelikomponenBindingSource
            // 
            this.lbelikomponenBindingSource.DataMember = "lbelikomponen";
            this.lbelikomponenBindingSource.DataSource = this.Report;
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
            this.btnBeliAlat.Location = new System.Drawing.Point(0, 263);
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
            this.btnReparasi.Location = new System.Drawing.Point(0, 83);
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
            this.btnLaporan.Location = new System.Drawing.Point(0, 421);
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
            this.panelUtama.Controls.Add(this.panelReport);
            this.panelUtama.Controls.Add(this.bKomponen);
            this.panelUtama.Controls.Add(this.pemasokan_v2);
            this.panelUtama.Controls.Add(this.dashBoard);
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
            // panelReport
            // 
            this.panelReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(57)))), ((int)(((byte)(107)))));
            this.panelReport.Controls.Add(this.reportBeliKomponen);
            this.panelReport.Controls.Add(this.btnCari);
            this.panelReport.Controls.Add(this.label7);
            this.panelReport.Controls.Add(this.cmbTahun);
            this.panelReport.Controls.Add(this.label6);
            this.panelReport.Controls.Add(this.cmbBulan);
            this.panelReport.Controls.Add(this.flowLayoutPanel1);
            this.panelReport.Controls.Add(this.reportRestock);
            this.panelReport.Controls.Add(this.bunifuMaterialTextbox1);
            this.bunifuTransition.SetDecoration(this.panelReport, BunifuAnimatorNS.DecorationType.None);
            this.panelReport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelReport.Location = new System.Drawing.Point(0, 0);
            this.panelReport.Name = "panelReport";
            this.panelReport.Size = new System.Drawing.Size(1203, 727);
            this.panelReport.TabIndex = 4;
            this.panelReport.Visible = false;
            // 
            // reportBeliKomponen
            // 
            this.bunifuTransition.SetDecoration(this.reportBeliKomponen, BunifuAnimatorNS.DecorationType.None);
            reportDataSource1.Name = "BeliKomponen";
            reportDataSource1.Value = this.lbelikomponenBindingSource;
            this.reportBeliKomponen.LocalReport.DataSources.Add(reportDataSource1);
            this.reportBeliKomponen.LocalReport.ReportEmbeddedResource = "CRUD.ReportBeliKomponen.rdlc";
            this.reportBeliKomponen.Location = new System.Drawing.Point(0, 57);
            this.reportBeliKomponen.Name = "reportBeliKomponen";
            this.reportBeliKomponen.ServerReport.BearerToken = null;
            this.reportBeliKomponen.Size = new System.Drawing.Size(1203, 617);
            this.reportBeliKomponen.TabIndex = 18;
            this.reportBeliKomponen.Visible = false;
            // 
            // btnCari
            // 
            this.btnCari.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(149)))), ((int)(((byte)(131)))));
            this.bunifuTransition.SetDecoration(this.btnCari, BunifuAnimatorNS.DecorationType.None);
            this.btnCari.Image = ((System.Drawing.Image)(resources.GetObject("btnCari.Image")));
            this.btnCari.ImageActive = null;
            this.btnCari.Location = new System.Drawing.Point(1159, 3);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(32, 33);
            this.btnCari.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnCari.TabIndex = 17;
            this.btnCari.TabStop = false;
            this.btnCari.Zoom = 10;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // label7
            // 
            this.bunifuTransition.SetDecoration(this.label7, BunifuAnimatorNS.DecorationType.None);
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(1007, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 30);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tahun";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbTahun
            // 
            this.bunifuTransition.SetDecoration(this.cmbTahun, BunifuAnimatorNS.DecorationType.None);
            this.cmbTahun.FormattingEnabled = true;
            this.cmbTahun.Items.AddRange(new object[] {
            "2019",
            "2020",
            "2021"});
            this.cmbTahun.Location = new System.Drawing.Point(1083, 9);
            this.cmbTahun.Name = "cmbTahun";
            this.cmbTahun.Size = new System.Drawing.Size(62, 21);
            this.cmbTahun.TabIndex = 15;
            this.cmbTahun.Text = "- Tahun -";
            // 
            // label6
            // 
            this.bunifuTransition.SetDecoration(this.label6, BunifuAnimatorNS.DecorationType.None);
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(823, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 30);
            this.label6.TabIndex = 14;
            this.label6.Text = "Bulan";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cmbBulan
            // 
            this.bunifuTransition.SetDecoration(this.cmbBulan, BunifuAnimatorNS.DecorationType.None);
            this.cmbBulan.FormattingEnabled = true;
            this.cmbBulan.Items.AddRange(new object[] {
            "Januari",
            "Februari",
            "Maret",
            "April",
            "Mei",
            "Juni",
            "Juli",
            "Agustus",
            "September",
            "Oktober",
            "November",
            "Desember"});
            this.cmbBulan.Location = new System.Drawing.Point(899, 9);
            this.cmbBulan.Name = "cmbBulan";
            this.cmbBulan.Size = new System.Drawing.Size(102, 21);
            this.cmbBulan.TabIndex = 13;
            this.cmbBulan.Text = "- Bulan -";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.rbReparasi);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.rbBeliKomponen);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.rbRestockKomponen);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.rbRestockAlat);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.bunifuTransition.SetDecoration(this.flowLayoutPanel1, BunifuAnimatorNS.DecorationType.None);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(7, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(615, 33);
            this.flowLayoutPanel1.TabIndex = 12;
            // 
            // label1
            // 
            this.bunifuTransition.SetDecoration(this.label1, BunifuAnimatorNS.DecorationType.None);
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Laporan :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbReparasi
            // 
            this.rbReparasi.Checked = true;
            this.bunifuTransition.SetDecoration(this.rbReparasi, BunifuAnimatorNS.DecorationType.None);
            this.rbReparasi.Location = new System.Drawing.Point(79, 3);
            this.rbReparasi.Name = "rbReparasi";
            this.rbReparasi.Size = new System.Drawing.Size(18, 27);
            this.rbReparasi.TabIndex = 13;
            this.rbReparasi.TabStop = true;
            this.rbReparasi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbReparasi.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.bunifuTransition.SetDecoration(this.label2, BunifuAnimatorNS.DecorationType.None);
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(103, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reparasi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbBeliKomponen
            // 
            this.bunifuTransition.SetDecoration(this.rbBeliKomponen, BunifuAnimatorNS.DecorationType.None);
            this.rbBeliKomponen.Location = new System.Drawing.Point(179, 3);
            this.rbBeliKomponen.Name = "rbBeliKomponen";
            this.rbBeliKomponen.Size = new System.Drawing.Size(18, 27);
            this.rbBeliKomponen.TabIndex = 14;
            this.rbBeliKomponen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbBeliKomponen.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.bunifuTransition.SetDecoration(this.label3, BunifuAnimatorNS.DecorationType.None);
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(203, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 30);
            this.label3.TabIndex = 9;
            this.label3.Text = "Beli Komponen";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rbRestockKomponen
            // 
            this.bunifuTransition.SetDecoration(this.rbRestockKomponen, BunifuAnimatorNS.DecorationType.None);
            this.rbRestockKomponen.Location = new System.Drawing.Point(321, 3);
            this.rbRestockKomponen.Name = "rbRestockKomponen";
            this.rbRestockKomponen.Size = new System.Drawing.Size(18, 27);
            this.rbRestockKomponen.TabIndex = 15;
            this.rbRestockKomponen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRestockKomponen.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.bunifuTransition.SetDecoration(this.label4, BunifuAnimatorNS.DecorationType.None);
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(345, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "Restock Komponen";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rbRestockAlat
            // 
            this.bunifuTransition.SetDecoration(this.rbRestockAlat, BunifuAnimatorNS.DecorationType.None);
            this.rbRestockAlat.Location = new System.Drawing.Point(489, 3);
            this.rbRestockAlat.Name = "rbRestockAlat";
            this.rbRestockAlat.Size = new System.Drawing.Size(18, 27);
            this.rbRestockAlat.TabIndex = 16;
            this.rbRestockAlat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbRestockAlat.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.bunifuTransition.SetDecoration(this.label5, BunifuAnimatorNS.DecorationType.None);
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(513, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 30);
            this.label5.TabIndex = 11;
            this.label5.Text = "Restock Alat";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reportRestock
            // 
            this.bunifuTransition.SetDecoration(this.reportRestock, BunifuAnimatorNS.DecorationType.None);
            reportDataSource2.Name = "Restock";
            reportDataSource2.Value = this.lrestock1BindingSource;
            this.reportRestock.LocalReport.DataSources.Add(reportDataSource2);
            this.reportRestock.LocalReport.ReportEmbeddedResource = "CRUD.Report.ReportRestock1.rdlc";
            this.reportRestock.Location = new System.Drawing.Point(0, 57);
            this.reportRestock.Name = "reportRestock";
            this.reportRestock.ServerReport.BearerToken = null;
            this.reportRestock.Size = new System.Drawing.Size(1203, 617);
            this.reportRestock.TabIndex = 0;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuTransition.SetDecoration(this.bunifuMaterialTextbox1, BunifuAnimatorNS.DecorationType.None);
            this.bunifuMaterialTextbox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(245)))), ((int)(((byte)(224)))));
            this.bunifuMaterialTextbox1.LineThickness = 3;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(0, 0);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(1203, 41);
            this.bunifuMaterialTextbox1.TabIndex = 2;
            this.bunifuMaterialTextbox1.TabStop = false;
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1364, 765);
            this.panel1.TabIndex = 10;
            // 
            // reportViewer2
            // 
            this.bunifuTransition.SetDecoration(this.reportViewer2, BunifuAnimatorNS.DecorationType.None);
            reportDataSource3.Name = "Restock";
            reportDataSource3.Value = null;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "CRUD.ReportRestock1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(0, 62);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(1203, 632);
            this.reportViewer2.TabIndex = 0;
            // 
            // lrestock1TableAdapter
            // 
            this.lrestock1TableAdapter.ClearBeforeFill = true;
            // 
            // lbelikomponenTableAdapter
            // 
            this.lbelikomponenTableAdapter.ClearBeforeFill = true;
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
            // Menu_Utama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 765);
            this.Controls.Add(this.panelUtama);
            this.Controls.Add(this.panelAtas);
            this.Controls.Add(this.panelKiri);
            this.Controls.Add(this.panel1);
            this.bunifuTransition.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Utama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Menu_Utama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Menu_Utama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lrestock1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lbelikomponenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnPanelKiri)).EndInit();
            this.panelKiri1.ResumeLayout(false);
            this.panelKiri.ResumeLayout(false);
            this.panelAtas.ResumeLayout(false);
            this.panelAtas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            this.panelUtama.ResumeLayout(false);
            this.panelReport.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnCari)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuFlatButton btnReparasi;
        private Bunifu.Framework.UI.BunifuFlatButton btnBeliKomponen;
        private Bunifu.Framework.UI.BunifuFlatButton btnBeliAlat;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition;
        private UCBaru.BKomponen bKomponen;
        public System.Windows.Forms.Panel panelReport;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private Microsoft.Reporting.WinForms.ReportViewer reportRestock;
        private System.Windows.Forms.BindingSource lrestock1BindingSource;
        private Report Report;
        private ReportTableAdapters.lrestock1TableAdapter lrestock1TableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rbReparasi;
        private System.Windows.Forms.RadioButton rbBeliKomponen;
        private System.Windows.Forms.RadioButton rbRestockKomponen;
        private System.Windows.Forms.RadioButton rbRestockAlat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuImageButton btnCari;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTahun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbBulan;
        private Microsoft.Reporting.WinForms.ReportViewer reportBeliKomponen;
        private System.Windows.Forms.BindingSource lbelikomponenBindingSource;
        private ReportTableAdapters.lbelikomponenTableAdapter lbelikomponenTableAdapter;
    }
}