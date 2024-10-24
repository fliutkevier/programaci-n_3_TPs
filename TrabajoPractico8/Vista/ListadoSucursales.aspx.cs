using Data;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Vista
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {

        string consulta = "SELECT Id_Sucursal, NombreSucursal AS NOMBRE, DescripcionSucursal AS DESCRIPCION, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCION " +
               "FROM Sucursal JOIN Provincia ON Id_ProvinciaSucursal = Id_Provincia";
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                CargarSucursales();
            }
        }

        private void CargarSucursales()
        {
            Dato db = new Dato();
            db.setConsultaDeLectura(consulta);
            grdSucursales.DataSource = db.getReader();
            grdSucursales.DataBind();
            db.Cerrar();
        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            CargarSucursales();
            txtBusqueda.Text = string.Empty;
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            int id;
            NegocioCategoria neg = new NegocioCategoria();
            if (txtBusqueda.Text != "" && int.TryParse(txtBusqueda.Text, out id) && neg.existe(txtBusqueda.Text))
            {
                String consultaFiltrado = consulta + " WHERE Id_Sucursal = " + txtBusqueda.Text;
                lblMensaje.Text = "";
                txtBusqueda.Text = string.Empty;
                Dato db = new Dato();
                db.setConsultaDeLectura(consultaFiltrado);
                grdSucursales.DataSource = db.getReader();
                grdSucursales.DataBind();
            }
            else
            {
                lblMensaje.Text = "Ingrese un ID valido";
            }
        }
    }
}