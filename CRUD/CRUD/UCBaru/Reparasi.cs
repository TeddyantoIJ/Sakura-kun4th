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

namespace CRUD
{
    public partial class Reparasi : UserControl
    {
        public string id_karyawan = "";
        public Reparasi()
        {
            InitializeComponent();
        }

        private void btnNewPelanggan_Click(object sender, EventArgs e)
        {
            CustomerMaster cus = new CustomerMaster(nama_pelanggan.Text);
            cus.ShowDialog(this);
            addSourceNama();
            
        }
        private void addSourceNama()
        {
            nama_pelanggan.AutoCompleteCustomSource = null;

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
            nama_pelanggan.AutoCompleteCustomSource = collection;
            nama_pelanggan.AutoCompleteMode = AutoCompleteMode.Suggest;
            nama_pelanggan.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void addSourceJenis()
        {
            txtJenis_alat.AutoCompleteCustomSource = null;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_jenis from msjeniselektronik", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            txtJenis_alat.AutoCompleteCustomSource = collection;
            txtJenis_alat.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtJenis_alat.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        //txtJenis_alat
        private void addSourceAlat()
        {
            txtAlat.AutoCompleteCustomSource = null;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_alat from msalatelektronik where id_jenis ='"+getIDJenis(txtJenis_alat.Text)+"'", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            try
            {
                txtAlat.AutoCompleteCustomSource = collection;
                txtAlat.AutoCompleteMode = AutoCompleteMode.Suggest;
                txtAlat.AutoCompleteSource = AutoCompleteSource.CustomSource;
            }
            catch(Exception ex)
            {

            }
            
        }
        private void nama_pelanggan_TextChanged(object sender, EventArgs e)
        {
            try
            {

                foto_pelanggan.Image = Image.FromFile(getPathCustomer(nama_pelanggan.Text));
                foto_pelanggan.SizeMode = PictureBoxSizeMode.StretchImage;
                lblFoto.Text = "";
                lblFoto.Visible = false;
            }
            catch (Exception ex)
            {
                lblFoto.Visible =true;
                foto_pelanggan.Image = null;
                lblFoto.Text = "Tidak tersedia";
            }
        }
        private string getPathCustomer(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariCustomer", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_customer", "XX");
                myCommand.Parameters.AddWithValue("nama_customer", inx);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][3].ToString();
                return output;

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error getIDKomponen : " + ex.ToString());

                return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }

        private void panelPelanggan_Paint(object sender, PaintEventArgs e)
        {
            addSourceNama();
            addSourceJenis();
        }
        private string getLastID()
        {
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select count (no_transaksi_reparasi) from treparasialat", connection);
            //memasukkan ke dataset
            DataSet mscustomer = new DataSet();
            adapter.Fill(mscustomer);

            //mengambil data jumlah
            int count = (int)mscustomer.Tables[0].Rows[0][0];
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
        private string getIDPelanggan(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariCustomer", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_customer", "XX");
                myCommand.Parameters.AddWithValue("nama_customer", inx);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                return output;

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error getIDKomponen : " + ex.ToString());

                return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }
        private string getIDJenis(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariJenisElektronik", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_jenis", "XX");
                myCommand.Parameters.AddWithValue("nama_jenis", inx);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                return output;

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error getIDKomponen : " + ex.ToString());

                return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }
        private string getIDAlat(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatElektronik", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_alat", "XX");
                myCommand.Parameters.AddWithValue("nama_alat", inx);
                myCommand.Parameters.AddWithValue("id_jenis", "XX");
                
                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                //MessageBox.Show(output.ToString());
                return output;
                MessageBox.Show(output.ToString());
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error getIDAlat : " + ex.ToString());

                return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }
        private void btnProses_Click(object sender, EventArgs e)
        {
            DialogResult n = MessageBox.Show("Proses transaksi?", "Pertanyaan", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(n == DialogResult.OK)
            {

            }
            else
            {
                MessageBox.Show("Transaksi dibatalkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_inputTransaksiReparasiAlat", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();


                
                myCommand.Parameters.AddWithValue("no_transaksi_reparasi", "TBA-" + getLastID());
                //myCommand.Parameters.AddWithValue("id_pelayan", id_karyawan);
                myCommand.Parameters.AddWithValue("id_pelayan", "PLY-0001");
                myCommand.Parameters.AddWithValue("id_customer", getIDPelanggan(nama_pelanggan.Text));
                myCommand.Parameters.AddWithValue("tanggal_reparasi", DateTime.Now.ToString("yyyyMMdd"));
                myCommand.Parameters.AddWithValue("keluhan", txtKeluhan.Text);
                myCommand.Parameters.AddWithValue("id_gudang", "-");
                myCommand.Parameters.AddWithValue("id_jenis", getIDJenis(txtJenis_alat.Text));
                myCommand.Parameters.AddWithValue("alat_elektronik", getIDAlat(txtAlat.Text));
                




                myCommand.ExecuteNonQuery();
                connection.Close();

                txtAlat.Text = "";
                txtJenis_alat.Text = "";
                nama_pelanggan.Text = "";
                txtKeluhan.Text = "";

                //by = 1;

                //btnUpdate.Enabled = true;
                MessageBox.Show("Segera diproses","Informasi",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masukkan data dengan benar! "+ex.ToString(),"Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Warning);


                //btnUpdate.Enabled = false;
                //clear();
            }
        }

        private void txtJenis_alat_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtAlat_Enter(object sender, EventArgs e)
        {
            addSourceAlat();
        }
    }
}
