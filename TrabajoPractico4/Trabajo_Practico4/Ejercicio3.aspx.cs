using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Trabajo_Practico4
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void lnkVerLibros_Click(object sender, EventArgs e)
        {
            if (ddlTemas.SelectedIndex != 0)
            {
                lblError.Text = "";
                int temaSeleccionado = Convert.ToInt32(ddlTemas.SelectedValue);
                Context.Items["TemaSeleccionado"] = temaSeleccionado;
                Server.Transfer("Ejercicio3b.aspx");
            }
            else
            {
                lblError.Text = "Por favor, seleccione un tema";
            }
        }
    }
}