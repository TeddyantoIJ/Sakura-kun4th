using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Komponen : Form
    {
        private Boolean cek = false;
        private string idAlat;
        public Komponen()
        {
            InitializeComponent();
            txtNama.MaxLength = 30;
            txtAlat.MaxLength = 30;
            txtTempat.MaxLength = 4;
            addSourceAlat();
            clear();
        }
        public Komponen(string x)
        {
            InitializeComponent();
            txtNama.Text = x;
            txtNama.MaxLength = 30;
            txtAlat.MaxLength = 30;
            txtTempat.MaxLength = 4;
            addSourceAlat();
            clear();
        }
        private void addSourceAlat()
        {

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            // Punya fio
            //string connectionString = ConfigurationSettings.AppSettings["constring1"];

            //Punya teddy
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

        private void clear()
        {
            lblId.Text = "KMP-" + getLastID();
            txtNama.Text = "";
            txtJumlah.Text = "";
            txtHarga.Text = "";
            txtAlat.Text = "";
            txtTempat.Text = "";
            epSalah.SetError(txtNama, "");
            epBenar.SetError(txtNama, "");
            epSalah.SetError(txtJumlah, "");
            epBenar.SetError(txtJumlah, "");
            epSalah.SetError(txtHarga, "");
            epBenar.SetError(txtHarga, "");
            epSalah.SetError(txtAlat, "");
            epBenar.SetError(txtAlat, "");
            epSalah.SetError(txtTempat, "");
            epBenar.SetError(txtTempat, "");
        }

        private string getLastID()
        {
            //punya fio
            //string connectionString = ConfigurationSettings.AppSettings["constring1"];
            //punya saya
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";


            SqlConnection connection = new SqlConnection(connectionString);
            


            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select count (id_komponen) from mskomponen", connection); ;

            //memasukkan ke dataset
            DataSet mskomponen = new DataSet();
            adapter.Fill(mskomponen);
            //mengambil data jumlah
            int count = (int)mskomponen.Tables[0].Rows[0][0];
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

        private void inputDB()
        {
            try
            {

                //string connectionString = ConfigurationSettings.AppSettings["constring1"];
                //punya teddy
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                SqlCommand myCommand = null;

                myConnection.Open();

                SqlParameter param = new SqlParameter();

                myCommand = new SqlCommand("sp_inputKomponen", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("id_komponen", lblId.Text);
                myCommand.Parameters.AddWithValue("nama_komponen", txtNama.Text);
                myCommand.Parameters.AddWithValue("jumlah", int.Parse(txtJumlah.Text));
                myCommand.Parameters.AddWithValue("harga_jual", int.Parse(txtHarga.Text));
                myCommand.Parameters.AddWithValue("id_alat", idAlat);
                myCommand.Parameters.AddWithValue("tempat", txtTempat.Text);

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epSalah.SetError(txtNama, "Kolom nama komponen harap diisi");
                epBenar.SetError(txtNama, "");
                cek = false;
            }
            else
            {
                epSalah.SetError(txtNama, "");
                epBenar.SetError(txtNama, "Sesuai");
                cek = true;
            }
        }

        private void txtJumlah_TextChanged(object sender, EventArgs e)
        {
            if (txtJumlah.Text == "")
            {
                epSalah.SetError(txtJumlah, "Kolom jumlah harap diisi");
                epBenar.SetError(txtJumlah, "");
                cek = false;
            }
            else
            {
                epSalah.SetError(txtJumlah, "");
                epBenar.SetError(txtJumlah, "Sesuai");
                cek = true;
            }
        }

        private void txtHarga_TextChanged(object sender, EventArgs e)
        {
            if (txtHarga.Text == "")
            {
                epSalah.SetError(txtHarga, "Kolom harga jual harap diisi");
                epBenar.SetError(txtHarga, "");
                cek = false;
            }
            else
            {
                epSalah.SetError(txtHarga, "");
                epBenar.SetError(txtHarga, "Sesuai");
                cek = true;
            }
        }

        private void txtAlat_TextChanged(object sender, EventArgs e)
        {
            if (txtAlat.Text == "")
            {
                epSalah.SetError(txtAlat, "Kolom komponen alat elektronik harap diisi");
                epBenar.SetError(txtAlat, "");
                cek = false;
            }
            else
            {
                epSalah.SetError(txtAlat, "");
                epBenar.SetError(txtAlat, "Sesuai");
                cek = true;
            }
            try
            {
                //string connectionString = ConfigurationSettings.AppSettings["constring1"];
                //punya teddy
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
            }
            catch (Exception ex)
            {
                epSalah.SetError(txtTempat, "Data tidak ditemukan");
                epBenar.SetError(txtTempat, "");
                cek = false;
            }
        }

        private void txtTempat_TextChanged(object sender, EventArgs e)
        {
            if (txtTempat.Text == "")
            {
                epSalah.SetError(txtTempat, "Kolom tempat harap diisi");
                epBenar.SetError(txtTempat, "");
                cek = false;
            }
            else
            {
                epSalah.SetError(txtTempat, "");
                epBenar.SetError(txtTempat, "Sesuai");
                cek = true;
            }
        }

        private void txtJumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtHarga_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            this.Close();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cek)
            {
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                   "ID Komponen\t\t: " + lblId.Text + "\n" +
                   "Nama Komponen\t\t: " + txtNama.Text + "\n" +
                   "Jumlah\t\t\t: " + txtJumlah.Text + "\n" +
                   "Harga Jual\t\t: " + txtHarga.Text + "\n" +
                   "Komponen Alat Elektronik\t: " + txtAlat.Text + "\n" +
                   "Tempat\t\t\t: " + txtTempat.Text
                   , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    inputDB();
                }
                else
                {
                    MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnTambah_MouseEnter(object sender, EventArgs e)
        {
            if (cek)
            {
                btnTambah.Enabled = true;
            }
            else
            {
                btnTambah.Enabled = false;
            }
        }

        private void btnTambah_Leave(object sender, EventArgs e)
        {
            btnTambah.Enabled = true;
        }

        private void btnBaru_Click(object sender, EventArgs e)
        {
            GenericIdentity myIdentity = new GenericIdentity(txtAlat.Text);
            string[] myRole = new string[10];

            GenericPrincipal myPrincipal = new GenericPrincipal(myIdentity, myRole);

            Thread.CurrentPrincipal = myPrincipal;

            AlatElektronik alat = new AlatElektronik();

            alat.ShowDialog(this);
        }
    }
}
