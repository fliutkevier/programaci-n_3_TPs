using DAO;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TPINT_GRUPO_17_PR3
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        private NegocioPaciente negocioPaciente = new NegocioPaciente();
        private NegocioProvincia negocioProvincia = new NegocioProvincia();
        private NegocioLocalidad negocioLocalidad = new NegocioLocalidad();
        private NegocioNacionalidad negocioNacionalidad = new NegocioNacionalidad();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                if (Request.Cookies["usuarioNombre"] != null)
                {
                    lblUsuarioConectado.Text += Request.Cookies["usuarioNombre"].Value;
                }
                cargarPacientes();
                cargarDDLS();
                
            }
        }

        public void cargarDDLS()
        {
            /// CARGA DDL PROVINCIA
            List<Provincia> provincias = negocioProvincia.obtenerTodos();
            ddlFiltroProvincia.DataSource = provincias;
            ddlFiltroProvincia.DataTextField = "Nombre";
            ddlFiltroProvincia.DataValueField = "Id";
            ddlFiltroProvincia.DataBind();
            ddlFiltroProvincia.Items.Insert(0, new ListItem("Seleccione una provincia", "0")); // Opción inicial
            /// CARGA DDL LOCALIDAD
            List<Localidad> localidades = negocioLocalidad.buscarLocalidadesXProvincia(Convert.ToInt32(ddlFiltroProvincia.SelectedValue));
            ddlFiltroLocalidad.DataSource = localidades;
            ddlFiltroLocalidad.DataTextField = "Nombre";
            ddlFiltroLocalidad.DataValueField = "Id";
            ddlFiltroLocalidad.DataBind();
            ddlFiltroLocalidad.Items.Insert(0, new ListItem("Seleccione una localidad", "0")); // Opción inicial
            ///CARGA DDL NACIONALIDAD
            List<Nacionalidad> nacionalidades = negocioNacionalidad.obtenerTodos();
            ddlFiltroNacionalidad.DataSource = nacionalidades;
            ddlFiltroNacionalidad.DataTextField = "Nombre";
            ddlFiltroNacionalidad.DataValueField = "Id";
            ddlFiltroNacionalidad.DataBind();
            ddlFiltroNacionalidad.Items.Insert(0, new ListItem("Seleccione una nacionalidad", "0")); // Opción inicial

        }

        

        protected void btnCargarPac_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_CargarPaciente.aspx");
        }



        private void cargarPacientes()
        {
            Session["Pacientes"] = negocioPaciente.ObtenerPacientes();   //Para mantener los filtros actualizados
            gdvPacientes.DataSource = Session["Pacientes"];
            gdvPacientes.DataBind();
        }


        /////////////////////////////////Eventos de filtrado /////////////////////////////////
        protected void btnBuscarPacDNI_Click(object sender, EventArgs e)
        {
            string dni = txtBuscarPaciente.Text.Trim();
 
            if (!string.IsNullOrEmpty(dni) )
            {
                Session["Pacientes"] = negocioPaciente.filtrarPacientes(dni);  //Para mantener los filtros actualizados
                gdvPacientes.DataSource = Session["Pacientes"];
                aplicarFiltros();
                gdvPacientes.DataBind();
            }
            else
            {
                cargarPacientes();
                aplicarFiltros();
            }
        }

        protected void ddlFiltroProvincia_SelectedIndexChanged(object sender, EventArgs e)  //Filtro Provincia
        {

            gdvPacientes.DataSource = aplicarFiltros();
            gdvPacientes.DataBind();
           

            // Carga dinamica del DDL Localidad
            List<Localidad> localidades = negocioLocalidad.buscarLocalidadesXProvincia(Convert.ToInt32(ddlFiltroProvincia.SelectedValue));
            ddlFiltroLocalidad.DataSource = localidades;
            ddlFiltroLocalidad.DataTextField = "Nombre";
            ddlFiltroLocalidad.DataValueField = "Id";
            ddlFiltroLocalidad.DataBind();
            ddlFiltroLocalidad.Items.Insert(0, new ListItem("Seleccione una localidad", "0")); // Opción inicial
        }

        protected void ddlFiltroLocalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            gdvPacientes.DataSource = aplicarFiltros();
            gdvPacientes.DataBind();

        }

        protected void ddlFiltroNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            gdvPacientes.DataSource = aplicarFiltros();
            gdvPacientes.DataBind();

        }

        public List<Paciente> aplicarFiltros()
        {

            if (Session["Pacientes"] != null)
            {
                List<Paciente> pacientes = Session["Pacientes"] as List<Paciente>;

                int idProvincia = Convert.ToInt32(ddlFiltroProvincia.SelectedValue);
                if (idProvincia != 0)
                {
                    pacientes = pacientes.Where(paciente => paciente.Provincia.Id == idProvincia).ToList(); //si el index es 0 (no hay seleccion) se carga respetando la provincia seleccionada
                    gdvPacientes.DataSource = pacientes;
                    gdvPacientes.DataBind();
                }

                int idLocalidad = Convert.ToInt32(ddlFiltroLocalidad.SelectedValue);
                if (idLocalidad != 0)
                {
                    pacientes = pacientes.Where(paciente => paciente.Localidad.Id == idLocalidad).ToList();
                    gdvPacientes.DataSource = pacientes;
                    gdvPacientes.DataBind();
                }

                int idNacionalidad = Convert.ToInt32(ddlFiltroNacionalidad.SelectedValue);
                if (idNacionalidad != 0)
                {
                    pacientes = pacientes.Where(paciente => paciente.Nacionalidad.Id == idNacionalidad).ToList();
                    gdvPacientes.DataSource = pacientes;
                    gdvPacientes.DataBind();
                }

                return pacientes;
            }

            return negocioPaciente.ObtenerPacientes();
        }

        protected void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBuscarPaciente.Text = null;
            ddlFiltroProvincia.SelectedIndex = 0;
            ddlFiltroLocalidad.SelectedIndex = 0;
            ddlFiltroNacionalidad.SelectedIndex = 0;
            cargarPacientes();
        }
        /////////////////////////////////Fin eventos de filtrado /////////////////////////////////




        /////////////////////////////////Inicio eventos de la grilla /////////////////////////////////
        protected void gdvPacientes_RowEditing(object sender, GridViewEditEventArgs e)
        {
            gdvPacientes.EditIndex = e.NewEditIndex;
            string dni = txtBuscarPaciente.Text.Trim();
            if (!string.IsNullOrEmpty(dni))
            {
                Session["Pacientes"] = negocioPaciente.filtrarPacientes(dni);  //Para mantener los filtros actualizados
                gdvPacientes.DataSource = Session["Pacientes"];
                aplicarFiltros();
                gdvPacientes.DataBind();
            }
            else
            {
                cargarPacientes();
                aplicarFiltros();
            }
        }

        protected void gdvPacientes_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {

            TextBox txtNombre = (TextBox)gdvPacientes.Rows[e.RowIndex].FindControl("txt_eit_Nombre");
            TextBox txtApellido = (TextBox)gdvPacientes.Rows[e.RowIndex].FindControl("txt_eit_Apellido");
            TextBox txtTelefono = (TextBox)gdvPacientes.Rows[e.RowIndex].FindControl("txt_eit_Telefono");
            TextBox txtFechaNacimiento = (TextBox)gdvPacientes.Rows[e.RowIndex].FindControl("txt_eit_Nacimiento");

            lblError.Text = ""; 

            if (string.IsNullOrEmpty(txtNombre.Text.Trim()))
            {
                lblError.Text += "* El campo 'Nombre' es requerido.<br/>";
            }

            if (string.IsNullOrEmpty(txtApellido.Text.Trim()))
            {
                lblError.Text += "* El campo 'Apellido' es requerido.<br/>";
            }

            if (!txtTelefono.Text.All(char.IsDigit))
            {
                lblError.Text += "* El campo 'Teléfono' contiene caracteres inválidos.<br/>";
            }

            if (DateTime.TryParse(txtFechaNacimiento.Text.Trim(), out DateTime nacimiento))
            {
                if (nacimiento > DateTime.Now)
                {
                    lblError.Text += "* La fecha de nacimiento no puede estar en el futuro.<br/>";
                }
            }

            //muestra lblError si hubo errores
            if (!string.IsNullOrEmpty(lblError.Text))
            {
                lblError.Visible = true;
                return;
            }

            //si no hubo errores
            lblError.Visible = false;


            Paciente paciente = new Paciente();

            paciente.Dni = ((Label)gdvPacientes.Rows[e.RowIndex].FindControl("lbl_eit_Dni")).Text;
            paciente.Nombre = ((TextBox)gdvPacientes.Rows[e.RowIndex].FindControl("txt_eit_Nombre")).Text;
            paciente.Apellido = ((TextBox)gdvPacientes.Rows[e.RowIndex].FindControl("txt_eit_Apellido")).Text;
            paciente.Direccion = ((TextBox)gdvPacientes.Rows[e.RowIndex].FindControl("txt_eit_Direccion")).Text;
            paciente.Telefono = ((TextBox)gdvPacientes.Rows[e.RowIndex].FindControl("txt_eit_Telefono")).Text;
            paciente.CorreoElectronico = ((TextBox)gdvPacientes.Rows[e.RowIndex].FindControl("txt_eit_Correo")).Text;
            RadioButtonList rbtn = ((RadioButtonList)gdvPacientes.Rows[e.RowIndex].FindControl("rbtn_eit_Sexo"));
            paciente.Sexo = Convert.ToChar(rbtn.SelectedValue);
            TextBox txtNacimiento = ((TextBox)gdvPacientes.Rows[e.RowIndex].FindControl("txt_eit_Nacimiento"));
            paciente.Nacimiento = Convert.ToDateTime(txtNacimiento.Text);
            DropDownList ddlProvincia = ((DropDownList)gdvPacientes.Rows[e.RowIndex].FindControl("ddl_eit_Provincia"));
            paciente.Provincia = negocioProvincia.buscarProvincia(Convert.ToInt32(ddlProvincia.SelectedValue));
            DropDownList ddlLocalidad = ((DropDownList)gdvPacientes.Rows[e.RowIndex].FindControl("ddl_eit_Localidad"));
            paciente.Localidad = negocioLocalidad.buscarLocalidad(Convert.ToInt32(ddlLocalidad.SelectedValue));
            DropDownList ddlNacionalidad = ((DropDownList)gdvPacientes.Rows[e.RowIndex].FindControl("ddl_eit_Nacionalidad"));
            paciente.Nacionalidad = negocioNacionalidad.buscarNacionalidad(Convert.ToInt32(ddlNacionalidad.SelectedValue));
            paciente.Estado = true;

            negocioPaciente.modificar(paciente);

            gdvPacientes.EditIndex = -1;

            string dni = txtBuscarPaciente.Text.Trim();
            if (!string.IsNullOrEmpty(dni))
            {
                Session["Pacientes"] = negocioPaciente.filtrarPacientes(dni);  //Para mantener los filtros actualizados
                gdvPacientes.DataSource = Session["Pacientes"];
                aplicarFiltros();
                gdvPacientes.DataBind();
            }
            else
            {
                cargarPacientes();
                aplicarFiltros();
            }

        }

        
        protected void gdvPacientes_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            gdvPacientes.EditIndex = -1;

            string dni = txtBuscarPaciente.Text.Trim();

            if (!string.IsNullOrEmpty(dni))
            {
                Session["Pacientes"] = negocioPaciente.filtrarPacientes(dni);  //Para mantener los filtros actualizados
                gdvPacientes.DataSource = Session["Pacientes"];
                aplicarFiltros();
                gdvPacientes.DataBind();
            }
            else
            {
                cargarPacientes();
                aplicarFiltros();
            }
        }

        protected void gdvPacientes_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TextBox txtNacimiento = (TextBox)e.Row.FindControl("txt_eit_Nacimiento");
                if (txtNacimiento != null)
                {
                    Paciente paciente = (Paciente)e.Row.DataItem;
                    txtNacimiento.Text = paciente.Nacimiento.ToString("yyyy-MM-dd");
                }

                DropDownList ddlProvincia = (DropDownList)e.Row.FindControl("ddl_eit_Provincia");

                if (ddlProvincia != null)
                {
                    ///CARGA DDL PROVINCIA
                    List<Provincia> provincias = negocioProvincia.obtenerTodos();

                    ddlProvincia.DataSource = provincias;
                    ddlProvincia.DataTextField = "Nombre";
                    ddlProvincia.DataValueField = "Id";
                    ddlProvincia.DataBind();

                    // Una vez que ya se cargan los datos del ddl ahora si se puede buscar el value que estaba seleccionado
                    int idProvincia = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Provincia.Id"));
                    ddlProvincia.SelectedValue = idProvincia.ToString();


                }


                //Se carga localidad acá también para que se cargue el selectedValue
                DropDownList ddlLocalidad = (DropDownList)e.Row.FindControl("ddl_eit_Localidad");
                if (ddlLocalidad != null)
                {
                    List<Localidad> localidades = negocioLocalidad.buscarLocalidadesXProvincia(Convert.ToInt32(ddlProvincia.SelectedValue));
                    ddlLocalidad.DataSource = localidades;
                    ddlLocalidad.DataTextField = "Nombre";
                    ddlLocalidad.DataValueField = "Id";
                    ddlLocalidad.DataBind();

                    int idLocalidad = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Localidad.Id"));
                    ddlLocalidad.SelectedValue = idLocalidad.ToString();
                }


                DropDownList ddlNacionalidad = (DropDownList)e.Row.FindControl("ddl_eit_Nacionalidad");
                if (ddlNacionalidad != null)
                {
                    ///CARGA DDL NACIONALIDAD
                    List<Nacionalidad> nacionalidades = negocioNacionalidad.obtenerTodos();
                    ddlNacionalidad.DataSource = nacionalidades;
                    ddlNacionalidad.DataTextField = "Nombre";
                    ddlNacionalidad.DataValueField = "Id";
                    ddlNacionalidad.DataBind();

                    int idNacionalidad = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Nacionalidad.Id"));
                    ddlNacionalidad.SelectedValue = idNacionalidad.ToString();
                }


            }
        }
        

        protected void ddl_eit_Provincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtiene el DDL de provincias que disparó el evento gracias al sender
            DropDownList ddlProvincia = (DropDownList)sender;

            // Obtiene la fila de la grilla que contiene el DropDownList gracias al namingContainer
            GridViewRow row = (GridViewRow)ddlProvincia.NamingContainer;

            DropDownList ddlLocalidad = (DropDownList)row.FindControl("ddl_eit_Localidad");

            if (ddlLocalidad != null)
            {
                // Obtiene el ID de la provincia seleccionada
                int idProvincia = Convert.ToInt32(ddlProvincia.SelectedValue);

                List<Localidad> localidades = negocioLocalidad.buscarLocalidadesXProvincia(idProvincia);

                ddlLocalidad.DataSource = localidades;
                ddlLocalidad.DataTextField = "Nombre";
                ddlLocalidad.DataValueField = "Id";
                ddlLocalidad.DataBind();
            }
        }

        protected void gdvPacientes_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label LabelDni = gdvPacientes.Rows[e.RowIndex].FindControl("lbl_it_Dni") as Label;
            CheckBox checkBoxEstado = gdvPacientes.Rows[e.RowIndex].FindControl("cb_it_Estado") as CheckBox;

            if (checkBoxEstado.Checked)
            {
                string dni = LabelDni.Text.Trim();
                negocioPaciente.bajaLogica(negocioPaciente.buscarPacienteXDNI(dni));
                cargarPacientes();
                
            }
            else
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "Este paciente ya está dado de baja. Para volver a darlo de alta, selecciona 'Editar'.";
                lblError.Visible = true;
            }
        }

        protected void gdvPacientes_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            gdvPacientes.PageIndex = e.NewPageIndex;
            cargarPacientes();
            aplicarFiltros();
        }





        /////////////////////////////////////////// Fin eventos de la grilla //////////////////////////////////////////////

    }
}