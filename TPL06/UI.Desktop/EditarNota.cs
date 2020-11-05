using Academia.Data.Database;
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
    public partial class EditarNota : Form
    {
        int _inscripcion;
        public EditarNota(int id)
        {
            InitializeComponent();
            IdInscripcion = id;
        }

        public int IdInscripcion { get => _inscripcion; set => _inscripcion = value; }

        private void EditarNota_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                try
                {
                    alumnos_inscripciones aluIns = db.alumnos_inscripciones.Find(IdInscripcion);
                    aluIns.nota = int.Parse(txtNota.Text);
                    db.SaveChanges();
                    MessageBox.Show("Calificacion guardada,");
                    this.Close();
                }
                catch
                {
                    MessageBox.Show("La nota ingresada es invalida");
                }


            }
        }
    }
}
