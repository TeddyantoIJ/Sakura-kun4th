using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class UpdateAlatKomponenSupplier : Form
    {
        public UpdateAlatKomponenSupplier()
        {
            InitializeComponent();
            addSourceViewAlat();
            addSourceViewKomponen();
            
        }

        private void UpdateAlatKomponenSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'komponenSupplier.mskomponensupplier' table. You can move, or remove it, as needed.
            //this.mskomponensupplierTableAdapter.Fill(this.komponenSupplier.mskomponensupplier);

        }
        private void addSourceViewAlat()
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter("select ROW_NUMBER() over(order by nama_alat asc) No, [msalatkerja].nama_alat as [Nama Alat], [mssupplier].nama_supplier as [Nama Supplier], convert(numeric(10,2), harga)  as [Harga(Rp)] from[msalatsupplier] " +
                    "inner join[msalatkerja] on[msalatkerja].id_alat = [msalatsupplier].id_alat " +
                    "inner join[mssupplier] on [mssupplier].id_supplier = [msalatsupplier].id_supplier", connection);
                
                DataTable data = new DataTable();
                adapter.Fill(data);

                viewAlatSupplier.DataSource = data;

                this.viewAlatSupplier.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.viewAlatSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.viewAlatSupplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.viewAlatSupplier.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.viewAlatSupplier.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                //by = 1;
                connection.Close();
               
            }
            catch (Exception)
            {
                //btnUpdate.Enabled = false;
                //this.msalatkerjaTableAdapter.Fill(this.sakuraDataDataSet2.msalatkerja);
                //clear();
            }
        }
        private void addSourceViewKomponen()
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlDataAdapter adapter = new SqlDataAdapter("select ROW_NUMBER() over(order by nama_komponen asc) No, [mskomponen].nama_komponen as [Nama Komponen], [mssupplier].nama_supplier," +
                    " convert(numeric(10,2), harga)  as [Harga(Rp)] from[mskomponensupplier] inner join[mskomponen]"+
                    " on [mskomponensupplier].id_komponen = [mskomponen].id_komponen inner join[mssupplier] on[mssupplier].id_supplier = [mskomponensupplier].id_supplier", connection);

                DataTable data = new DataTable();
                adapter.Fill(data);

                viewKomponenSupplier.DataSource = data;

                this.viewKomponenSupplier.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.viewKomponenSupplier.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.viewKomponenSupplier.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.viewKomponenSupplier.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                this.viewKomponenSupplier.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
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

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(cbAlat.Checked == true)
            {
                clear();
                cbKomponen.Checked = false;
                viewAlatSupplier.Enabled = true;
                pembaruanAlat.Enabled = true;
                
            }
            else
            {
               
                cbKomponen.Checked = true;
                viewAlatSupplier.Enabled = false;
                pembaruanAlat.Enabled = false;
                
            }
        }

        private void cbKomponen_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKomponen.Checked == true)
            {
                clear();
                cbAlat.Checked = false;
                viewKomponenSupplier.Enabled = true;
                pembaruanKomponen.Enabled = true;
                
            }
            else
            {
                
                cbAlat.Checked = true;
                viewKomponenSupplier.Enabled = false;
                pembaruanKomponen.Enabled = false;
               
            }
        }
        int selectedRow;
        private void viewAlatSupplier_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            Int32 selectedRowCount =
            viewAlatSupplier.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            if (selectedRowCount > 0 && selectedRowCount <= 1)
            {
                btnUpdate.Enabled = true;
                btnBatal.Enabled = true;
                // clear();
                //by = 0;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    selectedRow = Int32.Parse(viewAlatSupplier.SelectedRows[i].Index.ToString());
                }
                DataGridViewRow row = viewAlatSupplier.Rows[selectedRow];
                txtnama_alat.Text = row.Cells[1].Value.ToString();
                txtnama_supplier.Text = row.Cells[2].Value.ToString();
                int harga = (row.Cells[3].Value.ToString()).Length;

                txtharga.Text = (row.Cells[3].Value.ToString()).Substring(0,(harga-3));
            }
            else if (btnUpdate.Enabled == true)
            {
                btnUpdate.Enabled = false;
                btnBatal.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
        private void getid_alat()
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariAlatKerja", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtnama_alat.Text;

                myCommand.Parameters.AddWithValue("id_alat", pencarian);
                myCommand.Parameters.AddWithValue("nama_alat", pencarian);
                myCommand.Parameters.AddWithValue("jumlah", -1);
                myCommand.Parameters.AddWithValue("bagus", -1);
                myCommand.Parameters.AddWithValue("rusak", -1);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                txtid_alat.Text = "";
                txtid_alat.Text = data.Rows[0][0].ToString();
                
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
               

                //btnUpdate.Enabled = false;
                //clear();
            }
        }
        private void getid_supplier()
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariSupplier", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian;
                if (cbAlat.Checked == true)
                {
                    pencarian = txtnama_supplier.Text;
                }
                else
                {
                    pencarian = txtnama_supplier1.Text;
                }
                

                myCommand.Parameters.AddWithValue("id_supplier", pencarian);
                myCommand.Parameters.AddWithValue("nama_supplier", pencarian);
                myCommand.Parameters.AddWithValue("contact_person", pencarian);
                myCommand.Parameters.AddWithValue("no_telepon", pencarian);
                myCommand.Parameters.AddWithValue("alamat", pencarian);
                myCommand.Parameters.AddWithValue("keterangan", pencarian);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                txtid_supplier.Text = "";
                txtid_supplier1.Text = "";
                if (cbAlat.Checked == true)
                {
                    txtid_supplier.Text = data.Rows[0][0].ToString();
                }
                else
                {
                    txtid_supplier1.Text = data.Rows[0][0].ToString();
                }
                
                
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                //MessageBox.Show(ex.ToString());
                //btnUpdate.Enabled = false;
                //clear();
                
            }
        }
        private void txtnama_alat_TextChanged(object sender, EventArgs e)
        {
            getid_alat();
        }

        private void txtnama_supplier_TextChanged(object sender, EventArgs e)
        {
            getid_supplier();
        }

        private void viewKomponenSupplier_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

            Int32 selectedRowCount =
            viewKomponenSupplier.Rows.GetRowCount(DataGridViewElementStates.Selected);
            
            if (selectedRowCount > 0 && selectedRowCount <= 1)
            {
                btnUpdate.Enabled = true;
                btnBatal.Enabled = true;
                // clear();
                //by = 0;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    selectedRow = Int32.Parse(viewKomponenSupplier.SelectedRows[i].Index.ToString());
                }
                DataGridViewRow row = viewKomponenSupplier.Rows[selectedRow];
                txtnama_komponen.Text = row.Cells[1].Value.ToString();
                txtnama_supplier1.Text = row.Cells[2].Value.ToString();

                int harga = (row.Cells[3].Value.ToString()).Length;

                txtharga1.Text = (row.Cells[3].Value.ToString()).Substring(0, (harga - 3));
            }
            else if (btnUpdate.Enabled == true)
            {
                btnUpdate.Enabled = false;
                btnBatal.Enabled = true;
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void txtnama_supplier1_TextChanged(object sender, EventArgs e)
        {
            getid_supplier();
        }

        private void txtharga_KeyUp(object sender, KeyEventArgs e)
        {
            if(cbAlat.Checked == false)
            {
                if(txtharga.Text == "")
                {
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void txtharga1_KeyUp(object sender, KeyEventArgs e)
        {
            if(cbKomponen.Checked == true)
            {
                if(txtharga1.Text == "")
                {
                    btnUpdate.Enabled = false;
                }
                else
                {
                    btnUpdate.Enabled = true;
                }
            }
        }

        private void pembaruanAlat_EnabledChanged(object sender, EventArgs e)
        {
            
        }

        private void pembaruanKomponen_EnabledChanged(object sender, EventArgs e)
        {
            
        }
        private void clear()
        {

                txtnama_alat.Text = "";
                txtnama_supplier.Text = "";
                txtharga.Text = "";
                txtnama_komponen.Text = "";
                txtnama_supplier1.Text = "";
                txtharga1.Text = "";

        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            addSourceViewAlat();
            addSourceViewKomponen();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cbAlat.Checked == true)
            {

                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                    "Nama Alat\t: " + txtnama_alat.Text + "\n" +
                    "Nama Supplier\t: " + txtnama_supplier.Text + "\n" +
                    "Harga \t\t: Rp " + string.Format(CultureInfo.GetCultureInfo("de-DE"), "{0:n}", Int32.Parse(txtharga.Text))
                    , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    updateDBAlat();
                    clear();
                    
                    addSourceViewAlat();
                }
                else
                {
                    MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {

                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                    "Nama Komponen\t: " + txtnama_komponen.Text + "\n" +
                    "Nama Supplier\t: " + txtnama_supplier1.Text + "\n" +
                    "Harga \t\t: Rp " + string.Format(CultureInfo.GetCultureInfo("de-DE"), "{0:n}", Int32.Parse(txtharga1.Text))
                    , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    updateDBKomponen();
                    clear();
                    
                    addSourceViewKomponen();
                }
                else
                {
                    MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void updateDBAlat()
        {
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_updateAlatSupplierHarga", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string id_alat = txtid_alat.Text;
                string id_supplier = txtid_supplier.Text;
                string harga = txtharga.Text;

                SqlParameter param = new SqlParameter();

                myCommand.Parameters.AddWithValue("id_alat", id_alat);
                myCommand.Parameters.AddWithValue("id_supplier", id_supplier);
                myCommand.Parameters.AddWithValue("harga", harga);
                

                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void updateDBKomponen()
        {
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_updateKomponenSupplierHarga", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string id_komponen = txtid_komponen.Text;
                string id_supplier = txtid_supplier1.Text;
                string harga = txtharga1.Text;


                SqlParameter param = new SqlParameter();

                myCommand.Parameters.AddWithValue("id_komponen", id_komponen);
                myCommand.Parameters.AddWithValue("id_supplier", id_supplier);
                myCommand.Parameters.AddWithValue("harga", harga);
                

                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txtnama_komponen_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariKomponen", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtnama_komponen.Text;

                myCommand.Parameters.AddWithValue("id_komponen", "XXX");
                myCommand.Parameters.AddWithValue("nama_komponen", pencarian);
                myCommand.Parameters.AddWithValue("jumlah", -1);
                myCommand.Parameters.AddWithValue("harga_jual", 0);
                myCommand.Parameters.AddWithValue("id_alat", "XXX");
                myCommand.Parameters.AddWithValue("tempat", pencarian);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);

                txtid_komponen.Text = "";
                txtid_komponen.Text = data.Rows[0][0].ToString();

                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception)
            {

                //btnUpdate.Enabled = false;
                //clear();
            }
        }
    }
}
