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
    public partial class CreateOrUpdate : UserControl
    {
        public string kelola;
        public CreateOrUpdate()
        {
            InitializeComponent();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            this.SendToBack();
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            switch (kelola)
            {
                case "Pelanggan":
                    {
                        CustomerMaster c = new CustomerMaster();
                        c.ShowDialog(this);
                        break;
                    }
                case "Pemasok":
                    {
                        SupplierMaster s = new SupplierMaster();
                        s.ShowDialog(this);
                        break;
                    }
                case "Pelayan":
                    {
                        TambahPekerja t = new TambahPekerja();
                        t.ShowDialog(this);
                        break;
                    }
                case "Pereparasi":
                    {
                        TambahPekerja t = new TambahPekerja();
                        t.ShowDialog(this);
                        break;
                    }
                case "Komponen":
                    {
                        Komponen k = new Komponen();
                        k.ShowDialog(this);
                        break;
                    }
                case "Alat Kerja":
                    {
                        AlatKerjaMaster a = new AlatKerjaMaster();
                        a.ShowDialog(this);
                        break;
                    }
                case "Pemasok Alat":
                    {
                        AlatSupplier a = new AlatSupplier();
                        a.ShowDialog(this);
                        break;
                    }
                case "Pemasok Komponen":
                    {
                        KomponenSupplier k = new KomponenSupplier();
                        k.ShowDialog(this);
                        break;
                    }
                case "Alat Elektronik":
                    {
                        AlatElektronik a = new AlatElektronik();
                        a.ShowDialog(this);
                        break;
                    }
                case "Jenis Alat":
                    {
                        JenisAlatElektronik j = new JenisAlatElektronik();
                        j.ShowDialog(this);
                        break;
                    }
            }
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            switch (kelola)
            {
                case "Pelanggan":
                    {
                        UpdateCustomer c = new UpdateCustomer();
                        c.ShowDialog(this);
                        break;
                    }
                case "Pemasok":
                    {
                        UpdateSupplier u = new UpdateSupplier();
                        u.ShowDialog(this);
                        break;
                    }
                case "Pelayan":
                    {
                        UpdatePekerja u  = new UpdatePekerja();
                        u.ShowDialog(this);
                        break;
                    }
                case "Pereparasi":
                    {
                        UpdatePekerja u = new UpdatePekerja();
                        u.ShowDialog(this);
                        break;
                    }
                case "Komponen":
                    {
                        UpdateKomponen k = new UpdateKomponen();
                        k.ShowDialog(this);
                        break;
                    }
                case "Alat Kerja":
                    {
                        UpdateAlatKerja a = new UpdateAlatKerja();
                        a.ShowDialog(this);
                        break;
                    }
                case "Pemasok Alat":
                    {
                        UpdateAlatKomponenSupplier a = new UpdateAlatKomponenSupplier();
                        a.ShowDialog(this);
                        break;
                    }
                case "Pemasok Komponen":
                    {
                        UpdateAlatKomponenSupplier a = new UpdateAlatKomponenSupplier();
                        a.ShowDialog(this);
                        break;
                    }
                case "Alat Elektronik":
                    {
                        UpdateAlatElektronik a = new UpdateAlatElektronik();
                        a.ShowDialog(this);
                        break;
                    }
                case "Jenis Alat":
                    {
                        UpdateJenisElektronik j = new UpdateJenisElektronik();
                        j.ShowDialog(this);
                        break;
                    }
            }
        }
    }
}
