using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace Academia.UI.Web
{
    public partial class ComisionForm : System.Web.UI.Page
    {
        #region Declaraciones 
        ComisionLogic Logic = new ComisionLogic();
        private Comision Entity
        {
            get;
            set;
        }

        public enum FormModes { Alta, Baja, Modificion }

        public FormModes FormMode
        {
            get
            {
                return (FormModes)this.ViewState["formMode"];
            }
            set
            {
                this.ViewState["formMode"] = value;
            }
        }
        #endregion

        #region Metodos y disparadores 
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.descComtxt.Text = this.Entity.DescripcionComision;
            this.cboIdPlan.SelectedValue = this.Entity.IdPlan.ToString();
            this.añoEspeTextBox.Text = this.Entity.AñoEspecialidad.ToString();

        }

        protected void LoadEntity(Comision comision)
        {
         
                comision.DescripcionComision = this.descComtxt.Text;
                comision.AñoEspecialidad = int.Parse(this.añoEspeTextBox.Text);
                comision.IdPlan = int.Parse(this.cboIdPlan.Text);
        
            
        }
        private void SaveEntity(Comision comision)
        {
            
                this.Logic.Save(comision);
         
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);

        }

        protected void AceptarLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.FormMode)
                {
                    case FormModes.Alta:
                        this.Entity = new Comision();
                        this.Entity.State = BusinessEntity.Estados.New;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        break;
                    case FormModes.Modificion:
                        this.Entity = new Comision();
                        this.Entity.Id = (int)Session["idSeleccionada"];
                        this.Entity.State = BusinessEntity.Estados.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        Page.Response.Redirect("~/Comisiones.aspx");
                        break;
                }
                MessageBox.Show("Datos guardados");
            }
            catch (Exception)
            {
                MessageBox.Show("Campos invalidos");
            }
        }

        protected void CancelarLinkButton_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Comisiones.aspx");
        }

        protected void cboIdPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            EspecialidadLogic el = new EspecialidadLogic();
            Especialidad esp = el.GetByPlan(int.Parse(this.cboIdPlan.SelectedValue));
            lblEspecialidad.Text = esp.Descripcion;

        }
        private void cargacombo()
        {

            PlanLogic pl = new PlanLogic();
            cboIdPlan.DataSource = pl.GetAll();
            cboIdPlan.DataBind();
            EspecialidadLogic el = new EspecialidadLogic();
            Especialidad esp = el.GetByPlan(int.Parse(this.cboIdPlan.SelectedValue));
            lblEspecialidad.Text = esp.Descripcion;

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
                if (!(m.Descripcion == "NoDocente" || m.Descripcion == "Administrador"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }

            if (usuarioLog == null) Page.Response.Redirect("~/Login.aspx");
            foreach (Modulo m in usuarioLog.Modulo)
            {
                if (!(m.Descripcion == "NoDocente" || m.Descripcion == "Administrador"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            if (!Page.IsPostBack)
            {
                cargacombo();
                if (Session["formMode"] != null)
                {

                    FormMode = (FormModes)Session["formMode"];
                    if (Session["idSeleccionada"] != null)
                        LoadForm((int)Session["idSeleccionada"]);
                }

            }
        }


    }
}