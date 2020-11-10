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
        private Persona Entity
        {
            get;
            set;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];
            PersonaLogic pl = new PersonaLogic();
            Entity = pl.GetOne(usuarioLog.Persona.Id);
            LoadForm();
            

        }
        private void LoadForm()
        {
            Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];
            PlanLogic pla = new PlanLogic();
            Plan plan = pla.GetOne(Entity.IdPlan);
            this.txtNombre.Text = this.Entity.Nombre;
            this.txtApellido.Text = this.Entity.Apellido;
            this.txtEmail.Text = usuarioLog.Persona.Email.ToString();
            this.txtTelefono.Text = this.Entity.Telefono;
            this.txtFechaNac.Text = this.Entity.FechaDeNacimiento.ToString();
            this.txtLegajo.Text = this.Entity.Legajo.ToString();
            this.txtNombreUsua.Text = usuarioLog.NombreUsuario;
            this.txtClave.Text = usuarioLog.Clave;
            this.txtDireccion.Text = this.Entity.Direccion.ToString();
            this.txtPlan.Text = plan.Descripcion;
        }
    }
}