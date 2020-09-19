using Business.Logic;
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
    public partial class InscripcionMateria : Form
    {
        int IdMateria = 0;

        public InscripcionMateria()
        {
            InitializeComponent();
        }

        private void InscripcionMateria_Load(object sender, EventArgs e)
        {
            FillMaterias();
        }
        private void Listar()
        {
            CursoLogic el = new CursoLogic();

            try
            {
                this.dgvCursos.DataSource = el.GetByMateria(IdMateria);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void FillMaterias()
        {
            MateriaLogic pl = new MateriaLogic();
            cmbIdMaterias.DataSource = pl.GetAll();
            cmbIdMaterias.DisplayMember = "Descripcion";
            cmbIdMaterias.ValueMember = "Id";

        }
        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmbIdMaterias.ValueMember != "")
            {
    IdMateria = Convert.ToInt32(this.cmbIdMaterias.SelectedValue); ;
            Listar();
            }
        
        }

        private void cmbIdMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
