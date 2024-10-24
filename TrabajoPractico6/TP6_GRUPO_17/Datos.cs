using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace TP6_GRUPO_17
{
    public class Datos
    {
        private string consulta;
        private SqlConnection conexion;
        public SqlCommand Comando { get; set; }

        public Datos()
        {
            consulta = "Data Source = localhost\\sqlexpress; Initial Catalog = Neptuno; Integrated Security = True";
            conexion = new SqlConnection(consulta);
        }

        private void SetParametros(string parametro, object valor)
        {
            Comando.Parameters.AddWithValue(parametro, valor);
        }
        public void setConsultaDeLectura(string consulta)
        {   
            conexion.Open();
            this.consulta = consulta;
            Comando = new SqlCommand(consulta, conexion);
        }
        public SqlDataReader getConsultaDeLectura()
        {
            SqlDataReader reader = Comando.ExecuteReader();
            return reader;
        }


        public void Cerrar()
        {
            conexion.Close();
        }
    }
}