using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Academia.UI.Web
{
    public partial class Alumnos : System.Web.UI.Page
    {

        // TODO: Agregar funcionalidad de poner nota MARCO

        protected void Page_Load(object sender, EventArgs e)
        {
            CursoLogic cl = new CursoLogic();
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            if (usuario== null)
            {
                Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            foreach (Modulo m in usuario.Modulo)
            {
                if (!(m.Descripcion == "Docente" || m.Descripcion == "Administrador"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            int idPersona = usuario.Persona.Id;

            List<Inscripcion> ls = cl.GetMateriasInscripcionesDocente(idPersona);
            inscripcionesDocente.DataSource = ls;
            inscripcionesDocente.DataBind();
            if (inscripcionesDocente == null)
            {
                MessageBox.Show("No posee inscripciones de alumnos");
            }
        }

        protected void NuevoLinkButton_Click(object sender, EventArgs e)
        {

        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

        }

        protected void EliminarLinkButton_Click(object sender, EventArgs e)
        {

        }
    }
}