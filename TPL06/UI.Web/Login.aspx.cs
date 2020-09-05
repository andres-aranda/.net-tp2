using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace Academia.UI.Web
{
    public partial class Login : System.Web.UI.Page
    {
        Usuario _usuarioLogeado;
        UsuarioLogic ul = new UsuarioLogic();
        public Usuario UsuarioLogeado
        {
            get { return _usuarioLogeado; }
            set { _usuarioLogeado = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            UsuarioLogeado = ul.Loguearse(txtUsuario.Text, txtContraseña.Text);
            if (UsuarioLogeado != null)
            {
                Session["usuarioLogueado"] = UsuarioLogeado;
                Page.Response.Redirect("~/Home.aspx");
            }
        }
    }
}