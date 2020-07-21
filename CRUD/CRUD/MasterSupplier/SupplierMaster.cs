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
    public partial class SupplierMaster : Form
    {
        public SupplierMaster()
        {
            InitializeComponent();
            addSource();
            txtid_supplier.Text = "SUPP-XXXX";
        }
        public SupplierMaster(string x)
        {
            InitializeComponent();
            txtnama_supplier.Text = x;
            txtid_supplier.Text = "SUPP-XXXX";
        }
        private void txtcontact_person_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtno_telepon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
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
                    "ID Supplier\t: "+txtid_supplier.Text+"\n"+
                    "Nama Supplier\t: "+txtnama_supplier.Text+"\n"+
                    "Contact Person\t: "+txtcontact_person.Text+"\n"+
                    "No Telepon\t: "+txtno_telepon.Text+"\n"+   
                    "Alamat\t\t: "+txtalamat.Text+"\n"+
                    "Keterangan\t: "+txtketerangan.Text
                    ,"Informasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.Yes)
                {
                    updateDB();
                }
                else
                {
                    MessageBox.Show("BATAL!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {
                MessageBox.Show("Semua data harus diisi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void addSource()
        {
            txtnama_supplier.AutoCompleteCustomSource = null;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            string connectionString = Program.getConstring();

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select nama_supplier from mssupplier", connection);
            //memasukkan ke dataset
            DataSet mscustomer = new DataSet();
            adapter.Fill(mscustomer);

            for (int i = 0; i < mscustomer.Tables[0].Rows.Count; i++)
            {

                collection.Add(mscustomer.Tables[0].Rows[i][0].ToString());
            }
            txtnama_supplier.AutoCompleteCustomSource = collection;
            txtnama_supplier.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtnama_supplier.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }
        private string getLastID()
        {
            string connectionString = Program.getConstring();

            SqlConnection connection = new SqlConnection(connectionString);

            //membuat table dengan jumlah data saja
            SqlDataAdapter adapter = new SqlDataAdapter("select count (id_supplier) from mssupplier",connection);
            //memasukkan ke dataset
            DataSet mssupplier = new DataSet();
            adapter.Fill(mssupplier);

            //mengambil data jumlah
            int count = (int) mssupplier.Tables[0].Rows[0][0];
            count++;
            if(count.ToString().Length == 1)
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
        
        private void updateDB()
        {
            try
            {

                string connectionString = Program.getConstring();

                SqlConnection myConnection = new SqlConnection(connectionString);

                myConnection.Open();

                SqlCommand myCommand = new SqlCommand("sp_inputSupplier", myConnection);
                myCommand.CommandType = CommandType.StoredProcedure;

                string id_supplier = "SUPP-" + getLastID();
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
                clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

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

        private void btnBatal_Click(object sender, EventArgs e)
        {
            if(txtnama_supplier.Text == "" && txtno_telepon.Text == "")
            {
                this.Close();
            }
            else
            {
                clear();
            }
            

        }
        private void clear()
        {
            txtid_supplier.Text = "SUPP-XXXX";
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

        private void SupplierMaster_Load(object sender, EventArgs e)
        {
            if(Thread.CurrentPrincipal.Identity.Name != "")
            {
                txtnama_supplier.Text = Thread.CurrentPrincipal.Identity.Name;
            }
            //this.Size = new System.Drawing.Size(Parent.Width, Parent.Height);
        }
    }
}
