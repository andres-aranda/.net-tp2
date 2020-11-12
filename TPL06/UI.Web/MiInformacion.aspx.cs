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

namespace Academia.UI.Web
{

    public partial class MiInformacion : System.Web.UI.Page
    {
        private Persona persona;
        private usuarios usuario;

        PersonaLogic pl = new PersonaLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            int idPersona;
            if (!Page.IsPostBack)
            {
                CargarPlanes();
                if (Session["idSeleccionado"] != null && (int)Session["idSeleccionado"] != -1)
                {
                    idPersona = (int)Session["idSeleccionado"];
                    Session["esNuevo"] = false;
                    persona = pl.GetOne(idPersona);
                    LoadForm();
                }
                else if (Session["idSeleccionado"] == null)
                {
                    idPersona = ((Usuario)Session["usuarioLogueado"]).Persona.Id;
                    Session["esNuevo"] = false;
                    persona = pl.GetOne(idPersona);
                    LoadForm();
                }
                else
                {
                    txtFechaNac.Enabled = true;
                    txtLegajo.Enabled = true;
                    ddlPlanes.Enabled = true;
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
                ddlPlanes.SelectedValue = persona.IdPlan.ToString();
            }

        }

        private void CargarPlanes()
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                List<planes> planes = db.planes.ToList();
                ddlPlanes.DataSource = planes;
                ddlPlanes.DataValueField = "id_plan";
                ddlPlanes.DataTextField = "desc_plan";
                ddlPlanes.DataBind();
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int idPersona = (int)Session["idSeleccionado"];
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
                        id_plan = int.Parse(ddlPlanes.SelectedValue)
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
                }
                db.SaveChanges();
                System.Windows.Forms.MessageBox.Show("Datos guardados con exitos");
            }
            Page.Response.Redirect("~/Personas.aspx");

        }
    }
}