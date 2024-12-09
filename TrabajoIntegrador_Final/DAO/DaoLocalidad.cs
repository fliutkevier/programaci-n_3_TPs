using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoLocalidad
    {
        private AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos();
        private string query;


        public List<Localidad> obtenerLocalidades()
        {
            List<Localidad> localidades = new List<Localidad>();

            query = "SELECT Id_loc, IdProvincia_loc, Nombre_loc FROM LOCALIDADES";
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);

            while (reader.Read())
            {
                Localidad localidad = new Localidad();

                localidad.Id = (int)reader["Id_loc"];
                localidad.IdProvincia = (int)reader["IdProvincia_loc"];
                localidad.Nombre = (string)reader["Nombre_loc"];

                localidades.Add(localidad);

            }
            reader.Close();
            return localidades;
        }

        public List<Localidad> ObtenerLocalidadesXProvincia(int idProv)
        {
            query = "SELECT Id_loc, IdProvincia_loc, Nombre_loc FROM LOCALIDADES WHERE IdProvincia_loc = " + idProv;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);

            List<Localidad> localidades = new List<Localidad>();

            while (reader.Read())
            {
                Localidad localidad = new Localidad();

                localidad.Id = (int)reader["Id_loc"];
                localidad.IdProvincia = (int)reader["IdProvincia_loc"];
                localidad.Nombre = (string)reader["Nombre_loc"];

                localidades.Add(localidad); 
            }
            reader.Close();
            return localidades;
        }

        public Localidad buscarLocalidad(int idLoc)
        {
            Localidad localidad = null;
            query = "SELECT Id_loc, IdProvincia_loc, nombre_loc FROM LOCALIDADES WHERE Id_loc = " + idLoc;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);

            if (reader.Read())
            {
                int id = (int)reader["Id_loc"];
                int IdProvincia = (int)reader["IdProvincia_loc"];
                string nombre = reader["nombre_loc"].ToString();

                localidad = new Localidad(id, IdProvincia, nombre);
            }

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return localidad;
        }
        public string buscarNombre(Localidad localidad)
        {
            query = "SELECT Nombre_loc FROM Localidades WHERE Id_loc = " + localidad.Id;
            SqlDataReader reader=accesoBaseDatos.ejecutarConDevolucion(query);
            reader.Read();
            string nombreLocalidad = (string)reader["Nombre_loc"];
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return nombreLocalidad;
        }

        public int buscarId(Localidad localidad)
        {
            query = "SELECT Id_loc FROM Localidades WHERE Nombre_loc = " + localidad.Nombre;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            reader.Read();
            int idLocalidad = (int)reader["Id_loc"];
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return idLocalidad;
        }
    }
}
