using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using tp_web_equipo_19.Models;

namespace tp_web_equipo_19.Views
{
    public partial class viewCarrito : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RptArticulos.DataSource = Carrito.ArticulosAgregados;
                RptArticulos.DataBind();
            }
        }

        protected void ibEliminar_Click(object sender, ImageClickEventArgs e)
        {

        }
    }
}