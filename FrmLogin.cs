using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FUNDALZHEIMER_CR
{
    public partial class Frm_LOGIN : Form
    {
        public Frm_LOGIN()
        {
            InitializeComponent();
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "admin" && txtContraseña.Text == "pass")
            {
                FrmSistema fm = new FrmSistema (txtUsuario.Text);
                fm.Show();
                FrmSistema ff = new FrmSistema(txtUsuario.Text);
                fm.Show();

            }
            else if (txtUsuario.Text == "guest" && txtContraseña.Text == "pass")
            {
                FrmSistema  fm = new FrmSistema(txtUsuario.Text);
                fm.Show();
                FrmSistema ff = new FrmSistema(txtUsuario.Text);
                fm.Show();


            }
        }

        private void Frm_LOGIN_Load(object sender, EventArgs e)
        {

        }
    }
}

