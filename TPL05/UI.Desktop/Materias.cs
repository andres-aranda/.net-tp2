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
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            try
            {
                this.dgvMaterias.DataSource = ml.GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Materias_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }
    }
}
