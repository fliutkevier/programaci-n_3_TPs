using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paciente : Persona
    {
        public Paciente(string dni, string nombre, string apellido, char sexo, DateTime fechaNacimiento, string correoElectronico, string telefono, string direccion, Provincia provincia, Localidad localidad,Nacionalidad nacionalidad, bool estado)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Sexo = sexo;
            Nacimiento = fechaNacimiento;
            CorreoElectronico = correoElectronico;
            Telefono = telefono;
            Direccion = direccion;
            Provincia = provincia;
            Nacionalidad = nacionalidad;
            Localidad = localidad;
            Estado = estado;
        }
        public Paciente() { }
    }
}
