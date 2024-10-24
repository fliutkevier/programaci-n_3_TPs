using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio
{
    public partial class Ejercicio4b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            lblMensaje.Text = $"<span style='font-size:20px; font-weight:bold;'>Bienvenido a mi pagina Sr./a Claudio</span>";
        }
    }
}