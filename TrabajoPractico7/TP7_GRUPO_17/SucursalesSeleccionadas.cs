using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP7_GRUPO_17
{
    public class SucursalesSeleccionadas
    {
        private String Session = "SucursalesSeleccionadas";
        public string session => Session;

        public void AgregarSucursal(Sucursal nuevaSucursal)
        {
       
            List<Sucursal> sucursales = HttpContext.Current.Session[Session] as List<Sucursal>;
            if (sucursales == null)
            {
                sucursales = new List<Sucursal>();
            }

            if (!sucursales.Any(s => s.IdSucursal == nuevaSucursal.IdSucursal))
            {
                sucursales.Add(nuevaSucursal);
                HttpContext.Current.Session[Session] = sucursales;
            }
            
        }


    }
}