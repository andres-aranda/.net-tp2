using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Academia.UI.Desktop.Reportes
{
    public partial class Reporte : Form
    {
        public Reporte()    
        {
            InitializeComponent();
        }

        //private void Reporte_Load(object sender, EventArgs e)
        //{

        //    this.rptReport.RefreshReport();
        //}

        //private void reportViewer1_Load(object sender, EventArgs e)
        //{

        //}

        public void SetFormText(string nombre)
        {
            this.Text = "Reportes " + nombre;
        }
    }
}
