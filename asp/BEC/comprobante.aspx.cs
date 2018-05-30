using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class comprobante : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtTipo.Text = Convert.ToString(Session["tipo"]);
            txtEstado.Text = Convert.ToString(Session["estado"]);
            txtFechaPrestamo.Text = Convert.ToString(Session["fechaP"]);
            txtFechaDevolución.Text = Convert.ToString(Session["FechaD"]);
        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("prestamoOnline.aspx");
        }
    }
}