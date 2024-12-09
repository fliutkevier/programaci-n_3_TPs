using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioInforme
    {
        private DaoInforme informeDao = new DaoInforme();

        public int totalPacientes(DateTime fechaInicio, DateTime fechaFin)
        {
            return informeDao.contarTodos(fechaInicio, fechaFin);
        }

        public int totalPresentes(DateTime fechaInicio, DateTime fechaFin)
        {
            return informeDao.contarPresentes(fechaInicio, fechaFin);
        }

        public int totalAusentes(DateTime fechaInicio, DateTime fechaFin)
        {
            return informeDao.contarAusentes(fechaInicio, fechaFin);
        }

        public float porcPresentes(DateTime fechaInicio, DateTime fechaFin)
        {
            return informeDao.porcentajePresentes(fechaInicio, fechaFin);
        }

        public float porcAusentes(DateTime fechaInicio, DateTime fechaFin)
        {
            return informeDao.porcentjeAusentes(fechaInicio, fechaFin);
        }
        public List<Informe> obtenerPresentes(DateTime fechaInicio, DateTime fechaFin)
        {
            return informeDao.obtenerPresentes(fechaInicio, fechaFin);
        }

        public List<Informe> obtenerAusentes(DateTime fechaInicio, DateTime fechaFin)
        {
            return informeDao.obtenerAusentes(fechaInicio, fechaFin);
        }
    }
}
