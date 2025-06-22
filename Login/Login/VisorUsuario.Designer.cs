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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisorUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblBienvenido = new System.Windows.Forms.Label();
            this.btnListadoJuegos = new System.Windows.Forms.Button();
            this.btnAvisoStock = new System.Windows.Forms.Button();
            this.bntInfoVenta = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btn_ClasificacionJuegosXEdad = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ClasificacionJuegosXEdad);
            this.groupBox1.Controls.Add(this.lblBienvenido);
            this.groupBox1.Controls.Add(this.btnListadoJuegos);
            this.groupBox1.Controls.Add(this.btnAvisoStock);
            this.groupBox1.Controls.Add(this.bntInfoVenta);
            this.groupBox1.Location = new System.Drawing.Point(355, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(251, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblBienvenido
            // 
            this.lblBienvenido.AutoSize = true;
            this.lblBienvenido.Location = new System.Drawing.Point(102, 16);
            this.lblBienvenido.Name = "lblBienvenido";
            this.lblBienvenido.Size = new System.Drawing.Size(0, 13);
            this.lblBienvenido.TabIndex = 2;
            // 
            // btnListadoJuegos
            // 
            this.btnListadoJuegos.Location = new System.Drawing.Point(69, 63);
            this.btnListadoJuegos.Name = "btnListadoJuegos";
            this.btnListadoJuegos.Size = new System.Drawing.Size(124, 46);
            this.btnListadoJuegos.TabIndex = 1;
            this.btnListadoJuegos.Text = "Listado de juegos";
            this.btnListadoJuegos.UseVisualStyleBackColor = true;
            this.btnListadoJuegos.Click += new System.EventHandler(this.btnListadoJuegos_Click);
            // 
            // btnAvisoStock
            // 
            this.btnAvisoStock.Location = new System.Drawing.Point(69, 167);
            this.btnAvisoStock.Name = "btnAvisoStock";
            this.btnAvisoStock.Size = new System.Drawing.Size(124, 46);
            this.btnAvisoStock.TabIndex = 0;
            this.btnAvisoStock.Text = "Aviso de Stock";
            this.btnAvisoStock.UseVisualStyleBackColor = true;
            this.btnAvisoStock.Click += new System.EventHandler(this.btnAvisoStock_Click);
            // 
            // bntInfoVenta
            // 
            this.bntInfoVenta.Location = new System.Drawing.Point(69, 115);
            this.bntInfoVenta.Name = "bntInfoVenta";
            this.bntInfoVenta.Size = new System.Drawing.Size(124, 46);
            this.bntInfoVenta.TabIndex = 0;
            this.bntInfoVenta.Text = "Info Venta";
            this.bntInfoVenta.UseVisualStyleBackColor = true;
            this.bntInfoVenta.Click += new System.EventHandler(this.bntInfoVenta_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(622, 365);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 34);
            this.btnVolver.TabIndex = 1;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btn_ClasificacionJuegosXEdad
            // 
            this.btn_ClasificacionJuegosXEdad.Location = new System.Drawing.Point(69, 219);
            this.btn_ClasificacionJuegosXEdad.Name = "btn_ClasificacionJuegosXEdad";
            this.btn_ClasificacionJuegosXEdad.Size = new System.Drawing.Size(124, 41);
            this.btn_ClasificacionJuegosXEdad.TabIndex = 3;
            this.btn_ClasificacionJuegosXEdad.Text = "Clasificación Juegos por Edad";
            this.btn_ClasificacionJuegosXEdad.UseVisualStyleBackColor = true;
            this.btn_ClasificacionJuegosXEdad.Click += new System.EventHandler(this.btn_ClasificacionJuegosXEdad_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(50, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 129);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // VisorUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "VisorUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VisorUsuario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bntInfoVenta;
        private System.Windows.Forms.Button btnAvisoStock;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnListadoJuegos;
        private System.Windows.Forms.Label lblBienvenido;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_ClasificacionJuegosXEdad;
    }
}