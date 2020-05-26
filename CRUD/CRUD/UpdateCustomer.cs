using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class UpdateCustomer : Form
    {
        public UpdateCustomer()
        {
            InitializeComponent();
        }

        private void UpdateCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sakuraDataDataSet1.mscustomer' table. You can move, or remove it, as needed.
            this.mscustomerTableAdapter.Fill(this.sakuraDataDataSet1.mscustomer);

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateGrup.Enabled = true;
            btnUpdate.Enabled = false;
            btnBatal.Enabled = true;
        }

        int selectedRow;
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cmbTriger.Text = "- Pilih Kategori -";
            txtCari.Text = "";
            Int32 selectedRowCount =
            viewcustomer.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0 && selectedRowCount <= 1)
            {
                btnUpdate.Enabled = true;
                clear();
                //by = 0;
                System.Text.StringBuilder sb = new System.Text.StringBuilder();

                for (int i = 0; i < selectedRowCount; i++)
                {
                    selectedRow = Int32.Parse(viewcustomer.SelectedRows[i].Index.ToString());
                }
                DataGridViewRow row = viewcustomer.Rows[selectedRow];
                txtid_customer.Text = row.Cells[0].Value.ToString();
                txtnama_customer.Text = row.Cells[1].Value.ToString();
                txttotal_transaksi.Text = row.Cells[2].Value.ToString();
                
            }
            else
            {
                btnUpdate.Enabled = false;
            }
        }
        private void clear()
        {
            updateGrup.Enabled = false;
            btnBatal.Enabled = false;

            txtid_customer.Text = "";
            txtnama_customer.Text = "";
            txttotal_transaksi.Text = "";
            

            infonama_customer.Text = "";
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            clear();
            btnUpdate.Enabled = true;
            btnBatal.Enabled = false;
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            benar = true;
            if (txtnama_customer.Text == "")
            {
                benar = false;
                infonama_customer.ForeColor = System.Drawing.Color.Red;
                infonama_customer.Text = "Wajib diisi!";
            }
            else
            {
                txtnama_customer.BackColor = System.Drawing.Color.White;
                infonama_customer.ForeColor = System.Drawing.Color.Green;
                infonama_customer.Text = "Sesuai";
            }
            if (benar)
            {
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                    "ID Customer\t: " + txtid_customer.Text + "\n" +
                    "Nama Customer\t: " + txtnama_customer.Text + "\n" +
                    "Total Transaksi\t: " + txttotal_transaksi.Text
                    , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    updateDB();
                }
                else
                {
                    MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clear();
                    btnBatal.Enabled = false;
                    btnUpdate.Enabled = false;
                }
            }
            else
            {
                txtnama_customer.BackColor = System.Drawing.Color.Red;
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            clear();
            this.mscustomerTableAdapter.Fill(this.sakuraDataDataSet1.mscustomer);
        }
        private void updateDB()
        {
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_updateCustomer", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string id_customer = txtid_customer.Text;
                string nama_customer = txtnama_customer.Text;
                string total_transaksi = txttotal_transaksi.Text;


                myCommand.Parameters.AddWithValue("id_customer", id_customer);
                myCommand.Parameters.AddWithValue("nama_customer", nama_customer);
                myCommand.Parameters.AddWithValue("total_transaksi", total_transaksi);



                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.mscustomerTableAdapter.Fill(this.sakuraDataDataSet1.mscustomer);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        bool benar;
        private void txtnama_customer_TextChanged(object sender, EventArgs e)
        {
            benar = true;
            if (txtnama_customer.Text == "")
            {
                benar = false;
                infonama_customer.ForeColor = System.Drawing.Color.Red;
                infonama_customer.Text = "Wajib diisi!";
            }
            else
            {
                txtnama_customer.BackColor = System.Drawing.Color.White;
                infonama_customer.ForeColor = System.Drawing.Color.Green;
                infonama_customer.Text = "Sesuai";
            }
        }

        private void txtnama_customer_Leave(object sender, EventArgs e)
        {
            benar = true;
            if (txtnama_customer.Text == "")
            {
                benar = false;
                infonama_customer.ForeColor = System.Drawing.Color.Red;
                infonama_customer.Text = "Wajib diisi!";
            }
            else
            {
                txtnama_customer.BackColor = System.Drawing.Color.White;
                infonama_customer.ForeColor = System.Drawing.Color.Green;
                infonama_customer.Text = "Sesuai";
            }
        }
        private void addSource(string comein)
        {

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select " + comein + " from mscustomer", connection);
            //memasukkan ke dataset
            DataSet mscustomer = new DataSet();
            adapter.Fill(mscustomer);

            for (int i = 0; i < mscustomer.Tables[0].Rows.Count; i++)
            {

                collection.Add(mscustomer.Tables[0].Rows[i][0].ToString());
            }
            txtCari.AutoCompleteCustomSource = collection;
            txtCari.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtCari.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void cmbTriger_TextChanged(object sender, EventArgs e)
        {
            clear();
            btnUpdate.Enabled = false;
            switch (cmbTriger.Text)
            {
                case "ID Customer" : addSource("id_customer");break;
                case "Nama Customer" : addSource("nama_customer");break;
            }
        }

        private void txtCari_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand = new SqlCommand("sp_cariCustomer", connection);


                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();
                string pencarian = txtCari.Text;

                myCommand.Parameters.AddWithValue("id_customer", pencarian);
                myCommand.Parameters.AddWithValue("nama_customer", pencarian);


                SqlDataAdapter adapter = new SqlDataAdapter(myCommand);
                DataTable data = new DataTable();
                adapter.Fill(data);
                clear();

                txtid_customer.Text = data.Rows[0][0].ToString();
                txtnama_customer.Text = data.Rows[0][1].ToString();
                txttotal_transaksi.Text = data.Rows[0][2].ToString();
                

                //by = 1;

                btnUpdate.Enabled = true;
            }
            catch (Exception)
            {
                btnUpdate.Enabled = false;                
                clear();
            }
        }

        private void cmbTriger_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtnama_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
