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
    public partial class beliKomponen : UserControl
    {
        private int selectedKomponen = 0;
        private int selectedDaftarBeli = 0;
        private string id_transaksi = "";
        public Boolean berhasil = false;
        public beliKomponen()
        {
            InitializeComponent();
            addDataKomponen();
            addSourceNama();

        }
        public void addDataKomponen()
        {
            tableKomponen.DataSource = null;
            tableKomponen.Columns.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_getAllKomponen", connection);
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable data = new DataTable();
                adapter.SelectCommand = myCommand;
                adapter.Fill(data);

                tableKomponen.DataSource = data;

                for (int i = 0; i < tableKomponen.Columns.Count; i++)
                {
                        this.tableKomponen.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        this.tableKomponen.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                this.tableKomponen.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableKomponen.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableKomponen.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableKomponen.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableKomponen.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                this.tableKomponen.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.tableKomponen.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //by = 1;
                connection.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //btnUpdate.Enabled = false;
                //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                //clear();
            }
        }

        

        private void beliKomponen_Load(object sender, EventArgs e)
        {

        }

        private void addSourceNama()
        {
            txtPelanggan.AutoCompleteCustomSource = null;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_customer from mscustomer", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            txtPelanggan.AutoCompleteCustomSource = collection;
            txtPelanggan.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPelanggan.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnTambahPelanggan_Click(object sender, EventArgs e)
        {
            CustomerMaster cus = new CustomerMaster(txtPelanggan.Text);
            cus.ShowDialog(this);
            addSourceNama();
        }

        private void txtPelanggan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                picPelanggan.Image = Image.FromFile(getPathCustomer(txtPelanggan.Text));
                picPelanggan.SizeMode = PictureBoxSizeMode.StretchImage;
                lblFoto.Text = "";
            }
            catch (Exception ex)
            {
                picPelanggan.Image = null;
                lblFoto.Text = "Tidak tersedia";
            }
        }
        private string getPathCustomer(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariCustomer", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_customer", "XX");
                myCommand.Parameters.AddWithValue("nama_customer", inx);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][3].ToString();
                return output;

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error getIDKomponen : " + ex.ToString());

                return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            Int32 selectedRow = tableKomponen.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (txtJumlah.Text.Equals("0") || txtKomponen.Text.Equals("") || txtPelanggan.Text.Equals(""))
            {
                return;
            }
            if(selectedRow < 0 && selectedRow > 1)
            {
                return;
            }
            for (int i = 0; i < selectedRow; i++)
            {
                selectedKomponen = Int32.Parse(tableKomponen.SelectedRows[i].Index.ToString());
            }
            insertDataTransaksi();
            clear();
        }
        private void clear()
        {
            txtJumlah.Text = "";
            txtKomponen.Text = "";
        }
        private void clearAll()
        {
            clear();
            txtPelanggan.Text = "";
            txtTotal.Text = "0";
        }
        private void insertDataTransaksi()
        {
            DataGridViewRow row = tableKomponen.Rows[selectedKomponen];
            int no = Convert.ToInt32(tableDaftarBeli.Rows.Count.ToString());
            String komponen = row.Cells[1].Value.ToString();
            String barang = row.Cells[2].Value.ToString();
            String harga = row.Cells[3].Value.ToString();
            String jumlah = txtJumlah.Text;
            String total = Convert.ToString(Convert.ToInt32(harga.Substring(0, (harga.ToString()).Length - 3)) * Convert.ToInt32(txtJumlah.Text));

            txtTotal.Text = (Convert.ToInt32(total) + Convert.ToInt32(txtTotal.Text)).ToString();

            //MessageBox.Show(no + komponen + barang + harga + total + jumlah);
            tableDaftarBeli.Rows.Add(no + 1, komponen, barang, harga, jumlah, total);

            foreach (DataGridViewColumn col in tableDaftarBeli.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.tableDaftarBeli.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tableDaftarBeli.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableDaftarBeli.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tableDaftarBeli.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableDaftarBeli.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableDaftarBeli.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.tableDaftarBeli.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.tableDaftarBeli.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tableDaftarBeli.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        
        private void tableKomponen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selected = tableKomponen.Rows.GetRowCount(DataGridViewElementStates.Selected);
            txtJumlah.Text = "0";
            if(selected > 0 && selected <= 1)
            {
                int select = 0;
                for(int i = 0; i<selected; i++)
                {
                    select = Int32.Parse(tableKomponen.SelectedRows[i].Index.ToString());
                }
                DataGridViewRow row = tableKomponen.Rows[select];
                txtKomponen.Text = row.Cells[1].Value.ToString();
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

        private void tableDaftarBeli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = tableDaftarBeli.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if (selectedRow > 0 && selectedRow <= 1)
            {
                for (int i = 0; i < selectedRow; i++)
                {
                    selectedDaftarBeli = Int32.Parse(tableDaftarBeli.SelectedRows[i].Index.ToString());
                }
                btnBatal.Enabled = true;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow del = tableDaftarBeli.Rows[selectedDaftarBeli];
            tableDaftarBeli.Rows.Remove(del);

            perapihan();
            hitungTotal();
            if (tableDaftarBeli.Rows.Count == 0)
            {
                btnBatal.Enabled = false;
            }
        }
        private void hitungTotal()
        {
            int total = 0;
            for (int i = 0; i < tableDaftarBeli.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(tableDaftarBeli[5, i].Value);
            }
            txtTotal.Text = total.ToString();
        }
        private void perapihan()
        {
            int i = 1;

            foreach (DataGridViewRow row in tableDaftarBeli.Rows)
            {
                tableDaftarBeli[0, i - 1].Value = i.ToString();
                i++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tableDaftarBeli.Rows.Clear();
            hitungTotal();
            btnBatal.Enabled = false;
        }

        private void btnLanjutkan_Click(object sender, EventArgs e)
        {
            if (txtTotal.Text.Equals("0"))
            {
                return;
            }

            Pembayaran pembayaran = new Pembayaran();
            pembayaran.txtTagihan.Text = txtTotal.Text;
            pembayaran.ShowDialog(this);
            

            if (pembayaran.berhasil)
            {
                MessageBox.Show("Transaksi berhasil!\n" +
                                "Tagihan      : Rp "+txtTotal.Text+ "\n"+
                                "Uang dibayar : Rp " +pembayaran.txtUang.Text+ "\n"+
                                "Kembalian    : Rp " +pembayaran.kembalian,"Informasi",MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                return;
            }

                try
                {
                    string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand myCommand = new SqlCommand("sp_inputTBeliKomponen", connection);


                    myCommand.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                
                    id_transaksi = "tbk-" + getLastID();
                    myCommand.Parameters.AddWithValue("no_transaksi_pembelian", id_transaksi);
                    myCommand.Parameters.AddWithValue("tanggal_transaksi", DateTime.Now.ToString("yyyyMMdd"));
                    myCommand.Parameters.AddWithValue("jumlah_komponen", hitungJumlahKomponen());
                    myCommand.Parameters.AddWithValue("total_jenis", tableDaftarBeli.RowCount);
                    myCommand.Parameters.AddWithValue("total_harga", txtTotal.Text);
                    myCommand.Parameters.AddWithValue("id_pelayan", getIDPelayan(txtPelayan.Text));
                    myCommand.Parameters.AddWithValue("id_customer", getIDPelanggan(txtPelanggan.Text));


                    myCommand.ExecuteNonQuery();
                    connection.Close();

                    detailtransaksi();
                    //by = 1;

                    //btnUpdate.Enabled = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error btnBayar_Click : " + ex.ToString());


                    //btnUpdate.Enabled = false;
                    //clear();
                }
        }
        private void detailtransaksi()
        {
            for (int i = 0; i < tableDaftarBeli.Rows.Count; i++)
            {
                try
                {
                    string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand myCommand = new SqlCommand("sp_inputTDetailBeliKomponen", connection);


                    myCommand.CommandType = CommandType.StoredProcedure;


                    
		 

                    connection.Open();

                    myCommand.Parameters.AddWithValue("no_transaksi_pembelian", id_transaksi);
                    myCommand.Parameters.AddWithValue("id_komponen", getIDKomponen(tableDaftarBeli[1, i].Value.ToString()));
                    myCommand.Parameters.AddWithValue("jumlah", tableDaftarBeli[4, i].Value);
                    myCommand.Parameters.AddWithValue("total_harga", tableDaftarBeli[5, i].Value);

                    myCommand.ExecuteNonQuery();
                    connection.Close();




                    //by = 1;

                    //btnUpdate.Enabled = true;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error detailtransaksi : " + ex.ToString());


                    //btnUpdate.Enabled = false;
                    //clear();
                }
            }
            MessageBox.Show("Berhasil memproses transaksi..");
            tableDaftarBeli.Rows.Clear();
            


            clearAll();
            txtKomponen.Text = "";
        }
        private int hitungJumlahKomponen()
        {
            int total = 0;
            for (int i = 0; i < tableDaftarBeli.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(tableDaftarBeli[4, i].Value);
            }
            return total;
        }
        private string getIDKomponen(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariKomponen", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_komponen", "XX");
                myCommand.Parameters.AddWithValue("nama_komponen", inx);
                myCommand.Parameters.AddWithValue("jumlah", -1);
                myCommand.Parameters.AddWithValue("harga_jual", -1);
                myCommand.Parameters.AddWithValue("id_alat", "x");
                myCommand.Parameters.AddWithValue("tempat", "x");

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                return output;

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getIDKomponen : " + ex.ToString());

                return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }
        private string getIDPelayan(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariPelayan", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                
                myCommand.Parameters.AddWithValue("id_pelayan", "XX");
                myCommand.Parameters.AddWithValue("nama_pelayan", inx);
                myCommand.Parameters.AddWithValue("jenis_kelamin", "x");
                myCommand.Parameters.AddWithValue("alamat", "x");
                myCommand.Parameters.AddWithValue("email", "x");
                myCommand.Parameters.AddWithValue("no_telepon", "x");
                myCommand.Parameters.AddWithValue("status", "x");

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                return output;

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getIDPelayan : " + ex.ToString());

                return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }
        private string getIDPelanggan(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariCustomer", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_customer", "XX");
                myCommand.Parameters.AddWithValue("nama_customer", inx);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                return output;

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error getIDKomponen : " + ex.ToString());

                return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }
        private string getLastID()
        {
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select count (no_transaksi_pembelian) from tbelikomponen", connection);
            //memasukkan ke dataset
            DataSet mscustomer = new DataSet();
            adapter.Fill(mscustomer);

            //mengambil data jumlah
            int count = (int)mscustomer.Tables[0].Rows[0][0];
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
    }
}
