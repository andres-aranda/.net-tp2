﻿using Business.Entities;
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
    public partial class Comisiones : System.Web.UI.Page
    {
        ComisionLogic _logic;
        private ComisionLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new ComisionLogic();
                }
                return _logic;
            }
        }
        private Comision Entity
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
            this.dgvComisiones.DataSource = this.Logic.GetAll();
            this.dgvComisiones.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            if (usuario == null)
            {
                Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            foreach (Modulo m in usuario.Modulo)
            {
                if (!(m.Descripcion == "NoDocente" || m.Descripcion == "Administrador"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            LoadGrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID = (int)this.dgvComisiones.SelectedValue;
        }
        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                Session["idSeleccionada"] = SelectedID;
                Session["formMode"] = FormModes.Modificion;
                Page.Response.Redirect("~/ComisionForm.aspx");
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
            try
            {

                if (MessageBox.Show("¿Desea eliminar la Comision?", "Eliminar materia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    this.Logic.Delete(id);
                    MessageBox.Show("La materia fue furrada conexito");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la Comision. Verifique que no esté siendo usada.");
            }
        }
        protected void NuevoLinkButton_Click(object sender, EventArgs e)
        {
            Session["idSeleccionada"] = null;
            Session["formMode"] = FormModes.Alta;
            Page.Response.Redirect("~/ComisionForm.aspx");


        }
    }
}