using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_17_PR3
{
    public partial class frmLogin : System.Web.UI.Page
    {
        NegocioUsuario usuarioNegocio = new NegocioUsuario();
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombreUsuario = txtUsuario.Text; ;
            string contrasenia = txtContrasenia.Text;

            Usuario usuario = usuarioNegocio.AutenticarUsuario(nombreUsuario, contrasenia);

            if (usuario != null)
            {
                HttpCookie cookie = new HttpCookie("usuarioNombre", usuario.Nombre);
                cookie.Expires = DateTime.Now.AddHours(6);
                this.Response.Cookies.Add(cookie);

                if (usuario.Tipo == 'A')
                {
                    Response.Redirect("Admin_main.aspx");
                }
                else
                {
                    if (!string.IsNullOrEmpty(usuario.LegajoMedico))
                    {
                        HttpCookie legajoCookie = new HttpCookie("medicoLegajo", usuario.LegajoMedico);
                        legajoCookie.Expires = DateTime.Now.AddHours(6);
                        this.Response.Cookies.Add(legajoCookie);
                        Response.Redirect("Medico_main.aspx");
                    }
                }
            }
            else
            {
                lblNoUsuario.Visible = true;
            }
        }
    }
}