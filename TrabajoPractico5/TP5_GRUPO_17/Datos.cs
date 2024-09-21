using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TP5_GRUPO_17
{
    public class Datos
    {
        string consulta;
        private SqlConnection conexion;
        private SqlCommand comando;

        public Datos()
        {
            consulta = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales; Integrated Security = True";
            conexion = new SqlConnection(consulta);
            conexion.Open();
        }

        private void setParametro(string parametro, object valor)
        {
            comando.Parameters.AddWithValue(parametro, valor);
        }

        public bool Insertar(string nombreSucursal, string descSucursal, int idHorario, int idProvincia, string direccion, string URL)
        {
            consulta = "INSERT INTO Sucursal VALUES(@nombre, @descripcion, @idHorario, @idProvincia, @direccion, @url)";

            comando = new SqlCommand(consulta, conexion);

            setParametro("@nombre", nombreSucursal);
            setParametro("@descripcion", descSucursal);
            setParametro("@idHorario", idHorario);
            setParametro("@idProvincia", idProvincia);
            setParametro("@direccion", direccion);
            setParametro("@url", URL);

            if(comando.ExecuteNonQuery() == 1)
            {
                return true;
            }

            return false;

        }
    }
}