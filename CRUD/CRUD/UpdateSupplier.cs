using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class UpdateSupplier : Form
    {
        public UpdateSupplier()
        {
            InitializeComponent();
        }
        int by = 0;
        private void UpdateSupplier_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakuraDataDataSet.mssupplier' table. You can move, or remove it, as needed.
            this.mssupplierTableAdapter.Fill(this.sakuraDataDataSet.mssupplier);

        }
        private void txtnama_supplier_Leave(object sender, EventArgs e)
        {
            if (txtnama_supplier.Text == "")
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                infonama_supplier.Text = "Wajib diisi!";

            }
            else
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Green;
                infonama_supplier.Text = "Sesuai";
            }
        }

        private void txtcontact_person_Leave(object sender, EventArgs e)
        {
            if (txtcontact_person.Text == "")
            {

                infocontact_person.ForeColor = System.Drawing.Color.Red;
                infocontact_person.Text = "Wajib diisi!";
            }
            else
            {

                infocontact_person.ForeColor = System.Drawing.Color.Green;
                infocontact_person.Text = "Sesuai";
            }

        }

        private void txtno_telepon_Leave(object sender, EventArgs e)
        {
            if (txtno_telepon.Text == "")
            {

                infono_telepon.ForeColor = System.Drawing.Color.Red;
                infono_telepon.Text = "Wajib diisi!";
            }
            else
            {

                infono_telepon.ForeColor = System.Drawing.Color.Green;
                infono_telepon.Text = "Sesuai";
            }

        }

        private void txtalamat_Leave(object sender, EventArgs e)
        {
            if (txtalamat.Text == "")
            {

                infoalamat.ForeColor = System.Drawing.Color.Red;
                infoalamat.Text = "Wajib diisi!";
            }
            else
            {

                infoalamat.ForeColor = System.Drawing.Color.Green;
                infoalamat.Text = "Sesuai";
            }
        }

        int selectedRow;
        private void viewSupplier_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            
            Int32 selectedRowCount =
        viewSupplier.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount  <= 1)
            {
                btnUpdate.Enabled = true;
                clear();
                by = 0;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    selectedRow = Int32.Parse(viewSupplier.SelectedRows[i].Index.ToString());  
                }
                DataGridViewRow row = viewSupplier.Rows[selectedRow];
                txtid_supplier.Text = row.Cells[0].Value.ToString();
                txtnama_supplier.Text = row.Cells[1].Value.ToString();
                txtcontact_person.Text = row.Cells[2].Value.ToString();
                txtno_telepon.Text = row.Cells[3].Value.ToString();
                txtalamat.Text = row.Cells[4].Value.ToString();
                txtketerangan.Text = row.Cells[5].Value.ToString();

            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(selectedRow.ToString());
            if(by == 0)
            {
                btnBatal.Enabled = true;
                btnUpdate.Enabled = false;
                updateGrup.Enabled = true;
            }
            else
            {
                btnBatal.Enabled = true;
                btnUpdate.Enabled = false;
                updateGrup.Enabled = true;
            }
            
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            bool benar = true;
            if (txtnama_supplier.Text == "")
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Red;
                infonama_supplier.Text = "Wajib diisi!";
                benar = false;
            }
            else
            {
                infonama_supplier.ForeColor = System.Drawing.Color.Green;
                infonama_supplier.Text = "Sesuai";
            }
            if (txtcontact_person.Text == "")
            {
                benar = false;
                infocontact_person.ForeColor = System.Drawing.Color.Red;
                infocontact_person.Text = "Wajib diisi!";
            }
            else
            {

                infocontact_person.ForeColor = System.Drawing.Color.Green;
                infocontact_person.Text = "Sesuai";
            }
            if (txtno_telepon.Text == "")
            {
                benar = false;
                infono_telepon.ForeColor = System.Drawing.Color.Red;
                infono_telepon.Text = "Wajib diisi!";
            }
            else
            {

                infono_telepon.ForeColor = System.Drawing.Color.Green;
                infono_telepon.Text = "Sesuai";
            }
            if (txtalamat.Text == "")
            {
                benar = false;
                infoalamat.ForeColor = System.Drawing.Color.Red;
                infoalamat.Text = "Wajib diisi!";
            }
            else
            {

                infoalamat.ForeColor = System.Drawing.Color.Green;
                infoalamat.Text = "Sesuai";
            }

            if (benar)
            {
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                    "ID Supplier\t: " + txtid_supplier.Text + "\n" +
                    "Nama Supplier\t: " + txtnama_supplier.Text + "\n" +
                    "Contact Person\t: " + txtcontact_person.Text + "\n" +
                    "No Telepon\t: " + txtno_telepon.Text + "\n" +
                    "Alamat\t\t: " + txtalamat.Text + "\n" +
                    "Keterangan\t: " + txtketerangan.Text
                    , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    updateDB();
                }
                else
                {
                    MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                }

            }
            this.mssupplierTableAdapter.Fill(this.sakuraDataDataSet.mssupplier);

        }

        private void updateDB()
        {
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_updateSupplier", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string id_supplier = txtid_supplier.Text;
                string nama_supplier = txtnama_supplier.Text;
                string contact_person = txtcontact_person.Text;
                string no_telepon = txtno_telepon.Text;
                string alamat = txtalamat.Text;
                string keterangan = txtketerangan.Text;
                SqlParameter param = new SqlParameter();

                myCommand.Parameters.AddWithValue("id_supplier", id_supplier);
                myCommand.Parameters.AddWithValue("nama_supplier", nama_supplier);
                myCommand.Parameters.AddWithValue("contact_person", contact_person);
                myCommand.Parameters.AddWithValue("no_telepon", no_telepon);
                myCommand.Parameters.AddWithValue("alamat", alamat);
                myCommand.Parameters.AddWithValue("keterangan", keterangan);


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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.mssupplierTableAdapter.Fill(this.sakuraDataDataSet.mssupplier);
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            updateGrup.Enabled = false;
            btnBatal.Enabled = false;

            txtid_supplier.Text = "";
            txtalamat.Text = "";
            txtcontact_person.Text = "";
            txtketerangan.Text = "";
            txtnama_supplier.Text = "";
            txtno_telepon.Text = "";

            infoalamat.Text = "";
            infocontact_person.Text = "";
            infonama_supplier.Text = "";
            infono_telepon.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addSource(string comein)
        {
            
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);
            
            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select "+comein+" from mssupplier", connection);
            //memasukkan ke dataset
            DataSet mssupplier = new DataSet();
            adapter.Fill(mssupplier);
            
            for (int i = 0; i < mssupplier.Tables[0].Rows.Count; i++)
            {
                
                collection.Add(mssupplier.Tables[0].Rows[i][0].ToString());
            }
            txtCari.AutoCompleteCustomSource = collection;
            txtCari.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            switch (cmbTriger.Text){
                case "ID Supplier": addSource("id_supplier");break;
                case "Nama Supplier": addSource("nama_supplier"); break;
                case "Contact Person": addSource("contact_person"); break;
                case "No Telepon": addSource("no_telepon"); break;
                case "Alamat": addSource("alamat"); break;
                case "Keterangan": addSource("keterangan"); break;
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariSupplier", connection);
                
                
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtCari.Text;

                    myCommand.Parameters.AddWithValue("id_supplier", pencarian);
                    myCommand.Parameters.AddWithValue("nama_supplier", pencarian);
                    myCommand.Parameters.AddWithValue("contact_person", pencarian);
                    myCommand.Parameters.AddWithValue("no_telepon", pencarian);
                    myCommand.Parameters.AddWithValue("alamat", pencarian);
                    myCommand.Parameters.AddWithValue("keterangan", pencarian);

                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);
                clear();

                txtid_supplier.Text = data.Rows[0][0].ToString();
                txtnama_supplier.Text = data.Rows[0][1].ToString();
                txtcontact_person.Text = data.Rows[0][2].ToString();
                txtno_telepon.Text = data.Rows[0][3].ToString();
                txtalamat.Text = data.Rows[0][4].ToString();
                txtketerangan.Text = data.Rows[0][5].ToString();

                by = 1;
                
                btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                btnUpdate.Enabled = false;
                this.mssupplierTableAdapter.Fill(this.sakuraDataDataSet.mssupplier);
                clear();
            }
        }
    }

}
