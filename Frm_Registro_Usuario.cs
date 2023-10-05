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
    public partial class Frm_Registro_Usuario : Form
    {
        public Frm_Registro_Usuario()
        {
            InitializeComponent();
        }

        SqlConnection cn;
        SqlCommand cmd;
        SqlDataReader dr;
        SqlDataAdapter da;
        DataSet ds;
        DataTable dt;


        private void Frm_Registro_Usuario_Load(object sender, EventArgs e)
        {
            Conexion obj = new Conexion();
            obj.cargar_Usuario2(dgv_Registro_Usuario);


        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            Conexion obj1 = new Conexion();
            // obj2.insertarUSUARIO(txt_COD_USUARIO.Text, txt_CEDULA.Text, txt_NOMBRE.Text, txt_APELLIDO1.Text, txt_APELLIDO2.Text, txt_CONTRASEÑA.Text, txt_COD_ESTADO.Text, datipi_FEC_INGRESO.Text, datipi_FEC_MODIFICACION.Text);
            MessageBox.Show(obj1.insertarUSUARIO2(txt_COD_USUARIO.Text, txt_CEDULA.Text, txt_NOMBRE.Text, txt_APELLIDO1.Text, txt_APELLIDO2.Text, txt_CONTRASEÑA.Text, txt_COD_ESTADO.Text, datipi_FEC_INGRESO.Value, datipi_FEC_MODIFICACION.Value));
            obj1.cargar_Usuario2(dgv_Registro_Usuario);
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            Conexion obj2 = new Conexion();
            MessageBox.Show(obj2.eliminarUSUARIO2(txt_CEDULA.Text));
            obj2.cargar_Usuario2(dgv_Registro_Usuario);

        }


        private void txt_CEDULA_TextChanged(object sender, EventArgs e)
        {
            Conexion obj3 = new Conexion();
            obj3.cargarUSUARIO2(dgv_Registro_Usuario, txt_CEDULA.Text);
        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            Conexion obj4 = new Conexion();
            MessageBox.Show(obj4.actualizarUSUARIO2(txt_COD_USUARIO.Text, txt_NOMBRE.Text, txt_APELLIDO1.Text, txt_APELLIDO2.Text, txt_CONTRASEÑA.Text, txt_COD_ESTADO.Text, datipi_FEC_INGRESO.Value, datipi_FEC_MODIFICACION.Value, txt_CEDULA.Text));
            obj4.cargar_Usuario2(dgv_Registro_Usuario);
        }



        private void dgv_Registro_Usuario_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            txt_COD_USUARIO.Text = dgv_Registro_Usuario.CurrentRow.Cells[0].Value.ToString();
            txt_CEDULA.Text = dgv_Registro_Usuario.CurrentRow.Cells[1].Value.ToString();
            txt_NOMBRE.Text = dgv_Registro_Usuario.CurrentRow.Cells[2].Value.ToString();
            txt_APELLIDO1.Text = dgv_Registro_Usuario.CurrentRow.Cells[3].Value.ToString();
            txt_APELLIDO2.Text = dgv_Registro_Usuario.CurrentRow.Cells[4].Value.ToString();
            txt_CONTRASEÑA.Text = dgv_Registro_Usuario.CurrentRow.Cells[5].Value.ToString();
            txt_COD_ESTADO.Text = dgv_Registro_Usuario.CurrentRow.Cells[6].Value.ToString();
            datipi_FEC_INGRESO.Text = dgv_Registro_Usuario.CurrentRow.Cells[7].Value.ToString();
            datipi_FEC_MODIFICACION.Text = dgv_Registro_Usuario.CurrentRow.Cells[8].Value.ToString();
            /* txt_Marca.Text = dgv_Cliente.CurrentRow.Cells[18].Value.ToString();
             txt_Modelo.Text = dgv_Cliente.CurrentRow.Cells[19].Value.ToString();
             txt_Año.Text = dgv_Cliente.CurrentRow.Cells[20].Value.ToString();
             txt_Cilindraje.Text = dgv_Cliente.CurrentRow.Cells[21].Value.ToString();
             txt_Kilometraje.Text = dgv_Cliente.CurrentRow.Cells[22].Value.ToString();*/

            //, txt_Nombre.Text, txt_Apellidos.Text, Convert.ToInt32(txt_Telefono.Text), txt_Direccion.Text, Convert.ToInt32(txt_Fecha.Text), txt_Correo.Text, txt_Placa.Text, txt_Marca.Text, txt_Modelo.Text, Convert.ToInt32(txt_Año.Text), txt_Cilindraje.Text, txt_Kilometraje.Text

        }

    }
}


