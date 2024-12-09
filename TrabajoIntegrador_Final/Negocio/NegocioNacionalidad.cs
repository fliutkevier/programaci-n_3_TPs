using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioNacionalidad
    {
        private DaoNacionalidad daoNacionalidad = new DaoNacionalidad();

        public Nacionalidad buscarNacionalidad(int id_Nac)
        {
            return daoNacionalidad.buscarNacionalidad(id_Nac);
        }
        public List<Nacionalidad> obtenerTodos()
        {
            return daoNacionalidad.obtenerNacionalidades();
        }
    }
}
