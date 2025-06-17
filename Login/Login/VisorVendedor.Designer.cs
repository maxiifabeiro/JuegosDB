namespace Login
{
    partial class VisorVendedor
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
            this.btn_ListadoJuegos = new System.Windows.Forms.Button();
            this.btn_InfoVenta = new System.Windows.Forms.Button();
            this.btn_Aviso_Stock = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_ListadoJuegos
            // 
            this.btn_ListadoJuegos.Location = new System.Drawing.Point(296, 49);
            this.btn_ListadoJuegos.Name = "btn_ListadoJuegos";
            this.btn_ListadoJuegos.Size = new System.Drawing.Size(193, 46);
            this.btn_ListadoJuegos.TabIndex = 0;
            this.btn_ListadoJuegos.Text = "Listado de Juegos";
            this.btn_ListadoJuegos.UseVisualStyleBackColor = true;
            this.btn_ListadoJuegos.Click += new System.EventHandler(this.btn_ListadoJuegos_Click);
            // 
            // btn_InfoVenta
            // 
            this.btn_InfoVenta.Location = new System.Drawing.Point(296, 101);
            this.btn_InfoVenta.Name = "btn_InfoVenta";
            this.btn_InfoVenta.Size = new System.Drawing.Size(193, 47);
            this.btn_InfoVenta.TabIndex = 1;
            this.btn_InfoVenta.Text = "Info Venta";
            this.btn_InfoVenta.UseVisualStyleBackColor = true;
            // 
            // btn_Aviso_Stock
            // 
            this.btn_Aviso_Stock.Location = new System.Drawing.Point(296, 154);
            this.btn_Aviso_Stock.Name = "btn_Aviso_Stock";
            this.btn_Aviso_Stock.Size = new System.Drawing.Size(193, 47);
            this.btn_Aviso_Stock.TabIndex = 1;
            this.btn_Aviso_Stock.Text = "Aviso de Stock";
            this.btn_Aviso_Stock.UseVisualStyleBackColor = true;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(617, 343);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 34);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // VisorVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btn_Aviso_Stock);
            this.Controls.Add(this.btn_InfoVenta);
            this.Controls.Add(this.btn_ListadoJuegos);
            this.Name = "VisorVendedor";
            this.Text = "VisorVendedor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ListadoJuegos;
        private System.Windows.Forms.Button btn_InfoVenta;
        private System.Windows.Forms.Button btn_Aviso_Stock;
        private System.Windows.Forms.Button btnVolver;
    }
}