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
            cmbMateria.SelectedItem = Curso.id_materia;
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
    }
}
