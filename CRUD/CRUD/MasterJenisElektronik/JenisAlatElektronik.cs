using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class JenisAlatElektronik : Form
    {
        private Boolean cek = false;

        public JenisAlatElektronik()
        {
            InitializeComponent();
            txtNama.MaxLength = 30;
            clear();
        }

        private void clear()
        {
            lblId.Text = "JAL-XXXX";
            txtNama.Text = "";
            epSalah.SetError(txtNama, "");
            epBenar.SetError(txtNama, "");
        }

        private string getLastID()
        {
            //string connectionString = ConfigurationSettings.AppSettings["constring1"];
            //punya teddy
            string connectionString = Program.getConstring();

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select count (id_jenis) from msjeniselektronik", connection); ;

            //memasukkan ke dataset
            DataSet msjenis = new DataSet();
            adapter.Fill(msjenis);
            //mengambil data jumlah
            int count = (int)msjenis.Tables[0].Rows[0][0];
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

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (cek)
            {
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                   "ID Jenis\t\t\t: " + lblId.Text + "\n" +
                   "Nama Jenis Alat Elektronik\t: " + txtNama.Text
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

        private void inputDB()
        {
            try
            {

                //string connectionString = ConfigurationSettings.AppSettings["constring1"];
                //punya teddy
                string connectionString = Program.getConstring();

                SqlConnection myConnection = new SqlConnection(connectionString);

                SqlCommand myCommand = null;

                myConnection.Open();

                SqlParameter param = new SqlParameter();

                myCommand = new SqlCommand("sp_inputJenisElektronik", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("id_jenis", "JAL-" + getLastID());
                myCommand.Parameters.AddWithValue("nama_jenis", txtNama.Text);

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

        private void btnTambah_MouseLeave(object sender, EventArgs e)
        {
            btnTambah.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            this.Close();
        }

        private void txtNama_TextChanged(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epSalah.SetError(txtNama, "Kolom jenis alat elektronik harap diisi");
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

        private void JenisAlatElektronik_Load(object sender, EventArgs e)
        {
            if (Thread.CurrentPrincipal.Identity.Name != "")
            {
                txtNama.Text = Thread.CurrentPrincipal.Identity.Name;
            }
        }
    }
}
