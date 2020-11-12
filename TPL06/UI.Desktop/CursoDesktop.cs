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
            cmbPlan.DataSource = (new PlanLogic()).GetAll();
            cmbPlan.DisplayMember = "Descripcion";
            cmbPlan.ValueMember = "Id";

            cmbComision.DataSource = (new ComisionLogic()).GetByPlan((int)cmbPlan.SelectedValue);
            cmbComision.DisplayMember = "DescripcionComision";
            cmbComision.ValueMember = "Id";

            cmbMateria.DataSource = (new MateriaLogic()).GetByPlan((int)cmbPlan.SelectedValue);
            cmbMateria.DisplayMember = "Descripcion";
            cmbMateria.ValueMember = "Id";
        }
        private void Mapeo()
        {
            int idPlan = (int)cmbPlan.SelectedValue;
            txtAnio.Text = Curso.anio_calendario.ToString();
            txtCupo.Text = Curso.cupo.ToString();
            cmbPlan.SelectedValue = (new PlanLogic()).GetByIdMateria(Curso.id_materia).Id;
            idPlan = (int)cmbPlan.SelectedValue;
            cmbComision.DataSource = (new ComisionLogic()).GetByPlan(idPlan);
            cmbComision.DisplayMember = "DescripcionComision";
            cmbComision.ValueMember = "Id";
            cmbComision.SelectedValue = Curso.id_comision;
            cmbMateria.DataSource = (new MateriaLogic()).GetByPlan(idPlan);
            cmbMateria.DisplayMember = "Descripcion";
            cmbMateria.ValueMember = "Id";
            cmbMateria.SelectedValue = Curso.id_materia;
        }



        private void cmbPlan_SelectedValueChanged(object sender, EventArgs e)
        {

            using (EntidadesTP2 db = new EntidadesTP2())
            {
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
            if (Validar())
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    cursos curso;
                    if (idCurso == 0)
                    {
                        curso = new cursos();
                        curso.id_comision = int.Parse(cmbComision.SelectedValue.ToString());
                        curso.id_materia = int.Parse(cmbMateria.SelectedValue.ToString());
                        curso.anio_calendario = int.Parse(txtAnio.Text);
                        curso.cupo = int.Parse(txtCupo.Text);
                        db.cursos.Add(curso);
                    }
                    else
                    {
                        curso = db.cursos.Find(idCurso);
                        curso.id_comision = int.Parse(cmbComision.SelectedValue.ToString());
                        curso.id_materia = int.Parse(cmbMateria.SelectedValue.ToString());
                        curso.anio_calendario = int.Parse(txtAnio.Text);
                        curso.cupo = int.Parse(txtCupo.Text);
                    }
                    db.SaveChanges();
                }
                Dispose();
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos.");
            }
        }

        private bool Validar()
        {
            if (cmbPlan.SelectedValue == null ||
                cmbComision.SelectedValue == null ||
                cmbMateria.SelectedValue == null ||
                string.IsNullOrEmpty(txtAnio.Text) ||
                string.IsNullOrEmpty(txtCupo.Text))
            {
                return false;
            }
            return true;
        }
    }
}