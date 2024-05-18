using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tp_web_equipo_19.Models;

namespace tp_web_equipo_19.Views
{
    public partial class viewDetallada : System.Web.UI.Page
    {

        private ArticuloNegocio articuloNegocio = new ArticuloNegocio();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                int id = Convert.ToInt32(Session["IdArticulo"]);

                foreach (Articulo articulo in articuloNegocio.ListarArticulos())
                {
                    if (articulo.ID == id)
                    {
                        ImagenPrincipalArticulo.Src = articulo.ImagenURl;
                        NombreProducto.InnerText = articulo.Nombre;
                        lblCategoria.Text = "Categoria: " + articulo.Categoria;
                        DescripcionArticulo.Text = articulo.Descripcion;
                        lblMarca.Text = "Marca: " + articulo.Marca;
                        PrecioProducto.Text = "$" + articulo.Precio.ToString();
                        break;
                    }
                }
            }

        }

        protected void Atras_Click(object sender, EventArgs e)
        {

        }

        protected void Siguiente_Click(object sender, EventArgs e)
        {

        }

        protected void btnAgregarAlCarrito_Click(object sender, EventArgs e)
        {

        }
    }
}