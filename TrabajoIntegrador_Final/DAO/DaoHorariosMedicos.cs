using Entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DaoHorariosMedicos
    {
        private AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos();
        private string query;


        public void insertarHorario(HorariosMedicos horario)
        {
            query = "INSERT INTO HORARIOSMEDICOS (LegajoMedico_hor, HoraInicio_hor, HoraFin_hor ) " +
            "VALUES (@legajo, @horainicio, @horafin )";

            List<SqlParameter> parametros = new List<SqlParameter> {
                new SqlParameter("@legajo", horario.LegajoMedico),
                new SqlParameter("@horainicio", horario.HoraInicio),
                new SqlParameter("@horafin", horario.HoraFin),
            };
            accesoBaseDatos.ejecutarSinDevolucion(query, parametros);
        }
        public List<HorariosMedicos> obtenerHorarios()
        {
            List<HorariosMedicos> horarios = new List<HorariosMedicos>();

            query = "SELECT LegajoMedico_hor, HoraInicio_hor, HoraFin_hor FROM HORARIOSMEDICOS";
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);

            while (reader.Read())
            {
                HorariosMedicos horario = new HorariosMedicos();

                horario.LegajoMedico = (string)reader["LegajoMedico_hor"];
                horario.HoraInicio = (TimeSpan)reader["HoraInicio_hor"];
                horario.HoraFin = (TimeSpan)reader["HoraFin_hor"];

                horarios.Add(horario);

            }
            reader.Close();
            return horarios;
        }

        public int obtenerUltimoID()
        {
            query = "SELECT IDENT_CURRENT('HorariosMedicos')";  //Devuelve el ultimo id autonumerico agregado en la tabla especificada
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);
            if (reader.Read())
            {
                int id = Convert.ToInt32(reader[0]);
                reader.Close();
                return id; //Ya que se espera un resultado unico se lee de la columna 0
            }
            else {
                return 0;
            }
            
        }
        
        public HorariosMedicos buscarHorarios(string legajoMedico)
        {
            HorariosMedicos horarios = null;
            List<SqlParameter> parametros = new List<SqlParameter>
            {
                new SqlParameter("@legajoMedico", legajoMedico)
            };
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion("SELECT LegajoMedico_hor, HoraInicio_hor, HoraFin_hor FROM HORARIOSMEDICOS WHERE LegajoMedico_hor = @legajoMedico", parametros);

            if (reader.Read())
            {
                string legajo = (string)reader["LegajoMedico_hor"];
                TimeSpan horainicio = (TimeSpan)reader["HoraInicio_hor"];
                TimeSpan horafin = (TimeSpan)reader["HoraFin_hor"];

                 horarios= new HorariosMedicos(legajo, horainicio, horafin);
            }

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return horarios;
        }
    }
}

