using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Principal;
using System.Threading;

namespace CRUD
{
    public partial class ReparasiAlatElektronik : UserControl
    {
        Boolean cek = false;
        string idAlat = null, idGudang = null;
        private int selectedDaftarReparasi = 0;
        private string id_transaksi = "";

        public ReparasiAlatElektronik()
        {
            InitializeComponent();
            addSourceAlat();
            addSourceReparasi();
            addSourcePelayan();
            addSourcePelanggan();
        }

        private void addSourcePelayan()
        {
            txtPelayan.AutoCompleteCustomSource = null;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_pelayan from msbagianpelayan", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            txtPelayan.AutoCompleteCustomSource = collection;
            txtPelayan.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPelayan.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void addSourcePelanggan()
        {
            txtPelanggan.AutoCompleteCustomSource = null;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_customer from mscustomer", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            txtPelanggan.AutoCompleteCustomSource = collection;
            txtPelanggan.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPelanggan.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void addSourceAlat()
        {
            txtAlat.AutoCompleteCustomSource = null;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
            SqlConnection connection = new SqlConnection(connectionString);
            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_alat from msalatelektronik", connection);
            //memasukkan ke dataset
            DataSet msalat = new DataSet();
            adapter.Fill(msalat);

            for (int i = 0; i < msalat.Tables[0].Rows.Count; i++)
            {

                collection.Add(msalat.Tables[0].Rows[i][0].ToString());
            }
            txtAlat.AutoCompleteCustomSource = collection;
            txtAlat.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtAlat.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void addSourceReparasi()
        {
            txtBagianReparasi.AutoCompleteCustomSource = null;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_gudang from msbagiangudang", connection);
            //memasukkan ke dataset
            DataSet msgudang = new DataSet();
            adapter.Fill(msgudang);

            for (int i = 0; i < msgudang.Tables[0].Rows.Count; i++)
            {

                collection.Add(msgudang.Tables[0].Rows[i][0].ToString());
            }
            txtBagianReparasi.AutoCompleteCustomSource = collection;
            txtBagianReparasi.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtBagianReparasi.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void clear()
        {
            txtAlat.Text = "";
            txtBagianReparasi.Text = "";
            txtBiaya.Text = "";
            cek = false;
        }

        private void clearAll()
        {
            clear();
            txtPelanggan.Text = "";
            txtPelayan.Text = "";
            lblTotal.Text = "0";
            cek = false;
        }
        private void txtAlat_TextChanged(object sender, EventArgs e)
        {
            if (txtAlat.Text == "")
            {
                cek = false;
            }
            else
            {
                cek = true;
            }
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatElektronik", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtAlat.Text;

                myCommand.Parameters.AddWithValue("id_alat", pencarian);
                myCommand.Parameters.AddWithValue("nama_alat", pencarian);
                myCommand.Parameters.AddWithValue("id_jenis", pencarian);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                idAlat = "";
                idAlat = data.Rows[0][0].ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                cek = false;
            }
        }

        private void btnBaru1_Click(object sender, EventArgs e)
        {
            AlatElektronik alat = new AlatElektronik();

            alat.ShowDialog(this);
        }

        private void btnBaru2_Click(object sender, EventArgs e)
        {
            TambahPekerja pekerja = new TambahPekerja();
            pekerja.ShowDialog(this);
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            string checker = null;

            if (txtAlat.Text == "")
            {
                checker += "Kolom Nama Alat Harus Diisi!\n";
                cek = false;
            }
            else
            {
                cek = true;
            }

            if (txtBagianReparasi.Text == "")
            {
                checker += "Kolom Nama Bagian Reparasi Harus Diisi!\n";
                cek = false;
            }
            else
            {
                cek = true;
            }

            if (txtBiaya.Text == "")
            {
                checker += "Kolom Biaya Reparasi Harus Diisi!\n";
                cek = false;
            }
            else
            {
                cek = true;
            }

            if (cek)
            {
                insertDataTransaksi();
                clear();
            }
            else
            {
                MessageBox.Show(checker + "Periksa Kembali Data!\nData Ada Yang Tidak Valid/Kosong", 
                    "Data Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void insertDataTransaksi()
        {
            int no = Convert.ToInt32(tbDaftarReparasi.Rows.Count.ToString());
            String namaAlat = txtAlat.Text;
            String namaBagianReparasi = txtBagianReparasi.Text;
            String biaya = txtBiaya.Text;

            lblTotal.Text = (Convert.ToInt32(biaya) + Convert.ToInt32(lblTotal.Text)).ToString();

            //MessageBox.Show(no + komponen + barang + harga + total + jumlah);
            tbDaftarReparasi.Rows.Add(no + 1, namaAlat, namaBagianReparasi, biaya);

            foreach (DataGridViewColumn col in tbDaftarReparasi.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.tbDaftarReparasi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbDaftarReparasi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbDaftarReparasi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbDaftarReparasi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.tbDaftarReparasi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void tbDaftarReparasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = tbDaftarReparasi.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRow > 0 && selectedRow <= 1)
            {
                for (int i = 0; i < selectedRow; i++)
                {
                    selectedDaftarReparasi = Int32.Parse(tbDaftarReparasi.SelectedRows[i].Index.ToString());
                }
                btnBatal.Enabled = true;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbDaftarReparasi.Rows.Clear();
            hitungTotal();
            btnBatal.Enabled = false;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DataGridViewRow del = tbDaftarReparasi.Rows[selectedDaftarReparasi];
            tbDaftarReparasi.Rows.Remove(del);

            perapihan();
            hitungTotal();
            if (tbDaftarReparasi.Rows.Count == 0)
            {
                btnBatal.Enabled = false;
            }
        }

        private void hitungTotal()
        {
            int total = 0;
            for (int i = 0; i < tbDaftarReparasi.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(tbDaftarReparasi[3, i].Value);
            }
            lblTotal.Text = total.ToString();
        }

        private void perapihan()
        {
            int i = 1;

            foreach (DataGridViewRow row in tbDaftarReparasi.Rows)
            {
                tbDaftarReparasi[0, i - 1].Value = i.ToString();
                i++;
            }
        }

        private void btnTambahPelayan_Click(object sender, EventArgs e)
        {
            TambahPekerja pelayan = new TambahPekerja();
            pelayan.ShowDialog(this);
            addSourcePelayan();
        }

        private void btnTambahPelanggan_Click(object sender, EventArgs e)
        {
            CustomerMaster pelanggan = new CustomerMaster();
            pelanggan.ShowDialog(this);
            addSourcePelanggan();
        }

        private string getLastID()
        {
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("select count (no_transaksi_reparasi) from treparasialat", connection);
            
            DataSet msreparasi = new DataSet();
            adapter.Fill(msreparasi);

            //mengambil data jumlah
            int count = (int)msreparasi.Tables[0].Rows[0][0];
            count++;
            if (count.ToString().Length == 1)
            {
                return "000" + count;
            }
            else if (count.ToString().Length == 2)
            {
                return "00" + count;
            }
            else if (count.ToString().Length == 3)
            {
                return "0" + count;
            }
            else
            {
                return count.ToString();
            }
        }

        private string getIDPelanggan(string nama_pelanggan)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariCustomer", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_customer", "XX");
                myCommand.Parameters.AddWithValue("nama_customer", nama_pelanggan);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                return output;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private string getIDAlat(string nama_alat)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatElektronik", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_alat", "XX");
                myCommand.Parameters.AddWithValue("nama_alat", nama_alat);
                myCommand.Parameters.AddWithValue("id_jenis", "x");

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                return output;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private string getIDReparasi(string nama_bagianReparasi)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariGudang", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_gudang", "XX");
                myCommand.Parameters.AddWithValue("nama_gudang", nama_bagianReparasi);
                myCommand.Parameters.AddWithValue("jenis_kelamin", "x");
                myCommand.Parameters.AddWithValue("alamat", "x");
                myCommand.Parameters.AddWithValue("email", "x");
                myCommand.Parameters.AddWithValue("no_telepon", "x");
                myCommand.Parameters.AddWithValue("status", "x");

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                return output;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private string getIDPelayan(string nama_pelayan)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariPelayan", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_pelayan", "XX");
                myCommand.Parameters.AddWithValue("nama_pelayan", nama_pelayan);
                myCommand.Parameters.AddWithValue("jenis_kelamin", "x");
                myCommand.Parameters.AddWithValue("alamat", "x");
                myCommand.Parameters.AddWithValue("email", "x");
                myCommand.Parameters.AddWithValue("no_telepon", "x");
                myCommand.Parameters.AddWithValue("status", "x");

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                connection.Close();
                return output;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void btnLanjutkan_Click(object sender, EventArgs e)
        {
            if (lblTotal.Text.Equals("0"))
            {
                return;
            }

            string checker = null;

            if (txtPelayan.Text == "")
            {
                checker += "Kolom Pelayan Harap Diisi!\n";
                cek = false;
            }
            else
            {
                cek = true;
            }

            if (txtPelanggan.Text == "")
            {
                checker += "Kolom Pelanggan Harap Diisi!\n";
                cek = false;
            }
            else
            {
                cek = true;
            }

            if (cek)
            {
                Pembayaran pembayaran = new Pembayaran();
                pembayaran.txtTagihan.Text = lblTotal.Text;
                pembayaran.ShowDialog(this);

                if (pembayaran.berhasil)
                {
                    MessageBox.Show("Transaksi berhasil!\n" +
                                    "Tagihan      : Rp " + lblTotal.Text + "\n" +
                                    "Uang dibayar : Rp " + pembayaran.txtUang.Text + "\n" +
                                    "Kembalian    : Rp " + pembayaran.kembalian, "Informasi", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                }
                else
                {
                    return;
                }

                try
                {
                    string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand myCommand = new SqlCommand("sp_inputTransaksiReparasiAlat", connection);

                    myCommand.CommandType = CommandType.StoredProcedure;

                    connection.Open();
                    
                    id_transaksi = "TBA-" + getLastID();
                    myCommand.Parameters.AddWithValue("no_transaksi_reparasi", id_transaksi);
                    myCommand.Parameters.AddWithValue("id_pelayan", getIDPelayan(txtPelayan.Text));
                    myCommand.Parameters.AddWithValue("id_customer", getIDPelanggan(txtPelanggan.Text));
                    myCommand.Parameters.AddWithValue("tanggal_reparasi", DateTime.Now.ToString("yyyy-MM-dd"));
                    myCommand.Parameters.AddWithValue("total", lblTotal.Text);

                    myCommand.ExecuteNonQuery();
                    connection.Close();

                    detailtransaksi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error btnBayar_Click : " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show(checker + "Periksa Kembali Data!\nData Ada Yang Tidak Valid/Kosong",
                    "Data Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void detailtransaksi()
        {
            for (int i = 0; i < tbDaftarReparasi.Rows.Count; i++)
            {
                try
                {
                    string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand myCommand = new SqlCommand("sp_inputTDetailReparasi", connection);

                    myCommand.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    myCommand.Parameters.AddWithValue("no_transaksi_reparasi", id_transaksi);
                    myCommand.Parameters.AddWithValue("id_alat", getIDAlat(tbDaftarReparasi[1, i].Value.ToString()));
                    myCommand.Parameters.AddWithValue("id_gudang", getIDReparasi(tbDaftarReparasi[2, i].Value.ToString()));
                    myCommand.Parameters.AddWithValue("harga", tbDaftarReparasi[3, i].Value);

                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error detail transaksi : " + ex.ToString());
                    return;
                }
            }
            MessageBox.Show("Berhasil memproses transaksi..");
            tbDaftarReparasi.Rows.Clear();

            clearAll();
        }

        private void txtBagianReparasi_TextChanged(object sender, EventArgs e)
        {
            if (txtBagianReparasi.Text == "")
            {
                cek = false;
            }
            else
            {
                cek = true;
            }
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariGudang", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtBagianReparasi.Text;

                myCommand.Parameters.AddWithValue("id_gudang", pencarian);
                myCommand.Parameters.AddWithValue("nama_gudang", pencarian);
                myCommand.Parameters.AddWithValue("jenis_kelamin", pencarian);
                myCommand.Parameters.AddWithValue("alamat", pencarian);
                myCommand.Parameters.AddWithValue("email", pencarian);
                myCommand.Parameters.AddWithValue("no_telepon", pencarian);
                myCommand.Parameters.AddWithValue("status", pencarian);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                idGudang = "";
                idGudang = data.Rows[0][0].ToString();
                connection.Close();
            }
            catch (Exception ex)
            {
                cek = false;
            }
        }
    }
}
