using DAO;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_17_PR3
{
    public partial class Admin_AsignacionTurnos : System.Web.UI.Page
    {
        Dictionary<string, DayOfWeek> diasSemana = new Dictionary<string, DayOfWeek>
        {
            { "L", DayOfWeek.Monday },
            { "M", DayOfWeek.Tuesday },
            { "X", DayOfWeek.Wednesday },
            { "J", DayOfWeek.Thursday },
            { "V", DayOfWeek.Friday },
            { "S", DayOfWeek.Saturday },
            { "D", DayOfWeek.Sunday }
        };

        //permite que persista el valor a pesar de los postback.
        List<DayOfWeek> diasLaborales
        {
            get
            {
                return Session["DiasLaborales"] as List<DayOfWeek> ?? new List<DayOfWeek>();
            }
            set
            {
                Session["DiasLaborales"] = value;
            }
        }


        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            if (!IsPostBack)
            {
                if (Request.Cookies["usuarioNombre"] != null)
                {
                    lblUsuario.Text += Request.Cookies["usuarioNombre"].Value;
                }
                cargarEspecialidades();
                ddlHorarios.Enabled = false;
            }
        }

        public void cargarEspecialidades()
        {
            NegocioEspecialidad negocioEspecialidad = new NegocioEspecialidad();
            List<Especialidad> especialidades = negocioEspecialidad.obtenerTodos();
            ddlEspecialidad.DataSource = especialidades;
            ddlEspecialidad.DataTextField = "Descripcion";
            ddlEspecialidad.DataValueField = "Id";
            ddlEspecialidad.DataBind();
            ddlEspecialidad.Items.Insert(0, new ListItem("Seleccione una Especialidad", "0"));
        }

        protected void ddlEspecialidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            NegocioMedico negocioMedico = new NegocioMedico();
            List<Medico> medicos = negocioMedico.ObtenerXEspecialidad(Convert.ToInt32(ddlEspecialidad.SelectedValue));
            ddlMedicos.DataSource = medicos;
            ddlMedicos.DataTextField = "Nombre";
            ddlMedicos.DataValueField = "Legajo";
            ddlMedicos.DataBind();
            ddlMedicos.Items.Insert(0, new ListItem("Seleccione un Medico", "0"));
            lblAsignado.Visible = false;
        }

        protected void ddlMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {
            NegocioDiasHorariosMedicos negocioDias = new NegocioDiasHorariosMedicos();
            string[] diasTrabajados = negocioDias.buscarDiasXLegajo(ddlMedicos.SelectedValue).Select(dia => dia.Dia.ToString()).ToArray();

            diasLaborales = diasTrabajados
                .Where(dia => diasSemana.ContainsKey(dia))
                .Select(dia => diasSemana[dia])
                .ToList();
            lblAsignado.Visible = false;
        }

        protected void Calendar_DayRender(object sender, DayRenderEventArgs e)
        {
            if (diasLaborales.Contains(e.Day.Date.DayOfWeek))
            {
                e.Cell.BackColor = System.Drawing.Color.LightGreen;
                e.Cell.Font.Bold = true;
            }
        }

        protected void Calendar_SelectionChanged(object sender, EventArgs e)
        {
            DateTime diaSeleccionado = calendario.SelectedDate;
            lblAsignado.Visible = false;

            if (diasLaborales.Contains(diaSeleccionado.DayOfWeek))
            {
                lblVerifDia.Visible = false;
                ddlHorarios.Enabled = true;

                string legajo = ddlMedicos.SelectedValue;
                NegocioHorariosMedicos negocioHorariosMedicos = new NegocioHorariosMedicos();
                List<TimeSpan> horarios = negocioHorariosMedicos.obtenerXLegajo(legajo);

                NegocioTurno negocioTurno = new NegocioTurno();
                List<TimeSpan> horasDisponibles = negocioTurno.obtenerHorariosDisponibles(legajo, diaSeleccionado, horarios);


                ddlHorarios.DataSource = horasDisponibles;
                ddlHorarios.DataBind();
                ddlHorarios.Items.Insert(0, new ListItem("Seleccione un horario", "0"));
            }
            else
            {
                ddlHorarios.Enabled = false;
            }
            
        }

        protected void btnAsignar_Click(object sender, EventArgs e)
        {
            Turno turnoAsignado = new Turno();

            turnoAsignado.DniPaciente = txtDniPaciente.Text.Trim();

            if (ddlHorarios.Enabled)
            {   
                lblVerifDia.Visible = false;
                DateTime turnoHorario = new DateTime();
                turnoHorario = calendario.SelectedDate.Date;
                TimeSpan hora = TimeSpan.Parse(ddlHorarios.SelectedValue);
                turnoHorario = turnoHorario.Add(hora);

                turnoAsignado.Legajo = ddlMedicos.SelectedValue;
                turnoAsignado.DiaHorario = turnoHorario;
                turnoAsignado.Observacion = "Esperando Observacion...";
                turnoAsignado.Presente = false;

                NegocioPaciente negocioPaciente = new NegocioPaciente();
                if (negocioPaciente.buscarPacienteXDNI(turnoAsignado.DniPaciente) != null)
                {
                    NegocioTurno negocioTurno = new NegocioTurno();
                    if (negocioTurno.cargarTurno(turnoAsignado))
                    {
                        txtDniPaciente.Text = string.Empty;
                        calendario.SelectedDate = DateTime.Today;
                        ddlHorarios.SelectedIndex = 0;
                        ddlMedicos.SelectedIndex = 0;
                        ddlEspecialidad.SelectedIndex = 0;
                        ddlHorarios.Enabled = false;
                        lblAsignado.Visible = true;
                    }
                }
            }
            else
            {
                lblVerifDia.Visible = true;
            }
        }
    }

}