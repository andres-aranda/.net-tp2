using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Academia.UI.Web
{
    public partial class MateriaForm : System.Web.UI.Page
    {
        #region Declaraciones
        private MateriaLogic Logic = new MateriaLogic();

        private Materia Entity
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

        #region Metodos 
        private void cargacombo()
        {

            PlanLogic pl = new PlanLogic();
            cboIdPlan.DataSource = pl.GetAll();
            cboIdPlan.DataBind();
            EspecialidadLogic el = new EspecialidadLogic();
            Especialidad esp = el.GetByPlan(int.Parse(this.cboIdPlan.SelectedValue));
            lblEspecialidad.Text = esp.Descripcion;

        }
        private void LoadForm(int id)
        {
            EspecialidadLogic el = new EspecialidadLogic();

            this.Entity = this.Logic.GetOne(id);
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            this.hsSemanalesTextBox.Text = this.Entity.HsSemanales.ToString();
            this.hsTotalesTextBox.Text = this.Entity.HsTotales.ToString();
            this.cboIdPlan.SelectedValue = this.Entity.IdPlan.ToString();
        }

        protected void LoadEntity(Materia Matadd)
        {
            Matadd.Descripcion = this.descripcionTextBox.Text;
            Matadd.HsTotales = int.Parse(this.hsTotalesTextBox.Text);
            Matadd.HsSemanales = int.Parse(this.hsSemanalesTextBox.Text);
            Matadd.IdPlan = int.Parse(this.cboIdPlan.SelectedValue);
        }
        private void SaveEntity(Materia usuario)
        {
            this.Logic.Save(usuario);
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        #endregion

        #region Disparadores
        protected void AceptarLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.FormMode)
                {
                    case FormModes.Alta:
                        this.Entity = new Materia();
                        this.Entity.State = BusinessEntity.Estados.New;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        break;
                    case FormModes.Modificion:
                        this.Entity = new Materia();
                        this.Entity.Id = (int)Session["idSeleccionada"];
                        this.Entity.State = BusinessEntity.Estados.Modified;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
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
            Page.Response.Redirect("~/Materias.aspx");
        }

        protected void cboIdPlan_SelectedIndexChanged(object sender, EventArgs e)
        {
            EspecialidadLogic el = new EspecialidadLogic();
            Especialidad esp = el.GetByPlan(int.Parse(this.cboIdPlan.SelectedValue));
            lblEspecialidad.Text = esp.Descripcion;
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

            Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];

            foreach (Modulo m in usuarioLog.Modulo)
            {
                if (!(m.Descripcion == "NoDocente" || m.Descripcion == "Administrador"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            if (!IsPostBack)
            {
                cargacombo();

                if (Session["formMode"] != null)
                {
                    if (Session["idSeleccionada"] != null)
                        LoadForm((int)Session["idSeleccionada"]);

                    FormMode = (FormModes)Session["formMode"];
                }
            }


        }



    }


}