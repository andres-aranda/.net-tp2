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
    
        private void LoadForm(int id)
        {
            EspecialidadLogic el = new EspecialidadLogic();

            this.Entity = this.Logic.GetOne(id);
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            this.hsSemanalesTextBox.Text = this.Entity.HsSemanales.ToString();
            this.hsTotalesTextBox.Text = this.Entity.HsTotales.ToString();
            PlanesID.PlanSeleccionado = this.Entity.IdPlan;
        }

        protected void LoadEntity(Materia Matadd)
        {
            Matadd.Descripcion = this.descripcionTextBox.Text;
            Matadd.HsTotales = int.Parse(this.hsTotalesTextBox.Text);
            Matadd.HsSemanales = int.Parse(this.hsSemanalesTextBox.Text);
            Matadd.IdPlan = PlanesID.PlanSeleccionado;
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