using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio
{
    public partial class Ejercicio3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkColorRojo_Click(object sender, EventArgs e)
        {
            lblTextoColoreado.ForeColor = Color.Red;
        }

        protected void lnkColorAzul_Click(object sender, EventArgs e)
        {
            lblTextoColoreado.ForeColor = Color.Blue;
        }

        protected void lnkColorVerde_Click(object sender, EventArgs e)
        {
            lblTextoColoreado.ForeColor = Color.Green;
        }
    }
}