using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_17
{
    public partial class SeleccionarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            CargarProductos();
        }

        private void CargarProductos()
        {
            Datos db = new Datos();
            string consulta = $@"SELECT IdProducto, NombreProducto, IdProveedor, PrecioUnidad FROM productos";
            db.setConsultaDeLectura(consulta);
            DataTable tabla = new DataTable();

            tabla.Load(db.getConsultaDeLectura());

            grdProductos.DataSource = tabla;
            grdProductos.DataBind();

            db.Cerrar();
        }
       
        protected void grdProductos_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            
            GridViewRow filaSeleccionada = grdProductos.Rows[e.NewSelectedIndex];
            
            string idProducto = ((Label)filaSeleccionada.FindControl("lbl_it_IdProducto")).Text;
            string nombreProducto = ((Label)filaSeleccionada.FindControl("lbl_it_NombreProducto")).Text;
            string proveedorProducto = ((Label)filaSeleccionada.FindControl("lbl_it_IdProveedor")).Text;
            string precioProducto = ((Label)filaSeleccionada.FindControl("lbl_it_PrecioUnitario")).Text;

            Producto nuevoProducto = new Producto
            {
                IdProducto = idProducto,
                NombreProducto = nombreProducto,
                Proveedor = proveedorProducto,
                Precio = precioProducto
            };

            ProductosSeleccionados Productos = new ProductosSeleccionados();

            Productos.AgregarProductos(nuevoProducto);

            lblProductoSeleccionado.Text = $"Producto agregados: {nombreProducto}";
        }

    }
}