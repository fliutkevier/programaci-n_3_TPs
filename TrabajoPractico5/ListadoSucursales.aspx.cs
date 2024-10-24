using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_GRUPO_17
{
    public partial class ListadoSucursales : System.Web.UI.Page
    {
        string consulta = "SELECT Id_Sucursal, NombreSucursal AS NOMBRE, DescripcionSucursal AS DESCRIPCION, DescripcionProvincia AS PROVINCIA, DireccionSucursal AS DIRECCION " +
                "FROM Sucursal JOIN Provincia ON Id_ProvinciaSucursal = Id_Provincia";
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                CargarSucursales();
            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBusquedaSucursal.Text))
            {
                int idSucursal = Convert.ToInt32(txtBusquedaSucursal.Text);
                Datos db = new Datos();

                db.setConsultaDeLectura(consulta + " WHERE Id_Sucursal = @ID_Sucursal");

                db.Comando.Parameters.AddWithValue("@ID_Sucursal", idSucursal);

                SqlDataReader reader = db.Comando.ExecuteReader();
                grdSucursales.DataSource = reader;
                grdSucursales.DataBind();
                db.Cerrar();

            }

        }

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CargarSucursales();
        }

        private void CargarSucursales()
        {
            Datos db = new Datos();

            db.setConsultaDeLectura(consulta);
            SqlDataReader reader = db.Comando.ExecuteReader();
            grdSucursales.DataSource = reader;
            grdSucursales.DataBind();
            db.Cerrar();
        }

    }
}