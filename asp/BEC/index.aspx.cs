using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidarCuentaActivada();

            if (Session["lg"] != null)
            {
                CambioClaveBien();
                Session["estado"] = null;
            }
            else if(Session["reg"] != null)
            {

                RegistroBien();
            }
            
            
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            



            WS_Login_Bec.LoginClient log = new WS_Login_Bec.LoginClient();


            if (log.Logear(txtUser.Text, txtPass.Text))
            {
                WS_Listar_Bec.ListarClient l = new WS_Listar_Bec.ListarClient();
                var item = l.listarUsuarioPorNombre(txtUser.Text);
                foreach (var u in item)
                {


                    Session["usuario"] = txtUser.Text;
                    Session["idRol"] = u.idRol;


                    if(u.activo > 0)
                    { 

                    if (u.idRol == 3)
                    {
                            Session["correcto"] = "si";
                            Response.Redirect("homeAdministrativo.aspx");
                           
                   }
                    if (u.idRol == 2)
                    {
                            Session["correcto"] = "si";
                            Response.Redirect("home.aspx");
                    }
                    if (u.idRol == 1)
                        {



                            Session["correcto"] = "si";
                            Response.Redirect("prestamoOnline.aspx");

                        }


                    }
                    else
                    {
                        lblalert.Text = "Su cuenta no esta activada";
                    }
                }
            }

            else
            {

                logIncorrect();
                

            }
        }

        public void ValidarCuentaActivada()
        {
            WS_Listar_Bec.ListarClient l = new WS_Listar_Bec.ListarClient();
            WS_Actualizar_Bec.ActualizarClient update = new BEC.WS_Actualizar_Bec.ActualizarClient();


            string text = Convert.ToString(Request.QueryString["EAD"]);
            if (text != null)
            {
                BEC_EMAIL.Email mail = new BEC_EMAIL.Email();
                BEC_EMAIL.EAD d = new BEC_EMAIL.EAD();


                string[] salida = new string[1];
                salida = mail.ActivacionCuenta(d.DesEncriptar(text));
                var nick = l.listarUsuarioPorNombre(salida[0]);
                if (nick != null)
                {
                    foreach (var item in nick)
                    {

                        if (item.clave.Equals("D2wq#43gtd@kl#d1dDssq"))
                        {

                            if (update.actualizarUsuario(item.idUsuario, item.nombreUsuario, item.clave, int.Parse(salida[1]), item.idRol, item.idFicha))
                            {
                                //int id, String nomU, String pass,int codigo, int r, int f
                                Session["correcto"] = "si";

                                Session["nick"] = item.nombreUsuario;
                                Response.Redirect("ActualizarClave.aspx");

                            }
                            else
                            {
                                SinActivar();
                            }
                        }
                        else
                        {
                            LinkUsado();
                        }
                    }
                }
                else
                {
                    NoUsuario();
                }



            }
        }

        #region Mensaje login     
        public bool logCorrect()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Usuario logueado correctamente', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }

        public bool Activacion()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Cuenta Activada correctamente', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }

        public bool SinActivar()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('La cuenta no se encuentra activada', 'Revise su bandeja de correos el link de activacion', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }

        public bool NoUsuario()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha encontrado el nombre de usuario', 'Favor de comunicarse con la administracion de la biblioteca para atender su problema', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }

        public bool logIncorrect()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Usuario o contraseña incorrecto', 'Valide la informacion ingresada nuevamente', 'error');";
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
            Session["lg"] = null;
            return true;
        }

        public bool RegistroBien()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Usuario agregado correctamente', 'Se ha enviado un email de confirmacion al usuario con sus datos de inicio de sesion', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

            Session["reg"] = null;

            return true;

        }

        public bool LinkUsado()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('El link de activacion ya ha expirado o ya se ha cambiado la clave', 'En caso de tener problemas con el cambio de clave, favor solicitar asistencia a la Administracion de la biblioteca', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            Session["lg"] = null;
            return true;
        }
        #endregion


    }
}