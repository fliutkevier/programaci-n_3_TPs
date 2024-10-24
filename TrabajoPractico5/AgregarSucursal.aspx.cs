using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP5_GRUPO_17
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
            
            if (!IsPostBack)
            {
                Datos db = new Datos();
                db.setConsultaDeLectura("SELECT Id_Provincia, DescripcionProvincia FROM Provincia");

                SqlDataReader reader = db.Comando.ExecuteReader();

                ddlProvincias.DataSource = reader;
                ddlProvincias.DataTextField = "DescripcionProvincia";
                ddlProvincias.DataValueField = "Id_Provincia";
                ddlProvincias.DataBind();

                ddlProvincias.Items.Insert(0, new ListItem("-- Seleccione Provincia --", "0"));

                db.Cerrar();
            }
        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Datos db = new Datos();

            string nombre = txtNombreSucursal.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            int provincia = Convert.ToInt32(ddlProvincias.SelectedValue);
            string direccion = txtDireccion.Text.Trim();

            
            if (ValidarDireccion(direccion))
            {
                if (db.Insertar(nombre, descripcion, provincia, direccion))
                {
                    txtNombreSucursal.Text = "";
                    txtDescripcion.Text = "";
                    txtDireccion.Text = "";
                    ddlProvincias.SelectedIndex = 0;
                    lblAgregado.Text = "La sucursal se ha agregado con éxito";
                }
            }
            else
            {
                
                lblAgregado.Text = "Por favor, ingrese una dirección válida que contenga calle y número.";
            }
        }

       
        private bool ValidarDireccion(string direccion)
        {
            return direccion.Split(' ').Any(part => int.TryParse(part, out _));
        }
       

    }
}