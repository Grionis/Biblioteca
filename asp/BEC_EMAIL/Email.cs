using BEC_EMAIL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEC_EMAIL
{
    public class Email
    {

        public void EnviarCorreo(string destino, string pass, string nombre)
        {
            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(destino);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Activacion de cuenta - BEC";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            //mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = CuerpoMensaje(destino,pass,nombre);


            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress("bibliotecabecchile@gmail.com");


            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.Credentials =
                new System.Net.NetworkCredential("bibliotecabecchile@gmail.com", "BibliotecaBec2017");

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail
           
            cliente.Port = 587;
            cliente.EnableSsl = true;
          

            cliente.Host = "smtp.gmail.com"; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                //Aquí gestionamos los errores al intentar enviar el correo
            }
        }

        public void EnviarCorreoPrestamo(string destino, string Tipo, string Nombre, DateTime fechaIni, DateTime fechFin)
        {
            /*-------------------------MENSAJE DE CORREO----------------------*/

            //Creamos un nuevo Objeto de mensaje
            System.Net.Mail.MailMessage mmsg = new System.Net.Mail.MailMessage();

            //Direccion de correo electronico a la que queremos enviar el mensaje
            mmsg.To.Add(destino);

            //Nota: La propiedad To es una colección que permite enviar el mensaje a más de un destinatario

            //Asunto
            mmsg.Subject = "Prestamo Bibioteca - BEC";
            mmsg.SubjectEncoding = System.Text.Encoding.UTF8;

            //Direccion de correo electronico que queremos que reciba una copia del mensaje
            //mmsg.Bcc.Add("destinatariocopia@servidordominio.com"); //Opcional

            //Cuerpo del Mensaje
            mmsg.Body = CuerpoMensajePrestamo(Tipo,Nombre,fechaIni,fechFin);


            mmsg.BodyEncoding = System.Text.Encoding.UTF8;
            mmsg.IsBodyHtml = true; //Si no queremos que se envíe como HTML

            //Correo electronico desde la que enviamos el mensaje
            mmsg.From = new System.Net.Mail.MailAddress("bibliotecabecchile@gmail.com");


            /*-------------------------CLIENTE DE CORREO----------------------*/

            //Creamos un objeto de cliente de correo
            System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient();

            //Hay que crear las credenciales del correo emisor
            cliente.Credentials =
                new System.Net.NetworkCredential("bibliotecabecchile@gmail.com", "BibliotecaBec2017");

            //Lo siguiente es obligatorio si enviamos el mensaje desde Gmail

            cliente.Port = 587;
            cliente.EnableSsl = true;


            cliente.Host = "smtp.gmail.com"; //Para Gmail "smtp.gmail.com";


            /*-------------------------ENVIO DE CORREO----------------------*/

            try
            {
                //Enviamos el mensaje      
                cliente.Send(mmsg);
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                //Aquí gestionamos los errores al intentar enviar el correo
            }
        }

        public string CuerpoMensaje(string mail, string pass,string nombre)
        {
            EAD en = new EAD();
            string UE = nombre + " 1234";
            string e = en.Encriptar(UE);

            string url = "<a href='http://localhost:49231/index.aspx?EAD=" + e+ "'>Link de activacion </a>:";



            return string.Format("<h1>Activacion de la cuenta </h1> <br>"+
                                 "<h2>Datos de la cuenta      </h2> <br>"+                                        
                                 "Nombre: "+ nombre + "<br>" +
                                 "Email: " + mail   + "<br>" +
                                 "<br><br>" +
                                 "<p> Para hacer efectivo su registro, debera ingresar al siguiente link para la activacion de su cuenta: "+
                                 url
                                    );
        }

        public string CuerpoMensajePrestamo(string Tipo, string Nombre, DateTime fechaIni, DateTime fechFin)
        {
            

         
            return string.Format("<h1>Prestamo </h1> <br>  " +
                                 "<h2>Detalles del prestamo </h2> <br>" +
                                 "Tipo: " + Tipo + "<br>" +
                                 "Nombre: " + Nombre + "<br>" +
                                 
                                 "Fecha de inicio del prestamo : " + fechaIni + "<br>" +
                                 "Fecha de termino del prestamo: " + fechFin + "<br>" +

                                 "<br><br>" +
                                 "<p> Recuerde hacer la <b> devolucion </b> dentro del tiempo indicado para evitar multas </p>" 
                              
                                    );
        }





        public string[] ActivacionCuenta(string codigo)
        {
 
            char[] delimitador = { ' ' };
            string[] mensaje = codigo.Split(delimitador);
            return mensaje;

        }
    }
}
