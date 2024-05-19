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
        public static List<Articulo> ArticulosFiltrados { get; set; }
        public static List<int> ArticulosFiltradosCantidad { get; set; }
        public static decimal Total { get; set; }

        static Carrito()
        {
            ContadorArticulos = 0;
            ArticulosAgregados = new List<Articulo> { };
            Total = 0;
        }

        public static void EliminarArticuloXID(int id)
        {
            for (int i = 0; i < ArticulosAgregados.Count; i++)
            {

                Articulo articulo = ArticulosAgregados[i];
                if(articulo.ID == id)
                {
                    ArticulosAgregados.Remove(articulo);
                    ArticulosFiltrados.Remove(articulo); // 
                    break;
                }   
            }
        }

        public static void CargarTotalActual()
        {
            foreach (Articulo articulo in ArticulosAgregados)
            {
                Total += articulo.Precio;
            }

        }

        public static void ListaArticulosFiltrados() // A CONFIRMAR 
        {
            ArticulosFiltrados = new List<Articulo> { };

           // List<Articulo> ListaArticulosOrdenados_aux = new List<Articulo> ();

            ArticulosFiltradosCantidad = new List<int> { };
            
            Articulo articulo_aux = new Articulo();    

            int x = 0, y=0;

            // Ordenar lista articulo agregados
            List<Articulo> articulosOrdenados = ArticulosAgregados.OrderBy(a => a.ID).ToList(); // A es una expresion lambda que dice de donde se utilizara para ordenar la lista.

           for (x=0; x<articulosOrdenados.Count; x++)
            {
                foreach (Articulo articulo in articulosOrdenados)
                {
                    y = 0;

                    if (articulo.ID == x+1)
                    {
                        y++;
                        articulo_aux = articulo;
                    }
                }
                ArticulosFiltradosCantidad.Add(y);
                ArticulosFiltrados.Add(articulo_aux);
            }
           
        }


    }
}