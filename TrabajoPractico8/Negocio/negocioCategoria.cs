using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using Entidades;

namespace Negocio
{
    public class NegocioCategoria
    {
        private Dato dato;

        public NegocioCategoria()
        {
            this.dato = new Dato();
        }

        public bool insertarSucursal(Sucursal sucursal)
        {
            if (dato.agregarSucursal(sucursal))
            {
                return true;
            }

            return false;
        }

        public bool eliminarSucursal(int id)
        {
            if (dato.eliminarSucursal(id))
            {
                return true;
            }
            return false;
        }

        public bool existe(String id)
        {
            String consulta = "Select * FROM Sucursal WHERE Id_Sucursal = " + id;
            if (dato.existe(consulta))
            {
                return true;
            }
            return false;
        }
    }
}
