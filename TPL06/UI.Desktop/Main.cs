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
using Academia.Util;
using Academia.Data.Database;

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
            #region Ocultar todo
            tsmgestionAcademia.Visible = false;
            tsmgestionAlumno.Visible = false;
            tsmgestionDocente.Visible = false;
            tsmAlumno.Visible = false;
            tsmDocente.Visible = false;
            tsmSeguridad.Visible = false;            
            lblBienvenida.Visible = false;
            lblTituloAcciones.Visible = false;
            btnAlumnoCursos.Visible = false;
            btnAlumnoInscribirse.Visible = false;
            btnDocenteCursos.Visible = false;
            btnDocenteAlumnos.Visible = false;
            btnNoDocenteInscribirAlumno.Visible = false;
            btnNoDocentePersonas.Visible = false;
            btnNoDocenteUsuarios.Visible = false;
            btnAdministradorPermisos.Visible = false;
            #endregion

            Login appLogin = new Login();
            if (appLogin.ShowDialog() != DialogResult.OK)
                this.Dispose();
            else
                contraerMenuLateral();
            usuarioActual = (Usuario) appLogin.UsuarioLogeado;

            appLogin.Close();

            lblBienvenida.Text = Validations.Greeting() + usuarioActual.Persona.Nombre;
            lblBienvenida.Visible = true;
            lblTituloAcciones.Visible = true;
            
            foreach (Modulo m in usuarioActual.Modulo)
            {
                if (m.Descripcion == "Alumno")
                {
                    tsmAlumno.Visible = true;
                    btnAlumnoCursos.Visible = true;
                    btnAlumnoInscribirse.Visible = true;
                }
                if (m.Descripcion == "Docente")
                {
                    tsmDocente.Visible = true;
                    btnDocenteAlumnos.Visible = true;
                    btnDocenteCursos.Visible = true;
                }
                    
                if (m.Descripcion == "NoDocente" || m.Descripcion == "Administrador")
                {
                    tsmgestionAcademia.Visible = true;
                    tsmgestionAlumno.Visible = true;
                    tsmgestionDocente.Visible = true;
                    btnNoDocenteInscribirAlumno.Visible = true;
                    btnNoDocentePersonas.Visible = true;
                    btnNoDocenteUsuarios.Visible = true;
                    if (m.Descripcion == "Administrador")
                    {
                        tsmSeguridad.Visible = true;
                        btnAdministradorPermisos.Visible = true;
                    }
                }
            }

        }
        private void btnModulos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Modulos());
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
            IngresoLegajo il = new IngresoLegajo();
            il.ShowDialog();
            int legajo = il.Legajo;
            int idPersona;
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                idPersona = db.personas.Where(x => x.legajo == legajo).First().id_persona;
            }
            AbrirFormularioHijo(new InscripcionesDesktop(idPersona));
        }

        private void personasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Personas());
        }

        private void listadoDeMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Reporte());
        }

        private void tsmPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Permisos());
        }

        private void cursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Cursos());
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Materias());
        }

        private void btnAlumnoCursos_Click(object sender, EventArgs e)
        {
            // TODO: Abrir cursos del alumno
        }

        private void btnAlumnoInscribirse_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new InscripcionesDesktop(usuarioActual.Persona.Id));
        }

        private void btnDocenteCursos_Click(object sender, EventArgs e)
        {
            // TODO: Abrir CursosDocente
        }

        private void btnDocenteAlumnos_Click(object sender, EventArgs e)
        {
            // TODO: Abrir AlumnosDocente
        }

        private void btnNoDocentePersonas_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Personas());
        }

        private void btnNoDocenteUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Usuarios());
        }

        private void btnAdministradorPermisos_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Permisos());
        }

        private void miInformaciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new PersonaDesktop());
        }

        private void usuariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Usuarios());
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new Planes());
        }

        private void cursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // TODO: Preguntar ID docente para abrir CursosDocente
        }

        private void misCursosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Abrir CursosAlumno
        }

        private void inscripciónAMateriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormularioHijo(new InscripcionesDesktop(usuarioActual.Persona.Id));
        }

        private void misCursosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // TODO: Abrir CursosDocente
        }

        private void alumnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // TODO: Abrir AlumnosDocente
        }
    }
}

