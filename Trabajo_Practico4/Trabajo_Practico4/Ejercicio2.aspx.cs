using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Collections;
using System.Windows.Input;

namespace Trabajo_Practico4
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        string connectionString = @"Data Source=localhost\sqlexpress;Initial Catalog=Neptuno;Integrated Security=True";

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {   
                string query = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);

                    grdProductos.DataSource = dataTable;
                    grdProductos.DataBind();
                }

            }
        }

        protected void btnFiltrar_Click(object sender, EventArgs e)
        {
            string consulta = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos WHERE ";
            int seleccionProducto, numBuscadoProducto, seleccionCategoria, numBuscadoCategoria;


            if (!string.IsNullOrEmpty(tbxIdProducto.Text) && !string.IsNullOrEmpty(tbxIdCategoria.Text))
            {
                seleccionProducto = Convert.ToInt32(ddlIdProducto.SelectedValue);
                numBuscadoProducto = Convert.ToInt32(tbxIdProducto.Text);

                seleccionCategoria = Convert.ToInt32(ddlIdCategoria.SelectedValue);
                numBuscadoCategoria = Convert.ToInt32(tbxIdCategoria.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    switch (seleccionProducto)
                    {
                        case 0: //Igual a
                            consulta += "IdProducto = @IdProducto";
                            break;

                        case 1: //Mayor a
                            consulta += "IdProducto > @IdProducto";
                            break;

                        case 2: //Menor a
                            consulta += "IdProducto < @IdProducto";
                            break;
                    }

                    switch (seleccionCategoria)
                    {
                        case 0: //Igual a
                            consulta += " AND IdCategoría = @IdCategoria";
                            break;

                        case 1: //Mayor a
                            consulta += " AND IdCategoría > @IdCategoria";
                            break;

                        case 2: //Menor a
                            consulta += " AND IdCategoría < @IdCategoria";
                            break;
                    }

                    SqlCommand command = new SqlCommand(consulta, connection);

                    command.Parameters.AddWithValue("@IdProducto", numBuscadoProducto);
                    command.Parameters.AddWithValue("@IdCategoria", numBuscadoCategoria);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    grdProductos.DataSource = dataTable;
                    grdProductos.DataBind();

                    connection.Close();

                }
            }
            else if (!string.IsNullOrEmpty(tbxIdProducto.Text))
            {
                seleccionProducto = Convert.ToInt32(ddlIdProducto.SelectedValue);
                numBuscadoProducto = Convert.ToInt32(tbxIdProducto.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    switch (seleccionProducto)
                    {
                        case 0: //Igual a
                            consulta += "IdProducto = @IdProducto";
                            break;

                        case 1: //Mayor a
                            consulta += "IdProducto > @IdProducto";
                            break;

                        case 2: //Menor a
                            consulta += "IdProducto < @IdProducto";
                            break;
                    }

                    SqlCommand command = new SqlCommand(consulta, connection);

                    command.Parameters.AddWithValue("@IdProducto", numBuscadoProducto);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    grdProductos.DataSource = dataTable;
                    grdProductos.DataBind();

                    connection.Close();
                }

            }
            else
            {
                seleccionCategoria = Convert.ToInt32(ddlIdCategoria.SelectedValue);
                numBuscadoCategoria = Convert.ToInt32(tbxIdCategoria.Text);

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    switch (seleccionCategoria)
                    {
                        case 0: //Igual a
                            consulta += "IdCategoría = @IdCategoria";
                            break;

                        case 1: //Mayor a
                            consulta += "IdCategoría > @IdCategoria";
                            break;

                        case 2: //Menor a
                            consulta += "IdCategoría < @IdCategoria";
                            break;
                    }

                    SqlCommand command = new SqlCommand(consulta, connection);

                    command.Parameters.AddWithValue("@IdCategoria", numBuscadoCategoria);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();

                    adapter.Fill(dataTable);

                    grdProductos.DataSource = dataTable;
                    grdProductos.DataBind();

                    connection.Close();
                }
            }
        }

        protected void btnQuitarFiltro_Click(object sender, EventArgs e)
        {
            string query = "SELECT IdProducto, NombreProducto, IdCategoría, CantidadPorUnidad, PrecioUnidad FROM Productos";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);

                grdProductos.DataSource = dataTable;
                grdProductos.DataBind();
            }

            tbxIdCategoria.Text = "";
            tbxIdProducto.Text = "";
        }
    }
}