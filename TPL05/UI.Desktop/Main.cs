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

namespace Academia.UI.Desktop
{
    public partial class Main : Form
    {
        Usuario usuario;
        public Main(Usuario usuarioLogueado)
        {
            usuario = usuarioLogueado;
            InitializeComponent();
        }
        private Form formularioActual;

        private void AbrirFormularioHijo(Form FormularoHijo)
        {
            //open only form
            if (formularioActual != null)
            {
                formularioActual.Close();
            }
            formularioActual = FormularoHijo;
            //End
            FormularoHijo.TopLevel = false;
            FormularoHijo.FormBorderStyle = FormBorderStyle.None;
            FormularoHijo.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(FormularoHijo);
            panelDesktop.Tag = FormularoHijo;
            FormularoHijo.BringToFront();
            FormularoHijo.Show();
            lblTituloFormulario.Text = FormularoHijo.Text;
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Modulos());
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Usuarios());
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Planes());
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Especialidades());
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Materias());
        }

        private void btnComisones_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Comisiones());
        }
    }
}

