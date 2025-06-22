
namespace Login
{
    partial class Ventas
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
            this.btnVender = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.cbClasificaciones = new System.Windows.Forms.ComboBox();
            this.lblCategorias = new System.Windows.Forms.Label();
            this.lblClasificaciones = new System.Windows.Forms.Label();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.dgvJuegos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(181, 397);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(93, 23);
            this.btnVender.TabIndex = 0;
            this.btnVender.Text = "Vender Juego";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(280, 397);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(93, 23);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(218, 103);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(121, 21);
            this.cbCategorias.TabIndex = 1;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // cbClasificaciones
            // 
            this.cbClasificaciones.FormattingEnabled = true;
            this.cbClasificaciones.Location = new System.Drawing.Point(356, 103);
            this.cbClasificaciones.Name = "cbClasificaciones";
            this.cbClasificaciones.Size = new System.Drawing.Size(121, 21);
            this.cbClasificaciones.TabIndex = 1;
            this.cbClasificaciones.SelectedIndexChanged += new System.EventHandler(this.cbClasificaciones_SelectedIndexChanged);
            // 
            // lblCategorias
            // 
            this.lblCategorias.AutoSize = true;
            this.lblCategorias.Location = new System.Drawing.Point(215, 88);
            this.lblCategorias.Name = "lblCategorias";
            this.lblCategorias.Size = new System.Drawing.Size(101, 13);
            this.lblCategorias.TabIndex = 2;
            this.lblCategorias.Text = "Filtrar por Categoria:";
            // 
            // lblClasificaciones
            // 
            this.lblClasificaciones.AutoSize = true;
            this.lblClasificaciones.Location = new System.Drawing.Point(353, 87);
            this.lblClasificaciones.Name = "lblClasificaciones";
            this.lblClasificaciones.Size = new System.Drawing.Size(81, 13);
            this.lblClasificaciones.TabIndex = 2;
            this.lblClasificaciones.Text = "Filtrar por Edad:";
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(81, 88);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(101, 13);
            this.lblBuscar.TabIndex = 2;
            this.lblBuscar.Text = "Buscar por Nombre:";
            this.lblBuscar.Click += new System.EventHandler(this.lblBuscar_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(222, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(108, 36);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Ventas";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(84, 104);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(121, 20);
            this.txtBuscar.TabIndex = 3;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // dgvJuegos
            // 
            this.dgvJuegos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvJuegos.Location = new System.Drawing.Point(84, 140);
            this.dgvJuegos.Name = "dgvJuegos";
            this.dgvJuegos.Size = new System.Drawing.Size(393, 239);
            this.dgvJuegos.TabIndex = 4;
            this.dgvJuegos.SelectionChanged += new System.EventHandler(this.dgvJuegos_SelectionChanged);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 456);
            this.Controls.Add(this.dgvJuegos);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.lblClasificaciones);
            this.Controls.Add(this.lblCategorias);
            this.Controls.Add(this.cbClasificaciones);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnVender);
            this.Name = "Ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvJuegos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.ComboBox cbClasificaciones;
        private System.Windows.Forms.Label lblCategorias;
        private System.Windows.Forms.Label lblClasificaciones;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.DataGridView dgvJuegos;
    }
}