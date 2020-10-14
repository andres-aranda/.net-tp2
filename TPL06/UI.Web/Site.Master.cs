using Business.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.Web
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];
            this.gestionAcademica.Visible = false;
            this.gestionAlumno.Visible = false;
            this.gestionDocente.Visible = false;
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "printHello();", true);
            this.lblUsuarioLogeado.Text = "Bienvenido " + usuarioLog.Nombre + " ";
            foreach (Modulo m in usuarioLog.Modulo)
            {
                if (m.Descripcion == "Alumno" || m.Descripcion == "Administrador")
                    this.gestionAlumno.Visible = true;
                if (m.Descripcion == "Docente" || m.Descripcion == "Administrador")
                    this.gestionDocente.Visible = true;
                if (m.Descripcion == "No docente" || m.Descripcion == "Administrador")
                    this.gestionAcademica.Visible = true;
            }
        }

    }
}