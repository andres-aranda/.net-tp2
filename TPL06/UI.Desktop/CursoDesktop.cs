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

        public int idCurso { get; private set; }


        public CursoDesktop()
        {
            idCurso = 0;
            InitializeComponent();
        }
        public CursoDesktop(int id)
        {
            idCurso = id;
            InitializeComponent();
        }

        public void CursoDesktop_Load(object sender, EventArgs e)
        {

            CargaCombos();
            if (idCurso != 0)
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    Curso = db.cursos.Find(idCurso);
                }
                Mapeo();
            }

        }

        public void CargaCombos()
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                this.cmbPlan.DataSource = db.planes.ToList();
                this.cmbPlan.DisplayMember = "desc_plan";
                this.cmbPlan.ValueMember = "id_plan";


                this.cmbComision.DataSource =  db.comisiones.Where(c => c.id_plan == (int)cmbPlan.SelectedValue).ToList();
                this.cmbComision.DisplayMember = "desc_comision";
                this.cmbComision.ValueMember = "id_comision";

                this.cmbMateria.DataSource = db.materias.Where(m=>m.id_plan==(int)cmbPlan.SelectedValue).ToList();
                this.cmbMateria.DisplayMember = "desc_materia";
                this.cmbMateria.ValueMember = "id_materia";
            }
        }
        private void Mapeo()
        {
            lblId.Text = Curso.id_curso.ToString();
            txtAnio.Text = Curso.anio_calendario.ToString();
            txtCupo.Text = Curso.cupo.ToString();
            cmbComision.SelectedValue = Curso.id_comision;
            cmbMateria.SelectedValue = Curso.id_materia;
        }
       
          

        private void cmbPlan_SelectedValueChanged(object sender, EventArgs e)
        {

             using (EntidadesTP2 db = new EntidadesTP2())
            {
                Console.WriteLine(cmbPlan.SelectedValue.GetType());
                int pla = 0;
                try
                {            
                    pla = (int)(cmbPlan.SelectedValue);
                }
                catch
                {

                }
                if (pla != 0)
                {
                this.cmbComision.DataSource = db.comisiones.Where(c => c.id_plan == pla).ToList();
                this.cmbComision.DisplayMember = "desc_comision";
                this.cmbComision.ValueMember = "id_comision";

                this.cmbMateria.DataSource = db.materias.Where(m => m.id_plan == pla).ToList();
                this.cmbMateria.DisplayMember = "desc_materia";
                this.cmbMateria.ValueMember = "id_materia";
                }
                
            }
      
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                cursos curso = LeerCampos();
                if (idCurso == 0)
                {
                    db.cursos.Add(curso);
                }
                else
                {
                    curso = db.cursos.Find(idCurso);
                    curso = LeerCampos();                
                }
                db.SaveChanges();

                    /*
                     public void Update(Persona p)
        {
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    personas oPersona = db.personas.Find(p.Id);
                    oPersona.nombre = p.Nombre;
                    oPersona.apellido = p.Apellido;
                    oPersona.direccion = p.Direccion;
                    oPersona.telefono = p.Telefono;
                    oPersona.legajo = p.Legajo;
                    oPersona.id_plan = p.IdPlan;
                    oPersona.fecha_nac = p.FechaDeNacimiento;

                    db.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
*/
                
            }
        }

        private cursos LeerCampos()
        {
            cursos c = new cursos
            {
                id_comision = int.Parse(cmbComision.SelectedValue.ToString()),
                id_materia = int.Parse(cmbMateria.SelectedValue.ToString()),
                anio_calendario = int.Parse(txtAnio.Text),
                cupo = int.Parse(txtCupo.Text)
            };
            return c;
        }

    }
}
