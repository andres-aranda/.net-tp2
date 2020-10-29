using Data.Database;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.Reportes
{
    public partial class Reporte1 : Form
    {
        MateriaAdapter matAdap = new MateriaAdapter();
        PersonaAdapter perAdap = new PersonaAdapter();
        public Reporte1()
        {
            InitializeComponent();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {
            this.dgv
            reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
