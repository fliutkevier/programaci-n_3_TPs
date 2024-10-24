using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_17
{
    public class ProductosSeleccionados
    {
        public ProductosSeleccionados()
        {
            if (HttpContext.Current.Session["ArtsSeleccionados"] == null)
            {
                DataTable dtSeleccionados = new DataTable();
                dtSeleccionados.Columns.Add("ID");
                dtSeleccionados.Columns.Add("Nombre");
                dtSeleccionados.Columns.Add("Cantidad");
                dtSeleccionados.Columns.Add("Precio");

                HttpContext.Current.Session["ArtsSeleccionados"] = dtSeleccionados;
            }
        }

        public DataTable ObtenerProductos()
        {
            return HttpContext.Current.Session["ArtsSeleccionados"] as DataTable;
        }

        public void AgregarProductos(Producto productoAgregado)
        {
            List<Producto> productosSeleccionados = HttpContext.Current.Session["ProductosSeleccionados"] as List<Producto>;
            if (productosSeleccionados == null)
            {
                productosSeleccionados = new List<Producto>();
            }

            productosSeleccionados.Add(productoAgregado);

            HttpContext.Current.Session["ProductosSeleccionados"] = productosSeleccionados;

        }

        public void EliminarProductos()
        {
            HttpContext.Current.Session["ProductosSeleccionados"] = null;
        }
        
    }
}