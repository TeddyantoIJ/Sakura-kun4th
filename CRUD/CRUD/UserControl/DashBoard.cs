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
    public partial class DashBoard : UserControl
    {
        public DashBoard()
        {
            InitializeComponent();
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
    }
}
