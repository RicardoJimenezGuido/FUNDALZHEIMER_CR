using Guna.UI2.WinForms.Enums;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

class Conexion
{
    SqlConnection cn;
    SqlCommand cmd;
    SqlDataReader dr;
    SqlDataAdapter da;
    DataSet ds;
    DataTable dt;

    public Conexion()
    {
        try
        {
            cn = new SqlConnection("Data Source=DESKTOP-E63H3AV\\SQLEXPRESS;Initial Catalog=FundalzheimerCR;Integrated Security=True");
            cn.Open();
            //MessageBox.Show("Conectado");
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se conecto con la base de datos: " + ex.ToString());
        }
    }



    /*********************REGISTRO*****************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************/

    public string insertarREGISTRO2(string CONSECUTIVO, string CEDULA, string ID_ENFERMEDAD, string COD_MEDICAMENTO, string COD_TERAPIA, string NOTA, string CED_CUIDADOR, string COD_USUARIO, string COD_ESTADO, string ID_PARENTESCO, DateTime FEC_REGISTRO)
    {
        string salida = "";
        try
        {
            cmd = new SqlCommand("Insert into REGISTRO2(CONSECUTIVO,CEDULA,ID_ENFERMEDAD,COD_MEDICAMENTO,COD_TERAPIA,NOTA,CED_CUIDADOR, COD_USUARIO, COD_ESTADO,ID_PARENTESCO, FEC_REGISTRO) values ('" + CONSECUTIVO + "','" + CEDULA + "','" + ID_ENFERMEDAD + "','" + COD_MEDICAMENTO + "','" + COD_TERAPIA + "','" + NOTA + "','" + CED_CUIDADOR + "', '" + COD_USUARIO + "' ,'" + COD_ESTADO + "','" + ID_PARENTESCO + "','" + FEC_REGISTRO +  "')", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se conecto: " + ex.ToString();
        }
        return salida;
    }


    public void cargar_REGISTRO2(DataGridView dgv)
    {
        try
        {
            da = new SqlDataAdapter("Select * from REGISTRO2", cn);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

        }

        catch (Exception ex)
        {
            MessageBox.Show("No se puedo llenar el Data Grid View: " + ex.ToString());
        }
    }

    public string eliminarREGISTRO2(string CEDULA)
    {
        string salida = "Se Elimino Correctamente El Usario con la Cédula: " + CEDULA;
        try
        {
            cmd = new SqlCommand("Delete REGISTRO2 from REGISTRO2 Where CEDULA='" + CEDULA + "'", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se eliminó el registro: " + ex.ToString();
        }
        return salida;
    }

    public void cargarREGISTRO2(DataGridView tabla, string CEDULA)
    {
        try
        {
            da = new SqlDataAdapter("Select  *  from REGISTRO2 Where CEDULA like '" + "%" + CEDULA + "%" + "'", cn);
            ds = new DataSet();
            da.Fill(ds, "REGISTRO2");
            tabla.DataSource = ds.Tables["REGISTRO2"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se actualizó el registro: " + ex.ToString());
        }
    }

    public string actualizarREGISTRO2(string CONSECUTIVO, string CEDULA, string ID_ENFERMEDAD, string COD_MEDICAMENTO, string COD_TERAPIA, string NOTA, string CED_CUIDADOR, string COD_USUARIO, string COD_ESTADO, string ID_PARENTESCO, DateTime FEC_REGISTRO)
    {
        string salida = "";
        try
        {                //CONSECUTIVO,CEDULA,ID_ENFERMEDAD,COD_MEDICAMENTO,COD_TERAPIA,NOTA,CED_CUIDADOR, COD_USUARIO, COD_ESTADO,ID_PARENTESCO, FEC_REGISTRO
            cmd = new SqlCommand("Update REGISTRO2 set CONSECUTIVO = '" + CONSECUTIVO + "' IS_ENFERMEDAD = '" + ID_ENFERMEDAD + "',COD_MEDICAMENTO = '" + COD_MEDICAMENTO + "',COD_TERAPIA = '" + COD_TERAPIA + "',NOTA = '" + NOTA + "',CED_CUIDADOR = '" + CED_CUIDADOR + "',COD_USUARIO = '" + COD_USUARIO + "',COD_ESTADO = '" + COD_ESTADO + "', ID_PARENTESCO = '" + ID_PARENTESCO + "',FEC_REGISTRO = '" + FEC_REGISTRO + "' Where CEDULA = '" + CEDULA + "'", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se actualizó el registro: " + ex.ToString();
        }
        return salida;
    }



    /*********************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************/





    /*********************REGISTR USUARIO*********************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************/

    public string insertarUSUARIO2(string COD_USUARIO, string CEDULA, string NOMBRE, string APELLIDO1, string APELLIDO2, string CONTRASEÑA, string COD_ESTADO, DateTime FEC_INGRESO, DateTime FEC_MODIFICACION)
    {
        string salida = "";
        try
        {
            cmd = new SqlCommand("Insert into USUARIO2(COD_USUARIO,CEDULA,NOMBRE,APELLIDO1,APELLIDO2,CONTRASEÑA,COD_ESTADO, FEC_INGRESO, FEC_MODIFICACION) values ('" + COD_USUARIO + "','" + CEDULA + "','" + NOMBRE + "','" + APELLIDO1 + "','" + APELLIDO2 + "','" + CONTRASEÑA + "','" + COD_ESTADO + "','" + FEC_INGRESO + "', '" + FEC_MODIFICACION + "')", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se conecto: " + ex.ToString();
        }
        return salida;
    }


    public void cargar_Usuario2(DataGridView dgv)
    {
        try
        {
            da = new SqlDataAdapter("Select * from USUARIO2", cn);
            dt = new DataTable();
            da.Fill(dt);
            dgv.DataSource = dt;

        }

        catch (Exception ex)
        {
            MessageBox.Show("No se puedo llenar el Data Grid View: " + ex.ToString());
        }
    }

 

    public string eliminarUSUARIO2(string CEDULA)
    {
        string salida = "";
        try
        {
            cmd = new SqlCommand("Delete USUARIO2 from USUARIO2 Where CEDULA='" + CEDULA + "'", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se eliminó el registro: " + ex.ToString();
        }
        return salida;
    }

    public void cargarUSUARIO2(DataGridView tabla, string CEDULA)
    {
        try
        {
            da = new SqlDataAdapter("Select  *  from USUARIO2 Where CEDULA like '" + "%" + CEDULA + "%" + "'", cn);
            ds = new DataSet();
            da.Fill(ds, "USUARIO2");
            tabla.DataSource = ds.Tables["USUARIO2"];
        }
        catch (Exception ex)
        {
            MessageBox.Show("No se actualizó el registro: " + ex.ToString());
        }
    }

    public string actualizarUSUARIO2(string COD_USUARIO, string NOMBRE, string APELLIDO1, string APELLIDO2, string CONTRASEÑA, string COD_ESTADO, DateTime FEC_INGRESO, DateTime FEC_MODIFICACION, string CEDULA)
    {
        string salida = "";
        try
        {
            cmd = new SqlCommand("Update USUARIO2 set COD_USUARIO = '" + COD_USUARIO + "',NOMBRE = '" + NOMBRE + "',APELLIDO1 = '" + APELLIDO1 + "',APELLIDO2 = '" + APELLIDO2 + "',CONTRASEÑA = '" + CONTRASEÑA + "',COD_ESTADO = '" + COD_ESTADO + "',FEC_INGRESO = '" + FEC_INGRESO + "',FEC_MODIFICACION = '" + FEC_MODIFICACION + "' Where CEDULA = '" + CEDULA + "'", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se actualizó el registro: " + ex.ToString();
        }
        return salida;
    }



/******************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************/


/**************************REGISTRO CUIDADOR***********************************************************************************************************************************************************************************************************************************************************************************************************************************************************/

   public string insertarCUIDADOR2(string CED_CUIDADOR, string NOMBRE, string APELLIDO1, string APELLIDO2, string ID_PARENTESCO)
    {
       string salida = "";
       try
       {
        cmd = new SqlCommand("Insert into CUIDADOR2(CED_CUIDADOR,NOMBRE,APELLIDO1,APELLIDO2,ID_PARENTESCO) values ('" + CED_CUIDADOR + "','" + NOMBRE + "','" + APELLIDO1 + "','" + APELLIDO2 + "','" + ID_PARENTESCO + "')", cn);
        cmd.ExecuteNonQuery();
       }
       catch (Exception ex)
       {
        salida = "No se conecto: " + ex.ToString();
       }
       return salida;
}


   public void cargar_CUIDADOR2(DataGridView dgv)
   {
      try
      {
        da = new SqlDataAdapter("Select * from CUIDADOR2", cn);
        dt = new DataTable();
        da.Fill(dt);
        dgv.DataSource = dt;

      }

       catch (Exception ex)
      {
        MessageBox.Show("No se puedo llenar el Data Grid View: " + ex.ToString());
      }
}


    public string eliminarCUIDADOR2(string CED_CUIDADOR)
    {
        string salida = "";
        try
        {
            cmd = new SqlCommand("Delete CUIDADOR2 from CUIDADOR2 Where CED_CUIDADOR='" + CED_CUIDADOR + "'", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se eliminó el registro: " + ex.ToString();
        }
        return salida;
    }


    public void cargarCUIDADOR2(DataGridView tabla, string CED_CUIDADOR)
   {
      try
      {
        da = new SqlDataAdapter("Select  *  from CUIDADOR2 Where CED_CUIDADOR like '" + "%" + CED_CUIDADOR + "%" + "'", cn);
        ds = new DataSet();
        da.Fill(ds, "CUIDADOR2");
        tabla.DataSource = ds.Tables["CUIDADOR2"];
      }
      catch (Exception ex)
      {
        MessageBox.Show("No se actualizó el registro: " + ex.ToString());
      }
}

    

    public string actualizarCUIDADOR2(string NOMBRE, string APELLIDO1, string APELLIDO2, string ID_PARENTESCO, string CED_CUIDADOR)
    {
        string salida = "";
        try
        {
            cmd = new SqlCommand("Update CUIDADOR2 set NOMBRE = '" + NOMBRE + "',APELLIDO1 = '" + APELLIDO1 + "',APELLIDO2 = '" + APELLIDO2 + "',ID_PARENTESCO = '" + ID_PARENTESCO + "' Where CED_CUIDADOR = '" + CED_CUIDADOR + "'", cn);
            cmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            salida = "No se actualizó el registro: " + ex.ToString();
        }
        return salida;
    }



    /******************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************************/


}
