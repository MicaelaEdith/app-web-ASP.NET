using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace TPFinalNivel3RomeroMicaela
{
    public partial class Default : System.Web.UI.Page
    {
        public List<Producto> ListaProductos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            ProductoNegocio negocio = new ProductoNegocio();
            ListaProductos = negocio.listaProductos();

            foreach (var prod in ListaProductos)
            {
                prod.ImagenUrl = ProductoNegocio.UrlImagenValida(prod.ImagenUrl);
            }
        }
    }
}