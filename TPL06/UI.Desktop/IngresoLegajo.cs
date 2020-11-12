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
    public partial class IngresoLegajo : Form
    {
        private int legajo;
        public int Legajo { get => legajo; set => legajo = value; }

        public IngresoLegajo()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(txtLegajo.Text))
                { 
                    Legajo = int.Parse(txtLegajo.Text);
                    Close();
                }
                else
                { 
                    MessageBox.Show("Ingrese un legajo.");
                }
            }
            catch (FormatException)
            {

            }
        }
    }
}
