using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class Pembayaran : Form
    {
        public Boolean berhasil = false;
        public int kembalian = 0;
        public Pembayaran()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!txtUang.Text.Equals("0"))
            {
                if(Convert.ToInt32(txtUang.Text) < Convert.ToInt32(txtTagihan.Text))
                {
                    MessageBox.Show("Uang tidak cukup","Peringatan",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    kembalian = Convert.ToInt32(txtUang.Text) - Convert.ToInt32(txtTagihan.Text);
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
    }
}
