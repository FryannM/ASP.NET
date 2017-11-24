using System;
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
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string CnnVal(string name)
        {
            return WebConfigurationManager.ConnectionStrings[name].ConnectionString;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            // Page.ClientScript.RegisterStartupScript(GetType(), "script", "Validacion();", true);

            ScriptManager.RegisterStartupScript(this, GetType(), "Validacion", "Validar()", true);
            //ClientScript.RegisterStartupScript(GetType(), "Mostrar","Validacion();", true);
        }

        public void ConectBD()
        {
            SqlConnection con = new SqlConnection(

               WebConfigurationManager.ConnectionStrings["WebServer"].ConnectionString);
            con.Open();
            if (con.State == System.Data.ConnectionState.Open)
            {
                DisplayMessage(this, "Successfull");
            }

        }
        static public void DisplayMessage(Control page, string msg)
        {
            string myScript = String.Format("alert('{0}')", msg);

            ScriptManager.RegisterStartupScript(page, page.GetType(), "Myscript", myScript, true);
        }
    }
}