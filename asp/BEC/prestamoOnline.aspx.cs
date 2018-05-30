using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class PrestamoOnline : System.Web.UI.Page
    {
        BEC_EMAIL.Email em = new BEC_EMAIL.Email();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["correcto"] != null)
            {
                logCorrect();
                Session["correcto"] = null;
                
            }

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
            labelFechPrestamo.Visible = false;
            //cfechaReserva.Visible = false;
            txtFechaPrestamo.Visible = false;
            labelFechDevolucion.Visible = false;
            txtFechaDevolución.Visible = false;
            labelLibro.Visible = false;
            ddlLibro.Visible = false;
            idUsuario.Visible = false;
            btnAceptar.Visible = false;
            btnGuardar.Visible = false;
            btnGuardarMultimedia.Visible = false;
            txtFechaPrestamo.ReadOnly = true;
            txtFechaPrestamo.Text = DateTime.Now.ToString("G");
            DateTime fecha = Convert.ToDateTime(txtFechaPrestamo.Text);
            fecha = fecha.AddDays(4);
            txtFechaDevolución.ReadOnly = true;
            txtFechaDevolución.Text = fecha.ToString();

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            WS_Actualizar_Bec.ActualizarClient act = new WS_Actualizar_Bec.ActualizarClient();
            WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();
            WS_Agregar_Bec.AgregarClient pres = new WS_Agregar_Bec.AgregarClient();


            string use = Convert.ToString(Session["usuarioP"]);
            var user = list.listarUsuarioPorNombre(use);
            string book = "";
            string usuario = "";
            int id = 0;
            foreach (var us in user)
            {
                id = us.idFicha;
            }
            var ficha = list.listarFichaPorId(id);
            foreach (var f in ficha)
            {
                usuario = f.correo;
            }
            var libro = list.listarLibroPorId(int.Parse(ddlLibro.Text));
            foreach (var l in libro)
            {
                book = l.nombre;
            }

            pres.insertaPrestamo(ddlTipo.Text, txtEstado.Text, txtFechaPrestamo.Text, txtFechaDevolución.Text, int.Parse(idUsuario.Text), int.Parse(ddlLibro.Text));
            Session["tipo"] = ddlTipo.Text;
            Session["estado"] = txtEstado.Text;
            Session["fechaP"] = txtFechaPrestamo.Text;
            Session["FechaD"] = txtFechaDevolución.Text;
            em.EnviarCorreoPrestamo(usuario, ddlTipo.Text, book, Convert.ToDateTime(txtFechaPrestamo.Text), Convert.ToDateTime(txtFechaDevolución.Text));

            Response.Redirect("comprobante.aspx");


        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            WS_Login_Bec.LoginClient v = new WS_Login_Bec.LoginClient();
            int x = v.ValidarInt(txtUser.Text, txtValidacion.Text);
            if (x > 0)
            {
                Session["usuarioP"] = txtUser.Text;
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
                txtEstado.Text = "Domicilio";
                txtEstado.ReadOnly = true;
                txtEstado.Visible = true;
                labelFechPrestamo.Visible = true;
                //cfechaReserva.Visible = true;

                txtFechaPrestamo.Visible = true;
                labelFechDevolucion.Visible = true;
                txtFechaDevolución.Visible = true;
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
                txtEstado.Text = "Domicilio";
                txtEstado.ReadOnly = true;
                txtEstado.Visible = true;
                labelFechPrestamo.Visible = true;
                //cfechaReserva.Visible = true;

                txtFechaPrestamo.Visible = true;
                labelFechDevolucion.Visible = true;
                txtFechaDevolución.Visible = true;
                labelMultimedia.Visible = true;
                ddlMultimedia.Visible = true;


                WS_Listar_Bec.ListarClient l = new WS_Listar_Bec.ListarClient();
                ddlMultimedia.DataTextField = "nombre";
                ddlMultimedia.DataValueField = "idMultimedia";
                ddlMultimedia.DataSource = l.listarMultimedia();
                ddlMultimedia.DataBind();
            }
        }

        protected void btnGuardarMultimedia_Click(object sender, EventArgs e)
        {
            WS_Actualizar_Bec.ActualizarClient act = new WS_Actualizar_Bec.ActualizarClient();
            WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();
            WS_Agregar_Bec.AgregarClient pres = new WS_Agregar_Bec.AgregarClient();


            string use = Convert.ToString(Session["usuarioP"]);
            var user = list.listarUsuarioPorNombre(use);
            string multi = "";
            string usuario = "";
            int id = 0;
            foreach (var us in user)
            {
                id = us.idFicha;
            }
            var ficha = list.listarFichaPorId(id);
            foreach (var f in ficha)
            {
                usuario = f.correo;
            }
            var libro = list.ListarMultimediaPorId(int.Parse(ddlLibro.Text));
            foreach (var l in libro)
            {
                multi = l.nombre;
            }

          
            pres.insertaPrestamoMultimedia(ddlTipo.Text, txtEstado.Text, txtFechaPrestamo.Text, txtFechaDevolución.Text, int.Parse(idUsuario.Text), int.Parse(ddlMultimedia.Text));
            Session["tipo"] = ddlTipo.Text;
            Session["estado"] = txtEstado.Text;
            Session["fechaP"] = txtFechaPrestamo.Text;
            Session["FechaD"] = txtFechaDevolución.Text;
            em.EnviarCorreoPrestamo(usuario, ddlTipo.Text, multi, Convert.ToDateTime(txtFechaPrestamo.Text), Convert.ToDateTime(txtFechaDevolución.Text));

            Response.Redirect("comprobante.aspx");
        }

        public bool logCorrect()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Usuario logueado correctamente', 'Presione ok para cerrar esta ventana', 'success');";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }
    }
}