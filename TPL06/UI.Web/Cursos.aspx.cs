using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;

// TODO: Estilo de tabla BRAIAN
// TODO: Botones ABM BRAIAN

namespace Academia.UI.Web
{
    public partial class Cursos : System.Web.UI.Page
    {
        CursoLogic cl = new CursoLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvCursos.DataSource = cl.GetAll();
            dgvCursos.DataBind();
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

        }
    }
}