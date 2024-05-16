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

        public static void EliminarArticuloXID(int id)
        {
            for (int i = 0; i < ArticulosAgregados.Count; i++)
            {

                Articulo articulo = ArticulosAgregados[i];
                if(articulo.ID == id)
                {
                    ArticulosAgregados.Remove(articulo);
                    break;
                }   
            }
        }

    }
}