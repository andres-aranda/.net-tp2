using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.Web
{
    public partial class InscripcionCursado : System.Web.UI.Page
    {
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

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            int idPersona = usuario.IdPersona;
            Persona per = LogicPer.GetOne(idPersona);
            if (!(Page.IsPostBack)) 
            {
                buscarMaterias(per.IdPlan);
                DataBind(); 
            }
        }
        private List<Comision> buscarComisiones(int idMateria){
            ComisionLogic comLog = new ComisionLogic();
            return comLog.GetByMateria(idMateria);
            }
        protected void cmbMateria_SelectedIndexChanged(object sender, EventArgs e)
        {
            int idMateria = int.Parse(cmbMateria.SelectedValue);
            cmbComision.DataSource = buscarComisiones(idMateria);
            cmbComision.DataBind();
        }
       
    
        private void buscarMaterias(int idPlan)
        {
            this.cmbMateria.DataSource = Logic.GetByPlan(idPlan);
            this.cmbMateria.DataBind();
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
            CursoElegido.Comision = new Comision();
            CursoElegido.Materia = new Materia();
            ResumenInscripcion inscripcion = new ResumenInscripcion
            {
                nombreComision = CursoElegido.Comision.DescripcionComision,
                nombreMateria = CursoElegido.Materia.Descripcion,
                añoCurso = CursoElegido.AñoCalendario
            };
            MateriaLabel.Text = "hola" + CursoElegido.Comision.DescripcionComision;
            this.detallesInscripcion.Visible = true;
            this.MateriaLabel.Visible = true;
        }

        protected void solicInscripcion(object sender, EventArgs e)
        {

        }
    }
}