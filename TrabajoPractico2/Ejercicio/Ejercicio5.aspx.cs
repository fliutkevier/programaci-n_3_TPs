using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void CheckBoxList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
          
                 decimal memoriaSeleccionada = Convert.ToDecimal(ddlMemoria.SelectedValue);
                 decimal accesoriosSeleccionados = cblAccesorios.Items.Cast<ListItem>().Where(li => li.Selected).Sum(li => Convert.ToDecimal(li.Value));

                 decimal precioFinal = memoriaSeleccionada + accesoriosSeleccionados;

                 lblMensaje.Text = $"<strong>El precio final es: {precioFinal:C}</strong>";

        }
    }
}