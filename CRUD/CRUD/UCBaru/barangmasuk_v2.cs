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
    public partial class barangmasuk_v2 : UserControl
    {
        private int selectedRestock = 0;
        private int selectedDetail = 0;
        public barangmasuk_v2()
        {
            InitializeComponent();
            addDataTransaksiSorting("Belum dikonfirmasi");
        }
        public void addDataTransaksiSorting(string init)
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
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_getRestockByStatus", myConnection);
                myCommand.Parameters.Add(new SqlParameter("status", status));
                myCommand.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable data = new DataTable();

                adapter.SelectCommand = myCommand;
                adapter.Fill(data);
                //tableRestock.DataSource = data;

                foreach (DataGridViewColumn col in tableRestock.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    //col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }



                //PENGISIAN PADA DATA GRID
                for (int i = 0; i < data.Rows.Count; i++)
                {
                    string harga = "Rp " + toRupiah(Convert.ToInt32(data.Rows[i][3].ToString().Substring(0, data.Rows[i][3].ToString().Length - 3)));
                    DateTime date = Convert.ToDateTime(data.Rows[i][4].ToString());
                    Object[] n = { (i + 1) + ".", data.Rows[i][0].ToString(), data.Rows[i][1].ToString(), data.Rows[i][2].ToString(), harga, date.ToString("dd-MM-yyyy") };
                    tableRestock.Rows.Add(n);
                }

                this.tableRestock.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableRestock.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableRestock.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableRestock.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableRestock.Columns[5].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void addDataTransaksi()
        {
            
            tableRestock.Rows.Clear();
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_getAlltrestockkomponen", myConnection);
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
                    string harga = "Rp " + toRupiah(Convert.ToInt32(data.Rows[i][3].ToString().Substring(0, data.Rows[i][3].ToString().Length-3)));
                    DateTime date = Convert.ToDateTime(data.Rows[i][4].ToString());
                    Object[] n = { (i + 1) + ".", data.Rows[i][0].ToString(), data.Rows[i][1].ToString(), data.Rows[i][2].ToString(), harga, date.ToString("dd-MM-yyyy")};
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

            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "{0:N}", angka);

        }

        public int toAngka(string rupiah)

        {

            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));

        }
        public void addDataDetail(string pembelian)
        {
            tableDetail.Rows.Clear();
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_getAlltdetailrestock", myConnection);
                myCommand.Parameters.Add(new SqlParameter("no_pembelian_komponen", pembelian));
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
                    string harga = "Rp " + toRupiah(Convert.ToInt32(data.Rows[i][3].ToString().Substring(0, data.Rows[i][3].ToString().Length - 3)));
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
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void tableRestock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            enabledBtn(null);
            selectedRestock = i;
            if(e.RowIndex == -1)
            {
                return;
            }
            tableRestock.Rows[i].Selected = true;
            addDataDetail(tableRestock[1, i].Value.ToString());
        }

        private void btnSukses_Click(object sender, EventArgs e)
        {
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
            catch(Exception ex)
            {

            }
            
        }
        private void setTotalTransaksiKomponen(string komponen, string supplier)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_setTotalTransaksiKomponen", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();


                myCommand.Parameters.AddWithValue("id_komponen", getIDKomponenByNamadanSupplier(komponen,supplier));
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
        private void btnGagal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Gagal transaksi dipilih", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            enabledBtn(btnGagal);
        }

        private void tableDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            enabledBtn(null);
            selectedDetail = i;
            if(i == -1)
            {
                return;
            }
            tableDetail.Rows[i].Selected = true;

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

                SqlCommand myCommand = new SqlCommand("sp_setStatusDetailRestock", myConnection);
                myCommand.Parameters.Add(new SqlParameter("no_pembelian_komponen", tableRestock[1, selectedRestock].Value.ToString()));
                myCommand.Parameters.Add(new SqlParameter("id_komponen", getIDKomponenByNamadanSupplier(tableDetail[1, selectedDetail].Value.ToString(), tableDetail[2, selectedDetail].Value.ToString())));
                myCommand.Parameters.Add(new SqlParameter("status", status));
                myCommand.CommandType = CommandType.StoredProcedure;



                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Berhasil Mengkonfirmasi!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (status.Equals("Sukses"))
                {
                    setJumlahKomponen();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void setJumlahKomponen()
        {
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();
                MessageBox.Show(tableDetail[1, selectedDetail].Value.ToString() + "  " + tableDetail[2, selectedDetail].Value.ToString());
                SqlCommand myCommand = new SqlCommand("sp_setJumlahKomponen", myConnection);
                myCommand.Parameters.Add(new SqlParameter("id_komponen", getIDKomponenByNamadanSupplier(tableDetail[1, selectedDetail].Value.ToString(), tableDetail[2, selectedDetail].Value.ToString())));
                myCommand.Parameters.Add(new SqlParameter("jumlah", tableDetail[3, selectedDetail].Value.ToString()));
                myCommand.CommandType = CommandType.StoredProcedure;



                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private string getIDKomponenByNamadanSupplier(string komponen, string supplier)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariKomponenByNamaSupplier", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("nama_komponen", komponen);
                myCommand.Parameters.AddWithValue("nama_supplier", supplier);

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

        private void btnKonfirmasi_Click(object sender, EventArgs e)
        {
            if (!btnSukses.Enabled)
            {
                Int32 selectedRow = tableDetail.Rows.GetRowCount(DataGridViewElementStates.Selected);

                for (int i = 0; i < selectedRow; i++)
                {
                    selectedDetail = Int32.Parse(tableDetail.SelectedRows[i].Index.ToString());
                }

                if (!tableDetail[5, selectedDetail].Value.ToString().Equals("Proses"))
                {
                    MessageBox.Show("Tidak dapat dikonfirmasi lagi", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    setStatusDetail(1);
                    setTotalTransaksiKomponen(tableDetail[1, selectedDetail].Value.ToString(), tableDetail[2, selectedDetail].Value.ToString());
                    addDataDetail(tableRestock[1, selectedRestock].Value.ToString());
                }

                
            }
            else
            {
                Int32 selectedRow = tableDetail.Rows.GetRowCount(DataGridViewElementStates.Selected);

                for (int i = 0; i < selectedRow; i++)
                {
                    selectedDetail = Int32.Parse(tableDetail.SelectedRows[i].Index.ToString());
                }
                if (!tableDetail[5, selectedDetail].Value.ToString().Equals("Proses"))
                {
                    MessageBox.Show("Tidak dapat dikonfirmasi lagi", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    setStatusDetail(0);
                    addDataDetail(tableRestock[1, selectedRestock].Value.ToString());
                }
            }
            enabledBtn(null);
            tableDetail.Rows[0].Selected = true;
            //tableRestock.Rows[0].Selected = true;
        }

        private void cmbSortir_SelectedIndexChanged(object sender, EventArgs e)
        {
            addDataTransaksiSorting(cmbSortir.Text);
            tableDetail.Rows.Clear();
        }
    }
}
