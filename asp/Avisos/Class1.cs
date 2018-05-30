using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;

namespace Avisos
{
    public class popups
    {

        public bool Activacion()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Cuenta Activada correctamente', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }

        public bool CambioClaveBien()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Clave de acceso actualizada correctamente', 'Ya puede ingresar con sus credenciales al sistema de biblioteca BEC', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }

        public bool CambioClaveMal()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha podido actualizar la clave', 'Favor de comunicarse con la administracion de la biblioteca para atender su problema', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }




    }
}
