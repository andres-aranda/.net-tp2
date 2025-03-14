﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business.Entities;
using Business.Logic;

namespace Academia.UI.Desktop
{
    public partial class Materias : Form
    {
        public Materias()
        {
            InitializeComponent();
            this.dgvMaterias.AutoGenerateColumns = false;
        }

        public void Listar()
        {
            MateriaLogic ml = new MateriaLogic();
            try
            {
                this.dgvMaterias.DataSource = ml.GetAll();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void Materias_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            MateriaDesktop md = new MateriaDesktop(ApplicationForm.ModoForm.Alta);
            md.ShowDialog();
            Listar();
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                int id = ((Business.Entities.Materia)dgvMaterias.SelectedRows[0].DataBoundItem).Id;
                MateriaDesktop materiaDesktop = new MateriaDesktop(id, ApplicationForm.ModoForm.Modificacion);
                materiaDesktop.ShowDialog();
            }
            Listar();
        }

        private void tsbEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMaterias.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("¿Desea eliminar la materia?", "Eliminar materia", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    int id = ((Business.Entities.Materia)dgvMaterias.SelectedRows[0].DataBoundItem).Id;
                    MateriaLogic materiaLogic = new MateriaLogic();
                    materiaLogic.Delete(id);
                }
            }
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
