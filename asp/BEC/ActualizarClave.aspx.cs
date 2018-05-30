using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class ActualizarClave : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (verificar()) { }
           
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string user = Convert.ToString(Session["nick"]);
            WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();
            WS_Actualizar_Bec.ActualizarClient update = new WS_Actualizar_Bec.ActualizarClient();
            if (txtPass1.Text.Equals(txtPass2.Text))
            {

                var datos = list.listarUsuarioPorNombre(user);
                foreach (var item in datos)
                {

                    if (update.actualizarUsuario(item.idUsuario, item.nombreUsuario, txtPass1.Text, item.activo, item.idRol, item.idFicha))
                    {
                        Session["correcto"] = null;
                        Session["nick"] = null;
                        Session["lg"] = "si";
                        Response.Redirect("index.aspx");
                    }
                }

            }
            else
            {
                
                fallo();

            }
        }


        
        #region Avisos

        public bool verificar()
        {
           

            if(Session["correcto"] != null)
            {
                Activacion();
                Session["estado"] = "d";
                Session["correcto"] = null;
                return true;

            }
            else
            {
                return false;
            }
            

        }

        public void fallo()
        {
             if(Session["estado"] != null)
            {

                CambioClaveMal();
               
            }
             else
            {
                Response.Redirect("index.aspx");
            }
        }
        public void Activacion()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Cuenta Activada correctamente', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            
        }

        

        public bool CambioClaveMal()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();

            

            String cstext1 = "swal('No coinciden las contraseñas', 'Si el problema persiste Favor de comunicarse con la administracion de la biblioteca para atender su problema', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }

        #endregion
    }
}