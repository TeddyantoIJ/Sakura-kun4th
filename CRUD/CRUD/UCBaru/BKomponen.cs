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
using System.Globalization;
using System.Text.RegularExpressions;

namespace CRUD.UCBaru
{
    public partial class BKomponen : UserControl
    {
        private String txtKomponen = "";
        private String txtAlat = "";
        private String id_transaksi = "";
        public string id_karyawan = "";


        public BKomponen()
        {
            
            InitializeComponent();

            addDataKomponen();
            addSourceNama();
            txtTanggal.Text = DateTime.Now.ToString("dd-MM-yyyy");

            //elipse
            bunifuElipse.ApplyElipse(panelKomponen, 15);
            bunifuElipse.ApplyElipse(panelTransaksi, 15);
            bunifuElipse.ApplyElipse(panelTengah, 15);
            bunifuElipse.ApplyElipse(panelTengah1, 15);
            bunifuElipse.ApplyElipse(panelKerajang, 15);
        }
        private void addSourceNama()
        {
            nama_pelanggan.AutoCompleteCustomSource = null;

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
            nama_pelanggan.AutoCompleteCustomSource = collection;
            nama_pelanggan.AutoCompleteMode = AutoCompleteMode.Suggest;
            nama_pelanggan.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

                DataTable dtCloned = data.Clone();
                dtCloned.Columns[3].DataType = typeof(String);
                foreach (DataRow row in data.Rows)
                {
                    dtCloned.ImportRow(row);
                }

                tableKomponen.DataSource = dtCloned;

                foreach (DataGridViewColumn col in tableKomponen.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //    col.HeaderCell.Style.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Pixel);
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                this.tableKomponen.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableKomponen.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableKomponen.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableKomponen.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableKomponen.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                this.tableKomponen.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.tableKomponen.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //by = 1;

                connection.Close();

                for (int i = 0; i < tableKomponen.RowCount; i++)
                {
                    tableKomponen[3, i].Value = toRupiah(Convert.ToInt32(tableKomponen[3, i].Value.ToString().Substring(0, tableKomponen[3, i].Value.ToString().Length - 3)));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //btnUpdate.Enabled = false;
                //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                //clear();
            }
        }
        public string toRupiah(Int32 angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "{0:N}", angka);
        }

        public int toAngka(string rupiah)
        {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }

        private void tableKomponen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tableKomponen[4,e.RowIndex].Value.ToString().Equals("0"))
            {
                return;
            }
            Int32 selectedRow = tableKomponen.SelectedCells.Count;
            int selectedrowindex = tableKomponen.SelectedCells[0].RowIndex;
            tableKomponen.Rows[selectedrowindex].Selected = true;
            DataGridViewRow row = tableKomponen.Rows[selectedrowindex];
            
