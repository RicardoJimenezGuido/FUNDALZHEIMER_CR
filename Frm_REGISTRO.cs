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
    public partial class Frm_REGISTRO : Form
    {
        public Frm_REGISTRO()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;

        private void Frm_REGISTRO_Load(object sender, EventArgs e)
        {
            Conexion obj = new Conexion();
            obj.cargar_REGISTRO2(dgv_Registro);


        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {

            Conexion obj1 = new Conexion();
            // obj2.insertarUSUARIO(txt_COD_USUARIO.Text, txt_CEDULA.Text, txt_NOMBRE.Text, txt_APELLIDO1.Text, txt_APELLIDO2.Text, txt_CONTRASEÑA.Text, txt_COD_ESTADO.Text, datipi_FEC_INGRESO.Text, datipi_FEC_MODIFICACION.Text);
            MessageBox.Show(obj1.insertarREGISTRO2(txt_CONSECUTIVO.Text, txt_CEDULA.Text, txt_ID_ENFERMEDAD.Text, txt_COD_MEDICAMENTO.Text, txt_COD_TERAPIA.Text, txt_NOTA.Text, txt_CED_CUIDADOR.Text, txt_COD_USUARIO.Text, txt_COD_ESTADO.Text, txt_ID_PARENTESCO.Text, datipi_FEC_REGISTRO.Value));
            obj1.cargar_REGISTRO2(dgv_Registro);

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {

            Conexion obj2 = new Conexion();
            MessageBox.Show(obj2.eliminarREGISTRO2(txt_CEDULA.Text));
            obj2.cargar_REGISTRO2(dgv_Registro);

        }


      /* private void txt_CEDULA_TextChanged(object sender, EventArgs e)
        {
            Conexion obj3 = new Conexion();
            obj3.cargarREGISTRO2(dgv_Registro, txt_CEDULA.Text);
        }*/

        private void btn_Editar_Click(object sender, EventArgs e)
        {

            Conexion obj4 = new Conexion();
            MessageBox.Show(obj4.actualizarREGISTRO2(txt_CONSECUTIVO.Text, txt_CEDULA.Text, txt_ID_ENFERMEDAD.Text, txt_COD_MEDICAMENTO.Text, txt_COD_TERAPIA.Text, txt_NOTA.Text, txt_CED_CUIDADOR.Text, txt_COD_USUARIO.Text, txt_COD_ESTADO.Text, txt_ID_PARENTESCO.Text, datipi_FEC_REGISTRO.Value));
            obj4.cargar_REGISTRO2(dgv_Registro);

        }

        private void dgv_Registro_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_CONSECUTIVO.Text = dgv_Registro.CurrentRow.Cells[0].Value.ToString();
            txt_CEDULA.Text = dgv_Registro.CurrentRow.Cells[1].Value.ToString();
            txt_ID_ENFERMEDAD.Text = dgv_Registro.CurrentRow.Cells[2].Value.ToString();
            txt_COD_MEDICAMENTO.Text = dgv_Registro.CurrentRow.Cells[3].Value.ToString();
            txt_COD_TERAPIA.Text = dgv_Registro.CurrentRow.Cells[4].Value.ToString();
            datipi_FEC_REGISTRO.Text = dgv_Registro.CurrentRow.Cells[5].Value.ToString();
            txt_NOTA.Text = dgv_Registro.CurrentRow.Cells[6].Value.ToString();
            txt_CED_CUIDADOR.Text = dgv_Registro.CurrentRow.Cells[7].Value.ToString();
            txt_COD_USUARIO.Text = dgv_Registro.CurrentRow.Cells[8].Value.ToString();
            txt_COD_ESTADO.Text = dgv_Registro.CurrentRow.Cells[9].Value.ToString();
            txt_ID_PARENTESCO.Text = dgv_Registro.CurrentRow.Cells[10].Value.ToString();
            /*txt_Año.Text = dgv_Cliente.CurrentRow.Cells[20].Value.ToString();
             txt_Cilindraje.Text = dgv_Cliente.CurrentRow.Cells[21].Value.ToString();
             txt_Kilometraje.Text = dgv_Cliente.CurrentRow.Cells[22].Value.ToString();*/

        }

        private void txt_CEDULA_TextChanged_1(object sender, EventArgs e)
        {
            Conexion obj3 = new Conexion();
            obj3.cargarREGISTRO2(dgv_Registro, txt_CEDULA.Text);
        }

    }
    
}
