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
    public partial class Materias : System.Web.UI.Page
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
        private Materia Entity
        {
            get;
            set;
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
        private bool IsEntitySelected
        {
            get
            {
                return (this.SelectedID != 0);
            }
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

        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
        }

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
            LoadGrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.gridView.SelectedValue;
        }
        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                Session["idSeleccionada"] = SelectedID;
                Session["formMode"] = FormModes.Modificion;
                Page.Response.Redirect("~/MateriaForm.aspx");
            }
        }
        protected void EliminarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                DeleteEntity(SelectedID);
                LoadGrid();
            }
        }

        private void DeleteEntity(int id)
        {
            this.Logic.Delete(id);
        }
        protected void NuevoLinkButton_Click(object sender, EventArgs e)
        {
            Session["idSeleccionada"] = null;
            Session["formMode"] = FormModes.Alta;
            Page.Response.Redirect("~/MateriaForm.aspx");

        }

    }
}