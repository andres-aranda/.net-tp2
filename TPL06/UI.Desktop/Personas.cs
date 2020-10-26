using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Logic;

namespace Academia.UI.Desktop
{
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            PersonaLogic pl = new PersonaLogic();
            dgvPersonas.DataSource = pl.GetAll();
        }
    }
}
