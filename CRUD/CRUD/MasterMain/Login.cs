using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD.MasterMain
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnMasuk_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Visible = false;
            home.ShowDialog(this);
            this.Visible = true;
            
        }
    }
}
