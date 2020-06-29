using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class UCTransaksi : UserControl
    {
        public UCTransaksi()
        {
            InitializeComponent();
        }

        private void UCTransaksi_Load(object sender, EventArgs e)
        {

        }

        private void btnTrans1_Click(object sender, EventArgs e)
        {
            show(ucTrans1);
        }
        private void show(UserControl aktif)
        {
            ucTrans1.Visible = false;
            ucTrans2.Visible = false;
            ucTrans3.Visible = false;
            ucTrans4.Visible = false;
            btnTrans1.BackColor = System.Drawing.Color.Gainsboro;
            btnTrans2.BackColor = System.Drawing.Color.Gainsboro;
            btnTrans3.BackColor = System.Drawing.Color.Gainsboro;
            btnTrans4.BackColor = System.Drawing.Color.Gainsboro;

            if (aktif.Equals(ucTrans1))
            {
                ucTrans1.Visible = true;
                btnTrans1.BackColor = System.Drawing.Color.Gray;
            }
            if (aktif.Equals(ucTrans2))
            {
                ucTrans2.Visible = true;
                btnTrans2.BackColor = System.Drawing.Color.Gray;
            }
            if (aktif.Equals(ucTrans3))
            {
                ucTrans3.Visible = true;
                btnTrans3.BackColor = System.Drawing.Color.Gray;
            }
            if (aktif.Equals(ucTrans4))
            {
                ucTrans4.Visible = true;
                btnTrans4.BackColor = System.Drawing.Color.Gray;
            }
        }

        private void btnTrans2_Click(object sender, EventArgs e)
        {
            show(ucTrans2);
        }

        private void btnTrans3_Click(object sender, EventArgs e)
        {
            show(ucTrans3);
        }

        private void btnTrans4_Click(object sender, EventArgs e)
        {
            show(ucTrans4);
        }
    }
}
