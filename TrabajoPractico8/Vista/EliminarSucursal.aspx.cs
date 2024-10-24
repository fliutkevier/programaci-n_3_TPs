using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class EliminarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            NegocioCategoria negocioCategoria = new NegocioCategoria();

            int idSucursal;
            if (int.TryParse(txtEliminarSucursal.Text, out idSucursal))
            {
                if (negocioCategoria.eliminarSucursal(idSucursal))
                {
                    lblMensaje.Text = "La sucursal ha sido eliminada con éxito.";
                    txtEliminarSucursal.Text = string.Empty;
                }
                else
                {
                    lblMensaje.Text = "Error al eliminar la sucursal.";
                }
            }
            else
            {
                lblMensaje.Text = "Ingrese un ID válido.";
            }
        }
    }
}
