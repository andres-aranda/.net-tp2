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
            dataGridView1.AutoGenerateColumns = false;
            Mapeo();

        }
        private void Mapeo()
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                List<cursos>  cur = db.cursos.Include(x => x.comisiones).Include(x => x.materias).ToList();
                this.dataGridView1.DataSource = cur;
            }
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            CursoDesktop cd = new CursoDesktop();
            cd.ShowDialog();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int id = ((cursos)dataGridView1.SelectedRows[0].DataBoundItem).id_curso;
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
                if (this.dataGridView1.SelectedRows.Count > 0)
                {
                    using (EntidadesTP2 db = new EntidadesTP2())
                    {
                        int ID = ((cursos)this.dataGridView1.SelectedRows[0].DataBoundItem).id_curso;
                        cursos curso = db.cursos.Find(ID);
                        db.cursos.Remove(curso);
                        db.SaveChanges();
                    }
                    
                      
                }
            }
            Mapeo();
        }
    }
}
