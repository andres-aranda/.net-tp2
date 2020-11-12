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
    public partial class DocentesCursosForm : Form
    {
        public DocentesCursosForm(int idPersona)
        {
            InitializeComponent();
        }

        static List<string> cargos = new List<string>()
        {
            "Docente",
            "Jefe de cátedra",
            "Jefe de trabajos prácticos",
            "Ayudante"
        };

        private void DocentesCursosForm_Load(object sender, EventArgs e)
        {

        }
    }
}
