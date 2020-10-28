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
using System.Data.Entity;

namespace Academia.UI.Desktop
{
    public partial class Cursos : Form
    {
        public Cursos()
        {
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            Mapeo();

        }
        private void Mapeo()
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                 List<cursos>  cur = db.cursos.Include(x => x.comisiones).Include(x => x.materias).ToList();
                this.dataGridView1.DataSource = cur;
           }
        }
    }
}
