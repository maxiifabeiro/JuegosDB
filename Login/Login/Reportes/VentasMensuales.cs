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
            negocio = new ReporteNegocio();
            CargarFiltros();
        }

        private void CargarFiltros()
        {
            nudAnio.Minimum = 2020;
            nudAnio.Maximum = DateTime.Now.Year + 1;
            nudAnio.Value = DateTime.Now.Year;

            var meses = new[]
            {
                new { Name = "Enero", Value = 1 },
                new { Name = "Febrero", Value = 2 },
                new { Name = "Marzo", Value = 3 },
                new { Name = "Abril", Value = 4 },
                new { Name = "Mayo", Value = 5 },
                new { Name = "Junio", Value = 6 },
                new { Name = "Julio", Value = 7 },
                new { Name = "Agosto", Value = 8 },
                new { Name = "Septiembre", Value = 9 },
                new { Name = "Octubre", Value = 10 },
                new { Name = "Noviembre", Value = 11 },
                new { Name = "Diciembre", Value = 12 }
            };

            cbMes.DataSource = meses;
            cbMes.DisplayMember = "Name";
            cbMes.ValueMember = "Value";
            cbMes.SelectedValue = DateTime.Now.Month;
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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
