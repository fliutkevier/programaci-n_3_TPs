using DAO;
using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class NegocioProvincia
    {
        private DaoProvincia daoProvincia = new DaoProvincia();


        public Provincia buscarProvincia(int id_pro)
        {
            return daoProvincia.buscarProvincia(id_pro);
        }
        public int buscarProvinciaXNombre(string nombre_pro)
        {
            return daoProvincia.buscarId(nombre_pro);
        }

        public List<Provincia> obtenerTodos()
        {
            return daoProvincia.obtenerProvincias();
        }

    }
}
