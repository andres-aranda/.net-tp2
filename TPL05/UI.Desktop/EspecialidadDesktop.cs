using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace Academia.UI.Desktop
{
    public partial class EspecialidadDesktop : ApplicationForm
    {
        public Especialidad EspecialidadActual { get; set; }
        public EspecialidadDesktop()
        {
            InitializeComponent();
        }


        public EspecialidadDesktop(ModoForm modo) : this()
        {
            this.modoForm = modo;

            this.SetFormName(modo);
        }

        public EspecialidadDesktop(int ID, ModoForm modo) : this()
        {
            EspecialidadLogic especialidadLogic = new EspecialidadLogic();
            EspecialidadActual = especialidadLogic.GetOne(ID);

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
            this.txtId.Text = this.EspecialidadActual.Id.ToString();
            this.txtDescripcion.Text = this.EspecialidadActual.Descripcion;

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
                    this.EspecialidadActual = new Especialidad();
                    this.EspecialidadActual.Id = 0;
                    this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                  
                    this.EspecialidadActual.State = BusinessEntity.Estados.New;
                    break;

                case ModoForm.Modificacion:
                    this.EspecialidadActual.Id = int.Parse(this.txtId.Text.ToString());
                    this.EspecialidadActual.Descripcion = this.txtDescripcion.Text;
                  
                    this.EspecialidadActual.State = BusinessEntity.Estados.Modified;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
            EspecialidadLogic especialidadLogic = new EspecialidadLogic();
            especialidadLogic.Save(EspecialidadActual);
        }
        public override bool Validar()
        {
            bool retorno = true;
            string mensaje = "";

            if (this.txtDescripcion.Text == "")
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
                    this.Text = "Crear Especialidad";
                    break;
                case ModoForm.Baja:
                    this.Text = "Borrar Especialidad";
                    break;
                case ModoForm.Consulta:
                    this.Text = "Consultar Especialidad";
                    break;
                case ModoForm.Modificacion:
                    this.Text = "Modificar Especialidad";
                    break;
            }
        }

    }
}
