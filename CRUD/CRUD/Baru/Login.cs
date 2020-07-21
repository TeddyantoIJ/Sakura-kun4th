using CRUD.Baru;
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

namespace CRUD.MasterMain
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        bool login = false;
        private void label3_Click(object sender, EventArgs e)
        {

            if (ucMasuk.Visible)
            {
                ucMasuk.Visible = false;
            }
            else
            {
                ucMasuk.Visible = true;
            }
           
            
            
        }

        private void lblLogin_MouseEnter(object sender, EventArgs e)
        {
            changeColorAktif(lblLogin);
        }

        private void lblLogin_MouseLeave(object sender, EventArgs e)
        {
            changeColorNot(lblLogin);
        }
        private void changeColorAktif(Label n)
        {
            n.ForeColor = Color.White;
        }
        private void changeColorNot(Label n)
        {
            n.ForeColor = Color.FromArgb(56, 149, 131);
        }

        private void lblAboutUs_MouseEnter(object sender, EventArgs e)
        {
            changeColorAktif(lblAboutUs);
        }

        private void lblExit_MouseEnter(object sender, EventArgs e)
        {
            changeColorAktif(lblExit);
        }

        private void lblExit_MouseLeave(object sender, EventArgs e)
        {
            changeColorNot(lblExit);
        }

        private void lblAboutUs_MouseLeave(object sender, EventArgs e)
        {
            changeColorNot(lblAboutUs);
        }

        private void lblAboutUs_Click(object sender, EventArgs e)
        {
            ucMasuk.Visible = false;
            login = false;
            if (panelAboutUs.Visible)
            {
                rb1.Checked = true;
                panelAboutUs.Visible = false;
                panelAwal.Visible = true;
            }
            else
            {
                rb2.Checked = true;
                panelAboutUs.Visible = true;
                panelAwal.Visible = false;
            }
        }

        private void lblExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            ucMasuk.Visible = false;
            login = false;
            if (panelAboutUs.Visible)
            {
                rb1.Checked = true;
                panelAboutUs.Visible = false;
                panelAwal.Visible = true;
            }
            else
            {
                rb2.Checked = true;
                panelAboutUs.Visible = true;
                panelAwal.Visible = false;
            }
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void ucMasuk_VisibleChanged(object sender, EventArgs e)
        {
            if (ucMasuk.login)
            {
                this.Visible = false;
            }
        }
    }
}
