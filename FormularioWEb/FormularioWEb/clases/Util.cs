using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Web.Script;

namespace FormularioWEb.clases
{
    public class Util: WebForm1
    {

         public void Clear()
        {
            nametxt.Text = "";
            lastnametxt.Text = "";
            idtxt.Text = "";
            datetxt.Text = "";
            emailtxt.Text = "";
            phonetxt.Text = "";
            conutry.Text = "";
            carreer.Text = "";


        }

        public int crearDatos()
        {
           int  idmateria = 0;

            if (CtrInscripcion.clases.datamanager.ConexionAbrir())
            {

                // Preparamos consulta pra la actualización
                SqlCommand cmd = new SqlCommand("Insert into materia(descripcion)" +
                                                " output INSERTED.idmateria" +
                                                " Values(@descripcion)", clases.datamanager.ConexionSQL);


                // Ponemos valores a los Parametros incluidos en la consulta de actualización

                cmd.Parameters.AddWithValue("@descripcion", descripcion);


                // Ejecutamos consulta de Actualización
                // y Retornamos el idColor Insertado.
                idmateria = (int)cmd.ExecuteScalar();

                // Cerramos conexión.
           //  FormularioWEb.clases. datamanager.ConexionCerrar();

            }
            // si no logra insertar nada el idempresa Retornado es Cero
            return idmateria;
        }
    }

}
