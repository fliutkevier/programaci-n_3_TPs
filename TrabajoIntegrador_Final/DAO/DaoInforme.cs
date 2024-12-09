using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoInforme
    {
        private AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos();
        private string query;

        public int contarTodos(DateTime fechaInicio, DateTime fechaFin)
        {
            int contar = 0;
            query = "SELECT COUNT(*) FROM Turnos WHERE DiaHorario_tur BETWEEN @fechaInicio AND @fechaFin";
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@fechaInicio", fechaInicio),
                new SqlParameter("@fechaFin", fechaFin)
            };

            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);
            if (reader.Read())
            {
                contar = reader.GetInt32(0);
            }
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return contar;
        }

        public int contarPresentes(DateTime fechaInicio, DateTime fechaFin)
        {
            int contar = 0;
            query = "SELECT COUNT(*) FROM Turnos WHERE Presente_tur=1 AND DiaHorario_tur BETWEEN @fechaInicio AND @fechaFin";
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@fechaInicio", fechaInicio),
                new SqlParameter("@fechaFin", fechaFin)
            };

            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);
            if (reader.Read())
            {
                contar = reader.GetInt32(0);
            }
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return contar;
        }

        public int contarAusentes(DateTime fechaInicio, DateTime fechaFin)
        {
            int contar = 0;
            query = "SELECT COUNT(*) FROM Turnos WHERE Presente_tur=0 AND DiaHorario_tur BETWEEN @fechaInicio AND @fechaFin";
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@fechaInicio", fechaInicio),
                new SqlParameter("@fechaFin", fechaFin)
            };

            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);
            if (reader.Read())
            {
                contar = reader.GetInt32(0);
            }
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return contar;
        }

        public float porcentajePresentes(DateTime fechaInicio, DateTime fechaFin)
        {
            int presentes = contarPresentes(fechaInicio, fechaFin), totales = contarTodos(fechaInicio, fechaFin);
            float porcentaje = ((float)presentes / totales) * 100;
            return porcentaje;
        }

        public float porcentjeAusentes(DateTime fechaInicio, DateTime fechaFin)
        {
            int ausentes = contarAusentes(fechaInicio, fechaFin), totales = contarTodos(fechaInicio, fechaFin);
            float porcentaje = ((float)ausentes / totales) * 100;
            return porcentaje;
        }

        public List<Informe> obtenerPresentes(DateTime fechaInicio, DateTime fechaFin)
        {
            query = "SELECT Id_tur, LegajoMedico_tur, DniPaciente_tur, Observacion_tur FROM Turnos WHERE Presente_tur=1 AND DiaHorario_tur BETWEEN @fechaInicio AND @fechaFin";
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@fechaInicio", fechaInicio),
                new SqlParameter("@fechaFin", fechaFin)
            };
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);
            List<Informe> informes = new List<Informe>();

            while (reader.Read())
            {
                Informe informe = new Informe();
                informe.ID = (int)reader["Id_tur"];
                informe.Medico = (string)reader["LegajoMedico_tur"];
                informe.Dni = (string)reader["DniPaciente_tur"];

                informes.Add(informe);
            }
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return informes;
        }

        public List<Informe> obtenerAusentes(DateTime fechaInicio, DateTime fechaFin)
        {
            query = "SELECT Id_tur, LegajoMedico_tur, DniPaciente_tur FROM Turnos WHERE Presente_tur=0 AND DiaHorario_tur BETWEEN @fechaInicio AND @fechaFin";
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@fechaInicio", fechaInicio),
                new SqlParameter("@fechaFin", fechaFin)
            };
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);
            List<Informe> informes = new List<Informe>();

            while (reader.Read())
            {
                Informe informe = new Informe();
                informe.ID = (int)reader["Id_tur"];
                informe.Medico = (string)reader["LegajoMedico_tur"];
                informe.Dni = (string)reader["DniPaciente_tur"];

                informes.Add(informe);
            }
            reader.Close();
            accesoBaseDatos.cerrarConexion();
            return informes;
        }
    }
}
