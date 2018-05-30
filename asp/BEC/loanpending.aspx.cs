using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class loanpending : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("index.aspx");

            }
            else
            {
                lblNick.Text = Convert.ToString(Session["usuario"]);
                txtFechaHoy.Text = DateTime.Now.ToString("G");
                txtFechaHoy.Visible = false;
                lblIdPrestamo.Visible = false;
                txtIdprestamo.Visible = false;
                txtIdprestamo.ReadOnly = true;
                lblTipo.Visible = false;
                txtTipo.Visible = false;
                txtTipo.ReadOnly = true;
                lblEstado.Visible = false;
                txtEstado.Visible = false;
                txtEstado.ReadOnly = true;
                lblFechaP.Visible = false;
                txtFechaP.Visible = false;
                txtFechaP.ReadOnly = true;
                lblFechaD.Visible = false;
                txtFechaD.Visible = false;
                txtFechaD.ReadOnly = true;
                lblUsuario.Visible = false;
                txtUsuario.Visible = false;
                txtUsuario.ReadOnly = true;
                lblLibro.Visible = false;
                txtLibro.Visible = false;
                txtLibro.ReadOnly = true;
                ddlDocumento.Items.Add("Libro");
                ddlDocumento.Items.Add("Multimeddia");
                ddlDocumento.DataBind();
                btnDevolver.Visible = false;
                btnDevolverMultimedia.Visible = false;

            }
            
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoLib = "";
            string codigoMul = "";

            if (ddlDocumento.Text.Equals("Libro"))
            {
                

                WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();
                int x = list.listarLibroByCodigo(txtCodigo.Text);
                var libro = list.listarLibro();
                var item = list.ListarPrestamoPorIdLibro(x);

                foreach (var l in libro)
                {
                    if (l.codigo.Equals(txtCodigo.Text))
                    {
                        codigoLib = txtCodigo.Text;
                        Correct();
                        btnDevolverMultimedia.Visible = false;
                        lblDocumento.Visible = false;
                        ddlDocumento.Visible = false;
                        txtCodigo.ReadOnly = true;
                        lblIdPrestamo.Visible = true;
                        txtIdprestamo.Visible = true;

                        lblTipo.Visible = true;
                        txtTipo.Visible = true;

                        lblEstado.Visible = true;
                        txtEstado.Visible = true;

                        lblFechaP.Visible = true;
                        txtFechaP.Visible = true;

                        lblFechaD.Visible = true;
                        txtFechaD.Visible = true;
                        btnDevolver.Visible = true;
                        //lblUsuario.Visible = true;
                        //txtUsuario.Visible = true;

                        //lblLibro.Visible = true;
                        // txtLibro.Visible = true;

                        foreach (var items in item)
                        {
                            txtIdprestamo.Text = items.idPrestamo.ToString();
                            txtTipo.Text = items.tipo.ToString();
                            txtEstado.Text = items.estado.ToString();
                            txtFechaP.Text = items.fechaPrestamo.ToString();
                            txtFechaD.Text = items.fechaDevolucion.ToString();
                            txtUsuario.Text = items.idUsuario.ToString();
                            txtLibro.Text = items.idLibro.ToString();


                        }
                    }
                   
                    
                }
               
                    
            }
            else
            {
                
                WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();
                int x = list.listarMultimediaByCodigo(txtCodigo.Text);

                var item = list.ListarPrestamoPorIdMultimedia(x);
                var multimedia = list.listarMultimedia();
                foreach (var m in multimedia)
                {
                    if (m.codigo.Equals(txtCodigo.Text))
                    {
                        codigoMul = txtCodigo.Text;
                        Correct();
                        btnDevolver.Visible = false;
                        lblDocumento.Visible = false;
                        ddlDocumento.Visible = false;
                        txtCodigo.ReadOnly = true;
                        lblIdPrestamo.Visible = true;
                        txtIdprestamo.Visible = true;
                        lblTipo.Visible = true;
                        txtTipo.Visible = true;
                        lblEstado.Visible = true;
                        txtEstado.Visible = true;
                        lblFechaP.Visible = true;
                        txtFechaP.Visible = true;
                        lblFechaD.Visible = true;
                        txtFechaD.Visible = true;
                        //lblUsuario.Visible = true;
                        //txtUsuario.Visible = true;
                        //lblLibro.Visible = true;
                        //txtLibro.Visible = true;
                        btnDevolverMultimedia.Visible = true;



                        foreach (var items in item)
                        {
                            txtIdprestamo.Text = items.idPrestamo.ToString();
                            txtTipo.Text = items.tipo.ToString();
                            txtEstado.Text = items.estado.ToString();
                            txtFechaP.Text = items.fechaPrestamo.ToString();
                            txtFechaD.Text = items.fechaDevolucion.ToString();
                            txtUsuario.Text = items.idUsuario.ToString();
                            txtLibro.Text = items.idMultimedia.ToString();

                        }
                    }
                    
                }
            }

            if (codigoLib == "" || codigoMul == "") { Incorrect(); }


        }

        protected void btnDevolver_Click(object sender, EventArgs e)
        {

            btnBuscar.Visible = false;
            WS_Actualizar_Bec.ActualizarClient actualizar = new WS_Actualizar_Bec.ActualizarClient();
           int fechaD = Convert.ToDateTime(txtFechaD.Text).Day;
           int fechaH = Convert.ToDateTime(txtFechaHoy.Text).Day;
           int horaD = Convert.ToDateTime(txtFechaD.Text).Hour;
            int horaH = Convert.ToDateTime(txtFechaHoy.Text).Hour;
            if (fechaD > fechaH && txtEstado.Text.Equals("Domicilio") || horaD > horaH && txtEstado.Text.Equals("Meson"))
            {

            actualizar.actualizarPrestamoLibroSinMora(int.Parse(txtIdprestamo.Text), txtTipo.Text, "Devuelto", txtFechaP.Text, txtFechaD.Text, int.Parse(txtUsuario.Text), int.Parse(txtLibro.Text));
                Session["regD"] = "si";
                Response.Redirect("loan.aspx");
            }
            
            else
            {
              WS_Agregar_Bec.AgregarClient add = new WS_Agregar_Bec.AgregarClient();
              int x =  add.insertarMulta("Moroso",3, 3);
               actualizar.actualizarPrestamoLibro(int.Parse(txtIdprestamo.Text), txtTipo.Text, txtEstado.Text, txtFechaP.Text, txtFechaD.Text, int.Parse(txtUsuario.Text), int.Parse(txtLibro.Text), x);
                Session["regM"] = "si";
                Response.Redirect("loan.aspx");
            }
        }

        protected void btnDevolverMultimedia_Click(object sender, EventArgs e)
        {
            WS_Actualizar_Bec.ActualizarClient actualizar = new WS_Actualizar_Bec.ActualizarClient();
            int fechaD = Convert.ToDateTime(txtFechaD.Text).Day;
            int fechaH = Convert.ToDateTime(txtFechaHoy.Text).Day;
            int horaD = Convert.ToDateTime(txtFechaD.Text).Hour;
            int horaH = Convert.ToDateTime(txtFechaHoy.Text).Hour;
            if (fechaD > fechaH && txtEstado.Text.Equals("Domicilio") || horaD > horaH && txtEstado.Text.Equals("Meson"))
            {

                actualizar.actualizarPrestamoMultimediaSinMora(int.Parse(txtIdprestamo.Text), txtTipo.Text, "Devuelto", txtFechaP.Text, txtFechaD.Text, int.Parse(txtUsuario.Text), int.Parse(txtLibro.Text));
                Session["regD"] = "si";
                Response.Redirect("loan.aspx");
            }

            else
            {
                WS_Agregar_Bec.AgregarClient add = new WS_Agregar_Bec.AgregarClient();
                int x = add.insertarMulta("Moroso", 3, 3);
                actualizar.actualizarPrestamoMultimedia(int.Parse(txtIdprestamo.Text), txtTipo.Text, txtEstado.Text, txtFechaP.Text, txtFechaD.Text, int.Parse(txtUsuario.Text), int.Parse(txtLibro.Text), x);
                Session["regM"] = "si";
                Response.Redirect("loan.aspx");
            }
        }

        public void Incorrect()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('No se ha encontrado el codigo', 'Presione ok para cerrar esta ventana', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void Multa()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('El libro entregado ha superado el tiempo del prestamo', 'Se ha generado una multa al usuario', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void Entregado()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Libro entregado dentro del plazo', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }

        public void Correct()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Codigo encontrado', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);

        }
    }
}