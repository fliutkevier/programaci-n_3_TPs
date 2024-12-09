using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoTurno
    {
        private AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos();
        private string query;

        public bool cargarTurno(Turno turno)
        {
            query = "INSERT INTO TURNOS (LegajoMedico_tur, DniPaciente_tur, DiaHorario_tur, Observacion_tur, Presente_tur) VALUES (@legajoMedico, @dniPaciente, @diaHorario, @observacion, 0)";

            List<SqlParameter> parametros = new List<SqlParameter> {
                new SqlParameter("@legajoMedico", turno.Legajo),
                new SqlParameter("@dniPaciente", turno.DniPaciente),
                new SqlParameter("@diaHorario", turno.DiaHorario),
                new SqlParameter("@observacion", turno.Observacion),
            };

            return accesoBaseDatos.ejecutarSinDevolucion(query, parametros);

        }

        public List<Turno> obtenerTurnos()
        {
            List<Turno> turnos = new List<Turno>();

            query = "SELECT Id_tur, LegajoMedico_tur, DniPaciente_tur, DiaHorario_tur FROM TURNOS";
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);

            while (reader.Read())
            {
                Turno turno = new Turno();

                turno.Id = (int)reader["Id_tur"];
                turno.Legajo = (string)reader["LegajoMedico_tur"];
                turno.DniPaciente = (string)reader["DniPaciente_tur"];
                turno.DiaHorario = (DateTime)reader["DiaHorario_tur"];

                turnos.Add(turno);
            }
            reader.Close();
            return turnos;
        }

        public List<Turno> obtenerTurnosMEDICO(string legajoMedico)
        {
            List<Turno> turnos = new List<Turno>();

            query = "SELECT Id_tur, LegajoMedico_tur, DniPaciente_tur, DiaHorario_tur, Observacion_tur, Presente_tur FROM TURNOS where LegajoMedico_tur = @legajo";
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@legajo", legajoMedico)
            };

            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);

            while (reader.Read())
            {
                Turno turno = new Turno();

                turno.Id = (int)reader["Id_tur"];
                turno.Legajo = (string)reader["LegajoMedico_tur"];
                turno.DniPaciente = (string)reader["DniPaciente_tur"];
                turno.Observacion = (string)reader["Observacion_tur"];
                turno.Presente = (bool)reader["Presente_tur"];
                turno.DiaHorario = (DateTime)reader["DiaHorario_tur"];

                turnos.Add(turno);
            }
            reader.Close();
            return turnos;
        }

        public Turno buscarTurno(string dniPaciente)
        {
            Turno turno = null;
            query = "SELECT Id_tur, LegajoMedico_tur, DniPaciente_tur, DiaHorario_tur FROM TURNOS " +
                "WHERE DniPaciente_tur = @dniPaciente";
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@dniPaciente", dniPaciente)
            };
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);

            if (reader.Read())
            {
                turno = new Turno();
                turno.Id = (int)reader["Id_tur"];
                turno.Legajo = (string)reader["LegajoMedico_tur"];
                turno.DniPaciente = (string)reader["DniPaciente_tur"];
                turno.DiaHorario = (DateTime)reader["DiaHorario_tur"];
            }
            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return turno;
        }

        public bool validarDisponibilidad(string legajoMedico, DateTime diaHorario)
        {
            query = "SELECT Id_tur FROM TURNOS WHERE LegajoMedico_tur = @legajoMedico AND DiaHorario_tur = @diaHorario";

            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@legajoMedico", legajoMedico),
                new SqlParameter("@diaHorario", diaHorario)
            };

            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);

            bool disponible = !reader.Read(); // si no hay filas el turno está disponible

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return disponible;
        }

        public bool Modificar(Turno turno)
        {
            query = "UPDATE Turnos SET  LegajoMedico_tur = @legajomedico, DniPaciente_tur = @dnipaciente, DiaHorario_tur = @diahorario, Observacion_tur = @observacion, Presente_tur = @presente  WHERE Id_tur = " + turno.Id ;

            List<SqlParameter> parametros = new List<SqlParameter> {

                ///new SqlParameter("@id_tur", turno.Id),
                new SqlParameter("@legajomedico", turno.Legajo),
                new SqlParameter("@dnipaciente", turno.DniPaciente),
                new SqlParameter("@diahorario", turno.DiaHorario),
                new SqlParameter("@observacion", turno.Observacion),
                new SqlParameter("@presente", turno.Presente)


            };

            if (accesoBaseDatos.ejecutarSinDevolucion(query, parametros))
            {

                return true;
            }

            return false;
        }


        public List<Turno> filtrarTurnosxPaciente(string referencia)
        {
            query = "SELECT Id_tur, LegajoMedico_tur, DniPaciente_tur, DiaHorario_tur, Observacion_tur, Presente_tur FROM TURNOS " +
                "WHERE DniPaciente_tur LIKE '%" + referencia + "%'";

            List<Turno> turnos = new List<Turno>();
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            while (reader.Read())
            {
                Turno turno = new Turno();
                turno.Id = (int)reader["Id_tur"];
                turno.Legajo = (string)reader["LegajoMedico_tur"];
                turno.DniPaciente = (string)reader["DniPaciente_tur"];
                turno.Observacion = (string)reader["Observacion_tur"];
                turno.Presente = (bool)reader["Presente_tur"];
                turno.DiaHorario = (DateTime)reader["DiaHorario_tur"];

                turnos.Add(turno);
            }
            reader.Close();
            return turnos;
        }

    }
}
