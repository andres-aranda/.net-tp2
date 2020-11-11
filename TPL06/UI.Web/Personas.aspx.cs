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
    public partial class Personas : System.Web.UI.Page
    {
        PersonaLogic pl = new PersonaLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            dgvPersonas.DataSource = pl.GetAll();
            dgvPersonas.DataBind();
        }

        protected void btnEditar_Click(object sender, EventArgs e)
        {
            Session["idSeleccionado"] = dgvPersonas.SelectedValue;
            Page.Response.Redirect("~/MiInformacion.aspx");
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            pl.Delete((int)dgvPersonas.SelectedValue);
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            Session["idSeleccionado"] = -1;
            Page.Response.Redirect("~/MiInformacion.aspx");
        }
    }
}