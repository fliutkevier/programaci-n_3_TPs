using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioTurno
    {
        private DaoTurno daoTurno = new DaoTurno();
        public bool cargarTurno(Turno turno)
        {
            //if (validarDisponibilidad(turno))
            //{
                 return daoTurno.cargarTurno(turno);
            //}
            //else
            //{
               //"El turno no está disponible para el médico seleccionado."
            //}
        }

        /*private bool validarDisponibilidad(Turno turno)
        {
            return daoTurno.validarDisponibilidad(turno.Legajo, turno.DiaHorario);
        }*/

        public List<Turno> obtenerTurnosPorMedico(string legajoMedico)
        {
            return daoTurno.obtenerTurnosMEDICO(legajoMedico);
        }

        public List<TimeSpan> obtenerHorariosDisponibles(string legajo, DateTime diaSeleccionado, List<TimeSpan> horarios)
        {
            List<Turno> turnos = daoTurno.obtenerTurnosMEDICO(legajo);
            var horariosAux = new List<TimeSpan>(horarios);

            foreach (Turno turno in turnos)
            {
                if(turno.DiaHorario.Date == diaSeleccionado.Date && horarios.Contains(turno.DiaHorario.TimeOfDay))
                {
                    horariosAux.Remove(turno.DiaHorario.TimeOfDay);
                }
            }

            return horariosAux;
        }

        public bool modificar(Turno turno)
        {
            return daoTurno.Modificar(turno);
        }

        public List<Turno> filtrarTurno(string filtro)
        {
            return daoTurno.filtrarTurnosxPaciente(filtro);
        }
    }
}
