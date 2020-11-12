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
    public partial class Planes1 : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PlanLogic pl = new PlanLogic();
   cmbPlanes.DataSource = pl.GetAll();
            cmbPlanes.DataBind();
                labelCarga();
            }
         
        }
        public bool SoloLectura
        {
            set => cmbPlanes.Enabled = value;
        }

        public int  PlanSeleccionado
        {
            get => int.Parse(cmbPlanes.SelectedValue); 
            set => cmbPlanes.SelectedValue = value.ToString();
        }
        protected void cmbPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelCarga();
        }

        private void labelCarga()
        {
            EspecialidadLogic el = new EspecialidadLogic();
            Especialidad esp = el.GetByPlan(int.Parse(this.cmbPlanes.SelectedValue));
            lblplan.Text = esp.Descripcion;
        }
    }
}