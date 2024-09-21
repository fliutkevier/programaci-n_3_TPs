using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace Trabajo_Practico4
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Libreria;Integrated Security=True";
        
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                
                //Accedo al valor que guardé anteriormente y me fijo que no sea nulo
                if (Context.Items["TemaSeleccionado"] != null)
                {
                    Session["Tema"] = Context.Items["TemaSeleccionado"];
                    //Convierto el objeto a un int nuevamente para buscar el tema elegido en la base de datos
                    int temaSeleccionado = (int)Context.Items["TemaSeleccionado"];

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                    string consulta = "SELECT IdLibro, IdTema, Titulo, Precio, Autor FROM Libros WHERE ";

                    switch (temaSeleccionado)
                    {
                        case 1:
                            consulta += "IdTema = '1'";
                            break;
                        case 2:
                             consulta += "IdTema = '2'";
                             break;
                        case 3:
                                consulta += "IdTema = '3'";
                                break;
                    }
                        SqlDataAdapter adap = new SqlDataAdapter(consulta, connection);
                        DataTable dt = new DataTable();

                        adap.Fill(dt);

                        grdLibros.DataSource = dt;
                        grdLibros.DataBind();

                        connection.Close();
                    }
                }
                
            }
        }

        protected void btnConsultarOtroTema_Click(object sender, EventArgs e)
        {
            Server.Transfer("Ejercicio3.aspx");
        }

        protected void lnkSiguienteLibro_Click(object sender, EventArgs e)
        {
            if (Session["Tema"] != null) 
            {

                int temaSeleccionado = (int)Session["Tema"];

                temaSeleccionado += 1;

                if(temaSeleccionado >= 3)
                {
                    Session["Tema"] = null;
                }
                else { 
                    Session["Tema"] = temaSeleccionado;
                }
                    

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string consulta = "SELECT IdLibro, IdTema, Titulo, Precio, Autor FROM Libros WHERE ";

                    consulta += "IdTema = '" + temaSeleccionado + "'";
                    SqlDataAdapter adap = new SqlDataAdapter(consulta, connection);
                    DataTable dt = new DataTable();

                    adap.Fill(dt);

                    grdLibros.DataSource = dt;
                    grdLibros.DataBind();

                    connection.Close();
                }
            }
            else
            {
                lblError.Text = "No hay mas libros para listar";
                Response.Redirect("Ejercicio3.aspx");
                return;
            }
        }
    }
}