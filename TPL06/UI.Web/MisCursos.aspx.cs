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
            int idPersona = usuario.IdPersona;
            inscripcionesAlu.DataSource = cl.GetMateriasInscripciones(idPersona);
            inscripcionesAlu.DataBind();
       
         
        }
    }
}