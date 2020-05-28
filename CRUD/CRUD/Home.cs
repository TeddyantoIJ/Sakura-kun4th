﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            //FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
            
        }

        private void Home_Resize(object sender, EventArgs e)
        {
            

        }
        bool menuAktif = false;
        private void btnPop_Click(object sender, EventArgs e)
        {
            enterMenu();
            if (menuAktif)
            {
                menuAktif = false;
                
                panelMenu.Size = new System.Drawing.Size(161, 704);
                btnPop.Location = new Point(127, 11);
            }
            else
            {
                menuAktif = true;
                clearPanelAll();
                panelMenu.Size = new System.Drawing.Size(39, 704);
                btnPop.Location = new Point(5, 11);
            }
        }
        private void enterMenu()
        {
            if (menuAktif)
            {
                menu1.Visible = true;
                menu2.Visible = true;
                menu3.Visible = true;
                menu4.Visible = true;
                menu5.Visible = true;
            }
            else
            {
                menu1.Visible = false;
                menu2.Visible = false;
                menu3.Visible = false;
                menu4.Visible = false;
                menu5.Visible = false;
            }
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            if(panelKelolaData.Visible == true)
            {
                clearPanel1();
                clearPanel2();
                clearPanel3();
            }
            else
            {
                panelKelolaData.Visible = true;
            }
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            if(panelSupplier.Visible == true)
            {
                panelSupplier.Visible = false;
                panelDataSupplier.Visible = false;
                panelKomponenSupplier.Visible = false;
                panelAlatSupplier.Visible = false;
            }
            else
            {
                clearPanel2();
                panelSupplier.Visible = true;
            }
        }
        private void clearPanel1()
        {
            panelKelolaData.Visible = false;
            clearPanel2();
        }
        private void clearPanel2()
        {
            clearPanel3();
            panelPenyimpanan.Visible = false;
            panelSupplier.Visible = false;
            panelCustomer.Visible = false;
            panelKaryawan.Visible = false;
            panelAlatKerja.Visible = false;
            panelAlatElektronik.Visible = false;
        }
        private void clearPanel3()
        {
            panelJenisElektronik.Visible = false;
            panelNamaAlatElektronik.Visible = false;
            panelAlatSupplier.Visible = false;
            panelKomponenSupplier.Visible = false;
            panelDataSupplier.Visible = false;
        }
        private void btnDataSupplier_Click(object sender, EventArgs e)
        {
            if(panelDataSupplier.Visible == true)
            {
                panelDataSupplier.Visible = false;
            }
            else
            {
                clearPanel3();
                panelDataSupplier.Visible = true;
            }
        }

        private void btnKomponenSupplier_Click(object sender, EventArgs e)
        {
            if(panelKomponenSupplier.Visible == true)
            {
                panelKomponenSupplier.Visible = false;
            }
            else
            {
                clearPanel3();
                panelKomponenSupplier.Visible = true;
            }
        }

        private void btnAlatSupplier_Click(object sender, EventArgs e)
        {
            if(panelAlatSupplier.Visible == true)
            {
                panelAlatSupplier.Visible = false;
            }
            else
            {
                clearPanel3();
                panelAlatSupplier.Visible = true;
            }
        }
        private void clearPanelAll()
        {
            clearPanel1();
            clearPanel2();
            clearPanel3();
        }

        private void btnTambahSupplier_Click(object sender, EventArgs e)
        {
            clearPanelAll();
            SupplierMaster supplierMaster = new SupplierMaster();
            supplierMaster.ShowDialog(this);
        }

        private void btnTambahKomponenSupplier_Click(object sender, EventArgs e)
        {
            clearPanelAll();
            KomponenSupplier komponenSupplier = new KomponenSupplier();
            komponenSupplier.ShowDialog(this);
        }

        private void btnTambahAlatSupplier_Click(object sender, EventArgs e)
        {
            clearPanelAll();
            AlatSupplier alatSupplier = new AlatSupplier();
            alatSupplier.ShowDialog(this);
        }

        private void btnPerbaruiAlatSupplier_Click(object sender, EventArgs e)
        {
            clearPanelAll();
            UpdateAlatKomponenSupplier komponenSupplier = new UpdateAlatKomponenSupplier();
            komponenSupplier.Show(this);
        }

        private void btnPerbaruiKomponenSupplier_Click(object sender, EventArgs e)
        {
            clearPanelAll();
            UpdateAlatKomponenSupplier komponenSupplier = new UpdateAlatKomponenSupplier();
            komponenSupplier.Show(this);
        }

        private void btnEditSupplier_Click(object sender, EventArgs e)
        {
            clearPanelAll();
            UpdateSupplier updateSupplier = new UpdateSupplier();
            updateSupplier.ShowDialog(this);
        }

        private void btnTambahCustomer_Click(object sender, EventArgs e)
        {
            clearPanelAll();
            CustomerMaster customerMaster = new CustomerMaster();
            customerMaster.ShowDialog(this);
        }

        private void btnPerbaruiCustomer_Click(object sender, EventArgs e)
        {
            clearPanelAll();
            UpdateCustomer updateCustomer = new UpdateCustomer();
            updateCustomer.ShowDialog(this);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            if(panelCustomer.Visible == true)
            {
                panelCustomer.Visible = false;
            }
            else
            {
                clearPanel2();
                panelCustomer.Visible = true;
            }
        }

        private void btnPenyimpanan_Click(object sender, EventArgs e)
        {
            if(panelPenyimpanan.Visible == true)
            {
                panelPenyimpanan.Visible = false;
            }
            else
            {
                clearPanel2();
                panelPenyimpanan.Visible = true;
            }
        }

        private void btnKaryawan_Click(object sender, EventArgs e)
        {
            if(panelKaryawan.Visible == true)
            {
                panelKaryawan.Visible = false;
            }
            else
            {
                clearPanel2();
                panelKaryawan.Visible = true;
            }
        }

        private void btnAlatKerja_Click(object sender, EventArgs e)
        {
            if(panelAlatKerja.Visible == true)
            {
                panelAlatKerja.Visible = false;
            }
            else
            {
                clearPanel2();
                panelAlatKerja.Visible = true;
            }
        }

        private void btnTambahAlatKerja_Click(object sender, EventArgs e)
        {
            clearPanelAll();
            AlatKerjaMaster alatKerjaMaster = new AlatKerjaMaster();
            alatKerjaMaster.ShowDialog(this);
        }

        private void btnPerbaruiAlatKerja_Click(object sender, EventArgs e)
        {
            clearPanelAll();
            UpdateAlatKerja updateAlatKerja = new UpdateAlatKerja();
            updateAlatKerja.ShowDialog(this);
        }

        private void btnAlatElektronik_Click(object sender, EventArgs e)
        {
            if(panelAlatElektronik.Visible == true)
            {
                panelAlatElektronik.Visible = false;
            }
            else
            {
                clearPanel2();
                panelAlatElektronik.Visible = true;
            }
        }

        private void btnNamaAlatElektronik_Click(object sender, EventArgs e)
        {
            if(panelNamaAlatElektronik.Visible == true)
            {
                panelNamaAlatElektronik.Visible = false;
            }
            else
            {
                clearPanel3();
                panelNamaAlatElektronik.Visible = true;
            }
        }

        private void btnJenisAlatElektronik_Click(object sender, EventArgs e)
        {
            if(panelJenisElektronik.Visible == true)
            {
                panelJenisElektronik.Visible = false;
            }
            else
            {
                clearPanel3();
                panelJenisElektronik.Visible = true;
            }
        }

        private void btnTambahAlatElektronik_Click(object sender, EventArgs e)
        {
            
        }

        private void menu5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Terimakasih telah menggunakan aplikasi kami\nHormat kami\nFiorenta Jihad Wibowo dan Teddyanto Idrus J", "Terima Kasih", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Environment.Exit(1);
        }
    }
}
