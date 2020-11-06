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
using System.Data.Entity;

namespace Academia.UI.Desktop
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            dgvCursos.AutoGenerateColumns = false;
            Mapeo();

        }
        private void Mapeo()
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                var listaCursos = from cur in db.cursos
                                  join com in db.comisiones on cur.id_comision equals com.id_comision
                                  join m in db.materias on cur.id_materia equals m.id_materia
                                  select new { Id = cur.id_curso, Materia = m.desc_materia, Comision = com.desc_comision, Año = cur.anio_calendario, Cupo = cur.cupo };
                this.dgvCursos.DataSource = listaCursos.ToList();
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop cd = new CursoDesktop();
            cd.ShowDialog();
            Mapeo();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvCursos.SelectedRows.Count > 0)
            {
                int id = (int)dgvCursos.SelectedRows[0].Cells[0].Value;
                CursoDesktop cd = new CursoDesktop(id);
                cd.ShowDialog();
            }
            Mapeo();
        }

        private void tsbReporte_Click(object sender, EventArgs e)
        {
            ReporteInscripciones ri = new ReporteInscripciones();
            ri.ShowDialog();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el curso?", "Borrar Curso", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.dgvCursos.SelectedRows.Count > 0)
                {
                    using (EntidadesTP2 db = new EntidadesTP2())
                    {
                        int ID = (int)dgvCursos.SelectedRows[0].Cells[0].Value;
                        cursos curso = db.cursos.Find(ID);
                        db.cursos.Remove(curso);
                        db.SaveChanges();
                    }
                    
                      
                }
            }
            Mapeo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Mapeo();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
