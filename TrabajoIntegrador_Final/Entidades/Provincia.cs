using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Provincia
    {
        public int Id { get; set; }
        public string Nombre { get; set; }

        public Provincia() { }
        public Provincia(int id, string nombre)
        {
            Id= id;
            Nombre= nombre;
        }
        public override string ToString()
        {
            return Nombre;
        }
    }
}
