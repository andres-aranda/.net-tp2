using Business.Entities;
using Business.Logic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.UI.Desktop
{
    public partial class ComisionDesktop : ApplicationForm
    {
        public Comision ComisionActual;

        public ComisionDesktop()
        {
            InitializeComponent();
            FillPlanes();
        }

        public ComisionDesktop(ModoForm modo) : this()
        {
            modoForm = modo;
            SetFormName(modo);
        }

        public ComisionDesktop(int id, ModoForm modo) : this()
        {
            ComisionLogic cl = new ComisionLogic();
            ComisionActual = cl.GetOne(id);
            modoForm = modo;
            MapearDeDatos();
            SetFormName(modo);
        }

        private void SetFormName(ModoForm modo)
        {
            switch (modo)
            {
                case ModoForm.Alta:
                    this.Text = "Crear comisión";
                    break;
                case ModoForm.Baja:
                    this.Text = "Borrar comisión";
                    break;
                case ModoForm.Consulta:
                    this.Text = "Consultar comisión";
                    break;
                case ModoForm.Modificacion:
                    this.Text = "Modificar comisión";
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        public override void MapearDeDatos()
        {
            txtDescripcion.Text = ComisionActual.DescripcionComision;
            txtAñoEspecialidad.Text = ComisionActual.AñoEspecialidad.ToString();
            cboPlan.Text = ComisionActual.IdPlan.ToString();
            switch(this.modoForm)
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

        public override bool Validar()
        {
            if (txtDescripcion.Text == "" || txtAñoEspecialidad.Text == "")
            {
                Notificar("Debe llenar todos los campos.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public override void MapearADatos()
        {
            ComisionActual = new Comision();
            ComisionActual.Id = 0;
            ComisionActual.DescripcionComision = txtDescripcion.Text;
            ComisionActual.AñoEspecialidad = int.Parse(txtAñoEspecialidad.Text);
            ComisionActual.IdPlan = (int)cboPlan.SelectedValue;
            if (modoForm == ModoForm.Alta)
                ComisionActual.State = Comision.Estados.New;
            else if (modoForm == ModoForm.Modificacion)
            {
                ComisionActual.State = Comision.Estados.Modified;
            }
        }

        public override void GuardarCambios()
        {
            MapearADatos();
            ComisionLogic cl = new ComisionLogic();
            cl.Save(ComisionActual);
        }

        public void FillPlanes()
        {
            PlanLogic pl = new PlanLogic();
            cboPlan.DataSource = pl.GetAll();
            cboPlan.DisplayMember = "DescripcionComision";
            cboPlan.ValueMember = "Id";
        }
    }
}
