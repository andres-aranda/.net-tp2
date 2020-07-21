using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;


namespace Academia.UI.Desktop
{
    public partial class PlanDesktop : ApplicationForm
    {
        public Plan PlanActual { get; set; }
        EspecialidadLogic el = new EspecialidadLogic();

        private void comboBox()
        {
            this.cmbEsp.DataSource = el.GetAll();
            this.cmbEsp.DisplayMember = "Descripcion";
            this.cmbEsp.ValueMember = "Id";
        }
        public PlanDesktop()
        {
            InitializeComponent();

          
        }
        public PlanDesktop(ModoForm modo) : this()
        {
            this.modoForm = modo;
            this.comboBox();
            this.SetFormName(modo);
       
        }
     
        public PlanDesktop(int ID, ModoForm modo) : this()
        {
            PlanLogic planLogic = new PlanLogic();
            PlanActual = planLogic.GetOne(ID);

            this.comboBox();
            this.modoForm = modo;

            this.MapearDeDatos();

            this.SetFormName(modo);
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (this.Validar())
            {
                this.GuardarCambios();
                this.Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public override void MapearDeDatos()
        {
            this.txtId.Text = this.PlanActual.Id.ToString();
            this.txtDescripcion.Text = this.PlanActual.Descripcion;

            switch (this.modoForm)
            {
                case ModoForm.Alta | ModoForm.Modificacion:
                    this.btnAceptar.Text = "Guardar";
                    break;

                case ModoForm.Baja:
                    this.btnAceptar.Text = "Eliminar";
                    break;

                case ModoForm.Consulta:
                    this.btnAceptar.Text = "Aceptar";
                    break;
            }

        }
        public override void MapearADatos()
        {
            switch (this.modoForm)
            {
                case ModoForm.Alta:
                    this.PlanActual = new Plan();
                    this.PlanActual.Id = 0;
                    this.PlanActual.Descripcion = this.txtDescripcion.Text;
                    this.PlanActual.IdEspecialidad = Convert.ToInt32(this.cmbEsp.SelectedValue);

                    this.PlanActual.State = BusinessEntity.Estados.New;
                    break;

                case ModoForm.Modificacion:
                    this.PlanActual.Id = int.Parse(this.txtId.Text.ToString());
                    this.PlanActual.Descripcion = this.txtDescripcion.Text;
                    this.PlanActual.IdEspecialidad = Convert.ToInt32(this.cmbEsp.SelectedValue);

                    this.PlanActual.State = BusinessEntity.Estados.Modified;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
            PlanLogic planLogic = new PlanLogic();
            planLogic.Save(PlanActual);
        }
        public override bool Validar()
        {
            bool retorno = true;
            string mensaje = "";

            if (this.txtDescripcion.Text == "" )
            {
                mensaje = "Debe llenar todos los campos.";
                retorno = false;
            }

            if (!retorno)
            {
                Notificar(mensaje, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            return retorno;
        }
        private void SetFormName(ModoForm modo)
        {
            switch (modo)
            {
                case ModoForm.Alta:
                    this.Text = "Crear Plan";
                    break;
                case ModoForm.Baja:
                    this.Text = "Borrar Plan";
                    break;
                case ModoForm.Consulta:
                    this.Text = "Consultar Plan";
                    break;
                case ModoForm.Modificacion:
                    this.Text = "Modificar Plan";
                    break;
            }
        }
    }
}
