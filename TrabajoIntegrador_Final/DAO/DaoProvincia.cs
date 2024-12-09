using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoProvincia
    {
        private AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos();
        private string query;

        public List<Provincia> obtenerProvincias()
        {
            List<Provincia> provincias = new List<Provincia>(); 

            query = "SELECT Id_pro, Nombre_pro FROM PROVINCIAS";
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);

            while (reader.Read())
            {
                Provincia provincia = new Provincia();

                provincia.Id = (int)reader["Id_pro"];
                provincia.Nombre = (string)reader["Nombre_pro"];

                provincias.Add(provincia);

            }
            reader.Close();
            return provincias;
        }

        public Provincia buscarProvincia(int idPro)
        {
            Provincia provincia = null;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion("SELECT Id_pro, nombre_pro FROM PROVINCIAS WHERE Id_pro = " + idPro);

            if (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id_pro"]);
                string nombre = reader["nombre_pro"].ToString();

                provincia = new Provincia(id, nombre);
            }

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return provincia;
        }
        public string buscarNombre(Provincia provincia)
        {
            query = "SELECT Nombre_pro FROM Provincias WHERE Id_pro = " + provincia.Id;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            reader.Read();
            string nombreProvincia = (string)reader["Nombre_pro"];
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return nombreProvincia;
        }

        public int buscarId(string provincia)
        {
            query = "SELECT Id_pro FROM Provincias WHERE Nombre_pro = '" + provincia+"'";
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            reader.Read();
            int idProvincia = (int)reader["Id_pro"];
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return idProvincia;
        }
    }
}
