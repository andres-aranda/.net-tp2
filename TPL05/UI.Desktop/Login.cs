using Business.Entities;
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

namespace Academia.UI.Desktop
{
    public partial class Login : Form
    {
        Usuario _usuarioLogeado;
        UsuarioLogic ul = new UsuarioLogic();
        public Usuario UsuarioLogeado
        {
            get { return _usuarioLogeado; }
            set { _usuarioLogeado = value; }
        }
        public Login()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsuarioDesktop registrar = new UsuarioDesktop();
            registrar.ShowDialog();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            this.UsuarioLogeado = ul.Loguearse(txtUsuario.Text, txtPassword.Text);
            if (this.UsuarioLogeado != null)
            {
                this.DialogResult = DialogResult.OK;
            }
            else
                MessageBox.Show("Usuario incorrecto", "Usuario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}
