using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Especialidad
    {   
        public int Id { get; set; }
        public string Descripcion { get; set; }

        public Especialidad() { }

        public Especialidad(int id, string descripcion)
        {
            Id = id;
            Descripcion = descripcion;
        }
    }
}
