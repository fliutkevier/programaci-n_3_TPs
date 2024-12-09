using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioHorariosMedicos
    {
        private DaoHorariosMedicos daoHorarios = new DaoHorariosMedicos();

        public void cargarHorario(HorariosMedicos horario)
        {
            daoHorarios.insertarHorario(horario);
        }
        public HorariosMedicos buscarHorario(string legajoMedico)
        {
            return daoHorarios.buscarHorarios(legajoMedico);
        }
        public List<HorariosMedicos> obtenerTodos()
        {
            return daoHorarios.obtenerHorarios();
        }

        public int buscarUltimoID()
        {
            return daoHorarios.obtenerUltimoID();
        }

        public List<TimeSpan> obtenerXLegajo(string legajo)
        {
            HorariosMedicos rangoHorario = daoHorarios.buscarHorarios(legajo);

            List<TimeSpan> horarios = new List<TimeSpan>();
            TimeSpan horaAux = rangoHorario.HoraInicio;
            horarios.Add(horaAux);

            while (rangoHorario.HoraFin > horarios.Last())
            {
                horaAux = horaAux.Add(TimeSpan.FromHours(1));
                horarios.Add(horaAux);
            }

            return horarios;
        }
    }
}
