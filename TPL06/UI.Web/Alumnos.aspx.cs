using Academia.Data.Database;
using Academia.Util;
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
        private int idIncripcion;
        CursoLogic cl;

        public int IdIncripcion { get => idIncripcion; set => idIncripcion = value; }
        List<string> condiciones = new List<string>()
        {
            "Cursando",
            "Regular",
            "Aprobada",
            "Libre"
        };
        protected void Page_Load(object sender, EventArgs e)
        {
           
            cl = new CursoLogic();
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            if (usuario == null)
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
            if (!IsPostBack)
            {
                ZonaEdicion.Visible = false;
                cmbCondicion.DataSource = condiciones;
                cmbCondicion.DataBind();


            }

        }

        protected void inscripcionesDocente_SelectedIndexChanged(object sender, EventArgs e)
        {
            ZonaEdicion.Visible = true;
            IdIncripcion = (int)inscripcionesDocente.SelectedValue;
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validations.IsValidNota(int.Parse(txtNota.Text), (string)cmbCondicion.SelectedValue))
                {
                    using (EntidadesTP2 db = new EntidadesTP2())
                    {
                        alumnos_inscripciones aluInsc = db.alumnos_inscripciones.Find((int)inscripcionesDocente.SelectedValue);
                        aluInsc.nota = int.Parse(txtNota.Text);
                        aluInsc.condicion = (string)cmbCondicion.SelectedValue;
                        db.SaveChanges();
                        MessageBox.Show("Nota Cambiada con éxito");
                    }
                    Usuario usuario = (Usuario)Session["usuarioLogueado"];
                    List<Inscripcion> ls = cl.GetMateriasInscripcionesDocente(usuario.Persona.Id);
                    inscripcionesDocente.DataSource = ls;
                    inscripcionesDocente.DataBind();
                    IdIncripcion = 0;
                    if (inscripcionesDocente == null)
                    {
                        MessageBox.Show("No posee inscripciones de alumnos");
                    }
                    ZonaEdicion.Visible = false;
                }
                else
                {
                    MessageBox.Show("La nota no es acorde a la condicion");
                }
            }
            catch
            {
                MessageBox.Show("Ingrese la nota de forma numerica");
            }
        }

        protected void txtNota_TextChanged(object sender, EventArgs e)
        {

        }
    }
}