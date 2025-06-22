using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Clases
{
    public class ReporteNegocio
    {
        public DataTable GetReporteMensual(int anio, int mes)
        {
            var dt = new DataTable();
            var datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_ReporteVentasMensuales");
                datos.setearParametro("@Anio", anio);
                datos.setearParametro("@Mes", mes);
                datos.ejecutarLectura();
                dt.Load(datos.Lector);
                return dt;
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

        public DataRow GetTotalesMensuales(int anio, int mes)
        {
            var dt = new DataTable();
            var datos = new AccesoDatos();
            try
            {
                datos.setearProcedimiento("sp_ObtenerTotalesMensuales");
                datos.setearParametro("@Anio", anio);
                datos.setearParametro("@Mes", mes);
                datos.ejecutarLectura();
                dt.Load(datos.Lector);

                if (dt.Rows.Count > 0)
                {
                    return dt.Rows[0];
                }
                return null;
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
