using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioLocalidad
    {
        private DaoLocalidad daoLocalidad = new DaoLocalidad();

        public Localidad buscarLocalidad(int id_loc)
        {
            return daoLocalidad.buscarLocalidad(id_loc);
        }

        public List<Localidad> obtenerTodos()
        {
            return daoLocalidad.obtenerLocalidades();
        }

        public List<Localidad> buscarLocalidadesXProvincia(int idProvincia)
        {
            return daoLocalidad.ObtenerLocalidadesXProvincia(idProvincia);
        }
    }
}
