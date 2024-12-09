using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_17_PR3
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["usuarioNombre"] != null)
                {
                    lblUsuario.Text += Request.Cookies["usuarioNombre"].Value;
                }
            }
        }

        public void cargarPresentes()
        {
            NegocioInforme negocioInforme = new NegocioInforme();
            DateTime fechaInicio, fechaFin;
            fechaInicio = Convert.ToDateTime(txtDesde.Text);
            fechaFin = Convert.ToDateTime(txtHasta.Text);
            grdPresentes.DataSource = negocioInforme.obtenerPresentes(fechaInicio, fechaFin);
            grdPresentes.DataBind();
        }

        public void cargarAusentes()
        {
            NegocioInforme negocioInforme = new NegocioInforme();
            DateTime fechaInicio, fechaFin;
            fechaInicio = Convert.ToDateTime(txtDesde.Text);
            fechaFin = Convert.ToDateTime(txtHasta.Text);
            grdAusentes.DataSource =  negocioInforme.obtenerAusentes(fechaInicio, fechaFin);
            grdAusentes.DataBind();

        }

        protected void btnGenerarInforme_Click(object sender, EventArgs e)
        {
            NegocioInforme negocioInforme = new NegocioInforme();
            DateTime fechaInicio, fechaFin;
            fechaInicio = Convert.ToDateTime(txtDesde.Text);
            fechaFin = Convert.ToDateTime(txtHasta.Text);
            if (fechaFin > fechaInicio)
            {
                lblTotPac.Text = Convert.ToString(negocioInforme.totalPacientes(fechaInicio, fechaFin));
                lblCantPresentes.Text = Convert.ToString(negocioInforme.totalPresentes(fechaInicio, fechaFin));
                lblCantAus.Text = Convert.ToString(negocioInforme.totalAusentes(fechaInicio, fechaFin));
                lblPorcPresentes.Text = Convert.ToString(negocioInforme.porcPresentes(fechaInicio, fechaFin)) + '%';
                lblPorcAus.Text = Convert.ToString(negocioInforme.porcAusentes(fechaInicio, fechaFin)) + '%';
                cargarPresentes();
                cargarAusentes();
            }
        }
    }
}