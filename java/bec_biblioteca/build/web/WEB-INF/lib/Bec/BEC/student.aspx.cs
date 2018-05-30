using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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

            
            WS_Agregar_Bec.AgregarClient add = new WS_Agregar_Bec.AgregarClient();

       
            
            if(add.insertarFicha(txtRut.Text, txtNombre.Text, txtDIreccion.Text, txtEmail.Text, txtTelefono.Text, int.Parse(txtHuella.Text)) != 0 )
            {
                lblAlert.Text = "Usuario agregado correctamente";
            }
            else
            {
                lblAlert.Text = "NO se ha podido registrar al usuario";
            }

            
            
        }
    }
}