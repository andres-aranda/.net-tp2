using Academia.Util;
using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Academia.UI.Web
{
    public partial class InscripcionCursado : System.Web.UI.Page
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

        #endregion

        #region BUSCAR
        private List<Comision> buscarComisiones(int idMateria)
        {
            ComisionLogic comLog = new ComisionLogic();
            return comLog.GetByMateria(idMateria);
        }
        private void buscarMaterias(int idPlan)
        {
            this.cmbMateria.DataSource = Logic.GetByPlan(idPlan);
            this.cmbMateria.DataBind();
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {
            tablaResumen.Visible = false;
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            int idPersona = usuario.Persona.Id;
            Persona per = LogicPer.GetOne(idPersona);
            if (!(Page.IsPostBack)) 
            {
                buscarMaterias(per.IdPlan);
                DataBind(); 
            }
        }

        protected void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateria = int.Parse(cmbMateria.SelectedValue);
            cmbComision.DataSource = buscarComisiones(idMateria);
            cmbComision.DataBind();
        }
        protected void cmbComision_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateria = int.Parse(cmbMateria.SelectedValue);
            int idComision = int.Parse(cmbComision.SelectedValue);
            CursoLogic cl = new CursoLogic();
            CursoElegido = cl.GetByComisionMateria(idComision, idMateria);          
        }

        protected void inscripcion_Click(object sender, EventArgs e)
        {
            int idMateria = int.Parse(cmbMateria.SelectedValue);
            int idComision = int.Parse(cmbComision.SelectedValue);
            CursoLogic cl = new CursoLogic();
            CursoElegido = cl.GetByComisionMateria(idComision, idMateria);
            Usuario u = (Usuario)Session["usuarioLogueado"];
            if (Validations.IsValidInscripcion(u.Persona.Id, CursoElegido.Id))
            {
                ResumenInscripcion inscripcion = new ResumenInscripcion
                {
                    nombreComision = CursoElegido.Comision.DescripcionComision,
                    nombreMateria = CursoElegido.Materia.Descripcion,
                    añoCurso = CursoElegido.AñoCalendario
                };
                ComisionLabel.Text = inscripcion.nombreComision;
                MateriaLabel.Text = inscripcion.nombreMateria;
                AñoLabel.Text = inscripcion.añoCurso.ToString();
                tablaResumen.Visible = true;
                cl.Inscribir(u.Persona.Id, CursoElegido.Id);
            }
            else
            {
                MessageBox.Show(u.Persona.Apellido + " " + u.Persona.Nombre + " ya se encuentra inscripto a " + CursoElegido.Materia.Descripcion);
            }
        }
    }
}