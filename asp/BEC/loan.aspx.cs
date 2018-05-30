using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEC.WS_Listar_Bec;
using System.Data;

namespace BEC
{
    public partial class loan : System.Web.UI.Page
    {
        WS_Listar_Bec.ListarClient l = new ListarClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["usuario"] == null)
            {
                Response.Redirect("index.aspx");

            }
            else
            {
                lblNick.Text = Convert.ToString(Session["usuario"]);
                GrillaTotalPrestamosLibro();
                GrillaTotalPrestamosMulti();

            }
            if(Session["regP"] != null)
            {
                Correct();
            }
            if(Session["regD"] != null)
            {
                Entregado();
            }
            if(Session["regM"] != null)
            {
                Multa();
            }
            if(Session["regR"] != null)
            {
                CorrectReservation();
            }
          

        }





        private DataTable GrillaTotalPrestamosLibro()
        {
            DataTable tb = new DataTable();
            DataRow dr;
            var prestamo = l.ListarPrestamo();
            var ficha = l.listarFicha();
            var usuario = l.listarUsuario();
            var libro = l.listarLibro();
            var multimedia = l.listarMultimedia();

            int c = 0;

            tb.Columns.Add("Tipo prestamo", typeof(string));
            tb.Columns.Add("Codigo", typeof(string));
            tb.Columns.Add("Titulo", typeof(string));
            tb.Columns.Add("Autor", typeof(string));
            tb.Columns.Add("Fecha inicial", typeof(string));
            tb.Columns.Add("Fecha Termino", typeof(string));
            tb.Columns.Add("Usuario", typeof(string));


            tb.Columns.Add("Estado", typeof(string));


            foreach (var p in prestamo)
            {
                foreach (var u in usuario)
                {
                    foreach (var f in ficha)
                    {
                        foreach (var l in libro)
                        {

                            if (u.idFicha == f.idFicha && p.idUsuario == u.idUsuario && p.idLibro == l.idLibro)
                            {
                                dr = tb.NewRow();
                                dr["Tipo Prestamo"] = p.tipo;
                                dr["Titulo"] = l.nombre;
                                dr["Autor"] = l.autor;
                                dr["Fecha inicial"] = p.fechaPrestamo;
                                dr["Fecha Termino"] = p.fechaDevolucion;
                                dr["Usuario"] = u.nombreUsuario;
                                dr["Codigo"] = l.codigo;
                                dr["Estado"] = p.estado;

                                tb.Rows.Add(dr);


                            }



                        }
                    }
                }
            }

            


            gvPrestamoMulti.Visible = true;
            gvPrestamosLib.Visible = true;
            gvPrestamosLib.DataSource = tb;
            gvPrestamosLib.DataBind();
            ViewState["table1"] = tb;
            return tb;
        }

        private DataTable GrillaTotalPrestamosMulti()
        {
            DataTable tb = new DataTable();
            DataRow dr;
            var prestamo = l.ListarPrestamo();
            var ficha = l.listarFicha();
            var usuario = l.listarUsuario();
            var libro = l.listarLibro();
            var multimedia = l.listarMultimedia();

            int c = 0;

            tb.Columns.Add("Tipo prestamo", typeof(string));
            tb.Columns.Add("Codigo", typeof(string));
            tb.Columns.Add("Titulo", typeof(string));
            tb.Columns.Add("Autor", typeof(string));
            tb.Columns.Add("Fecha inicial", typeof(string));
            tb.Columns.Add("Fecha Termino", typeof(string));
            tb.Columns.Add("Usuario", typeof(string));


            tb.Columns.Add("Estado", typeof(string));


            foreach (var p in prestamo)
            {
                foreach (var u in usuario)
                {
                    foreach (var f in ficha)
                    {

                        foreach (var m in multimedia)
                        {


                            if (u.idFicha == f.idFicha && p.idUsuario == u.idUsuario && m.idMultimedia == p.idMultimedia)
                            {

                                dr = tb.NewRow();
                                dr["Tipo Prestamo"] = p.tipo;
                                dr["Titulo"] = m.nombre;
                                dr["Autor"] = m.autor;
                                dr["Fecha inicial"] = p.fechaPrestamo;
                                dr["Fecha Termino"] = p.fechaDevolucion;
                                dr["Usuario"] = u.nombreUsuario;
                                dr["Codigo"] = m.codigo;
                                dr["Estado"] = p.estado;

                                tb.Rows.Add(dr);



                            }



                        }
                    }
                }
            }

         


            gvPrestamoMulti.Visible = true;
            gvPrestamosLib.Visible = true;
            gvPrestamoMulti.DataSource = tb;
            gvPrestamoMulti.DataBind();
            ViewState["table2"] = tb;
            return tb;
        }

        protected void gvPrestamos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
          

        }
        protected void gvLibros_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        protected void gvLibros_Sorted(object sender, EventArgs e)
        {

        }

        protected void gvPrestamosLib_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPrestamosLib.PageIndex = e.NewPageIndex;
            GrillaTotalPrestamosLibro();
        }

        protected void gvPrestamoMulti_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvPrestamoMulti_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            gvPrestamoMulti.PageIndex = e.NewPageIndex;
            GrillaTotalPrestamosMulti();
        }

        public void Correct()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Prestamo agregado correctamente', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            Session["regP"] = null;
        }

        public void Entregado()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Prestamo entregado dentro del plazo', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            Session["regD"] = null;

        }

        public void Multa()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('El prestamo entregado ha superado el tiempo del prestamo', 'Se ha generado una multa al usuario', 'error'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            Session["regM"] = null;

        }

        public void CorrectReservation()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Prestamo reservado correctamente', 'Presione ok para cerrar esta ventana', 'success'); wait(1000);";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            Session["regR"] = null;

        }
    }
}