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

namespace FUNDALZHEIMER_CR
{
    public partial class Registro_Cuidador : Form
    {
        public Registro_Cuidador()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;


        private void Registro_Cuidador_Load(object sender, EventArgs e)
        {
            Conexion obj = new Conexion();
            obj.cargar_CUIDADOR2(dgv_Registro_Cuidador);
        }


        private void btn_RegistrarA_Click(object sender, EventArgs e)
        {

            Conexion obj1 = new Conexion();
           
            MessageBox.Show(obj1.insertarCUIDADOR2(txt_CED_CUIDADOR.Text, txt_NOMBRE.Text, txt_APELLIDO1.Text, txt_APELLIDO2.Text, txt_ID_PARENTESCO.Text));
            obj1.cargar_CUIDADOR2(dgv_Registro_Cuidador);

        }

        // obj2.insertarUSUARIO(txt_COD_USUARIO.Text, txt_CEDULA.Text, txt_NOMBRE.Text, txt_APELLIDO1.Text, txt_APELLIDO2.Text, txt_CONTRASEÑA.Text, txt_COD_ESTADO.Text, datipi_FEC_INGRESO.Text, datipi_FEC_MODIFICACION.Text);

        private void btn_EliminarA_Click(object sender, EventArgs e)
        {
            Conexion obj2 = new Conexion();
            MessageBox.Show(obj2.eliminarCUIDADOR2(txt_CED_CUIDADOR.Text));
            obj2.cargar_CUIDADOR2(dgv_Registro_Cuidador);

        }

   

        private void btn_EditarA_Click(object sender, EventArgs e)
        {
            Conexion obj4 = new Conexion();
            MessageBox.Show(obj4.actualizarCUIDADOR2(txt_CED_CUIDADOR.Text, txt_NOMBRE.Text, txt_APELLIDO1.Text, txt_APELLIDO2.Text, txt_ID_PARENTESCO.Text));
            obj4.cargar_CUIDADOR2(dgv_Registro_Cuidador);
        }

        private void dgv_Registro_Cuidador_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_CED_CUIDADOR.Text = dgv_Registro_Cuidador.CurrentRow.Cells[0].Value.ToString();
            txt_NOMBRE.Text = dgv_Registro_Cuidador.CurrentRow.Cells[1].Value.ToString(); 
            txt_APELLIDO1.Text = dgv_Registro_Cuidador.CurrentRow.Cells[2].Value.ToString();
            txt_APELLIDO2.Text = dgv_Registro_Cuidador.CurrentRow.Cells[3].Value.ToString();
            txt_ID_PARENTESCO.Text = dgv_Registro_Cuidador.CurrentRow.Cells[4].Value.ToString();
            /* datipi_FEC_REGISTRO.Text = dgv_Registro.CurrentRow.Cells[5].Value.ToString();
             txt_NOTA.Text = dgv_Registro.CurrentRow.Cells[6].Value.ToString();
             txt_CED_CUIDADOR.Text = dgv_Registro.CurrentRow.Cells[7].Value.ToString();
             txt_COD_USUARIO.Text = dgv_Registro.CurrentRow.Cells[8].Value.ToString();
             txt_COD_ESTADO.Text = dgv_Registro.CurrentRow.Cells[9].Value.ToString();
             txt_ID_PARENTESCO.Text = dgv_Registro.CurrentRow.Cells[10].Value.ToString();*/


        }

        private void txt_CED_CUIDADOR_TextChanged_1(object sender, EventArgs e)
        {
            Conexion obj3 = new Conexion();
            obj3.cargarCUIDADOR2(dgv_Registro_Cuidador, txt_CED_CUIDADOR.Text);

        }
    }
}
