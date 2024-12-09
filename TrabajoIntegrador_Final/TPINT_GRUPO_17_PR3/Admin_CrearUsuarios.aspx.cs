using DAO;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_17_PR3
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                if (Request.Cookies["usuarioNombre"] != null)
                {
                    lblUsuario.Text += Request.Cookies["usuarioNombre"].Value;
                }
                cargarUsuarios();

            }
        }

        public void cargarUsuarios()
        {
            NegocioUsuario usuarioNegocio = new NegocioUsuario();
            grdUsuarios.DataSource = usuarioNegocio.obtenerUsuarios();
            grdUsuarios.DataBind();
        }

        protected void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            NegocioUsuario usuarioNegocio = new NegocioUsuario();
            Usuario usuario = new Usuario();
            usuario.Nombre = txtNombreUsuario.Text;
            usuario.Contrasenia = txtContraUsuario.Text;
            usuario.LegajoMedico = txtLegajo.Text;
            
            usuarioNegocio.crearUsuario(usuario);
            limpiarCampos();
            cargarUsuarios();
        }

        public void limpiarCampos()
        {
            txtNombreUsuario.Text = null;
            txtContraUsuario.Text = null;
            txtConfirmarContra.Text = null;
            txtLegajo.Text = null;
        }

        protected void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            NegocioUsuario usuarioNegocio = new NegocioUsuario();
            string nombre = txtBuscarUsuario.Text.Trim();

            if (!string.IsNullOrEmpty(nombre))
            {
                grdUsuarios.DataSource = usuarioNegocio.buscarUsuarioNombre(nombre);
                grdUsuarios.DataBind();
            }
        }
    }
}