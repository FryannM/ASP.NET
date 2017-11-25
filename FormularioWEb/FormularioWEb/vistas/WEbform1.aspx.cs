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

        SqlConnection sqlCon =  new SqlConnection(@"Data Source=FRYANNM\SQLEXPRESS;Initial Catalog=WebServer;Integrated Security=True");
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public static string CnnVal(string name)
        {
            return WebConfigurationManager.ConnectionStrings[name].ConnectionString;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();
           

            SqlCommand cmd = new SqlCommand("sp_save", sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            // cmd.Parameters.AddWithValue("@idpersona",hfidpersona.Value);
            cmd.Parameters.AddWithValue("@name",nametxt.Text.Trim());
            cmd.Parameters.AddWithValue("@lastname", nametxt.Text.Trim());
            cmd.Parameters.AddWithValue("@date", nametxt.Text.Trim());
            cmd.Parameters.AddWithValue("@email", nametxt.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", nametxt.Text.Trim());
            cmd.Parameters.AddWithValue("@country", nametxt.Text.Trim());
            cmd.Parameters.AddWithValue("@career", nametxt.Text.Trim());




            ScriptManager.RegisterStartupScript(this, GetType(), "Validacion", "Validar()", true);
           
          
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