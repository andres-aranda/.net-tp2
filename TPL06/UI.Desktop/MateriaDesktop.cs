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
    public partial class MateriaDesktop : ApplicationForm
    {
        public Materia Materia { get; set; }

        public MateriaDesktop()
        {
            InitializeComponent();
            FillPlanes();
        }

        public MateriaDesktop(ModoForm modo) : this()
        {
            modoForm = modo;
            SetFormName(modo);
        }

        public MateriaDesktop(int id, ModoForm modo) : this()
        {
            MateriaLogic materiaLogic = new MateriaLogic();
            Materia = materiaLogic.GetOne(id);
            modoForm = modo;
            SetFormName(modo);
            MapearDeDatos();
        }

        public override void MapearDeDatos()
        {
            txtId.Text = Materia.Id.ToString();
            txtNombre.Text = Materia.Descripcion;
            txtHsSemanales.Text = Materia.HsSemanales.ToString();
            txtHsTotales.Text = Materia.HsTotales.ToString();
            
        }

        public override bool Validar()
        {
            if (txtNombre.Text == "" || txtHsSemanales.Text == "" || txtHsTotales.Text == "")
            {
                Notificar("Debe llenar todos los campos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void SetFormName(ModoForm modo)
        {
            switch (modo)
            {
                case ModoForm.Alta:
                    Text = "Crear materia";
                    break;
                case ModoForm.Baja:
                    Text = "Borrar materia";
                    break;
                case ModoForm.Consulta:
                    Text = "Consultar materia";
                    break;
                case ModoForm.Modificacion:
                    Text = "Modificar materia";
                    break;
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Validar())
            {
                GuardarCambios();
                Close();
            }
        }

        public override void MapearADatos()
        {
            Materia = new Materia();
            Materia.Id = 0;
            Materia.Descripcion = txtNombre.Text;
            Materia.HsSemanales = int.Parse(txtHsSemanales.Text);
            Materia.HsTotales = int.Parse(txtHsTotales.Text);
            Materia.IdPlan = (int)cboIdPlan.SelectedValue;
            if (modoForm == ModoForm.Alta)
                Materia.State = Materia.Estados.New;
            else if (modoForm == ModoForm.Modificacion)
            {
                Materia.Id = int.Parse(txtId.Text);
                Materia.State = Materia.Estados.Modified;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            MateriaLogic ml = new MateriaLogic();
            ml.Save(Materia);
        }

        public void FillPlanes()
        {
            PlanLogic pl = new PlanLogic();
            cboIdPlan.DataSource = pl.GetAll();
            cboIdPlan.DisplayMember = "DescripcionComision";
            cboIdPlan.ValueMember = "Id";
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MateriaDesktop_Load(object sender, EventArgs e)
        {

        }
    }
}
