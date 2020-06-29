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
    public partial class RestockAlatKerja : UserControl
    {
        private int selected = 0;
        private int selectedTransaksi = -1;
        private int newJumlah = 0, newBagus = 0, newRusak = 0;
        private string id_restock = "";

        public RestockAlatKerja()
        {
            InitializeComponent();
            addDataAlatKerja();
            addSourcePelayan();
        }

        private void addSourcePelayan()
        {
            txtPelayan.AutoCompleteCustomSource = null;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_pelayan from msbagianpelayan", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            txtPelayan.AutoCompleteCustomSource = collection;
            txtPelayan.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPelayan.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        public void addDataAlatKerja()
        {
            tbAlatKerja.DataSource = null;
            tbAlatKerja.Columns.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);

                SqlCommand myCommand = new SqlCommand("sp_getAllAlatKerja", connection);
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
   
                DataTable data = new DataTable();
                adapter.SelectCommand = myCommand;
                adapter.Fill(data);

                tbAlatKerja.DataSource = data;

                foreach (DataGridViewColumn col in tbAlatKerja.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                this.tbAlatKerja.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tbAlatKerja.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tbAlatKerja.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tbAlatKerja.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tbAlatKerja.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.tbAlatKerja.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tbAlatKerja.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tbAlatKerja.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void addDataSupplier(String alatKerja)
        {
            tbSupplier.Columns.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter("select distinct ROW_NUMBER() over(order by harga asc) No, [mssupplier].nama_supplier, "+
                    "convert(numeric(10, 2), harga) as [Harga(Rp)] from[msalatsupplier] aks inner join[msalatkerja] ak "+
                    "on aks.id_alat = ak.id_alat inner join[mssupplier] on[mssupplier].id_supplier = aks.id_supplier where ak.nama_alat = '" 
                    + alatKerja + "'", connection);

                DataTable data = new DataTable();
                adapter.Fill(data);

                tbSupplier.DataSource = data;

                foreach (DataGridViewColumn col in tbSupplier.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                this.tbSupplier.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tbSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tbSupplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                

                this.tbSupplier.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private string getIDPelayan(string nama_pelayan)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariPelayan", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_pelayan", "XX");
                myCommand.Parameters.AddWithValue("nama_pelayan", nama_pelayan);
                myCommand.Parameters.AddWithValue("jenis_kelamin", "x");
                myCommand.Parameters.AddWithValue("alamat", "x");
                myCommand.Parameters.AddWithValue("email", "x");
                myCommand.Parameters.AddWithValue("no_telepon", "x");
                myCommand.Parameters.AddWithValue("status", "x");

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                connection.Close();
                return output;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private void insertDataTransaksi()
        {
            DataGridViewRow row = tbSupplier.Rows[selected];
            int no = Convert.ToInt32(tbTransaksi.Rows.Count.ToString());
            String alakerja = lblAlatKerja.Text;
            String supp = txtSupplier.Text;
            String harga = (row.Cells[2].Value.ToString()).Substring(0, (row.Cells[2].Value.ToString()).Length -3);
            String total = Convert.ToString(Convert.ToInt32(harga) * Convert.ToInt32(txtJumlah.Text));
            String jumlah = txtJumlah.Text;

            tbTransaksi.Rows.Add(no+1 , alakerja, supp , harga , jumlah, total);

            foreach (DataGridViewColumn col in tbTransaksi.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.tbTransaksi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbTransaksi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbTransaksi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbTransaksi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbTransaksi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tbTransaksi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.tbTransaksi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.tbTransaksi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tbTransaksi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void perapihan()
        {
            int i = 1;
           
            foreach (DataGridViewRow row in tbTransaksi.Rows)
            {
                tbTransaksi[0,i-1].Value = i.ToString();
                i++;
            }
        }
        private void clear()
        {
            txtSupplier.Text = "";
            txtJumlah.Text = "0";
            lblTotal.Text = "0";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            
            Int32 selectedRow = tbAlatKerja.Rows.GetRowCount(DataGridViewElementStates.Selected);

            Int32 select = 0;
            for (int i = 0; i < selectedRow; i++)
            {
                select = Int32.Parse(tbAlatKerja.SelectedRows[i].Index.ToString());
            }
            DataGridViewRow row = tbAlatKerja.Rows[select];
            addDataSupplier(row.Cells[1].Value.ToString());
            lblAlatKerja.Text = row.Cells[1].Value.ToString();

        }

        private void tbSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = tbSupplier.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRow > 0 && selectedRow <= 1)
            {
                for (int i = 0; i < selectedRow; i++)
                {
                    selected = Int32.Parse(tbSupplier.SelectedRows[i].Index.ToString());
                }
                DataGridViewRow row = tbSupplier.Rows[selected];
                txtSupplier.Text = row.Cells[1].Value.ToString();
            }
        }

        private void tbAlatKerja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = tbAlatKerja.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRow > 0 && selectedRow <= 1)
            {
                btnCari.Enabled = true;
            }
            else
            {
                btnCari.Enabled = false;
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            txtJumlah.Text = (Convert.ToInt16(txtJumlah.Text) + 1).ToString();
            if (!txtJumlah.Text.Equals("0"))
            {
                btnMin.Enabled = true;
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            txtJumlah.Text = (Convert.ToInt16(txtJumlah.Text) - 1).ToString();
            if (txtJumlah.Text.Equals("0"))
            {
                btnMin.Enabled = false;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtJumlah.Text.Equals("0") || txtSupplier.Text.Equals(""))
            {
                return;
            }
            insertDataTransaksi();
            clear();
            hitungTotal();
        }

        private void tbTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = tbTransaksi.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRow > 0 && selectedRow <= 1)
            {
                for (int i = 0; i < selectedRow; i++)
                {
                    selectedTransaksi = Int32.Parse(tbTransaksi.SelectedRows[i].Index.ToString());
                }

                btnBatal.Enabled = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DataGridViewRow del = tbTransaksi.Rows[selectedTransaksi];
            tbTransaksi.Rows.Remove(del);
           
            btnBatal.Enabled = false;
            perapihan();
            hitungTotal();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbTransaksi.Rows.Clear();
            hitungTotal();
        }

        private void hitungTotal()
        {
            int total = 0;
            for(int i = 0; i < tbTransaksi.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(tbTransaksi[5, i].Value);
            }
            lblTotal.Text = total.ToString();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {   if(tbTransaksi.Rows.Count == 0)
            {
                return;
            }

            string checker = null;
            Boolean cek = false;
            if (txtPelayan.Text == "")
            {
                checker += "Kolom Pelayan Harap Diisi!";
                cek = false;
            }
            else if (getIDPelayan(txtPelayan.Text) == "")
            {
                checker += "Nama Pelayan Tidak Valid";
                cek = false;
            }
            else
            {
                cek = true;
            }

            if (cek)
            {
                try
                {
                    string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand myCommand = new SqlCommand("sp_inputTRestockAlatKerja", connection);

                    myCommand.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    id_restock = "TRA-" + getLastID();
                    myCommand.Parameters.AddWithValue("no_transaksi_pembelian", id_restock);
                    myCommand.Parameters.AddWithValue("id_pelayan", getIDPelayan(txtPelayan.Text));
                    myCommand.Parameters.AddWithValue("tanggal_pembelian", DateTime.Now.ToString("yyyy-MM-dd"));
                    myCommand.Parameters.AddWithValue("total", lblTotal.Text);

                    myCommand.ExecuteNonQuery();
                    connection.Close();

                    detailtransaksi();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error btnBayar_Click : " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show(checker + "Periksa Kembali Data!\nData Ada Yang Tidak Valid/Kosong",
                    "Data Tidak Valid", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            addDataAlatKerja();
        }

        private void getInfoAlat(string id_alat)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatKerja", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_alat", id_alat);
                myCommand.Parameters.AddWithValue("nama_alat", "x");
                myCommand.Parameters.AddWithValue("jumlah", -1);
                myCommand.Parameters.AddWithValue("rusak", -1);
                myCommand.Parameters.AddWithValue("bagus", -1);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                newJumlah = int.Parse(data.Rows[0][2].ToString());
                newBagus = int.Parse(data.Rows[0][4].ToString());
                newRusak = int.Parse(data.Rows[0][3].ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());

                return;
            }
        }

        private void detailtransaksi()
        {
            for (int i = 0; i < tbTransaksi.Rows.Count; i++)
            {
                try
                {
                    string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand myCommand = new SqlCommand("sp_inputTDRestockAlatKerja", connection);

                    myCommand.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    myCommand.Parameters.AddWithValue("no_transaksi_pembelian", id_restock);
                    myCommand.Parameters.AddWithValue("id_supplier", getIDSupplier(tbTransaksi[2, i].Value.ToString()));
                    myCommand.Parameters.AddWithValue("id_alat", getIDAlatKerja(tbTransaksi[1, i].Value.ToString()));
                    myCommand.Parameters.AddWithValue("jumlah", tbTransaksi[4, i].Value);
                    myCommand.Parameters.AddWithValue("harga", tbTransaksi[5, i].Value);

                    myCommand.ExecuteNonQuery();
                    connection.Close();

                    updateStock(i);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error btnBayar_Click : " + ex.ToString());
                }
            }
            MessageBox.Show("Berhasil memproses ..");
            tbTransaksi.Rows.Clear();
            tbSupplier.DataSource = null;
            
            clear();
            lblAlatKerja.Text = "[Alat Kerja]";
        }
        
        private void updateStock(int column)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_updateAlatKerja", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                getInfoAlat(getIDAlatKerja(tbTransaksi[1, column].Value.ToString()));

                newJumlah += int.Parse(tbTransaksi[4, column].Value.ToString());
                newBagus += int.Parse(tbTransaksi[4, column].Value.ToString());

                myCommand.Parameters.AddWithValue("id_alat", getIDAlatKerja(tbTransaksi[1, column].Value.ToString()));
                myCommand.Parameters.AddWithValue("nama_alat", tbTransaksi[1, column].Value.ToString());
                myCommand.Parameters.AddWithValue("jumlah", newJumlah.ToString());
                myCommand.Parameters.AddWithValue("rusak", newRusak.ToString());
                myCommand.Parameters.AddWithValue("bagus", newBagus.ToString());
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }
        }

        private string getIDAlatKerja(string nama_alat)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatKerja", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_alat", "XX");
                myCommand.Parameters.AddWithValue("nama_alat", nama_alat);
                myCommand.Parameters.AddWithValue("jumlah", -1);
                myCommand.Parameters.AddWithValue("rusak", -1);
                myCommand.Parameters.AddWithValue("bagus", -1);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());

                return null;
            }
        }
        private string getIDSupplier(string nama_supplier)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariSupplier", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
 
                myCommand.Parameters.AddWithValue("id_supplier", "XX");
                myCommand.Parameters.AddWithValue("nama_supplier", nama_supplier);
                myCommand.Parameters.AddWithValue("@contact_person", "x");
                myCommand.Parameters.AddWithValue("@no_telepon", "x");
                myCommand.Parameters.AddWithValue("@alamat", "x");
                myCommand.Parameters.AddWithValue("@keterangan", "x");

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                return output;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());

                return null;
            }
        }
        private string getLastID()
        {
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
            SqlConnection connection = new SqlConnection(connectionString);

            SqlDataAdapter adapter = new SqlDataAdapter("select count (no_transaksi_pembelian) from trestockalatkerja", connection);

            DataSet data = new DataSet();
            adapter.Fill(data);

            //mengambil data jumlah
            int count = (int)data.Tables[0].Rows[0][0];
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

        private void btnTambahPelayan_Click(object sender, EventArgs e)
        {
            TambahPekerja pelayan = new TambahPekerja();
            pelayan.ShowDialog(this);
            addSourcePelayan();
        }
    }
}
