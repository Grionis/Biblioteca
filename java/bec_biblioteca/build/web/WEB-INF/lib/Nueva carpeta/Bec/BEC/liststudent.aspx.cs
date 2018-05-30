using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEC.ServiceListar;
using System.Data;
using WcfService.WebList;

namespace BEC
{
    public partial class liststudent : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceListar.ListarClient l = new ServiceListar.ListarClient();
            //WcfService.WebList.ListarClient l = new WcfService.WebList.ListarClient();


            var listar = l.listarFicha();
            
            gvUsuario.DataSource = listar;
            gvUsuario.DataBind();

        }
    }
}