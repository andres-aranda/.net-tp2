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
    public partial class Comisiones : Form
    {
        public Comisiones()
        {
            InitializeComponent();
            dgvComisiones.AutoGenerateColumns = false;
        }

        private void Listar()
        {
            ComisionLogic cl = new ComisionLogic();
            try
            {
                this.dgvComisiones.DataSource = cl.GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Comisiones_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            ComisionDesktop cd = new ComisionDesktop();
            cd.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvComisiones.SelectedRows.Count > 0)
            {
                int id = ((Business.Entities.Comision)dgvComisiones.SelectedRows[0].DataBoundItem).Id;
                ComisionDesktop cd = new ComisionDesktop(id, ApplicationForm.ModoForm.Modificacion);
                cd.ShowDialog();
            }
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvComisiones.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Seguro que desea eliminar la comisión?", "Eliminar comisión", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    ComisionLogic cl = new ComisionLogic();
                    int id = ((Business.Entities.Comision)dgvComisiones.SelectedRows[0].DataBoundItem).Id;
                    cl.Delete(id);
                }
            }
            Listar();
        }
    }
}
