using Academia.Data.Database;
using Business.Entities;
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
            CargarPlanes();
            if (idCurso != 0)
            {
                Mapeo();
            }
        }

        public void CargarPlanes()
        {
            cmbPlan.DataSource = (new PlanLogic()).GetAll();
            cmbPlan.ValueMember = "Id";
            cmbPlan.DisplayMember = "Descripcion";
        }
        private void Mapeo()
        {
            txtAnio.Text = Curso.anio_calendario.ToString();
            txtCupo.Text = Curso.cupo.ToString();
            Curso c = (new CursoLogic()).GetOne(idCurso);
            cmbPlan.SelectedValue = (new PlanLogic()).GetByIdMateria(c.Materia.Id).Id.ToString();
            CargarMaterias();
            cmbMateria.SelectedValue = Curso.id_materia;
            CargarComisiones();
            cmbComision.SelectedValue = Curso.id_comision;

        }

        private void CargarMaterias()
        {
            int idPlan = (int)cmbPlan.SelectedValue;
            cmbMateria.DataSource = (new MateriaLogic()).GetByPlan(idPlan);
        }

        private void CargarComisiones()
        {
            int idPlan = (int)cmbPlan.SelectedValue;
            cmbComision.DataSource = (new ComisionLogic()).GetByPlan(idPlan);
        }

        private void cmbPlan_SelectedValueChanged(object sender, EventArgs e)
        {
            CargarMaterias();
        }

        private void btnCanelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                cursos curso = new cursos();
                curso.id_comision = int.Parse(cmbComision.SelectedValue.ToString());
                curso.id_materia = int.Parse(cmbMateria.SelectedValue.ToString());
                curso.anio_calendario = int.Parse(txtAnio.Text);
                curso.cupo = int.Parse(txtCupo.Text);
                if (idCurso == 0)
                {
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

        private cursos LeerCampos()
        {
            cursos c = new cursos
            {

            };
            return c;
        }

    }
}
