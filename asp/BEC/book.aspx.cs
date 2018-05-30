using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class book : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ddlGenero.Items.Add("Fantasia");
            ddlGenero.Items.Add("Infantil");
            ddlGenero.Items.Add("Suspenso");
            ddlGenero.Items.Add("Educacional");
            ddlGenero.Items.Add("Novela");
            ddlGenero.Items.Add("Accion");
            ddlGenero.Items.Add("Terror");
            ddlGenero.Items.Add("Intriga");
            ddlGenero.Items.Add("Ficcion");
            ddlGenero.DataBind();

            txtCodigo.Text = NewCodeBook().ToString();

            if (Session["usuario"] == null)
            {
                Response.Redirect("index.aspx");

            }
            else
            {
                lblNick.Text = Convert.ToString(Session["usuario"]);
            }


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
                    int libro = add.InsertarLibro(txtIsbn.Text, txtCodigo.Text, txtTitulo.Text, txtAutor.Text, ddlGenero.Text, txtAño.Text, 1, stock);

                    if (libro != 0)
                    {

                        Session["reg"] = "si";
                        Response.Redirect("catalog.aspx");
                    }
                    else
                    {
                        IncorrectLibro();
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
            var c = l.listarLibro();
            foreach (var item in c)
            {
                if (item.idLibro > 0)
                {
                    codigo = int.Parse(item.codigo) + 1;
                }
            }

            return codigo;
        }


        #region avisos BOOK
        public void CorrectLibro()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Libro agregado correctamente', 'Puede consultar su pagina de inicio para obtener mas informacion sobre los libros agregados', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void IncorrectLibro()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha podido agregar el libro', 'Si el problema persiste favor de comunicarse con MF para atender el problema', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }



        public void IncorrectStock()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha podido agregar el stock para el libro', 'Si el problema persiste favor de comunicarse con MF para atender el problema', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void IncorrectUbicacion()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha podido agregar la ubicacion para el libro', 'Si el problema persiste favor de comunicarse con MF para atender el problema', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }
    }
    #endregion

}