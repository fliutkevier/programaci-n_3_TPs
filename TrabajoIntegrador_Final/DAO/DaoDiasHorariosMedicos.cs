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
    public class DaoDiasHorariosMedicos
    {
        private AccesoBaseDatos accesoBaseDatos = new AccesoBaseDatos();
        private string query;


        public void insertarDia(DiasHorariosMedicos dia)
        {
            query = "INSERT INTO DIASHORARIOSMEDICOS (Id_hor_dxh, dia_dxh) " +
            "VALUES (@id_hor, @dia )";

            List<SqlParameter> parametros = new List<SqlParameter> {
                new SqlParameter("@id_hor", dia.Id_hor),
                new SqlParameter("@dia", dia.Dia),
            };
            accesoBaseDatos.ejecutarSinDevolucion(query, parametros);
            accesoBaseDatos.cerrarConexion();


        }

        public List<DiasHorariosMedicos> obtenerDias(int id_hor)
        {
            List<DiasHorariosMedicos> dias = new List<DiasHorariosMedicos>();

            query = "SELECT Id_hor_dxh, Dia_dxh FROM DIASHORARIOSMEDICOS WHERE Id_hor_dxh = " + id_hor;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query);

            while (reader.Read())
            {
                DiasHorariosMedicos dia = new DiasHorariosMedicos();

                dia.Id_hor = (int)reader["Id_hor_dxh"];
                dia.Dia = (char)reader["Dia_dxh"];

                dias.Add(dia);

            }
            reader.Close();
            return dias;
        }

        public DiasHorariosMedicos buscarDia(int id_hor)
        {
            DiasHorariosMedicos dia = null;
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion("SELECT Id_hor_dxh, Dia_dxh FROM DIASHORARIOSMEDICOS WHERE Id_hor_dxh = " + id_hor);

            if (reader.Read())
            {
                int id_hor_dxh= (int)reader["id_hor_dxh"];
                char dia_dxh= (char)reader["Dia_dxh"];

                dia = new DiasHorariosMedicos(id_hor, dia_dxh);
            }

            reader.Close();
            accesoBaseDatos.cerrarConexion();

            return dia;
        }

        public List<DiasHorariosMedicos> obtenerDiasXLegajo(string legajo)
        {
            query = "SELECT Id_hor_dxh, Dia_dxh FROM DiasHorariosMedicos INNER JOIN HorariosMedicos ON Id_hor = Id_hor_dxh WHERE LegajoMedico_hor = @Legajo";

            List<SqlParameter> parametros = new List<SqlParameter> {
                new SqlParameter("@Legajo", legajo),
            };
            SqlDataReader reader = accesoBaseDatos.ejecutarConDevolucion(query, parametros);
            List<DiasHorariosMedicos> dias = new List<DiasHorariosMedicos>();

            while (reader.Read())
            {
                DiasHorariosMedicos dia = new DiasHorariosMedicos();
                dia.Id_hor = (int)reader["Id_hor_dxh"];
                dia.Dia = (char)reader["Dia_dxh"].ToString()[0];

                dias.Add(dia);
            }
            reader.Close();
            return dias;
        }
    }
}
