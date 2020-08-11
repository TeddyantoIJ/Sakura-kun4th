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
using System.Threading;

namespace CRUD.UCBaru
{
    public partial class Pemasokan_v2 : UserControl
    {
        private int selected = 0;
        private int selectedTransaksi = -1;
        private string id_restock = "";
        private string txtKomponen = "";
        private string txtSupplier = "";

        public string id_karyawan = "";

        DataGridViewButtonColumn buttons = new DataGridViewButtonColumn();
        public Pemasokan_v2()
        {
            InitializeComponent();
            addDataKomponen();
            //bunifuElipse.ApplyElipse(panelDetail,15);
            //bunifuElipse.ApplyElipse(panelTransaksi, 15);
            //bunifuElipse.ApplyElipse(panelKomponen, 15);
            //bunifuElipse.ApplyElipse(panelSupplier, 15);
            //bunifuElipse.ApplyElipse(btnTambah, 15);
            //bunifuElipse.ApplyElipse(btnKeranjang, 15);
            //bunifuElipse.ApplyElipse(btnReset, 15);

            tulisanTotal.ForeColor = Color.White;
            txtTanggal.Text = DateTime.Now.ToString("dd-MM-yyyy");
        }
        public void addDataKomponen()
        {
            tableKomponen.DataSource = null;
            tableKomponen.Columns.Clear();
            try
            {
                string connectionString = Program.getConstring();

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
                
                for (int i =0; i < tableKomponen.RowCount; i++)
                {
                    tableKomponen[3, i].Value = toRupiah(Convert.ToInt32(tableKomponen[3, i].Value.ToString().Substring(0, tableKomponen[3, i].Value.ToString().Length-3)));
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
        }
        private void addDataSupplier(String komponen)
        {
            tableSupplier.Columns.Clear();
            try
            {
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter("select distinct ROW_NUMBER() over(order by harga asc) No, [mssupplier].nama_supplier Supplier, " +
                    "convert(numeric(10, 2), harga) as [Harga(Rp)] from[mskomponensupplier] ks inner join[mskomponen] k " +
                    "on ks.id_komponen = k.id_komponen inner join[mssupplier] on[mssupplier].id_supplier = ks.id_supplier where k.nama_komponen = '" + komponen + "'", connection);

                DataTable data = new DataTable();
                adapter.Fill(data);

                //Cloning dataset dan dirubah
                DataTable dtCloned = data.Clone();
                dtCloned.Columns[2].DataType = typeof(String);
                foreach (DataRow row in data.Rows)
                {
                    dtCloned.ImportRow(row);
                }

                tableSupplier.DataSource = dtCloned;

                foreach (DataGridViewColumn col in tableSupplier.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleLeft;
                    //col.HeaderCell.Style.Font = new Font("Arial", 9F, FontStyle.Bold, GraphicsUnit.Pixel);
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }

                this.tableSupplier.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableSupplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                
                this.tableSupplier.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //by = 1;
                connection.Close();
                for (int i = 0; i < tableSupplier.RowCount-1; i++)
                {
                    //MessageBox.Show((tableSupplier[2, i].Value.ToString().Substring(0, tableSupplier[2, i].Value.ToString().Length - 3)).ToString());
                    tableSupplier[2, i].Value = toRupiah(Convert.ToInt32(tableSupplier[2, i].Value.ToString().Substring(0, tableSupplier[2, i].Value.ToString().Length - 3)));
                }
                try
                {
                    txtSupplier = tableSupplier[1, 0].Value.ToString();
                    tableSupplier.Rows[0].Selected = true;
                }
                catch(Exception ex)
                {

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

        private void tableKomponen_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            Int32 selectedRow = tableKomponen.SelectedCells.Count;
            int selectedrowindex = tableKomponen.SelectedCells[0].RowIndex;
            tableKomponen.Rows[selectedrowindex].Selected = true;            
            DataGridViewRow row = tableKomponen.Rows[selectedrowindex];
            addDataSupplier(row.Cells[1].Value.ToString());
            txtKomponen = row.Cells[1].Value.ToString();
        }

        private void tableSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = tableSupplier.SelectedCells.Count;
            int selectedrowindex = tableSupplier.SelectedCells[0].RowIndex;
            tableSupplier.Rows[selectedrowindex].Selected = true;
            DataGridViewRow row = tableSupplier.Rows[selectedrowindex];
            txtSupplier = row.Cells[1].Value.ToString();
            
        }
        private void insertDataTransaksi()
        {
            try
            {
                if (tableSupplier.CurrentRow.Index == -1)
                {
                    return;
                }
            }
            catch(Exception ex)
            {
                return;
            }
            
            DataGridViewRow row = tableSupplier.Rows[selected];
            int no = Convert.ToInt32(tableTransaksi.Rows.Count.ToString());
            string komponen = txtKomponen;
            string supp = txtSupplier;
            string harga = row.Cells[2].Value.ToString();
            int total = 0;
            int jumlah = 1;
            string plus = "+";
            string minus = "-";
            string batal = "x";


            for (int i = 0; i < tableTransaksi.RowCount; i++)
            {
                if (tableTransaksi[1, i].Value.Equals(komponen) && tableTransaksi[2, i].Value.Equals(supp))
                {
                    return;
                }
            }
            //MessageBox.Show(no + komponen + supp + harga + total);




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
            this.tableTransaksi.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tableTransaksi.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.tableTransaksi.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableTransaksi.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.tableTransaksi.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            this.tableTransaksi.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            this.tableTransaksi.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tableTransaksi.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            tableTransaksi.Rows.Add(no + 1, komponen, supp, harga, jumlah, harga, plus, minus, batal);
            countTotal();
            countBarang();
            countJenis();
        }
        private void AddButtonColumn()
        {
            
            {
                buttons.HeaderText = "Sales";
                buttons.Text = "+";
                buttons.UseColumnTextForButtonValue = true;
                buttons.AutoSizeMode =
                    DataGridViewAutoSizeColumnMode.DisplayedCells;
                buttons.FlatStyle = FlatStyle.Standard;
                buttons.CellTemplate.Style.BackColor = Color.Black;
                buttons.DisplayIndex = 0;
            }
            
        }

        private void tableSupplier_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnKeranjang_Click(object sender, EventArgs e)
        {
            if(txtKomponen.Equals("") || txtKomponen.Equals(""))
            {
                return;
            }
            int select = tableSupplier.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if(select < 0 || select >1)
            {
                return;
            }
            insertDataTransaksi();
            try
            {

            }catch(Exception ex)
            {
                tableTransaksi[5, tableTransaksi.RowCount - 1].Value = toRupiah(Convert.ToInt32(toAngka((tableTransaksi[3, tableTransaksi.RowCount - 1].Value).ToString())) * Convert.ToInt32(toAngka((tableTransaksi[4, tableTransaksi.RowCount - 1].Value).ToString()))).ToString();
            }
            countTotal();
            countBarang();
            countJenis();
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void tableKomponen_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuMaterialTextbox3_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox2_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox1_OnValueChanged_1(object sender, EventArgs e)
        {

        }

        private void bunifuMaterialTextbox6_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtTotal_Click(object sender, EventArgs e)
        {

        }

        private void blbHargaTotal_Click(object sender, EventArgs e)
        {

        }

        private void tableTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex >= 0 && e.ColumnIndex == 6)
            {
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
            for(int i = 0; i < tableTransaksi.RowCount; i++)
            {
                tableTransaksi[0, i].Value = i+1;
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
        public string toRupiah(Int32 angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "{0:N}", angka);
        }

        public int toAngka(string rupiah)
        {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            for(int i = tableTransaksi.RowCount-1; i >= 0; i--)
            {
                tableTransaksi.Rows.RemoveAt(i);
            }
            countBarang();
            countJenis();
            countTotal();
        }
        private string getLastID()
        {
            string connectionString = Program.getConstring();

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
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (tableTransaksi.Rows.Count == 0)
            {
                MessageBox.Show("Tidak ada data transaksi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_inputTRestockKomponen", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                id_restock = "trk-" + getLastID();
                myCommand.Parameters.AddWithValue("no_pembelian_komponen", id_restock);
                myCommand.Parameters.AddWithValue("id_pelayan", id_karyawan);
                myCommand.Parameters.AddWithValue("tanggal_pembelian", DateTime.Now.ToString("yyyyMMdd"));
                myCommand.Parameters.AddWithValue("total_jenis", txtBarang.Text);
                myCommand.Parameters.AddWithValue("jumlah_komponen", txtBarang.Text);
                myCommand.Parameters.AddWithValue("total_harga", toAngka(txtTotal.Text));


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
                    string connectionString = Program.getConstring();

                    SqlConnection connection = new SqlConnection(connectionString);
                    SqlCommand myCommand = new SqlCommand("sp_inputTDetailStock", connection);


                    myCommand.CommandType = CommandType.StoredProcedure;




                    connection.Open();

                    myCommand.Parameters.AddWithValue("no_pembelian_komponen", id_restock);
                    myCommand.Parameters.AddWithValue("id_komponen", getIDKomponen(tableTransaksi[1, i].Value.ToString()));
                    myCommand.Parameters.AddWithValue("id_supplier", getIDSupplier(tableTransaksi[2, i].Value.ToString()));
                    myCommand.Parameters.AddWithValue("jumlah", tableTransaksi[4, i].Value);
                    myCommand.Parameters.AddWithValue("total_harga", toAngka((String)tableTransaksi[5, i].Value));

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
            countTotal();
            countJenis();
            countBarang();
        }
        private string getIDKomponen(string inx)
        {
            try
            {
                string connectionString = Program.getConstring();

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
                string connectionString = Program.getConstring();

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

        private void Pemasokan_v2_VisibleChanged(object sender, EventArgs e)
        {
            addDataKomponen();
        }
    }
}
