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
    public partial class report : System.Web.UI.Page
    {
        WS_Listar_Bec.ListarClient l = new ListarClient();
        protected void Page_Load(object sender, EventArgs e)
        {
            PrestamoDomicilio();
            PrestamoSala();
            lblNick.Text = Convert.ToString(Session["usuario"]);
        }



        public void PrestamoDomicilio()
        {
            DataTable tb = new DataTable();
            DataRow dr;

            WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();

            var item = list.PrestamoMayor();


            if (item != null)
            {

                tb.Columns.Add("Tipo", typeof(string));
                tb.Columns.Add("Estado", typeof(string));
                tb.Columns.Add("Fecha del prestamo", typeof(string));
                tb.Columns.Add("Fecha de devolucion", typeof(string));


                foreach (var items in item)
                {



                    dr = tb.NewRow();


                    dr["Tipo"] = items.tipo;
                    dr["Estado"] = items.estado;
                    dr["Fecha del prestamo"] = items.fechaPrestamo;
                    dr["Fecha de devolucion"] = items.fechaDevolucion;


                    tb.Rows.Add(dr);

                }


                gvPrestamoDomicilio.DataSource = tb;
                gvPrestamoDomicilio.DataBind();
                ViewState["table1"] = tb;
            }
        
    }


        public void PrestamoSala()
        {
            DataTable tb = new DataTable();
            DataRow dr;

            WS_Listar_Bec.ListarClient list = new WS_Listar_Bec.ListarClient();

            var item = list.PrestamoPendiente();


            if (item != null)
            {

                tb.Columns.Add("Tipo", typeof(string));
                tb.Columns.Add("Estado", typeof(string));
                tb.Columns.Add("Fecha del prestamo", typeof(string));
                tb.Columns.Add("Fecha de devolucion", typeof(string));


                foreach (var items in item)
                {



                    dr = tb.NewRow();


                    dr["Tipo"] = items.tipo;
                    dr["Estado"] = items.estado;
                    dr["Fecha del prestamo"] = items.fechaPrestamo;
                    dr["Fecha de devolucion"] = items.fechaDevolucion;


                    tb.Rows.Add(dr);

                }


                gvPrestamoSala.DataSource = tb;
                gvPrestamoSala.DataBind();
                ViewState["table1"] = tb;
            }
        
    }
    }
}