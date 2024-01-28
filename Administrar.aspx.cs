using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Negocio;

namespace TPFinalNivel3RomeroMicaela
{
    public partial class Administrar : System.Web.UI.Page
    {
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
    }
}