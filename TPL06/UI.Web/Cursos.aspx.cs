﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia.Data.Database;
using Business.Logic;
using Business.Entities;

namespace Academia.UI.Web
{
    public partial class Cursos : System.Web.UI.Page
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
            dgvCursos.Columns[0].Visible = false;
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                var cursos = from cur in db.cursos
                             join mat in db.materias on cur.id_materia equals mat.id_materia
                             join com in db.comisiones on cur.id_comision equals com.id_comision
                             select new
                             {
                                 Id = cur.id_curso,
                                 Materia = mat.desc_materia,
                                 Comision = com.desc_comision,
                                 Año = cur.anio_calendario,
                                 Cupo = cur.cupo
                             };
                dgvCursos.DataSource = cursos.ToList();
                dgvCursos.DataBind();
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["idSeleccionado"] = -1; // Indica que es un nuevo curso
            Page.Response.Redirect("~/CursoForm.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Session["idSeleccionado"] = (int)dgvCursos.SelectedValue;
            Page.Response.Redirect("~/CursoForm.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
           
            try
            { int idCurso = (int)dgvCursos.SelectedValue;
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    cursos oCurso = db.cursos.Find(idCurso);
                    db.cursos.Remove(oCurso);
                    db.SaveChanges();
                }
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                Response.Write("<script>alert('Hubo un error.')</script>");
            }
        }
    }
}