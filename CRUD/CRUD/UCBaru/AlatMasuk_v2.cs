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
    public partial class AlatMasuk_v2 : UserControl
    {
        public AlatMasuk_v2()
        {
            InitializeComponent();
            addDataTransaksi("Belum dikonfirmasi");
        }
        public void addDataTransaksi()
        {

            tableRestock.Rows.Clear();
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_getAllDetailRestockAlat", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();

                adapter.SelectCommand = myCommand;
                adapter.Fill(data);
                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();

                foreach (DataGridViewColumn col in tableRestock.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }
                

                //PENGISIAN PADA DATA GRID
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string harga = "Rp " + toRupiah(Convert.ToInt32(data.Rows[i][3].ToString().Substring(0, data.Rows[i][3].ToString().Length - 5)));
                    DateTime date = Convert.ToDateTime(data.Rows[i][4].ToString());
                    Object[] n = { (i + 1) + ".", data.Rows[i][0].ToString(), data.Rows[i][1].ToString(), data.Rows[i][2].ToString(), harga, date.ToString("dd-MM-yyyy") };
                    tableRestock.Rows.Add(n);
                }

                this.tableRestock.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableRestock.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableRestock.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableRestock.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableRestock.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableRestock.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void addDataTransaksi(string init)
        {
            string status = "";
            if (init.Equals("Semua"))
            {
                addDataTransaksi(); return;
            }
            else if (init.Equals("Terkonfirmasi"))
            {
                status = "Sukses";
            }
            else if (init.Equals("Belum dikonfirmasi"))
            {
                status = "Proses";
            }
            else if (init.Equals("Gagal"))
            {
                status = "Gagal";
            }
            //tableRestock.DataSource = null;
            tableRestock.Rows.Clear();

            tableRestock.Rows.Clear();
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_getAllDetailRestockAlatbyStatus", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();

                myCommand.Parameters.AddWithValue("status", status);
                DataTable data = new DataTable();

                adapter.SelectCommand = myCommand;
                adapter.Fill(data);
                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();

                foreach (DataGridViewColumn col in tableRestock.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }


                //PENGISIAN PADA DATA GRID
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string harga = "Rp " + toRupiah(Convert.ToInt32(data.Rows[i][3].ToString().Substring(0, data.Rows[i][3].ToString().Length - 5)));
                    DateTime date = Convert.ToDateTime(data.Rows[i][4].ToString());
                    Object[] n = { (i + 1) + ".", data.Rows[i][0].ToString(), data.Rows[i][1].ToString(), data.Rows[i][2].ToString(), harga, date.ToString("dd-MM-yyyy") };
                    tableRestock.Rows.Add(n);
                }

                this.tableRestock.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableRestock.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableRestock.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableRestock.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableRestock.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableRestock.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public string toRupiah(int angka)

        {

            return String.Format(System.Globalization.CultureInfo.CreateSpecificCulture("id-id"), "{0:N}", angka);

        }

        public int toAngka(string rupiah)

        {

            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));

        }

        private void cmbSortir_SelectedIndexChanged(object sender, EventArgs e)
        {
            addDataTransaksi(cmbSortir.Text);
            enabledBtn(null);
        }

        private void tableRestock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            if(i == -1)
            {
                return;
            }
            tableRestock.Rows[i].Selected = true;
            addDataDetail(tableRestock[1, i].Value.ToString());
            enabledBtn(null);
        }
        public void addDataDetail(string kode)
        {
            tableDetail.Rows.Clear();
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_getAllDetailRestockAlatByKode", myConnection);
                myCommand.Parameters.Add(new SqlParameter("no_transaksi_pembelian", kode));
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();

                adapter.SelectCommand = myCommand;
                adapter.Fill(data);
                //tableDetail.DataSource = data;

                foreach (DataGridViewColumn col in tableDetail.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }



                //PENGISIAN PADA DATA GRID
                // NO \ KOMPONEN \ SUPPLIER \ JUMLAH \ HARGA \ STATUS
                // KOMPONEN \ SUPPLIER \ JUMLAH \ HARGA \ STATUS
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string harga = "Rp " + toRupiah(Convert.ToInt32(data.Rows[i][3].ToString().Substring(0, data.Rows[i][3].ToString().Length - 5)));
                    Object[] n = { (i + 1) + ".", data.Rows[i][0].ToString(), data.Rows[i][1].ToString(), data.Rows[i][2].ToString(), harga, data.Rows[i][4].ToString() };
                    tableDetail.Rows.Add(n);
                }

                this.tableDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableDetail.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                this.tableDetail.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                try
                {
                    tableDetail.Rows[0].Selected = true;
                }catch(Exception ex)
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            btnGagal.Enabled = true;
            btnSukses.Enabled = true;
            if(i == -1)
            {
                return;
            }
            tableDetail.Rows[i].Selected = true;
        }

        private void btnSukses_Click(object sender, EventArgs e)
        {
            if(tableDetail.Rows.Count == 0)
            {
                return;
            }
            MessageBox.Show("Sukses transaksi dipilih", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            enabledBtn(btnSukses);
        }
        private void enabledBtn(Bunifu.Framework.UI.BunifuFlatButton n)
        {
            btnSukses.Enabled = true;
            btnGagal.Enabled = true;

            try
            {
                n.Enabled = false;
            }
            catch (Exception ex)
            {

            }

        }

        private void btnGagal_Click(object sender, EventArgs e)
        {
            if (tableDetail.Rows.Count == 0)
            {
                return;
            }
            MessageBox.Show("Gagal transaksi dipilih", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            enabledBtn(btnGagal);
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
        private void setStatusDetail(int i)
        {
            string status = "";
            if (i == 0)
            {
                status = "Gagal";
            }
            else
            {
                status = "Sukses";
            }
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_updateStatusTRA", myConnection);
                myCommand.Parameters.Add(new SqlParameter("kode", tableRestock[1, tableRestock.CurrentRow.Index].Value.ToString()));
                myCommand.Parameters.Add(new SqlParameter("supplier", getIDSupplier(tableDetail[2,tableDetail.CurrentRow.Index].Value.ToString())));
                myCommand.Parameters.Add(new SqlParameter("alat", getIDAlatKerja(tableDetail[1,tableDetail.CurrentRow.Index].Value.ToString())));
                myCommand.Parameters.Add(new SqlParameter("status", status));
                myCommand.CommandType = CommandType.StoredProcedure;



                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Berhasil Mengkonfirmasi! " + "\n" + tableRestock[1, tableRestock.CurrentRow.Index].Value.ToString()+"\n" + getIDSupplier(tableDetail[2, tableDetail.CurrentRow.Index].Value.ToString())+"\n"+ getIDAlatKerja(tableDetail[1, tableDetail.CurrentRow.Index].Value.ToString()), "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (status.Equals("Sukses"))
                {
                    setJumlahAlat();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void setJumlahAlat()
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";
                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_updateAlatKerja1", connection);

                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

         

                myCommand.Parameters.AddWithValue("id_alat", getIDAlatKerja(tableDetail[1,tableDetail.CurrentRow.Index].Value.ToString()));
                myCommand.Parameters.AddWithValue("jumlah", tableDetail[3,tableDetail.CurrentRow.Index].Value.ToString());
                myCommand.Parameters.AddWithValue("bagus", tableDetail[3, tableDetail.CurrentRow.Index].Value.ToString());
                myCommand.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.ToString());
            }
        }
        private void setTotalTransaksiAlat(string komponen, string supplier)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_setTotalTransaksiAlat", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();


                myCommand.Parameters.AddWithValue("id_alat", getIDAlatKerja(komponen));
                myCommand.Parameters.AddWithValue("id_supplier", getIDSupplier(supplier));

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
        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (!btnSukses.Enabled)
            {
                
                if (!tableDetail[5, tableDetail.CurrentRow.Index].Value.ToString().Equals("Proses"))
                {
                    MessageBox.Show("Tidak dapat dikonfirmasi lagi", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    setStatusDetail(1);
                    setTotalTransaksiAlat(tableDetail[1, tableDetail.CurrentRow.Index].Value.ToString(), tableDetail[2, tableDetail.CurrentRow.Index].Value.ToString());
                    addDataDetail(tableRestock[1, tableRestock.CurrentRow.Index].Value.ToString());
                }


            }
            else if(!btnGagal.Enabled)
            {
                
                if (!tableDetail[5, tableDetail.CurrentRow.Index].Value.ToString().Equals("Proses"))
                {
                    MessageBox.Show("Tidak dapat dikonfirmasi lagi", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    setStatusDetail(0);
                    addDataDetail(tableRestock[1, tableRestock.CurrentRow.Index].Value.ToString());
                }
            }
            else
            {
                MessageBox.Show("|  Pilih pilihan konfirmasi yang ada     | \n" +
                                "|  Sukses berarti transaksi berhasil     |\n" +
                                "|  Gagal untuk transaksi tidak berhasil  |", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            enabledBtn(null);
            tableDetail.Rows[0].Selected = true;
            //tableRestock.Rows[0].Selected = true;
        }
    }
}
