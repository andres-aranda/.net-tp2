using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.Web
{
    public partial class MisCursosDocente : System.Web.UI.Page
    {
        CursoLogic cl = new CursoLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];
            if (usuarioLog == null)
            {
                Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            foreach (Modulo m in usuarioLog.Modulo)
            {
                if (!(m.Descripcion == "Docente" || m.Descripcion == "Administrador"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
           
            
            }
            
            cursosDocenteGV.DataSource = cl.GetCursosDocente(usuarioLog.Persona.Id);
            cursosDocenteGV.DataBind();
        }
    }
}