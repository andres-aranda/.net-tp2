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
            this.lblUsuarioLogeado.Text = "Bienbenido " + usuarioLog.Nombre + " ";
            //foreach (Modulo m in usuarioLog.Modulo)
            //{
            //    if (m.Descripcion == "Alumno" || m.Descripcion == "Administrador")
            //        Menu1.Items.Add( new MenuItem("")) ;
            //    if (m.Descripcion == "Docente" || m.Descripcion == "Administrador")
            //        btnComisiones.Visible = true;
            //    if (m.Descripcion == "NoDocente" || m.Descripcion == "Administrador")
            //        btnUsuarios.Visible = true;

            //}
        }

    }
}