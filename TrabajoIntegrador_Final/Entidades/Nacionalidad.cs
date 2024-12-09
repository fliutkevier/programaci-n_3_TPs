using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Nacionalidad
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Nacionalidad() { }

        public Nacionalidad(int id, string nombre)
        {
            Id = id;
            Nombre = nombre;
        }
    }
}
