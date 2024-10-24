using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio
{
    public partial class Ejercicio4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            String usuario = txtUsuario.Text;
            String clave = txtClave.Text;

            if (usuario == "claudio" && clave == "casas")
            {
                Server.Transfer("Ejercicio4b.aspx");
            }
            else
            {
                Server.Transfer("Ejercicio4c.aspx");
            }
        }
    }
}