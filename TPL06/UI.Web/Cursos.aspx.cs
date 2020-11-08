using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;

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
    }
}