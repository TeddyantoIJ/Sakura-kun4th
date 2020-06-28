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
    public partial class beliKomponen : UserControl
    {
        public beliKomponen()
        {
            InitializeComponent();
            addDataKomponen();
            addSourceNama();

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

                for (int i = 0; i < tableKomponen.Columns.Count; i++)
                {
                        this.tableKomponen.Columns[i].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                        this.tableKomponen.Columns[i].HeaderCell.Style.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Pixel);
                }

                this.tableKomponen.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableKomponen.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableKomponen.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                this.tableKomponen.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                this.tableKomponen.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;

                this.tableKomponen.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                this.tableKomponen.Columns[4].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
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

        

        private void beliKomponen_Load(object sender, EventArgs e)
        {

        }

        private void addSourceNama()
        {
            txtPelanggan.AutoCompleteCustomSource = null;

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
            txtPelanggan.AutoCompleteCustomSource = collection;
            txtPelanggan.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtPelanggan.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void btnTambahPelanggan_Click(object sender, EventArgs e)
        {
            CustomerMaster cus = new CustomerMaster(txtPelanggan.Text);
            cus.ShowDialog(this);
        }

        private void txtPelanggan_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                picPelanggan.Image = Image.FromFile(getPathCustomer(txtPelanggan.Text));
                picPelanggan.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception ex)
            {

            }
        }
        private string getPathCustomer(string inx)
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

                String output = data.Rows[0][3].ToString();
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
