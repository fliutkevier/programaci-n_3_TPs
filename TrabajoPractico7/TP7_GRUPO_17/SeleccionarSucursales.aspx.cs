using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using static System.Net.Mime.MediaTypeNames;

namespace TP7_GRUPO_17
{
    public partial class SeleccionarSucursales : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSeleccionar_Command(object sender, CommandEventArgs e)
        {
            if(e.CommandName == "eventoSeleccionar")
            {
                SucursalesSeleccionadas sucursalesSeleccionadas = new SucursalesSeleccionadas();

                int index = Convert.ToInt32(e.CommandArgument);

                String s_IdSucursal = ((Label)lvSucursales.Items[index].FindControl("IdSucursalLabel")).Text;
                String s_Nombre = ((Label)lvSucursales.Items[index].FindControl("NombreSucursalLabel")).Text;
                String s_Descripcion = ((Label)lvSucursales.Items[index].FindControl("DescripcionSucursalLabel")).Text;

                Sucursal sucursal = new Sucursal
                {
                    IdSucursal = s_IdSucursal,
                    NombreSucursal = s_Nombre,
                    DescripcionSucursal = s_Descripcion
                };

                sucursalesSeleccionadas.AgregarSucursal(sucursal);
            }
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            string sucursalBuscada = txtBusqueda.Text.Trim().ToLower();

            foreach (ListViewItem item in lvSucursales.Items)
            {
                Label lblNombreSucursal = (Label)item.FindControl("NombreSucursalLabel");

                string nombreSucursal = lblNombreSucursal.Text.ToLower();

                if (nombreSucursal.Contains(sucursalBuscada))
                {
                    item.Visible = true;
                }
                else
                {
                    item.Visible = false;
                }
            }
        }

        protected void FiltrarPorProvincia(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            string idProvincia = btn.CommandArgument;

            sdsSucursales.SelectCommand = $"SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal], [Id_Sucursal] FROM [Sucursal] WHERE [id_ProvinciaSucursal] = @idProvincia";

            sdsSucursales.SelectParameters.Clear();
            sdsSucursales.SelectParameters.Add("idProvincia", idProvincia);

            lvSucursales.DataBind();
        }
    }
}