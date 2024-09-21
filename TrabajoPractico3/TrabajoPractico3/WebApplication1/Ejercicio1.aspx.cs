using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnGuardarLocalidad_Click(object sender, EventArgs e)
        {
            String localidad = txtLocalidad.Text;
            bool existe = false;
            foreach (ListItem localidadCargada in ddlLocalidades.Items)
            {
                if (string.Equals(localidad, localidadCargada.Text))
                {
                    existe = true;
                }
            }
            if (!existe)
            {
                ddlLocalidades.Items.Add(localidad);
                txtLocalidad.Text = "";
            }
        }

        protected void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtLocalidad_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtRepetirContrañseña_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}