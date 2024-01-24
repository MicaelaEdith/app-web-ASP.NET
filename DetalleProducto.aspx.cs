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
    public partial class DetalleProducto : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string id = Request.QueryString["id"].ToString();

            if (!string.IsNullOrEmpty(id))
            {
                Producto prod = new Producto();
                ProductoNegocio producto = new ProductoNegocio();
                prod = producto.detalleProducto(int.Parse(id));

                if (producto != null)
                {
                    txtTitulo.Text = prod.Nombre;
                    txtPrecio.InnerText = "$ "+prod.Precio.ToString("F2")+ ".-";
                    txtDescripcion.InnerText = prod.Descripcion;
                    imgProducto.Src = prod.ImagenUrl;
                }

            }

        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}