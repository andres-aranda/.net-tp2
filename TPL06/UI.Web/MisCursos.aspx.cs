using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;
using Academia.Data.Database;



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
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                var inscripciones = from pe in db.personas
                                    join alu_ins in db.alumnos_inscripciones on pe.id_persona equals alu_ins.id_alumno
                                    join cur in db.cursos on alu_ins.id_curso equals cur.id_curso
                                    join mat in db.materias on cur.id_materia equals mat.id_materia
                                    join com in db.comisiones on cur.id_comision equals com.id_comision
                                    where alu_ins.id_alumno == idPersona
                                    select new { Materia = mat.desc_materia, Comision = com.desc_comision, Nota = alu_ins.nota, Año = cur.anio_calendario };

                inscripcionesAlu.DataSource = inscripciones.ToList();
                inscripcionesAlu.DataBind();
            }


          
       
         
        }
    }
}