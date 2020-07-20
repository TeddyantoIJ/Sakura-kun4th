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
    public partial class DetailReparasi : UserControl
    {
        private int currentRow = 0;
        private string id_komponen = "";
        public DetailReparasi()
        {
            InitializeComponent();
            addDataReparasi("Diproses");
            customizetable();
        }
        private void perapihan()
        {
            for(int i = 0; i < tableReparasi.RowCount; i++)
            {
                tableReparasi[0, i].Value = i+1;
            }
        }
        public void addDataReparasi(string status)
        {
            tableReparasi.DataSource = null;
            tableReparasi.Columns.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_viewprosesreparasialat", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                myCommand.Parameters.AddWithValue("status", status);
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable data = new DataTable();
                adapter.SelectCommand = myCommand;
                adapter.Fill(data);

                
                tableReparasi.DataSource = data;

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

                
                this.tableReparasi.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableReparasi.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
        public void addDataReparasi()
        {
            tableReparasi.DataSource = null;
            tableReparasi.Columns.Clear();
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_viewprosesreparasialat1", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                //myCommand.Parameters.AddWithValue("status", status);
                SqlDataAdapter adapter = new SqlDataAdapter();

                DataTable data = new DataTable();
                adapter.SelectCommand = myCommand;
                adapter.Fill(data);


                tableReparasi.DataSource = data;

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


                this.tableReparasi.Columns[6].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableReparasi.Columns[7].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void DetailReparasi_Load(object sender, EventArgs e)
        {
            
            
            //addSourceKomponen();
        }
        private string getIDKomponenByNamaDanID(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariKomponenByIDAlat", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();


                myCommand.Parameters.AddWithValue("nama_komponen", inx);
                myCommand.Parameters.AddWithValue("id_alat", getIDAlat(tableReparasi[4, currentRow].Value.ToString()));

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                String output = data.Rows[0][0].ToString();
                connection.Close();
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
        private void getHarga()
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);

                //membuat table dengan jumlah data saja
                SqlDataAdapter adapter = new SqlDataAdapter("select harga_jual from mskomponen where id_komponen = '" + getIDKomponenByNamaDanID(txtnama_komponen.Text) + "'", connection);
                //memasukkan ke dataset
                DataSet msdata = new DataSet();
                adapter.Fill(msdata);

                id_komponen = getIDKomponenByNamaDanID(txtnama_komponen.Text);



                int output =Convert.ToInt32(msdata.Tables[0].Rows[0][0].ToString().Substring(0, msdata.Tables[0].Rows[0][0].ToString().Length-5));
                
                txtharga_komponen.Text = "Rp "+toRupiah(output);
                //MessageBox.Show(output.ToString());
                //by = 1;
                hitungHarga();
                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error getHarga : " + ex.ToString());

                //return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }

        public string toRupiah(int angka)

        {

            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "{0:N}", angka);

        }

        public int toAngka(string rupiah)

        {
            try
            {
                return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
            }
            catch(Exception ex)
            {
                return 0;
            }
            

        }
        private void tableReparasi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtkode_transaksi.Text = "";
            
            try
            {
                tableReparasi.Rows[e.RowIndex].Selected = true;
                if (!tableReparasi[6, e.RowIndex].Value.ToString().Equals("Diproses"))
                {
                    return;
                }
                currentRow = e.RowIndex;
                txtkode_transaksi.Text = tableReparasi[1, e.RowIndex].Value.ToString();
                addSourceKomponen();
            }catch(Exception ex)
            {

            }
            
        }
        private string getIDAlat(string inx)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatElektronik", connection);

                
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("id_alat", "XX");
                myCommand.Parameters.AddWithValue("nama_alat", inx);
                myCommand.Parameters.AddWithValue("id_jenis", "XX");

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);
                connection.Close();
                String output = data.Rows[0][0].ToString();
                //MessageBox.Show(output.ToString());
                return output;
                MessageBox.Show(output.ToString());
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
        private void addSourceKomponen()
        {
            txtnama_komponen.AutoCompleteCustomSource = null;

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_komponen from mskomponen where id_alat = '"+getIDAlat(tableReparasi[4,currentRow].Value.ToString())+"'", connection);
            //memasukkan ke dataset
            DataSet msdata = new DataSet();
            adapter.Fill(msdata);

            for (int i = 0; i < msdata.Tables[0].Rows.Count; i++)
            {

                collection.Add(msdata.Tables[0].Rows[i][0].ToString());
            }
            txtnama_komponen.AutoCompleteCustomSource = collection;
            txtnama_komponen.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnama_komponen.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void txtnama_komponen_TextChanged(object sender, EventArgs e)
        {
            getHarga();
        }
        private void hitungHarga()
        {
            int uang = toAngka(txtharga_komponen.Text);
            try
            {
                txtharga_total.Text = "Rp "+toRupiah(Convert.ToInt32(uang * txtjumlah.Value));
            }
            catch (Exception ex)
            {

            }
        }
        private void txtjumlah_ValueChanged(object sender, EventArgs e)
        {
            hitungHarga();
        }
        private void hitungTotalHarga()
        {
            int total = 0;
            for(int i = 0; i < tableKomponen.RowCount; i++)
            {
                total = total + toAngka(tableKomponen[4, i].Value.ToString());
            }
            total = total + toAngka(txtBiaya.Text);
            txtTotalHarga.Text = toRupiah(total);
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (id_komponen.Equals(""))
            {
                return;
            }
            for(int i = 0; i < tableKomponen.RowCount; i++)
            {
                if (tableKomponen[1, i].Value.ToString().Equals(id_komponen))
                {
                    tableKomponen.Rows.RemoveAt(i);break;
                }
            }
            try
            {
                Object[] data = { tableKomponen.RowCount + 1, id_komponen, txtnama_komponen.Text, txtjumlah.Value, txtharga_total.Text };
                tableKomponen.Rows.Add(data);
                for(int i = 0; i < tableKomponen.RowCount; i++)
                {
                    tableKomponen[0, i].Value = i + 1;
                }
                hitungTotalHarga();
                clear();
            }catch(Exception ex)
            {
                MessageBox.Show("Ex "+ex.ToString());
            }
            
        }
        private void clear()
        {
            txtnama_komponen.Text = "";
            txtharga_komponen.Text = toRupiah(0);
            txtjumlah.Value = 1;
            hitungHarga();
        }
        private void customizetable()
        {
            
            this.tableKomponen.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.tableKomponen.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
        }
        int biaya = 0;
        private void txtBiaya_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; return;
            }
            
            e.Handled = true;
            string angka = "";
            try
            {
                angka = (toAngka(txtBiaya.Text)).ToString();
            }catch(Exception ex)
            {
            }

            char n = e.KeyChar;

            if (char.IsDigit(e.KeyChar))
            {
                angka = angka + n;
            }
            else
            {
                angka = angka.Substring(0, angka.Length - 1);
            }


            try
            {
                txtBiaya.Text = toRupiah(Convert.ToInt32(angka));
            }
            catch(Exception ex)
            {
                txtBiaya.Text = toRupiah(0);
            }
            hitungTotalHarga();
            
        }

        private void txtBiaya_KeyUp(object sender, KeyEventArgs e)
        {
            //txtBiaya.Text = toRupiah(biaya);
        }

        private void tableKomponen_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            tableKomponen.Rows[e.RowIndex].Selected = true;
            txtnama_komponen.Text = tableKomponen[2, e.RowIndex].Value.ToString();
            getHarga();
            hitungHarga();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            string status = rbSelesai.Checked ? "Selesai" : "Gagal";
            if (txtid_gudang.Text.Equals("") || txtkode_transaksi.Text.Equals(""))
            {
                MessageBox.Show("Periksa kembali data", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult n = MessageBox.Show("Simpan perubahan ?", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (n.Equals(DialogResult.OK))
            {

            }
            else
            {
                MessageBox.Show("Dibatalkan","",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_reparasiselesai", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();


                
                myCommand.Parameters.AddWithValue("no_transaksi_reparasi", txtkode_transaksi.Text);
                myCommand.Parameters.AddWithValue("id_gudang", txtid_gudang.Text);
                myCommand.Parameters.AddWithValue("total", toAngka(txtTotalHarga.Text));
                myCommand.Parameters.AddWithValue("biaya", toAngka(txtBiaya.Text));
                myCommand.Parameters.AddWithValue("status", status);



                myCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Berhasil menyimpan data","",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);

                

                //simpan detail
                for(int i = 0; i < tableKomponen.RowCount; i++)
                {
                    myCommand = new SqlCommand("sp_inputTDetailReparasi", connection);

                    myCommand.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    myCommand.Parameters.AddWithValue("no_transaksi_reparasi", txtkode_transaksi.Text);
                    myCommand.Parameters.AddWithValue("id_komponen", tableKomponen[1,i].Value.ToString());
                    myCommand.Parameters.AddWithValue("jumlah_komponen", tableKomponen[3, i].Value.ToString());
                    myCommand.Parameters.AddWithValue("harga", (toAngka(tableKomponen[4, i].Value.ToString()).ToString()));

                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }
                for (int i = 0; i < tableKomponen.RowCount; i++)
                {
                    myCommand = new SqlCommand("sp_updateJumlahKomponen", connection);

                    myCommand.CommandType = CommandType.StoredProcedure;
                    connection.Open();

                    
                    myCommand.Parameters.AddWithValue("id_komponen", tableKomponen[1, i].Value.ToString());
                    myCommand.Parameters.AddWithValue("jumlah", tableKomponen[3, i].Value.ToString());
                    

                    myCommand.ExecuteNonQuery();
                    connection.Close();
                }

                if (cmbSortir.Text.Equals("Semua"))
                {
                    addDataReparasi();
                }
                else
                {
                    addDataReparasi(cmbSortir.Text);
                }
                
                tableKomponen.Rows.Clear();
                txtBiaya.Text = "0.00";
                txtid_gudang.Text = "- ID GUDANG -";
                //hitungHarga();
                hitungTotalHarga();
                //detailtransaksi();
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

        private void rbSelesai_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSelesai.Checked)
            {
                btnTambah.Enabled = true;
            }
            else
            {
                btnTambah.Enabled = false;
            }
        }

        private void cmbSortir_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSortir.Text.Equals("Semua"))
            {
                addDataReparasi();return;
            }
            addDataReparasi(cmbSortir.Text);
        }
    }
}
