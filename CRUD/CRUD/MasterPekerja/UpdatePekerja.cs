using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class UpdatePekerja : Form
    {
        private BindingSource bsPekerja = new BindingSource();
        private Boolean cek = false;
        private string jenis_kelamin;
        public UpdatePekerja()
        {
            InitializeComponent();
            clear1();
            clear2();
            txtNama.MaxLength = 50;
            txtAlamat.MaxLength = 100;
            txtEmail.MaxLength = 30;
            txtTelepon.MaxLength = 13;
        }

        private void UpdatePekerja_Load(object sender, EventArgs e)
        {
            dgPekerja.DataSource = bsPekerja;
        }

        private void getData(string command)
        {
            try
            {
                //String connectionString = ConfigurationSettings.AppSettings["constring1"];
                //punya teddy
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter = new SqlDataAdapter(command, connectionString);

               SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable
                {
                    Locale = CultureInfo.InvariantCulture
                };
                dataAdapter.Fill(table);
                bsPekerja.DataSource = table;

                dgPekerja.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCells);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmbPekerja_TextChanged(object sender, EventArgs e)
        {
            if (cmbPekerja.Text == "Pelayan")
            {
                setPelayan();
                lblBagian.Text = "ID Pelayan";
                lblNama.Text = "Nama Pelayan";
                dgPekerja.Enabled = true;
                cmbPencarian.Enabled = true;
                txtPencarian.Enabled = true;
                btnSegarkan.Enabled = true;
                label4.Enabled = true;
            }
            else if(cmbPekerja.Text == "Gudang")
            {
                setGudang();
                lblBagian.Text = "ID Gudang";
                lblNama.Text = "Nama Gudang";
                dgPekerja.Enabled = true;
                cmbPencarian.Enabled = true;
                txtPencarian.Enabled = true;
                btnSegarkan.Enabled = true;
                label4.Enabled = true;
            }
            else
            {
                clear1();
            }
        }

        private void setGudang()
        {
            getData("select * from msbagiangudang");
            dgPekerja.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgPekerja.EnableHeadersVisualStyles = false;
            dgPekerja.Columns[0].HeaderText = "ID Gudang";
            dgPekerja.Columns[1].HeaderText = "Nama Gudang";
            dgPekerja.Columns[2].HeaderText = "Jenis Kelamin";
            dgPekerja.Columns[3].HeaderText = "Alamat";
            dgPekerja.Columns[4].HeaderText = "Email";
            dgPekerja.Columns[5].HeaderText = "No Telepon";
            dgPekerja.Columns[6].HeaderText = "Status";
        }

        private void setPelayan()
        {
            getData("select * from msbagianpelayan");
            dgPekerja.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            dgPekerja.EnableHeadersVisualStyles = false;
            dgPekerja.Columns[0].HeaderText = "ID Pelayan";
            dgPekerja.Columns[1].HeaderText = "Nama Pelayan";
            dgPekerja.Columns[2].HeaderText = "Jenis Kelamin";
            dgPekerja.Columns[3].HeaderText = "Alamat";
            dgPekerja.Columns[4].HeaderText = "Email";
            dgPekerja.Columns[5].HeaderText = "No Telepon";
            dgPekerja.Columns[6].HeaderText = "Status";
        }

        private void txtPencarian_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //string connectionString = ConfigurationSettings.AppSettings["constring1"];
                //punya teddy
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                connection.Open();
                string pencarian = txtPencarian.Text;
                SqlCommand myCommand = null;

                if (cmbPekerja.Text == "Pelayan")
                {
                    myCommand = new SqlCommand("sp_cariPelayan", connection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("id_pelayan", pencarian);
                    myCommand.Parameters.AddWithValue("nama_pelayan", pencarian);
                    myCommand.Parameters.AddWithValue("jenis_kelamin", pencarian);
                    myCommand.Parameters.AddWithValue("alamat", pencarian);
                    myCommand.Parameters.AddWithValue("email", pencarian);
                    myCommand.Parameters.AddWithValue("no_telepon", pencarian);
                    myCommand.Parameters.AddWithValue("status", pencarian);
                }
                else if (cmbPekerja.Text == "Gudang")
                {
                    myCommand = new SqlCommand("sp_cariGudang", connection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("id_gudang", pencarian);
                    myCommand.Parameters.AddWithValue("nama_gudang", pencarian);
                    myCommand.Parameters.AddWithValue("jenis_kelamin", pencarian);
                    myCommand.Parameters.AddWithValue("alamat", pencarian);
                    myCommand.Parameters.AddWithValue("email", pencarian);
                    myCommand.Parameters.AddWithValue("no_telepon", pencarian);
                    myCommand.Parameters.AddWithValue("status", pencarian);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                lblId.Text = data.Rows[0][0].ToString();
                txtNama.Text = data.Rows[0][1].ToString();
                jenis_kelamin = data.Rows[0][2].ToString();
                txtAlamat.Text = data.Rows[0][3].ToString();
                txtEmail.Text = data.Rows[0][4].ToString();
                txtTelepon.Text = data.Rows[0][5].ToString();
                cmbStatus.Text = data.Rows[0][6].ToString();

                if (jenis_kelamin == "Laki-laki")
                {
                    rbLakilaki.Checked = true;
                    rbPerempuan.Checked = false;
                }
                else if (jenis_kelamin == "Perempuan")
                {
                    rbLakilaki.Checked = false;
                    rbPerempuan.Checked = true;
                }
                
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

        private void refresh()
        {
            if (cmbPekerja.Text == "Pelayan")
            {
                setPelayan();
            }
            else if (cmbPekerja.Text == "Gudang")
            {
                setGudang();
            }
        }

        private void clear1()
        {
            cmbPekerja.SelectedItem = null;
            cmbPekerja.Text = "--Pilih--";
            dgPekerja.Enabled = false;
            cmbPencarian.Enabled = false;
            txtPencarian.Enabled = false;
            btnPerbarui.Enabled = false;
            btnBatal.Enabled = false;
            btnSegarkan.Enabled = false;
            label4.Enabled = false;
        }

        private void clear2()
        {
            cek = false;
            cmbPencarian.SelectedItem = null;
            cmbPencarian.Text = "--Pilih--";
            txtPencarian.Text = "";
            lblId.Text = "";
            txtNama.Text = "";
            rbLakilaki.Checked = false;
            rbPerempuan.Checked = false;
            txtAlamat.Text = "";
            txtEmail.Text = "";
            txtTelepon.Text = "";
            cmbStatus.SelectedItem = null;
            cmbStatus.Text = "";
            gbUpdate.Enabled = false;
            btnPerbarui.Enabled = false;
            btnBatal.Enabled = false;
        }

        private void cmbPencarian_TextChanged(object sender, EventArgs e)
        {
            if (cmbPekerja.Text == "Pelayan")
            {
                switch (cmbPencarian.Text)
                {
                    case "ID Pekerja": sourceFilter("id_pelayan"); break;
                    case "Nama Pekerja": sourceFilter("nama_pelayan"); break;
                    case "Jenis Kelamin": sourceFilter("jenis_kelamin"); break;
                    case "Alamat": sourceFilter("alamat"); break;
                    case "Email": sourceFilter("email"); break;
                    case "No Telepon": sourceFilter("no_telepon"); break;
                    case "Status": sourceFilter("status"); break;
                }
            }
            else if (cmbPekerja.Text == "Gudang")
            {
                switch (cmbPencarian.Text)
                {
                    case "ID Pekerja": sourceFilter("id_gudang"); break;
                    case "Nama Pekerja": sourceFilter("nama_gudang"); break;
                    case "Jenis Kelamin": sourceFilter("jenis_kelamin"); break;
                    case "Alamat": sourceFilter("alamat"); break;
                    case "Email": sourceFilter("email"); break;
                    case "No Telepon": sourceFilter("no_telepon"); break;
                    case "Status": sourceFilter("status"); break;
                }
            }
        }

        private void dgPekerja_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    gbUpdate.Enabled = false;
            //    btnBatal.Enabled = false;
            //    int selectedRow = 0;
            //    Int32 selectedRowCount = dgPekerja.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //    if (selectedRowCount > 0 && selectedRowCount <= 1)
            //    {
            //        btnPerbarui.Enabled = true;
            //        clear2();

            //        for (int i = 0; i < selectedRowCount; i++)
            //        {
            //            selectedRow = Int32.Parse(dgPekerja.SelectedRows[i].Index.ToString());
            //        }
            //        DataGridViewRow row = dgPekerja.Rows[selectedRow];

            //        lblId.Text = row.Cells[0].Value.ToString();
            //        txtNama.Text = row.Cells[1].Value.ToString();
            //        jenis_kelamin = row.Cells[2].Value.ToString();
            //        txtAlamat.Text = row.Cells[3].Value.ToString();
            //        txtEmail.Text = row.Cells[4].Value.ToString();
            //        txtTelepon.Text = row.Cells[5].Value.ToString();
            //        cmbStatus.Text = row.Cells[6].Value.ToString();

            //        if (jenis_kelamin == "Laki-laki")
            //        {
            //            rbLakilaki.Checked = true;
            //            rbPerempuan.Checked = false;
            //        }
            //        else if (jenis_kelamin == "Perempuan")
            //        {
            //            rbLakilaki.Checked = false;
            //            rbPerempuan.Checked = true;
            //        }
            //        btnPerbarui.Enabled = true;
            //    }
            //    else
            //    {
            //        btnPerbarui.Enabled = false;
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show("Data tidak valid", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //    btnPerbarui.Enabled = false;
            //}
        }

        private void btnPerbarui_Click(object sender, EventArgs e)
        {
            btnBatal.Enabled = true;
            btnPerbarui.Enabled = false;
            gbUpdate.Enabled = true;
        }

        private void sourceFilter(string filter)
        {

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            //string connectionString = ConfigurationSettings.AppSettings["constring1"];
            //punya teddy
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = null;
            if (cmbPekerja.Text == "Pelayan")
            {
                adapter = new SqlDataAdapter("select " + filter + " from msbagianpelayan", connection);
            }
            else if (cmbPekerja.Text == "Gudang")
            {
                adapter = new SqlDataAdapter("select " + filter + " from msbagiangudang", connection);
            }
            //memasukkan ke dataset
            DataSet mspekerja = new DataSet();
            adapter.Fill(mspekerja);

            for (int i = 0; i < mspekerja.Tables[0].Rows.Count; i++)
            {

                collection.Add(mspekerja.Tables[0].Rows[i][0].ToString());
            }
            txtPencarian.AutoCompleteCustomSource = collection;
            txtPencarian.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPencarian.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnSimpan_MouseEnter(object sender, EventArgs e)
        {
            if (cek)
            {
                btnSimpan.Enabled = true;
            }
            else
            {
                btnSimpan.Enabled = false;
            }
        }

        private void btnSimpan_Leave(object sender, EventArgs e)
        {
            btnSimpan.Enabled = true;
        }

        private void updateDB()
        {
            try
            {

                //string connectionString = ConfigurationSettings.AppSettings["constring1"];
                //punya teddy
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);
                SqlCommand myCommand = null;

                myConnection.Open();

                if (cmbPekerja.Text == "Pelayan")
                {
                    myCommand = new SqlCommand("sp_updatePelayan", myConnection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    myCommand.Parameters.AddWithValue("id_pelayan", lblId.Text);
                    myCommand.Parameters.AddWithValue("nama_pelayan", txtNama.Text);
                    myCommand.Parameters.AddWithValue("jenis_kelamin", jenis_kelamin);
                    myCommand.Parameters.AddWithValue("alamat", txtAlamat.Text);
                    myCommand.Parameters.AddWithValue("email", txtEmail.Text);
                    myCommand.Parameters.AddWithValue("no_telepon", txtTelepon.Text);
                    myCommand.Parameters.AddWithValue("status", cmbStatus.SelectedItem);
                }
                else if (cmbPekerja.Text == "Gudang")
                {
                    myCommand = new SqlCommand("sp_updateGudang", myConnection);
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
                MessageBox.Show("Data berhasil diperbarui!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                clear2();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear2();
        }

        private void btnSegarkan_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string checker = null;

            if (txtNama.Text == "")
            {
                cek = false;
                checker += "Kolom nama harap diisi\n";
            }
            else
            {
                cek = true;
            }

            if (txtAlamat.Text == "")
            {
                cek = false;
                checker += "Kolom alamat harap diisi\n";
            }
            else
            {
                cek = true;
            }

            if (txtEmail.Text == "")
            {
                cek = false;
                checker += "Kolom email harap diisi\n";
            }
            else if (Regex.IsMatch(txtEmail.Text, @"^^[^@\s]+@[^@\s]+(\.[^@\s]+)+$"))
            {
                cek = true;
            }
            else
            {
                cek = false;
                checker += "Format email salah (aaa@bbb.ccc)\n";
            }

            if (txtTelepon.Text == "")
            {
                cek = false;
                checker += "Kolom nomor telepon harap diisi\n";
            }
            else
            {
                cek = true;
            }

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
                if (cmbPekerja.Text == "Pelayan")
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
                else if (cmbPekerja.Text == "Gudang")
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
                    updateDB();
                    if (cmbPekerja.Text == "Pelayan")
                    {
                        setPelayan();
                    }
                    else if (cmbPekerja.Text == "Gudang")
                    {
                        setGudang();
                    }
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

        private void dgPekerja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnPerbarui.Enabled = false;
            btnBatal.Enabled = false;
            int i = e.RowIndex;
            if(i == -1)
            {
                return;
            }
            dgPekerja.Rows[i].Selected = true;
            btnPerbarui.Enabled = true;
            btnBatal.Enabled = true;
            lblId.Text = dgPekerja.Rows[i].Cells[0].Value.ToString();
            txtNama.Text = dgPekerja.Rows[i].Cells[1].Value.ToString();
            jenis_kelamin = dgPekerja.Rows[i].Cells[2].Value.ToString();
            txtAlamat.Text = dgPekerja.Rows[i].Cells[3].Value.ToString();
            txtEmail.Text = dgPekerja.Rows[i].Cells[4].Value.ToString();
            txtTelepon.Text = dgPekerja.Rows[i].Cells[5].Value.ToString();
            cmbStatus.Text = dgPekerja.Rows[i].Cells[6].Value.ToString();
            if (jenis_kelamin == "Laki-laki")
            {
                rbLakilaki.Checked = true;
                rbPerempuan.Checked = false;
            }
            else if (jenis_kelamin == "Perempuan")
            {
                rbLakilaki.Checked = false;
                rbPerempuan.Checked = true;
            }

        }
    }
}
