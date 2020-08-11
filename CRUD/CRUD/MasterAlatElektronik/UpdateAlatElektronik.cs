using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
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
    public partial class UpdateAlatElektronik : Form
    {
        private Boolean cek = false;
        private string idJenis;

        public UpdateAlatElektronik()
        {
            InitializeComponent();
            txtNama.MaxLength = 30;
            txtJenis.MaxLength = 30;
            addSourceJenis();
            clear();
        }

        private void UpdateAlatElektronik_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            this.msalatelektronikTableAdapter.Fill(this.dataAlatElektronik.msalatelektronik);
            for (int i = 0; i < dgAlatElektronik.Rows.Count - 1; i++)
            {
                dgAlatElektronik.Rows[i].Cells[2].Value = converterJenis(dgAlatElektronik.Rows[i].Cells[2].Value.ToString());
            }
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

        private string converterJenis(String search)
        {
            string nama_jenis = null;
            try
            {
                //string connectionString = ConfigurationSettings.AppSettings["constring1"];
                //punya teddy
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariJenisElektronik", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_jenis", search);
                myCommand.Parameters.AddWithValue("nama_jenis", search);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                nama_jenis = data.Rows[0][1].ToString();

                connection.Close();
            }
            catch (Exception ex)
            {
                //cek = false;
            }
            return nama_jenis;
        }

        private void dgAlatElektronik_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                gbUpdate.Enabled = false;
                btnBatal.Enabled = false;
                int selectedRow = 0;
                Int32 selectedRowCount = dgAlatElektronik.Rows.GetRowCount(DataGridViewElementStates.Selected);
                if (selectedRowCount > 0 && selectedRowCount <= 1)
                {
                    btnPerbarui.Enabled = true;

                    for (int i = 0; i < selectedRowCount; i++)
                    {
                        selectedRow = Int32.Parse(dgAlatElektronik.SelectedRows[i].Index.ToString());
                    }
                    DataGridViewRow row = dgAlatElektronik.Rows[selectedRow];

                    lblId.Text = row.Cells[0].Value.ToString();
                    txtNama.Text = row.Cells[1].Value.ToString();
                    txtJenis.Text = converterJenis(row.Cells[2].Value.ToString());

                    btnPerbarui.Enabled = true;
                }
                else
                {
                    btnPerbarui.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data tidak valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnPerbarui.Enabled = false;
            }
        }

        private void clear()
        {
            cek = false;
            cmbPencarian.SelectedItem = null;
            cmbPencarian.Text = "--Pilih--";
            txtPencarian.Text = "";
            lblId.Text = "";
            txtNama.Text = "";
            txtJenis.Text = "";
            gbUpdate.Enabled = false;
            btnPerbarui.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void sourceFilter(string filter)
        {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            //string connectionString = ConfigurationSettings.AppSettings["constring1"];
            //punya teddy
            string connectionString = Program.getConstring();


            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = adapter = new SqlDataAdapter("select " + filter + " from msalatelektronik", connection);
            //memasukkan ke dataset
            DataSet msalat = new DataSet();
            adapter.Fill(msalat);

            for (int i = 0; i < msalat.Tables[0].Rows.Count; i++)
            {

                collection.Add(msalat.Tables[0].Rows[i][0].ToString());
            }
            txtPencarian.AutoCompleteCustomSource = collection;
            txtPencarian.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPencarian.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cmbPencarian_TextChanged(object sender, EventArgs e)
        {
            switch (cmbPencarian.Text)
            {
                case "ID Alat": sourceFilter("id_alat"); break;
                case "Nama Alat Elektronik": sourceFilter("nama_alat"); break;
                case "Nama Jenis Elektronik": sourceFilter("id_jenis"); break;
            }
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

        private void btnSegarkan_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            btnBatal.Enabled = true;
            btnPerbarui.Enabled = false;
            gbUpdate.Enabled = true;
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateDB()
        {
            try
            {

                //string connectionString = ConfigurationSettings.AppSettings["constring1"];
                //punya teddy
                string connectionString = Program.getConstring();


                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand =  new SqlCommand("sp_updateAlatElektronik", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("id_alat", lblId.Text);
                myCommand.Parameters.AddWithValue("nama_alat", txtNama.Text);
                myCommand.Parameters.AddWithValue("id_jenis", idJenis);

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string checker = null;

            if (txtNama.Text == "")
            {
                cek = false;
                checker += "Kolom alat elektronik harap diisi\n";
                MessageBox.Show(checker, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                cek = true;
            }

            if (txtJenis.Text == "")
            {
                cek = false;
                checker += "Kolom jenis alat elektronik harap diisi\n"; MessageBox.Show(checker, "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning); return;
            }
            else
            {
                cek = true;
            }

            if (cek)
            {
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                   "ID Alat\t\t\t: " + lblId.Text + "\n" +
                   "Nama Alat Elektronik\t: " + txtNama.Text + "\n" +
                   "Jenis Alat Elektronik\t: " + txtJenis.Text
                   , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    updateDB();
                    clear();
                    refresh();
                }
                else
                {
                    MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show(checker, "Data tidak valid!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtJenis_TextChanged(object sender, EventArgs e)
        {
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
                connection.Close();
            }
            catch (Exception ex)
            {
                cek = false;
            }
        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //string connectionString = ConfigurationSettings.AppSettings["constring1"];
                //punya teddy
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);

                connection.Open();

                SqlCommand myCommand = new SqlCommand("sp_cariAlatElektronik", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string pencarian = txtPencarian.Text;

                myCommand.Parameters.AddWithValue("id_alat", pencarian);
                myCommand.Parameters.AddWithValue("nama_alat", pencarian);
                myCommand.Parameters.AddWithValue("id_jenis", pencarian);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                lblId.Text = data.Rows[0][0].ToString();
                txtNama.Text = data.Rows[0][1].ToString();
                txtJenis.Text = converterJenis(data.Rows[0][2].ToString());

                connection.Close();
                btnPerbarui.Enabled = true;
            }
            catch (Exception ex)
            {
                btnPerbarui.Enabled = false;
                refresh();
                gbUpdate.Enabled = false;
                btnBatal.Enabled = false;
            }
        }
    }
}
