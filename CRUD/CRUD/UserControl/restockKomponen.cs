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
    public partial class restockKomponen : UserControl
    {
        private int selected = 0;
        private int selectedTransaksi = -1;
        private string id_restock = "";
        public restockKomponen()
        {
            InitializeComponent();
            addDataKomponen();
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

                foreach (DataGridViewColumn col in tableKomponen.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                this.tableKomponen.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableKomponen.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableKomponen.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableKomponen.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableKomponen.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                this.tableKomponen.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
        private void addDataSupplier(String komponen)
        {
            tableSupplier.Columns.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter("select distinct ROW_NUMBER() over(order by harga asc) No, [mssupplier].nama_supplier Supplier, "+
                    "convert(numeric(10, 2), harga) as [Harga(Rp)] from[mskomponensupplier] ks inner join[mskomponen] k "+
                    "on ks.id_komponen = k.id_komponen inner join[mssupplier] on[mssupplier].id_supplier = ks.id_supplier where k.nama_komponen = '" + komponen+"'", connection);

                DataTable data = new DataTable();
                adapter.Fill(data);

                tableSupplier.DataSource = data;

                foreach (DataGridViewColumn col in tableSupplier.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                this.tableSupplier.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableSupplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                

                this.tableSupplier.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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
        
        private void insertDataTransaksi()
        {
            DataGridViewRow row = tableSupplier.Rows[selected];
            int no = Convert.ToInt32(tableTransaksi.Rows.Count.ToString());
            String komponen = txtKomponen.Text;
            String supp = txtSupplier.Text;
            String harga = (row.Cells[2].Value.ToString()).Substring(0, (row.Cells[2].Value.ToString()).Length -3);
            String total = Convert.ToString(Convert.ToInt32(harga) * Convert.ToInt32(txtJumlah.Text));
            String jumlah = txtJumlah.Text;

            //MessageBox.Show(no + komponen + supp + harga + total);
            tableTransaksi.Rows.Add(no+1 , komponen , supp , harga , jumlah, total);

            foreach (DataGridViewColumn col in tableTransaksi.Columns)
            {
                col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
            }

            this.tableTransaksi.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tableTransaksi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableTransaksi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableTransaksi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableTransaksi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableTransaksi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.tableTransaksi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.tableTransaksi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tableTransaksi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }

        private void perapihan()
        {
            int i = 1;
           
            foreach (DataGridViewRow row in tableTransaksi.Rows)
            {
                tableTransaksi[0,i-1].Value = i.ToString();
                i++;
            }
        }
        private void clear()
        {
            txtSupplier.Text = "";
            txtJumlah.Text = "0";
            txtTotal.Text = "0";
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            
            Int32 selectedRow = tableKomponen.Rows.GetRowCount(DataGridViewElementStates.Selected);

            Int32 select = 0;
            for (int i = 0; i < selectedRow; i++)
            {
                select = Int32.Parse(tableKomponen.SelectedRows[i].Index.ToString());
            }
            DataGridViewRow row = tableKomponen.Rows[select];
            addDataSupplier(row.Cells[1].Value.ToString());
            txtKomponen.Text = row.Cells[1].Value.ToString();

        }

        private void tableKomponen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = tableKomponen.Rows.GetRowCount(DataGridViewElementStates.Selected);
            //MessageBox.Show(selectedRow.ToString());
            if (selectedRow > 0 && selectedRow <= 1)
            {
                btnCari.Enabled = true;
            }
            else
            {
                btnCari.Enabled = false;
            }
        }

        private void tableSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = tableSupplier.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(selectedRow > 0 && selectedRow <= 1)
            {
                for(int i = 0; i < selectedRow; i++)
                {
                    selected = Int32.Parse(tableSupplier.SelectedRows[i].Index.ToString());
                }
                DataGridViewRow row = tableSupplier.Rows[selected];
                txtSupplier.Text = row.Cells[1].Value.ToString();
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

        private void tableTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = tableTransaksi.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if(selectedRow > 0 && selectedRow <= 1)
            {
                for (int i = 0; i < selectedRow; i++)
                {
                    selectedTransaksi = Int32.Parse(tableTransaksi.SelectedRows[i].Index.ToString());
                }

                btnBatal.Enabled = true;
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            DataGridViewRow del = tableTransaksi.Rows[selectedTransaksi];
            tableTransaksi.Rows.Remove(del);
           
            btnBatal.Enabled = false;
            perapihan();
            hitungTotal();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            tableTransaksi.Rows.Clear();
            hitungTotal();
        }
        private void hitungTotal()
        {
            int total = 0;
            for(int i = 0; i < tableTransaksi.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(tableTransaksi[5, i].Value);
            }
            txtTotal.Text = total.ToString();
        }
        private int hitungJumlahKomponen()
        {
            int total = 0;
            for (int i = 0; i < tableTransaksi.Rows.Count; i++)
            {
                total = total + Convert.ToInt32(tableTransaksi[4, i].Value);
            }
            return total;
        }
        private void btnBayar_Click(object sender, EventArgs e)
        {   if(tableTransaksi.Rows.Count == 0)
            {
                return;
            }
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_inputTRestockKomponen", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                id_restock = "trk-" + getLastID();
                myCommand.Parameters.AddWithValue("no_pembelian_komponen", id_restock);
                myCommand.Parameters.AddWithValue("tanggal_pembelian", DateTime.Now.ToString("yyyyMMdd"));
                myCommand.Parameters.AddWithValue("total_jenis", tableTransaksi.Rows.Count);
                myCommand.Parameters.AddWithValue("jumlah_komponen", hitungJumlahKomponen());
                myCommand.Parameters.AddWithValue("total_harga", txtTotal.Text);


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
            for (int i = 0; i < tableTransaksi.Rows.Count; i++)
            {
                try
                {
                    string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand myCommand = new SqlCommand("sp_inputTDetailStock", connection);


                    myCommand.CommandType = CommandType.StoredProcedure;

                

                
                        connection.Open();

                        myCommand.Parameters.AddWithValue("no_pembelian_komponen", id_restock);
                        myCommand.Parameters.AddWithValue("id_komponen", getIDKomponen(tableTransaksi[1, i].Value.ToString()));
                        myCommand.Parameters.AddWithValue("id_supplier", getIDSupplier(tableTransaksi[2, i].Value.ToString()));
                        myCommand.Parameters.AddWithValue("jumlah", tableTransaksi[4, i].Value);
                        myCommand.Parameters.AddWithValue("total_harga", tableTransaksi[5, i].Value);

                        myCommand.ExecuteNonQuery();
                        connection.Close();




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
            MessageBox.Show("Berhasil memproses ..");
            tableTransaksi.Rows.Clear();
            tableSupplier.DataSource = null;
            

            clear();
            txtKomponen.Text = "[Komponen]";
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
        private string getIDSupplier(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariSupplier", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
 
                myCommand.Parameters.AddWithValue("id_supplier", "XX");
                myCommand.Parameters.AddWithValue("nama_supplier", inx);
                myCommand.Parameters.AddWithValue("@contact_person", "x");
                myCommand.Parameters.AddWithValue("@no_telepon", "x");
                myCommand.Parameters.AddWithValue("@alamat", "x");
                myCommand.Parameters.AddWithValue("@keterangan", "x");

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
        private string getLastID()
        {
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select count (no_pembelian_komponen) from trestockkomponen", connection);
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
