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
        protected void Page_Load(object sender, EventArgs e)
        {
            PersonaLogic pl = new PersonaLogic();
            dgvPersonas.DataSource = pl.GetAll();
            dgvPersonas.DataBind();
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {

        }

        protected void EliminarLinkButton_Click(object sender, EventArgs e)
        {

        }

        protected void NuevoLinkButton_Click(object sender, EventArgs e)
        {

        }
    }
}