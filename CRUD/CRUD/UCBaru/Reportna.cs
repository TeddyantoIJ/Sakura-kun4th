using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Reportna : UserControl
    {
        public Reportna()
        {
            InitializeComponent();
        }

        private void btnPenjualanKomponen_Click(object sender, EventArgs e)
        {
            go(laporanPenjualanKomponen, btnPenjualanKomponen);
        }
        private void go(UserControl a, Bunifu.Framework.UI.BunifuTileButton b)
        {
            btnPemasokkanAlat.Enabled = true;
            btnPemasokkanKomponen.Enabled = true;
            btnPenjualanKomponen.Enabled = true;
            btnTransaksiPerbaikan.Enabled = true;

            b.Enabled = false;

            laporanPenjualanKomponen.Visible = false;
            laporanReparasiAlatElektronik.Visible = false;
            laporanRestockAlatKerja.Visible = false;
            laporanRestockKomponen.Visible = false;

            a.Visible = true;
        }

        private void btnTransaksiPerbaikan_Click(object sender, EventArgs e)
        {
            go(laporanReparasiAlatElektronik, btnTransaksiPerbaikan);
        }

        private void btnPemasokkanKomponen_Click(object sender, EventArgs e)
        {
            go(laporanRestockKomponen, btnPemasokkanKomponen);
        }

        private void btnPemasokkanAlat_Click(object sender, EventArgs e)
        {
            go(laporanRestockAlatKerja, btnPemasokkanAlat);
        }
    }
}
