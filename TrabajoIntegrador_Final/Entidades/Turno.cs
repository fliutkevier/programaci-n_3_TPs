using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        public int Id { get; set; }
        public string Legajo { get; set; }
        public string DniPaciente { get; set; }
        public DateTime DiaHorario { get; set; }
        public string Observacion { get; set; }
        public bool Presente { get; set; }

        public Turno() { }

        public Turno(int id, string legajo, string dniPaciente, DateTime diaHorario, string observacion, bool presente)
        {
            Id = id;
            Legajo = legajo;
            DniPaciente = dniPaciente;
            DiaHorario = diaHorario;
            Observacion = observacion;
            Presente = presente;
        }


    }
}
