using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioEspecialidad
    {
        private DaoEspecialidad daoEspecialidad = new DaoEspecialidad();

        public Especialidad buscarEspecialidad(int id_es)
        {
            return daoEspecialidad.buscarEspecialidad(id_es);
        }
        public List<Especialidad> obtenerTodos()
        {
            return daoEspecialidad.obtenerEspecialidades();
        }
    }
}
