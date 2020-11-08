using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
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
        }
    }
}