using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Contrasenia { get; set; }
        public char Tipo { get; set; }
        public string LegajoMedico { get; set; }

        public Usuario() { }

        public Usuario(int id, string nombre, string contrsenia, char tipoUsuario, string legajo)
        {
            Id = id;
            Nombre = nombre;
            Contrasenia = contrsenia;
            Tipo = tipoUsuario;
            LegajoMedico = legajo;
        }
    }

    
}
