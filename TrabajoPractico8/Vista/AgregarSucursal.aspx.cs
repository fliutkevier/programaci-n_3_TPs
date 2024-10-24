using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP8_GRUPO_17
{
    public partial class AgregarSucursal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                ProvinciaNegocio provinciaNegocio = new ProvinciaNegocio();
                ddlProvincias.DataSource = provinciaNegocio.GetProvincias();
                ddlProvincias.DataTextField = "Descripcion";
                ddlProvincias.DataValueField = "Id";
                ddlProvincias.DataBind();

                ddlProvincias.Items.Insert(0, new ListItem("-- Seleccione Provincia --", "0"));

            }
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            NegocioCategoria negocioCategoria = new NegocioCategoria();
            Sucursal NuevaSucursal = new Sucursal();

            NuevaSucursal.Nombre = txtNombreSucursal.Text;
            NuevaSucursal.Descripcion = txtDescripcion.Text;
            NuevaSucursal.IdProvincia = Convert.ToInt32(ddlProvincias.SelectedValue);
            NuevaSucursal.Direccion = txtDireccion.Text;
            negocioCategoria.insertarSucursal(NuevaSucursal);

            lblMensaje.Text = "La sucursal se ha agregado con éxito";

            txtNombreSucursal.Text = string.Empty;
            txtDescripcion.Text = string.Empty;
            txtDireccion.Text = string.Empty;
            ddlProvincias.SelectedIndex = 0;
            ddlProvincias.SelectedIndex = 0;

        }
    }
}