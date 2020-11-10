using Academia.Data.Database;
using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.Web
{
    // TODO: Ver Boton guardar y replicar css del amb en los otros
    public partial class MiInformacion : System.Web.UI.Page
    {
        private Persona Entity;

        protected void Page_Load(object sender, EventArgs e)
        {
            int idPersona;
            if (Session["idSeleccionado"] != null)
            {
                idPersona = (int)Session["idSeleccionado"];
            }
            else
            {
                idPersona = ((Usuario)Session["usuarioLogueado"]).Persona.Id;
            }
            PersonaLogic pl = new PersonaLogic();
            Entity = pl.GetOne(idPersona);
            LoadForm();
            Session["idSeleccionado"] = null;
        }
        private void LoadForm()
        {
            using (EntidadesTP2 db = new EntidadesTP2())
            {
                usuarios u = db.usuarios.Where(x => x.id_persona == Entity.Id).First();
                this.txtNombre.Text = this.Entity.Nombre;
                this.txtApellido.Text = this.Entity.Apellido;
                this.txtEmail.Text = Entity.Email.ToString();
                this.txtTelefono.Text = this.Entity.Telefono;
                this.txtFechaNac.Text = this.Entity.FechaDeNacimiento.ToString();
                this.txtLegajo.Text = this.Entity.Legajo.ToString();
                this.txtNombreUsua.Text = u.nombre_usuario;
                this.txtDireccion.Text = this.Entity.Direccion.ToString();
            }
            
        }
    }
}