using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;

// TODO: Estilo de tabla ANDRES
// TODO: Botones ABM ANDRES

namespace Academia.UI.Web
{
    public partial class Planes : System.Web.UI.Page
    {
        PlanLogic pl = new PlanLogic();
        protected void Page_Load(object sender, EventArgs e)
        {
            dgvPlanes.DataSource = pl.GetAll();
            dgvPlanes.DataBind();
        }
    }
}