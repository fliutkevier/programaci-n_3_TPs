using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Sucursal
    {
        private string _Nombre;
        private string _Descripcion;
        private int _idProvincia;
        private string _Direccion;

        public Sucursal()
        {  }

        public string Nombre { get => _Nombre; set => _Nombre = value; }
        public string Descripcion { get => _Descripcion; set => _Descripcion = value; }
        public int IdProvincia { get => _idProvincia; set => _idProvincia = value; }
        public string Direccion { get => _Direccion; set => _Direccion = value; }
    }
}
