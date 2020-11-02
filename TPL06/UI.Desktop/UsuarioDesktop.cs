using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
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
            PersonaLogic personaLogic = new PersonaLogic();
            UsuarioActual = usuarioLogic.GetOne(ID);
            UsuarioActual.Persona = personaLogic.GetOne(UsuarioActual.Persona.Id);

            this.modoForm = modo;

            txtLegajo.Enabled = false;

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
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;
            txtLegajo.Text = UsuarioActual.Persona.Legajo.ToString();

            switch (this.modoForm)
            {
                case ModoForm.Alta | ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
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
                    UsuarioActual = new Usuario();
                    UsuarioActual.Id = 0;
                    UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                    UsuarioActual.Clave = this.txtConfirmarClave.Text;
                    UsuarioActual.Persona = new Persona
                    {
                        Legajo = int.Parse(txtLegajo.Text)
                    };

                    this.UsuarioActual.State = BusinessEntity.Estados.New;
                    break;

                case ModoForm.Modificacion:
                    this.UsuarioActual.NombreUsuario = this.txtUsuario.Text; 
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
            if (this.txtNombre.Text == "" || this.txtApellido.Text == "" || this.txtUsuario.Text == "" || this.txtClave.Text == "" || this.txtConfirmarClave.Text == "")
            {
                Notificar("Debe llenar todos los campos.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (this.txtClave.Text != this.txtConfirmarClave.Text)
            {
                Notificar("Las claves deben ser iguales.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else if (this.txtClave.Text.Length < 8)
            {
                Notificar("La clave debe tener al menos 8 caracteres.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
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

        private void txtLegajo_TextChanged(object sender, EventArgs e)
        {
            PersonaLogic pl = new PersonaLogic();
            Persona p = new Persona();
            try
            {
                p = pl.GetByLegajo(int.Parse(txtLegajo.Text));
            }
            catch (Exception) { }
            txtApellido.Text = p.Apellido;
            txtNombre.Text = p.Nombre;
        }
    }
}