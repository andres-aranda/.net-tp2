using Business.Entities;
using Business.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Academia.UI.Web
{
    public partial class EspecialidadForm : System.Web.UI.Page
    {
        EspecialidadLogic el = new EspecialidadLogic();

        protected void Page_Load(object sender, EventArgs e)
        {
            Usuario usuario = (Usuario)Session["usuarioLogueado"];
            if (usuario == null)
            {
                Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            foreach (Modulo m in usuario.Modulo)
            {
                if (!(m.Descripcion == "NoDocente" || m.Descripcion == "Administrador"))
                    Page.Response.Redirect("~/PaginaNoPermitida.aspx");
            }
            if (!Page.IsPostBack)
            {
                int idEspecialidad = (int)Session["idSeleccionado"];
                if (idEspecialidad != -1)
                {
                    Especialidad especialidad = el.GetOne(idEspecialidad);
                    txtEspecialidad.Text = especialidad.Descripcion;
                }
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            int idEspecialidad = (int)Session["idSeleccionado"];
            Especialidad especialidad = new Especialidad
            {
                Descripcion = txtEspecialidad.Text,
            };
            if (idEspecialidad == -1)
            {
                especialidad.State = BusinessEntity.Estados.New;
            }
            else
            {
                especialidad.Id = idEspecialidad;
                especialidad.State = BusinessEntity.Estados.Modified;
            }
            el.Save(especialidad);
        }
    }
}