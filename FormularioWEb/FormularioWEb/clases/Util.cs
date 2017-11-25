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
    }
}