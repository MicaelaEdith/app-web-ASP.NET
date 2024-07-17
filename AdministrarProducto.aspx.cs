using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Proyecto_FlowerPower
{
    public partial class AdministrarProducto : System.Web.UI.Page
    {
        int IdProducto;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["administrar"] == null)
                Response.Redirect("Default.aspx");

            if (Request.QueryString["codigo"] != null)
                IdProducto = int.Parse(Request.QueryString["codigo"]);

            CategoriaNegocio categorias = new CategoriaNegocio();
            List<Categoria> listaCat = categorias.listaCategorias();

            MarcaNegocio marcas = new MarcaNegocio();
            List<Marca> listaMar = marcas.listaMarcas();


            drpCategoria.DataSource = listaCat;
            drpCategoria.DataValueField = "Id";
            drpCategoria.DataTextField = "Descripcion";

            drpCategoria.DataBind();

            drpMarca.DataSource = listaMar;
            drpMarca.DataValueField = "Id";
            drpMarca.DataTextField = "Descripcion";

            drpMarca.DataBind();

            if (!IsPostBack)
            {
                if (Request.QueryString["codigo"] != null)
                {
                    Producto producto = new Producto();
                    ProductoNegocio negocio = new ProductoNegocio();

                    producto = negocio.detalleProducto(IdProducto);

                    imgProducto.Src = producto.ImagenUrl;
                    txtCodigo.Text = producto.Codigo;
                    txtNombre.Text = producto.Nombre;
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecio.Text = producto.Precio.ToString();
                    drpCategoria.SelectedValue = producto.Categoria.Id.ToString();
                    drpMarca.SelectedValue = producto.Marca.Id.ToString();
                    producto.ImagenUrl = ProductoNegocio.UrlImagenValida(producto.ImagenUrl);
                    imgProducto.Src = producto.ImagenUrl;
                    imgProducto.Alt = producto.Nombre;

                }
            }
        }

        protected void EliminarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarProducto.aspx?codigo=" + IdProducto);
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {
            Producto prod = new Producto();
            ProductoNegocio negocio = new ProductoNegocio();

            prod.Codigo = txtCodigo.Text;
            prod.Nombre = txtNombre.Text;
            prod.Descripcion = txtDescripcion.Text;
            prod.ImagenUrl = txtUrlImg.Text;
            prod.Precio = decimal.Parse(txtPrecio.Text);

            prod.Marca = new Marca();
            prod.Marca.Id = int.Parse(drpMarca.SelectedValue);
            prod.Categoria = new Categoria();
            prod.Categoria.Id = int.Parse(drpCategoria.SelectedValue);

            if (Request.QueryString["codigo"] != null)
            {
                prod.Id = int.Parse(Request.QueryString["codigo"]);
                negocio.modificar(prod);
            }
            else { 
                negocio.agregar(prod);
                Response.Redirect("Administrar.aspx");
            } 
        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrar.aspx");
        }
    }

}