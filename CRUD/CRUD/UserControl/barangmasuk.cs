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
    public partial class barangmasuk : UserControl
    {

        private int selectedRestock = 0;
        private int selectedDetail = 0;
        public barangmasuk()
        {
            InitializeComponent();
            addDataTransaksi();
        }


        public void addDataTransaksi()
        {
            tableRestock.DataSource = null;
            tableRestock.Columns.Clear();
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
                tableRestock.DataSource = data;

                foreach (DataGridViewColumn col in tableRestock.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                

                this.tableRestock.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                this.tableRestock.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableRestock.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableRestock.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableRestock.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableRestock.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
        public void addDataTransaksiSorting(string init)
        {
            string status = "";
            if (init.Equals("Semua"))
            {
                addDataTransaksi(); return;
            }else if (init.Equals("Terkonfirmasi"))
            {
                status = "Sukses";
            }else if(init.Equals("Belum dikonfirmasi"))
            {
                status = "Proses";
            }else if (init.Equals("Gagal"))
            {
                status = "Gagal";
            }
            tableRestock.DataSource = null;
            tableRestock.Columns.Clear();
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
                tableRestock.DataSource = data;

                foreach (DataGridViewColumn col in tableRestock.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }



                this.tableRestock.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                this.tableRestock.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableRestock.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableRestock.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableRestock.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableRestock.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

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
        private void tableRestock_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 selectedRow = tableRestock.Rows.GetRowCount(DataGridViewElementStates.Selected);

            if(selectedRow > 0 && selectedRow <= 1)
            {
                btnCheck.Enabled = true;
            }
            else
            {
                btnCheck.Enabled = false;
            }
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Int32 selectedRow = tableRestock.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            for (int i = 0; i < selectedRow; i++)
            {
                selectedRestock = Int32.Parse(tableRestock.SelectedRows[i].Index.ToString());
            }
            
            addDataDetail(tableRestock[1, selectedRestock].Value.ToString());
        }
        public void addDataDetail(string pembelian)
        {
            tableDetail.Columns.Clear();
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
                tableDetail.DataSource = data;

                foreach (DataGridViewColumn col in tableDetail.Columns)
                {
                    col.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    col.HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                
                this.tableDetail.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                this.tableDetail.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableDetail.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableDetail.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableDetail.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableDetail.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.tableDetail.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableDetail.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                this.tableDetail.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private void button1_Click(object sender, EventArgs e)
        {
            Int32 selectedRow = tableDetail.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            for (int i = 0; i < selectedRow; i++)
            {
                selectedDetail = Int32.Parse(tableDetail.SelectedRows[i].Index.ToString());
            }

            if (!tableDetail[5, selectedDetail].Value.ToString().Equals("Proses"))
            {
                MessageBox.Show("Tidak dapat dikonfirmasi lagi", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            setStatusDetail(1);
            setTotalTransaksiKomponen(tableDetail[1, selectedRow].Value.ToString(), tableDetail[2, selectedRow].Value.ToString());
            addDataDetail(tableRestock[1, selectedRestock].Value.ToString());
            
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


                myCommand.Parameters.AddWithValue("id_komponen", getIDKomponen(komponen));
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
        private void setStatusDetail(int i)
        {
            string status = "";
            if(i == 0)
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
                myCommand.Parameters.Add(new SqlParameter("id_komponen", getIDKomponen(tableDetail[1, selectedDetail].Value.ToString())));
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
                myCommand.Parameters.Add(new SqlParameter("id_komponen", getIDKomponen(tableDetail[1, selectedDetail].Value.ToString())));
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

        private void btnGagal_Click(object sender, EventArgs e)
        {
            Int32 selectedRow = tableDetail.Rows.GetRowCount(DataGridViewElementStates.Selected);

            for (int i = 0; i < selectedRow; i++)
            {
                selectedDetail = Int32.Parse(tableDetail.SelectedRows[i].Index.ToString());
            }
            if(!tableDetail[5, selectedDetail].Value.ToString().Equals("Proses"))
            {
                MessageBox.Show("Tidak dapat dikonfirmasi lagi", "Peringatan!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return;
            }
            setStatusDetail(0);
            addDataDetail(tableRestock[1, selectedRestock].Value.ToString());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            addDataTransaksiSorting(cmbSortir.SelectedItem.ToString());
        }

        private void tableDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Int32 select = tableDetail.Rows.GetRowCount(DataGridViewElementStates.Selected);
            for(int i = 0; i < select; i++)
            {
                lblNomor.Text = (Int32.Parse(tableDetail.SelectedRows[i].Index.ToString())+1).ToString();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            addDataTransaksi();
        }
    }
    
}
