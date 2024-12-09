using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoEspecialidad
    {
        public AccesoBaseDatos accesoBaseDatos;
        public string query;

        public DaoEspecialidad()
        {
            accesoBaseDatos = new AccesoBaseDatos();
        }

        public List<Especialidad> obtenerEspecialidades()
        {
            List<Especialidad> especialidades = new List<Especialidad>();

            query = "SELECT Id_esp, Descripcion_esp FROM ESPECIALIDADES";
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);

            while (reader.Read())
            {
                Especialidad especialidad = new Especialidad();

                especialidad.Id = (int)reader["Id_esp"];
                especialidad.Descripcion = (string)reader["Descripcion_esp"];

                especialidades.Add(especialidad);

            }
            reader.Close();
            return especialidades;
        }

        /*
        public List<Especialidad> getEspecialidades()
        {
            List<Especialidad> especialidades = new List<Especialidad>();
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion("SELECT Id, Descripcion FROM Especialidades");

            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string descripcion = reader["Descripcion"].ToString();

                Especialidad especialidad = new Especialidad(id, descripcion);
                especialidades.Add(especialidad);
            }

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return especialidades;
        }
        */

        public Especialidad buscarEspecialidad(int idEspecialidad)
        {
            Especialidad especialidad = null;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion("SELECT Id_esp, Descripcion_esp FROM Especialidades WHERE Id_esp = " + idEspecialidad);

            if (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id_esp"]);
                string descripcion = reader["Descripcion_esp"].ToString();

                especialidad = new Especialidad(id, descripcion);
            }

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return especialidad;
        }

        public int buscarId(Especialidad especialidad)
        {
            query = "SELECT Id_esp FROM Especialidades WHERE Descripcion_esp = " + especialidad.Descripcion;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            reader.Read();
            int idEspecialidad = (int)reader["Id_esp"];
            accesoBaseDatos.cerrarConexion();
            reader.Close();
            return idEspecialidad;
        }

        public string buscarNombre(Especialidad especialidad)
        {
            query = "SELECT Descripcion_esp FROM Especialidades WHERE Id_esp = " + especialidad.Id;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            reader.Read();
            string NombreEspecialidad = (string)reader["Descripcion_esp"];
            accesoBaseDatos.cerrarConexion();
            return NombreEspecialidad;
        }
    }
}
