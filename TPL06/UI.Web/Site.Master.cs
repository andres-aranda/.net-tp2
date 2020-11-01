using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Academia.Util;

namespace Academia.UI.Web
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];
            if (usuarioLog == null)
            {
                Page.Response.Redirect("~/Login.aspx");
            }
            this.gestionAcademica.Visible = false;
            this.gestionAlumno.Visible = false;
            this.alumno.Visible = false;
            this.gestionDocente.Visible = false;
            this.docente.Visible = false;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "printHello();", true);
        
            this.lblUsuarioLogeado.Text =  Validations.Greeting() + usuarioLog.Persona.Nombre;

            foreach (Modulo m in usuarioLog.Modulo)
            {
                if (m.Descripcion == "Alumno" )
                    this.alumno.Visible = true;
                if (m.Descripcion == "Docente" )
                    this.docente.Visible = true;
                if (m.Descripcion == "NoDocente" || m.Descripcion == "Administrador")
                {
                    this.gestionAcademica.Visible = true;
                    this.gestionAlumno.Visible = true;
                    this.gestionDocente.Visible = true;
                }
            }
        }

        protected void LogOut_ServerClick(object sender, EventArgs e)
        {
            Session.Clear();
            Page.Response.Redirect("~/Login.aspx");
        }
    }
}