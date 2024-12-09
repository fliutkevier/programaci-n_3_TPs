using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_17_PR3
{
    public partial class Admin_main : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["usuarioNombre"] != null)
                {
                    lblBienvenida.Text += Request.Cookies["usuarioNombre"].Value;
                }
            }
        }

        protected void btnPacientes_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Pacientes.aspx");
        }

        protected void btnMedicos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Medicos.aspx");
        }

        protected void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            HttpContext.Current.Session["usuarioNombre"] = null;
            Response.Redirect("Login.aspx");
        }

        protected void btnInforme_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_Informes.aspx");
        }

        protected void btnTurnos_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_AsignacionTurnos.aspx");

        }
    }
}