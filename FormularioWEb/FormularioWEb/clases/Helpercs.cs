using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Data.SqlClient;
using System.Web.Script;


namespace FormularioWEb.clases
{
    public class Helpercs
    {
        public static string CnnVal(string name)
        {
            return WebConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}