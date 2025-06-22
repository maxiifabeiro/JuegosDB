
namespace Login
{
    partial class RealizarVenta
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblJuego = new System.Windows.Forms.Label();
            this.txtJuegoSeleccionado = new System.Windows.Forms.TextBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.txtUsuarioVendedor = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.gbxVenta = new System.Windows.Forms.GroupBox();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblPago = new System.Windows.Forms.Label();
            this.cbPago = new System.Windows.Forms.ComboBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.gbxTotal = new System.Windows.Forms.GroupBox();
            this.lblPrecioTotal = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnRealizarVenta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gbxVenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.gbxTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(32, 27);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 36);
            this.lblTitulo.TabIndex = 3;
            this.lblTitulo.Text = "Realizar Venta";
            // 
            // lblJuego
            // 
            this.lblJuego.AutoSize = true;
            this.lblJuego.Location = new System.Drawing.Point(33, 134);
            this.lblJuego.Name = "lblJuego";
            this.lblJuego.Size = new System.Drawing.Size(107, 13);
            this.lblJuego.TabIndex = 4;
            this.lblJuego.Text = "Juego Seleccionado:";
            // 
            // txtJuegoSeleccionado
            // 
            this.txtJuegoSeleccionado.Location = new System.Drawing.Point(36, 150);
            this.txtJuegoSeleccionado.Name = "txtJuegoSeleccionado";
            this.txtJuegoSeleccionado.Size = new System.Drawing.Size(223, 20);
            this.txtJuegoSeleccionado.TabIndex = 5;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(36, 198);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(104, 20);
            this.txtPrecio.TabIndex = 7;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(33, 182);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(79, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio Unitario:";
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(155, 198);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(104, 20);
            this.txtStock.TabIndex = 9;
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(152, 182);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(38, 13);
            this.lblStock.TabIndex = 8;
            this.lblStock.Text = "Stock:";
            // 
            // txtUsuarioVendedor
            // 
            this.txtUsuarioVendedor.Location = new System.Drawing.Point(36, 100);
            this.txtUsuarioVendedor.Name = "txtUsuarioVendedor";
            this.txtUsuarioVendedor.Size = new System.Drawing.Size(223, 20);
            this.txtUsuarioVendedor.TabIndex = 11;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(33, 84);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(95, 13);
            this.lblUsuario.TabIndex = 10;
            this.lblUsuario.Text = "Usuario Vendedor:";
            // 
            // gbxVenta
            // 
            this.gbxVenta.Controls.Add(this.nudCantidad);
            this.gbxVenta.Controls.Add(this.lblPago);
            this.gbxVenta.Controls.Add(this.cbPago);
            this.gbxVenta.Controls.Add(this.lblCantidad);
            this.gbxVenta.Location = new System.Drawing.Point(12, 242);
            this.gbxVenta.Name = "gbxVenta";
            this.gbxVenta.Size = new System.Drawing.Size(269, 77);
            this.gbxVenta.TabIndex = 12;
            this.gbxVenta.TabStop = false;
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(9, 33);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(120, 20);
            this.nudCantidad.TabIndex = 7;
            this.nudCantidad.ValueChanged += new System.EventHandler(this.nudCantidad_ValueChanged);
            // 
            // lblPago
            // 
            this.lblPago.AutoSize = true;
            this.lblPago.Location = new System.Drawing.Point(133, 16);
            this.lblPago.Name = "lblPago";
            this.lblPago.Size = new System.Drawing.Size(82, 13);
            this.lblPago.TabIndex = 6;
            this.lblPago.Text = "Forma de Pago:";
            // 
            // cbPago
            // 
            this.cbPago.FormattingEnabled = true;
            this.cbPago.Location = new System.Drawing.Point(136, 32);
            this.cbPago.Name = "cbPago";
            this.cbPago.Size = new System.Drawing.Size(121, 21);
            this.cbPago.TabIndex = 5;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(6, 16);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(52, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // gbxTotal
            // 
            this.gbxTotal.Controls.Add(this.lblPrecioTotal);
            this.gbxTotal.Controls.Add(this.lblTotal);
            this.gbxTotal.Location = new System.Drawing.Point(13, 326);
            this.gbxTotal.Name = "gbxTotal";
            this.gbxTotal.Size = new System.Drawing.Size(269, 71);
            this.gbxTotal.TabIndex = 13;
            this.gbxTotal.TabStop = false;
            // 
            // lblPrecioTotal
            // 
            this.lblPrecioTotal.AutoSize = true;
            this.lblPrecioTotal.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioTotal.Location = new System.Drawing.Point(99, 16);
            this.lblPrecioTotal.Name = "lblPrecioTotal";
            this.lblPrecioTotal.Size = new System.Drawing.Size(0, 23);
            this.lblPrecioTotal.TabIndex = 3;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Britannic Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(19, 16);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(74, 23);
            this.lblTotal.TabIndex = 3;
            this.lblTotal.Text = "Total : ";
            // 
            // btnRealizarVenta
            // 
            this.btnRealizarVenta.Location = new System.Drawing.Point(48, 386);
            this.btnRealizarVenta.Name = "btnRealizarVenta";
            this.btnRealizarVenta.Size = new System.Drawing.Size(93, 23);
            this.btnRealizarVenta.TabIndex = 14;
            this.btnRealizarVenta.Text = "Realizar Venta";
            this.btnRealizarVenta.UseVisualStyleBackColor = true;
            this.btnRealizarVenta.Click += new System.EventHandler(this.btnRealizarVenta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(156, 386);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(93, 23);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // RealizarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 436);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRealizarVenta);
            this.Controls.Add(this.gbxTotal);
            this.Controls.Add(this.gbxVenta);
            this.Controls.Add(this.txtUsuarioVendedor);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.txtJuegoSeleccionado);
            this.Controls.Add(this.lblJuego);
            this.Controls.Add(this.lblTitulo);
            this.MaximizeBox = false;
            this.Name = "RealizarVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RealizarVenta";
            this.gbxVenta.ResumeLayout(false);
            this.gbxVenta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.gbxTotal.ResumeLayout(false);
            this.gbxTotal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblJuego;
        private System.Windows.Forms.TextBox txtJuegoSeleccionado;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.TextBox txtUsuarioVendedor;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.GroupBox gbxVenta;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Label lblPago;
        private System.Windows.Forms.ComboBox cbPago;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.GroupBox gbxTotal;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnRealizarVenta;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblPrecioTotal;
    }
}