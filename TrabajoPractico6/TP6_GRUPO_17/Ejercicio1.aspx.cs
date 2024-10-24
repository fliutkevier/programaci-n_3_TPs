using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP6_GRUPO_17
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CargarProductos();
            }
        }

        protected void grdProductos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            grdProductos.PageIndex = e.NewPageIndex;
            CargarProductos();
        }

        private void CargarProductos()
        {
            Datos db = new Datos();
            string consulta = $@"SELECT IdProducto, NombreProducto, CantidadPorUnidad, PrecioUnidad FROM productos";
            db.setConsultaDeLectura(consulta);
            DataTable tabla = new DataTable();

            tabla.Load(db.getConsultaDeLectura());

            grdProductos.DataSource = tabla;
            grdProductos.DataBind();

            db.Cerrar();
        }

        protected void grdProductos_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            String s_IdProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_it_idProducto")).Text;

            int idProducto = Convert.ToInt32(s_IdProducto);
            string consulta = @"DELETE FROM productos WHERE IdProducto = @IdProducto";

            using (SqlConnection conexion = new SqlConnection("Data Source=localhost\\sqlexpress; Initial Catalog=Neptuno; Integrated Security=True"))
            {
                using (SqlCommand comando = new SqlCommand(consulta, conexion))
                {
                    comando.Parameters.AddWithValue("@IdProducto", idProducto);

                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }

            CargarProductos();
        }

        protected void grdProductos_RowEditing(object sender, GridViewEditEventArgs e)
        {
            grdProductos.EditIndex = e.NewEditIndex;
            CargarProductos();
        }

        protected void grdProductos_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            String s_IdProducto = ((Label)grdProductos.Rows[e.RowIndex].FindControl("lbl_eit_IdProducto")).Text;
            String s_NombreProducto = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_NombreProducto")).Text;
            String s_CantidadPorUnidad = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_CantidadPorUnidad")).Text;
            String s_PrecioUnidad = ((TextBox)grdProductos.Rows[e.RowIndex].FindControl("txt_eit_PrecioUnidad")).Text;


            int idProducto = Convert.ToInt32(s_IdProducto);
            decimal precioUnidad = Convert.ToDecimal(s_PrecioUnidad);

            string consulta = @"UPDATE productos SET NombreProducto = @NombreProducto, CantidadPorUnidad = @CantidadPorUnidad, PrecioUnidad = @PrecioUnidad WHERE IdProducto = @IdProducto";

            Datos datos = new Datos();
            datos.setConsultaDeLectura(consulta);

            datos.Comando.Parameters.AddWithValue("@NombreProducto", s_NombreProducto);
            datos.Comando.Parameters.AddWithValue("@CantidadPorUnidad", s_CantidadPorUnidad);
            datos.Comando.Parameters.AddWithValue("@PrecioUnidad", precioUnidad);
            datos.Comando.Parameters.AddWithValue("@IdProducto", idProducto);

            datos.Comando.ExecuteNonQuery();
            datos.Cerrar();

            grdProductos.EditIndex = -1;
            CargarProductos();
        }

        protected void grdProductos_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            grdProductos.EditIndex = -1;
            CargarProductos();
        }
    }

}