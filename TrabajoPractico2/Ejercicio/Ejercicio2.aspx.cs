using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnResumen_Click(object sender, EventArgs e)
        {
            String temasSeleccionados = String.Join("<br />", cblTemas.Items.Cast<ListItem>().Where(li => li.Selected).Select(li => li.Text));
            Context.Items["Temas"] = temasSeleccionados;
            Server.Transfer("Ejercicio2b.aspx");
        }
    }
}