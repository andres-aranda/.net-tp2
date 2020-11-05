using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Academia.Data.Database;
using Business.Entities;
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
            dgvPersonas.AutoGenerateColumns = false;
            //dgvPersonas.Columns[0].Visible = false;
            Listar();
        }

        private void Listar()
        {

            PersonaLogic pl = new PersonaLogic();
            dgvPersonas.DataSource = pl.GetAll();

        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            PersonaDesktop pd = new PersonaDesktop();
            pd.ShowDialog();
            Listar();
        }
        

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar la persona?", "Borrar Persona", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.dgvPersonas.SelectedRows.Count > 0)
                {
                    using (EntidadesTP2 db = new EntidadesTP2())
                    {
                        int ID = (int)this.dgvPersonas.SelectedRows[0].Cells[0].Value;
                        personas persona = db.personas.Find(ID);
                        db.personas.Remove(persona);
                        db.SaveChanges();
                    }
                    
                }
            }
            Listar();
                    }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            try
            {
            int ID = (int)this.dgvPersonas.SelectedRows[0].Cells[0].Value;
            PersonaDesktop pd = new PersonaDesktop(ID);
            pd.ShowDialog();
            Listar();
            }
            catch
            {

            }
           
        }
    }
}
