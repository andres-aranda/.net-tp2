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
    public partial class Especialidades : Form
    {
        public Especialidades()
        {
            InitializeComponent();
            dgvEspecialidades.AutoGenerateColumns = false;
            dgvEspecialidades.Columns[0].Visible = false;
        }

        private void Listar()
        {
            EspecialidadLogic el = new EspecialidadLogic();

            try
            {
                this.dgvEspecialidades.DataSource = el.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Especialidades_Load(object sender, EventArgs e)
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
            EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(ApplicationForm.ModoForm.Alta);
            especialidadDesktop.ShowDialog();
            this.Listar();
        }
        private void TsbModificarEspecialidad_Click(object sender, EventArgs e)
        {
            if (this.dgvEspecialidades.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).Id;
                EspecialidadDesktop especialidadDesktop = new EspecialidadDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                especialidadDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void TsbBorrarEspecialidad_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvEspecialidades.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show("¿Desea eliminar el especialidad?", "Borrar Especialidad", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                        int ID = ((Business.Entities.Especialidad)this.dgvEspecialidades.SelectedRows[0].DataBoundItem).Id;
                        EspecialidadLogic especialidadLogic = new EspecialidadLogic();
                        especialidadLogic.Delete(ID);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al eliminar la especialidad. Verifique que no esté siendo usada.");
            }
            this.Listar();
        }

        private void tscUsuarios_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }
    }
}
