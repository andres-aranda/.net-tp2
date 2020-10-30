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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DataSetMateriasAcademia.materias' table. You can move, or remove it, as needed.
            this.materiasTableAdapter.Fill(this.DataSetMateriasAcademia.materias);

            this.reportViewer1.RefreshReport();
        }
    }
}
