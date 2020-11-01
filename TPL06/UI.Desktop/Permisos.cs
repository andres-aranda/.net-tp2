using Academia.Data.Database;
using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academia.UI.Desktop
{
    public partial class Permisos : Form
    {
        UsuarioLogic ul = new UsuarioLogic();

        public Permisos()
        {
            InitializeComponent();
            Listar();
        }

        private void Permisos_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Listar()
        {
            List<Usuario> usuarios = ul.GetAll();
            dgvPermisos.AutoGenerateColumns = false;
            dgvPermisos.DataSource = usuarios;
            foreach (DataGridViewRow row in dgvPermisos.Rows)
            {
                Usuario u = usuarios.Find(usr => usr.NombreUsuario == (string)row.Cells[0].Value);
                u.Modulo = ul.GetModulos(u);
                if (u.Modulo.Exists(m => m.Id == 1))
                    row.Cells[1].Value = true;
                if (u.Modulo.Exists(m => m.Id == 2))
                    row.Cells[2].Value = true;
                if (u.Modulo.Exists(m => m.Id == 3))
                    row.Cells[3].Value = true;
                if (u.Modulo.Exists(m => m.Id == 4))
                    row.Cells[4].Value = true;
            }
        }

        private void dgvPermisos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvPermisos.CommitEdit(DataGridViewDataErrorContexts.Commit);

            if ((bool)dgvPermisos.CurrentCell.Value == false)
            {
                int idModulo = 0;
                switch (dgvPermisos.CurrentCell.ColumnIndex)
                {
                    case 1:
                        idModulo = 1;
                        break;
                    case 2:
                        idModulo = 2;
                        break;
                    case 3:
                        idModulo = 3;
                        break;
                    case 4:
                        idModulo = 4;
                        break;
                }
                ul.DeleteModulo((string)dgvPermisos.CurrentRow.Cells[0].Value, idModulo);
                MessageBox.Show("Permiso eliminado con éxito.", "Éxito", MessageBoxButtons.OK);
            }
            else
            {
                int idModulo = 0;
                switch (dgvPermisos.CurrentCell.ColumnIndex)
                {
                    case 1:
                        idModulo = 1;
                        break;
                    case 2:
                        idModulo = 2;
                        break;
                    case 3:
                        idModulo = 3;
                        break;
                    case 4:
                        idModulo = 4;
                        break;
                }
                ul.AddModulo((string)dgvPermisos.CurrentRow.Cells[0].Value, idModulo);
                MessageBox.Show("Permiso agregado con éxito.", "Éxito", MessageBoxButtons.OK);
            }
            Listar();
        }
    }
}
