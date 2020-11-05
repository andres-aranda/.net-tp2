using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace Academia.UI.Web
{
    public partial class ComisionForm : System.Web.UI.Page
    {
            ComisionLogic _logic;
            private ComisionLogic Logic
            {
                get
                {
                    if (_logic == null)
                        _logic = new ComisionLogic();
                    return _logic;
                }
            }
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

            protected void Page_Load(object sender, EventArgs e)
            {
                //   int variable = (int)Session["idSeleccionado"];
           if (Page.IsPostBack)
            {
                 if (Session["formMode"] != null)
                {
                    FormMode = (FormModes)Session["formMode"];
                    if (Session["idSeleccionada"] != null)
                        LoadForm((int)Session["idSeleccionada"]);
                }

            }
            }
           

            private void LoadForm(int id)
            {
                this.Entity = this.Logic.GetOne(id);
                this.descComtxt.Text = this.Entity.DescripcionComision;
                this.idPlanTextBox.Text = this.Entity.IdPlan.ToString();
                this.añoEspeTextBox.Text = this.Entity.AñoEspecialidad.ToString();

            }

            protected void LoadEntity(Comision comision)
            {
                comision.DescripcionComision = this.descComtxt.Text;
                comision.AñoEspecialidad = int.Parse(this.añoEspeTextBox.Text);
                comision.IdPlan = int.Parse(this.idPlanTextBox.Text);
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
            }

            protected void CancelarLinkButton_Click(object sender, EventArgs e)
            {
                Page.Response.Redirect("~/Comisiones.aspx");
            }
        
    }
}