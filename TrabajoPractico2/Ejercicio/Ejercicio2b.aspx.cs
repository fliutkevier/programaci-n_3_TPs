using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio
{
    public partial class Ejercicio2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          
            String Nombre = Request["txtNombre"].ToString();
            String Apellido = Request["txtApellido"].ToString();
            String ZonaSeleccionada = Request["ddlCiudad"].ToString();
            String Temas = Context.Items["Temas"]?.ToString();

            String Resumen = $"<span style='font-size:20px;'><strong>Resumen</strong></span><br /><br />" +
                                 $"Nombre: <strong>{Nombre}</strong><br />" +
                                 $"Apellido: <strong>{Apellido}</strong><br />" +
                                 $"Zona: <strong>{ZonaSeleccionada}</strong><br /><br />" +
                                 $"Los temas elegidos son:<br /><strong>{Temas}</strong>";

            lblMensaje.Text = Resumen;
        }
    }
}