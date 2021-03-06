﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Web.Script;

namespace FormularioWEb
{
    public class dmpersona 
    {
        public int idpersona { get; set; }
        public string name { get; set; }
        public string lastname { get; set; }
        public string cedula { get; set; }
        public string dateT { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string country { get; set; }
        public string career { get; set; }

        public void Clear()
        {
            name = "";
            lastname = "";
            cedula = "";
            dateT = "";
            email = "";
            phone = "";
            country = "";
            career = "";
       

        }

        public int crearDatos()
        {
            int idpersona = 0;

            if (clases.datamanager.ConexionAbrir())
            {

                // Preparamos consulta pra la actualización

                SqlCommand cmd = new SqlCommand("sp_save", clases.datamanager.ConexionSQL);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                // Ponemos valores a los Parametros incluidos en la consulta de actualización

                // Ejecutamos consulta de Actualización
                // y Retornamos el idColor Insertado.
                idpersona = (int)cmd.ExecuteScalar();
                cmd.Parameters.AddWithValue("@idpersona", idpersona);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@lastname", lastname);
                cmd.Parameters.AddWithValue("@cedula", cedula);
                cmd.Parameters.AddWithValue("@dateT", dateT);
                cmd.Parameters.AddWithValue("@email", email);
                cmd.Parameters.AddWithValue("@phone", phone);
                cmd.Parameters.AddWithValue("@country", country);
                cmd.Parameters.AddWithValue("@career", career);
                cmd.ExecuteNonQuery();

                // Cerramos conexión.
                clases.datamanager.ConexionCerrar();

            }
            // si no logra insertar nada el idempresa Retornado es Cero
            return idpersona;
        }
    }

}
