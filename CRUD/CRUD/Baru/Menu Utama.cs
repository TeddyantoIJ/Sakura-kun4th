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

        private void show(UserControl masuk, Bunifu.Framework.UI.BunifuFlatButton btn)
        {
            //frame
            dashBoard.Visible = false;
            pemasokan_v2.Visible = false;
            bKomponen.Visible = false;

            //masuk.Visible = true;
            bunifuTransition.ShowSync(masuk, false, BunifuAnimatorNS.Animation.VertSlide);
            
            
            //button
            btnMenuUtama.BackColor = panelKiri.BackColor;
            btnRestockKomponen.BackColor = panelKiri.BackColor;
            btnBeliKomponen.BackColor = panelKiri.BackColor;

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
        }

        private void btnKelolaData_Click(object sender, EventArgs e)
        {

        }

        private void btnLaporan_Click(object sender, EventArgs e)
        {

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
        }
    }
}
