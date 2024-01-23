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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {           
            if (Session["user"] != null)
            {
                Response.Redirect("Default.aspx", false);
            }            
        }

        protected void btnIngresar_Click(object sender, EventArgs e)
        {
            User user = new User();
            UserNegocio negocio = new UserNegocio();

            try
            {
                user.email = txtUser.Text;
                user.pass = txtPassword.Text;

                if (negocio.Login(user))
                {
                    Session.Add("user", user);
                    Console.WriteLine("Redirección exitosa");
                    Response.Redirect("Favoritos.aspx", false);
                }
                else
                {
                    lblIncorrecto.Visible = true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine("falló");
                Session.Add("Error ", ex.ToString());
            }
        }
    }
}
