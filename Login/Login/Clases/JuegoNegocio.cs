using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Clases
{
    public class JuegoNegocio
    {
        public List<Juego> listarJuegos(string terminoBusqueda, int idCategoria, int idClasificacion)
        {
            List<Juego> lista = new List<Juego>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearProcedimiento("sp_BuscarJuegoParaVenta");
                datos.setearParametro("@TerminoBusqueda", terminoBusqueda);
                datos.setearParametro("@IDCategoria", idCategoria);
                datos.setearParametro("@IDClasificacionEdad", idClasificacion);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Juego aux = new Juego();
                    aux.IDJuego = (int)datos.Lector["IDJuego"];
                    aux.Nombre = (string)datos.Lector["Nombre del Juego"];
                    aux.Categoria = (string)datos.Lector["Categoría"];
                    aux.Clasificacion = (string)datos.Lector["Clasificación"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.Stock = (int)datos.Lector["Stock"];
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

        public List<Categoria> listarCategorias()
        {
            List<Categoria> lista = new List<Categoria>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT IDCategoria, Nombre FROM Categorias ORDER BY Nombre");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.IDCategoria = (int)datos.Lector["IDCategoria"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
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

        public List<Clasificacion> ListarClasificaciones()
        {
            List<Clasificacion> lista = new List<Clasificacion>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT IDClasificacionEdad, Nombre FROM ClasificacionEdades ORDER BY Nombre");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Clasificacion aux = new Clasificacion();
                    aux.IDClasificacionEdad = (int)datos.Lector["IDClasificacionEdad"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
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

        public List<FormaPago> listarFormas()
        {
            List<FormaPago> lista = new List<FormaPago>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT IDFormaDePago, Nombre FROM FormasDePago ORDER BY Nombre");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    FormaPago aux = new FormaPago();
                    aux.IDFormaDePago = (int)datos.Lector["IDFormaDePago"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
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


        public void registrarVenta(int idJuego, string nombreVendedor, int idFormaPago, int cantidad, decimal precioTotal)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_RegistrarVenta");
                datos.setearParametro("@IDJuego", idJuego);
                datos.setearParametro("@NombreUsuarioVendedor", nombreVendedor);
                datos.setearParametro("@IDFormaPago", idFormaPago);
                datos.setearParametro("@Cantidad", cantidad);
                datos.setearParametro("@PrecioTotal", precioTotal);
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
    }
}
