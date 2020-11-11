using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia.Data.Database;
using Business.Entities;
using Business.Logic;
using Data.Database;

namespace Academia.UI.Desktop
{
    public partial class Planes : Form
    {
        public Planes()
        {
            InitializeComponent();
            dgvPlanes.AutoGenerateColumns = false;
            dgvPlanes.Columns[0].Visible = false;
            
        }
        private void Listar()
        {
            PlanLogic ml = new PlanLogic();
            try
            {
                using (EntidadesTP2 db = new EntidadesTP2())
                {
                    var listaPlanes = from p in db.planes
                                      join e in db.especialidades on p.id_especialidad equals e.id_especialidad
                                      select new { ID = p.id_plan, Descripcion = p.desc_plan, Especialidad = e.desc_especialidad };
                    dgvPlanes.DataSource = listaPlanes.ToList();
                }
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
                int ID = (int)dgvPlanes.SelectedRows[0].Cells[0].Value;
                PlanDesktop planDesktop = new PlanDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                planDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void TsbBorrarPlan_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvPlanes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea eliminar el plan?", "Borrar Plan", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int ID = (int)dgvPlanes.SelectedRows[0].Cells[0].Value;
                        PlanLogic planLogic = new PlanLogic();
                        planLogic.Delete(ID);
                    }
                }
                this.Listar();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateException)
            {
                MessageBox.Show("No se pudo eliminar el plan.");
            }
        }
    }
}
