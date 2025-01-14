﻿using Academia.Data.Database;
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
    public partial class CursoForm : System.Web.UI.Page
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
            if (!Page.IsPostBack)
            {
                CargarPlanes();
                if ((int)Session["idSeleccionado"] != -1) // Si el modo es editar, carga los datos del formulario
                {
                    CargarFormulario();
                }
            }
        }

        private void CargarPlanes()
        {
            ddlPlanes.DataSource = (new PlanLogic()).GetAll();
            ddlPlanes.DataBind();
            CargarMaterias();
            CargarComisiones();
        }

        private void CargarFormulario()
        {
            int idCurso = (int)Session["idSeleccionado"];
            Curso c = (new CursoLogic()).GetOne(idCurso);
            ddlPlanes.SelectedValue = (new PlanLogic()).GetByIdMateria(c.Materia.Id).Id.ToString();
            CargarMaterias();
            ddlMaterias.SelectedValue = c.Materia.Id.ToString();
            CargarComisiones();
            ddlComisiones.SelectedValue = c.Comision.Id.ToString(); 
            txtAño.Text = c.AñoCalendario.ToString();
            txtCupo.Text = c.Cupo.ToString();
        }

        protected void ddlPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarMaterias();
            EspecialidadLogic el = new EspecialidadLogic();
            Especialidad esp = el.GetByPlan(int.Parse(this.ddlPlanes.SelectedValue));
            lblEspecialidad.Text = esp.Descripcion;
        }

        protected void ddlMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComisiones();
        } 

        private void CargarMaterias()
        {
            int idPlan = int.Parse(ddlPlanes.SelectedValue);
            ddlMaterias.DataSource = (new MateriaLogic()).GetByPlan(idPlan);
            ddlMaterias.DataBind();
        }

        private void CargarComisiones()
        {
            int idPlan = int.Parse(ddlPlanes.SelectedValue);
            ddlComisiones.DataSource = (new ComisionLogic()).GetByPlan(idPlan);
            ddlComisiones.DataBind();
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            int idCurso = (int)Session["idSeleccionado"];
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                if (idCurso == -1) // Si es un nuevo curso
                {
                    cursos oCurso = new cursos
                    {
                        id_materia = int.Parse(ddlMaterias.SelectedValue),
                        id_comision = int.Parse(ddlComisiones.SelectedValue),
                        anio_calendario = int.Parse(txtAño.Text),
                        cupo = int.Parse(txtCupo.Text)
                    };
                    db.cursos.Add(oCurso);
                }
                else
                {
                    cursos oCurso = db.cursos.Find(idCurso);
                    oCurso.id_materia = int.Parse(ddlMaterias.SelectedValue);
                    oCurso.id_comision = int.Parse(ddlComisiones.SelectedValue);
                    oCurso.anio_calendario = int.Parse(txtAño.Text);
                    oCurso.cupo = int.Parse(txtCupo.Text);
                }
                db.SaveChanges();
            }
        }
    }
}