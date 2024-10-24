using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_17
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        private ProductosSeleccionados productosSeleccionados;
        protected void Page_Load(object sender, EventArgs e)
        {
            productosSeleccionados = new ProductosSeleccionados();
        }

        protected void lkbEliminarProductos_Click(object sender, EventArgs e)
        {
            productosSeleccionados.EliminarProductos();
        }
    }
}