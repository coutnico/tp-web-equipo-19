using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tp_web_equipo_19.Models;

namespace tp_web_equipo_19.Views
{
    public partial class viewArticulos : System.Web.UI.Page
    {
        SiteMaster master;
        protected void Page_Load(object sender, EventArgs e)
        {

           Articulo articulo = new Articulo();  
            
           ArticuloNegocio articuloNegocio = new ArticuloNegocio();

           List<Articulo> lista_articulos = articuloNegocio.ListarArticulos();
                       

            //Enlazo con repeater
            reapeter_articulos.DataSource = lista_articulos;
            reapeter_articulos.DataBind(); // VINCULA LOS DATOS

        }

        protected void btnAgregarCarrito_Click(object sender, EventArgs e)
        {

            master = (SiteMaster)this.Master;

            Carrito.ContadorArticulos++;

            master.Contador = Carrito.ContadorArticulos.ToString();



        }
    }
}