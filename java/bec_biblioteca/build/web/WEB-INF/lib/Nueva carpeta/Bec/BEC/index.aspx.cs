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
            //ddlTypeUser.Items.Add(l.listarRol().ToString());
          
            ddlTypeUser.DataBind();
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            ServiceListar.usuario u = new ServiceListar.usuario();

            if(txtUser.Text == u.nombreUsuario && txtPass.Text == u.clave)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                lblAlerta.Text = "Usuario/contraseña incorrecta";
                txtUser.Text = "";
                txtPass.Text = "";
            }
        }
    }
}