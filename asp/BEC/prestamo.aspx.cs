using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class Prestamo : System.Web.UI.Page
    {
        BEC_EMAIL.Email em = new BEC_EMAIL.Email();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("index.aspx");

            }
            else
            {
                lblNick.Text = Convert.ToString(Session["usuario"]);
                // lblTipo.Visible = false;
                //ddlTipo.Visible = false;
                ddlLibro.Visible = false;
                lblMultimedia.Visible = false;
                ddlMultimedia.Visible = false;
                lblEstado.Visible = false;
                txtEstado.Visible = false;
                lblFechaPrestamo.Visible = false;
                //cfechaReserva.Visible = false;
                txtFechaPrestamo.Visible = false;
                lblFechaDevolución.Visible = false;
                txtFechaDevolución.Visible = false;
                lblLibro.Visible = false;
                ddlLibro.Visible = false;
                // idUsuario.Visible = false;
                // btnAceptar.Visible = false;
                btnGuardar.Visible = false;
                btnGuardarMultimedia.Visible = false;
                txtFechaPrestamo.ReadOnly = true;
                txtFechaPrestamo.Text = DateTime.Now.ToString("G");
                DateTime fecha = Convert.ToDateTime(txtFechaPrestamo.Text);
                fecha = fecha.AddHours(5);
                txtFechaDevolución.ReadOnly = true;
                txtFechaDevolución.Text = fecha.ToString("G");
                ddlUsuario.Visible = false;
                lblUsuario.Visible = false;
                //txtUser.Visible = false;
                ddlTipo.Items.Add("Libro");
                ddlTipo.Items.Add("Multimedia");

                ddlTipo.DataBind();
            }



        }
        
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            WS_Actualizar_Bec.ActualizarClient act = new WS_Actualizar_Bec.ActualizarClient();
            WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();
            WS_Agregar_Bec.AgregarClient pres = new WS_Agregar_Bec.AgregarClient();
            if (pres.insertaPrestamo(ddlTipo.Text, txtEstado.Text, txtFechaPrestamo.Text, txtFechaDevolución.Text, int.Parse(ddlUsuario.Text), int.Parse(ddlLibro.Text)))
            {
                int stock;
                int total;
                int calculo;
                var item = list.listarLibroPorId(int.Parse(ddlLibro.Text));
                var user = list.listarUsuarioPorId(int.Parse(ddlUsuario.Text));
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
                

                foreach (var items in item)
                {
                    stock = items.idstock;


                    var item2 = list.listarStockPorId(stock);
                    foreach (var item1 in item2)
                    {
                        if (item1.total > 1)
                        {
                            total = item1.total - 1;
                            calculo = item1.total - total;
                            act.ActualizarStock(stock, total, calculo, item1.total, item1.idestante);
                            //string destino,string Tipo, string Nombre, string Autor, DateTime fechaIni, DateTime fechFin
                            em.EnviarCorreoPrestamo(usuario,ddlTipo.Text, book, Convert.ToDateTime(txtFechaPrestamo.Text), Convert.ToDateTime(txtFechaDevolución.Text));

                            Session["regP"] = "si";
                            Response.Redirect("loan.aspx");
                        }
                    }
                }

            }
            else
            {
                Incorrect();
            }
        }

      /*  protected void btnValidar_Click(object sender, EventArgs e)
        {
            // WS_Login_Bec.LoginClient v = new WS_Login_Bec.LoginClient();
            // int x = v.ValidarInt(txtUser.Text, txtValidacion.Text);
           
            int x = int.Parse(ddlUsuario.Text);
            
            if (x > 0)
            {

                idUsuario.Text = x.ToString();
                lblTipo.Visible = true;
                ddlTipo.Visible = true;
                ddlTipo.Items.Add("Libro");
                ddlTipo.Items.Add("Multimedia");

                ddlTipo.DataBind();
                btnAceptar.Visible = true;
            }
        }
*/
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            if (ddlTipo.Text.Equals("Libro"))
            {
                ddlTipo.Visible = false;
                lblTipo.Visible = false;
                btnAceptar.Visible = false;
                btnGuardar.Visible = true;
                lblEstado.Visible = true;
                txtEstado.Text = "Meson";
                txtEstado.ReadOnly = true;
                txtEstado.Visible = true;
                lblFechaPrestamo.Visible = true;
                //cfechaReserva.Visible = true;

                txtFechaPrestamo.Visible = true;
                lblFechaDevolución.Visible = true;
                txtFechaDevolución.Visible = true;
                lblLibro.Visible = true;
                ddlLibro.Visible = true;
                ddlUsuario.Visible = true;
                lblUsuario.Visible = true;

                WS_Listar_Bec.ListarClient l = new WS_Listar_Bec.ListarClient();
                ddlLibro.DataTextField = "nombre";
                ddlLibro.DataValueField = "idLibro";
                ddlLibro.DataSource = l.listarLibro();
                ddlLibro.DataBind();

                WS_Listar_Bec.ListarClient listarUsuario = new WS_Listar_Bec.ListarClient();
                ddlUsuario.DataTextField = "nombreUsuario";
                ddlUsuario.DataValueField = "idUsuario";
                ddlUsuario.DataSource = listarUsuario.listarUsuario();
                ddlUsuario.DataBind();
            }
            else
            {
                ddlTipo.Visible = false;
                lblTipo.Visible = false;
                btnAceptar.Visible = false;
                btnGuardarMultimedia.Visible = true;
                lblEstado.Visible = true;
                txtEstado.Text = "Meson";
                txtEstado.ReadOnly = true;
                txtEstado.Visible = true;
                lblFechaPrestamo.Visible = true;
                //cfechaReserva.Visible = true;

                txtFechaPrestamo.Visible = true;
                lblFechaDevolución.Visible = true;
                txtFechaDevolución.Visible = true;
                lblMultimedia.Visible = true;
                ddlMultimedia.Visible = true;
                ddlUsuario.Visible = true;
                lblUsuario.Visible = true;

                WS_Listar_Bec.ListarClient l = new WS_Listar_Bec.ListarClient();
                ddlMultimedia.DataTextField = "nombre";
                ddlMultimedia.DataValueField = "idMultimedia";
                ddlMultimedia.DataSource = l.listarMultimedia();
                ddlMultimedia.DataBind();

                WS_Listar_Bec.ListarClient listarUsuario = new WS_Listar_Bec.ListarClient();
                ddlUsuario.DataTextField = "nombreUsuario";
                ddlUsuario.DataValueField = "idUsuario";
                ddlUsuario.DataSource = listarUsuario.listarUsuario();
                ddlUsuario.DataBind();
            }
        }

        protected void btnGuardarMultimedia_Click(object sender, EventArgs e)
        {
            WS_Actualizar_Bec.ActualizarClient act = new WS_Actualizar_Bec.ActualizarClient();
            WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();
            WS_Agregar_Bec.AgregarClient pres = new WS_Agregar_Bec.AgregarClient();
            if (pres.insertaPrestamoMultimedia(ddlTipo.Text, txtEstado.Text, txtFechaPrestamo.Text, txtFechaDevolución.Text, int.Parse(ddlUsuario.Text), int.Parse(ddlMultimedia.Text)))
            {
                int stock;
                int total;
                int calculo;
                var item = list.ListarMultimediaPorId(int.Parse(ddlMultimedia.Text));

                var user = list.listarUsuarioPorId(int.Parse(ddlUsuario.Text));
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
                var libro = list.ListarMultimediaPorId(int.Parse(ddlMultimedia.Text));
                foreach (var l in libro)
                {
                    multi = l.nombre;
                }

                foreach (var items in item)
                {
                    stock = items.idstock;


                    var item2 = list.listarStockPorId(stock);
                    foreach (var item1 in item2)
                    {
                        if (item1.total > 1)
                        {
                            total = item1.total - 1;
                            calculo = item1.total - total;
                            act.ActualizarStock(stock, total, calculo, item1.total, item1.idestante);
                            em.EnviarCorreoPrestamo(usuario, ddlTipo.Text, multi, Convert.ToDateTime(txtFechaPrestamo.Text), Convert.ToDateTime(txtFechaDevolución.Text));

                            Session["regP"] = "si";
                            Response.Redirect("loan.aspx");
                        }
                    }
                }
               

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



            String cstext1 = "swal('Prestamo agregado correctamente', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void Incorrect()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha podido agregar el prestamo', 'Presione ok para cerrar esta ventana', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }
    }
    }
