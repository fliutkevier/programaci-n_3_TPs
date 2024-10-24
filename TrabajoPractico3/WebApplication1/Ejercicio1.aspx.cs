using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;
        }

        protected void btnGuardarLocalidad_Click(object sender, EventArgs e)
        {
            Page.Validate("Grupo1");
            String localidad = txtLocalidad.Text.Trim();

            if (Page.IsValid == false)
            {
                txtLocalidad.Text = "";
            }
            else
            {
                ddlLocalidades.Items.Add(localidad);
                txtLocalidad.Text = "";
            }

        }

        protected void txtContrasenia_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtLocalidad_TextChanged(object sender, EventArgs e)
        {

        }

        protected void txtRepetirContrañseña_TextChanged(object sender, EventArgs e)
        {

        }

        protected void btnGuardarUsuario_Click(object sender, EventArgs e)
        {
            Page.Validate("Grupo2");

            if(Page.IsValid == true)
            {
     
                lblBienvenida.Text = "Bienvenido/a " + txtUsuario.Text;
                
                txtUsuario.Text = string.Empty;
                txtContrasenia.Text = string.Empty;
                txtRepetirContrasenia.Text = String.Empty;
                txtEmail.Text = string.Empty;
                txtCP.Text = string.Empty;
                ddlLocalidades.SelectedIndex = 0;


            }
            else
            {
                lblBienvenida.Text = "";
            }
        }

        protected void cvLocalidad_ServerValidate(object source, ServerValidateEventArgs args)
        {
            String localidad = txtLocalidad.Text.Trim();

            
            foreach (ListItem item in ddlLocalidades.Items)
            {
                String localidadExistente = item.Text.Trim();

                if (string.Equals(localidadExistente.ToLower(), localidad.ToLower()))
                {
                    args.IsValid = false;
                    return;
                }
                else
                {
                    args.IsValid = true;
                }
            }

        }

        protected void btnInicio_Click(object sender, EventArgs e)
        {
            Server.Transfer("Inicio.aspx");
        }
    }
}