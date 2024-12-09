using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DiasHorariosMedicos
    {
        public int Id_hor {  get; set; }
        public char Dia { get; set; }

        public DiasHorariosMedicos() { }

        public DiasHorariosMedicos(int id_hor, char dia)
        {
            Id_hor = id_hor;
            Dia = dia;
        }

    }
}
