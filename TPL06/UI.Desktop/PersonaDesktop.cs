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
        bool PuedeModificar;

        public int IdPersona { get => _idPersona; set => _idPersona = value; }

        public PersonaDesktop()
        {
            IdPersona = -1;
            InitializeComponent();
        }

        public PersonaDesktop(int id, bool puedeModificar)
        {
            IdPersona = id;
            PuedeModificar = puedeModificar;
            InitializeComponent();
        }

        private void PerosnaDesktop_Load(object sender, EventArgs e)
        {
            txtLegajo.Enabled = PuedeModificar;
            cmbPlan.Enabled = PuedeModificar;
            btnAceptar.Visible = PuedeModificar;
            btnCancelar.Visible = PuedeModificar;

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
            bool isLegajoUnico = IdPersona == -1 ? Validations.IsLegajoUnico(int.Parse(txtLegajo.Text)) : true;
            return txtNombre.Text != string.Empty
                && txtApellido.Text != string.Empty
                && txtDireccion.Text != string.Empty
                && txtTelefono.Text != string.Empty
                && Validations.IsValidEmail(txtEmail.Text)
                && isLegajoUnico;
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validar())
                {
                    using (EntidadesTP2 db = new EntidadesTP2())
                    {
                        personas oPersona = new personas();
                        oPersona.nombre = txtNombre.Text;
                        oPersona.apellido = txtApellido.Text;
                        oPersona.direccion = txtDireccion.Text;
                        oPersona.telefono = txtTelefono.Text;
                        oPersona.email = txtEmail.Text;
                        oPersona.legajo = int.Parse(txtLegajo.Text);
                        oPersona.id_plan = (int)cmbPlan.SelectedValue;
                        oPersona.fecha_nac = mcFechaNacimiento.SelectionStart;

                        if (IdPersona == -1)
                        {
                            db.personas.Add(oPersona);
                            MessageBox.Show("Persona agregada con éxito.");
                        }
                        else
                        {
                            oPersona = db.personas.Find(IdPersona);
                            oPersona.nombre = txtNombre.Text;
                            oPersona.apellido = txtApellido.Text;
                            oPersona.direccion = txtDireccion.Text;
                            oPersona.telefono = txtTelefono.Text;
                            oPersona.email = txtEmail.Text;
                            oPersona.legajo = int.Parse(txtLegajo.Text);
                            oPersona.id_plan = (int)cmbPlan.SelectedValue;
                            oPersona.fecha_nac = mcFechaNacimiento.SelectionStart;
                            db.SaveChanges();
                            MessageBox.Show("Persona actualizada con éxito.");
                        }

                        db.SaveChanges();
                        this.Close();
                    }

                }
                else
                    MessageBox.Show("Error en los campos ingresados.");
            }
            catch
            {
                MessageBox.Show("Datos inválidos.");
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
