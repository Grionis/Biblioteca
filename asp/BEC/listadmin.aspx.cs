using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEC.WS_Listar_Bec;
using System.Data;

namespace BEC
{
    public partial class listadmin : System.Web.UI.Page
    {
        WS_Listar_Bec.ListarClient l = new ListarClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            listarUsuarios();
            lblNick.Text = Convert.ToString(Session["usuario"]);
        }

        public void listarUsuarios()
        {
            DataTable tb = new DataTable();
            DataRow dr;

            WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();

            var item = list.listarUsuario();


            if (item != null)
            {

                tb.Columns.Add("Nombre de usuario", typeof(string));
                tb.Columns.Add("Clave", typeof(string));
                


                foreach (var items in item)
                {



                    dr = tb.NewRow();


                    dr["Nombre de usuario"] = items.nombreUsuario;
                    dr["Clave"] = items.clave;
                   

                    tb.Rows.Add(dr);

                }


                gvUsuarios.DataSource = tb;
                gvUsuarios.DataBind();
                ViewState["table1"] = tb;
            }
        }

    }

    }
