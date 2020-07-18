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

namespace CRUD
{
    public partial class BayarReparasi : UserControl
    {
        public BayarReparasi()
        {
            InitializeComponent();
        }
        public void addDataReparasi()
        {
            tableReparasi.DataSource = null;
            tableReparasi.Columns.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_viewselesaireparasialat", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("nama", txtnama_pelanggan.Text);
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable data = new DataTable();
                adapter.SelectCommand = myCommand;
                adapter.Fill(data);

                DataTable dtclone = new DataTable();
                dtclone = data.Clone();
                dtclone.Columns[6].DataType = typeof(String);
                dtclone.Columns[7].DataType = typeof(String);
                foreach (DataRow row in data.Rows)
                {
                    dtclone.ImportRow(row);
                }
                tableReparasi.DataSource = dtclone;

                foreach (DataGridViewColumn col in tableReparasi.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //    col.HeaderCell.Style.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Pixel);
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                this.tableReparasi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableReparasi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableReparasi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableReparasi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableReparasi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableReparasi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableReparasi.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableReparasi.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableReparasi.Columns[8].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableReparasi.Columns[9].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;


                this.tableReparasi.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.tableReparasi.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.tableReparasi.Columns[8].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableReparasi.Columns[9].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableReparasi.Columns[10].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                //by = 1;

                connection.Close();
                perapihan();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //btnUpdate.Enabled = false;
                //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                //clear();
            }
        }
        public string toRupiah(int angka)

        {

            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "{0:N}", angka);

        }

        public int toAngka(string rupiah)

        {

            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));

        }
        private void perapihan()
        {
            for (int i = 0; i < tableReparasi.RowCount; i++)
            {
                try
                {
                    tableReparasi[6, i].Value = "Rp "+ toRupiah(Convert.ToInt32(tableReparasi[6, i].Value.ToString()));
                }
                catch(Exception ex)
                {
                    tableReparasi[6, i].Value = "Rp " + toRupiah(0);
                }
                try
                {
                    tableReparasi[7, i].Value = "Rp " + toRupiah(Convert.ToInt32(tableReparasi[7, i].Value.ToString().Substring(0, tableReparasi[7, i].Value.ToString().Length - 5).ToString()));
                }
                catch (Exception ex)
                {
                    tableReparasi[7, i].Value = "Rp " + toRupiah(0);
                }
                
                
                tableReparasi[0, i].Value = i + 1;
            }
        }
        private void addSourceNama()
        {
            txtnama_pelanggan.AutoCompleteCustomSource = null;

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
            txtnama_pelanggan.AutoCompleteCustomSource = collection;
            txtnama_pelanggan.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnama_pelanggan.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void BayarReparasi_Load(object sender, EventArgs e)
        {
            addSourceNama();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            addDataReparasi();
        }

        private void tableReparasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            try
            {
                if(tableReparasi[8,e.RowIndex].Value.ToString().Equals("Diproses") || tableReparasi[10, e.RowIndex].Value.ToString().Equals("Lunas"))
                {
                    btnBayar.Enabled = false;
                }
                else
                {
                    btnBayar.Enabled = true;
                }
                tableReparasi.Rows[i].Selected = true;

                txtKode.Text = tableReparasi[1, i].Value.ToString();
                txtJenis.Text = tableReparasi[3, i].Value.ToString();
                txtKeluhan.Text = tableReparasi[5, i].Value.ToString();
                txtBiaya.Text = tableReparasi[6, i].Value.ToString();
                txtTotalBiaya.Text = tableReparasi[7, i].Value.ToString().Substring(3);
                txtAlat_elektronik.Text = tableReparasi[4, i].Value.ToString();
                getDetail();
            }
            catch(Exception ex)
            {

            }
            
        }

        private void getDetail()
        {
            
            tableKomponenBeli.Rows.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_getDetailReparasi", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("no_transaksi_reparasi", txtKode.Text);
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable data = new DataTable();
                adapter.SelectCommand = myCommand;
                adapter.Fill(data);
                //by = 1;

                connection.Close();
                
                for(int i = 0; i<data.Rows.Count; i++)
                {
                    
                    string harga = "Rp " + toRupiah(Convert.ToInt32(data.Rows[i][3].ToString().Substring(0,data.Rows[i][3].ToString().Length-5)));
                    string total = "Rp " + toRupiah(Convert.ToInt32(data.Rows[i][4].ToString().Substring(0, data.Rows[i][4].ToString().Length - 5)));
                    Object[] n = { (i + 1)+".",data.Rows[i][1].ToString(),data.Rows[i][2].ToString(),harga,total };
                    tableKomponenBeli.Rows.Add(n);
                }
                this.tableKomponenBeli.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.tableKomponenBeli.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                //btnUpdate.Enabled = false;
                //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                //clear();
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            Pembayaran pembayaran = new Pembayaran(txtTotalBiaya.Text);

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
                SqlCommand myCommand = new SqlCommand("sp_updateTransaksiCustomer", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();



                myCommand.Parameters.AddWithValue("id_customer", getIDPelanggan(txtnama_pelanggan.Text));
               
                myCommand.ExecuteNonQuery();
                connection.Close();


                myCommand = new SqlCommand("sp_updatestatuspembayaranreparasi", connection);
                myCommand.CommandType = CommandType.StoredProcedure;
                connection.Open();
                myCommand.Parameters.AddWithValue("no_transaksi_reparasi", txtKode.Text);
                myCommand.ExecuteNonQuery();
                connection.Close();


                txtAlat_elektronik.Text = "";
                txtJenis.Text = "";
                txtnama_pelanggan.Text = "";
                txtKeluhan.Text = "";
                txtBiaya.Text = "Rp " + toRupiah(0);
                txtTotalBiaya.Text = toRupiah(0);
                addDataReparasi();
                tableKomponenBeli.Rows.Clear();
                //tableReparasi.Rows.Clear();
                //by = 1;

                //btnUpdate.Enabled = true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Masukkan data dengan benar! " + ex.ToString(), "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);


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
    }
}
