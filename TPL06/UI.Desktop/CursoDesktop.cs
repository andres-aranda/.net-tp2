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
    public partial class CursoDesktop : Form
    {
        private cursos Curso = new cursos();
        public CursoDesktop(int idCurso)
        {
            idCurso = 4;
            CargaCombos();
            if (idCurso != 0)
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    Curso = db.cursos.Find(idCurso);
                }
                Mapeo();
            }

            InitializeComponent();
        }

        public void CursoDesktop_Load(object sender, EventArgs e)
        {

        }

        public void CargaCombos()
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                List<comisiones> com = db.comisiones.ToList();
                this.cmbComision.DataSource = com;
                this.cmbComision.DisplayMember = "desc_comision";
                this.cmbComision.ValueMember = "id_comision";

                this.cmbMateria.DataSource = db.materias.ToList();
                this.cmbMateria.DisplayMember = "desc_materia";
                this.cmbMateria.ValueMember = "id_materia";
            }
        }
        private void Mapeo()
        {
            lblId.Text = Curso.id_curso.ToString();
            txtAnio.Text = Curso.anio_calendario.ToString();
            txtCupo.Text = Curso.cupo.ToString();
            cmbComision.SelectedItem = Curso.id_comision;
            cmbMateria.SelectedItem = Curso.id_materia;
        }
    }
}
