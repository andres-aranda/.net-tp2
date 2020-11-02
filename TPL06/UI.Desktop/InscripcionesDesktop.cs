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
    public partial class InscripcionesDesktop : Form
    {
        #region DECLARACIONES
        MateriaLogic _logic;
        private MateriaLogic Logic
        {
            get
            {
                if (_logic == null)
                {
                    _logic = new MateriaLogic();
                }
                return _logic;
            }
        }
        PersonaLogic _logicPer;
        private PersonaLogic LogicPer
        {
            get
            {
                if (_logicPer == null)
                {
                    _logicPer = new PersonaLogic();
                }
                return _logicPer;
            }
        }
        private struct ResumenInscripcion
        {
            public string nombreComision;
            public string nombreMateria;
            public int añoCurso;
        }

        Curso _Curso = new Curso();
        private Curso CursoElegido
        {
            get => _Curso;
            set => _Curso = value;
        }
        public Persona Per { get => _per; set => _per = value; }

        Persona _per;
        #endregion

        #region BUSCAR
        private List<Comision> buscarComisiones(int idMateria)
        {
            ComisionLogic comLog = new ComisionLogic();
            return comLog.GetByMateria(idMateria);
        }
        private void buscarMaterias(int idPlan)
        {
            this.cmbMaterias.DataSource = Logic.GetByPlan(idPlan);
            this.cmbMaterias.DisplayMember = "Descripcion";
            this.cmbMaterias.ValueMember = "Id";
        }
        #endregion
        public InscripcionesDesktop(int idPersona)
        {
            Per = LogicPer.GetOne(idPersona);
            
            InitializeComponent();
        }

        private void InscripcionesDesktop_Load(object sender, EventArgs e)
        {
            panelResumen.Visible = false;
            buscarMaterias(Per.IdPlan);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            int idMateria = (int)cmbMaterias.SelectedValue;
            int idComision = (int)cmbComison.SelectedValue;
            CursoLogic cl = new CursoLogic();
            CursoElegido = cl.GetByComisionMateria(idComision, idMateria);
            ResumenInscripcion inscripcion = new ResumenInscripcion
            {
                nombreComision = CursoElegido.Comision.DescripcionComision,
                nombreMateria = CursoElegido.Materia.Descripcion,
                añoCurso = CursoElegido.AñoCalendario
            };
            lblComision.Text = inscripcion.nombreComision;
            lblMateria.Text = inscripcion.nombreMateria;
            lblAño.Text = inscripcion.añoCurso.ToString();
            panelResumen.Visible = true;
            cl.Inscribir(Per.Id, CursoElegido.Id);
            MessageBox.Show("Inscripción solicitada con éxito");
            cmbComison.Enabled = false;
            cmbMaterias.Enabled = false;
            btnConfirmar.Enabled = false;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbMaterias_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
            int idMateria = (int)cmbMaterias.SelectedValue;
            cmbComison.DataSource = buscarComisiones(idMateria);
            this.cmbComison.DisplayMember = "DescripcionComision";
            this.cmbComison.ValueMember = "Id";
               
            }
            catch
            {

            }
       
        }

        private void cmbComison_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            { if (cmbComison.SelectedValue != null)
                {
             int idMateria = ((Materia)cmbMaterias.SelectedValue).Id;            
            int idComision = ((Comision)cmbComison.SelectedValue).Id;
            CursoLogic cl = new CursoLogic();
            CursoElegido = cl.GetByComisionMateria(idComision, idMateria);
                }
 
            }
            catch
            {

            }
          
        }
    }
}
