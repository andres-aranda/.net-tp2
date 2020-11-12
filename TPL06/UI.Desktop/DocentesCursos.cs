using Academia.Data.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.UI.Desktop
{
    public partial class DocentesCursos : Form
    {
        int idPersona;
        public DocentesCursos()
        {
            InitializeComponent();
            idPersona = -1;
        }
        public DocentesCursos(int id)
        {
            InitializeComponent();
            idPersona = id;
        }

        private void DocentesCursos_Load(object sender, EventArgs e)
        {
            if (idPersona == -1)
            { try
                {
                IngresoLegajo il = new IngresoLegajo();
                il.ShowDialog();
                int legajo = il.Legajo;
               
                    using (EntidadesTP2 db = new EntidadesTP2())
                    {
                        idPersona = db.personas.Where(x => x.legajo == legajo).First().id_persona;
                    }
                }
                catch
                {
                    MessageBox.Show("Lejago no válido.");
                    this.Close();
                }
            }
            else
            {
                tsmCursosDocente.Visible = false;
            }

            using (EntidadesTP2 db = new EntidadesTP2())
            {
                var listaDocentesCursos = from d in db.personas
                                          join dc in db.docentes_cursos on d.id_persona equals dc.id_docente
                                          join c in db.cursos on dc.id_curso equals c.id_curso
                                          join com in db.comisiones on c.id_comision equals com.id_comision
                                          join m in db.materias on c.id_materia equals m.id_materia
                                          where d.id_persona == idPersona
                                          select new { d.legajo, d.apellido, d.nombre, com.desc_comision, m.desc_materia };

                dgvCursosDocente.DataSource = listaDocentesCursos.ToList();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DocentesCursosForm dcf = new DocentesCursosForm(idPersona);
            dcf.ShowDialog();
        }
    }
}
