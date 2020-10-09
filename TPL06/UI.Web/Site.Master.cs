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
            
            this.menuArchivo.Visible = false;
            this.gestionAcademica.Visible = false;
            this.gestionAlumno.Visible = false;
            this.gestionDocente.Visible = false;
            Usuario usuarioLog = (Usuario)Session["usuarioLogueado"];
            ScriptManager.RegisterStartupScript(this, this.GetType(), "alert", "printHello();", true);
            this.lblUsuarioLogeado.Text = "Bienvenido " + usuarioLog.Nombre + " ";
            foreach (Modulo m in usuarioLog.Modulo)
            {
                if ((m.Descripcion == "NoDocente") || (m.Descripcion == "Administrador"))
                this.menuArchivo.Visible = true; //ESTO FUNCIONA
                
            //    if (m.Descripcion == "Docente" || m.Descripcion == "Administrador")
            //        btnComisiones.Visible = true;
            //    if (m.Descripcion == "NoDocente" || m.Descripcion == "Administrador")
            //        btnUsuarios.Visible = true;

            }
        }

    }
}