using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace Academia.UI.Web
{
    public partial class MisCursos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            if (usuario == null)
            {
                Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            foreach (Modulo m in usuario.Modulo)
            {
                if (!(m.Descripcion == "Alumno" || m.Descripcion == "Administrador"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            int idPersona = usuario.Persona.Id;
            inscripcionesAlu.DataSource = cl.GetMateriasInscripciones(idPersona);
            inscripcionesAlu.DataBind();
       
         
        }
    }
}