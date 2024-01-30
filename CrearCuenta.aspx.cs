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
    public partial class CrearCuenta : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] != null)
            {
                Response.Redirect("Default.aspx", false);
            }

        }

        protected void btnRegistrarse_Click(object sender, EventArgs e)
        {

            try
            {
                if (txtPassword1.Text == txtPassword2.Text)
                {

                    User user = new User();
                    UserNegocio negocio = new UserNegocio();

                    user.email = txtEmail.Text;
                    user.nombre = txtNombre.Text;
                    user.apellido = txtApellido.Text;
                    user.pass = txtPassword1.Text;

                    negocio.CrearCuenta(user);
                    Response.Redirect("Login.aspx");

                }
                else
                {

                    lblErrorPass.Visible = true;
                }
            }
            catch (Exception ex)
            {
                Session.Add("Error ", ex.ToString());
                throw ex;
            }


        }
    }
}