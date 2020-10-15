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
        void contraerMenuLateral()
        {
            if (lblAcacemia.Visible)
            {
                menuLateral.Width = 60;
                panel2.Height = 63;
                menuAbierto.Visible = false;
                lblAcacemia.Visible = false;
            }
            else
            {
                menuLateral.Width = 200;
                panel2.Height = 100;
                menuAbierto.Visible = true;
                lblAcacemia.Visible = true;
            }
        }
        Usuario usuarioActual;
        public Main()
        {
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

        private void formMain_Shown(object sender, EventArgs e)
        {
            tsmgestionAcademia.Visible = false;
            tsmgestionAlumno.Visible = false;
            tsmgestionDocente.Visible = false;
            Login appLogin = new Login();
            if (appLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
            else
                contraerMenuLateral();
            usuarioActual = (Usuario) appLogin.UsuarioLogeado;
            appLogin.Close();
            this.WindowState = FormWindowState.Maximized;
            foreach (Modulo m in usuarioActual.Modulo)
            {
                if (m.Descripcion == "Alumno" || m.Descripcion == "Administrador") 
                    tsmgestionAlumno.Visible = true ;
                if (m.Descripcion == "Docente" || m.Descripcion == "Administrador")
                    tsmgestionDocente.Visible = true;
                if (m.Descripcion == "No docente" || m.Descripcion == "Administrador")
                    tsmgestionAcademia.Visible = true;

            }

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

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            contraerMenuLateral();

        }

        private void mnuSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void mnuInscripcionCursos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Inscripciones(1));

            // COMO IDENTIFICO EL ID DEL ALUMNO LOGUEADO??????????? Donde esta el 1 tiene que ir algo como "IdAlumnoActual"
        }
    }
}

