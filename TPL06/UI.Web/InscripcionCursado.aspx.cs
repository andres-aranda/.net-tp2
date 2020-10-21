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
    public partial class InscripcionCursado : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private List<Comision> buscarComisiones(int idMateria){
            ComisionLogic comLog = new ComisionLogic();
            return comLog.GetByMateria(idMateria);
            }
        protected void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateria = int.Parse(cmbMateria.SelectedValue);
            cmbComision.DataSource = buscarComisiones(idMateria);
            cmbComision.DataBind();
        }
    }
}