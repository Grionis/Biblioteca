using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class liststudent : System.Web.UI.Page
    {
        


        protected void Page_Load(object sender, EventArgs e)
        {

            listarFichas();

            lblNick.Text = Convert.ToString(Session["usuario"]);

            if(Session["reg"] != null)
            {
                UserAdd();

            }
        }



        public void listarFichas()
        {
            DataTable tb = new DataTable();
            DataRow dr;

            WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();

            var item = list.listarFicha();


            if (item != null)
            {

                tb.Columns.Add("Rut", typeof(string));
                tb.Columns.Add("Nombre", typeof(string));
                tb.Columns.Add("Direccion", typeof(string));
                tb.Columns.Add("Correo", typeof(string));
                tb.Columns.Add("Telefono", typeof(string));
               

                foreach (var items in item)
                {



                    dr = tb.NewRow();


                    dr["Rut"] = items.rut;
                    dr["Nombre"] = items.nombres;
                    dr["Direccion"] = items.direccion;
                    dr["Correo"] = items.correo;
                    dr["Telefono"] = items.telefono;
                  

                    tb.Rows.Add(dr);

                }


                gvUsuario.DataSource = tb;
                gvUsuario.DataBind();
                ViewState["table1"] = tb;

            }
        }



           private void UserAdd()
            {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Usuario agregado correctamente', 'Se ha enviado un email de confirmacion al usuario con sus datos de inicio de sesion', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

            Session["reg"] = null;


        }

        protected void gvUsuario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUsuario.PageIndex = e.NewPageIndex;
            listarFichas();
        }
    }
    }
