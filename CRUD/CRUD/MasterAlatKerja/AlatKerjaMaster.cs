using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class AlatKerjaMaster : Form
    {
        public AlatKerjaMaster()
        {
            InitializeComponent();
            txtid_alat_kerja.Text = "AKRJ-XXXX";
        }
        public AlatKerjaMaster(string x)
        {
            txtnama_alat_kerja.Text = x;
            InitializeComponent();
            txtid_alat_kerja.Text = "AKRJ-XXXX";
        }
        private string getLastID()
        {
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select count (id_alat) from msalatkerja", connection);
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

        private void txtnama_alat_kerja_KeyUp(object sender, KeyEventArgs e)
        {
            benar = true;
            if(txtnama_alat_kerja.Text == "")
            {
                benar = false;
                infonama_alat_kerja.ForeColor = System.Drawing.Color.Red;
                infonama_alat_kerja.Text = "Wajib diisi!";
            }
            else
            {
                infonama_alat_kerja.ForeColor = System.Drawing.Color.Green;
                infonama_alat_kerja.Text = "Sesuai!";
            }
        }

        private void txtnama_alat_kerja_Leave(object sender, EventArgs e)
        {
            benar = true;
            if (txtnama_alat_kerja.Text == "")
            {
                benar = false;
                infonama_alat_kerja.ForeColor = System.Drawing.Color.Red;
                infonama_alat_kerja.Text = "Wajib diisi!";
            }
            else
            {
                infonama_alat_kerja.ForeColor = System.Drawing.Color.Green;
                infonama_alat_kerja.Text = "Sesuai!";
            }
        }

        private void txtjumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
        }

        private void txtjumlah_KeyUp(object sender, KeyEventArgs e)
        {
            benar = true;
            if(txtjumlah.Text == "")
            {
                benar = false;
                info_jumlah.ForeColor = System.Drawing.Color.Red;
                info_jumlah.Text = "Wajib diisi!";
                cmbrusak.Items.Clear();
                cmbbagus.Items.Clear();
                cmbrusak.Text = "";
                cmbbagus.Text = "";
            }
            else
            {
                info_jumlah.ForeColor = System.Drawing.Color.Green;
                info_jumlah.Text = "Sesuai!";

                cmbrusak.Items.Clear();
                cmbbagus.Items.Clear();
                cmbrusak.Text = "";
                cmbbagus.Text = "";
                for(int i = 1; i <= (Int16.Parse(txtjumlah.Text)) ; i++)
                {
                    cmbrusak.Items.Add(i);
                    cmbbagus.Items.Add(i);
                }
            }
        }

        private void txtjumlah_Leave(object sender, EventArgs e)
        {
            benar = true;
            if (txtjumlah.Text == "")
            {
                benar = false;
                info_jumlah.ForeColor = System.Drawing.Color.Red;
                info_jumlah.Text = "Wajib diisi!";
            }
            else
            {
                info_jumlah.ForeColor = System.Drawing.Color.Green;
                info_jumlah.Text = "Sesuai!";
            }
        }

        private void cmbrusak_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbrusak_TextChanged(object sender, EventArgs e)
        {

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
        
        private void cmbbagus_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void cmbbagus_TextChanged(object sender, EventArgs e)
        {
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
        bool benar = false;
        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (benar && cmbrusak.Text != "")
            {
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                    "ID Alat Kerja\t: " + txtid_alat_kerja.Text + "\n" +
                    "Nama Alat Kerja\t: " + txtnama_alat_kerja.Text + "\n" +
                    "Jumlah\t\t: "+txtjumlah.Text + "\n" +
                    "Bagus\t\t: "+cmbbagus.Text + "\n" +
                    "Rusak\t\t: " + cmbrusak.Text
                    , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    updateDB();
                    clear();
                }
                else
                {
                   
                        MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
     
                }
            }
            else
            {
                if(cmbrusak.Text == "")
                {
                    infocmb1.ForeColor = System.Drawing.Color.Red;
                    infocmb2.ForeColor = System.Drawing.Color.Red;
                    infocmb1.Text = "Wajib diisi!";
                    infocmb2.Text = "Wajib diisi!";
                }
                else
                {
                    infocmb1.ForeColor = System.Drawing.Color.Transparent;
                    infocmb2.ForeColor = System.Drawing.Color.Transparent;
                }   
                MessageBox.Show("Lengkapi data terlebih dahulu", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }
        }
        private void updateDB()
        {
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_inputAlatKerja", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string id_alat = txtid_alat_kerja.Text;
                string nama_alat = txtnama_alat_kerja.Text;
                string jumlah = txtjumlah.Text;
                string bagus = cmbbagus.Text;
                string rusak = cmbrusak.Text;

                SqlParameter param = new SqlParameter();

                myCommand.Parameters.AddWithValue("id_alat", "AKRJ-" + getLastID());
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
        private void clear()
        {
            txtid_alat_kerja.Text = "AKRJ-XXXX";
            infonama_alat_kerja.Text = "";
            info_jumlah.Text = "";
            txtnama_alat_kerja.Text = "";
            txtjumlah.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if(txtnama_alat_kerja.Text != "" || txtjumlah.Text != "")
            {
                clear();
            }
            else
            {
                this.Close();
            }
        }

        private void txtjumlah_TextChanged(object sender, EventArgs e)
        {
            if (txtjumlah.Text == "")
            {
                benar = false;
                info_jumlah.ForeColor = System.Drawing.Color.Red;
                info_jumlah.Text = "Wajib diisi!";
                cmbrusak.Items.Clear();
                cmbbagus.Items.Clear();
                cmbrusak.Text = "";
                cmbbagus.Text = "";
            }
        }

        private void AlatKerjaMaster_Load(object sender, EventArgs e)
        {
            if (Thread.CurrentPrincipal.Identity.Name != "")
            {
                txtnama_alat_kerja.Text = Thread.CurrentPrincipal.Identity.Name;
                infonama_alat_kerja.Text = "Sesuai";
                infonama_alat_kerja.ForeColor = System.Drawing.Color.Green;
            }
        }
    }
}
