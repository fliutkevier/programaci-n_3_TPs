using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoNacionalidad
    {
        private AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos();
        private string query;


        public List<Nacionalidad> obtenerNacionalidades()
        {
            List<Nacionalidad> nacionalidades = new List<Nacionalidad>();

            query = "SELECT Id_pa, Nombre_pa FROM PAISES";
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);

            while (reader.Read())
            {
                Nacionalidad nacionalidad = new Nacionalidad();

                nacionalidad.Id = (int)reader["Id_pa"];
                nacionalidad.Nombre = (string)reader["Nombre_pa"];

                nacionalidades.Add(nacionalidad);

            }
            reader.Close();
            return nacionalidades;
        }


        public Nacionalidad buscarNacionalidad(int idNac)
        {
            Nacionalidad nacionalidad = null;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion("SELECT Id_pa, nombre_pa FROM PAISES WHERE Id_pa = " + idNac);

            if (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id_pa"]);
                string nombre = reader["nombre_pa"].ToString();

                nacionalidad = new Nacionalidad(id, nombre);
            }

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return nacionalidad;
        }

        public string buscarNombre(Nacionalidad nacionalidad)
        {
            query = "SELECT Nombre_pa FROM PAISES WHERE Id_pa = " + nacionalidad.Id;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            reader.Read();
            string nombreNacionalidad = (string)reader["Nombre_pa"];
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return nombreNacionalidad;
        }

        public int buscarId(Nacionalidad nacionalidad)
        {
            query = "SELECT Nombre_pa FROM PAISES WHERE Id_pa = " + nacionalidad.Nombre;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            reader.Read();
            int idNacionalidad = (int)reader["Id_pa"];
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return idNacionalidad;
        }
    }
}
