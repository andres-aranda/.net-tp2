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
    public partial class Alumno : Form
    {
        public Alumno()
        {
            InitializeComponent();
        }

        private void Alumno_Load(object sender, EventArgs e)
        {
            Mapeo();
        }
        private void Mapeo()
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    var listaCursos = from pe in db.personas
                                      join alu_ins in db.alumnos_inscripciones on pe.id_persona equals alu_ins.id_alumno
                                      join cur in db.cursos on alu_ins.id_curso  equals cur.id_curso
                                      join mat in db.materias on cur.id_materia equals mat.id_materia
                                      join com in db.comisiones on cur.id_comision equals com.id_comision
                                      join doc_cur in db.docentes_cursos on cur.id_curso equals doc_cur.id_curso
                                      select new { 
                                          Materia = mat.desc_materia, 
                                          Comision = com.desc_comision,
                                          Año = cur.anio_calendario,
                                          Nombre = pe.nombre,
                                          Apellido = pe.apellido,
                                          Legajo = pe.legajo,
                                          Nota = alu_ins.nota,
                                          Anio = cur.anio_calendario

                                      };
                     this.dvgAlumnos.DataSource = listaCursos.ToList();
                }
            }
    }
}
