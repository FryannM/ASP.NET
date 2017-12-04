using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Configuration;
using System.Security.Cryptography;
using System.Web.UI.WebControls;
using System.Web.Configuration;


using System.Web.Script;

namespace FormularioWEb.clases
{
    public class datamanager
    {

        public static string cadenadeconexion
        {
            get
            {
                return WebConfigurationManager.ConnectionStrings["WebServer"].ConnectionString;
            }
            private set { }
        }
        public static SqlConnection ConexionSQL;

      

        public static String loginName { get; private set; }
        public static int IdUsuario { get; private set; }

        public static Boolean ConexionAbrir()
        {
            Boolean ret = true;
            try
            {
                ConexionSQL = new SqlConnection(cadenadeconexion);
                ConexionSQL.Open();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                ret = false;
            }
            return ret;
        }
        // Fin ConexionCerrar

        public static Boolean ConexionCerrar()
        {
            Boolean ret = true;
            try
            {
                ConexionSQL = new SqlConnection(cadenadeconexion);
                ConexionSQL.Open();
            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
                ret = false;
            }
            return ret;
        }
        // Fin ConexionCerra

        public static SqlDataReader ConsultaLeer(string cmdSQL)
        {
            SqlDataReader reader = null;
            if (ConexionAbrir())
            {
                SqlCommand cmd = new SqlCommand();

                try
                {
                    cmd.CommandText = cmdSQL;
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = ConexionSQL;
                    reader = cmd.ExecuteReader();
                }
                catch (Exception ex)
                {
                   
                    reader = null;
                }
                ConexionCerrar();
            }
            return reader;
        }
        // Fin ConsultaLeer

        public static DataSet ConsultaDatos(string cmdSQL)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();

            if (ConexionAbrir())
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    cmd.Connection = ConexionSQL;
                    cmd.CommandText = cmdSQL;
                    adapter.SelectCommand = cmd;
                    adapter.Fill(ds);
                }
                catch (Exception ex)
                {
                   
                    ds = null;
                }
                ConexionCerrar();
            }
            return ds;
        }
        // Fin ConsultaDatos
    }
}