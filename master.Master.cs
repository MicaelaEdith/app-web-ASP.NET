using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace Proyecto_FlowerPower
{
    public partial class master : System.Web.UI.MasterPage
    {
        public List<Producto> ListaProductosBusqueda
        {
            get
            {
                return Session["ListaProductosBusqueda"] as List<Producto>;
            }
            set
            {
                Session["ListaProductosBusqueda"] = value;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

    }
}