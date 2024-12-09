using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoMedico
    {
        private AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos();
        private string query;


        public bool insertarMedico(Medico medico)
        {
            query = "INSERT INTO MEDICOS (legajo_med, Dni_med, Nombre_med, Apellido_med, Sexo_med, FechaNacimiento_med, CorreoElectronico_med, Telefono_med, Direccion_med, Estado_med , Localidad_med, Provincia_med, Especialidad_med, Nacionalidad_med) " +
            "VALUES (@legajo, @dni, @nombre, @apellido, @sexo, @nacimiento, @correo, @telefono, @direccion, @estado, @localidad, @provincia, @especialidad, @nacionalidad)";

            List<SqlParameter> parametros = new List<SqlParameter> {
                new SqlParameter("@legajo", medico.Legajo),
                new SqlParameter("@dni", medico.Dni),
                new SqlParameter("@nombre", medico.Nombre),
                new SqlParameter("@apellido", medico.Apellido),
                new SqlParameter("@sexo", medico.Sexo),
                new SqlParameter("@nacimiento", medico.Nacimiento),
                new SqlParameter("@correo", medico.CorreoElectronico),
                new SqlParameter("@telefono", medico.Telefono),
                new SqlParameter("@direccion", medico.Direccion),
                new SqlParameter("@estado", medico.Estado),
                new SqlParameter("@localidad", medico.Localidad.Id),
                new SqlParameter("@provincia", medico.Provincia.Id),
                new SqlParameter("@especialidad", medico.Especialidad.Id),
                new SqlParameter("@nacionalidad", medico.Nacionalidad.Id)

            };
            return accesoBaseDatos.ejecutarSinDevolucion(query, parametros);


        }
        public List<Medico> buscarTodos()
        {
            query = "SELECT Legajo_med, Dni_med, Nombre_med, Apellido_med, Sexo_med, FechaNacimiento_med, CorreoElectronico_med, Telefono_med, Direccion_med, Estado_med, Localidad_med, Provincia_med, Especialidad_med, Nacionalidad_med FROM MEDICOS";
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            List<Medico> medicos = new List<Medico>();

            while (reader.Read()) { 
                Medico medico = new Medico();
                medico.Legajo = (string)reader["Legajo_med"];
                medico.Dni = (string)reader["Dni_med"];
                medico.Nombre = (string)reader["Nombre_med"];
                medico.Apellido = (string)reader["Apellido_med"];
                medico.Sexo = (char)reader["Sexo_med"].ToString()[0];
                medico.Nacimiento = (DateTime)reader["FechaNacimiento_med"];
                medico.CorreoElectronico = (string)reader["CorreoElectronico_med"];
                medico.Telefono = (string)reader["Telefono_med"];
                medico.Direccion = (string)reader["Direccion_med"];
                medico.Provincia = new Provincia();
                medico.Provincia.Id = (int)reader["Provincia_med"];
                medico.Localidad = new Localidad();
                medico.Localidad.Id = (int)reader["Localidad_med"];
                medico.Estado = (bool)reader["Estado_med"];
                medico.Especialidad = new Especialidad();
                medico.Especialidad.Id = (int)reader["Especialidad_med"];
                medico.Nacionalidad = new Nacionalidad();
                medico.Nacionalidad.Id = (int)reader["Nacionalidad_med"];


                medicos.Add(medico);

            }
            reader.Close();
            return medicos;

        }

        public bool Modificar(Medico medico)
        {
            query = "UPDATE Medicos SET Nombre_med = @nombre, Apellido_med = @apellido, Sexo_med = @sexo, FechaNacimiento_med = @nacimiento, CorreoElectronico_med = @correo, Telefono_med = @telefono, Direccion_med = @direccion, Localidad_med = @localidad, Provincia_med = @provincia, Estado_med = @estado, Especialidad_med = @especialidad, Nacionalidad_med = @nacionalidad WHERE Legajo_med = '"+medico.Legajo+"'";

            List<SqlParameter> parametros = new List<SqlParameter> {
               /// new SqlParameter("@dni", medico.Dni),
                new SqlParameter("@nombre", medico.Nombre),
                new SqlParameter("@apellido", medico.Apellido),
                new SqlParameter("@sexo", medico.Sexo),
                new SqlParameter("@nacimiento", medico.Nacimiento),
                new SqlParameter("@correo", medico.CorreoElectronico),
                new SqlParameter("@telefono", medico.Telefono),
                new SqlParameter("@direccion", medico.Direccion),
                new SqlParameter("@estado", medico.Estado),
                new SqlParameter("@localidad", medico.Localidad.Id),
                new SqlParameter("@provincia", medico.Provincia.Id),
                new SqlParameter("@especialidad", medico.Especialidad.Id),
                new SqlParameter("@nacionalidad", medico.Nacionalidad.Id)

            };

            if (accesoBaseDatos.ejecutarSinDevolucion(query, parametros))
            {
                
                return true;
            }

            return false;
        }

        public Medico BuscarMedico(string Legajo)
        {
            Medico medico = new Medico();
            query = "SELECT Legajo_med, Dni_med, Nombre_med, Apellido_med, Sexo_med, FechaNacimiento_med, CorreoElectronico_med, Telefono_med, Direccion_med, Estado_med, Localidad_med, Provincia_med, Especialidad_med, Nacionalidad_med FROM MEDICOS WHERE Legajo_med = @legajoBuscado";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@legajoBuscado", Legajo)
            };

            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);
           
            if (reader.Read())
            {
                medico.Legajo = (string)reader["Legajo_med"];
                medico.Dni = (string)reader["Dni_med"];
                medico.Nombre = (string)reader["Nombre_med"];
                medico.Apellido = (string)reader["Apellido_med"];
                medico.Sexo = (char)reader["Sexo_med"].ToString()[0];
                medico.Nacimiento = (DateTime)reader["FechaNacimiento_med"];
                medico.CorreoElectronico = (string)reader["CorreoElectronico_med"];
                medico.Telefono = (string)reader["Telefono_med"];
                medico.Direccion = (string)reader["Direccion_med"];
                medico.Provincia = new Provincia();
                medico.Provincia.Id = (int)reader["Provincia_med"];
                medico.Localidad = new Localidad();
                medico.Localidad.Id = (int)reader["Localidad_med"];
                medico.Estado = (bool)reader["Estado_med"];
                medico.Especialidad = new Especialidad();
                medico.Especialidad.Id = (int)reader["Especialidad_med"];
                medico.Nacionalidad = new Nacionalidad();
                medico.Nacionalidad.Id = (int)reader["Nacionalidad_med"];
            }

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return medico;
        }

        public List<Medico> buscarXEspecialidad(int idEspecialidad)
        {
            query = "SELECT Legajo_med, Dni_med, Nombre_med, Apellido_med, Sexo_med, FechaNacimiento_med, CorreoElectronico_med, Telefono_med, Direccion_med, Estado_med, Localidad_med, Provincia_med, Especialidad_med, Nacionalidad_med FROM MEDICOS INNER JOIN Especialidades ON Especialidad_med = Especialidades.Id_esp WHERE Especialidad_med = @idEspecialidad";

            List<SqlParameter> parametros = new List<SqlParameter> {
                new SqlParameter("@idEspecialidad", idEspecialidad),
            };
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);
            List<Medico> medicos = new List<Medico>();

            while (reader.Read())
            {
                Medico medico = new Medico();
                medico.Legajo = (string)reader["Legajo_med"];
                medico.Dni = (string)reader["Dni_med"];
                medico.Nombre = (string)reader["Nombre_med"];
                medico.Apellido = (string)reader["Apellido_med"];
                medico.Sexo = (char)reader["Sexo_med"].ToString()[0];
                medico.Nacimiento = (DateTime)reader["FechaNacimiento_med"];
                medico.CorreoElectronico = (string)reader["CorreoElectronico_med"];
                medico.Telefono = (string)reader["Telefono_med"];
                medico.Direccion = (string)reader["Direccion_med"];
                medico.Provincia = new Provincia();
                medico.Provincia.Id = (int)reader["Provincia_med"];
                medico.Localidad = new Localidad();
                medico.Localidad.Id = (int)reader["Localidad_med"];
                medico.Estado = (bool)reader["Estado_med"];
                medico.Especialidad = new Especialidad();
                medico.Especialidad.Id = (int)reader["Especialidad_med"];
                medico.Nacionalidad = new Nacionalidad();
                medico.Nacionalidad.Id = (int)reader["Nacionalidad_med"];


                medicos.Add(medico);

            }
            reader.Close();
            return medicos;
        }

        public List<Medico> FiltrarMedicos(string referencia)
        {
            query = "SELECT Legajo_med, Dni_med, Nombre_med, Apellido_med, Sexo_med, FechaNacimiento_med, CorreoElectronico_med, Telefono_med, Direccion_med, Estado_med, Localidad_med, Provincia_med, Especialidad_med, Nacionalidad_med FROM MEDICOS " +
                "WHERE Legajo_med LIKE '%" + referencia + "%'";

            List<Medico> medicos = new List<Medico>();
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            while (reader.Read())
            {
                Medico medico = new Medico();
                medico.Legajo = (string)reader["Legajo_med"];
                medico.Dni = (string)reader["Dni_med"];
                medico.Nombre = (string)reader["Nombre_med"];
                medico.Apellido = (string)reader["Apellido_med"];
                medico.Sexo = (char)reader["Sexo_med"].ToString()[0];
                medico.Nacimiento = (DateTime)reader["FechaNacimiento_med"];
                medico.CorreoElectronico = (string)reader["CorreoElectronico_med"];
                medico.Telefono = (string)reader["Telefono_med"];
                medico.Direccion = (string)reader["Direccion_med"];
                medico.Provincia = new Provincia();
                medico.Provincia.Id = (int)reader["Provincia_med"];
                medico.Localidad = new Localidad();
                medico.Localidad.Id = (int)reader["Localidad_med"];
                medico.Estado = (bool)reader["Estado_med"];
                medico.Especialidad = new Especialidad();
                medico.Especialidad.Id = (int)reader["Especialidad_med"];
                medico.Nacionalidad = new Nacionalidad();
                medico.Nacionalidad.Id = (int)reader["Nacionalidad_med"];

                medicos.Add(medico);
            }
            reader.Close();
            return medicos;
        }
    }
}
