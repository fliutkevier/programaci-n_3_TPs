using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace Trabajo_Practico4
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Viajes;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {

                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();


                    SqlCommand cmd = new SqlCommand("SELECT IDProvincia, NombreProvincia FROM Provincias", cn);
                    SqlDataReader dr = cmd.ExecuteReader();


                    ddlProvinciasInicio.DataSource = dr;

                    ddlProvinciasInicio.DataTextField = "NombreProvincia";
                    ddlProvinciasInicio.DataValueField = "IDProvincia";
                    ddlProvinciasInicio.DataBind();
                    ddlProvinciasInicio.Items.Insert(0, new ListItem("--Seleccione Provincia--", "0"));
                    ddlLocalidadesInicio.Items.Insert(0, new ListItem("--Seleccione Localidad--", "0"));
                    ddlProvinciasFinal.Items.Insert(0, new ListItem("--Seleccione Provincia--", "0"));
                    ddlLocalidadFinal.Items.Insert(0, new ListItem("--Seleccione Localidad--", "0"));
                    cn.Close();


                }
            }
        }

        protected void ddlProvincias_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idProvinciaSeleccionada = ddlProvinciasInicio.SelectedValue;

            if (ddlProvinciasInicio.SelectedIndex != 0)
            {
                using (SqlConnection cn = new SqlConnection(connectionString))
                {
                    cn.Open();


                    SqlCommand cmd = new SqlCommand("SELECT IDLocalidad, NombreLocalidad FROM Localidades WHERE IDProvincia = @IDProvincia", cn);
                    cmd.Parameters.AddWithValue("@IDProvincia", idProvinciaSeleccionada);

                    SqlDataReader dr = cmd.ExecuteReader();

                    ddlLocalidadesInicio.DataSource = dr;
                    ddlLocalidadesInicio.DataTextField = "NombreLocalidad";
                    ddlLocalidadesInicio.DataValueField = "IDLocalidad";
                    ddlLocalidadesInicio.DataBind();

                    dr.Close();

                    SqlCommand cmd2 = new SqlCommand("SELECT IDProvincia, NombreProvincia FROM Provincias WHERE IDProvincia != @IDProvincia", cn);
                    cmd2.Parameters.AddWithValue("@IDProvincia", idProvinciaSeleccionada);

                    SqlDataReader dr2 = cmd2.ExecuteReader();

                    ddlProvinciasFinal.DataSource = dr2;
                    ddlProvinciasFinal.DataTextField = "NombreProvincia";
                    ddlProvinciasFinal.DataValueField = "IDProvincia";
                    ddlProvinciasFinal.DataBind();

                    dr2.Close ();

                    cn.Close();
                    ddlProvinciasFinal_SelectedIndexChanged(sender, e);
                }
            }
            else
            {

                ddlProvinciasFinal.Items.Clear();
                ddlProvinciasFinal.Items.Insert(0, new ListItem("--Seleccione Provincia--", "0"));
                ddlLocalidadFinal.Items.Clear();
                ddlLocalidadesInicio.Items.Clear();
            }

        }

        protected void ddlProvinciasFinal_SelectedIndexChanged(object sender, EventArgs e)
        {
            string idProvinciaSeleccionada = ddlProvinciasFinal.SelectedValue;


            using (SqlConnection cn = new SqlConnection(connectionString))
            {
                cn.Open();


                SqlCommand cmd = new SqlCommand("SELECT IDLocalidad, NombreLocalidad FROM Localidades WHERE IDProvincia = @IDProvincia", cn);
                cmd.Parameters.AddWithValue("@IDProvincia", idProvinciaSeleccionada);

                SqlDataReader dr = cmd.ExecuteReader();

                ddlLocalidadFinal.DataSource = dr;
                ddlLocalidadFinal.DataTextField = "NombreLocalidad";
                ddlLocalidadFinal.DataValueField = "IDLocalidad";

                ddlLocalidadFinal.DataBind();


                dr.Close();
                cn.Close();

            }

        }
    }
}