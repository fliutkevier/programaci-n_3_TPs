﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ejercicio
{
    public partial class Ejercicio4c : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensaje.Text = $"<span style='font-size:20px; font-weight:bold;'>USUARIO INVALIDO INGRESO NO PERMITIDO</span>";
        }
    }
}