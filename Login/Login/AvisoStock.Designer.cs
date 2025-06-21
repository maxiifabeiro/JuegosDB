
namespace Login
{
    partial class AvisoStock
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
            this.lvwListaJuegos = new System.Windows.Forms.ListView();
            this.btnFiltrarMayor = new System.Windows.Forms.Button();
            this.lblStock = new System.Windows.Forms.Label();
            this.nupCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnFiltrarMenor = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnFiltrarIgual = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.lblTitulo.Location = new System.Drawing.Point(137, 38);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 36);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Aviso de Stock";
            // 
            // lvwListaJuegos
            // 
            this.lvwListaJuegos.FullRowSelect = true;
            this.lvwListaJuegos.GridLines = true;
            this.lvwListaJuegos.HideSelection = false;
            this.lvwListaJuegos.Location = new System.Drawing.Point(62, 200);
            this.lvwListaJuegos.MultiSelect = false;
            this.lvwListaJuegos.Name = "lvwListaJuegos";
            this.lvwListaJuegos.Size = new System.Drawing.Size(357, 226);
            this.lvwListaJuegos.TabIndex = 13;
            this.lvwListaJuegos.UseCompatibleStateImageBehavior = false;
            // 
            // btnFiltrarMayor
            // 
            this.btnFiltrarMayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarMayor.Location = new System.Drawing.Point(26, 152);
            this.btnFiltrarMayor.Name = "btnFiltrarMayor";
            this.btnFiltrarMayor.Size = new System.Drawing.Size(133, 28);
            this.btnFiltrarMayor.TabIndex = 16;
            this.btnFiltrarMayor.Text = "&Mayor a:";
            this.btnFiltrarMayor.UseVisualStyleBackColor = true;
            this.btnFiltrarMayor.Click += new System.EventHandler(this.btnFiltrarMayor_Click);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock.Location = new System.Drawing.Point(11, 115);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(184, 20);
            this.lblStock.TabIndex = 14;
            this.lblStock.Text = "Ingrese cantidad a filtrar:";
            // 
            // nupCantidad
            // 
            this.nupCantidad.Location = new System.Drawing.Point(201, 115);
            this.nupCantidad.Name = "nupCantidad";
            this.nupCantidad.Size = new System.Drawing.Size(53, 20);
            this.nupCantidad.TabIndex = 17;
            // 
            // btnFiltrarMenor
            // 
            this.btnFiltrarMenor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarMenor.Location = new System.Drawing.Point(340, 152);
            this.btnFiltrarMenor.Name = "btnFiltrarMenor";
            this.btnFiltrarMenor.Size = new System.Drawing.Size(133, 28);
            this.btnFiltrarMenor.TabIndex = 18;
            this.btnFiltrarMenor.Text = "M&enor a:";
            this.btnFiltrarMenor.UseVisualStyleBackColor = true;
            this.btnFiltrarMenor.Click += new System.EventHandler(this.btnFiltrarMenor_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(171, 472);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(133, 28);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnFiltrarIgual
            // 
            this.btnFiltrarIgual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarIgual.Location = new System.Drawing.Point(185, 152);
            this.btnFiltrarIgual.Name = "btnFiltrarIgual";
            this.btnFiltrarIgual.Size = new System.Drawing.Size(133, 28);
            this.btnFiltrarIgual.TabIndex = 20;
            this.btnFiltrarIgual.Text = "&Igual a:";
            this.btnFiltrarIgual.UseVisualStyleBackColor = true;
            this.btnFiltrarIgual.Click += new System.EventHandler(this.btnFiltrarIgual_Click);
            // 
            // AvisoStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 512);
            this.Controls.Add(this.btnFiltrarIgual);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnFiltrarMenor);
            this.Controls.Add(this.nupCantidad);
            this.Controls.Add(this.btnFiltrarMayor);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lvwListaJuegos);
            this.Controls.Add(this.lblTitulo);
            this.Name = "AvisoStock";
            this.Text = "AvisoStock";
            this.Load += new System.EventHandler(this.AvisoStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nupCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListView lvwListaJuegos;
        private System.Windows.Forms.Button btnFiltrarMayor;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.NumericUpDown nupCantidad;
        private System.Windows.Forms.Button btnFiltrarMenor;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnFiltrarIgual;
    }
}