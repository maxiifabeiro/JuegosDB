
namespace Login
{
    partial class ListadoUsuarios
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
            this.lvwListadoUsuario = new System.Windows.Forms.ListView();
            this.btnMostrarTodosUsuarios = new System.Windows.Forms.Button();
            this.btnBuscarIDUsuario = new System.Windows.Forms.Button();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.lblListarPorID = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(348, 440);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 28);
            this.btnVolver.TabIndex = 13;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lvwListadoUsuario
            // 
            this.lvwListadoUsuario.FullRowSelect = true;
            this.lvwListadoUsuario.GridLines = true;
            this.lvwListadoUsuario.HideSelection = false;
            this.lvwListadoUsuario.Location = new System.Drawing.Point(30, 130);
            this.lvwListadoUsuario.MultiSelect = false;
            this.lvwListadoUsuario.Name = "lvwListadoUsuario";
            this.lvwListadoUsuario.Size = new System.Drawing.Size(741, 294);
            this.lvwListadoUsuario.TabIndex = 12;
            this.lvwListadoUsuario.UseCompatibleStateImageBehavior = false;
            // 
            // btnMostrarTodosUsuarios
            // 
            this.btnMostrarTodosUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodosUsuarios.Location = new System.Drawing.Point(606, 85);
            this.btnMostrarTodosUsuarios.Name = "btnMostrarTodosUsuarios";
            this.btnMostrarTodosUsuarios.Size = new System.Drawing.Size(140, 28);
            this.btnMostrarTodosUsuarios.TabIndex = 11;
            this.btnMostrarTodosUsuarios.Text = "Mostrar &Todos";
            this.btnMostrarTodosUsuarios.UseVisualStyleBackColor = true;
            this.btnMostrarTodosUsuarios.Click += new System.EventHandler(this.btnMostrarTodosUsuarios_Click);
            // 
            // btnBuscarIDUsuario
            // 
            this.btnBuscarIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarIDUsuario.Location = new System.Drawing.Point(265, 87);
            this.btnBuscarIDUsuario.Name = "btnBuscarIDUsuario";
            this.btnBuscarIDUsuario.Size = new System.Drawing.Size(75, 28);
            this.btnBuscarIDUsuario.TabIndex = 10;
            this.btnBuscarIDUsuario.Text = "&Buscar";
            this.btnBuscarIDUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarIDUsuario.Click += new System.EventHandler(this.btnBuscarIDUsuario_Click);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDUsuario.Location = new System.Drawing.Point(144, 87);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(100, 26);
            this.txtIDUsuario.TabIndex = 9;
            // 
            // lblListarPorID
            // 
            this.lblListarPorID.AutoSize = true;
            this.lblListarPorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListarPorID.Location = new System.Drawing.Point(50, 91);
            this.lblListarPorID.Name = "lblListarPorID";
            this.lblListarPorID.Size = new System.Drawing.Size(88, 20);
            this.lblListarPorID.TabIndex = 8;
            this.lblListarPorID.Text = "Ingrese ID:";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.lblTitulo.Location = new System.Drawing.Point(259, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(293, 36);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Listado de Usuarios";
            // 
            // ListadoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lvwListadoUsuario);
            this.Controls.Add(this.btnMostrarTodosUsuarios);
            this.Controls.Add(this.btnBuscarIDUsuario);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblListarPorID);
            this.Controls.Add(this.lblTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ListadoUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Listado de Usuarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListView lvwListadoUsuario;
        private System.Windows.Forms.Button btnMostrarTodosUsuarios;
        private System.Windows.Forms.Button btnBuscarIDUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblListarPorID;
        private System.Windows.Forms.Label lblTitulo;
    }
}