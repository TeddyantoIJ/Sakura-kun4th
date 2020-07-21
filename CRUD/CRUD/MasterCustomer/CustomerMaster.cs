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
    public partial class CustomerMaster : Form
    {
        private string sFileName = "";
        public CustomerMaster()
        {
            InitializeComponent();

            txtid_customer.Text = "CUST-XXXX";
            addSource();
        }
        public CustomerMaster(string inn)
        {
            InitializeComponent();

            txtid_customer.Text = "CUST-XXXX";
            txtnama_customer.Text = inn;
            addSource();
        }

        private void txtnama_customer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        bool benar;
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
                infonama_customer.ForeColor = System.Drawing.Color.Green;
                infonama_customer.Text = "Sesuai";
            }
            
        }
        
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
                infonama_customer.ForeColor = System.Drawing.Color.Green;
                infonama_customer.Text = "Sesuai";
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (benar)
            {
                DialogResult result = MessageBox.Show("Periksa data sebelum disimpan\n" +
                    "ID Customer\t: " + txtid_customer.Text + "\n" +
                    "Nama Supplier\t: " + txtnama_customer.Text
                    , "Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    updateDB();
                }
                else
                {
                    MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
        private void updateDB()
        {
            try
            {

                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_inputCustomer", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string id_customer = txtid_customer.Text;
                string nama_customer = txtnama_customer.Text;
                
                SqlParameter param = new SqlParameter();

                myCommand.Parameters.AddWithValue("id_customer", "CUST-" + getLastID());
                myCommand.Parameters.AddWithValue("nama_customer", nama_customer);
                myCommand.Parameters.AddWithValue("path", sFileName);


                //myCommand.Connection = myConnection;

                //myCommand.CommandText = cmd;

                myCommand.ExecuteNonQuery();
                myConnection.Close();
                MessageBox.Show("Data berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                addSource();
                txtid_customer.Text = "CUST-XXXX";
                txtnama_customer.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private string getLastID()
        {
            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select count (id_customer) from mscustomer", connection);
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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void addSource()
        {

            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_customer from mscustomer", connection);
            //memasukkan ke dataset
            DataSet mscustomer = new DataSet();
            adapter.Fill(mscustomer);

            for (int i = 0; i < mscustomer.Tables[0].Rows.Count; i++)
            {

                collection.Add(mscustomer.Tables[0].Rows[i][0].ToString());
            }
            txtnama_customer.AutoCompleteCustomSource = collection;
            txtnama_customer.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnama_customer.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }
        
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog choofdlog = new OpenFileDialog();
            choofdlog.Filter = "All Files (*.*)|*.*";
            choofdlog.FilterIndex = 1;
            choofdlog.Multiselect = true;
            
            if (choofdlog.ShowDialog() == DialogResult.OK)
            {
                sFileName = choofdlog.FileName;
            }
            try
            {
                picCustomer.Image = Image.FromFile(sFileName);
                picCustomer.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch(Exception ex)
            {

            }
            
        }
    }
}
