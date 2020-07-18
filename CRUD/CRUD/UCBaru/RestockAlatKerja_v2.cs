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
using System.Text.RegularExpressions;

namespace CRUD
{
    public partial class RestockAlatKerja_v2 : UserControl
    {
        private int selected = 0;
        private int selectedTransaksi = -1;
        private int newJumlah = 0, newBagus = 0, newRusak = 0;
        private string id_restock = "";

        private int selectedSupplier = -1;
        private int selectedAlat = -1;

        public string id_karyawan = "";

        private void tbAlatKerja_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i == -1)
            {
                return;
            }
            selectedAlat = i;
            tbAlatKerja.Rows[i].Selected = true;
            addDataSupplier(tbAlatKerja[1, i].Value.ToString());
            try
            {
                tbSupplier.Rows[0].Selected = true;
            }
            catch(Exception ex)
            {

            }
            
            
        }

        public RestockAlatKerja_v2()
        {
            InitializeComponent();
            addDataAlatKerja();
            txtTanggal.Text = DateTime.Today.ToString("dd-MM-yyyy");
        }
        private bool periksaAlat(string namaalat, string supplier)
        {
            for(int i = 0; i < tbTransaksi.Rows.Count; i++)
            {
                if (tbTransaksi[1, i].Value.ToString().Equals(namaalat) && tbTransaksi[2, i].Value.ToString().Equals(supplier))
                {
                    return false;
                }
            }
            return true;
        }
        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            //NO \ ALAT KERJA \ SUPPLIER \ HARGA \ JUMLAH \ TOTAL \ + \ - \ X
            //if(selectedSupplier == -1)
            //{
            //   MessageBox.Show("Pilih supplier dengan benar", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //  return;
            //}
            try
            {
                selectedSupplier = tbSupplier.CurrentRow.Index;
            }
            catch(Exception ex)
            {
                return;
            }
            if (!periksaAlat(tbAlatKerja[1, tbAlatKerja.CurrentRow.Index].Value.ToString(), tbSupplier[1,selectedSupplier].Value.ToString()))
            {
                MessageBox.Show("Data sudah dimasukkan", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            this.tbTransaksi.Columns[6].CellTemplate.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.tbTransaksi.Columns[7].CellTemplate.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            this.tbTransaksi.Columns[8].CellTemplate.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);

            this.tbTransaksi.Columns[6].CellTemplate.Style.BackColor = Color.Green;
            this.tbTransaksi.Columns[7].CellTemplate.Style.BackColor = Color.Green;
            this.tbTransaksi.Columns[8].CellTemplate.Style.BackColor = Color.Red;

            string harga = toRupiah(Convert.ToInt32(tbSupplier[2, selectedSupplier].Value.ToString().Substring(0, tbSupplier[2, selectedSupplier].Value.ToString().Length-3)));
            Object[] n = { tbTransaksi.Rows.Count + 1, tbAlatKerja[1, selectedAlat].Value.ToString(), tbSupplier[1, selectedSupplier].Value.ToString(),harga, 1,harga, "+", "-", "x" };
            tbTransaksi.Rows.Add(n);

            this.tbTransaksi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            this.tbTransaksi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.tbTransaksi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            hitungHargaTotal();
        }
        private void hitungHargaTotal()
        {
            int uang = 0;
            int barang = 0;
            for(int i = 0; i < tbTransaksi.Rows.Count; i++)
            {
                uang = uang + toAngka(tbTransaksi[5, i].Value.ToString());
                barang = barang + (int)tbTransaksi[4, i].Value;
            }
            txtTotal.Text = toRupiah(uang);
            txtJenis.Text = tbTransaksi.Rows.Count.ToString();
            txtBarang.Text = barang.ToString();
        }
        public string toRupiah(int angka)

        {

            return String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("id-id"), "{0:N}", angka);

        }

        public int toAngka(string rupiah)

        {

            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));

        }
        private void tbSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedSupplier = e.RowIndex;
            if(selectedSupplier == -1)
            {
                return;
            }
            tbSupplier.Rows[e.RowIndex].Selected = true;
        }

        private void tbTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 6)
            {
                tbTransaksi[4, e.RowIndex].Value = ((int)tbTransaksi[4, e.RowIndex].Value) + 1;
            }
            if (e.ColumnIndex == 7)
            {
                if(tbTransaksi[4, e.RowIndex].Value.ToString().Equals("1"))
                {
                    return;
                }
                tbTransaksi[4, e.RowIndex].Value = ((int)tbTransaksi[4, e.RowIndex].Value) - 1;
            }
            if (e.ColumnIndex == 8)
            {
                tbTransaksi.Rows.RemoveAt(e.RowIndex);
            }
            try
            {
                int harga = toAngka(tbTransaksi[3, e.RowIndex].Value.ToString());
                //MessageBox.Show(harga.ToString());
                int jumlah = (int)tbTransaksi[4, e.RowIndex].Value;
                int total = harga * jumlah;
                string totals = toRupiah(total);
                tbTransaksi[5, e.RowIndex].Value = totals;
            }
            catch(Exception ex)
            {
                //MessageBox.Show(ex.ToString());
            }
            perapihanKeranjang();
            hitungHargaTotal();
        }
        private void perapihanKeranjang()
        {
            for(int i = 0; i < tbTransaksi.Rows.Count; i++)
            {
                tbTransaksi[0, i].Value = i+1;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tbTransaksi.Rows.Clear();
            hitungHargaTotal();
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
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tbTransaksi.Rows.Count == 0)
            {
                return;
            }

            string checker = null;
            Boolean cek = true;
            

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
                    myCommand.Parameters.AddWithValue("id_pelayan", id_karyawan);
                    //myCommand.Parameters.AddWithValue("id_pelayan", "PLY-0001");
                    myCommand.Parameters.AddWithValue("tanggal_pembelian", DateTime.Now.ToString("yyyy-MM-dd"));
                    myCommand.Parameters.AddWithValue("total", toAngka(txtTotal.Text));
                    myCommand.Parameters.AddWithValue("jenis", txtJenis.Text);
                    myCommand.Parameters.AddWithValue("jumlah", txtBarang.Text);

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
                    myCommand.Parameters.AddWithValue("harga", toAngka(tbTransaksi[5, i].Value.ToString()));

                    myCommand.ExecuteNonQuery();
                    connection.Close();

                   // updateStock(i);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error btnBayar_Click : " + ex.ToString());
                }
            }
            MessageBox.Show("Berhasil memproses ..");
            tbTransaksi.Rows.Clear();
            tbSupplier.DataSource = null;

           
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
        private void addDataSupplier(String alatKerja)
        {
            tbSupplier.Rows.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_getSupplierAlatKerja", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("nama_alat", alatKerja);
                SqlDataAdapter adapter = new SqlDataAdapter();

                
                DataTable data = new DataTable();
                adapter.SelectCommand = myCommand;
                adapter.Fill(data);

                //tbSupplier.DataSource = data;

                foreach (DataGridViewColumn col in tbSupplier.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    //col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                //MEMASUKKAN DATA KE DALAM TABLE
                for(int i = 0; i < data.Rows.Count; i++)
                {
                    
                    Object[] n = { (i + 1) +"." , data.Rows[i][0].ToString(), data.Rows[i][1].ToString()};
                    tbSupplier.Rows.Add(n);
                }


                this.tbSupplier.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        public void addDataAlatKerja()
        {
            tbAlatKerja.Rows.Clear();
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

                //tbAlatKerja.DataSource = data;

                foreach (DataGridViewColumn col in tbAlatKerja.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                    //col.HeaderCell.Style.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }


                //MEMASUKKAN NILAI KE TABLE
                for(int i = 0; i < data.Rows.Count; i++)
                {
                    Object[] n = { (i + 1) + ".", data.Rows[i][0].ToString(), data.Rows[i][1].ToString(), data.Rows[i][2].ToString(), data.Rows[i][3].ToString()};
                    tbAlatKerja.Rows.Add(n);
                }

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
    }
}
