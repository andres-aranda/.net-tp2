using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;

namespace Academia.UI.Web
{
    public partial class IngresoLegajoForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            if (usuario == null)
            {
                Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            foreach (Modulo m in usuario.Modulo)
            {
                if (!(m.Descripcion == "NoDocente" || m.Descripcion == "Administrador"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int legajo = int.Parse(txtLegajo.Text);
            Session["docente"] = (new PersonaLogic()).GetByLegajo(legajo);
            Page.Response.Redirect("~/MisCursosDocente.aspx");
        }
    }
}