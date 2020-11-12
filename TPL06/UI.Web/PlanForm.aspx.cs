using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Academia.UI.Web
{
    public partial class PlanForm : System.Web.UI.Page
    {
        #region Disparadores 
        protected void AceptarLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.FormMode)
                {
                    case FormModes.Alta:
                        this.Entity = new Plan();
                        this.Entity.State = BusinessEntity.Estados.New;
                        this.LoadEntity(this.Entity);
                        this.SaveEntity(this.Entity);
                        break;
                    case FormModes.Modificion:
                        this.Entity = new Plan();
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
            Page.Response.Redirect("~/Planes.aspx");
        }
        #endregion

        #region Declaraciones
        private PlanLogic Logic = new PlanLogic();
        private Plan Entity
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
        protected void LoadEntity(Plan PlanAdd)
        {
            PlanAdd.Descripcion = this.descripcionTextBox.Text;
            PlanAdd.IdEspecialidad = int.Parse(this.cmbEspecialidad.SelectedValue);
        }
        private void SaveEntity(Plan plan)
        {
            this.Logic.Save(plan);
        }
        private void cargacombo()
        {
            EspecialidadLogic pl = new EspecialidadLogic();
            cmbEspecialidad.DataSource = pl.GetAll();
            cmbEspecialidad.DataBind();
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.descripcionTextBox.Text = this.Entity.Descripcion.ToString();
            this.cmbEspecialidad.SelectedValue = this.Entity.IdEspecialidad.ToString();
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