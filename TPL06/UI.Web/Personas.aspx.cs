using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
// TODO: Editar, eliminar, nuevo BRAIAN

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

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            Session["idSeleccionado"] = dgvPersonas.SelectedValue;
            Page.Response.Redirect("~/MiInformacion.aspx");
        }

        protected void EliminarLinkButton_Click(object sender, EventArgs e)
        {
            pl.Delete((int)dgvPersonas.SelectedValue);
        }

        protected void NuevoLinkButton_Click(object sender, EventArgs e)
        {
            Session["idSeleccionado"] = -1;
            Page.Response.Redirect("~/MiInformacion.aspx");
        }
    }
}