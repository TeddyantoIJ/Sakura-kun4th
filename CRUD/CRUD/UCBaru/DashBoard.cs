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
using System.Windows.Forms.DataVisualization.Charting;

namespace CRUD
{
    public partial class DashBoard : UserControl
    {
        List<string> kata = new List<string>();
        private int index = 0;
        private int ganti = 0;
        public DashBoard()
        {
            InitializeComponent();
            addDataMaster(DateTime.Today.ToString("yyyyMM01"), DateTime.Today.ToString("yyyyMM31"));
            isiDiagram(null);
            tambahMutiara();
            mutiara();
        }
        private void tambahMutiara()
        {
            kata.Add("'Jangan membenci mereka yang mengatakan hal buruk tuk menjatuhkanmu, karena merekalah yang buatmu semakin kuat setiap hari.'");
            kata.Add("'Hanya karena orang lain berbuat tidak baik kepada kita, bukan berarti kita harus membalasnya dengan cara yang sama.'");
            kata.Add("'Salah satu hal terbaik dalam hidup adalah melihat senyum di wajah orang tuamu, dan menyadari bahwa kamulah alasannya.'");
            kata.Add("'Untuk setiap manusia di dunia ini, Tuhan telah memberikan sesuatu yang mulia dan baik ke dalam hatinya. Selalu jaga hatimu.'");
            kata.Add("'Jangan pernah meremehkan diri sendiri. Jika kamu tak bahagia dengan hidupmu, perbaiki apa yg salah, dan teruslah melangkah.'");
            kata.Add("'Hidup ini terlalu berharga tuk habiskan waktumu memikirkan dia yang tak memperlakukanmu dengan baik, dan tak pernah menganggapmu ada.'");
            kata.Add("'Jangan salahkan dirimu atas keputusan yg salah. Setiap orang membuatnya. Jadikan mereka pelajaran tuk keputusanmu selanjutnya.'");
            kata.Add("'Hidup tak pernah lepas dari masalah, karena masalah adalah salah satu cara Tuhan menjadikanmu pribadi yg lebih kuat dan dewasa.'");
            kata.Add("'Bagaikan batu yang teguh tiada tergoyahkan, demikian pula orang bijaksana tiada goyah di tengah – tengah celaan ataupun pujian.'");
            kata.Add("'Pikirkan apapun yang akan kamu ucapkan. Karena setiap ucapan yang keluar dari mulutmu, tak akan bisa kamu tarik kembali.'");
            kata.Add("'Selalu lakukan kebaikan dengan cara terbaik. Karena dengan cara itulah kedamaian akan tercipta.'");
            kata.Add("'Cintai apapun yang ada didunia dengan sewajarnya. Karena apapun yang ada di dunia tak ada yang abadi.'");
            kata.Add("'Belajar memahami bahwa tak semua keinginan bisa terpenuhi, adalah obat terbaik untuk mencegah kecewa dan sakit hati.'");
        }
        private void mutiara()
        {
            txtmutiara.Visible = false;
            txtmutiara.Text = kata[index].ToString();
            bunifuTransition1.ShowSync(txtmutiara, true, BunifuAnimatorNS.Animation.Mosaic);
            if (index == kata.Count)
            {
                index = 0;
            }
            else
            {
                index++;
            }
        }
        private void isiDiagram(Bunifu.Framework.UI.BunifuTileButton x)
        {
            if(x != null)
            {
                btnPemasokkanAlat.Enabled = true;
                btnPemasokkanKomponen.Enabled = true;
                btnPenjualanKomponen.Enabled = true;
                btnTransaksiPerbaikan.Enabled = true;
            }

            try
            {
                x.Enabled = false;
            }catch(Exception ex)
            {
                if (!btnPemasokkanAlat.Enabled)
                {
                    x = btnPemasokkanAlat;
                }else if (!btnPemasokkanKomponen.Enabled)
                {
                    x = btnPemasokkanKomponen;
                }else if (!btnPenjualanKomponen.Enabled)
                {
                    x = btnPenjualanKomponen;
                }else if (!btnTransaksiPerbaikan.Enabled)
                {
                    x = btnTransaksiPerbaikan;
                }

            }
            

            
            if (txtInfo.Text.Equals("Bulan ini"))
            {
                getDataTransaksi(x.Name.ToString(), DateTime.Today.ToString("yyyyMM01"), DateTime.Today.ToString("yyyyMM31"));
            }
            else
            {
                getDataTransaksi(x.Name.ToString(), dateSejak.Value.ToString("yyyyMMdd"), dateSampai.Value.ToString("yyyyMMdd"));
            }
        }
        private void getDataTransaksi(string transaksi, string sejak, string sampai)
        {
            List<int> nilai = new List<int>();
            List<DateTime> tanggal = new List<DateTime>();

            nilai.Clear();
            tanggal.Clear();
            try
            {
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand;
                SqlDataAdapter adapter;
                DataTable data = new DataTable();


                if (transaksi.Equals("btnPenjualanKomponen"))
                {
                    //================================== sp_sumtbelikomponen ===================
                    myCommand = new SqlCommand("sp_sumtbelikomponen", connection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    myCommand.Parameters.AddWithValue("sejak", sejak);
                    myCommand.Parameters.AddWithValue("sampai", sampai);

                    adapter = new SqlDataAdapter(myCommand);
                    data = new DataTable();
                    adapter.Fill(data);

                    //btnPenjualanKomponen.LabelText = data.Rows[0][0].ToString() + " Penjualan";
                    connection.Close();
                }
                else if (transaksi.Equals("btnTransaksiPerbaikan"))
                {
                    //================================== sp_sumtreparasialat ===================
                    myCommand = new SqlCommand("sp_sumtreparasialat", connection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    myCommand.Parameters.AddWithValue("sejak", sejak);
                    myCommand.Parameters.AddWithValue("sampai", sampai);

                    adapter = new SqlDataAdapter(myCommand);
                    data = new DataTable();
                    adapter.Fill(data);

                    //btnTransaksiPerbaikan.LabelText = data.Rows[0][0].ToString() + " Perbaikan";
                    connection.Close();
                }
                else if (transaksi.Equals("btnPemasokkanKomponen"))
                {
                    //================================== sp_sumtrestockkomponen ===================
                    myCommand = new SqlCommand("sp_sumtrestockkomponen", connection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    myCommand.Parameters.AddWithValue("sejak", sejak);
                    myCommand.Parameters.AddWithValue("sampai", sampai);

                    adapter = new SqlDataAdapter(myCommand);
                    data = new DataTable();
                    adapter.Fill(data);

                    //btnPemasokkanKomponen.LabelText = data.Rows[0][0].ToString() + " Komponen";
                    connection.Close();
                }
                else if (transaksi.Equals("btnPemasokkanAlat"))
                {
                    //================================== sp_sumtrestockalatkerja ===================
                    myCommand = new SqlCommand("sp_sumtrestockalatkerja", connection);
                    myCommand.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    myCommand.Parameters.AddWithValue("sejak", sejak);
                    myCommand.Parameters.AddWithValue("sampai", sampai);

                    adapter = new SqlDataAdapter(myCommand);
                    data = new DataTable();
                    adapter.Fill(data);

                    //btnPemasokkanAlat.LabelText = data.Rows[0][0].ToString() + " Alat";
                    connection.Close();
                }
                for(int i = 0; i < data.Rows.Count; i++)
                {
                    nilai.Add((int) data.Rows[i][0]);
                    tanggal.Add((DateTime) data.Rows[i][1]);
                }

                addDiagram(nilai, tanggal);
            }
            catch(Exception ex)
            {

            }
        }
        private void addDiagram(List<int> nilai, List<DateTime> tanggal)
        {

            chart1.Series.Clear();
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            //chart.AxisX.Maximum = tanggal.Count+1;

            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = nilai.Max();

            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 1;

            chart1.Series.Add("Diagram1");
            chart1.Series.Add("Diagram");
            

            chart1.Series["Diagram"].ChartType = SeriesChartType.FastLine;
            chart1.Series["Diagram"].Color = Color.Black;
            chart1.Series["Diagram"].BorderWidth = 3;


            chart1.Series["Diagram1"].ChartType = SeriesChartType.Column;
            chart1.Series["Diagram1"].Color = Color.FromArgb(56, 149, 131);
            chart1.Series[0].IsVisibleInLegend = false;
            chart1.Series[1].IsVisibleInLegend = false;

            chart1.Series["Diagram"].Points.AddXY("", 0);
            chart1.Series["Diagram1"].Points.AddXY("", 0);
            for (int i = 1; i <= tanggal.Count; i++)
            {
                //MessageBox.Show(Strike[i - 1].ToString());
                chart1.Series["Diagram"].Points.AddXY(tanggal[i - 1].ToString("dd MMM yyyy"), nilai[i - 1]);
                chart1.Series["Diagram1"].Points.AddXY(tanggal[i - 1].ToString("dd MMM yyyy"), nilai[i - 1]);
            }
            
        }
        private void btnKonfirmasiBarang_Click(object sender, EventArgs e)
        {
            //if (barangmasuk.Visible == false)
            //{
            //    barangmasuk.Visible = true;
            //    barangmasuk.BringToFront();
            //}
            //else
            //{
            //    barangmasuk.Visible = false;
            //    barangmasuk.SendToBack();
            //}

        }

        private void DashBoard_VisibleChanged(object sender, EventArgs e)
        {
            //barangmasuk.Visible = false;
            //barangmasuk.SendToBack();
        }

        private void barangmasuk_Load(object sender, EventArgs e)
        {

        }

        private void bunifuDatepicker2_onValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateSampai.Value, dateSejak.Value) < 0)
            {
                dateSampai.Value = dateSejak.Value;
                return;
            }
           
        }
        public void addDataMaster(string sejak, string sampai)
        {

            try
            {
                string connectionString = Program.getConstring();

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand myCommand;
                SqlDataAdapter adapter;
                DataTable data;



                //================================== sp_sumTotaltbelikomponen ===================
                myCommand = new SqlCommand("sp_sumTotaltbelikomponen", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("sejak", sejak);
                myCommand.Parameters.AddWithValue("sampai", sampai);

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnPenjualanKomponen.LabelText = data.Rows[0][0].ToString() + " Penjualan";
                connection.Close();

                //================================== sp_sumTotaltreparasialat ===================
                myCommand = new SqlCommand("sp_sumTotaltreparasialat", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("sejak", sejak);
                myCommand.Parameters.AddWithValue("sampai", sampai);

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnTransaksiPerbaikan.LabelText = data.Rows[0][0].ToString()+" Perbaikan";
                connection.Close();
                //================================== sp_sumTotaltrestockkomponen ===================
                myCommand = new SqlCommand("sp_sumTotaltrestockkomponen", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("sejak", sejak);
                myCommand.Parameters.AddWithValue("sampai", sampai);

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnPemasokkanKomponen.LabelText = data.Rows[0][0].ToString()+" Komponen";
                connection.Close();
                //================================== sp_sumTotaltrestockalatkerja ===================
                myCommand = new SqlCommand("sp_sumTotaltrestockalatkerja", connection);
                myCommand.CommandType = CommandType.StoredProcedure;

                connection.Open();

                myCommand.Parameters.AddWithValue("sejak", sejak);
                myCommand.Parameters.AddWithValue("sampai", sampai);

                adapter = new SqlDataAdapter(myCommand);
                data = new DataTable();
                adapter.Fill(data);

                btnPemasokkanAlat.LabelText = data.Rows[0][0].ToString()+" Alat";
                connection.Close();
                
                //by = 1;

                //btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error getIDKomponen : " + ex.ToString());

                //return null;
                //btnUpdate.Enabled = false;
                //clear();
            }
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            addDataMaster(dateSejak.Value.ToString("yyyyMMdd"), dateSampai.Value.ToString("yyyyMMdd"));
            txtInfo.Text = dateSejak.Value.ToString("dd MMM yyyy") + " - " + dateSampai.Value.ToString("dd MMM yyyy");
            isiDiagram(null);
        }

        private void dateSejak_onValueChanged(object sender, EventArgs e)
        {
            if (DateTime.Compare(dateSampai.Value, dateSejak.Value) < 0)
            {
                dateSejak.Value = DateTime.Today;
                return;
            }
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            
        }

        private void txtInfo_Click(object sender, EventArgs e)
        {
            addDataMaster(DateTime.Today.ToString("yyyyMM01"), DateTime.Today.ToString("yyyyMM31"));
            txtInfo.Text = "Bulan ini";
            isiDiagram(null);
        }

        private void btnPenjualanKomponen_Click(object sender, EventArgs e)
        {
            isiDiagram( btnPenjualanKomponen);
        }

        private void btnTransaksiPerbaikan_Click(object sender, EventArgs e)
        {
            isiDiagram(btnTransaksiPerbaikan);
        }

        private void btnPemasokkanKomponen_Click(object sender, EventArgs e)
        {
            isiDiagram(btnPemasokkanKomponen);
        }

        private void btnPemasokkanAlat_Click(object sender, EventArgs e)
        {
            isiDiagram(btnPemasokkanAlat);
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ganti++;
            if(ganti == 180)
            {
                ganti = 0;
                mutiara();
            }
        }
    }
}