            txtKomponen = row.Cells[1].Value.ToString();
            txtAlat = row.Cells[2].Value.ToString();
            insertKeranjang(row);
        }
        private void insertKeranjang(DataGridViewRow row)
        {
            
            int no = Convert.ToInt32(tableTransaksi.Rows.Count.ToString());
            string komponen = txtKomponen;
            string alat = txtAlat;
            string harga = row.Cells[3].Value.ToString();
            int total = 0;
            int jumlah = 1;
            string plus = "+";
            string minus = "-";
            string batal = "x";


            for (int i = 0; i < tableTransaksi.RowCount; i++)
            {
                if (tableTransaksi[1, i].Value.Equals(komponen) && tableTransaksi[2, i].Value.Equals(alat))
                {
                    return;
                }
            }

            this.tableTransaksi.Columns[6].CellTemplate.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.tableTransaksi.Columns[7].CellTemplate.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.tableTransaksi.Columns[8].CellTemplate.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);

            this.tableTransaksi.Columns[6].CellTemplate.Style.BackColor = Color.Green;
            this.tableTransaksi.Columns[7].CellTemplate.Style.BackColor = Color.Green;
            this.tableTransaksi.Columns[8].CellTemplate.Style.BackColor = Color.Red;
            foreach (DataGridViewColumn col in tableTransaksi.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }


            this.tableTransaksi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tableTransaksi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableTransaksi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableTransaksi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableTransaksi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tableTransaksi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

            this.tableTransaksi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.tableTransaksi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tableTransaksi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            


            tableTransaksi.Rows.Add(no + 1, komponen,alat, harga, jumlah, harga, plus, minus, batal);
            countTotal();
            countBarang();
            countJenis();
        }

        private void tableTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex >= 0 && e.ColumnIndex == 6)
            {
                //if (tableKomponen.SelectedRows.C) 
                for (int i = 0; i < tableKomponen.RowCount; i++)
                {
                    if (tableKomponen[1, i].Value.Equals(tableTransaksi[1,e.RowIndex].Value) && tableKomponen[2, i].Value.Equals(tableTransaksi[2, e.RowIndex].Value))
                    {
                        if(tableTransaksi[4, e.RowIndex].Value.ToString().Equals(tableKomponen[4, i].Value.ToString()))
                        {
                            return;
                        }
                    }
                }
                tableTransaksi[4, e.RowIndex].Value = (Convert.ToInt32(tableTransaksi[4, e.RowIndex].Value) + 1).ToString();
            }
            if (e.ColumnIndex >= 0 && e.ColumnIndex == 7)
            {
                if (tableTransaksi[4, e.RowIndex].Value.ToString() == "1")
                {
                    return;
                }
                tableTransaksi[4, e.RowIndex].Value = (Convert.ToInt32(tableTransaksi[4, e.RowIndex].Value) - 1).ToString();
            }
            tableTransaksi[5, e.RowIndex].Value = toRupiah(Convert.ToInt32(toAngka((tableTransaksi[3, e.RowIndex].Value).ToString()) * Convert.ToInt32(toAngka((tableTransaksi[4, e.RowIndex].Value).ToString()).ToString())));

            if (e.ColumnIndex >= 0 && e.ColumnIndex == 8)
            {
                tableTransaksi.Rows.RemoveAt(e.RowIndex);
            }
            perapihan();
            countTotal();
            countBarang();
            countJenis();
        }
        private void perapihan()
        {
            for (int i = 0; i < tableTransaksi.RowCount; i++)
            {
                tableTransaksi[0, i].Value = i + 1;
            }
        }
        private void countBarang()
        {
            int total = 0;
            for (int i = 0; i < tableTransaksi.RowCount; i++)
            {
                total = total + Convert.ToInt32(tableTransaksi[4, i].Value);
            }
            txtBarang.Text = total.ToString();
        }
        private void countJenis()
        {
            txtJenis.Text = (tableTransaksi.RowCount).ToString();
        }
        private void countTotal()
        {
            int total = 0;
            for (int i = 0; i < tableTransaksi.RowCount; i++)
            {
                total = total + Convert.ToInt32(toAngka((tableTransaksi[5, i].Value).ToString()));
            }
            txtTotal.Text = toRupiah(total);
        }

        private void nama_pelanggan_TextChanged(object sender, EventArgs e)
        {
            try
            {

                foto_pelanggan.Image = Image.FromFile(getPathCustomer(nama_pelanggan.Text));
                foto_pelanggan.SizeMode = PictureBoxSizeMode.StretchImage;
                lblFoto.Text = "";
                
            }
            catch (Exception ex)
            {
                foto_pelanggan.Image = null;
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

        private void btnReset_Click(object sender, EventArgs e)
        {
            for (int i = tableTransaksi.RowCount - 1; i >= 0; i--)
            {
                tableTransaksi.Rows.RemoveAt(i);
            }
            countBarang();
            countJenis();
            countTotal();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            
            if (toAngka(txtTotal.Text).Equals("0") || nama_pelanggan.Text.Equals(""))
            {
                MessageBox.Show("Masukkan data dengan benar", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Pembayaran pembayaran = new Pembayaran(txtTotal.Text);
            
            pembayaran.ShowDialog(this);
            if (pembayaran.berhasil)
            {
                MessageBox.Show("Transaksi berhasil...", "Informasi", MessageBoxButtons.OK,
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
                myCommand.Parameters.AddWithValue("jumlah_komponen", txtBarang.Text);
                myCommand.Parameters.AddWithValue("total_jenis", txtJenis.Text);
                myCommand.Parameters.AddWithValue("total_harga", toAngka(txtTotal.Text));
                myCommand.Parameters.AddWithValue("id_pelayan", id_karyawan);
                //myCommand.Parameters.AddWithValue("id_pelayan", "PLY-0001");
                myCommand.Parameters.AddWithValue("id_customer", getIDPelanggan(nama_pelanggan.Text));


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
            addDataKomponen();
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
        private void detailtransaksi()
        {
            for (int i = 0; i < tableTransaksi.Rows.Count; i++)
            {
                try
                {   //[sp_updateJumlahKomponen]

                    string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand myCommand = new SqlCommand("sp_inputTDetailBeliKomponen", connection);


                    myCommand.CommandType = CommandType.StoredProcedure;





                    connection.Open();

                    myCommand.Parameters.AddWithValue("no_transaksi_pembelian", id_transaksi);
                    myCommand.Parameters.AddWithValue("id_komponen", getIDKomponenByNamaDanID(tableTransaksi[1, i].Value.ToString(),i));
                    myCommand.Parameters.AddWithValue("jumlah", tableTransaksi[4, i].Value);
                    myCommand.Parameters.AddWithValue("total_harga", toAngka((String) tableTransaksi[5, i].Value));

                    //MessageBox.Show("ID Komponen : " + getIDKomponenByNamaDanID(tableTransaksi[1, i].Value.ToString(), i) + "\n" +
                    //            "ID Alat : " + getIDAlat(tableTransaksi[2, i].Value.ToString()) + "\n"+
                    //            "Nama Komponen : "+ tableTransaksi[1, i].Value.ToString() + "\n"+
                    //            "Nama Alat : " + tableTransaksi[2, i].Value.ToString());
                    myCommand.ExecuteNonQuery();
                    connection.Close();

                    //========================= UPDATE JUMLAHHH =======================================
                    string connectionString1 = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                    SqlConnection connection1 = new SqlConnection(connectionString1);
                    SqlCommand myCommand1 = new SqlCommand("sp_updateJumlahKomponen", connection1);


                    myCommand1.CommandType = CommandType.StoredProcedure;

                    
                    connection1.Open();

                    
                    myCommand1.Parameters.AddWithValue("id_komponen", getIDKomponenByNamaDanID(tableTransaksi[1, i].Value.ToString(),i));
                    myCommand1.Parameters.AddWithValue("jumlah", tableTransaksi[4, i].Value);
                    

                    myCommand1.ExecuteNonQuery();
                    connection1.Close();
    

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error detailtransaksi : " + ex.ToString());


                    //btnUpdate.Enabled = false;
                    //clear();
                }
            }
            MessageBox.Show("Berhasil memproses transaksi..");
            tableTransaksi.Rows.Clear();
            updateTransaksiCustomer();




            txtKomponen = "";
        }
        private void updateTransaksiCustomer()
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_updateTransaksiCustomer", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_customer", getIDPelanggan(nama_pelanggan.Text));


                myCommand.ExecuteNonQuery();
                connection.Close();

                clearAll();
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updateTransaksiCustomer : " + ex.ToString());


                //btnUpdate.Enabled = false;
                //clear();
            }
        }
        private void clear()
        {
            countBarang();
            countJenis();
            countTotal();
        }
        private void clearAll()
        {
            clear();
            nama_pelanggan.Text = "";
        }
        private string getIDKomponenByNamaDanID(string inx,int i)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariKomponenByIDAlat", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();


                myCommand.Parameters.AddWithValue("nama_komponen", inx);
                myCommand.Parameters.AddWithValue("id_alat", getIDAlat(tableTransaksi[2,i].Value.ToString()));

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

        private object getIDAlat(string v)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatElektronik", connection);
                

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_alat", "XX");
                myCommand.Parameters.AddWithValue("nama_alat", v);
                myCommand.Parameters.AddWithValue("id_jenis", "XX");
                

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
                MessageBox.Show("Error getIDAlat : " + ex.ToString());

                return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_getAllKomponenByNama", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                
                myCommand.Parameters.AddWithValue("Komponen", txtCari.text);
                
                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                DataTable dtCloned = data.Clone();
                dtCloned.Columns[3].DataType = typeof(String);
                foreach (DataRow row in data.Rows)
                {
                    dtCloned.ImportRow(row);
                }

                for (int i = tableKomponen.RowCount - 1; i >= 0; i--)
                {
                    tableKomponen.Rows.RemoveAt(i);
                }
                
                tableKomponen.DataSource = dtCloned;

                connection.Close();
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Data tidak ditemukan");

                
                //btnUpdate.Enabled = false;
                //clear();
            }
        }

        private void btnNewPelanggan_Click(object sender, EventArgs e)
        {
            CustomerMaster cus = new CustomerMaster(nama_pelanggan.Text);
            cus.ShowDialog(this);
            addSourceNama();
        }

        private void btnSegarkan_Click(object sender, EventArgs e)
        {
            addDataKomponen();
        }
    }
}
