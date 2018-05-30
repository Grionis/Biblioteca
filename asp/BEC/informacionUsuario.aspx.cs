using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class informacionUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("index.aspx");

            }
            else
            {
                //lblNick.Text = Convert.ToString(Session["usuario"]);
            }
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {

        }
    }
}