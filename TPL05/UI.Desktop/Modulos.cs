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
    public partial class Modulos : Form
    {
        public Modulos()
        {
            InitializeComponent();
            this.dgvModulos.AutoGenerateColumns = false;
        }
        private void Listar()
        {
            ModuloLogic ml = new ModuloLogic();

            try
            {
                this.dgvModulos.DataSource = ml.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void Modulos_Load(object sender, EventArgs e)
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
            ModuloDesktop moduloDesktop = new ModuloDesktop(ApplicationForm.ModoForm.Alta);
            moduloDesktop.ShowDialog();
            this.Listar();
        }
        private void TsbModificarModulo_Click(object sender, EventArgs e)
        {
            if (this.dgvModulos.SelectedRows.Count > 0)
            {
                int ID = ((Business.Entities.Modulo)this.dgvModulos.SelectedRows[0].DataBoundItem).Id;
                ModuloDesktop moduloDesktop = new ModuloDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                moduloDesktop.ShowDialog();
            }
            this.Listar();
        }

        private void TsbBorrarModulo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el modulo?", "Borrar Modulo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.dgvModulos.SelectedRows.Count > 0)
                {
                    int ID = ((Business.Entities.Modulo)this.dgvModulos.SelectedRows[0].DataBoundItem).Id;
                    ModuloLogic moduloLogic = new ModuloLogic();
                    moduloLogic.Delete(ID);
                }
            }
            this.Listar();
        }


    }
}
