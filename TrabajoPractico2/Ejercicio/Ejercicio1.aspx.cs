using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGenerarTabla_Click(object sender, EventArgs e)
        {
            String producto = txtProducto1.Text;
            String producto2 = txtProducto2.Text;
            int numero = int.Parse(txtCantidad1.Text);
            int numero2 = int.Parse(txtCantidad2.Text);

            String tabla = "<table border='1'>";
            tabla += "<tr><th>Producto</th><th>Resultado</th></tr>";

            tabla += "<tr>";
            tabla += "<td>" + producto + "</td>";
            tabla += "<td>" + numero + "</td>";
            tabla += "</tr>";

            tabla += "<tr>";
            tabla += "<td>" + producto2 + "</td>";
            tabla += "<td>" + numero2 + "</td>";
            tabla += "</tr>";

            tabla += "<tr>";
            tabla += "<td>" + "TOTAL" + "</td>";
            tabla += "<td>" + (numero + numero2) + "</td>";
            tabla += "</tr>";
            tabla += "</table>"; 

            lblTablaPxC.Text = tabla;
        }
    }
}