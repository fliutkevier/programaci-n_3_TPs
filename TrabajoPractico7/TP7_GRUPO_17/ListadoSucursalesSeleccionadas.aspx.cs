using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TP7_GRUPO_17;

namespace TP7_GRUPO_17
{
    public partial class ListadoSucursalesSeleccionadas : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SucursalesSeleccionadas sucursalesSeleccionadas = new SucursalesSeleccionadas();
                
                List<Sucursal> sucursales = HttpContext.Current.Session[sucursalesSeleccionadas.session] as List<Sucursal>;

                
                if (sucursales != null)
                {
                
                    grdSucursales.DataSource = sucursales;
                    grdSucursales.DataBind(); 
                }
            }
        }
    }
}