using Academia.Data.Database;
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
      public int IdIncripcion;
        CursoLogic cl;
        // TODO: Agregar funcionalidad de poner nota MARCO

        protected void Page_Load(object sender, EventArgs e)
        {
            ZonaEdicion.Visible = false;
            cl = new CursoLogic();
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

       

        protected void inscripcionesDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZonaEdicion.Visible = true;
           IdIncripcion = (int)inscripcionesDocente.SelectedValue;

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try {  
           using (EntidadesTP2 db = new EntidadesTP2())
                {
                    alumnos_inscripciones  aluInsc = db.alumnos_inscripciones.Find(IdIncripcion);
                    aluInsc.nota = int.Parse(txtNota.Text);
                    db.SaveChanges();
                    MessageBox.Show("Nota Cambiada con éxito");
                }
                Usuario usuario = (Usuario)Session["usuarioLogueado"];
                List<Inscripcion> ls = cl.GetMateriasInscripcionesDocente(usuario.Id);
                inscripcionesDocente.DataSource = ls;
                inscripcionesDocente.DataBind();
                if (inscripcionesDocente == null)
                {
                    MessageBox.Show("No posee inscripciones de alumnos");
                }
            } 
            catch 
            {
            }
        }
    }
}