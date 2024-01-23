using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;

namespace Negocio
{
    public class ProductoNegocio
    {

        public List<Producto> listaProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Consulta("SELECT A.Id, Codigo, Nombre,A.Descripcion, M.Descripcion as Marca,C.Descripcion as Categoria,ImagenUrl,Precio,A.IdMarca,A.IdCategoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE M.Id=A.IdMarca and C.Id=A.IdCategoria");
                datos.Leer();

                while (datos.Lector.Read())
                {
                    Producto aux = new Producto();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];

                    listaProductos.Add(aux);
                }
                return listaProductos;

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

        public void agregar(Producto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.Consulta("insert into ARTICULOS(Codigo, Nombre,Descripcion,ImagenUrl,Precio, IdCategoria,IdMarca)Values(@Codigo,@Nombre,@Descripcion,@ImagenUrl,@Precio,@IdCategoria,@IdMarca)");
                datos.setearParametro("@Codigo", nuevo.Codigo);
                datos.setearParametro("@Nombre", nuevo.Nombre);
                datos.setearParametro("@Descripcion", nuevo.Descripcion);
                datos.setearParametro("@ImagenUrl", nuevo.ImagenUrl);
                datos.setearParametro("@Precio",nuevo.Precio);
                datos.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                datos.setearParametro("@IdMarca", nuevo.Marca.Id);
                datos.Insertar();
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

        public void modificar(Producto producto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.Consulta("update ARTICULOS set codigo=@codigo,nombre=@nombre,descripcion=@descripcion,idMarca=@idMarca,idCategoria=@idCategoria,imagenUrl=@img, precio=@precio where Id=@id");
                datos.setearParametro("@codigo",producto.Codigo);
                datos.setearParametro("@nombre",producto.Nombre);
                datos.setearParametro("@descripcion",producto.Descripcion);
                datos.setearParametro("@idMarca",producto.Marca.Id);
                datos.setearParametro("@idCategoria",producto.Categoria.Id);
                datos.setearParametro("@img",producto.ImagenUrl);
                datos.setearParametro("@precio",producto.Precio);
                datos.setearParametro("@id",producto.Id);

                datos.Insertar();

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

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.Consulta("DELETE FROM ARTICULOS where Id=@id");
                datos.setearParametro("@id", id);
                datos.Insertar();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<Producto> buscar(string min, string max, string categoria, string marca)
        {
            if (min == "") min = "0";
            if (max == "") max = "0";


                List<Producto> productosEncontrados = new List<Producto>();
                AccesoDatos datos = new AccesoDatos();
            string consulta = "SELECT A.Id, Codigo, Nombre,A.Descripcion, M.Descripcion as Marca,C.Descripcion as Categoria,ImagenUrl,Precio,A.IdMarca,A.IdCategoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE M.Id=A.IdMarca and C.Id=A.IdCategoria ";
                try
                {

                        if (min != "0" && max!= "0")
                            consulta +=" and precio between " + min + " and " + max;
                        else if (min == "0" && max != "0")
                            consulta += " and precio <= " + max;
                        else if (min != "0" && max =="0")
                            consulta += " and precio >= " + min;


                if(categoria!="")consulta+= "and C.descripcion = '"+categoria+"'";

                if (marca != "") consulta +="and M.descripcion= '"+marca+"'";

                    datos.Consulta(consulta);
                    datos.Leer();
                    while (datos.Lector.Read())
                    {
                        Producto aux = new Producto();
                        aux.Id = (int)datos.Lector["Id"];
                        aux.Codigo = (string)datos.Lector["Codigo"];
                        aux.Nombre = (string)datos.Lector["Nombre"];
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                        aux.Marca = new Marca();
                        aux.Marca.Id = (int)datos.Lector["IdMarca"];
                        aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                        aux.Categoria = new Categoria();
                        aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                        aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                        aux.Precio = (decimal)datos.Lector["Precio"];

                        productosEncontrados.Add(aux);
                    }

                    return productosEncontrados;

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

        public bool validarPrecio(string valor)
        {
            bool valido = true;
            foreach (char caracter in valor)
            {
                if (char.IsNumber(caracter))
                    valido = true;
                else if (caracter == '.')
                    valido = true;
                else
                    valido = false;
            }
            return valido;
        }

        public bool validarBusqueda(string minimo, string maximo)
        {
            decimal min, max;

            if (minimo == "" || maximo == "")
                return true;

            min = decimal.Parse(minimo);
            max = decimal.Parse(maximo);

            if (min <= max)
                return true;
            else
                return false;

        }

        public Producto detalleProducto(int id) {

            AccesoDatos datos = new AccesoDatos();
            Producto prod = new Producto();

            string consulta = "Select * from articulos where Id="+id+";";

            datos.Consulta(consulta);
            datos.Leer();
            while (datos.Lector.Read())
            {
                prod.Id = (int)datos.Lector["Id"];
                prod.Codigo = (string)datos.Lector["Codigo"];
                prod.Nombre = (string)datos.Lector["Nombre"];
                prod.Descripcion = (string)datos.Lector["Descripcion"];
                prod.ImagenUrl = (string)datos.Lector["ImagenUrl"];
                prod.Precio = (decimal)datos.Lector["Precio"];

            }

            return prod;

        }

        public static string UrlImagenValida(string imageUrl)
        {
            if (string.IsNullOrEmpty(imageUrl) || !UrlExists(imageUrl))
            {
                return "https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Imagen_no_disponible.svg/300px-Imagen_no_disponible.svg.png";
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
                HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(url);
                request.Method = "HEAD";
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                {
                    return (response.StatusCode == HttpStatusCode.OK);
                }
            }
            catch
            {
                return false;
            }
        }
    }


}

