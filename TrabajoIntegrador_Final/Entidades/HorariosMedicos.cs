using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class HorariosMedicos
    {
        public string LegajoMedico { get; set; }
        public TimeSpan HoraInicio { get; set; }
        public TimeSpan HoraFin {  get; set; }

        public HorariosMedicos() { }

        public HorariosMedicos(string legajomedico, TimeSpan horainicio, TimeSpan horafin)
        {
            LegajoMedico = legajomedico;
            HoraInicio = horainicio;
            HoraFin = horafin;
        }
    }
}
