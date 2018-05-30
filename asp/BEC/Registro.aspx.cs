 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ServicePrueba.NewWebServiceClient list = new NewWebServiceClient();
            //cboUsuario.DataSource = list.listarFicha();
            //cboUsuario.DataBind();
        }

        #region
        /*
         * Se agregara la ficha en el orden indicado:
         * Rut
         * Nombre
         * Direccion
         * Email
         * Telefono
         * Fotografia(no se agrega aun)
         * Huella digital
         */
        #endregion

        protected void btnGuardar_Click(object sender, EventArgs e)
        {


            BEC_EMAIL.Email mail = new BEC_EMAIL.Email();
            WS_Agregar_Bec.AgregarClient add = new WS_Agregar_Bec.AgregarClient();
            BEC_EMAIL.User us = new BEC_EMAIL.User();

            //add.insertarFicha(txtRut.Text, txtNombre.Text, txtDIreccion.Text, txtEmail.Text, txtTelefono.Text, int.Parse(txtHuella.Text));
            
            int result = add.insertarFicha(txtRut.Text, txtNombre.Text, txtDIreccion.Text, txtEmail.Text, txtTelefono.Text, 123);

            if (result != 0)
            {
                string nick = us.CrearUser(txtNombre.Text.ToLower());
                add.insertarUsuario(nick, "D2wq#43gtd@kl#d1dDssq", 0, result, 1);
                mail.EnviarCorreo(txtEmail.Text, "D2wq#43gtd@kl#d1dDssq", nick);
                Session["Correcto"] = "si";
                Session["nick"] = nick;
                
                Session["reg"] = "si";
                Response.Redirect("index.aspx");


            }
            else
            {
                Incorrect();
            }



        }

        public void Correct()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Usuario agregado correctamente', 'Se ha enviado un email de confirmacion al usuario con sus datos de inicio de sesion', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            

        }

        public void Redirect()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "window.location.href = 'http://index.aspx';";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void Incorrect()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha podido agregar al usuario', 'Presione ok para cerrar esta ventana', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void IncorrectRut()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('El rut ingresado es incorrecto', 'Si el problema persiste, consulte con la administracion de la bibliotca', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        protected void txtRut_TextChanged(object sender, EventArgs e)
        {
            BEC_EMAIL.User us = new BEC_EMAIL.User();
            if(us.validarRut(txtRut.Text))
            {
                txtRut.Text = us.formatearRut(txtRut.Text);
            }
            else
            {
                IncorrectRut();
                txtRut.Text = "";
            }

        }
    }
}