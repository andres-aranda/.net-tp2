using Academia.Data.Database;
using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common.EntitySql;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Academia.UI.Web
{

    public partial class MiInformacion : System.Web.UI.Page
    {
        private Persona persona;
        int idPersona;
        private usuarios usuario;

        PersonaLogic pl = new PersonaLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
            
                if (Session["idSeleccionado"] != null && (int)Session["idSeleccionado"] != -1)
                {
                    PlanesID.SoloLectura = false;
                    idPersona = (int)Session["idSeleccionado"];
                    Session["esNuevo"] = false;
                    persona = pl.GetOne(idPersona);
                    LoadForm();
                }
                else if (Session["idSeleccionado"] == null)
                {
                    PlanesID.SoloLectura = false;
                    idPersona = ((Usuario)Session["usuarioLogueado"]).Persona.Id;
                    Session["idSeleccionado"] = idPersona;
                    Session["esNuevo"] = false;
                    persona = pl.GetOne(idPersona);
                    LoadForm();
                }
                else
                {
                    txtFechaNac.Enabled = true;
                    txtLegajo.Enabled = true;
                    PlanesID.SoloLectura = true;
                    txtNombreUsua.Text = "No asignado.";
                    txtClave.Enabled = false;
                    repetirClave.Enabled = false;
                    txtClave.Text = "No asignado.";
                    repetirClave.Text = "No asignado.";
                    Session["esNuevo"] = true;
                }
                //Session["idSeleccionado"] = null;
            }

        }

        private void LoadForm()
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                usuario = db.usuarios.Where(x => x.id_persona == persona.Id).First();
                this.txtNombre.Text = this.persona.Nombre;
                this.txtApellido.Text = this.persona.Apellido;
                this.txtEmail.Text = persona.Email.ToString();
                this.txtTelefono.Text = this.persona.Telefono;
                this.txtFechaNac.Text = this.persona.FechaDeNacimiento.ToString("D", CultureInfo.CreateSpecificCulture("es-ES"));
                this.txtLegajo.Text = this.persona.Legajo.ToString();
                this.txtNombreUsua.Text = usuario.nombre_usuario;
                this.txtDireccion.Text = this.persona.Direccion.ToString();
                PlanesID.PlanSeleccionado = persona.IdPlan;
            }

        }


        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            idPersona = (int)Session["idSeleccionado"];
            if (Validar())
            {
                try
                {
                    using (EntidadesTP2 db = new EntidadesTP2())
                    {
                        personas oPersona;
                        if ((bool)Session["esNuevo"])
                        {
                            oPersona = new personas
                            {
                                apellido = txtApellido.Text,
                                nombre = txtNombre.Text,
                                email = txtEmail.Text,
                                telefono = txtTelefono.Text,
                                fecha_nac = DateTime.Parse(txtFechaNac.Text),
                                legajo = int.Parse(txtLegajo.Text),
                                direccion = txtDireccion.Text,
                                id_plan = PlanesID.PlanSeleccionado
                        };
                            db.personas.Add(oPersona);
                        }
                        else
                        {
                            oPersona = db.personas.Find(idPersona);
                            oPersona.nombre = txtNombre.Text;
                            oPersona.apellido = txtApellido.Text;
                            oPersona.email = txtEmail.Text;
                            oPersona.telefono = txtTelefono.Text;
                            oPersona.direccion = txtDireccion.Text;
                            if (CambiaContraseña())
                            {
                                if (txtClave.Text == repetirClave.Text)
                                {
                                    try
                                    {
                                        usuarios oUsuario = db.usuarios.Where(x => x.id_persona == idPersona).First();
                                        oUsuario.clave = txtClave.Text;
                                    }
                                    catch (Exception)
                                    {
                                        MessageBox.Show("El usuario no existe.");
                                    }
                                    
                                }
                            }
                        }
                        db.SaveChanges();
                        System.Windows.Forms.MessageBox.Show("Datos guardados con éxito.");
                    }
                }
                catch (FormatException)
                {
                    MessageBox.Show("Verifique bien los campos.");
                }
                catch (Exception)
                {
                    MessageBox.Show("Hubo un error.");
                }
            }
        }

        private bool CambiaContraseña()
        {
            if (string.IsNullOrWhiteSpace(txtClave.Text) ||
                string.IsNullOrWhiteSpace(repetirClave.Text))
            {
                return false;
            }
            return true;
        }

        private bool Validar()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtApellido.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                string.IsNullOrWhiteSpace(txtFechaNac.Text) ||
                string.IsNullOrWhiteSpace(txtLegajo.Text) ||
                string.IsNullOrWhiteSpace(txtDireccion.Text) 
                //|| PlanesID.PlanSeleccionado == null
                )
            {
                return false;
            }
            return true;
        }
    }
}