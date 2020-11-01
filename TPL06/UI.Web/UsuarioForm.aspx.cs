using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;

namespace Academia.UI.Web
{
    public partial class UsuarioForm : System.Web.UI.Page
    {
        UsuarioLogic _logic;
        private UsuarioLogic Logic
        {
            get
            {
                if (_logic == null)
                    _logic = new UsuarioLogic();
                return _logic;
            }
        }
        private Usuario Entity
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
                if (Session["formMode"] != null)
                {
                    FormMode = (FormModes)Session["formMode"];
                    if (Session["idSeleccionada"] != null)
                        LoadForm((int)Session["idSeleccionada"]);
                }
           
        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.nombreTextBox.Text = this.Entity.Persona.Nombre;
            this.apellidoTextBox.Text = this.Entity.Persona.Apellido;
            this.emailTextBox.Text = this.Entity.Persona.Email.ToString();
            this.habilitadoCheckBox.Checked = this.Entity.Habilitado;
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;
            this.claveTextBox.Text = this.Entity.Clave;
        }

        protected void LoadEntity(Usuario usuario)
        {
            usuario.Persona.Nombre = this.nombreTextBox.Text;
            usuario.Persona.Apellido = this.apellidoTextBox.Text;
            usuario.Persona.Email = new System.Net.Mail.MailAddress(emailTextBox.Text);
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
            usuario.Habilitado = this.habilitadoCheckBox.Checked;
            usuario.Clave = this.claveTextBox.Text;
        }
        private void SaveEntity(Usuario usuario)
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
                    this.Entity = new Usuario();
                    this.Entity.State = BusinessEntity.Estados.New;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    break;
                case FormModes.Modificion:
                    this.Entity = new Usuario();
                    this.Entity.Id = (int)Session["idSeleccionada"];
                    this.Entity.State = BusinessEntity.Estados.Modified;
                    this.LoadEntity(this.Entity);
                    this.SaveEntity(this.Entity);
                    break;
            }
        }

        protected void CancelarLinkButton_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Usuarios.aspx");
        }
    }
}