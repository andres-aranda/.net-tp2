using Academia.Data.Database;
using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.Web
{
    // TODO: Ver Boton guardar y replicar css del amb en los otros
    public partial class MiInformacion : System.Web.UI.Page
    {
        private Persona persona;
        private usuarios usuario;
        private int modoForm; // 0: Nuevo, 1: Editar

        PersonaLogic pl = new PersonaLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            int idPersona;
            // modoForm = (int)Session["modoForm"];
            if (Session["idSeleccionado"] != null)
            {
                idPersona = (int)Session["idSeleccionado"];
            }
            else
            {
                idPersona = ((Usuario)Session["usuarioLogueado"]).Persona.Id;
            }
            
            persona = pl.GetOne(idPersona);
            if (!Page.IsPostBack)
            {
                LoadForm();
            }
            Session["idSeleccionado"] = null;
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
            }
            
        }

        protected void NuevoLinkButton_Click(object sender, EventArgs e)
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                personas oPersona = db.personas.Find(persona.Id);
                oPersona.nombre = txtNombre.Text;
                oPersona.apellido = txtApellido.Text;
                oPersona.email = txtEmail.Text;
                oPersona.telefono = txtTelefono.Text;
                oPersona.fecha_nac = DateTime.Parse(txtFechaNac.Text);
                oPersona.direccion = txtDireccion.Text;
            }
        }
    }
}