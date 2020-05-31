using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class TambahPekerja : Form
    {
        private Boolean cek = false;
        private string jenis_kelamin;

        public TambahPekerja()
        {
            InitializeComponent();

            clear();
            txtNama.MaxLength = 50;
            txtAlamat.MaxLength = 100;
            txtEmail.MaxLength = 30;
            txtTelepon.MaxLength = 13;
        }

        private string getLastID()
        {

            //string connectionString = ConfigurationSettings.AppSettings["constring1"];
            //punya teddy
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter adapter = null;

            //membuat table dengan jumlah data saja
            if (cmbBagian.Text == "Pelayan")
            {
                adapter = new SqlDataAdapter("select count (id_pelayan) from msbagianpelayan", connection);
            }
            else if (cmbBagian.Text == "Gudang")
            {
                adapter = new SqlDataAdapter("select count (id_gudang) from msbagiangudang", connection);
            }
            //memasukkan ke dataset
            DataSet mspekerja = new DataSet();
            adapter.Fill(mspekerja);

            //mengambil data jumlah
            int count = (int)mspekerja.Tables[0].Rows[0][0];
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
            if (rbLakilaki.Checked == true)
            {
                jenis_kelamin = rbLakilaki.Text;
            }
            else
            {
                jenis_kelamin = rbPerempuan.Text;
            }

            if (cek)
            {
                DialogResult result = DialogResult.Yes;
                if (cmbBagian.Text == "Pelayan")
                {
                    result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                   "ID Pelayan\t: " + lblId.Text + "\n" +
                   "Nama Pelayan\t: " + txtNama.Text + "\n" +
                   "Jenis Kelamin\t: " + jenis_kelamin + "\n" +
                   "Alamat\t\t: " + txtAlamat.Text + "\n" +
                   "Email\t\t: " + txtEmail.Text + "\n" +
                   "No Telepon\t: " + txtTelepon.Text + "\n" +
                   "Status\t\t: " + cmbStatus.SelectedItem
                   , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
                else if (cmbBagian.Text == "Gudang")
                {
                    result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                   "ID Gudang\t: " + lblId.Text + "\n" +
                   "Nama Gudang\t: " + txtNama.Text + "\n" +
                   "Jenis Kelamin\t: " + jenis_kelamin + "\n" +
                   "Alamat\t\t: " + txtAlamat.Text + "\n" +
                   "Email\t\t: " + txtEmail.Text + "\n" +
                   "No Telepon\t: " + txtTelepon.Text + "\n" +
                   "Status\t\t: " + cmbStatus.SelectedItem
                   , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                }
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
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection myConnection = new SqlConnection(connectionString);

                SqlCommand myCommand = null;

                myConnection.Open();

                SqlParameter param = new SqlParameter();

                if (cmbBagian.Text == "Pelayan")
                {
                    myCommand = new SqlCommand("sp_inputPelayan", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("id_pelayan", lblId.Text);
                    myCommand.Parameters.AddWithValue("nama_pelayan", txtNama.Text);
                    myCommand.Parameters.AddWithValue("jenis_kelamin", jenis_kelamin);
                    myCommand.Parameters.AddWithValue("alamat", txtAlamat.Text);
                    myCommand.Parameters.AddWithValue("email", txtEmail.Text);
                    myCommand.Parameters.AddWithValue("no_telepon", txtTelepon.Text);
                    myCommand.Parameters.AddWithValue("status", cmbStatus.SelectedItem);
                }
                else if (cmbBagian.Text == "Gudang")
                {
                    myCommand = new SqlCommand("sp_inputGudang", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("id_gudang", lblId.Text);
                    myCommand.Parameters.AddWithValue("nama_gudang", txtNama.Text);
                    myCommand.Parameters.AddWithValue("jenis_kelamin", jenis_kelamin);
                    myCommand.Parameters.AddWithValue("alamat", txtAlamat.Text);
                    myCommand.Parameters.AddWithValue("email", txtEmail.Text);
                    myCommand.Parameters.AddWithValue("no_telepon", txtTelepon.Text);
                    myCommand.Parameters.AddWithValue("status", cmbStatus.SelectedItem);
                }

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

        private void clear()
        {
            cmbBagian.SelectedItem = null;
            cmbBagian.Text = "--Pilih--";
            lblId.Text = "";
            txtNama.Text = "";
            rbLakilaki.Checked = false;
            rbPerempuan.Checked = false;
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtTelepon.Text = "";
            cmbStatus.SelectedItem = null;
            cmbStatus.Text = "";
            lblBagian.Enabled = false;
            lblNama.Enabled = false;
            label4.Enabled = false;
            label5.Enabled = false;
            label6.Enabled = false;
            label7.Enabled = false;
            label8.Enabled = false;
            label9.Enabled = false;
            label10.Enabled = false;
            label11.Enabled = false;
            label12.Enabled = false;
            label13.Enabled = false;
            label14.Enabled = false;
            label15.Enabled = false;
            txtNama.Enabled = false;
            rbLakilaki.Enabled = false;
            rbPerempuan.Enabled = false;
            txtAlamat.Enabled = false;
            txtEmail.Enabled = false;
            txtTelepon.Enabled = false;
            cmbStatus.Enabled = false;
            btnTambah.Enabled = false;
            btnBatal.Enabled = false;
            epSalah.SetError(txtNama, "");
            epBenar.SetError(txtNama, "");
            epSalah.SetError(txtAlamat, "");
            epBenar.SetError(txtAlamat, "");
            epSalah.SetError(txtEmail, "");
            epBenar.SetError(txtEmail, "");
            epSalah.SetError(txtTelepon, "");
            epBenar.SetError(txtTelepon, "");
        }

        private void enabler()
        {
            lblBagian.Enabled = true;
            lblNama.Enabled = true;
            label4.Enabled = true;
            label5.Enabled = true;
            label6.Enabled = true;
            label7.Enabled = true;
            label8.Enabled = true;
            label9.Enabled = true;
            label10.Enabled = true;
            label11.Enabled = true;
            label12.Enabled = true;
            label13.Enabled = true;
            label14.Enabled = true;
            label15.Enabled = true;
            txtNama.Enabled = true;
            rbLakilaki.Enabled = true;
            rbPerempuan.Enabled = true;
            txtAlamat.Enabled = true;
            txtEmail.Enabled = true;
            txtTelepon.Enabled = true;
            btnTambah.Enabled = true;
            btnBatal.Enabled = true;
            cmbStatus.SelectedIndex = 0;
        }
        private void txtNama_Leave(object sender, EventArgs e)
        {
            if (txtNama.Text == "")
            {
                epSalah.SetError(txtNama, "Kolom nama harap diisi");
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

        private void txtAlamat_Leave(object sender, EventArgs e)
        {
            if (txtAlamat.Text == "")
            {
                epSalah.SetError(txtAlamat, "Kolom alamat harap diisi");
                epBenar.SetError(txtAlamat, "");
                cek = false;
            }
            else
            {
                epSalah.SetError(txtAlamat, "");
                epBenar.SetError(txtAlamat, "Sesuai");
                cek = true;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (txtEmail.Text == "")
            {
                epSalah.SetError(txtEmail, "Kolom email harap diisi");
                epBenar.SetError(txtEmail, "");
                cek = false;
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                epSalah.SetError(txtEmail, "");
                epBenar.SetError(txtEmail, "Sesuai");
                cek = true;
            }
            else
            {
                epSalah.SetError(txtEmail, "Format email salah!\n(aaa@bbb.ccc)");
                epBenar.SetError(txtEmail, "");
                cek = false;
            }
        }

        private void txtTelepon_Leave(object sender, EventArgs e)
        {
            if (txtTelepon.Text == "")
            {
                epSalah.SetError(txtTelepon, "Kolom nomor telepon harap diisi");
                epBenar.SetError(txtTelepon, "");
                cek = false;
            }
            else
            {
                epSalah.SetError(txtTelepon, "");
                epBenar.SetError(txtTelepon, "Sesuai");
                cek = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            this.Close();
        }

        private void cmbBagian_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbBagian.Text == "Pelayan")
            {
                enabler();
                lblBagian.Text = "ID Pelayan";
                lblNama.Text = "Nama Pelayan";
                lblId.Text = "PLY-" + getLastID();
            }
            else if (cmbBagian.Text == "Gudang")
            {
                enabler();
                lblBagian.Text = "ID Gudang";
                lblNama.Text = "Nama Gudang";
                lblId.Text = "GDG-" + getLastID();
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

        private void cmbBagian_TextChanged(object sender, EventArgs e)
        {
            if (cmbBagian.Text == "Pelayan")
            {
                enabler();
                lblBagian.Text = "ID Pelayan";
                lblId.Text = "PLY-" + getLastID();
            }
            else if (cmbBagian.Text == "Gudang")
            {
                enabler();
                lblBagian.Text = "ID Gudang";
                lblId.Text = "GDG-" + getLastID();
            }
            else
            {
                clear();
            }
        }

        private void txtTelepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtNama_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
