using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BEC.ServiceAgregar;
using BEC.ServiceListar;
using BEC.ServicePrueba;

namespace BEC
{
    public partial class student : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //ServicePrueba.NewWebServiceClient list = new NewWebServiceClient();
            //cboUsuario.DataSource = list.listarFicha();
            //cboUsuario.DataBind();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceAgregar.AgregarClient agregar = new AgregarClient();
            try
            {
                int x = agregar.insertarFicha(txtRut.Text, txtNombre.Text, txtDIreccion.Text, txtEmail.Text, txtTelefono.Text, int.Parse(txtHuella.Text));
                //int x = agregar.insertarFicha(txtRut.Text, txtNombre.Text, txtDIreccion.Text, txtEmail.Text, txtTelefono.Text, int.Parse(txtHuella.Text));
                agregar.insertarUsuario(txtUSer.Text, txtPass1.Text, x);
                ServiceListar.usuario u = new ServiceListar.usuario();
            }
            catch (Exception E)
            {

                throw E;
            }
            
           
            
        }
    }
}