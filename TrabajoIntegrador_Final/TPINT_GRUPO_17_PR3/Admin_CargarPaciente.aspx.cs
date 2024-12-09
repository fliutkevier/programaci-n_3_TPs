using DAO;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Serialization;

namespace TPINT_GRUPO_17_PR3
{
    public partial class Admin_CargarPaciente : System.Web.UI.Page
    {
        NegocioPaciente negocioPaciente = new NegocioPaciente();
        NegocioProvincia negocioProvincia = new NegocioProvincia();

        NegocioLocalidad negocioLocalidad = new NegocioLocalidad(); 

        NegocioNacionalidad negocioNacionalidad = new NegocioNacionalidad();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            lblValidacionDNI.Visible = false;
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

            Paciente paciente = new Paciente();


            paciente.Dni = txtDni.Text.Trim();

            
            if (negocioPaciente.buscarPacienteXDNI(paciente.Dni) != null)
            {
                lblValidacionDNI.Text = "Dni ya existente";
                lblValidacionDNI.Visible = true;
                limpiarCampos();
                return;
            }

            paciente.Nombre = txtNombre.Text.Trim();



            paciente.Apellido = txtApellido.Text.Trim();
            paciente.Sexo = Convert.ToChar(rbtnSexo.SelectedValue);
            paciente.Nacimiento = Convert.ToDateTime(txtFechaNacimiento.Text);
            paciente.CorreoElectronico = txtCorreoElectronico.Text.Trim(); 
            paciente.Telefono = txtTelefono.Text.Trim();
            paciente.Direccion = txtDireccion.Text.Trim();
            paciente.Provincia = negocioProvincia.buscarProvincia(Convert.ToInt32(ddlProvincia.SelectedValue));
            paciente.Localidad = negocioLocalidad.buscarLocalidad(Convert.ToInt32(ddlLocalidad.SelectedValue));
            paciente.Estado = true;
            paciente.Nacionalidad = negocioNacionalidad.buscarNacionalidad(Convert.ToInt32(ddlNacionalidad.SelectedValue));
            
            bool carga = negocioPaciente.cargarPaciente(paciente);
            if (carga)
            {
                lblMensaje.Text = "Se agrego a la base de datos con exito";
            }
            else
            {
                lblMensaje.Text = "Error al cargar. Intente nuevamente";
            }
            limpiarCampos();

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

            ///CARGA DDL LOCALIDAD
            
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
        }

        public void limpiarCampos()
        {
            txtDni.Text = null;
            txtNombre.Text = null;
            txtApellido.Text = null;
            rbtnSexo.ClearSelection();
            txtFechaNacimiento.Text = null;
            txtCorreoElectronico.Text = null;
            txtTelefono.Text = null;
            txtDireccion.Text = null;
            ddlProvincia.SelectedIndex = 0;
            ddlLocalidad.SelectedIndex = 0;
            ddlNacionalidad.SelectedIndex = 0;

        }
        protected void cvProvincia_ServerValidate(object source, ServerValidateEventArgs args)
        {
            ///para que no tire error el execute command del DAO///
            if (ddlProvincia.SelectedValue == "0" || ddlLocalidad.SelectedValue == "0" || ddlNacionalidad.SelectedValue == "0")
            {
                args.IsValid = false; // La validación falla si el valor es 0
            }
            
            else
            {
                args.IsValid = true; // La validación pasa si el valor no es 0
            }
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