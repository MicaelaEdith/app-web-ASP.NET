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
    public partial class AdministrarProducto : System.Web.UI.Page
    {
        int IdProducto;
        protected void Page_Load(object sender, EventArgs e)
        {
           
                if (Request.QueryString["codigo"] != null)
                {
                    IdProducto = int.Parse(Request.QueryString["codigo"]);

                    Producto producto = new Producto();
                    ProductoNegocio negocio = new ProductoNegocio();

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

                    producto = negocio.detalleProducto(IdProducto);

                    IdProducto = producto.Id;

                    imgProducto.Src = producto.ImagenUrl;
                    txtCodigo.Text = producto.Codigo;
                    txtNombre.Text = producto.Nombre;
                    txtDescripcion.Text = producto.Descripcion;
                    txtPrecio.Text = producto.Precio.ToString();
                    drpCategoria.SelectedValue = producto.Categoria.Id.ToString();
                    drpMarca.SelectedValue = producto.Marca.Id.ToString();

                }

            
        }

        protected void EliminarProducto_Click(object sender, EventArgs e)
        {
            Response.Redirect("EliminarProducto.aspx?codigo=" + IdProducto);
        }

        protected void Aceptar_Click(object sender, EventArgs e)
        {


        }

        protected void Cancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Administrar.aspx");
        }
    }

}