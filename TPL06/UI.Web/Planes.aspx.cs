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
    public partial class Planes : System.Web.UI.Page
    {
        #region Declaraciones 
      PlanLogic Logic = new PlanLogic();
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

        #region Metodos 
        private void LoadGrid()
        { 
         dgvPlanes.DataSource = Logic.GetAll();

            dgvPlanes.DataBind();
        }
        private void DeleteEntity(int id)
        {
            try
            {

                if (MessageBox.Show("¿Desea eliminar la plan?", "Eliminar plan", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Logic.Delete(id);
                    MessageBox.Show("La materia fue furrada conexito");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la plan. Verifique que no esté siendo usado.");
            }
        }
        #endregion

        #region Disparadores 
        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                Session["idSeleccionada"] = SelectedID;
                Session["formMode"] = FormModes.Modificion;
                Page.Response.Redirect("~/PlanForm.aspx");
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
            Page.Response.Redirect("~/PlanForm.aspx");

        }

        protected void dgvPlanes_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.dgvPlanes.SelectedValue;
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