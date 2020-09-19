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
    public partial class ModuloDesktop : ApplicationForm
    {
        public Modulo ModuloActual { get; set; }
        public ModuloDesktop()
        {
            InitializeComponent();
        }
      

        public ModuloDesktop(ModoForm modo) : this()
        {
            this.modoForm = modo;

            this.SetFormName(modo);
        }

        public ModuloDesktop(int ID, ModoForm modo) : this()
        {
            ModuloLogic moduloLogic = new ModuloLogic();
            ModuloActual = moduloLogic.GetOne(ID);

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
            this.txtId.Text = this.ModuloActual.Id.ToString();
            this.txtDescripcion.Text = this.ModuloActual.Descripcion;
  
           
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
                    this.ModuloActual = new Modulo();
                    this.ModuloActual.Id = 0;
                    this.ModuloActual.Descripcion = this.txtDescripcion.Text;
                  //  this.ModuloActual.Ejecuta = this.txtEjecuta.Text;

                    this.ModuloActual.State = BusinessEntity.Estados.New;
                    break;

                case ModoForm.Modificacion:
                    this.ModuloActual.Id = int.Parse(this.txtId.Text.ToString());
                    this.ModuloActual.Descripcion = this.txtDescripcion.Text;
                  //  this.ModuloActual.Ejecuta = this.txtEjecuta.Text;

                    this.ModuloActual.State = BusinessEntity.Estados.Modified;
                    break;
                default:
                    break;
            }
        }

        public override void GuardarCambios()
        {
            this.MapearADatos();
            ModuloLogic moduloLogic = new ModuloLogic();
            moduloLogic.Save(ModuloActual);
        }
        public override bool Validar()
        {
            bool retorno = true;
            string mensaje = "";

            if (this.txtDescripcion.Text == "" | this.txtEjecuta.Text == "")
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
                    this.Text = "Crear Modulo";
                    break;
                case ModoForm.Baja:
                    this.Text = "Borrar Modulo";
                    break;
                case ModoForm.Consulta:
                    this.Text = "Consultar Modulo";
                    break;
                case ModoForm.Modificacion:
                    this.Text = "Modificar Modulo";
                    break;
            }
        }

    }
}
