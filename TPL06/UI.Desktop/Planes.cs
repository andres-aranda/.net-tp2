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
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            this.dgvPlanes.AutoGenerateColumns = false;
        }
        private void Listar()
        {
            PlanLogic ml = new PlanLogic();

            try
            {
                this.dgvPlanes.DataSource = ml.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Planes_Load(object sender, EventArgs e)
        {
            Listar();
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PlanDesktop planDesktop = new PlanDesktop(ApplicationForm.ModoForm.Alta);
            planDesktop.ShowDialog();
            this.Listar();
        }
        private void TsbModificarPlan_Click(object sender, EventArgs e)
        {
            if (this.dgvPlanes.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).Id;
                PlanDesktop planDesktop = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                planDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void TsbBorrarPlan_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el plan?", "Borrar Plan", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.dgvPlanes.SelectedRows.Count > 0)
                {
                    int ID = ((Business.Entities.Plan)this.dgvPlanes.SelectedRows[0].DataBoundItem).Id;
                    PlanLogic planLogic = new PlanLogic();
                    planLogic.Delete(ID);
                }
            }
            this.Listar();
        }
    }
}
