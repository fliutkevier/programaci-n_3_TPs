using DAO;
using Entidades;
using Negocio;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace TPINT_GRUPO_17_PR3
{
    public partial class SeccionMedicos : System.Web.UI.Page
    {
        private NegocioMedico negocioMedico = new NegocioMedico();
        private NegocioProvincia negocioProvincia = new NegocioProvincia(); 
        private NegocioLocalidad negocioLocalidad = new NegocioLocalidad();
        private NegocioEspecialidad negocioEspecialidad = new NegocioEspecialidad();
        private NegocioNacionalidad negocioNacionalidad = new NegocioNacionalidad();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblEliminarRegistro.Visible = false;
            lblCargarRegistro.Visible = false;
            if (!IsPostBack)
            {
                if (Request.Cookies["usuarioNombre"] != null)
                {
                    lblUsuario.Text += Request.Cookies["usuarioNombre"].Value;
                }
                cargarMedicos();
                cargarDDLS();
            }
        }

        //////////////////////////////Eventos de redireccion //////////////////////////////
        protected void btnCargarMedico_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_CargarMedico.aspx");
        }

        protected void btnCrearModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Admin_CrearUsuarios.aspx");
        }
        //////////////////////////////Eventos de redireccion //////////////////////////////



        //////////////////////////////Carga y filtrado //////////////////////////////
        public void cargarMedicos()
        {
            Session["Medicos"] = negocioMedico.obtenerTodos();   //Para mantener los filtros actualizados
            grdMedicos.DataSource = Session["Medicos"];
            grdMedicos.DataBind();
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

        protected void ddlFiltroProvincia_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdMedicos.DataSource = aplicarFiltros();
            grdMedicos.DataBind();


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
            grdMedicos.DataSource = aplicarFiltros();
            grdMedicos.DataBind();
        }

        protected void ddlFiltroNacionalidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            grdMedicos.DataSource = aplicarFiltros();
            grdMedicos.DataBind();
        }

        protected void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtBusqueda.Text = null;
            ddlFiltroProvincia.SelectedIndex = 0;
            ddlFiltroLocalidad.SelectedIndex = 0;
            ddlFiltroNacionalidad.SelectedIndex = 0;
            cargarMedicos();

        }


        public List<Medico> aplicarFiltros()
        {

            if (Session["Medicos"] != null)
            {
                List<Medico> medicos = Session["Medicos"] as List<Medico>;

                int idProvincia = Convert.ToInt32(ddlFiltroProvincia.SelectedValue);
                if (idProvincia != 0)
                {
                    medicos = medicos.Where(medico => medico.Provincia.Id == idProvincia).ToList(); //si el index es 0 (no hay seleccion) se carga respetando la provincia seleccionada
                    grdMedicos.DataSource = medicos;
                    grdMedicos.DataBind();
                }

                int idLocalidad = Convert.ToInt32(ddlFiltroLocalidad.SelectedValue);
                if (idLocalidad != 0)
                {
                    medicos = medicos.Where(medico => medico.Localidad.Id == idLocalidad).ToList();
                    grdMedicos.DataSource = medicos;
                    grdMedicos.DataBind();
                }

                int idNacionalidad = Convert.ToInt32(ddlFiltroNacionalidad.SelectedValue);
                if (idNacionalidad != 0)
                {
                    medicos = medicos.Where(medico => medico.Nacionalidad.Id == idNacionalidad).ToList();
                    grdMedicos.DataSource = medicos;
                    grdMedicos.DataBind();
                }

                return medicos;
            }

            return negocioMedico.obtenerTodos();
        }

        protected void btnBuscarMedico_Click(object sender, EventArgs e)
        {
            string legajo = txtBusqueda.Text.Trim();

            if (!string.IsNullOrEmpty(legajo))
            {
                Session["Medicos"] = negocioMedico.filtrarMedicos(legajo);  //Para mantener los filtros actualizados
                grdMedicos.DataSource = Session["Medicos"];
                aplicarFiltros();
                grdMedicos.DataBind();
            }
            else
            {
                cargarMedicos();
                aplicarFiltros();
            }
        }

        //////////////////////////////Carga y filtrado FIN //////////////////////////////


        /////////////////////////////////Eventos de la grilla /////////////////////////////////
        protected void grdMedicos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            Label LabelLegajo = grdMedicos.Rows[e.RowIndex].FindControl("lbl_it_Legajo") as Label;
            CheckBox checkBoxEstado = grdMedicos.Rows[e.RowIndex].FindControl("cb_it_Estado") as CheckBox;

            if (checkBoxEstado.Checked){
                string legajo = LabelLegajo.Text.Trim();
                negocioMedico.bajaLogica(negocioMedico.buscarMedicoPorLegajo(legajo));
                cargarMedicos();
            }
            else
            {
                lblEliminarRegistro.Text = "El registro ya esta dado de baja. Para volver a activarlo debe actualizarse";
                lblEliminarRegistro.ForeColor = Color.Red;
                lblEliminarRegistro.Visible = true;
            }
        }

        protected void grdMedicos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            /// grdMedicos.EditIndex = e.NewEditIndex; // No sirve al momento de filtrar y editar
            grdMedicos.EditIndex = e.NewEditIndex;
            string legajo = txtBusqueda.Text.Trim();
            if (!string.IsNullOrEmpty(legajo))
            {
                Session["Medicos"] = negocioMedico.filtrarMedicos(legajo);  //Para mantener los filtros actualizados
                grdMedicos.DataSource = Session["Medicos"];
                aplicarFiltros();
                grdMedicos.DataBind();
            }
            else
            {
                cargarMedicos();
                aplicarFiltros();
            }
            
        }
        protected void grdMedicos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            Medico medico = new Medico();

            medico.Legajo = ((Label)grdMedicos.Rows[e.RowIndex].FindControl("lbl_eit_Legajo")).Text;
            medico.Dni = ((Label)grdMedicos.Rows[e.RowIndex].FindControl("lbl_eit_Dni")).Text;
            medico.Nombre = ((TextBox)grdMedicos.Rows[e.RowIndex].FindControl("txt_eit_Nombre")).Text;
            medico.Apellido = ((TextBox)grdMedicos.Rows[e.RowIndex].FindControl("txt_eit_Apellido")).Text;
            medico.Direccion = ((TextBox)grdMedicos.Rows[e.RowIndex].FindControl("txt_eit_Direccion")).Text;
            medico.Telefono = ((TextBox)grdMedicos.Rows[e.RowIndex].FindControl("txt_eit_Telefono")).Text;
            medico.CorreoElectronico = ((TextBox)grdMedicos.Rows[e.RowIndex].FindControl("txt_eit_Correo")).Text;
            RadioButtonList rbtn = ((RadioButtonList)grdMedicos.Rows[e.RowIndex].FindControl("rbtn_eit_Sexo"));
            medico.Sexo = Convert.ToChar(rbtn.SelectedValue);
            TextBox txtNacimiento = ((TextBox)grdMedicos.Rows[e.RowIndex].FindControl("txt_eit_Nacimiento"));
            medico.Nacimiento = Convert.ToDateTime(txtNacimiento.Text);
            DropDownList ddlProvincia = ((DropDownList)grdMedicos.Rows[e.RowIndex].FindControl("ddl_eit_Provincia"));
            medico.Provincia = negocioProvincia.buscarProvincia(Convert.ToInt32(ddlProvincia.SelectedValue));
            DropDownList ddlLocalidad = ((DropDownList)grdMedicos.Rows[e.RowIndex].FindControl("ddl_eit_Localidad"));
            medico.Localidad = negocioLocalidad.buscarLocalidad(Convert.ToInt32(ddlLocalidad.SelectedValue));
            DropDownList ddlEspecialidad = ((DropDownList)grdMedicos.Rows[e.RowIndex].FindControl("ddl_eit_Especialidad"));
            medico.Especialidad = negocioEspecialidad.buscarEspecialidad(Convert.ToInt32(ddlEspecialidad.SelectedValue));
            DropDownList ddlNacionalidad = ((DropDownList)grdMedicos.Rows[e.RowIndex].FindControl("ddl_eit_Nacionalidad"));
            medico.Nacionalidad = negocioNacionalidad.buscarNacionalidad(Convert.ToInt32(ddlNacionalidad.SelectedValue));
            medico.Estado = true;
            negocioMedico.modificar(medico);

            grdMedicos.EditIndex = -1;

            string legajo = txtBusqueda.Text.Trim();

            if (!string.IsNullOrEmpty(legajo))
            {
                Session["Medicos"] = negocioMedico.filtrarMedicos(legajo);  //Para mantener los filtros actualizados
                grdMedicos.DataSource = Session["Medicos"];
                aplicarFiltros();
                grdMedicos.DataBind();
            }
            else
            {
                cargarMedicos();
                aplicarFiltros();
            }

            lblCargarRegistro.Visible = true;
            lblCargarRegistro.ForeColor = Color.Green;
            lblCargarRegistro.Text = "Registro actualizado con éxito!";
        }

        protected void grdMedicos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdMedicos.EditIndex = -1;

            string legajo = txtBusqueda.Text.Trim();

            if (!string.IsNullOrEmpty(legajo))
            {
                Session["Medicos"] = negocioMedico.filtrarMedicos(legajo);  //Para mantener los filtros actualizados
                grdMedicos.DataSource = Session["Medicos"];
                aplicarFiltros();
                grdMedicos.DataBind();
            }
            else
            {
                cargarMedicos();
                aplicarFiltros();
            }
        }

        protected void grdMedicos_RowDataBound(object sender, GridViewRowEventArgs e) //Para cargar los ddl
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                TextBox txtNacimiento = (TextBox)e.Row.FindControl("txt_eit_Nacimiento");
                if (txtNacimiento != null)
                {
                    Medico medico = (Medico)e.Row.DataItem;
                    txtNacimiento.Text = medico.Nacimiento.ToString("yyyy-MM-dd");
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


                DropDownList ddlEspecialidad = (DropDownList)e.Row.FindControl("ddl_eit_Especialidad");
                if (ddlEspecialidad != null)
                {
                    ///CARGA DDL ESPECIALIDAD
                    List<Especialidad> especialidades = negocioEspecialidad.obtenerTodos();
                    ddlEspecialidad.DataSource = especialidades;
                    ddlEspecialidad.DataTextField = "Descripcion";
                    ddlEspecialidad.DataValueField = "Id";
                    ddlEspecialidad.DataBind();

                    int idEspecialidad = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Especialidad.Id"));
                    ddlEspecialidad.SelectedValue = idEspecialidad.ToString();
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

        protected void grdMedicos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdMedicos.PageIndex = e.NewPageIndex;
            cargarMedicos();
            aplicarFiltros();
        }

        //////////////////////////////Eventos de la grilla FIN//////////////////////////////





    }
}