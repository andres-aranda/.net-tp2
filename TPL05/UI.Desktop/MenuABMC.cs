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
    public partial class MenuABMC : Form
    {
        public MenuABMC()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            Usuarios u = new Usuarios();
            u.ShowDialog();
        }

        private void btnMaterias_Click(object sender, EventArgs e)
        {
            Materias m = new Materias();
            m.ShowDialog();
        }

        private void btnEspecialidades_Click(object sender, EventArgs e)
        {
            Especialidades esp = new Especialidades();
            esp.ShowDialog();
        }

        private void btnModulos_Click(object sender, EventArgs e)
        {
            Modulos m = new Modulos();
            m.ShowDialog();
        }

        private void btnPlanes_Click(object sender, EventArgs e)
        {
            Planes p = new Planes();
            p.ShowDialog();
        }
    }
}
