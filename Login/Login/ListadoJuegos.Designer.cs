namespace Login
{
    partial class ListadoJuegos
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
            this.lblListarPorID = new System.Windows.Forms.Label();
            this.txtListarPorID = new System.Windows.Forms.TextBox();
            this.btnListarID = new System.Windows.Forms.Button();
            this.btnMostrarTodos = new System.Windows.Forms.Button();
            this.lvwListado = new System.Windows.Forms.ListView();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(312, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(93, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Listado de Juegos";
            // 
            // lblListarPorID
            // 
            this.lblListarPorID.AutoSize = true;
            this.lblListarPorID.Location = new System.Drawing.Point(67, 60);
            this.lblListarPorID.Name = "lblListarPorID";
            this.lblListarPorID.Size = new System.Drawing.Size(64, 13);
            this.lblListarPorID.TabIndex = 1;
            this.lblListarPorID.Text = "Listar por ID";
            // 
            // txtListarPorID
            // 
            this.txtListarPorID.Location = new System.Drawing.Point(153, 57);
            this.txtListarPorID.Name = "txtListarPorID";
            this.txtListarPorID.Size = new System.Drawing.Size(100, 20);
            this.txtListarPorID.TabIndex = 2;
            // 
            // btnListarID
            // 
            this.btnListarID.Location = new System.Drawing.Point(273, 54);
            this.btnListarID.Name = "btnListarID";
            this.btnListarID.Size = new System.Drawing.Size(75, 23);
            this.btnListarID.TabIndex = 3;
            this.btnListarID.Text = "Buscar ID";
            this.btnListarID.UseVisualStyleBackColor = true;
            this.btnListarID.Click += new System.EventHandler(this.btnListarID_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Location = new System.Drawing.Point(367, 54);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Size = new System.Drawing.Size(97, 23);
            this.btnMostrarTodos.TabIndex = 4;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.UseVisualStyleBackColor = true;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // lvwListado
            // 
            this.lvwListado.FullRowSelect = true;
            this.lvwListado.GridLines = true;
            this.lvwListado.HideSelection = false;
            this.lvwListado.Location = new System.Drawing.Point(31, 113);
            this.lvwListado.MultiSelect = false;
            this.lvwListado.Name = "lvwListado";
            this.lvwListado.Size = new System.Drawing.Size(741, 294);
            this.lvwListado.TabIndex = 5;
            this.lvwListado.UseCompatibleStateImageBehavior = false;
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.Location = new System.Drawing.Point(485, 54);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(75, 23);
            this.btnVolverAtras.TabIndex = 6;
            this.btnVolverAtras.Text = "Volver Atras";
            this.btnVolverAtras.UseVisualStyleBackColor = true;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // ListadoJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.lvwListado);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnListarID);
            this.Controls.Add(this.txtListarPorID);
            this.Controls.Add(this.lblListarPorID);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ListadoJuegos";
            this.Text = "ListadoJuegos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblListarPorID;
        private System.Windows.Forms.TextBox txtListarPorID;
        private System.Windows.Forms.Button btnListarID;
        private System.Windows.Forms.Button btnMostrarTodos;
        private System.Windows.Forms.ListView lvwListado;
        private System.Windows.Forms.Button btnVolverAtras;
    }
}