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
    public partial class DetalleProducto : System.Web.UI.Page
    {
        public Producto prod = new Producto();
        protected void Page_Load(object sender, EventArgs e)
        {

            string id = Request.QueryString["id"].ToString();

            if (!string.IsNullOrEmpty(id))
            {
                
                ProductoNegocio producto = new ProductoNegocio();
                prod = producto.detalleProducto(int.Parse(id));

                if (producto != null)
                {
                    txtTitulo.Text = prod.Nombre;
                    txtPrecio.InnerText = "$ "+prod.Precio.ToString("F2")+ ".-";
                    txtDescripcion.InnerText = prod.Descripcion;
                    prod.ImagenUrl = ProductoNegocio.UrlImagenValida(prod.ImagenUrl);
                    imgProducto.Src = prod.ImagenUrl;
                    imgProducto.Alt = prod.Nombre;

                }
            }
        }
    }
}