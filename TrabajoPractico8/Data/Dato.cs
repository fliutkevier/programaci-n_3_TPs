using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data
{
    public class Dato
    {
        private string query;
        private string consulta;
        private SqlConnection conexion;
        public SqlCommand comando;

        public Dato()
        {
            query = "Data Source=localhost\\sqlexpress; Initial Catalog=BDSucursales; Integrated Security=True";
            conexion = new SqlConnection(query);
            conexion.Open();
        }

        private void setParametro(string parametro, object valor)
        {
            comando.Parameters.AddWithValue(parametro, valor);
        }

        public bool agregarSucursal(Sucursal sucursal)
        {
            query = "INSERT INTO Sucursal VALUES(@nombre, @descripcion, NULL, @idProvincia, @direccion, NULL)";

            comando = new SqlCommand(query, conexion);

            setParametro("@nombre", sucursal.Nombre);
            setParametro("@descripcion", sucursal.Descripcion);
            setParametro("@idProvincia", sucursal.IdProvincia);
            setParametro("@direccion", sucursal.Direccion);

            if (comando.ExecuteNonQuery() == 1)
            {
                conexion.Close();
                return true;
            }

            conexion.Close();
            return false;
        }

        public bool eliminarSucursal(int id)
        {
            query = "DELETE FROM Sucursal WHERE Id_Sucursal = @id";
            comando = new SqlCommand(query, conexion);
            setParametro("@id", id);

            if (comando.ExecuteNonQuery() == 1)
            {
                conexion.Close();
                return true;
            }

            conexion.Close();
            return false;
        }

        public List<Provincia> GetProvincias()
        {
            query = "SELECT Id_Provincia, DescripcionProvincia FROM Provincia";
            comando = new SqlCommand(query, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            List<Provincia> provincias = new List<Provincia>();
            

            while (reader.Read())
            {
                Provincia provincia = new Provincia();
                provincia.Id = (int)reader["Id_Provincia"];
                provincia.Descripcion = (string)reader["DescripcionProvincia"];

                provincias.Add(provincia);
            }

            return provincias;
        }

        public Boolean existe(String consulta)
        {
            Boolean estado = false;
            SqlCommand cmd = new SqlCommand(consulta, conexion);
            SqlDataReader datos = cmd.ExecuteReader();
            if (datos.Read())
            {
                estado = true;
            }
            conexion.Close();
            return estado;
        }

        public void setConsultaDeLectura(string consulta)
        {
            this.consulta = consulta;
            comando = new SqlCommand(consulta, conexion);
        }

        public SqlDataReader getReader()
        {
            return comando.ExecuteReader();
        }

        public void Cerrar()
        {
            conexion.Close();
        }
    }
}
