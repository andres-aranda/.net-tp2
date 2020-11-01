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
    public partial class Materias_disponibles : System.Web.UI.Page
    {


        #region Datos
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
            
        private int SelectedID
        {
            get
            {
                if (this.ViewState["SelectedID"] != null)
                {
                    return (int)this.ViewState["SelectedID"];
                }
                else
                {
                    return 0;
                }
            }
            set
            {
                this.ViewState["SelectedID"] = value;
            }
        }
        #endregion
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];
            if (usuarioLog == null)
            {
                Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            foreach (Modulo m in usuarioLog.Modulo)
            {
                if (!(m.Descripcion == "NoDocente" || m.Descripcion == "Administrador" || m.Descripcion == "Alumno"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            int idPersona = usuario.Persona.Id;
            Persona per = LogicPer.GetOne(idPersona);
            LoadGrid(per.IdPlan);
        }
        private void LoadGrid(int IdPlan)
        {
            this.gridView.DataSource = Logic.GetByPlan(IdPlan);
            this.gridView.DataBind();
        }

    }
}