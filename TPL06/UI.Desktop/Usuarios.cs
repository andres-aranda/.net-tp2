using System;
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
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
            this.dgvUsuarios.AutoGenerateColumns = true;
            Listar();
        }

        private void Listar()
        {
            UsuarioLogic ul = new UsuarioLogic();

            try
            {
                List<Usuario> usuarios = ul.GetAll();
                var _bind = from u in usuarios
                            select new
                            {
                                Id = u.Id,
                                NombreUsuario = u.NombreUsuario,
                                Nombre = u.Persona.Nombre,
                                Apellido = u.Persona.Apellido,
                                Email = u.Persona.Email.ToString()
                            };
                dgvUsuarios.DataSource = _bind.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            
        }

        private void formUsuarios_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Listar();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            UsuarioDesktop usuarioDesktop = new UsuarioDesktop(ApplicationForm.ModoForm.Alta);
            usuarioDesktop.ShowDialog();
            this.Listar();
        }

        private void TsbModificarUsuario_Click(object sender, EventArgs e)
        {
            if (this.dgvUsuarios.SelectedRows.Count > 0)
            {
                int ID = (int)dgvUsuarios.SelectedRows[0].Cells[0].Value;
                UsuarioDesktop usuarioDesktop = new UsuarioDesktop(ID, ApplicationForm.ModoForm.Modificacion);
                usuarioDesktop.ShowDialog();
            }
            
            this.Listar();
        }

        private void TsbBorrarUsuario_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea eliminar el usuario?", "Borrar Usuario", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (this.dgvUsuarios.SelectedRows.Count > 0)
                {
                    int ID = (int)dgvUsuarios.SelectedRows[0].Cells[0].Value;
                    UsuarioLogic usuarioLogic = new UsuarioLogic();
                    usuarioLogic.Delete(ID);
                }
            }
            this.Listar();
        }

    }
}