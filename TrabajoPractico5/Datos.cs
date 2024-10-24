using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace TP5_GRUPO_17
{
    public class Datos
    {
        private string consulta;
        private SqlConnection conexion;
        public SqlCommand Comando { get; set; }

        public Datos()
        {
            consulta = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales; Integrated Security = True";
            conexion = new SqlConnection(consulta);
            conexion.Open();
        }

        private void setParametro(string parametro, object valor)
        {
            Comando.Parameters.AddWithValue(parametro, valor);
        }

        public bool Insertar(string nombreSucursal, string descSucursal, int idProvincia, string direccion)
        {
            consulta = "INSERT INTO Sucursal VALUES(@nombre, @descripcion, NULL, @idProvincia, @direccion, NULL)";

            Comando = new SqlCommand(consulta, conexion);

            setParametro("@nombre", nombreSucursal);
            setParametro("@descripcion", descSucursal);
            setParametro("@idProvincia", idProvincia);
            setParametro("@direccion", direccion);

            if(Comando.ExecuteNonQuery() == 1)
            {
                conexion.Close();
                return true;
            }

            conexion.Close();
            return false;

        }



        public void setConsultaDeLectura(string consulta)
        {
            this.consulta = consulta;
            Comando = new SqlCommand(consulta, conexion);
        }

        public void Cerrar()
        {
            conexion.Close();
        }
    }
}