namespace Login.Reportes
{
    partial class VentasMensuales
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbFiltros = new System.Windows.Forms.GroupBox();
            this.btnGenerarReporte = new System.Windows.Forms.Button();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.gbReporte = new System.Windows.Forms.GroupBox();
            this.lblResultados = new System.Windows.Forms.Label();
            this.gbResumen = new System.Windows.Forms.GroupBox();
            this.lblVentas = new System.Windows.Forms.Label();
            this.lblUnidades = new System.Windows.Forms.Label();
            this.lblIngresos = new System.Windows.Forms.Label();
            this.lblTotales = new System.Windows.Forms.Label();
            this.dgvReporte = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gbFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.gbReporte.SuspendLayout();
            this.gbResumen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(227, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(271, 36);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Reporte de Ventas";
            // 
            // gbFiltros
            // 
            this.gbFiltros.Controls.Add(this.btnGenerarReporte);
            this.gbFiltros.Controls.Add(this.nudAnio);
            this.gbFiltros.Controls.Add(this.cbMes);
            this.gbFiltros.Controls.Add(this.lblMes);
            this.gbFiltros.Controls.Add(this.lblAnio);
            this.gbFiltros.Location = new System.Drawing.Point(26, 210);
            this.gbFiltros.Name = "gbFiltros";
            this.gbFiltros.Size = new System.Drawing.Size(158, 177);
            this.gbFiltros.TabIndex = 5;
            this.gbFiltros.TabStop = false;
            // 
            // btnGenerarReporte
            // 
            this.btnGenerarReporte.Location = new System.Drawing.Point(24, 128);
            this.btnGenerarReporte.Name = "btnGenerarReporte";
            this.btnGenerarReporte.Size = new System.Drawing.Size(105, 23);
            this.btnGenerarReporte.TabIndex = 15;
            this.btnGenerarReporte.Text = "Generar Reporte";
            this.btnGenerarReporte.UseVisualStyleBackColor = true;
            this.btnGenerarReporte.Click += new System.EventHandler(this.btnGenerarReporte_Click);
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(24, 49);
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(105, 20);
            this.nudAnio.TabIndex = 11;
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(24, 91);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(105, 21);
            this.cbMes.TabIndex = 9;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(21, 75);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(30, 13);
            this.lblMes.TabIndex = 10;
            this.lblMes.Text = "Mes:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(21, 32);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(29, 13);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año:";
            // 
            // gbReporte
            // 
            this.gbReporte.Controls.Add(this.lblResultados);
            this.gbReporte.Controls.Add(this.gbResumen);
            this.gbReporte.Controls.Add(this.dgvReporte);
            this.gbReporte.Location = new System.Drawing.Point(209, 56);
            this.gbReporte.Name = "gbReporte";
            this.gbReporte.Size = new System.Drawing.Size(542, 468);
            this.gbReporte.TabIndex = 6;
            this.gbReporte.TabStop = false;
            // 
            // lblResultados
            // 
            this.lblResultados.AutoSize = true;
            this.lblResultados.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.lblResultados.Location = new System.Drawing.Point(108, 26);
            this.lblResultados.Name = "lblResultados";
            this.lblResultados.Size = new System.Drawing.Size(333, 25);
            this.lblResultados.TabIndex = 4;
            this.lblResultados.Text = "Resultados del Mes Seleccionado";
            // 
            // gbResumen
            // 
            this.gbResumen.Controls.Add(this.lblVentas);
            this.gbResumen.Controls.Add(this.lblUnidades);
            this.gbResumen.Controls.Add(this.lblIngresos);
            this.gbResumen.Controls.Add(this.lblTotales);
            this.gbResumen.Location = new System.Drawing.Point(128, 290);
            this.gbResumen.Name = "gbResumen";
            this.gbResumen.Size = new System.Drawing.Size(294, 154);
            this.gbResumen.TabIndex = 1;
            this.gbResumen.TabStop = false;
            // 
            // lblVentas
            // 
            this.lblVentas.AutoSize = true;
            this.lblVentas.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblVentas.Location = new System.Drawing.Point(20, 100);
            this.lblVentas.Name = "lblVentas";
            this.lblVentas.Size = new System.Drawing.Size(130, 21);
            this.lblVentas.TabIndex = 4;
            this.lblVentas.Text = "Nro de Ventas:";
            // 
            // lblUnidades
            // 
            this.lblUnidades.AutoSize = true;
            this.lblUnidades.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblUnidades.Location = new System.Drawing.Point(20, 79);
            this.lblUnidades.Name = "lblUnidades";
            this.lblUnidades.Size = new System.Drawing.Size(91, 21);
            this.lblUnidades.TabIndex = 4;
            this.lblUnidades.Text = "Unidades:";
            // 
            // lblIngresos
            // 
            this.lblIngresos.AutoSize = true;
            this.lblIngresos.Font = new System.Drawing.Font("Britannic Bold", 14F);
            this.lblIngresos.Location = new System.Drawing.Point(20, 58);
            this.lblIngresos.Name = "lblIngresos";
            this.lblIngresos.Size = new System.Drawing.Size(87, 21);
            this.lblIngresos.TabIndex = 4;
            this.lblIngresos.Text = "Ingresos:";
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Font = new System.Drawing.Font("Britannic Bold", 16F);
            this.lblTotales.Location = new System.Drawing.Point(69, 16);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(161, 25);
            this.lblTotales.TabIndex = 4;
            this.lblTotales.Text = "Totales del Mes";
            // 
            // dgvReporte
            // 
            this.dgvReporte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvReporte.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvReporte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReporte.EnableHeadersVisualStyles = false;
            this.dgvReporte.Location = new System.Drawing.Point(79, 70);
            this.dgvReporte.Name = "dgvReporte";
            this.dgvReporte.RowHeadersVisible = false;
            this.dgvReporte.Size = new System.Drawing.Size(390, 204);
            this.dgvReporte.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(646, 546);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(105, 23);
            this.btnSalir.TabIndex = 15;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // VentasMensuales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 591);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.gbReporte);
            this.Controls.Add(this.gbFiltros);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "VentasMensuales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VentasMensuales";
            this.gbFiltros.ResumeLayout(false);
            this.gbFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.gbReporte.ResumeLayout(false);
            this.gbReporte.PerformLayout();
            this.gbResumen.ResumeLayout(false);
            this.gbResumen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReporte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbFiltros;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnGenerarReporte;
        private System.Windows.Forms.GroupBox gbReporte;
        private System.Windows.Forms.DataGridView dgvReporte;
        private System.Windows.Forms.Label lblResultados;
        private System.Windows.Forms.GroupBox gbResumen;
        private System.Windows.Forms.Label lblVentas;
        private System.Windows.Forms.Label lblUnidades;
        private System.Windows.Forms.Label lblIngresos;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Button btnSalir;
    }
}