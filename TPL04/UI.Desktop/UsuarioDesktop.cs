using Business.Logic;
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
using System.Drawing.Text;

namespace Academia.UI.Desktop
{
    public partial class UsuarioDesktop : ApplicationForm
    {
        public ModoForm modo;
        public Usuario UsuarioActual { get; set; }
        public UsuarioDesktop()
        {
        
        }
                                             
        public UsuarioDesktop(ModoForm modo):this()
        {
           modo = ModoForm.Alta;
        }
        public UsuarioDesktop(int ID, ModoForm mdo) : this()
        {
            modo = mdo;
            UsuarioLogic usu = new UsuarioLogic(); 
            usu.GetOne(ID);
            MapearDeDatos();

        }
          public override void MapearDeDatos() 
          {
            this.txtID.Text = this.UsuarioActual.Id.ToString();
            this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
            this.txtNombre.Text = this.UsuarioActual.Nombre;
            this.txtApellido.Text = this.UsuarioActual.Apellido;
            this.txtEmail.Text = this.UsuarioActual.Email;
            this.txtUsuario.Text = this.UsuarioActual.NombreUsuario;
            this.txtClave.Text = this.UsuarioActual.Clave;
            this.txtConfirmarClave.Text = this.UsuarioActual.Clave;

            if (modo == ModoForm.Alta || modo == ModoForm.Modificacion)
            {
                this.btnAceptar.Text = "Guardar";
               /* if (modo == ModoForm.Alta)
                {
                    Usuario usuarionNuevo = new Usuario();
                    UsuarioActual = usuarionNuevo;
                    this.txtID.Enabled = false;
                    this.lblID.Enabled = false;
                }
        //        this.txtID.Text = this.UsuarioActual.Id.ToString();
                this.chkHabilitado.Checked = this.UsuarioActual.Habilitado;
                this.txtNombre.Text = this.UsuarioActual.Nombre;
*/
            }
             else if (modo == ModoForm.Baja)
            {
                this.btnAceptar.Text = "Eliminar";

            }
            else if (modo == ModoForm.Consulta)
            {
                this.btnAceptar.Text = "Aceptar";

            }
          }
          public override  void MapearADatos() 
          {
            if(modo == ModoForm.Alta)
            {
                this.UsuarioActual = new Usuario();
                this.txtID.Enabled = false;
                this.lblID.Enabled = false;
                this.UsuarioActual.State = BusinessEntity.Estados.New;
            }
            else if (modo == ModoForm.Modificacion)
            {
                this.UsuarioActual.State = BusinessEntity.Estados.Modified;
            }
            else if (modo == ModoForm.Alta || modo == ModoForm.Modificacion)
            {
                this.UsuarioActual.Habilitado = this.chkHabilitado.Checked;
                this.UsuarioActual.Nombre = this.txtNombre.Text;
                this.UsuarioActual.Apellido = this.txtApellido.Text;
                this.UsuarioActual.Email = this.txtEmail.Text;
                this.UsuarioActual.NombreUsuario = this.txtUsuario.Text;
                this.UsuarioActual.Clave = this.txtClave.Text;
                this.UsuarioActual.Clave = this.txtConfirmarClave.Text;
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
            bool esValido = true;
            string mensaje = "";

            if (this.txtNombre.Text == "" | this.txtApellido.Text == "" | this.txtEmail.Text == "" | this.txtUsuario.Text == "" | this.txtClave.Text == "" | this.txtConfirmarClave.Text == "")
            {
                mensaje = "Faltan datos.";
                esValido = false;
            }
            else if (this.txtClave.Text != this.txtConfirmarClave.Text)
            {
                mensaje = "Claves no coinciden.";
                esValido = false;
            }
            else if (this.txtClave.Text.Length < 8)
            {
                mensaje = "La clave debe tener al menos 8 caracteres.";
                esValido = false;
            }
            else if (!(ValidaCorreo(this.txtEmail.Text)))
            {
                mensaje = "Mail invalido.";
                esValido = false;
            }

            if (!esValido)
            {
                Notificar(mensaje, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return esValido;
        }
        private bool ValidaCorreo(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }


    }
}
