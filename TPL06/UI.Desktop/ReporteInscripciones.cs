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
    public partial class ReporteInscripciones : Form
    {
        public ReporteInscripciones()
        {
            InitializeComponent();
        }

        private void ReporteInscripciones_Load(object sender, EventArgs e)
        {
            this.DataTable1TableAdapter.Fill(this.DataSetPersonas.DataTable1);

            this.reportViewer1.RefreshReport();
        }
    }
}
