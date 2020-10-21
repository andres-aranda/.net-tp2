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
        MateriaLogic _logic;
        private MateriaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new MateriaLogic();
                }
                return _logic;
            }
        }
        PersonaLogic _logicPer;
        private PersonaLogic LogicPer
        {
            get
            {
                if (_logicPer == null)
                {
                    _logicPer = new PersonaLogic();
                }
                return _logicPer;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
        Usuario usuario = (Usuario)Session["usuarioLogueado"];
        int idPersona = usuario.IdPersona;
        Persona per = LogicPer.GetOne(idPersona);
       buscarMaterias(per.IdPlan);
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
       
    
    private void buscarMaterias(int idPlan)
    {
        this.cmbMateria.DataSource = Logic.GetByPlan(idPlan);
        this.cmbMateria.DataBind();
    }
}
}