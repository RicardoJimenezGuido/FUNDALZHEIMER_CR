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
    public partial class FrmSistema : Form
    {
        public FrmSistema()
        {
            InitializeComponent();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmSistema());
        }

        String username;
        public FrmSistema(String s)
        {
            InitializeComponent();
            username = s;

        }


        private void FrmSistema_Load(object sender, EventArgs e)
        {
            if (username == "guest")
            {
                mst_Reporte.Visible = false ;
                mst_Registro_Codigos.Visible = false ;
                

            }

            if (username == "guest")
            {
                mst_RegistroCuidador.Visible = true; ;
                mst_Registro_Paciente.Visible = true; ;
              

            }

        }

        private void mst_RegistroUsuario_Click(object sender, EventArgs e)
        {
            
                Frm_Registro_Usuario ru = new Frm_Registro_Usuario();
                ru.Show();
              

            }

        private void mst_RegistroCuidador_Click(object sender, EventArgs e)
        {

           
            Registro_Cuidador rv = new Registro_Cuidador();
            rv.Show();
           
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

         
            Frm_REGISTRO rw = new Frm_REGISTRO();
            rw.Show();
           

        }

        private void eXCELToolStripMenuItem_Click(object sender, EventArgs e)
        {

           
            FrmReporte rr = new FrmReporte();
            rr.Show();
           

        }

        private void uSUARIOPDFToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Reporte_Usuario tt = new Reporte_Usuario();
            tt.Show();
           
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


    }
        }

