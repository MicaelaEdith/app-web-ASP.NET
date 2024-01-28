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
    public partial class Favoritos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
            {
                Response.Redirect("Default.aspx");
            }
            else {

                User user = (User)Session["user"];
                UserNegocio negocio = new UserNegocio();

                txtNombre.Text = user.nombre;
                txtApellido.Text = user.apellido;
                user.urlImagenPerfil = UserNegocio.UrlImagenValida(user.urlImagenPerfil);
                imgPerfil.Src = user.urlImagenPerfil;
                imgPerfil.Alt = user.nombre;


            }
        }

        protected void btnSalir_Click(object sender, EventArgs e)
        {
            Session.Clear();
            Response.Redirect("Default.aspx");
        }

        protected void btnAdministrar_Click(object sender, EventArgs e)
        {
            if (Session["administrar"] != null)
            {
                Response.Redirect("Administrar.aspx");
            }
            else {
                Response.Redirect("Default.aspx");

            }

        }

        protected void btnModificarPerfil_Click(object sender, EventArgs e)
        {

        }
    }
}