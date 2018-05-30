using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEC.ServiceListar;

namespace BEC
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceListar.ListarClient l = new ListarClient();
            ddlTypeUser.Items.Add("Seleccione tipo de usuario");
            ddlTypeUser.Items.Add(l.listarRol().ToString());
          
            ddlTypeUser.DataBind();
        }
    }
}