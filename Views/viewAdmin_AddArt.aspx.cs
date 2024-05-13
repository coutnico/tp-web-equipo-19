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
    }
}