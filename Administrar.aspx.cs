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
    public partial class Administrar : System.Web.UI.Page
    {
        public List<Producto> ListaProductos { get; set; }

        public bool filtroAvanzado { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["administrar"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else {
                filtroAvanzado = chkFiltroAvanzado.Checked;
                ProductoNegocio negocio = new ProductoNegocio();

                Session.Add("listaProductos", negocio.listaProductos()); ;
                dgvProductos.DataSource = Session["listaProductos"];
                dgvProductos.DataBind();
            }

            if (filtroAvanzado) {
                CategoriaNegocio categorias = new CategoriaNegocio();
                List<Categoria> listaCat = categorias.listaCategorias();

                if (drpCategoria.Items.Count == 0)
                {
                    drpCategoria.Items.Insert(0, "");
                    foreach (var cat in listaCat)
                    {

                        drpCategoria.Items.Insert(cat.Id, cat.Descripcion);
                    }

                    drpCategoria.DataBind();
                }

                MarcaNegocio marcas = new MarcaNegocio();
                List<Marca> listaMar = marcas.listaMarcas();

                if (drpMarca.Items.Count == 0)
                {
                    drpMarca.Items.Insert(0, "");

                    foreach (var cat in listaMar)
                    {

                        drpMarca.Items.Insert(cat.Id, cat.Descripcion);
                    }

                    drpMarca.DataBind();
                }

            }
        }

        protected void dgvProductos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int index = Convert.ToInt32(e.CommandArgument);

                string IdProducto = dgvProductos.Rows[index].Cells[0].Text;

                Response.Redirect("AdministrarProducto.aspx?codigo=" + IdProducto);
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdministrarProducto.aspx");
        }

        protected void btnBuscar_Click(object sender, EventArgs e)
        {
            //seguir desde acá
        }
    }
}