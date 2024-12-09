using DAO;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_17_PR3
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        private NegocioTurno negocioTurno = new NegocioTurno();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblMensaje.Visible = false; 

            if (!IsPostBack)
            {
                if (Request.Cookies["usuarioNombre"] != null)
                {
                    lblUsuario.Text += Request.Cookies["usuarioNombre"].Value;
                }
                cargarTurnos();
            }
        }

        public void cargarTurnos()
        {
            string legajoMedico = Request.Cookies["medicoLegajo"].Value;        //si no anda es porque no esta logueado
            List<Turno> turnos = negocioTurno.obtenerTurnosPorMedico(legajoMedico);

            grdPacientes.DataSource = turnos;
            grdPacientes.DataBind();
        }

        protected void grdPacientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdPacientes.EditIndex = e.NewEditIndex;
        }

        protected void grdPacientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdPacientes.EditIndex = -1;
            cargarTurnos();
        }

        protected void grdPacientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Turno turno = new Turno();

            Label lbl = (Label)(grdPacientes.Rows[e.RowIndex].FindControl("lbl_eit_Id"));
            turno.Id = Convert.ToInt32(lbl.Text);
            turno.Legajo = ((Label)grdPacientes.Rows[e.RowIndex].FindControl("lbl_eit_Legajo")).Text;
            Label lblDiaHorario= ((Label)grdPacientes.Rows[e.RowIndex].FindControl("lbl_eit_DiaHorario"));
            turno.DiaHorario = Convert.ToDateTime(lblDiaHorario.Text);
            turno.DniPaciente = ((Label)grdPacientes.Rows[e.RowIndex].FindControl("lbl_eit_DniPaciente")).Text;
            turno.Observacion = ((TextBox)grdPacientes.Rows[e.RowIndex].FindControl("txt_eit_Observacion")).Text;

            if(turno.Observacion!= String.Empty)
            {
                turno.Presente = true;

                if (negocioTurno.modificar(turno))
                {
                    grdPacientes.EditIndex = -1;
                    lblMensaje.Visible = true;
                    lblMensaje.ForeColor = Color.Green;
                    lblMensaje.Text = "Turno " + turno.Id + " Actualizado!";
                    
                    cargarTurnos();
                }
            }
            else
            {
                lblMensaje.Visible = true;
                lblMensaje.ForeColor = Color.Red;
                lblMensaje.Text = "Turno " + turno.Id + " no fue actualizado!";
                turno.Presente = false;
                cargarTurnos();
            }

            

        }

        protected void btnBuscarPaciente_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarPaciente.Text.Trim();

            if (!string.IsNullOrEmpty(dni))
            {
                grdPacientes.DataSource = negocioTurno.filtrarTurno(dni);
                grdPacientes.DataBind();
            }
            else
            {
                cargarTurnos();
            }
        }

        protected void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscarPaciente.Text = string.Empty;
            cargarTurnos();
        }

        protected void grdPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdPacientes.PageIndex = e.NewPageIndex;
            cargarTurnos();
        }
    }
}