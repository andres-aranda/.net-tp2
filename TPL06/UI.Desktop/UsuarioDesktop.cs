using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;
using Academia.Util;

namespace Academia.UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public Usuario UsuarioActual { get; set; }


        public UsuarioDesktop()
        {
            InitializeComponent();
        }

        public UsuarioDesktop(ModoForm modo) : this()
        {
            this.modoForm = modo;

            this.SetFormName(modo);
        }

        public UsuarioDesktop(int ID, ModoForm modo) : this()
        {
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            UsuarioActual = usuarioLogic.GetOne(ID);

            this.modoForm = modo;

            this.MapearDeDatos();

            this.SetFormName(modo);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public override void MapearDeDatos()
        {
            this.txtId.Text = this.UsuarioActual.Id.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;

            switch (this.modoForm)
            {
                case ModoForm.Alta | ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;

                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }

        }

        public override void MapearADatos()
        {
            switch (this.modoForm)
            {
                case ModoForm.Alta:
                    this.UsuarioActual = new Usuario();
                    this.UsuarioActual.Id = 0;
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.Nombre = this.txtNombre.Text;
                    this.UsuarioActual.Apellido = this.txtApellido.Text;
                    this.UsuarioActual.Email = this.txtEmail.Text;
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.Clave = this.txtClave.Text;
                    this.UsuarioActual.Clave = this.txtConfirmarClave.Text;

                    this.UsuarioActual.State = BusinessEntity.Estados.New;
                    break;

                case ModoForm.Modificacion:
                    this.UsuarioActual.Id = int.Parse(this.txtId.Text.ToString());
                    this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                    this.UsuarioActual.Nombre = this.txtNombre.Text;
                    this.UsuarioActual.Apellido = this.txtApellido.Text;
                    this.UsuarioActual.Email = this.txtEmail.Text;
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    this.UsuarioActual.Clave = this.txtClave.Text;
                    this.UsuarioActual.Clave = this.txtConfirmarClave.Text;

                    this.UsuarioActual.State = BusinessEntity.Estados.Modified;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
            UsuarioLogic usuarioLogic = new UsuarioLogic();
            usuarioLogic.Save(UsuarioActual);
        }

        public override bool Validar()
        {
            bool retorno = true;
            string mensaje = "";

            if (this.txtNombre.Text == "" | this.txtApellido.Text == "" | this.txtEmail.Text == "" | this.txtUsuario.Text == "" | this.txtClave.Text == "" | this.txtConfirmarClave.Text == "")
            {
                mensaje = "Debe llenar todos los campos.";
                retorno = false;
            }
            else if (this.txtClave.Text != this.txtConfirmarClave.Text)
            {
                mensaje = "Las claves deben ser iguales.";
                retorno = false;
            }
            else if (this.txtClave.Text.Length < 8)
            {
                mensaje = "La clave debe tener al menos 8 caracteres.";
                retorno = false;
            }
            else if (!(Validations.IsValidEmail(this.txtEmail.Text)))
            {
                mensaje = "Debe ingresar un email valido.";
                retorno = false;
            }

            if (!retorno)
            {
                Notificar(mensaje, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return retorno;
        }

        private void SetFormName(ModoForm modo)
        {
            switch (modo)
            {
                case ModoForm.Alta:
                    this.Text = "Crear Usuario";
                    break;
                case ModoForm.Baja:
                    this.Text = "Borrar Usuario";
                    break;
                case ModoForm.Consulta:
                    this.Text = "Consultar Usuario";
                    break;
                case ModoForm.Modificacion:
                    this.Text = "Modificar Usuario";
                    break;
            }
        }

      
    }
}