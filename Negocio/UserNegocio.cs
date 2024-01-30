using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class UserNegocio
    {
        public bool Login(User user)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.Consulta("Select id, email, pass, nombre, apellido, urlImagenPerfil, admin from Users Where email=@email and pass=@pass");
                datos.setearParametro("@email", user.email);
                datos.setearParametro("@pass", user.pass);
                datos.Leer();

                if (datos.Lector.Read())
                {
                    user.Id = (int)datos.Lector["id"];
                    user.admin = (bool)datos.Lector["admin"];
                    if (!(datos.Lector["nombre"] is DBNull))
                        user.nombre= (string)datos.Lector["nombre"];
                    if (!(datos.Lector["apellido"] is DBNull))
                         user.apellido = (string)datos.Lector["apellido"];
                    if (!(datos.Lector["urlImagenPerfil"] is DBNull))
                          user.urlImagenPerfil = (string)datos.Lector["urlImagenPerfil"];
                        

                    return true;

                }
                else return false;


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void CrearCuenta(User user) {

            AccesoDatos datos = new AccesoDatos();
            try
            {
                string consulta = "insert into USERS(email,pass,nombre,apellido, admin) values ('" + user.email + "','" + user.pass + "','" + user.nombre + "','" + user.apellido + "', 0);";
                datos.Consulta(consulta);
                datos.Insertar();


            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally {
                datos.cerrarConexion();
            }

        }

        public static string UrlImagenValida(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl) || !UrlExists(imageUrl))
            {
                return "https://img.freepik.com/vector-premium/vector-icono-imagen-predeterminado-falta-pagina-imagen-diseno-sitio-web-o-aplicacion-movil-no-hay-foto-disponible_87543-7509.jpg?w=740";
            }
            else
            {
                return imageUrl;
            }
        }

        private static bool UrlExists(string url)
        {
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "HEAD";
                request.AllowAutoRedirect = false;
                request.Timeout = 5000;

                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        if (response.Headers["Location"] != null)
                        {
                            string redirectedUrl = response.Headers["Location"];
                            return UrlExists(redirectedUrl);
                        }
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (WebException)
            {
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

    }


}
