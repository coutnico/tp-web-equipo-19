using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace tp_web_equipo_19.Models
{
    public static class Carrito
    {
        public static int ContadorArticulos { get; set; }
        public static List<Articulo> ArticulosAgregados { get; set; }

        static Carrito()
        {
            ContadorArticulos = 0;
            ArticulosAgregados = new List<Articulo> { };
        }

    }
}