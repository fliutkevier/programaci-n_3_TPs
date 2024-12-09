using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class AccesoBaseDatos
    {
        private string _conexionQuery;
        private SqlConnection _conexion;
        private SqlCommand _comando;

        public AccesoBaseDatos() {
            _conexionQuery = "Data Source=localhost\\SQLEXPRESS; Initial Catalog = ClinicaBD_TPINT_PR3; Integrated Security=True";
            _conexion = new SqlConnection(_conexionQuery);

        }
        
        public SqlDataReader ejecutarConDevolucion(string query, List<SqlParameter> parametros = null)
        {
           if (_conexion.State == System.Data.ConnectionState.Closed) //CHEQUEa QUE LA CONEXION ESTE ABIERTA SI NO ES ASI, SE ABRE
            {
                _conexion.Open();
            }

            _comando = new SqlCommand(query, _conexion);
            if (parametros != null)
            {
                _comando.Parameters.AddRange(parametros.ToArray());
            }
            
                _comando.ExecuteReader().Close();
            
            SqlDataReader reader = _comando.ExecuteReader();
            return reader;
            
        }

        public bool ejecutarSinDevolucion(string query)
        {
            if (_conexion.State == System.Data.ConnectionState.Closed) //CHEQUEa QUE LA CONEXION ESTE ABIERTA SI NO ES ASI, SE ABRE
            {
                _conexion.Open();
            }

            _comando = new SqlCommand(query, _conexion);
            if(_comando.ExecuteNonQuery() == 1)
            {
                _conexion.Close();
                
                return true;
            }

            _conexion.Close();
            return false;
        }

        public bool ejecutarSinDevolucion(string query, List<SqlParameter> parametros)
        {

            if (_conexion.State == System.Data.ConnectionState.Closed) //CHEQUEa QUE LA CONEXION ESTE ABIERTA SI NO ES ASI, SE ABRE
            {
                _conexion.Open();
            }
            _comando = new SqlCommand(query, _conexion);
            if (parametros != null)
            {
                _comando.Parameters.AddRange(parametros.ToArray());
            }

            if (_comando.ExecuteNonQuery() == 1)
            {
                _conexion.Close();

                return true;
            }

            _conexion.Close();
            return false;
        }

       public void cerrarConexion()
        {
            _conexion.Close();
        }

    }
}
