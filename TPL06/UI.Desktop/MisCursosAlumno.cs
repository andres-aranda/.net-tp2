using Academia.Data.Database;
using Business.Logic;
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
    public partial class MisCursosAlumno : Form
    {
        int idPersona;
        CursoLogic cl = new CursoLogic();

 public int IdPersona { get => idPersona; set => idPersona = value; }

        public MisCursosAlumno(int id )
        {
            IdPersona = id;
            InitializeComponent();
        }

       

        private void MisCursosAlumno_Load(object sender, EventArgs e)
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                var inscripciones = from pe in db.personas
                                    join alu_ins in db.alumnos_inscripciones on pe.id_persona equals alu_ins.id_alumno
                                    join cur in db.cursos on alu_ins.id_curso equals cur.id_curso
                                    join mat in db.materias on cur.id_materia equals mat.id_materia
                                    join com in db.comisiones on cur.id_comision equals com.id_comision
                                    where alu_ins.id_alumno==IdPersona
                                    select new { Materia = mat.desc_materia, Comision = com.desc_comision, Nota = alu_ins.nota, Año=cur.anio_calendario };

                inscripcionesAlu.DataSource = inscripciones.ToList();
            }
           
        }
    }
}
