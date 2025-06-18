namespace Login
{
    partial class VisorAdmin
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnAltaJuego = new System.Windows.Forms.Button();
            this.btn_DevJuegos = new System.Windows.Forms.Button();
            this.btn_DevConsolas = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnModificarJuego = new System.Windows.Forms.Button();
            this.btnEliminarJuego = new System.Windows.Forms.Button();
            this.btnListadoJuegos = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(643, 373);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 34);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnAltaJuego
            // 
            this.btnAltaJuego.Location = new System.Drawing.Point(92, 54);
            this.btnAltaJuego.Name = "btnAltaJuego";
            this.btnAltaJuego.Size = new System.Drawing.Size(139, 23);
            this.btnAltaJuego.TabIndex = 1;
            this.btnAltaJuego.Text = "Alta Juego";
            this.btnAltaJuego.UseVisualStyleBackColor = true;
            this.btnAltaJuego.Click += new System.EventHandler(this.btnAltaJuego_Click);
            // 
            // btn_DevJuegos
            // 
            this.btn_DevJuegos.Location = new System.Drawing.Point(92, 170);
            this.btn_DevJuegos.Name = "btn_DevJuegos";
            this.btn_DevJuegos.Size = new System.Drawing.Size(139, 23);
            this.btn_DevJuegos.TabIndex = 3;
            this.btn_DevJuegos.Text = "Desarrolladores Juegos";
            this.btn_DevJuegos.UseVisualStyleBackColor = true;
            this.btn_DevJuegos.Click += new System.EventHandler(this.btn_DevJuegos_Click);
            // 
            // btn_DevConsolas
            // 
            this.btn_DevConsolas.Location = new System.Drawing.Point(92, 199);
            this.btn_DevConsolas.Name = "btn_DevConsolas";
            this.btn_DevConsolas.Size = new System.Drawing.Size(139, 23);
            this.btn_DevConsolas.TabIndex = 3;
            this.btn_DevConsolas.Text = "Desarrolladoras Consolas";
            this.btn_DevConsolas.UseVisualStyleBackColor = true;
            this.btn_DevConsolas.Click += new System.EventHandler(this.btn_DevConsolas_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnListadoJuegos);
            this.groupBox1.Controls.Add(this.btnEliminarJuego);
            this.groupBox1.Controls.Add(this.btnModificarJuego);
            this.groupBox1.Controls.Add(this.btn_DevConsolas);
            this.groupBox1.Controls.Add(this.btn_DevJuegos);
            this.groupBox1.Controls.Add(this.btnAltaJuego);
            this.groupBox1.Location = new System.Drawing.Point(239, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(335, 312);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            // 
            // btnModificarJuego
            // 
            this.btnModificarJuego.Location = new System.Drawing.Point(92, 112);
            this.btnModificarJuego.Name = "btnModificarJuego";
            this.btnModificarJuego.Size = new System.Drawing.Size(139, 23);
            this.btnModificarJuego.TabIndex = 4;
            this.btnModificarJuego.Text = "Modificar Juego";
            this.btnModificarJuego.UseVisualStyleBackColor = true;
            this.btnModificarJuego.Click += new System.EventHandler(this.btnModificarJuego_Click);
            // 
            // btnEliminarJuego
            // 
            this.btnEliminarJuego.Location = new System.Drawing.Point(92, 83);
            this.btnEliminarJuego.Name = "btnEliminarJuego";
            this.btnEliminarJuego.Size = new System.Drawing.Size(139, 23);
            this.btnEliminarJuego.TabIndex = 5;
            this.btnEliminarJuego.Text = "Eliminar Juego";
            this.btnEliminarJuego.UseVisualStyleBackColor = true;
            this.btnEliminarJuego.Click += new System.EventHandler(this.btnEliminarJuego_Click);
            // 
            // btnListadoJuegos
            // 
            this.btnListadoJuegos.Location = new System.Drawing.Point(92, 141);
            this.btnListadoJuegos.Name = "btnListadoJuegos";
            this.btnListadoJuegos.Size = new System.Drawing.Size(139, 23);
            this.btnListadoJuegos.TabIndex = 6;
            this.btnListadoJuegos.Text = "Listado de Juegos";
            this.btnListadoJuegos.UseVisualStyleBackColor = true;
            this.btnListadoJuegos.Click += new System.EventHandler(this.btnListadoJuegos_Click);
            // 
            // VisorAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnVolver);
            this.Name = "VisorAdmin";
            this.Text = "VisorAdmin";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAltaJuego;
        private System.Windows.Forms.Button btn_DevJuegos;
        private System.Windows.Forms.Button btn_DevConsolas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnModificarJuego;
        private System.Windows.Forms.Button btnListadoJuegos;
        private System.Windows.Forms.Button btnEliminarJuego;
    }
}