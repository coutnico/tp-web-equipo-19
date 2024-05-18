using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tp_web_equipo_19.Models;

namespace tp_web_equipo_19.Views
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Marca marca = new Marca();  
            MarcaNegocio marcaNegocio = new MarcaNegocio();

            List<Marca> marca_list = marcaNegocio.ListarMarcas();

            if (!IsPostBack)
            {
                try { 
                listMarca.DataSource = marca_list;
                listMarca.DataTextField = "Descripcion"; // Nombre del campo que se mostrará
                listMarca.DataValueField = "Id";   // Nombre del campo que se utilizará como valor
                listMarca.DataBind();
                }
                catch (Exception ex)
                {
                    
                }
            }


            Categoria categoria = new Categoria();  
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();     
            
            List<Categoria> categoria_list = categoriaNegocio.ListarCategorias();

            if (!IsPostBack)
            {
                try
                {

                    listCat.DataSource = categoria_list;
                    listCat.DataTextField = "Descripcion"; // Nombre del campo que se mostrará
                    listCat.DataValueField = "Id";   // Nombre del campo que se utilizará como valor
                    listCat.DataBind();
                }
                catch (Exception ex)
                {

                }
            }
        }

        public void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio articuloNegocio = new ArticuloNegocio();    
            Articulo articulo = new Articulo();
            List<Articulo> articulosList = new List<Articulo>();

            Imagen imagen = new Imagen();   
            ImagenNegocio imagenNegocio = new ImagenNegocio();  
            
            string mensaje;
            try { 

            articulo.Nombre = txtArticulo.Text;
            articulo.Codigo = txtCodigo.Text;
            articulo.Descripcion = txtDescripcion.Text;
            articulo.IDMarca =Convert.ToInt32(listMarca.SelectedValue);
            articulo.IDCategoria = Convert.ToInt32(listCat.SelectedValue);
            imagen.URL = txtImagenUrl.Text;
            articulo.Precio = Convert.ToDecimal(txtPrecio.Text);

            articuloNegocio.agregarArticulo(articulo);
                int x = 0;
                articulosList = articuloNegocio.ListarArticulos();
                for (x=0; x < articulosList.Count; x++ ) {
                articulo = articulosList[x]; // cargo el ultimo articulo para obtener el ultimo ID
                }
                 imagenNegocio.InsertarImagen(articulo.ID, imagen.URL); // 


                mensaje = "Cargado Correctamente ";
            // Registra el script para mostrar una alerta al usuario en el navegador
            ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('" + mensaje + "');", true);
                
            }
            catch (Exception ex)
            {
                mensaje = "Se produjo una excepción: " + ex.Message;
                // Registra el script para mostrar una alerta al usuario en el navegador
                ScriptManager.RegisterStartupScript(this, GetType(), "showalert", "alert('" + mensaje + "');", true);
            }

        }
    }
    
}