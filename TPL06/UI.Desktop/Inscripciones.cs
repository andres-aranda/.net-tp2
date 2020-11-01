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

namespace Academia.UI.Desktop
{
    public partial class Inscripciones : Form
    {
        private int IdAlumno;
        public Inscripciones(int IdAlumno)
        {
            InitializeComponent();
            this.IdAlumno = IdAlumno;
            this.dgvAlumnoInscripciones.AutoGenerateColumns = false;
        }
         private void AlumnoInscripciones_Load(object sender, EventArgs e)
        {
             this.Listar();
        }
        private void tsbCrearAlumnoInscripciones_Click(object sender, EventArgs e)
        {
                this.CrearInscripcion();
                this.Listar();

        }

        private void tsbModificarAlumnoInscripciones_Click(object sender, EventArgs e)
        {
                this.ModificarInscripcion();
                this.Listar();
        }

        private void tsbEliminarAlumnoInscripciones_Click(object sender, EventArgs e)
        {
                this.EliminarInscripcion();
                this.Listar();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            this.Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CrearInscripcion()
        {

        }

        private void ModificarInscripcion()
        {
            
        }

        private void EliminarInscripcion()
        {
           
        }

        private void Listar()
        {
           
        }

        private void tsbReporte_Click(object sender, EventArgs e)
        {
            ReporteInscripciones ri = new ReporteInscripciones();
            ri.ShowDialog();
        }
    }
}
