using DAO;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_17_PR3
{
    public partial class Admin_CargarMedico : System.Web.UI.Page
    {
        NegocioMedico negocioMedico = new NegocioMedico();

        NegocioProvincia negocioProvincia = new NegocioProvincia();

        NegocioLocalidad negocioLocalidad = new NegocioLocalidad();

        NegocioNacionalidad negocioNacionalidad = new NegocioNacionalidad();

        NegocioEspecialidad negocioEspecialidad = new NegocioEspecialidad();

        NegocioHorariosMedicos negocioHorarios = new NegocioHorariosMedicos();

        NegocioDiasHorariosMedicos negocioDias = new NegocioDiasHorariosMedicos();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblValidacionLegajo.Visible = false;
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            if (!IsPostBack)
            {
                cargarDDLS();
                if (Request.Cookies["usuarioNombre"] != null)
                {
                    lblUsuario.Text += Request.Cookies["usuarioNombre"].Value;
                    
                }


            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            Medico medico = new Medico();

            medico.Legajo = txtLegajo.Text;
            if (negocioMedico.buscarMedicoPorLegajo(medico.Legajo) != null)
            {
                lblValidacionLegajo.Text = "Legajo ya existente";
                lblValidacionLegajo.Visible = true;
                limpiarCampos();
                return;
            }

            medico.Dni = txtDni.Text;
            medico.Nombre = txtNombre.Text.Trim();
            medico.Apellido = txtApellido.Text.Trim();
            medico.Sexo = Convert.ToChar(rbtnSexo.SelectedValue);
            medico.Nacimiento = Convert.ToDateTime(txtFechaNacimiento.Text); 
            medico.CorreoElectronico = txtCorreoElectronico.Text.Trim();
            medico.Telefono = txtTelefono.Text.Trim();
            medico.Direccion = txtDireccion.Text.Trim();
            medico.Estado = true;
            medico.Localidad = negocioLocalidad.buscarLocalidad(Convert.ToInt32(ddlLocalidad.SelectedValue));
            medico.Provincia = negocioProvincia.buscarProvincia(Convert.ToInt32(ddlProvincia.SelectedValue));
            medico.Especialidad = negocioEspecialidad.buscarEspecialidad(Convert.ToInt32(ddlEspecialidad.SelectedValue));
            medico.Nacionalidad = negocioNacionalidad.buscarNacionalidad(Convert.ToInt32(ddlNacionalidad.SelectedValue));

            bool carga = negocioMedico.cargarMedico(medico);

            if (carga)
            {
                lblMensaje.Text = "Se agrego a la base de datos con exito";
            }
            else
            {
                lblMensaje.Text = "Error al cargar. Intente nuevamente";
            }

            ///Carga del horario para que se genere el id y se pueda cargar el dia sobre el mismo.
            HorariosMedicos horario = new HorariosMedicos();

            horario.LegajoMedico = txtLegajo.Text.Trim();
            string horarioSeleccionado = ddlHorarios.SelectedValue;
            string[] partes = horarioSeleccionado.Split('-');   // Divide "06:00-14:00" en ["06:00", "14:00"]
            horario.HoraInicio = TimeSpan.Parse(partes[0]);    // "06:00"
            horario.HoraFin = TimeSpan.Parse(partes[1]);        // "14:00"

            negocioHorarios.cargarHorario(horario);

            ///Carga de los dias

            DiasHorariosMedicos Dias = new DiasHorariosMedicos();

            foreach (ListItem item in cblDias.Items)
            {
                if (item.Selected)
                {
                    Dias.Id_hor = negocioHorarios.buscarUltimoID();
                    Dias.Dia = char.Parse(item.Value);
                    negocioDias.cargarDias(Dias);
                }
            }

            limpiarCampos();
        }



        public void limpiarCampos()
        {
            txtDni.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            rbtnSexo.ClearSelection();
            txtFechaNacimiento.Text = Convert.ToString(DateTime.Today);
            txtCorreoElectronico.Text = null;
            txtTelefono.Text = null;
            txtDireccion.Text = null;
            ddlProvincia.SelectedIndex = 0;
            ddlLocalidad.SelectedIndex = 0;
            ddlNacionalidad.SelectedIndex = 0;
            ddlEspecialidad.SelectedIndex = 0;
            ddlHorarios.SelectedIndex = 0;
            cblDias.ClearSelection();

        }

        public void cargarDDLS()
        {
            ///CARGA DDL PROVINCIA
            List<Provincia> provincias = negocioProvincia.obtenerTodos();
            ddlProvincia.DataSource = provincias;
            ddlProvincia.DataTextField = "Nombre";
            ddlProvincia.DataValueField = "Id";
            ddlProvincia.DataBind();
            ddlProvincia.Items.Insert(0, new ListItem("Seleccione una provincia", "0")); // Opción inicial

            //CARGA DDL LOCALIDAD
            List<Localidad> localidades = negocioLocalidad.obtenerTodos();
            ddlLocalidad.DataSource = localidades;
            ddlLocalidad.DataTextField = "Nombre";
            ddlLocalidad.DataValueField = "Id";
            ddlLocalidad.DataBind();
            ddlLocalidad.Items.Insert(0, new ListItem("Seleccione una localidad", "0")); // Opción inicial
            ///SE HACE AUTOMATICAMENTE DEPENDIENDO DEL ID DE PROVINCIA SELECCIONADO

            ///CARGA DDL NACIONALIDAD
            List<Nacionalidad> nacionalidades = negocioNacionalidad.obtenerTodos();
            ddlNacionalidad.DataSource = nacionalidades;
            ddlNacionalidad.DataTextField = "Nombre";
            ddlNacionalidad.DataValueField = "Id";
            ddlNacionalidad.DataBind();
            ddlNacionalidad.Items.Insert(0, new ListItem("Seleccione la nacionalidad", "0")); // Opción inicial

            ///
            ///CARGA DDL ESPECIALIDAD
            List<Especialidad> especialidades = negocioEspecialidad.obtenerTodos();
            ddlEspecialidad.DataSource = especialidades;
            ddlEspecialidad.DataTextField = "Descripcion";
            ddlEspecialidad.DataValueField = "Id";
            ddlEspecialidad.DataBind();
            ddlEspecialidad.Items.Insert(0, new ListItem("Seleccione la especialidad", "0")); // Opción inicial

            ///CARGA DDL HORARIOS
            ddlHorarios.Items.Insert(0, new ListItem("Seleccione el horario", "0")); //Opcion inicial
            ddlHorarios.Items.Insert(1, new ListItem("6:00 - 14:00", "06:00-14:00"));
            ddlHorarios.Items.Insert(2, new ListItem("14:00 - 22:00", "14:00-22:00"));
            ddlHorarios.Items.Insert(3, new ListItem("22:00 - 6:00", "22:00-6:00"));
        }
        

        protected void ddlProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Localidad> localidades = negocioLocalidad.buscarLocalidadesXProvincia(Convert.ToInt32(ddlProvincia.SelectedValue));
            ddlLocalidad.DataSource = localidades;
            ddlLocalidad.DataTextField = "Nombre";
            ddlLocalidad.DataValueField = "Id";
            ddlLocalidad.DataBind();
        }
    }
}