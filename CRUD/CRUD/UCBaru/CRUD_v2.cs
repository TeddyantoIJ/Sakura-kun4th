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
    public partial class CRUD_v2 : UserControl
    {
        public CRUD_v2()
        {
            InitializeComponent();
            addDataMaster();
        }
        public void addDataMaster()
        {
            try
            {
                string connectionString = "integrated security = true; data source = localhost; initial catalog = SakuraData";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand;
                SqlDataAdapter adapter;
                DataTable data;



                //================================== sp_summsalatkerja ===================
                myCommand = new SqlCommand("sp_summsalatkerja", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnAlatKerja.LabelText = data.Rows[0][0].ToString();
                connection.Close();

                //================================== sp_summsalatelektronik ===================
                myCommand = new SqlCommand("sp_summsalatelektronik", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnAlatElektronik.LabelText = data.Rows[0][0].ToString();
                connection.Close();
                //================================== sp_summsalatsupplier ===================
                myCommand = new SqlCommand("sp_summsalatsupplier", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnSupplierAlat.LabelText = data.Rows[0][0].ToString();
                connection.Close();
                //================================== sp_summsbagiangudang ===================
                myCommand = new SqlCommand("sp_summsbagiangudang", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnPereparasi.LabelText = data.Rows[0][0].ToString();
                connection.Close();
                //================================== sp_summsbagianpelayan ===================
                myCommand = new SqlCommand("sp_summsbagianpelayan", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnPelayan.LabelText = data.Rows[0][0].ToString();
                connection.Close();
                //================================== sp_summscustomer ===================
                myCommand = new SqlCommand("sp_summscustomer", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnCustomer.LabelText = data.Rows[0][0].ToString();
                connection.Close();
                //================================== sp_summsjeniselektronik ===================
                myCommand = new SqlCommand("sp_summsjeniselektronik", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnJenisAlatElektronik.LabelText = data.Rows[0][0].ToString();
                connection.Close();
                //================================== sp_summskomponen ===================
                myCommand = new SqlCommand("sp_summskomponen", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnKomponen.LabelText = data.Rows[0][0].ToString();
                connection.Close();
                //================================== sp_summskomponensupplier ===================
                myCommand = new SqlCommand("sp_summskomponensupplier", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnSupplierKomponen.LabelText = data.Rows[0][0].ToString();
                connection.Close();
                //================================== sp_summssupplier ===================
                myCommand = new SqlCommand("sp_summssupplier", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnSupplier.LabelText = data.Rows[0][0].ToString();
                connection.Close();
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error getIDKomponen : " + ex.ToString());

               //return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }
        private void go(string inx)
        {
            this.createOrUpdate.lblNama.Text = "Olah data "+inx;
            this.createOrUpdate.kelola = inx;
            this.createOrUpdate.Visible = true;
            this.createOrUpdate.BringToFront();

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            go("Pelanggan");
        }

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            go("Pemasok");
        }

        private void btnPelayan_Click(object sender, EventArgs e)
        {
            go("Pelayan");
        }

        private void btnPereparasi_Click(object sender, EventArgs e)
        {
            go("Pereparasi");
        }

        private void btnKomponen_Click(object sender, EventArgs e)
        {
            go("Komponen");
        }

        private void btnAlatKerja_Click(object sender, EventArgs e)
        {
            go("Alat Kerja");
        }

        private void btnSupplierAlat_Click(object sender, EventArgs e)
        {
            go("Pemasok Alat");
        }

        private void btnSupplierKomponen_Click(object sender, EventArgs e)
        {
            go("Pemasok Komponen");
        }

        private void btnAlatElektronik_Click(object sender, EventArgs e)
        {
            go("Alat Elektronik");
        }

        private void btnJenisAlatElektronik_Click(object sender, EventArgs e)
        {
            go("Jenis alat");
        }

        private void CRUD_v2_VisibleChanged(object sender, EventArgs e)
        {
            addDataMaster();
            createOrUpdate.Visible = false;
        }

        private void panelCRUD_Enter(object sender, EventArgs e)
        {
            
        }

        private void CRUD_v2_Enter(object sender, EventArgs e)
        {
            addDataMaster();
        }

        private void CRUD_v2_MouseEnter(object sender, EventArgs e)
        {
            
        }

        private void createOrUpdate_VisibleChanged(object sender, EventArgs e)
        {
            this.addDataMaster();
        }

        private void panelCRUD_Click(object sender, EventArgs e)
        {
            this.createOrUpdate.Visible = false;
        }
    }
}
