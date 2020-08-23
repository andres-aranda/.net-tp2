using System;
using System.Collections.Generic;
using System.Drawing.Design;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Entities;
using Business.Logic;

namespace Academia.UI.Web
{
    public partial class Usuarios : System.Web.UI.Page
    {
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new UsuarioLogic();
                }
                return _logic;
            }
        }
        private Usuario Entity
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
            LoadGrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.SelectedID=(int)this.gridView.SelectedValue;
        }
        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.nombreTextBox.Text = this.Entity.Nombre;
            this.apellidoTextBox.Text = this.Entity.Apellido;
            this.emailTextBox.Text = this.Entity.Email;
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;
        }

        protected void editarLinkButton_Click(object sender, EventArgs e)
        {
            if (this.IsEntitySelected)
            {
                this.formPanel.Visible = true;
                this.FormMode = FormModes.Modificion;
                this.LoadForm(this.SelectedID);
            }
        }
        protected void LoadEntity(Usuario usuario)
        {
            usuario.Nombre = this.nombreTextBox.Text;
            usuario.Apellido = this.apellidoTextBox.Text;
            usuario.Email = this.emailTextBox.Text;
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
        }
        private void SaveEntity(Usuario usuario)
        {
            this.Logic.Save(usuario);
        }

        protected void AceptarLinkButton_Click(object sender, EventArgs e)
        {
            this.Entity = new Usuario();
            this.Entity.Id = this.SelectedID;
            this.Entity.State = BusinessEntity.Estados.Modified;
            this.LoadEntity(this.Entity);
            this.SaveEntity(this.Entity);
            this.LoadGrid();

            this.formPanel.Visible = false;
        }
    }
}