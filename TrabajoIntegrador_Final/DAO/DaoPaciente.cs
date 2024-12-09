using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoPaciente
    {
        private AccesoBaseDatos accesoBaseDatos;
        private string query;

        public DaoPaciente()
        {
            accesoBaseDatos = new AccesoBaseDatos();
        }

        public bool InsertarPaciente(Paciente paciente)
        {
            query = "INSERT INTO Pacientes (Dni_pac, Nombre_pac, Apellido_pac, Sexo_pac, FechaNacimiento_pac, CorreoElectronico_pac, Telefono_pac, Direccion_pac,Provincia_pac, Localidad_pac,estado_pac, Nacionalidad_pac) " +
            "VALUES (@dni, @nombre, @apellido, @sexo, @nacimiento, @correo, @telefono, @direccion, @provincia, @localidad, @estado, @nacionalidad)";

            List<SqlParameter> parametros = new List<SqlParameter> {
                new SqlParameter("@dni", paciente.Dni),
                new SqlParameter("@nombre", paciente.Nombre),
                new SqlParameter("@apellido", paciente.Apellido),
                new SqlParameter("@sexo", paciente.Sexo),
                new SqlParameter("@nacimiento", paciente.Nacimiento),
                new SqlParameter("@correo", paciente.CorreoElectronico),
                new SqlParameter("@telefono", paciente.Telefono),
                new SqlParameter("@direccion", paciente.Direccion),
                new SqlParameter("@provincia", paciente.Provincia.Id),
                new SqlParameter("@localidad", paciente.Localidad.Id),
                new SqlParameter("@estado", paciente.Estado),
               new SqlParameter("@Nacionalidad", paciente.Nacionalidad.Id)

            };
            return accesoBaseDatos.ejecutarSinDevolucion(query, parametros);


        }

        public Paciente BuscarPaciente(string Dni)
        {
            Paciente paciente = null;
            query = @"SELECT Dni_pac, Nombre_pac, Apellido_pac, Sexo_pac, FechaNacimiento_pac, CorreoElectronico_pac, Telefono_pac, Direccion_pac, Provincia_pac, Localidad_pac, Nacionalidad_pac, Estado_pac FROM Pacientes WHERE Dni_pac = @dni";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@dni", Dni)
            };

            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);

            if (reader.Read())
            {
                paciente = new Paciente();
                paciente.Dni = (string)reader["Dni_pac"];
                paciente.Nombre = (string)reader["Nombre_pac"];
                paciente.Apellido = (string)reader["Apellido_pac"];
                paciente.Sexo = (char)reader["Sexo_pac"].ToString()[0];
                paciente.Nacimiento = (DateTime)reader["FechaNacimiento_pac"];
                paciente.CorreoElectronico = (string)reader["CorreoElectronico_pac"];
                paciente.Telefono = (string)reader["Telefono_pac"];
                paciente.Direccion = (string)reader["Direccion_pac"];
                paciente.Provincia = new Provincia();
                paciente.Provincia.Id = (int)reader["Provincia_pac"];
                paciente.Localidad = new Localidad();
                paciente.Localidad.Id = (int)reader["Localidad_pac"];
                paciente.Nacionalidad = new Nacionalidad();
                paciente.Nacionalidad.Id = (int)reader["Nacionalidad_pac"];
                paciente.Estado = (bool)reader["Estado_pac"];

            }

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return paciente;
        }

        public List<Paciente> BuscarTodos()
        {
            query = "SELECT Dni_pac, Nombre_pac, Apellido_pac, Sexo_pac, FechaNacimiento_pac, CorreoElectronico_pac, Telefono_pac, Direccion_pac, Provincia_pac, Localidad_pac, Nacionalidad_pac, Estado_pac FROM Pacientes";
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            List<Paciente> pacientes = new List<Paciente>();

            while (reader.Read())
            {
                Paciente paciente = new Paciente();
                paciente.Dni = (string)reader["Dni_pac"];
                paciente.Nombre = (string)reader["Nombre_pac"];
                paciente.Apellido = (string)reader["Apellido_pac"];
                paciente.Sexo = (char)reader["Sexo_pac"].ToString()[0];
                paciente.Nacimiento = (DateTime)reader["FechaNacimiento_pac"];
                paciente.CorreoElectronico = (string)reader["CorreoElectronico_pac"];
                paciente.Telefono = (string)reader["Telefono_pac"];
                paciente.Direccion = (string)reader["Direccion_pac"];
                paciente.Provincia = new Provincia();
                paciente.Provincia.Id = (int)reader["Provincia_pac"];
                paciente.Localidad = new Localidad();
                paciente.Localidad.Id = (int)reader["Localidad_pac"];
                paciente.Nacionalidad = new Nacionalidad();
                paciente.Nacionalidad.Id = (int)reader["Nacionalidad_pac"];
                paciente.Estado = (bool)reader["Estado_pac"];

                pacientes.Add(paciente);
            }
            reader.Close();
            return pacientes;
        }

        public bool Modificar(Paciente paciente)
        {
            query = "UPDATE Pacientes SET Nombre_pac = @nombre, Apellido_pac = @apellido, Sexo_pac = @sexo, FechaNacimiento_pac = @nacimiento, CorreoElectronico_pac = @correo, Telefono_pac = @telefono, Direccion_pac = @direccion, Localidad_pac = @localidad, Provincia_pac = @provincia, Nacionalidad_pac = @nacionalidad, Estado_pac = @estado\r\nWHERE Dni_pac = '" + paciente.Dni + "'";

            List<SqlParameter> parametros = new List<SqlParameter> {
               /// new SqlParameter("@dni", paciente.Dni),
                new SqlParameter("@nombre", paciente.Nombre),
                new SqlParameter("@apellido", paciente.Apellido),
                new SqlParameter("@sexo", paciente.Sexo),
                new SqlParameter("@nacimiento", paciente.Nacimiento),
                new SqlParameter("@correo", paciente.CorreoElectronico),
                new SqlParameter("@telefono", paciente.Telefono),
                new SqlParameter("@direccion", paciente.Direccion),
                new SqlParameter("@localidad", paciente.Localidad.Id),
                new SqlParameter("@provincia", paciente.Provincia.Id),
                new SqlParameter("@nacionalidad", paciente.Nacionalidad.Id),
                new SqlParameter("@estado", paciente.Estado)
            };

            if (accesoBaseDatos.ejecutarSinDevolucion(query, parametros))
            {
                return true;
            }

            return false;
        }

        public List<Paciente> FiltrarPacientes(string referencia)
        {
            query = "SELECT Dni_pac, Nombre_pac, Apellido_pac, Sexo_pac, FechaNacimiento_pac, CorreoElectronico_pac, Telefono_pac, Direccion_pac, Provincia_pac, Localidad_pac, Nacionalidad_pac, Estado_pac FROM Pacientes " +
                "WHERE Dni_pac LIKE '%"+referencia+"%'";

            List<Paciente> pacientes = new List<Paciente>();
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            while (reader.Read())
            {
                Paciente paciente = new Paciente();
                paciente.Dni = (string)reader["Dni_pac"];
                paciente.Nombre = (string)reader["Nombre_pac"];
                paciente.Apellido = (string)reader["Apellido_pac"];
                paciente.Sexo = (char)reader["Sexo_pac"].ToString()[0];
                paciente.Nacimiento = (DateTime)reader["FechaNacimiento_pac"];
                paciente.CorreoElectronico = (string)reader["CorreoElectronico_pac"];
                paciente.Telefono = (string)reader["Telefono_pac"];
                paciente.Direccion = (string)reader["Direccion_pac"];
                paciente.Provincia = new Provincia();
                paciente.Provincia.Id = (int)reader["Provincia_pac"];
                paciente.Localidad = new Localidad();
                paciente.Localidad.Id = (int)reader["Localidad_pac"];
                paciente.Nacionalidad = new Nacionalidad();
                paciente.Nacionalidad.Id = (int)reader["Nacionalidad_pac"];
                paciente.Estado = (bool)reader["Estado_pac"];

                pacientes.Add(paciente);
            }
            reader.Close();
            return pacientes;
        }
    }
}
