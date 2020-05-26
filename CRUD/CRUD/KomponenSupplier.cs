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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class KomponenSupplier : Form
    {
        public KomponenSupplier()
        {
            InitializeComponent();

            //txtid_komponen.Text = "KSUP-" + getLastID();
            addSourceKomponen();
            addSourceSupplier();
        }

    

        private string getLastID()
        {
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select count (id_komponen) from mskomponensupplier", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            //mengambil data jumlah
            int count = (int)msdata.Tables[0].Rows[0][0];
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

        private void addSourceSupplier()
        {

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

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

        private void addSourceKomponen()
        {

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_komponen from mspenyimpananx", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            txtnama_komponen.AutoCompleteCustomSource = collection;
            txtnama_komponen.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnama_komponen.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            benar = true;
            if (txtnama_komponen.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Wajib diisi!";
                benar = false;
            }
            else if (txtid_komponen.Text == "")
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
            if (txtid_komponen.Text == "" && txtnama_komponen.Text != "")
            {
                btnBaruKomponen.Enabled = true;
            }
            else
            {
                btnBaruKomponen.Enabled = false;
            }
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariPenyimpananx", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtnama_komponen.Text;

                myCommand.Parameters.AddWithValue("nama_komponen", pencarian);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                txtid_komponen.Text = "";
                txtid_komponen.Text = data.Rows[0][0].ToString();
                
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                
                //btnUpdate.Enabled = false;
                //clear();
            }
        }

        private void txtnama_supplier_TextChanged(object sender, EventArgs e)
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
            if (txtid_supplier.Text == "" && txtnama_supplier.Text != "")
            {
                btnBaruSupplier.Enabled = true;
            }
            else
            {
                btnBaruSupplier.Enabled = false;
            }
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

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

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //btnUpdate.Enabled = false;
                //clear();
            }
        }

        private void txtharga_KeyPress(object sender, KeyPressEventArgs e)
        {
            benar = true;
            if (txtharga.Text == "")
            {
                info_harga.ForeColor = System.Drawing.Color.Red;
                info_harga.Text = "Wajib diisi!";
                benar = false;
            }
            else
            {
                info_harga.ForeColor = System.Drawing.Color.Green;
                info_harga.Text = "Sesuai";
            }
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        bool benar;
        private void txtnama_komponen_Leave(object sender, EventArgs e)
        {
            benar = true;
            if (txtnama_komponen.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Wajib diisi!";
                benar = false;
            }
            else if (txtid_komponen.Text == "")
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
        }

        private void txtnama_supplier_Leave(object sender, EventArgs e)
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
        }

        private void txtnama_supplier_KeyPress(object sender, KeyPressEventArgs e)
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
            if (txtid_supplier.Text == "" && txtnama_supplier.Text != "")
            {
                btnBaruSupplier.Enabled = true;
            }
            else
            {
                btnBaruSupplier.Enabled = false;
            }
        }

        private void txtnama_komponen_KeyPress(object sender, KeyPressEventArgs e)
        {
       
            benar = true;
            if (txtnama_komponen.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Wajib diisi!";
                benar = false;
            }
            else if (txtid_komponen.Text == "")
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
        }

        private void txtharga_Leave(object sender, EventArgs e)
        {
            benar = true;
            if (txtharga.Text == "")
            {
                info_harga.ForeColor = System.Drawing.Color.Red;
                info_harga.Text = "Wajib diisi!";
                benar = false;
            }
            else
            {
                info_harga.ForeColor = System.Drawing.Color.Green;
                info_harga.Text = "Sesuai";
            }
        }

        private void txtharga_TextChanged(object sender, EventArgs e)
        {
            benar = true;
            if (txtharga.Text == "")
            {
                info_harga.ForeColor = System.Drawing.Color.Red;
                info_harga.Text = "Wajib diisi!";
                benar = false;
            }
            else
            {
                info_harga.ForeColor = System.Drawing.Color.Green;
                info_harga.Text = "Sesuai";
            }
            if (txtid_supplier.Text != "" && txtid_komponen.Text != "" && txtharga.Text != "")
            {
                btnSimpan.Enabled = true;
            }
            else
            {
                btnSimpan.Enabled = false;
            }

        }

        private void txtid_komponen_TextChanged(object sender, EventArgs e)
        {
            if (txtnama_komponen.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Wajib diisi!";
                benar = false;
            }
            else if (txtid_komponen.Text == "")
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
            if (txtid_komponen.Text == "" && txtnama_komponen.Text != "")
            {
                btnBaruKomponen.Enabled = true;
            }
            else
            {
                btnBaruKomponen.Enabled = false;
                
            }
            if(txtid_supplier.Text != "" && txtid_komponen.Text != "" && txtharga.Text != "")
            {
                btnSimpan.Enabled = true;
            }
            else
            {
                btnSimpan.Enabled = false;
            }
        }

        private void txtid_supplier_TextChanged(object sender, EventArgs e)
        {
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
            if (txtid_supplier.Text == "" && txtnama_supplier.Text != "")
            {
                btnBaruSupplier.Enabled = true;
            }
            else
            {
                btnBaruSupplier.Enabled = false;
            }
            if (txtid_supplier.Text != "" && txtid_komponen.Text != "" && txtharga.Text != "")
            {
                btnSimpan.Enabled = true;
            }
            else
            {
                btnSimpan.Enabled = false;
            }
        }

        private void txtnama_komponen_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtid_komponen.Text == "" && txtnama_komponen.Text != "")
            {
                btnBaruKomponen.Enabled = true;
            }
            else
            {
                btnBaruKomponen.Enabled = false;
            }
        }

        private void txtnama_supplier_KeyUp(object sender, KeyEventArgs e)
        {
            if (txtid_supplier.Text == "" && txtnama_supplier.Text != "")
            {
                btnBaruSupplier.Enabled = true;
            }
            else
            {
                btnBaruSupplier.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cekAll();
            if (benar)
            {
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                    "ID Customer\t: " + txtnama_komponen.Text + "\n" +
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
        private void cekAll()
        {
            benar = true;
            if (txtharga.Text == "")
            {
                info_harga.ForeColor = System.Drawing.Color.Red;
                info_harga.Text = "Wajib diisi!";
                benar = false;
            }            
            else
            {
                info_harga.ForeColor = System.Drawing.Color.Green;
                info_harga.Text = "Sesuai";
            }

            if (txtnama_komponen.Text == "")
            {
                infonamakomponen.ForeColor = System.Drawing.Color.Red;
                infonamakomponen.Text = "Wajib diisi!";
                benar = false;
            }else if(txtid_komponen.Text == "")
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

            if (txtnama_supplier.Text == "")
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                infonama_supplier.Text = "Wajib diisi!";
                benar = false;
            }
            else if(txtid_supplier.Text == "")
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
        }
        private void updateDB()
        {
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_inputKomponenSupplier", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string id_komponen = txtid_komponen.Text;
                string id_supplier = txtid_supplier.Text;
                string harga = txtharga.Text;
                string total_transaksi = "0";

                SqlParameter param = new SqlParameter();

                myCommand.Parameters.AddWithValue("id_komponen", id_komponen);
                myCommand.Parameters.AddWithValue("id_supplier", id_supplier);
                myCommand.Parameters.AddWithValue("harga", harga);
                myCommand.Parameters.AddWithValue("total_transaksi", total_transaksi);

                
                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(btnSimpan.Enabled == true)
            {
                clear();
            }
            else
            {
                this.Close();
            }
        }
        private void clear()
        {
            txtnama_komponen.Text = "";
            txtnama_supplier.Text = "";
            txtharga.Text = "";
        }
        public string namasupplier;
        private void btnBaruSupplier_Click(object sender, EventArgs e)
        {
            
            GenericIdentity myIdentity = new GenericIdentity(txtnama_supplier.Text);
            string[] myRole = new string[10];

            GenericPrincipal myPrincipal = new GenericPrincipal(myIdentity,myRole);

            Thread.CurrentPrincipal = myPrincipal;

            SupplierMaster supplier = new SupplierMaster();
            
            supplier.ShowDialog(this);
        }

        private void KomponenSupplier_Activated(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

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

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.ToString());
                //btnUpdate.Enabled = false;
                //clear();
            }
        }
    }
}
