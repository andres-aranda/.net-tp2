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
    public partial class MateriaForm : System.Web.UI.Page
    {
        private MateriaLogic _logic;

        private MateriaLogic Logic
        {
            get
            {
                if (_logic == null)
                    _logic = new MateriaLogic();
                return _logic;
            }
        }
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

        protected void Page_Load(object sender, EventArgs e)
        {
           
                Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];

                foreach (Modulo m in usuarioLog.Modulo)
                {
                    if (!(m.Descripcion == "Alumno" || m.Descripcion == "Administrador"))
                        Page.Response.Redirect("~/PaginaNoPermitida.aspx");
                }

            
            if (Session["formMode"] != null)
            {
                if (Session["idSeleccionada"] != null)
                    LoadForm((int)Session["idSeleccionada"]);

                FormMode = (FormModes)Session["formMode"];
            }
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.descripcionTextBox.Text = this.Entity.Descripcion;
            this.hsSemanalesTextBox.Text = this.Entity.HsSemanales.ToString();
            this.hsTotalesTextBox.Text = this.Entity.HsTotales.ToString();
            this.idPlanTextBox.Text = this.Entity.IdPlan.ToString();
        }

        protected void LoadEntity(Materia usuario)
        {
            usuario.Descripcion = this.descripcionTextBox.Text;
            usuario.HsTotales = int.Parse(this.hsTotalesTextBox.Text);
            usuario.HsSemanales = int.Parse(this.hsSemanalesTextBox.Text);
            usuario.IdPlan = int.Parse(this.idPlanTextBox.Text);
        }
        private void SaveEntity(Materia usuario)
        {
            this.Logic.Save(usuario);
        }
        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }

        protected void AceptarLinkButton_Click(object sender, EventArgs e)
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
        }

        protected void CancelarLinkButton_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Materias.aspx");
        }
    }

     
    }