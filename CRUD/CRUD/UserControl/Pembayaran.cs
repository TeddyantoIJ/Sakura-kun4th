using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Pembayaran : Form
    {
        public Boolean berhasil = false;
        public int kembalian = 0;
        private int tagihan = 0;
        private int bayar = 0;
        

        public Pembayaran(String tagihan)
        {
            InitializeComponent();
            txtTagihan.Text = tagihan;
            this.tagihan = toAngka(tagihan);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtUang.Text.Equals("0"))
            {
                if(Convert.ToInt32(txtUang.Text) < Convert.ToInt32(toAngka(txtTagihan.Text)))
                {
                    MessageBox.Show("Uang tidak cukup","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    berhasil = true;
                    this.Close();
                }
            }
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUang_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
            }
            
            
        }
        public string toRupiah(Int32 angka)
        {
            return String.Format(CultureInfo.CreateSpecificCulture("id-id"), "{0:N}", angka);
        }

        public int toAngka(string rupiah)
        {
            return int.Parse(Regex.Replace(rupiah, @",.*|\D", ""));
        }

        private void txtUang_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                bayar = Convert.ToInt32(txtUang.Text);
                kembalian = bayar - tagihan;
                txtKembalian.Text = toRupiah(kembalian);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Melewati batas");
            }
            
        }
    }
}
