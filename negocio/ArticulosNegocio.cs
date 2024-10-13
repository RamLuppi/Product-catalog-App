using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;
using System.Data.SqlClient;

namespace negocio
{
    public class ArticulosNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT a.Id,a.Nombre,a.Descripcion,c.Descripcion 'Categoria',m.Descripcion 'Marca', a.ImagenUrl,a.Precio,a.Codigo,a.IdCategoria,a.IdMarca FROM ARTICULOS as a,CATEGORIAS as c,MARCAS as m WHERE a.IdMarca=m.Id AND a.IdCategoria=c.Id");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);

                }
                
                return lista;
            }
            catch (Exception )
            {

                throw;
                
            }
            finally
            {
                datos.cerrarConexion();
            }


        }

        public void agregar(Articulo nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion,IdMarca, IdCategoria, ImagenUrl,Precio) VALUES (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio);");
                datos.setearParametro("@Codigo",nuevo.Codigo);
                datos.setearParametro("@Nombre",nuevo.Nombre);
                datos.setearParametro("@Descripcion",nuevo.Descripcion);
                datos.setearParametro("@IdMarca",nuevo.Marca.Id);
                datos.setearParametro("IdCategoria",nuevo.Categoria.Id);
                datos.setearParametro("ImagenUrl",nuevo.ImagenUrl);
                datos.setearParametro("Precio",nuevo.Precio);

                datos.ejecutarAccion();
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

        public void modificar(Articulo modificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE ARTICULOS SET Codigo=@Codigo, Nombre= @Nombre, Descripcion=@Descripcion,IdMarca=@IdMarca, IdCategoria=@IdCategoria, ImagenUrl=@ImagenUrl,Precio=@Precio WHERE Id=@Id");
                datos.setearParametro("@Id", modificado.Id);
                datos.setearParametro("@Codigo", modificado.Codigo);
                datos.setearParametro("@Nombre", modificado.Nombre);
                datos.setearParametro("@Descripcion", modificado.Descripcion);
                datos.setearParametro("@IdMarca", modificado.Marca.Id);
                datos.setearParametro("IdCategoria", modificado.Categoria.Id);
                datos.setearParametro("ImagenUrl", modificado.ImagenUrl);
                datos.setearParametro("Precio", modificado.Precio);

                datos.ejecutarAccion();

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
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("DELETE FROM ARTICULOS WHERE Id=@Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();

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

        public List<Articulo> filtrar(string campo, string criterio, string texto)
        {
            AccesoDatos datos = new AccesoDatos();
            List<Articulo> lista = new List<Articulo>();            

            try
            {
                string consulta = "SELECT a.Id,a.Nombre,a.Descripcion,c.Descripcion 'Categoria',m.Descripcion 'Marca', a.ImagenUrl,a.Precio,a.Codigo,a.IdCategoria,a.IdMarca FROM ARTICULOS as a,CATEGORIAS as c,MARCAS as m WHERE a.IdMarca=m.Id AND a.IdCategoria=c.Id AND ";
                if (campo == "Precio")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "a.Precio > "+texto;
                            break;
                        case "Menor a":
                            consulta += "a.Precio < " + texto;
                            break;
                        case "Igual a":
                            consulta += "a.Precio = " + texto;
                            break;
                    }
                }
                else
                {
                    string campoSeleccionado = "";
                    switch (campo)
                    {
                        case "Nombre":
                            campoSeleccionado = "a.Nombre";
                            break;
                        case "Descripcion":
                            campoSeleccionado = "a.Descripcion";
                            break;
                        case "Codigo":
                            campoSeleccionado = "a.Codigo";
                            break;
                        case "Categoria":
                            campoSeleccionado = "c.Descripcion";
                            break;
                        case "Marca":
                            campoSeleccionado = "m.Descripcion";
                            break;
                    }

                    switch (criterio)
                    {
                        case "Empieza con":
                            consulta += campoSeleccionado +" LIKE '"+texto+"%';";
                            break;
                        case "Termina con":
                            consulta += campoSeleccionado + " LIKE '%" + texto + "';";
                            break;
                        case "Contiene":
                            consulta += campoSeleccionado + " LIKE '%" + texto + "%';";
                            break;
                    }
                }

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.ImagenUrl = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    lista.Add(aux);

                }
                return lista;
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
