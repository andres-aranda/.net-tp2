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
    public partial class Materias : System.Web.UI.Page
    {
        #region Declaraciones
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

        #endregion

        #region Disparadores
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


        protected void NuevoLinkButton_Click(object sender, EventArgs e)
        {
            Session["idSeleccionada"] = null;
            Session["formMode"] = FormModes.Alta;
            Page.Response.Redirect("~/MateriaForm.aspx");

        }

        #endregion

        #region Metodos 
        private void DeleteEntity(int id)
        {
            try
            {

                if (MessageBox.Show("¿Desea eliminar la materia?", "Eliminar materia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Logic.Delete(id);
                    MessageBox.Show("La materia fue furrada conexito");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la materia. Verifique que no esté siendo usada.");
            }
        }
        private void LoadGrid()
        {
            this.gridView.DataSource = this.Logic.GetAll();
            this.gridView.DataBind();
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
            LoadGrid();
        }


    }
}