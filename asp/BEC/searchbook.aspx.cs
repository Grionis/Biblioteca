using BEC.WS_Listar_Bec;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace BEC
{
    

    public partial class searchbook : System.Web.UI.Page
    {
        WS_Listar_Bec.ListarClient l = new ListarClient();
        
        protected void Page_Load(object sender, EventArgs e)
        {
            BusquedaLibro();
            BusquedaMultimedia();

        }

        public void BusquedaLibro()
        {
            string text = Convert.ToString(Request.QueryString["bookName"]);
            int c;
            DataTable tb = new DataTable();
            DataRow dr;
       
              var item = l.ListarLibroPorNombre(text);

            
            if (item != null)
            {
                c = 0;
                gvLibro.Visible = true;
                lblAlert.Visible = false;
                gvMultimedia.Visible = false;
                
                tb.Columns.Add("ISBN", typeof(string));
                tb.Columns.Add("Codigo", typeof(string));
                tb.Columns.Add("Autor", typeof(string));
                tb.Columns.Add("Nombre", typeof(string));
                tb.Columns.Add("Genero", typeof(string));
                tb.Columns.Add("Fecha", typeof(string));
                tb.Columns.Add("Estado", typeof(string));
                tb.Columns.Add("Prestados", typeof(string));
                tb.Columns.Add("Esperar", typeof(string));
                foreach (var items in item)
                {
                    dr = tb.NewRow();
                    dr["ISBN"] = items.isbn;
                    dr["Codigo"] = items.codigo;
                    dr["Autor"] = items.autor;
                    dr["Nombre"] = items.nombre;
                    dr["Genero"] = items.genero;
                    dr["Fecha"] = items.fecha;
                    dr["Esperar"] = items.idLibro;


                    //gvLibro.Rows[c].Cells.Equals("Accion").Value = items.idLibro;



                    if (l.StockMayor(items.idstock))
                        {
                            dr["Estado"] = "Disponible";
                            dr["Prestados"] = l.Prestados(items.idstock);
                        }
                        else
                        {
                            dr["Estado"] = "No Disponible";
                            dr["Prestados"] = l.Prestados(items.idstock);

                        }   


                    tb.Rows.Add(dr);
                    c++;

                }
                gvLibro.DataSource = tb;
                gvLibro.DataBind();
                ViewState["table1"] = tb;

            }
            else
            {
                lblAlert.Visible = true;
            }


        }

        public void BusquedaMultimedia()
        {
            DataTable tb = new DataTable();
            DataRow dr;
            string text = Convert.ToString(Request.QueryString["bookName"]);
           
            var mul = l.ListarMultimediaPorNombre(text);

            if (mul != null)
            {
                gvLibro.Visible = false;
                lblAlert.Visible = false;
                gvMultimedia.Visible = true;

                tb.Columns.Add("Codigo", typeof(string));
                tb.Columns.Add("Autor", typeof(string));
                tb.Columns.Add("Año", typeof(string));
                tb.Columns.Add("Titulo", typeof(string));
                tb.Columns.Add("Tipo", typeof(string));
                tb.Columns.Add("Estado", typeof(string));
                tb.Columns.Add("Prestados", typeof(string));



                foreach (var items in mul)
                {
                    dr = tb.NewRow();
                    dr["Codigo"] = items.codigo;
                    dr["Autor"] = items.autor;
                    dr["Año"] = items.fecha;
                    dr["Titulo"] = items.nombre;
                    dr["Tipo"] = items.tipo;
                    dr["Esperar"] = items.idMultimedia;
                    if (l.StockMayor(items.idstock))
                    {
                        dr["Estado"] = "Disponible";
                        dr["Prestados"] = l.Prestados(items.idstock);
                    }
                    else
                    {
                        dr["Estado"] = "No Disponible";
                        dr["Prestados"] = l.Prestados(items.idstock);

                    }

                    tb.Rows.Add(dr);

                }

                gvMultimedia.DataSource = tb;
                gvMultimedia.DataBind();
                ViewState["table2"] = tb;
            }
        }

        protected void gvLibro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void gvLibro_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Esperar"))
                {
                lblAlert.Visible = true;
               Label l = (Label)gvLibro.FooterRow.FindControl("Esperar");
                lblAlert.Text = l.Text;
                }
            
        }

        protected void gvLibro_SelectedIndexChanged1(object sender, EventArgs e)
        {

        }

        protected void btnVolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("catalogoEstudiantes.aspx");
        }
    }
}