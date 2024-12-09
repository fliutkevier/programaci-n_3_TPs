using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Localidad
    {
        public int Id { get; set; }
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }
        public Localidad() { }
        public Localidad (int id, int idProvincia, string nombre)
        {
            Id = id;
            IdProvincia = idProvincia;
            Nombre = nombre;
            
        }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
