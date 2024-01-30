using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;
using Dominio;

namespace TPFinalNivel3RomeroMicaela
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

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            String busqueda = txtBuscar.Text;
            ProductoNegocio negocio = new ProductoNegocio();
            ListaProductosBusqueda = negocio.busquedaRapida(busqueda);

        }
    }
}