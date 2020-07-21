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
    public partial class UpdateJenisElektronik : Form
    {
        private Boolean cek = false;
        private string idJenis;

        public UpdateJenisElektronik()
        {
            InitializeComponent();
            txtNama.MaxLength = 30;
            clear();
        }

        private void UpdateJenisElektronik_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            this.msjeniselektronikTableAdapter.Fill(this.dataJenisElektronik.msjeniselektronik);
        }

        private void dgAlatElektronik_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
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
            SqlDataAdapter adapter = adapter = new SqlDataAdapter("select " + filter + " from msjeniselektronik", connection);
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
                case "ID Jenis": sourceFilter("id_jenis"); break;
                case "Nama Jenis Elektronik": sourceFilter("nama_jenis"); break;
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
                string pencarian = txtPencarian.Text;
                SqlCommand myCommand = new SqlCommand("sp_cariJenisElektronik", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("id_jenis", pencarian);
                myCommand.Parameters.AddWithValue("nama_jenis", pencarian);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);
                //MessageBox.Show(data.Rows[0][1].ToString());
                lblId.Text = data.Rows[0][0].ToString();
                txtNama.Text = data.Rows[0][1].ToString();

                connection.Close();
                btnPerbarui.Enabled = true;
            }
            catch (Exception)
            {
                btnPerbarui.Enabled = false;
                refresh();
                gbUpdate.Enabled = false;
                btnBatal.Enabled = false;
            }
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

                SqlCommand myCommand =  new SqlCommand("sp_updateJenisElektronik", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("id_jenis", lblId.Text);
                myCommand.Parameters.AddWithValue("nama_jenis", txtNama.Text);

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
                checker += "Kolom jenis elektronik harap diisi\n";
            }
            else
            {
                cek = true;
            }

            if (cek)
            {
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                   "ID Jenis\t\t\t: " + lblId.Text + "\n" +
                   "Nama Jenis Elektronik\t: " + txtNama.Text
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
    }
}
