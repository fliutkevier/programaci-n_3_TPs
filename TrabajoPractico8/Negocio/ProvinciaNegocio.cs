using Data;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class ProvinciaNegocio
    {
        private Dato dato;
        public ProvinciaNegocio()
        {
            dato = new Dato();
        }

        public List<Provincia> GetProvincias()
        {
            return dato.GetProvincias();
        }
    }
}
