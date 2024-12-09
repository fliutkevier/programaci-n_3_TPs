using Entidades;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoUsuario
    {
        private AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos();
        private string query;

        public Usuario ValidarUsuario(string Nombre, string Contrasenia)
        {
            Usuario usuario = null;
            string query = "SELECT Id_usu, Nombre_usu, Contrasenia_usu, Tipo_usu, LegajoMedico_usu FROM Usuarios WHERE Nombre_usu = @Nombre AND Contrasenia_usu = @Contrasenia";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@Nombre", Nombre),
                new SqlParameter("@Contrasenia", Contrasenia)
            };

            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);

            if (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id_usu"]);
                string nombre = reader["Nombre_usu"].ToString();
                string contrsenia = reader["Contrasenia_usu"].ToString();
                char tipoUsuario = Convert.ToChar(reader["Tipo_usu"]);
                string legajo = reader["LegajoMedico_usu"].ToString();

                usuario = new Usuario(id, nombre, contrsenia, tipoUsuario, legajo);
            }

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return usuario;
        }

        public List<Usuario> obtenerUsuarios()
        {
            query = "SELECT Id_usu, Nombre_usu, Contrasenia_usu, Tipo_usu, LegajoMedico_usu FROM USUARIOS WHERE Tipo_usu='M'";
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            List<Usuario> usuarios = new List<Usuario>();

            while (reader.Read())
            {
                Usuario usuario = new Usuario();
                usuario.Id = (int)reader["Id_usu"];
                usuario.Nombre = (string)reader["Nombre_usu"];
                usuario.Contrasenia = (string)reader["Contrasenia_usu"];
                usuario.Tipo = Convert.ToChar(reader["Tipo_usu"]);
                usuario.LegajoMedico = (string)reader["LegajoMedico_usu"];

                if (usuario.LegajoMedico != null)
                {
                    usuarios.Add(usuario);
                }

            }
            reader.Close();
            return usuarios;
        }

        public void crearUsuario(Usuario usuario)
        {
            query = "INSERT INTO Usuarios (Nombre_usu, Contrasenia_usu, Tipo_usu, LegajoMedico_usu) " +
            "VALUES (@nombre, @contrasenia, 'M', @legajo)";

            List<SqlParameter> parametros = new List<SqlParameter> {
                new SqlParameter("@nombre", usuario.Nombre),
                new SqlParameter("@contrasenia", usuario.Contrasenia),
                //new SqlParameter("M", usuario.Tipo),
                new SqlParameter("@legajo", usuario.LegajoMedico),
            };
            accesoBaseDatos.ejecutarSinDevolucion(query, parametros);
        }

        public Usuario encontrarUsuario(string nombre)
        {
            Usuario usuario = null;
            query = @"SELECT Id_usu, Nombre_usu, Contrasenia_usu, Tipo_usu, LegajoMedico_usu FROM USUARIOS WHERE Nombre_usu = @nombre";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@nombre", nombre)
            };

            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);

            if (reader.Read())
            {
                usuario = new Usuario();
                usuario.Id = (int)reader["Id_usu"];
                usuario.Nombre = (string)reader["Nombre_usu"];
                usuario.Contrasenia = (string)reader["Contrasenia_usu"];
                usuario.Tipo = (char)reader["Tipo_usu"].ToString()[0]; ;
                usuario.LegajoMedico = (string)reader["LegajoMedico_usu"];
            }

                return usuario;
        }
    }
}
