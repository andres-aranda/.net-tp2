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
        Usuario usuario;
        List<Usuario> usuarios = new List<Usuario>();
        UsuarioLogic ul = new UsuarioLogic();
        public Login()
        {
            InitializeComponent();
            usuarios = ul.GetAll();
        }

        private void lnkRegistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            UsuarioDesktop registrar = new UsuarioDesktop();
            registrar.ShowDialog();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            usuario = ul.Loguearse(txtUsuario.Text, txtPassword.Text);
            if (usuario != null)
            {
                Main main = new Main(usuario);
                this.Visible = false;
                main.ShowDialog();
            }
            else
                MessageBox.Show("Usuario incorrecto", "Usuario incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
