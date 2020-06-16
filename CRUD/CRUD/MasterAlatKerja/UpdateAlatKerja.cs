using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class UpdateAlatKerja : Form
    {
        public UpdateAlatKerja()
        {
            InitializeComponent();
        }

        private void UpdateAlatKerja_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakuraDataDataSet2.msalatkerja' table. You can move, or remove it, as needed.
            this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
            addSource();
        }
        int selectedRow;
        private void viewAlatKerja_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRowCount =
            viewAlatKerja.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount <= 1)
            {
                btnUpdate.Enabled = true;
                btnBatal.Enabled = false;
               // clear();
                //by = 0;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    selectedRow = Int32.Parse(viewAlatKerja.SelectedRows[i].Index.ToString());
                }
                DataGridViewRow row = viewAlatKerja.Rows[selectedRow];
                txtid_alat_kerja.Text = row.Cells[0].Value.ToString();
                txtnama_alat_kerja.Text = row.Cells[1].Value.ToString();
                txtjumlah.Text = row.Cells[2].Value.ToString();
                cmbbagus.Text = row.Cells[3].Value.ToString();
                cmbrusak.Text = row.Cells[4].Value.ToString();
            }
            else if(btnUpdate.Enabled == true)
            {
                btnUpdate.Enabled = false;
                btnBatal.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
        private void addSource()
        {

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_alat from msalatkerja", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);
            txtCari.AutoCompleteSource = AutoCompleteSource.None;
            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            txtCari.AutoCompleteCustomSource = collection;
            txtCari.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
            txtCari.Text = "";
            clear();
            btnUpdate.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateGrup.Enabled = true;
            btnUpdate.Enabled = false;
            btnBatal.Enabled = true;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            cmbbagus.Text = ((Int16.Parse(cmbbagus.Text)) + 1).ToString();
            txtjumlah.Text = ((Int16.Parse(cmbbagus.Text)) + (Int16.Parse(cmbrusak.Text))).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if((Int32.Parse(txtjumlah.Text)) <= (Int32.Parse(cmbbagus.Text)))
            {
                cmbbagus.Text = txtjumlah.Text;
            }
            else if (txtjumlah.Text != "0")
            {
                cmbbagus.Text = ((Int16.Parse(cmbbagus.Text)) - 1).ToString();
                txtjumlah.Text = ((Int16.Parse(cmbbagus.Text)) + (Int16.Parse(cmbrusak.Text))).ToString();
            }
            
        }

        private void txtjumlah_TextChanged(object sender, EventArgs e)
        {
            if (txtjumlah.Text == cmbbagus.Text)
            {
                btnPlus.Enabled = false;
            }
            else
            {
                btnPlus.Enabled = true;
            }
            if(txtjumlah.Text == cmbrusak.Text)
            {
                btnPlus1.Enabled = false;
            }
            else
            {
                btnPlus1.Enabled = true;
            }
            if(txtjumlah.Text == "0")
            {
                button1.Enabled = false;
            }
            else
            {
                button1.Enabled = true;
            }
        }

        private void cmbbagus_TextChanged(object sender, EventArgs e)
        {
            if(cmbbagus.Text == txtjumlah.Text)
            {
                btnPlus.Enabled = false;
            }
            else
            {
                btnPlus.Enabled = true;
            }
            if(cmbbagus.Text == "0")
            {
                btnMinus.Enabled = false;
            }
            else
            {
                btnMinus.Enabled = true;
            }
            try
            {
                if (txtjumlah.Text != "")
                {
                    cmbrusak.Text = ((Int16.Parse(txtjumlah.Text)) - Int16.Parse(cmbbagus.Text)).ToString();
                    infocmb1.ForeColor = System.Drawing.Color.Transparent;
                    infocmb2.ForeColor = System.Drawing.Color.Transparent;
                }
            }
            catch (Exception)
            {
                cmbrusak.Text = "";
            }
        }

        private void cmbrusak_TextChanged(object sender, EventArgs e)
        {
            if(cmbrusak.Text == "0")
            {
                btnMinus1.Enabled = false;
            }
            else
            {
                btnMinus1.Enabled = true;
            }
            if (cmbrusak.Text == txtjumlah.Text)
            {
                btnPlus1.Enabled = false;
            }
            else
            {
                btnPlus1.Enabled = true;
            }
            try
            {
                if (txtjumlah.Text != "")
                {
                    cmbbagus.Text = ((Int16.Parse(txtjumlah.Text)) - Int16.Parse(cmbrusak.Text)).ToString();
                    infocmb1.ForeColor = System.Drawing.Color.Transparent;
                    infocmb2.ForeColor = System.Drawing.Color.Transparent;
                }
            }
            catch (Exception)
            {
                cmbbagus.Text = "";
            }
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            cmbrusak.Text = ((Int16.Parse(cmbrusak.Text)) + 1).ToString();
            txtjumlah.Text = ((Int16.Parse(cmbbagus.Text)) + (Int16.Parse(cmbrusak.Text))).ToString();
        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            if ((Int32.Parse(txtjumlah.Text)) <= (Int32.Parse(cmbrusak.Text)))
            {
                cmbrusak.Text = txtjumlah.Text;
            }
            else if (txtjumlah.Text != "0")
            {
                cmbrusak.Text = ((Int16.Parse(cmbrusak.Text)) - 1).ToString();
                txtjumlah.Text = ((Int16.Parse(cmbbagus.Text)) + (Int16.Parse(cmbrusak.Text))).ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            txtjumlah.Text = ((Int16.Parse(txtjumlah.Text)) + 1).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtjumlah.Text = ((Int16.Parse(txtjumlah.Text)) - 1).ToString();
            if ((Int32.Parse(txtjumlah.Text)) <= ((Int32.Parse(cmbbagus.Text))+ (Int32.Parse(cmbrusak.Text))))
            {
                btnPlus.Enabled = false;
            }
            else
            {
                btnPlus.Enabled = true;
            }
            if ((Int32.Parse(txtjumlah.Text)) <= ((Int32.Parse(cmbbagus.Text)) + (Int32.Parse(cmbrusak.Text))))
            {
                btnPlus1.Enabled = false;
            }
            else
            {
                btnPlus1.Enabled = true;
            }
        }
        private bool cekJumlah()
        {
            if((Int16.Parse(txtjumlah.Text)) == ((Int16.Parse(cmbbagus.Text)) + (Int16.Parse(cmbrusak.Text))))
            {
                return true;
            }
            return false;
        }
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            
            if (benar && cekJumlah())
            {
                cmbbagus.BackColor = System.Drawing.Color.White;
                cmbrusak.BackColor = System.Drawing.Color.White;
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                    "ID Alat Kerja\t: " + txtid_alat_kerja.Text + "\n" +
                    "Nama Alat Kerja\t: " + txtnama_alat_kerja.Text + "\n" +
                    "Jumlah\t\t: " + txtjumlah.Text + "\n" +
                    "Bagus\t\t: " + cmbbagus.Text + "\n" +
                    "Rusak\t\t: " + cmbrusak.Text
                    , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    updateDB();
                    clear();
                    this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                    addSource();
                }
                else
                {
                    MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }else if (!cekJumlah())
            {
                MessageBox.Show("Jumlah tidak sesuai!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void clear()
        {
            txtid_alat_kerja.Text = "";
            infonama_alat_kerja.Text = "";
            txtnama_alat_kerja.Text = "";
            txtjumlah.Text = "";
            cmbbagus.Text = "";
            cmbrusak.Text = "";
            updateGrup.Enabled = false;
        }
        private void updateDB()
        {
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_updateAlatKerja", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string id_alat = txtid_alat_kerja.Text;
                string nama_alat = txtnama_alat_kerja.Text;
                string jumlah = txtjumlah.Text;
                string bagus = cmbbagus.Text;
                string rusak = cmbrusak.Text;

                SqlParameter param = new SqlParameter();

                myCommand.Parameters.AddWithValue("id_alat", id_alat);
                myCommand.Parameters.AddWithValue("nama_alat", nama_alat);
                myCommand.Parameters.AddWithValue("jumlah", jumlah);
                myCommand.Parameters.AddWithValue("rusak", rusak);
                myCommand.Parameters.AddWithValue("bagus", bagus);


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
        bool benar = true;
        private void txtnama_alat_kerja_KeyUp(object sender, KeyEventArgs e)
        {
            benar = true;
            if(txtnama_alat_kerja.Text == "")
            {
                infonama_alat_kerja.ForeColor = System.Drawing.Color.Red;
                infonama_alat_kerja.Text = "Harus diisi!";
                benar = false;
            }
            else
            {
                infonama_alat_kerja.ForeColor = System.Drawing.Color.Transparent;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnBatal.Enabled = false;
            clear();
        }

      

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCari_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatKerja", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtCari.Text;

                myCommand.Parameters.AddWithValue("id_alat", pencarian);
                myCommand.Parameters.AddWithValue("nama_alat", pencarian);
                myCommand.Parameters.AddWithValue("jumlah", -1);
                myCommand.Parameters.AddWithValue("bagus", -1);
                myCommand.Parameters.AddWithValue("rusak", -1);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);
                clear();

                txtid_alat_kerja.Text = data.Rows[0][0].ToString();
                txtnama_alat_kerja.Text = data.Rows[0][1].ToString();
                txtjumlah.Text = data.Rows[0][2].ToString();
                cmbrusak.Text = data.Rows[0][3].ToString();
                cmbbagus.Text = data.Rows[0][4].ToString();


                //by = 1;
                connection.Close();
                btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                btnUpdate.Enabled = false;
                //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                clear();
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                txtCari.Enabled = true;
            }
            else
            {
                txtCari.Enabled = false;
            }
        }

        private void txtnama_alat_kerja_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
