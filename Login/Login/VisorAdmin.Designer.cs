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
            this.btnAltaJuego.Location = new System.Drawing.Point(331, 86);
            this.btnAltaJuego.Name = "btnAltaJuego";
            this.btnAltaJuego.Size = new System.Drawing.Size(75, 23);
            this.btnAltaJuego.TabIndex = 1;
            this.btnAltaJuego.Text = "Alta Juego";
            this.btnAltaJuego.UseVisualStyleBackColor = true;
            this.btnAltaJuego.Click += new System.EventHandler(this.btnAltaJuego_Click);
            // 
            // VisorAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAltaJuego);
            this.Controls.Add(this.btnVolver);
            this.Name = "VisorAdmin";
            this.Text = "VisorAdmin";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnAltaJuego;
    }
}