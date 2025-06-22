using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Clases;

namespace Login.Reportes
{
    public partial class VentasMensuales : Form
    {
        private ReporteNegocio negocio;

        public VentasMensuales()
        {
            InitializeComponent();
        }

        private void btnGenerarReporte_Click(object sender, EventArgs e)
        {
            try
            {
                int anio = (int)nudAnio.Value;
                int mes = (int)cbMes.SelectedValue;

                DataRow totales = negocio.GetTotalesMensuales(anio, mes);
                if (totales != null)
                {
                    lblIngresos.Text = "Ingresos: " + ((decimal)totales["IngresosTotales"]).ToString("C");
                    lblUnidades.Text = "Unidades: " + totales["UnidadesTotales"].ToString();
                    lblVentas.Text = "Nro de Ventas: " + totales["CantidadDeVentas"].ToString();
                }

                dgvReporte.DataSource = negocio.GetReporteMensual(anio, mes);

                if (dgvReporte.Columns["TotalVendido"] != null)
                {
                    dgvReporte.Columns["TotalVendido"].DefaultCellStyle.Format = "C2";
                    dgvReporte.Columns["TotalVendido"].HeaderText = "Total Vendido";
                }
                if (dgvReporte.Columns["UnidadesVendidas"] != null)
                {
                    dgvReporte.Columns["UnidadesVendidas"].HeaderText = "Unidades Vendidas";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al generar el reporte: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
