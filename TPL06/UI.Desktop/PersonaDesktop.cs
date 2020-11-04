using Academia.Data.Database;
using Academia.Util;
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
    public partial class PersonaDesktop : Form
    {
        int _idPersona;

        public int IdPersona { get => _idPersona; set => _idPersona = value; }

        public PersonaDesktop()
        {
            IdPersona = -1;
            InitializeComponent();
        }
        public PersonaDesktop(int id)
        {
            IdPersona = id;
            InitializeComponent();
            
        }

        private void PerosnaDesktop_Load(object sender, EventArgs e)
        {
            Mapeo();
        }

        private void Mapeo()
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                this.cmbPlan.DataSource = db.planes.ToList();
                this.cmbPlan.DisplayMember = "desc_plan";
                this.cmbPlan.ValueMember = "id_plan";

                if (IdPersona != -1)
                {
                    personas per = db.personas.Find(IdPersona);
                    txtNombre.Text = per.nombre;
                    txtApellido.Text = per.apellido;
                    txtDireccion.Text = per.direccion;
                    txtTelefono.Text = per.telefono.ToString();
                    txtEmail.Text = per.email;
                    txtLegajo.Text = per.legajo.ToString();
                    cmbPlan.SelectedValue = per.id_plan;
                    mcFechaNacimiento.SelectionStart = per.fecha_nac;
                }
            }
        }
        private bool Validar()
        {
            return (txtNombre.Text != string.Empty && txtApellido.Text != string.Empty && txtDireccion.Text != string.Empty && txtTelefono.Text != string.Empty && Validations.IsValidEmail(txtEmail.Text) && Validations.IsLegajoUnico(int.Parse(txtLegajo.Text)));
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    using (EntidadesTP2 db = new EntidadesTP2())
                    {
                        personas oPersona = LeerCampos();

                        if (IdPersona == -1)
                        {
                            db.personas.Add(oPersona);
                            MessageBox.Show("Persona agregada con exito");
                        }
                        else
                        {
                            oPersona = db.personas.Find(IdPersona);
                            oPersona = LeerCampos();
                            MessageBox.Show("Persona actualizada con exito");
                        }

                        db.SaveChanges();
                        this.Close();
                    }

                }
                else
                    MessageBox.Show("Ingrese todos los campos");
            }
            catch
            {
                MessageBox.Show("Datos invalidos");
            }

        }

        private personas LeerCampos()
        {
            return new personas
            {
                nombre = txtNombre.Text,
                apellido = txtApellido.Text,
                direccion = txtDireccion.Text,
                telefono = txtTelefono.Text,
                email = txtEmail.Text,
                legajo = int.Parse(txtLegajo.Text),
                id_plan = (int)cmbPlan.SelectedValue,
                fecha_nac = mcFechaNacimiento.SelectionStart
            };
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
