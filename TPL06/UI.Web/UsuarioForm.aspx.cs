using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Business.Logic;
using Business.Entities;
using System.Windows.Forms;
using Academia.Util;


namespace Academia.UI.Web
{
    public partial class UsuarioForm : System.Web.UI.Page
    {
        UsuarioLogic _logic;
        List<Persona> personas;
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
            Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];
            personas = (new PersonaLogic()).GetAll();

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

            if (FormMode == FormModes.Alta)
            {
                txtLegajo.Enabled = true;
            }

        }

        private void LoadForm(int id)
        {
            this.Entity = this.Logic.GetOne(id);
            this.nombreTextBox.Text = this.Entity.Persona.Nombre;
            this.apellidoTextBox.Text = this.Entity.Persona.Apellido;
            this.emailTextBox.Text = this.Entity.Persona.Email.ToString();
            this.nombreUsuarioTextBox.Text = this.Entity.NombreUsuario;
            this.claveTextBox.Text = this.Entity.Clave;
            this.txtLegajo.Text = Entity.Persona.Legajo.ToString();
        }

        protected void LoadEntity(Usuario usuario)
        {
            usuario.Persona = new Persona();
            //usuario.Persona.Nombre = this.nombreTextBox.Text;
            //usuario.Persona.Apellido = this.apellidoTextBox.Text;
            //usuario.Persona.Email = new System.Net.Mail.MailAddress(emailTextBox.Text);
            usuario.Persona.Legajo = int.Parse(txtLegajo.Text);
            usuario.NombreUsuario = this.nombreUsuarioTextBox.Text;
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

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validations.IsClaveValida(repetirClaveTextBox.Text, claveTextBox.Text))
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
                    MessageBox.Show("Datos guardados");
                }
                else
                    MessageBox.Show("Las claves no coinciden");
            }
            catch (FormatException)
            {
                MessageBox.Show("Campos inválidos.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Page.Response.Redirect("~/Usuarios.aspx");
        }
    }
}