namespace Login
{
    partial class VisorUsuario
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnListadoJuegos = new System.Windows.Forms.Button();
            this.bntInfoVenta = new System.Windows.Forms.Button();
            this.btnAvisoStock = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAvisoStock);
            this.groupBox1.Controls.Add(this.bntInfoVenta);
            this.groupBox1.Controls.Add(this.btnListadoJuegos);
            this.groupBox1.Location = new System.Drawing.Point(221, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 325);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnListadoJuegos
            // 
            this.btnListadoJuegos.Location = new System.Drawing.Point(105, 41);
            this.btnListadoJuegos.Name = "btnListadoJuegos";
            this.btnListadoJuegos.Size = new System.Drawing.Size(124, 46);
            this.btnListadoJuegos.TabIndex = 0;
            this.btnListadoJuegos.Text = "Listado de juegos";
            this.btnListadoJuegos.UseVisualStyleBackColor = true;
            this.btnListadoJuegos.Click += new System.EventHandler(this.button1_Click);
            // 
            // bntInfoVenta
            // 
            this.bntInfoVenta.Location = new System.Drawing.Point(105, 103);
            this.bntInfoVenta.Name = "bntInfoVenta";
            this.bntInfoVenta.Size = new System.Drawing.Size(124, 46);
            this.bntInfoVenta.TabIndex = 0;
            this.bntInfoVenta.Text = "Info Venta";
            this.bntInfoVenta.UseVisualStyleBackColor = true;
            this.bntInfoVenta.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAvisoStock
            // 
            this.btnAvisoStock.Location = new System.Drawing.Point(105, 166);
            this.btnAvisoStock.Name = "btnAvisoStock";
            this.btnAvisoStock.Size = new System.Drawing.Size(124, 46);
            this.btnAvisoStock.TabIndex = 0;
            this.btnAvisoStock.Text = "Aviso de Stock";
            this.btnAvisoStock.UseVisualStyleBackColor = true;
            this.btnAvisoStock.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(621, 334);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 34);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            // 
            // VisorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.Name = "VisorUsuario";
            this.Text = "VisorUsuario";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnListadoJuegos;
        private System.Windows.Forms.Button bntInfoVenta;
        private System.Windows.Forms.Button btnAvisoStock;
        private System.Windows.Forms.Button btnVolver;
    }
}