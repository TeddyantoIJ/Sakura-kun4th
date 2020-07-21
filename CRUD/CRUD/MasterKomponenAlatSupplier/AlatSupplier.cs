using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class AlatSupplier : Form
    {
        public AlatSupplier()
        {
            InitializeComponent();
            addSourceAlat();
            addSourceSupplier();
        }
        private void addSourceAlat()
        {

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = Program.getConstring();

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_alat from msalatkerja", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            txtnama_alat.AutoCompleteCustomSource = collection;
            txtnama_alat.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnama_alat.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void addSourceSupplier()
        {

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = Program.getConstring();

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_supplier from mssupplier", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            txtnama_supplier.AutoCompleteCustomSource = collection;
            txtnama_supplier.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnama_supplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        
        bool benar;
        private void txtnama_supplier_KeyUp(object sender, KeyEventArgs e)
        {
            benar = true;
            
            try
            {
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariSupplier", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtnama_supplier.Text;

                myCommand.Parameters.AddWithValue("id_supplier", pencarian);
                myCommand.Parameters.AddWithValue("nama_supplier", pencarian);
                myCommand.Parameters.AddWithValue("contact_person", pencarian);
                myCommand.Parameters.AddWithValue("no_telepon", pencarian);
                myCommand.Parameters.AddWithValue("alamat", pencarian);
                myCommand.Parameters.AddWithValue("keterangan", pencarian);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                txtid_supplier.Text = "";
                txtid_supplier.Text = data.Rows[0][0].ToString();
                infonama_supplier.ForeColor = System.Drawing.Color.Green;
                infonama_supplier.Text = "Sesuai!";
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
                //btnUpdate.Enabled = false;
                //clear();
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                if(txtnama_supplier.Text == "")
                {
                    infonama_supplier.Text = "Wajib diisi!";
                }
                else
                {
                    infonama_supplier.Text = "Data tidak ditemukan!";
                }
            }
            if (txtnama_supplier.Text == "")
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                infonama_supplier.Text = "Wajib diisi!";
                benar = false;
            }
            else if (txtid_supplier.Text == "")
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                infonama_supplier.Text = "Data tidak ditemukan!";
                benar = false;
            }
            else
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Green;
                infonama_supplier.Text = "Sesuai";
            }
            if (txtnama_alat.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Wajib diisi!";
                benar = false;
            }
            else if (txtid_alat.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Data tidak ditemukan!";
                benar = false;
            }
            else
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Green;
                infonamakomponen.Text = "Sesuai";
            }
            if (txtharga.Text == "")
            {
                benar = false;
                info_harga.ForeColor = System.Drawing.Color.Red;
                info_harga.Text = "Wajib diisi!";
            }
            else
            {
                info_harga.ForeColor = System.Drawing.Color.Green;
                info_harga.Text = "Sesuai";
            }

            if (txtid_supplier.Text == "" && txtnama_supplier.Text != "")
            {
                btnBaruSupplier.Enabled = true;
            }
            else
            {
                btnBaruSupplier.Enabled = false;
            }

            if (benar)
            {
                btnSimpan.Enabled = true;
            }
            else
            {
                btnSimpan.Enabled = false;
            }
        }

        private void txtnama_alat_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatKerja", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtnama_alat.Text;

                myCommand.Parameters.AddWithValue("id_alat", pencarian);
                myCommand.Parameters.AddWithValue("nama_alat", pencarian);
                myCommand.Parameters.AddWithValue("jumlah", 999);
                myCommand.Parameters.AddWithValue("bagus", 999);
                myCommand.Parameters.AddWithValue("rusak", 999);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                txtid_alat.Text = "";
                txtid_alat.Text = data.Rows[0][0].ToString();
                infonamakomponen.ForeColor = System.Drawing.Color.Green;
                infonamakomponen.Text = "Sesuai";
                btnBaruAlat.Enabled = false;
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                if(txtnama_alat.Text == "")
                {
                    btnBaruAlat.Enabled = false;
                    infonamakomponen.Text = "Wajib diisi!";
                }
                else
                {
                    btnBaruAlat.Enabled = true;
                    infonamakomponen.Text = "Data tidak ditemukan!";
                }
                
                //btnUpdate.Enabled = false;
                //clear();
            }
            if (txtnama_supplier.Text == "")
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                infonama_supplier.Text = "Wajib diisi!";
                benar = false;
            }
            else if (txtid_supplier.Text == "")
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                infonama_supplier.Text = "Data tidak ditemukan!";
                benar = false;
            }
            else
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Green;
                infonama_supplier.Text = "Sesuai";
            }
            if (txtnama_alat.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Wajib diisi!";
                benar = false;
            }
            else if (txtid_alat.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Data tidak ditemukan!";
                benar = false;
            }
            else
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Green;
                infonamakomponen.Text = "Sesuai";
            }
            if (txtharga.Text == "")
            {
                benar = false;
                info_harga.ForeColor = System.Drawing.Color.Red;
                info_harga.Text = "Wajib diisi!";
            }
            else
            {
                info_harga.ForeColor = System.Drawing.Color.Green;
                info_harga.Text = "Sesuai";
            }
            if (benar)
            {
                btnSimpan.Enabled = true;
            }
            else
            {
                btnSimpan.Enabled = false;
            }
        }

        private void txtharga_KeyUp(object sender, KeyEventArgs e)
        {
            benar = true;
            if (txtnama_supplier.Text == "")
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                infonama_supplier.Text = "Wajib diisi!";
                benar = false;
            }
            else if (txtid_supplier.Text == "")
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                infonama_supplier.Text = "Data tidak ditemukan!";
                benar = false;
            }
            else
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Green;
                infonama_supplier.Text = "Sesuai";
            }
            if (txtnama_alat.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Wajib diisi!";
                benar = false;
            }
            else if (txtid_alat.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Data tidak ditemukan!";
                benar = false;
            }
            else
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Green;
                infonamakomponen.Text = "Sesuai";
            }
            if (txtharga.Text == "")
            {
                benar = false;
                info_harga.ForeColor = System.Drawing.Color.Red;
                info_harga.Text = "Wajib diisi!";
            }
            else
            {
                info_harga.ForeColor = System.Drawing.Color.Green;
                info_harga.Text = "Sesuai";
            }
            if (benar)
            {
                btnSimpan.Enabled = true;
            }
            else
            {
                btnSimpan.Enabled = false;
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (benar && cekSamaIDAlat())
            {
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                    "Nama Alat\t: " + txtnama_alat.Text + "\n" +
                    "Nama Supplier\t: " + txtnama_supplier.Text + "\n" +
                    "Harga \t\t: Rp " + string.Format(CultureInfo.GetCultureInfo("de-DE"), "{0:n}", Int32.Parse(txtharga.Text))
                    , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    updateDB();
                }
                else
                {
                    MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private bool cekSamaIDAlat()
        {
            try
            {
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);

                //membuat table dengan jumlah data saja
                //SqlDataAdapter adapter = new SqlDataAdapter("select nama_alat from msalatsupplier", connection);
                SqlCommand myCommand = new SqlCommand("sp_cariSamaAlatKerjaSupplier", connection);
                //memasukkan ke dataset

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string id_alat = txtid_alat.Text;
                string id_supplier = txtid_supplier.Text;

                myCommand.Parameters.AddWithValue("id_alat", id_alat);
                myCommand.Parameters.AddWithValue("id_supplier", id_supplier);
                //MessageBox.Show(id_alat.ToString() + id_supplier.ToString());

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataSet data = new DataSet();

                connection.Close();
                adapter.Fill(data);

                string n = data.Tables[0].Rows[0][0].ToString();

                MessageBox.Show("Data sudah ada!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
          
            }
            catch(Exception )
            {
                return true;
            }


        }
        private void updateDB()
        {
            try
            {

                string connectionString = Program.getConstring();

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_inputAlatSupplier", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string id_komponen = txtid_alat.Text;
                string id_supplier = txtid_supplier.Text;
                string harga = txtharga.Text;
                string total_transaksi = "0";

                SqlParameter param = new SqlParameter();

                myCommand.Parameters.AddWithValue("id_alat", id_komponen);
                myCommand.Parameters.AddWithValue("id_supplier", id_supplier);
                myCommand.Parameters.AddWithValue("harga", toAngka(harga));
                myCommand.Parameters.AddWithValue("total_transaksi", total_transaksi);


                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtnama_alat.Text = "";
                txtid_alat.Text = "";
                txtnama_supplier.Text = "";
                txtid_supplier.Text = "";
                txtharga.Text = "";
                infonamakomponen.Text = "";
                infonama_supplier.Text = "";
                info_harga.Text = "";
                benar = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public int toAngka(string rupiah)
        {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (benar)
            {
                txtnama_alat.Text = "";
                txtid_alat.Text = "";
                txtnama_supplier.Text = "";
                txtid_supplier.Text = "";
                txtharga.Text = "";
                infonamakomponen.Text = "";
                infonama_supplier.Text = "";
                info_harga.Text = "";
                benar = false;
            }
            else
            {
                Close();
            }
        }

        private void txtharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBaruSupplier_Click(object sender, EventArgs e)
        {
 //           GenericIdentity myIdentity = new GenericIdentity(txtnama_supplier.Text);
//            string[] myRole = new string[10];

//            GenericPrincipal mynewSupplier = new GenericPrincipal(myIdentity, myRole);

            //Thread.CurrentPrincipal = mynewSupplier;

            SupplierMaster supplier = new SupplierMaster(txtnama_supplier.Text);

            supplier.ShowDialog(this);
        }

        private void btnBaruKomponen_Click(object sender, EventArgs e)
        {
    //        GenericIdentity myIdentity = new GenericIdentity(txtnama_alat.Text);
  //          string[] myRole = new string[10];

//            GenericPrincipal mynewAlat = new GenericPrincipal(myIdentity, myRole);

            //Thread.CurrentPrincipal = mynewAlat

            AlatKerjaMaster alatKerja = new AlatKerjaMaster(txtnama_alat.Text);

            alatKerja.ShowDialog(this);
        }

        private void AlatSupplier_Activated(object sender, EventArgs e)
        {
            try
            {
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatKerja", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtnama_alat.Text;

                myCommand.Parameters.AddWithValue("id_alat", pencarian);
                myCommand.Parameters.AddWithValue("nama_alat", pencarian);
                myCommand.Parameters.AddWithValue("jumlah", 999);
                myCommand.Parameters.AddWithValue("bagus", 999);
                myCommand.Parameters.AddWithValue("rusak", 999);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                txtid_alat.Text = "";
                txtid_alat.Text = data.Rows[0][0].ToString();
                infonamakomponen.ForeColor = System.Drawing.Color.Green;
                infonamakomponen.Text = "Sesuai";

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception )
            {
                //MessageBox.Show(ex.ToString());
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                if (txtnama_alat.Text == "")
                {
                    btnBaruAlat.Enabled = false;
                    infonamakomponen.Text = "Wajib diisi!";
                }
                else
                {
                    btnBaruAlat.Enabled = true;
                    infonamakomponen.Text = "Data tidak ditemukan!";
                }

                //btnUpdate.Enabled = false;
                //clear();
            }
            try
            {
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariSupplier", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtnama_supplier.Text;

                myCommand.Parameters.AddWithValue("id_supplier", pencarian);
                myCommand.Parameters.AddWithValue("nama_supplier", pencarian);
                myCommand.Parameters.AddWithValue("contact_person", pencarian);
                myCommand.Parameters.AddWithValue("no_telepon", pencarian);
                myCommand.Parameters.AddWithValue("alamat", pencarian);
                myCommand.Parameters.AddWithValue("keterangan", pencarian);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                txtid_supplier.Text = "";
                txtid_supplier.Text = data.Rows[0][0].ToString();
                infonama_supplier.ForeColor = System.Drawing.Color.Green;
                infonama_supplier.Text = "Sesuai!";
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception )
            {
                //MessageBox.Show(ex.ToString());
                //btnUpdate.Enabled = false;
                //clear();
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                if (txtnama_supplier.Text == "")
                {
                    infonama_supplier.Text = "Wajib diisi!";
                }
                else
                {
                    infonama_supplier.Text = "Data tidak ditemukan!";
                }
            }

        }
    }
    
}
