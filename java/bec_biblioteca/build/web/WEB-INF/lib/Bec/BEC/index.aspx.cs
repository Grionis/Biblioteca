using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            ddlTypeUser.Items.Add("Seleccione tipo de usuario");
            ddlTypeUser.Items.Add("Usuario");
            ddlTypeUser.Items.Add("Administrativo Bibliotecario");
            ddlTypeUser.Items.Add("Bibliotecario");

            ddlTypeUser.DataBind();
        }
    }
}