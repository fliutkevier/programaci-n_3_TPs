using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static TP6_GRUPO_17.SeleccionarProductos;

namespace TP6_GRUPO_17
{
    public partial class MostrarProductos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                
                List<Producto> productosSeleccionados = Session["ProductosSeleccionados"] as List<Producto>;

                if (productosSeleccionados != null)
                {
                    grdProductosSeleccionados.DataSource = productosSeleccionados;
                    grdProductosSeleccionados.DataBind();
                }
            }
        }

        
    }
}