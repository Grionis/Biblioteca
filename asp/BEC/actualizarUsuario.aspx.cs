using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class actualizarUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            //WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();
            //WS_Actualizar_Bec.ActualizarClient update = new WS_Actualizar_Bec.ActualizarClient();
            //var usuario = list.listarUsuarioPorNombre(txtBusqueda.Text);

            //var fichauser = list.listarFichaPorId(usuario.idFicha);
           
        }

            /*
            if (update.actualizarUsuario(usuario.idUsuario, txtUSer.Text, txtPass1.Text))
            {
                if(update.ActualizarFicha(fichauser.idFicha,txtRut.Text, txtNombre.Text, txtDIreccion.Text, txtEmail.Text, txtTelefono.Text, int.Parse(txtHuella.Text)))
                {
                    lblAlert.Text = "Informacion del usuario actualizada correctamente";
                }
                else
                {
                    lblAlert.Text = "No se ha podido actualizar la informacion de la ficha del usuario";
                }
            }
            else
            {
                lblAlert.Text = "No se ha podido actualizar la informacion del usuario";
            }

        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();


            try
            {
                var item = list.listarUsuarioPorNombre(txtBusqueda.Text);
                var ficha = list.listarFichaPorId(item.idFicha);

                //se muestra la informacion de usuario
                txtUSer.Text = item.nombreUsuario;
                txtPass1.Text = item.clave;

                //se muestra la informacion de la ficha relacionada a ese usuario
                txtRut.Text = ficha.rut;
                txtNombre.Text = ficha.nombres;
                txtDIreccion.Text = ficha.direccion;
                txtEmail.Text = ficha.correo;
                txtTelefono.Text = ficha.telefono;
                txtHuella.Text = ficha.huella.ToString();
            }catch(Exception E)
            {

                lblAlert.Text = "Usuario no encontraro";
            }

        }
       

        public void limpiar()
        {
            txtUSer.Text = "";
            txtPass1.Text = "";

            
            txtRut.Text = "";
            txtNombre.Text = "";
            txtDIreccion.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = ""; 
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
     */
        }
        }