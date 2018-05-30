using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    public partial class home : System.Web.UI.Page
    {
        WS_Listar_Bec.ListarClient l = new WS_Listar_Bec.ListarClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["correcto"] != null)
            {
                logCorrect();
                Session["correcto"] = null;
            }

            if (Session["usuario"] == null)
            {
                Response.Redirect("index.aspx");

            }
            gvAdmin.Visible = false;
            ddlExportExcel.Items.Add("Seleccione el informe que desea exportar");
            ddlExportExcel.Items.Add("Bibliotecarios Administrativos");
            ddlExportExcel.Items.Add("Bibliotecario");
            ddlExportExcel.Items.Add("Usuario ");
            ddlExportExcel.Items.Add("Libro");
            ddlExportExcel.Items.Add("Multimedia");
            ddlExportExcel.Items.Add("Reservaciones");
            ddlExportExcel.Items.Add("Prestamos en meson");
            ddlExportExcel.Items.Add("Todos los prestamos");
            lblNick.Text = Convert.ToString(Session["usuario"]);

            MaxLibro();
            MaxAdmin();
            MaxUser();
            MaxBibliotecario();
            MaxMultimedia();
            MaxPendientes();
            MaxReservacionec();
            MaxPrestamos();
        }


        //Test


        public void ExportarExcel()
        {
            if (ddlExportExcel.SelectedIndex >= 1)
            {
                switch (ddlExportExcel.SelectedIndex)
                {
                    case 1:
                        ExportToExcel(GrillaAdmin(),"Informe de bibliotecarios administrativos");
                        break;
                    case 2:
                        ExportToExcel(GrillaBibliotecario(),"Informe de Biliotecario");
                        break;
                    case 3:
                        ExportToExcel(grillaUsuario(),"Informe de Usuarios");
                        break;
                    case 4:
                        ExportToExcel(grillaLibro(), "Informe de libros");
                        break;
                    case 5:
                        ExportToExcel(grillaMultimedia(),"Informe de Multimedia");
                        break;

                    case 6:
                        ExportToExcel(grillaReservacionLibro(),"informe de Reservaciones");
                        break;

                    case 7:
                        ExportToExcel(grillaMesonMultimedia(),"Informe de reservaciones en el meson");
                        break;

                    case 8:
                        ExportToExcel(GrillaTotalPrestamosLibro(),"Informe con todos los prestamos");
                        break;
                    default:
                        break;
                }

            }
            else
            {
                IncorrectChoice();
            }
        }
        public void ExportToExcel(DataTable dt, string nombre)
        {
            if (dt.Rows.Count > 0)
            {
                string filename = nombre + ".xls";
                System.IO.StringWriter tw = new System.IO.StringWriter();
                System.Web.UI.HtmlTextWriter hw = new System.Web.UI.HtmlTextWriter(tw);
                DataGrid dgGrid = new DataGrid();
                DataTable test = new DataTable();
                dgGrid.DataSource = dt;




                dgGrid.DataBind();


                dgGrid.RenderControl(hw);

                Response.ContentType = "application/vnd.ms-excel";
                Response.AppendHeader("Content-Disposition", "attachment; filename=" + filename + "");
                this.EnableViewState = false;
                Response.Write(tw.ToString());
                Response.End();
            }

        }


        #region Onclick Grilla
        protected void btnAdmin_Click(object sender, EventArgs e)
        {

            GrillaAdmin();
        }
        protected void Bibliotecario_Click(object sender, EventArgs e)
        {

            GrillaBibliotecario();
        }
        protected void Usuario_Click(object sender, EventArgs e)
        {

            grillaUsuario();
        }
        protected void Libro_Click(object sender, EventArgs e)
        {

            grillaLibro();
        }
        protected void Multimedia_Click(object sender, EventArgs e)
        {

            grillaMultimedia();
        }
        protected void Meson_Click(object sender, EventArgs e)
        {

            grillaMesonMultimedia();
            grillaMesonLibro();
        }



        protected void Reservaciones_Click(object sender, EventArgs e)
        {

            grillaReservacionLibro();
            grillaReservacionMultimedia();
        }

        protected void TotalPrestados_Click(object sender, EventArgs e)
        {

            GrillaTotalPrestamosLibro();
            GrillaTotalPrestamosMulti();
        }
        #endregion

        #region Grilla
        public DataTable GrillaAdmin()
        {



            DataTable tb = new DataTable();
            DataRow dr;
            var admin = l.listarUsuario();
            var ficha = l.listarFicha();
            var rol = l.listarRol();
            int c = 0;

            tb.Columns.Add("Usuario", typeof(string));
            tb.Columns.Add("Clave", typeof(string));
            tb.Columns.Add("Rut", typeof(string));
            tb.Columns.Add("Nombre completo", typeof(string));
            tb.Columns.Add("Direccion", typeof(string));
            tb.Columns.Add("Correo", typeof(string));
            tb.Columns.Add("Telefono", typeof(string));


            foreach (var a in admin)
            {
                foreach (var f in ficha)
                {
                    foreach (var r in rol)
                    {
                        if (a.idFicha == f.idFicha)
                        {
                            if (a.idRol == 3 && r.descripcion.Equals("Administrativo de Biblioteca"))
                            {
                                dr = tb.NewRow();
                                dr["Usuario"] = a.nombreUsuario;
                                dr["Clave"] = a.clave;
                                dr["Rut"] = f.rut;
                                dr["Nombre completo"] = f.nombres;
                                dr["Direccion"] = f.direccion;
                                dr["Correo"] = f.correo;
                                dr["Telefono"] = f.telefono;
                                tb.Rows.Add(dr);
                            }
                        }
                    }
                }
            }

            gvMesonLibro.Visible = false;
            gvMesonMultimedia.Visible = false;
            gvMultimedia.Visible = false;
            gvResMulti.Visible = false;
            gvResLibro.Visible = false;
            gvLibros.Visible = false;
            gvBibliotecario.Visible = false;
            gvUsuario.Visible = false;
            gvPrestamosLib.Visible = false;
            gvPrestamoMulti.Visible = false;

            gvAdmin.Visible = true;
            gvAdmin.DataSource = tb;
            gvAdmin.DataBind();
            ViewState["table1"] = tb;

            return tb;
        }

        public DataTable GrillaBibliotecario()
        {
            DataTable tb = new DataTable();
            DataRow dr;
            var admin = l.listarUsuario();
            var ficha = l.listarFicha();
            var rol = l.listarRol();
            int c = 0;

            tb.Columns.Add("Usuario", typeof(string));
            tb.Columns.Add("Clave", typeof(string));
            tb.Columns.Add("Rut", typeof(string));
            tb.Columns.Add("Nombre completo", typeof(string));
            tb.Columns.Add("Direccion", typeof(string));
            tb.Columns.Add("Correo", typeof(string));
            tb.Columns.Add("Telefono", typeof(string));


            foreach (var a in admin)
            {
                foreach (var f in ficha)
                {
                    foreach (var r in rol)
                    {
                        if (a.idFicha == f.idFicha)
                        {
                            if (a.idRol == 2 && r.descripcion.Equals("Bibliotecario"))
                            {
                                dr = tb.NewRow();
                                dr["Usuario"] = a.nombreUsuario;
                                dr["Clave"] = a.clave;
                                dr["Rut"] = f.rut;
                                dr["Nombre completo"] = f.nombres;
                                dr["Direccion"] = f.direccion;
                                dr["Correo"] = f.correo;
                                dr["Telefono"] = f.telefono;
                                tb.Rows.Add(dr);
                            }
                        }
                    }
                }
            }

            gvMesonLibro.Visible = false;
            gvMesonMultimedia.Visible = false;
            gvMultimedia.Visible = false;
            gvResMulti.Visible = false;
            gvResLibro.Visible = false;
            gvAdmin.Visible = false;
            gvLibros.Visible = false;
            gvUsuario.Visible = false;
            gvPrestamosLib.Visible = false;
            gvPrestamoMulti.Visible = false;

            gvBibliotecario.Visible = true;
            gvBibliotecario.DataSource = tb;
            gvBibliotecario.DataBind();
            ViewState["table1"] = tb;
            return tb;
        }

        public DataTable grillaUsuario()
        {
            DataTable tb = new DataTable();
            DataRow dr;
            var admin = l.listarUsuario();
            var ficha = l.listarFicha();
            var rol = l.listarRol();
            int c = 0;

            tb.Columns.Add("Usuario", typeof(string));
            tb.Columns.Add("Clave", typeof(string));
            tb.Columns.Add("Rut", typeof(string));
            tb.Columns.Add("Nombre completo", typeof(string));
            tb.Columns.Add("Direccion", typeof(string));
            tb.Columns.Add("Correo", typeof(string));
            tb.Columns.Add("Telefono", typeof(string));


            foreach (var a in admin)
            {
                foreach (var f in ficha)
                {
                    foreach (var r in rol)
                    {
                        if (a.idFicha == f.idFicha)
                        {
                            if (a.idRol == 1 && r.descripcion.Equals("Usuario"))
                            {
                                dr = tb.NewRow();
                                dr["Usuario"] = a.nombreUsuario;
                                dr["Clave"] = a.clave;
                                dr["Rut"] = f.rut;
                                dr["Nombre completo"] = f.nombres;
                                dr["Direccion"] = f.direccion;
                                dr["Correo"] = f.correo;
                                dr["Telefono"] = f.telefono;
                                tb.Rows.Add(dr);
                            }
                        }
                    }
                }
            }

            gvMesonLibro.Visible = false;
            gvMesonMultimedia.Visible = false;
            gvMultimedia.Visible = false;
            gvResMulti.Visible = false;
            gvResLibro.Visible = false;
            gvAdmin.Visible = false;
            gvBibliotecario.Visible = false;
            gvLibros.Visible = false;
            gvPrestamosLib.Visible = false;
            gvPrestamoMulti.Visible = false;

            gvUsuario.Visible = true;
            gvUsuario.DataSource = tb;
            gvUsuario.DataBind();
            ViewState["table1"] = tb;
            return tb;
        }


        public DataTable grillaLibro()
        {
            DataTable tb = new DataTable();
            DataRow dr;
            var libro = l.listarLibro();
            var stock = l.ListarStock();
            var estante = l.listarEstante();
            int c = 0;

            tb.Columns.Add("ISBN", typeof(string));
            tb.Columns.Add("Codigo", typeof(string));
            tb.Columns.Add("Titulo", typeof(string));
            tb.Columns.Add("Autor", typeof(string));
            tb.Columns.Add("Genero", typeof(string));
            tb.Columns.Add("Año", typeof(string));
            tb.Columns.Add("Cantidad disponible", typeof(string));
            tb.Columns.Add("Piso", typeof(string));
            tb.Columns.Add("Estante", typeof(string));

            foreach (var l in libro)
            {
                foreach (var s in stock)
                {
                    foreach (var e in estante)
                    {
                        if (l.idstock == s.idStock && s.idestante == e.idEstante)
                        {

                            dr = tb.NewRow();
                            dr["ISBN"] = l.isbn;
                            dr["Codigo"] = l.codigo;
                            dr["Titulo"] = l.nombre;
                            dr["Autor"] = l.autor;
                            dr["Genero"] = l.genero;
                            dr["Año"] = l.fecha;
                            dr["Cantidad disponible"] = s.activo;
                            dr["Piso"] = e.piso;
                            dr["Estante"] = e.seccion;
                            tb.Rows.Add(dr);

                        }
                    }
                }
            }

            gvMesonLibro.Visible = false;
            gvMesonMultimedia.Visible = false;
            gvMultimedia.Visible = false;
            gvResMulti.Visible = false;
            gvResLibro.Visible = false;
            gvAdmin.Visible = false;
            gvBibliotecario.Visible = false;
            gvUsuario.Visible = false;
            gvPrestamosLib.Visible = false;
            gvPrestamoMulti.Visible = false;


            gvLibros.Visible = true;
            gvLibros.DataSource = tb;
            gvLibros.DataBind();
            ViewState["table1"] = tb;
            return tb;
        }


        public DataTable grillaMultimedia()
        {
            DataTable tb = new DataTable();
            DataRow dr;
            var multimedia = l.listarMultimedia();
            var stock = l.ListarStock();
            var estante = l.listarEstante();
            int c = 0;

            tb.Columns.Add("Codigo", typeof(string));
            tb.Columns.Add("Nombre", typeof(string));
            tb.Columns.Add("Tipo", typeof(string));
            tb.Columns.Add("Autor", typeof(string));
            tb.Columns.Add("Año", typeof(string));
            tb.Columns.Add("Cantidad disponible", typeof(string));
            tb.Columns.Add("Piso", typeof(string));
            tb.Columns.Add("Estante", typeof(string));

            foreach (var m in multimedia)
            {
                foreach (var s in stock)
                {
                    foreach (var e in estante)
                    {
                        if (m.idstock == s.idStock && s.idestante == e.idEstante)
                        {

                            dr = tb.NewRow();
                            dr["Codigo"] = m.codigo;
                            dr["Nombre"] = m.nombre;
                            dr["Tipo"] = m.tipo;
                            dr["Autor"] = m.autor;
                            dr["Año"] = m.fecha;
                            dr["Cantidad disponible"] = s.activo;
                            dr["Piso"] = e.piso;
                            dr["Estante"] = e.seccion;
                            tb.Rows.Add(dr);

                        }
                    }
                }
            }

            gvMesonLibro.Visible = false;
            gvMesonMultimedia.Visible = false;
            gvLibros.Visible = false;
            gvResMulti.Visible = false;
            gvResLibro.Visible = false;
            gvAdmin.Visible = false;
            gvBibliotecario.Visible = false;
            gvUsuario.Visible = false;
            gvPrestamosLib.Visible = false;
            gvPrestamoMulti.Visible = false;

            gvMultimedia.Visible = true;
            gvMultimedia.DataSource = tb;
            gvMultimedia.DataBind();
            ViewState["table1"] = tb;

            return tb;
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

            gvMesonLibro.Visible = false;
            gvMesonMultimedia.Visible = false;
            gvMultimedia.Visible = false;
            gvResMulti.Visible = false;
            gvResLibro.Visible = false;
            gvAdmin.Visible = false;
            gvBibliotecario.Visible = false;
            gvUsuario.Visible = false;
            gvLibros.Visible = false;

            
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

            gvMesonLibro.Visible = false;
            gvMesonMultimedia.Visible = false;
            gvMultimedia.Visible = false;
            gvResMulti.Visible = false;
            gvResLibro.Visible = false;
            gvAdmin.Visible = false;
            gvBibliotecario.Visible = false;
            gvUsuario.Visible = false;
            gvLibros.Visible = false;


            gvPrestamoMulti.Visible = true;
            gvPrestamosLib.Visible = true;
            gvPrestamoMulti.DataSource = tb;
            gvPrestamoMulti.DataBind();
            ViewState["table2"] = tb;
            return tb;
        }

        public DataTable grillaMesonMultimedia()
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


                            if (u.idFicha == f.idFicha && p.idUsuario == u.idUsuario && m.idMultimedia == p.idMultimedia && p.estado.Equals("Meson"))
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

            gvPrestamoMulti.Visible = false;
            gvPrestamosLib.Visible = false;
           
            gvMultimedia.Visible = false;
            gvResLibro.Visible = false;
            gvResMulti.Visible = false;
            gvAdmin.Visible = false;
            gvBibliotecario.Visible = false;
            gvUsuario.Visible = false;
            gvLibros.Visible = false;


            gvMesonLibro.Visible = true;
            gvMesonMultimedia.Visible = true;
            gvMesonMultimedia.DataSource = tb;
            gvMesonMultimedia.DataBind();
            ViewState["table2"] = tb;
            return tb;
        
    }

        public DataTable grillaMesonLibro()
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


                            if (u.idFicha == f.idFicha && p.idUsuario == u.idUsuario && l.idLibro == p.idLibro && p.estado.Equals("Meson"))
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

            
            gvMultimedia.Visible = false;
            gvResMulti.Visible = false;
            gvResLibro.Visible = false;
            gvAdmin.Visible = false;
            gvBibliotecario.Visible = false;
            gvUsuario.Visible = false;
            gvLibros.Visible = false;
            gvPrestamoMulti.Visible = false;
            gvPrestamosLib.Visible = false;

            gvMesonLibro.Visible = true;
          
            gvMesonMultimedia.Visible = true;
            gvMesonLibro.DataSource = tb;
            gvMesonLibro.DataBind();
            ViewState["table2"] = tb;
            return tb;

        }

        public DataTable grillaReservacionLibro()
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


                            if (u.idFicha == f.idFicha && p.idUsuario == u.idUsuario && l.idLibro == p.idLibro && p.estado.Equals("Reservado"))
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

            gvPrestamoMulti.Visible = false;
            gvPrestamosLib.Visible = false;

            gvMultimedia.Visible = false;
            gvMesonLibro.Visible = false;
            gvMesonMultimedia.Visible = false;
            gvAdmin.Visible = false;
            gvBibliotecario.Visible = false;
            gvUsuario.Visible = false;
            gvLibros.Visible = false;


            gvResMulti.Visible = true;
            gvResLibro.Visible = true;
            gvResLibro.DataSource = tb;
            gvResLibro.DataBind();
            ViewState["table2"] = tb;
            return tb;

        }
        public DataTable grillaReservacionMultimedia()
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


                            if (u.idFicha == f.idFicha && p.idUsuario == u.idUsuario && m.idMultimedia == p.idMultimedia && p.estado.Equals("Reservado"))
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

            gvPrestamoMulti.Visible = false;
            gvPrestamosLib.Visible = false;

            gvMultimedia.Visible = false;
            gvMesonLibro.Visible = false;
            gvMesonMultimedia.Visible = false;
            gvAdmin.Visible = false;
            gvBibliotecario.Visible = false;
            gvUsuario.Visible = false;
            gvLibros.Visible = false;


            gvResMulti.Visible = true;
            gvResLibro.Visible = true;
            gvResMulti.DataSource = tb;
            gvResMulti.DataBind();
            ViewState["table2"] = tb;
            return tb;

        }

        #endregion

        #region Listado DB
        public void MaxLibro()
        {

            var libro = l.listarLibro();
            var stock = l.ListarStock();
            int total = 0;
            int c = 0;
            foreach (var li in libro)
            {

                foreach (var s in stock)
                {
                    if (li.idstock == s.idStock)
                    {
                        total += s.total;
                        c++;
                    }
                }

            }
            lblLibros.InnerText = c.ToString();
        }

        public void MaxAdmin()
        {
            var admin = l.listarUsuario();
            var ficha = l.listarFicha();
            var rol = l.listarRol();
            int c = 0;

            foreach (var a in admin)
            {
                foreach (var f in ficha)
                {
                    foreach (var r in rol)
                    {
                        if (a.idFicha == f.idFicha)
                        {
                            if (a.idRol == 3 && r.descripcion.Equals("Administrativo de Biblioteca"))
                            {
                                c++;
                            }
                        }
                    }
                }
            }

            lblAdmin.InnerText = c.ToString();

        }

        public void MaxUser()
        {
            var admin = l.listarUsuario();
            var ficha = l.listarFicha();
            var rol = l.listarRol();
            int c = 0;

            foreach (var a in admin)
            {
                foreach (var f in ficha)
                {
                    foreach (var r in rol)
                    {
                        if (a.idFicha == f.idFicha)
                        {
                            if (a.idRol == 1 && r.descripcion.Equals("Usuario"))
                            {
                                c++;
                            }
                        }
                    }
                }
            }

            lblUser.InnerText = c.ToString();
        }

        public void MaxBibliotecario()
        {
            var admin = l.listarUsuario();
            var ficha = l.listarFicha();
            var rol = l.listarRol();
            int c = 0;

            foreach (var a in admin)
            {
                foreach (var f in ficha)
                {
                    foreach (var r in rol)
                    {
                        if (a.idFicha == f.idFicha)
                        {
                            if (a.idRol == 2 && r.descripcion.Equals("Bibliotecario"))
                            {
                                c++;
                            }
                        }
                    }
                }
            }

            lblBibliotecario.InnerText = c.ToString();
        }

        public void MaxMultimedia()
        {
            var multimedia = l.listarMultimedia();
            var stock = l.ListarStock();
            int total = 0;
            int c = 0;
            foreach (var mu in multimedia)
            {

                foreach (var s in stock)
                {
                    if (mu.idstock == s.idStock)
                    {
                        total += s.total;
                        c++;
                    }
                }

            }
            lblMultimedia.InnerText = c.ToString();
        }

        public void MaxReservacionec()
        {
            var prest = l.ListarPrestamo();
            var stock = l.ListarStock();
            int total = 0;
            int c = 0;
            foreach (var pr in prest)
            {

                //foreach (var s in stock)
                //{
                if (pr.estado.Equals("Reservado"))
                {
                    //total += s.total;
                    c++;
                }
                //}

            }
            lblReservaciones.InnerText = c.ToString();
        }

        public void MaxPendientes()
        {
            var prest = l.ListarPrestamo();
            var stock = l.ListarStock();

            int c = 0;
            foreach (var pr in prest)
            {

                //foreach (var s in stock)
                //{
                if (pr.estado.Equals("Meson"))
                {
                    //total += s.total;
                    c++;
                }
                //}

            }
            lblPendiente.InnerText = c.ToString();
        }

        public void MaxPrestamos()
        {
            var prest = l.ListarPrestamo();
            var stock = l.ListarStock();

            int c = 0;
            foreach (var pr in prest)
            {

                //foreach (var s in stock)
                //{
                //if (!pr.estado.Equals("Devuelto"))
                //{
                //total += s.total;
                c++;
                //}
                //}

            }
            lblPrestamos.InnerText = c.ToString();
        }

        #endregion



        protected void gvLibros_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
         

        }

        protected void gvLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void gvLibros_Sorted(object sender, EventArgs e)
        {

        }

        public bool logCorrect()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Usuario logueado correctamente', 'Presione ok para cerrar esta ventana', 'success');";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }

        public bool IncorrectChoice()
        {
            ClientScriptManager cs = Page.ClientScript;

            String csname1 = "alert";

            Type cstype = this.GetType();



            String cstext1 = "swal('Debe Seleccionar una categoria para descargar un informe', 'Si el problema persiste, favor de comunicarse con el area de informatica', 'success');";
            cs.RegisterStartupScript(cstype, csname1, cstext1, true);
            return true;
        }

        protected void Export_Click(object sender, EventArgs e)
        {
            ExportarExcel();
        }

        protected void gvAdmin_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvAdmin.PageIndex = e.NewPageIndex;
            GrillaAdmin();
        }

        protected void gvBibliotecario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvBibliotecario.PageIndex = e.NewPageIndex;
            GrillaBibliotecario();
        }

        protected void gvUsuario_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvUsuario.PageIndex = e.NewPageIndex;
            grillaUsuario();
        }

        protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvLibros.PageIndex = e.NewPageIndex;
            grillaLibro();
        }

        protected void gvMultimedia_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMultimedia.PageIndex = e.NewPageIndex;
            grillaMultimedia();
        }

        protected void gvReservaciones_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
           

        }

        protected void gvMeson_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            
        }

        protected void gvPrestamos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            //gvPrestamosLib.PageIndex = e.NewPageIndex;
            //GrillaTotalPrestamos();
        }

        protected void edia_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {

        }

        protected void gvPrestamosLib_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPrestamosLib.PageIndex = e.NewPageIndex;
        }

        protected void gvPrestamoMulti_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvPrestamoMulti.PageIndex = e.NewPageIndex;

        }

        protected void gvMesonLibro_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
                gvMesonLibro.PageIndex = e.NewPageIndex;
                grillaMesonLibro();
        }

        protected void gvMesonMultimedia_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMesonMultimedia.PageIndex = e.NewPageIndex;
            grillaMesonMultimedia();
        }

        protected void gvResLibro_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvResLibro.PageIndex = e.NewPageIndex;
            grillaReservacionLibro();
        }

        protected void gvResMulti_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvResMulti.PageIndex = e.NewPageIndex;
            grillaReservacionMultimedia();
        }
    }
}