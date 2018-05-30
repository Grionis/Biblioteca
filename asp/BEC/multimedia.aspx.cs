using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class multimedia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("index.aspx");

            }
            else
            {
                ddlTipoMultimedia.Items.Add("DVD");
                ddlTipoMultimedia.Items.Add("CD");
                ddlTipoMultimedia.Items.Add("Pelicula");
                ddlTipoMultimedia.DataBind();
                txtCodigo.Text = NewCodeBook().ToString();

            }
            lblNick.Text = Convert.ToString(Session["usuario"]);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            WS_Agregar_Bec.AgregarClient add = new WS_Agregar_Bec.AgregarClient();
            int estante = add.InsertarEstante(txtPiso.Text, txtEstante.Text);
            if (estante != 0)
            {
                int stock = add.InsertarStock(int.Parse(txtStock.Text), 0, int.Parse(txtStock.Text), estante);

                if (stock != 0)
                {
                    int multi = add.InsertarMultimedia(txtCodigo.Text,ddlTipoMultimedia.Text, txtTitulo.Text,txtAutor.Text,txtAño.Text, stock);

                    if (multi != 0)
                    {
                        Session["regM"] = "si";
                        Response.Redirect("catalog.aspx");
                    }
                    else
                    {
                        IncorrectoMultimedia();
                    }

                }
                else
                {
                    IncorrectStock();
                }
            }
            else
            {
                IncorrectUbicacion();
            }


        }


        public int NewCodeBook()
        {
            WS_Listar_Bec.ListarClient l = new WS_Listar_Bec.ListarClient();
            int codigo = 0;
            var c = l.listarMultimedia();
            foreach (var item in c)
            {
                if (item.idMultimedia > 0)
                {
                    codigo = int.Parse(item.codigo) + 1;
                }
            }

            return codigo;
        }


        #region avisos BOOK
        public void CorrectoMultimedia()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Multimedia agregada correctamente', 'Puede consultar su pagina de inicio para obtener mas informacion sobre los multimedias agregados', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void IncorrectoMultimedia()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha podido agregar el multimedia', 'Si el problema persiste favor de comunicarse con MF para atender el problema', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }



        public void IncorrectStock()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha podido agregar el stock para el multimedia', 'Si el problema persiste favor de comunicarse con MF para atender el problema', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void IncorrectUbicacion()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha podido agregar la ubicacion para el Multimedia', 'Si el problema persiste favor de comunicarse con MF para atender el problema', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }
    }
    #endregion
}
    
