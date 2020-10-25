using Academia.Data.Database;
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
    public partial class Personas : Form
    {
        public Personas()
        {
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tp2_netDataSet.personas' Puede moverla o quitarla según sea necesario.
            this.personasTableAdapter.Fill(this.tp2_netDataSet.personas);
            using (tp2 odb = new Entities())
            {
                List<usuarios> lista = odb.usuarios.ToList();
            }

        }
    }
}
