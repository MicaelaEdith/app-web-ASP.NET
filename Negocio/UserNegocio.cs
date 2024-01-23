using System;
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
                        user.nombre = (string)datos.Lector["nombre"];
                    if (!(datos.Lector["apellido"] is DBNull))
                        user.apellido = (string)datos.Lector["apellido"];
                    if (!(datos.Lector["imagenPerfil"] is DBNull))
                        user.urlImagenPerfil = (string)datos.Lector["urlImagenPerfil"];

                    Console.WriteLine("paso");
                    
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
    }
}
