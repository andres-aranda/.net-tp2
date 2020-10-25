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
        protected void Page_Load(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            int idPersona = usuario.IdPersona;
            inscripcionesDocente.DataSource = cl.GetMateriasInscripcionesDocente(idPersona);
            inscripcionesDocente.DataBind();
        }
    }
}