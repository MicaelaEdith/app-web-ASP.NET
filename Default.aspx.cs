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
            CategoriaNegocio categorias = new CategoriaNegocio();
            List<Categoria> listaCat = categorias.listaCategorias();

            drpCategoria.Items.Insert(0, "");
            foreach (var cat in listaCat)
            {

                drpCategoria.Items.Insert(cat.Id, cat.Descripcion);
            }

            drpCategoria.DataBind();

            /* if (Master != null)
             {
                 List<Producto> listaBusqueda = ((master)Master).ListaProductosBusqueda;

             }*/

            ProductoNegocio negocio = new ProductoNegocio();
            ListaProductos = negocio.listaProductos();
            

            foreach (var prod in ListaProductos)
            {
                prod.ImagenUrl = ProductoNegocio.UrlImagenValida(prod.ImagenUrl);
            }
        }

        protected void btnBuscarSidebar_Click(object sender, EventArgs e)
        {
            String min = txtMin.Text;
            String max = txtMax.Text;
            String categoria = drpCategoria.SelectedValue;
            String marca = drpMarca.SelectedValue;

            ProductoNegocio negocio = new ProductoNegocio();
            ListaProductos = negocio.buscar(min, max, categoria, marca);

            foreach (var prod in ListaProductos)
            {
                prod.ImagenUrl = ProductoNegocio.UrlImagenValida(prod.ImagenUrl);
            }

        }

        protected void drpCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(drpCategoria.SelectedValue) && drpCategoria.SelectedValue != "0")
            {
                MarcaNegocio marcas = new MarcaNegocio();
                List<Marca> listaMar = marcas.listaMarcas();
                drpMarca.Items.Insert(0, "");

                foreach (var cat in listaMar)
                {

                    drpMarca.Items.Insert(cat.Id, cat.Descripcion);
                }

                drpMarca.DataBind();
            }
            else
            {
                drpMarca.Items.Clear();
                drpMarca.Items.Insert(0, new ListItem("", ""));
            }
        }
    }
}