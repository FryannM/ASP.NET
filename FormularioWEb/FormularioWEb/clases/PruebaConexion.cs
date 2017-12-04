using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data.Sql;
using System.Windows.Forms;
using System.Web.UI;
using System.Data;

namespace FormularioWEb.clases
{
    public class PruebaConexion
    {
        //Ins Es para utilizar el patron singleton
        private static PruebaConexion ins;
        //Variable estatica para hacer consultas
        private static SqlCommand cmd;

        //Constructor privado de la clase para Patron singleton
        private PruebaConexion() { }
        /*Se hace un metodo del tipo de la clase estatico
         * se Pregunta si la ins es nulo, si lo es
         * se crea una nueva instancia y se retorna
         * para acceder a la instancia solo usan PruebaConexion c = PruebaConexion.instancia();
        
         */
        public static PruebaConexion instancia()
        {
            if (ins == null)
                ins = new PruebaConexion();
            return ins;
        }

        /*Se crea un metodo de tipo MySqlConnection estatico
         * Se cra un objeto MySqlConnection y se le pasan:
         * Server, nombre de la base de datos, usuario, contrasena.
         * se llama la variable conectar y se utiliza su metodo Open.
         * Y se retorna conectar
         */
        public static SqlConnection Conectar()
        {
            SqlConnection conectar = new SqlConnection("@Data Source=FRYANNM/SQLEXPRESS;Initial Catalog=WebServer;Integrated Security=True");
            conectar.Open();
            return conectar;
        }

        public static SqlConnection Desconectar()
        {
            SqlConnection desconectar = new SqlConnection("@Data Source=FRYANNM/SQLEXPRESS;Initial Catalog=WebServer;Integrated Security=True");
            desconectar.Close();
            return desconectar;
        }

        //public static SqlCommand Ejecutar(string consultar, CommandType s)
        //{
           
        //    try
        //    {
        //        cmd = new SqlCommand(consultar, PruebaConexion.Conectar());
        //        cmd.ExecuteNonQuery();

        //    }
        //    catch (SqlException ex)
        //    {

        //        //ScriptManager.RegisterStartupScript(this, GetType(), "Validar", "Hola();", true);
        //    }

        //    return cmd;
        //}
        public static SqlCommand Ejecutar(string comando)
        {
            try
            {
                cmd = new SqlCommand(comando, PruebaConexion.Conectar());
                cmd.ExecuteNonQuery();
                
            }
            catch (SqlException ex)
            {

                //ScriptManager.RegisterStartupScript(this, GetType(), "Validar", "Hola();", true);
            }

            return cmd;
        }

        internal static void Ejecutar(string v, PruebaConexion cmd)
        {
            throw new NotImplementedException();
        }

        public static CommandType Procedimiento(CommandType procedimiento)
        {
            return CommandType.StoredProcedure;

        }

    }
}
