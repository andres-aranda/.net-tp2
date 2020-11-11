using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Academia.Data.Database;
using Business.Entities;
using Business.Logic;

namespace Academia.UI.Web
{
    public partial class Especialidades : System.Web.UI.Page
    {
        EspecialidadLogic el = new EspecialidadLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvEspecialidades.DataSource = el.GetAll();
            dgvEspecialidades.DataBind();
            dgvEspecialidades.Columns[0].Visible = false;
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["idSeleccionado"] = -1;
            Page.Response.Redirect("~/EspecialidadForm.aspx");
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Session["idSeleccionado"] = (int)dgvEspecialidades.SelectedValue;
            Page.Response.Redirect("~/EspecialidadForm.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            int idEspecialidad = (int)dgvEspecialidades.SelectedValue;
            try
            {
                (new EspecialidadLogic()).Delete(idEspecialidad);
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                Response.Write("<script>alert('Hubo un error.')</script>");
            }
        }
    }
}