using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class reservaOnline : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("index.aspx");

            }
            lblNick.Text = Convert.ToString(Session["usuario"]);
            labelTipo.Visible = false;
            ddlTipo.Visible = false;
            ddlLibro.Visible = false;
            labelMultimedia.Visible = false;
            ddlMultimedia.Visible = false;
            labelEstado.Visible = false;
            txtEstado.Visible = false;
            labelFechDevolucion.Visible = false;
            //cfechaReserva.Visible = false;
            txtFechaPrestamo.Visible = false;
            labelFechReserva.Visible = false;
            txtFechaDevolución.Visible = false;
            labelLibro.Visible = false;
            ddlLibro.Visible = false;
            idUsuario.Visible = false;
            btnAceptar.Visible = false;
            btnGuardar.Visible = false;
            btnGuardarMultimedia.Visible = false;
        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            WS_Login_Bec.LoginClient v = new WS_Login_Bec.LoginClient();
            int x = v.ValidarInt(txtUser.Text, txtValidacion.Text);
            if (x > 0)
            {
               
                idUsuario.Text = x.ToString();
                labelTipo.Visible = true;
                ddlTipo.Visible = true;
                ddlTipo.Items.Add("Libro");
                ddlTipo.Items.Add("Multimedia");

                ddlTipo.DataBind();
                btnAceptar.Visible = true;
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            
            if (ddlTipo.Text.Equals("Libro"))
            {
                btnGuardar.Visible = true;
                labelEstado.Visible = true;
                txtEstado.Text = "Reservado";
                txtEstado.ReadOnly = true;
                txtEstado.Visible = true;
                labelFechReserva.Visible = true;
                //cfechaReserva.Visible = true;

                txtFechaPrestamo.Visible = true;
                //lblFechaDevolución.Visible = true;
                //txtFechaDevolución.Visible = true;
                labelLibro.Visible = true;
                ddlLibro.Visible = true;

                
                WS_Listar_Bec.ListarClient l = new WS_Listar_Bec.ListarClient();
                ddlLibro.DataTextField = "nombre";
                ddlLibro.DataValueField = "idLibro";
                ddlLibro.DataSource = l.listarLibro();
                ddlLibro.DataBind();
            }
            else
            {
                btnGuardarMultimedia.Visible = true;
                labelEstado.Visible = true;
                txtEstado.Text = "Reservado";
                txtEstado.ReadOnly = true;
                txtEstado.Visible = true;
                labelFechReserva.Visible = true;
                //cfechaReserva.Visible = true;

                txtFechaPrestamo.Visible = true;
                //lblFechaDevolución.Visible = true;
                //txtFechaDevolución.Visible = true;
                labelMultimedia.Visible = true;
                ddlMultimedia.Visible = true;


                WS_Listar_Bec.ListarClient l = new WS_Listar_Bec.ListarClient();
                ddlMultimedia.DataTextField = "nombre";
                ddlMultimedia.DataValueField = "idMultimedia";
                ddlMultimedia.DataSource = l.listarMultimedia();
                ddlMultimedia.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            WS_Agregar_Bec.AgregarClient pres = new WS_Agregar_Bec.AgregarClient();
            pres.insertaPrestamo(ddlTipo.Text, txtEstado.Text, txtFechaPrestamo.Text, txtFechaPrestamo.Text, int.Parse(idUsuario.Text), int.Parse(ddlLibro.Text));
            Correct();
        }

        protected void btnGuardarMultimedia_Click(object sender, EventArgs e)
        {
            WS_Agregar_Bec.AgregarClient pres = new WS_Agregar_Bec.AgregarClient();
            pres.insertaPrestamoMultimedia(ddlTipo.Text, txtEstado.Text, txtFechaPrestamo.Text, txtFechaPrestamo.Text, int.Parse(idUsuario.Text), int.Parse(ddlMultimedia.Text));
            Correct();
        }

        public void Correct()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Reserva agregada correctamente', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void Incorrect()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha podido generar la reserva', 'Presione ok para cerrar esta ventana', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }
    }
}