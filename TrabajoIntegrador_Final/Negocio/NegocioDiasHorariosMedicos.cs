using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioDiasHorariosMedicos
    {
        private DaoDiasHorariosMedicos daoDiasHorariosMedicos = new DaoDiasHorariosMedicos();

        public void cargarDias(DiasHorariosMedicos dias)
        {
            daoDiasHorariosMedicos.insertarDia(dias);
        }
        public List<DiasHorariosMedicos> buscarDias(int id_hor)
        {
            return daoDiasHorariosMedicos.obtenerDias(id_hor);
        }

        public List<DiasHorariosMedicos> buscarDiasXLegajo(string legajo)
        {
            return daoDiasHorariosMedicos.obtenerDiasXLegajo(legajo);
        }


    }
}
