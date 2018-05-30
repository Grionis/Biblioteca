using BEC.WS_Listar_Bec;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC.scripts
{
    public partial class catalogoEstudiantes : System.Web.UI.Page
    {
      
    

        WS_Listar_Bec.ListarClient l = new ListarClient();

        protected void Page_Load(object sender, EventArgs e)
        {

            
           
            ListadoLibro();

            ListadoMultimedia();




        }



        protected void btnIniciar_Click(object sender, EventArgs e)
        {




            Response.Redirect("index.aspx");
        }

        protected void btnRegistrse_Click(object sender, EventArgs e)
        {
            Response.Redirect("Registro.aspx");
        }

        public void ListadoLibro()
        {
            
            DataTable tb = new DataTable();
            DataRow dr;

           


            try
            {
                var lib = l.listarLibro();
                var st = l.ListarStock();
                var est = l.listarEstante();

                if (lib != null)
                {


                    tb.Columns.Add("ISBN", typeof(string));
                    tb.Columns.Add("Codigo", typeof(string));
                    tb.Columns.Add("Autor", typeof(string));
                    tb.Columns.Add("Nombre", typeof(string));
                    tb.Columns.Add("Genero", typeof(string));
                    tb.Columns.Add("Fecha", typeof(string));
                    tb.Columns.Add("Piso", typeof(string));
                    tb.Columns.Add("Seccion", typeof(string));
                    tb.Columns.Add("Disponibilidad", typeof(string));

                    foreach (var libro in lib)
                    {
                        foreach (var stock in st)
                        {

                            foreach (var estante in est)
                            {

                                if (estante.idEstante == stock.idestante && stock.idStock == libro.idstock)
                                {
                                    dr = tb.NewRow();
                                    dr["ISBN"] = libro.isbn;
                                    dr["Codigo"] = libro.codigo;
                                    dr["Autor"] = libro.autor;
                                    dr["Nombre"] = libro.nombre;
                                    dr["Genero"] = libro.genero;
                                    dr["Fecha"] = libro.fecha;
                                    dr["Piso"] = estante.piso;
                                    dr["Seccion"] = estante.seccion;
                                    if (stock.activo >= 1)
                                    {
                                        dr["Disponibilidad"] = "Disponible";
                                    }
                                    else
                                    {
                                        dr["Disponibilidad"] = "No disponible";
                                    }
                                    tb.Rows.Add(dr);
                                }
                            }
                        }
                    }

                    gvLibros.DataSource = tb;
                    gvLibros.DataBind();
                    ViewState["table1"] = tb;

                }



            }
            catch (Exception)
            {

                Response.Redirect("ErrorPage.aspx");
            }

          
                
          

        }

        

        public void ListadoMultimedia()
        {
            DataTable tb = new DataTable();
            DataRow dr;

            var mul = l.listarMultimedia();
            var st = l.ListarStock();
            var est = l.listarEstante();
            if (mul != null)
            {


                tb.Columns.Add("Codigo", typeof(string));
                tb.Columns.Add("Tipo", typeof(string));
                tb.Columns.Add("Nombre", typeof(string));
                tb.Columns.Add("Autor", typeof(string));
                tb.Columns.Add("Fecha", typeof(string));
                tb.Columns.Add("Piso", typeof(string));
                tb.Columns.Add("Seccion", typeof(string));
                tb.Columns.Add("Disponibilidad", typeof(string));

                foreach (var multi in mul)
                {
                    foreach (var stock in st)
                    {

                        foreach (var estante in est)
                        {

                            if (estante.idEstante == stock.idestante && stock.idStock == multi.idstock)
                            {
                                dr = tb.NewRow();
                                dr["Codigo"] = multi.codigo;
                                dr["Tipo"] = multi.tipo;
                                dr["Nombre"] = multi.nombre;
                                dr["Autor"] = multi.autor;
                                dr["Fecha"] = multi.fecha;
                               
                                dr["Piso"] = estante.piso;
                                dr["Seccion"] = estante.seccion;
                                if (stock.activo >= 1)
                                {
                                    dr["Disponibilidad"] = "Disponible";
                                }
                                else
                                {
                                    dr["Disponibilidad"] = "No disponible";
                                }
                                tb.Rows.Add(dr);
                            }
                        }
                    }
                }

                gvMultimedia.DataSource = tb;
                gvMultimedia.DataBind();
                ViewState["table1"] = tb;

            }

        }

        protected void gvLibros_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void gvLibros_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
          

            gvMultimedia.PageIndex = e.NewPageIndex;
            ListadoMultimedia();
                
        }

        protected void gvLibros_PageIndexChanging1(object sender, GridViewPageEventArgs e)
        {
            gvLibros.PageIndex = e.NewPageIndex;
            ListadoLibro();
        }

        protected void gvLibros_Sorted(object sender, EventArgs e)
        {

        }

        protected void gvMultimedia_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gvMultimedia.PageIndex = e.NewPageIndex;
            ListadoLibro();
        }

        protected void gvLibros_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

        }
    }
}