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
    public partial class AlatElektronik : Form
    {
        private Boolean cek = false;
        private string idJenis;
        public AlatElektronik()
        {
            InitializeComponent();
            txtNama.MaxLength = 30;
            txtJenis.MaxLength = 30;
            addSourceJenis();
            clear();
        }

        private void addSourceJenis()
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            //string connectionString = ConfigurationSettings.AppSettings["constring1"];
            //punya teddy
            string connectionString = Program.getConstring();

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_jenis from msjeniselektronik", connection);
            //memasukkan ke dataset
            DataSet msjenis = new DataSet();
            adapter.Fill(msjenis);

            for (int i = 0; i < msjenis.Tables[0].Rows.Count; i++)
            {

                collection.Add(msjenis.Tables[0].Rows[i][0].ToString());
            }
            txtJenis.AutoCompleteCustomSource = collection;
            txtJenis.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtJenis.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void clear()
        {
            lblId.Text = "ALE-XXXX";
            txtNama.Text = "";
            txtJenis.Text = "";
            epSalah.SetError(txtNama, "");
            epBenar.SetError(txtNama, "");
            epSalah.SetError(txtJenis, "");
            epBenar.SetError(txtJenis, "");
            idJenis = "";
        }

        private string getLastID()
        {
            //string connectionString = ConfigurationSettings.AppSettings["constring1"];
            //punya teddy
            string connectionString = Program.getConstring();


            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select count (id_alat) from msalatelektronik", connection); ;

            //memasukkan ke dataset
            DataSet msalat = new DataSet();
            adapter.Fill(msalat);
            //mengambil data jumlah
            int count = (int)msalat.Tables[0].Rows[0][0];
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
                //string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                
                string connectionString = Program.getConstring();

                SqlConnection myConnection = new SqlConnection(connectionString);

                SqlCommand myCommand = null;

                myConnection.Open();

                SqlParameter param = new SqlParameter();

                myCommand = new SqlCommand("sp_inputAlatElektronik", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("id_alat", "ALE-" + getLastID());
                myCommand.Parameters.AddWithValue("nama_alat", txtNama.Text);
                myCommand.Parameters.AddWithValue("id_jenis", idJenis);

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

        private void txtJenis_TextChanged(object sender, EventArgs e)
        {
            if (txtJenis.Text == "")
            {
                epSalah.SetError(txtJenis, "Kolom jenis alat elektronik harap diisi");
                epBenar.SetError(txtJenis, "");
                cek = false;
            }
            else
            {
                epSalah.SetError(txtJenis, "");
                epBenar.SetError(txtJenis, "Sesuai");
                cek = true;
            }
            try
            {
                //string connectionString = ConfigurationSettings.AppSettings["constring1"];
                //punya teddy
                string connectionString = Program.getConstring();


                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariJenisElektronik", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtJenis.Text;

                myCommand.Parameters.AddWithValue("id_jenis", pencarian);
                myCommand.Parameters.AddWithValue("nama_jenis", pencarian);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                idJenis = "";
                idJenis = data.Rows[0][0].ToString();
            }
            catch (Exception ex)
            {
                epSalah.SetError(txtJenis, "Data tidak ditemukan");
                epBenar.SetError(txtJenis, "");
                cek = false;
            }
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epSalah.SetError(txtNama, "Kolom alat elektronik harap diisi!");
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
                   "ID Alat\t\t\t: " + lblId.Text + "\n" +
                   "Nama Alat Elektronik\t: " + txtNama.Text + "\n" +
                   "Nama Jenis Alat Elektronik\t: " + txtJenis.Text
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
            GenericIdentity myIdentity = new GenericIdentity(txtJenis.Text);
            string[] myRole = new string[10];

            GenericPrincipal myPrincipal = new GenericPrincipal(myIdentity, myRole);

            Thread.CurrentPrincipal = myPrincipal;

            JenisAlatElektronik jenis = new JenisAlatElektronik();

            jenis.ShowDialog(this);
        }

        private void AlatElektronik_Load(object sender, EventArgs e)
        {
            if (Thread.CurrentPrincipal.Identity.Name != "")
            {
                txtNama.Text = Thread.CurrentPrincipal.Identity.Name;
            }
        }
    }
}
