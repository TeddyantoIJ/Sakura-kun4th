using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.Baru
{
    public partial class Menu_Utama : Form
    {
        private bool simple = false;
        public string karyawan_id = "";

        public Menu_Utama()
        {
            InitializeComponent();
            dashBoard.Visible = true;
            btnMenuUtama.Normalcolor = btnMenuUtama.Activecolor;
            WindowState = FormWindowState.Maximized;
            
        }
        public Menu_Utama(string nama, string id)
        {
            InitializeComponent();
            //Restock transaski
            pemasokan_v2.id_karyawan = id;

            karyawan_id = id;
            
            MessageBox.Show("Selamat datang " + nama);
            karyawan_nama.Text = nama;
            dashBoard.Visible = true;
            btnMenuUtama.Normalcolor = btnMenuUtama.Activecolor;
            WindowState = FormWindowState.Maximized;

        }
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            if (simple)
            {
                panelKiri1.Visible = true;
                simple = false;
                panelKiri.Size = new Size(161, 765);
            }
            else
            {
                panelKiri1.Visible = false;
                simple = true;
                panelKiri.Size = new Size(42, 765);
            }
            
        }

        private void clock_Tick(object sender, EventArgs e)
        {
            jam.Text = DateTime.Now.ToString("HH:mm:ss WIB");
            tanggal.Text = DateTime.Now.ToString("dddd dd-MMMM-yyyy");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            show(dashBoard,btnMenuUtama);
        }

        private void show(Panel masuk, Bunifu.Framework.UI.BunifuFlatButton btn)
        {
            //frame
            dashBoard.Visible = false;
            pemasokan_v2.Visible = false;
            bKomponen.Visible = false;
            panelReport.Visible = false;

            //masuk.Visible = true;
            bunifuTransition.ShowSync(masuk, false, BunifuAnimatorNS.Animation.VertSlide);
            
            
            //button
            btnMenuUtama.BackColor = panelKiri.BackColor;
            btnRestockKomponen.BackColor = panelKiri.BackColor;
            btnBeliKomponen.BackColor = panelKiri.BackColor;
            btnLaporan.BackColor = panelKiri.BackColor;

            btn.Normalcolor = btn.Activecolor;
        }
        private void show(UserControl masuk, Bunifu.Framework.UI.BunifuFlatButton btn)
        {
            //frame
            dashBoard.Visible = false;
            pemasokan_v2.Visible = false;
            bKomponen.Visible = false;
            panelReport.Visible = false;

            //masuk.Visible = true;
            bunifuTransition.ShowSync(masuk, false, BunifuAnimatorNS.Animation.VertSlide);


            //button
            btnMenuUtama.BackColor = panelKiri.BackColor;
            btnRestockKomponen.BackColor = panelKiri.BackColor;
            btnBeliKomponen.BackColor = panelKiri.BackColor;
            btnLaporan.BackColor = panelKiri.BackColor;

            btn.Normalcolor = btn.Activecolor;
        }

        private void panelKiri_MouseClick(object sender, MouseEventArgs e)
        {
            panelKiri1.Visible = true;
            simple = false;
            panelKiri.Size = new Size(161, 765);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(1);
        }

        private void btnTransaksi_Click(object sender, EventArgs e)
        {
            show(pemasokan_v2,btnRestockKomponen);
            pemasokan_v2.id_karyawan = this.karyawan_id;
        }

        private void btnKelolaData_Click(object sender, EventArgs e)
        {

        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {
            
            show(panelReport,btnLaporan);
        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void panelKiri1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_2(object sender, EventArgs e)
        {

        }

        private void btnBeliKomponen_Click(object sender, EventArgs e)
        {
            show(bKomponen, btnBeliKomponen);
            bKomponen.id_karyawan = this.karyawan_id;
        }

        private void Menu_Utama_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'Report.lbelikomponen' table. You can move, or remove it, as needed.
            //this.lbelikomponenTableAdapter.Fill(this.Report.lbelikomponen);
            // TODO: This line of code loads data into the 'Report.lbelikomponen' table. You can move, or remove it, as needed.
            //this.lbelikomponenTableAdapter.Fill(this.Report.lbelikomponen);
            // TODO: This line of code loads data into the 'Report.lrestock1' table. You can move, or remove it, as needed.



            this.reportRestockAlat.RefreshReport();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void showReport(ReportViewer a)
        {
            reportRestock.Visible = false;
            reportBeliKomponen.Visible = false;
            reportReparasi.Visible = false;
            reportRestockAlat.Visible = false;

            a.Visible = true;
        }
        private void btnCari_Click(object sender, EventArgs e)
        {
            if (rbReparasi.Checked)
            {
                showReport(reportReparasi);
                this.lreparasialatTableAdapter.Fill(this.Report.lreparasialat, cmbBulan.SelectedIndex + 1, Convert.ToInt32(cmbTahun.Text));
                this.reportReparasi.RefreshReport();
            }
            if (rbBeliKomponen.Checked)
            {
                showReport(reportBeliKomponen);
                // TODO: This line of code loads data into the 'Report.lbelikomponen' table. You can move, or remove it, as needed.
                this.lbelikomponenTableAdapter.Fill(this.Report.lbelikomponen, cmbBulan.SelectedIndex + 1, Convert.ToInt32(cmbTahun.Text));
                // TODO: This line of code loads data into the 'Report.lrestock1' table. You can move, or remove it, as needed.

                this.reportBeliKomponen.RefreshReport();
            }
            if (rbRestockKomponen.Checked)
            {
                showReport(reportRestock);
                this.lrestock1TableAdapter.Fill(this.Report.lrestock1, cmbBulan.SelectedIndex + 1, Convert.ToInt32(cmbTahun.Text));
                this.reportRestock.RefreshReport();
            }
            if (rbRestockAlat.Checked)
            {
                showReport(reportRestockAlat);
                this.lrestockalatTableAdapter.Fill(this.Report.lrestockalat, cmbBulan.SelectedIndex + 1, Convert.ToInt32(cmbTahun.Text));
                this.reportRestockAlat.RefreshReport();
            }
            
            

            
        }
    }
}
