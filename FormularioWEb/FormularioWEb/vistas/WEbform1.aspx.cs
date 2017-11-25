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
       
        protected void Button1_Click1(object sender, EventArgs e)
        {
            int id = 0;
            if (sqlCon.State == System.Data.ConnectionState.Closed)
                sqlCon.Open();


            SqlCommand cmd = new SqlCommand("sp_save", sqlCon);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
         
            cmd.Parameters.AddWithValue("@idpersona",id);
            cmd.Parameters.AddWithValue("@name", nametxt.Text.Trim());
            cmd.Parameters.AddWithValue("@lastname", lastnametxt.Text.Trim());
            cmd.Parameters.AddWithValue("@cedula", idtxt.Text.Trim());
            cmd.Parameters.AddWithValue("@dateT", datetxt.Text.Trim());
            cmd.Parameters.AddWithValue("@email", emailtxt.Text.Trim());
            cmd.Parameters.AddWithValue("@phone", phonetxt.Text.Trim());
            cmd.Parameters.AddWithValue("@country", paislist.Text.Trim());
            cmd.Parameters.AddWithValue("@career", carreer.Text.Trim());
            cmd.ExecuteNonQuery();

            sqlCon.Close();
            if (id !=0 )
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Validacion", "MsgSuccessul()", true);

            }

         






        }
    }
}