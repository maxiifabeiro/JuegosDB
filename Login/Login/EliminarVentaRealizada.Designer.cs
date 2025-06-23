namespace Login
{
    partial class EliminarVentaRealizada
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
            this.lblVentaRealizada = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.lblIDVentaAEliminar = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnMostrarTodas = new System.Windows.Forms.Button();
            this.dgvEliminarVenta = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVentaRealizada
            // 
            this.lblVentaRealizada.AutoSize = true;
            this.lblVentaRealizada.Location = new System.Drawing.Point(307, 9);
            this.lblVentaRealizada.Name = "lblVentaRealizada";
            this.lblVentaRealizada.Size = new System.Drawing.Size(124, 13);
            this.lblVentaRealizada.TabIndex = 0;
            this.lblVentaRealizada.Text = "Eliminar Venta Realizada";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(264, 75);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // lblIDVentaAEliminar
            // 
            this.lblIDVentaAEliminar.AutoSize = true;
            this.lblIDVentaAEliminar.Location = new System.Drawing.Point(84, 78);
            this.lblIDVentaAEliminar.Name = "lblIDVentaAEliminar";
            this.lblIDVentaAEliminar.Size = new System.Drawing.Size(150, 13);
            this.lblIDVentaAEliminar.TabIndex = 2;
            this.lblIDVentaAEliminar.Text = "Ingrese ID de Venta a Eliminar";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(249, 355);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolverAtras.Location = new System.Drawing.Point(473, 355);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(75, 23);
            this.btnVolverAtras.TabIndex = 4;
            this.btnVolverAtras.Text = "Volver Atras";
            this.btnVolverAtras.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(402, 72);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 5;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnMostrarTodas
            // 
            this.btnMostrarTodas.Location = new System.Drawing.Point(495, 72);
            this.btnMostrarTodas.Name = "btnMostrarTodas";
            this.btnMostrarTodas.Size = new System.Drawing.Size(151, 23);
            this.btnMostrarTodas.TabIndex = 7;
            this.btnMostrarTodas.Text = "Mostrar Todas Las Ventas";
            this.btnMostrarTodas.UseVisualStyleBackColor = true;
            this.btnMostrarTodas.Click += new System.EventHandler(this.btnMostrarTodas_Click);
            // 
            // dgvEliminarVenta
            // 
            this.dgvEliminarVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEliminarVenta.Location = new System.Drawing.Point(127, 107);
            this.dgvEliminarVenta.Name = "dgvEliminarVenta";
            this.dgvEliminarVenta.Size = new System.Drawing.Size(529, 233);
            this.dgvEliminarVenta.TabIndex = 8;
            // 
            // EliminarVentaRealizada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolverAtras;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvEliminarVenta);
            this.Controls.Add(this.btnMostrarTodas);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblIDVentaAEliminar);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblVentaRealizada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EliminarVentaRealizada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar Venta Realizada";
            ((System.ComponentModel.ISupportInitialize)(this.dgvEliminarVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVentaRealizada;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label lblIDVentaAEliminar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolverAtras;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnMostrarTodas;
        private System.Windows.Forms.DataGridView dgvEliminarVenta;
    }
}