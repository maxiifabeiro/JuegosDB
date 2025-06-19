
namespace Login
{
    partial class ABMLUsuario
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
            this.btnAltaUsuario = new System.Windows.Forms.Button();
            this.btnBajaUsuario = new System.Windows.Forms.Button();
            this.btnModificacionUsuario = new System.Windows.Forms.Button();
            this.btnListarUsuarios = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAltaUsuario
            // 
            this.btnAltaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAltaUsuario.Location = new System.Drawing.Point(207, 49);
            this.btnAltaUsuario.Name = "btnAltaUsuario";
            this.btnAltaUsuario.Size = new System.Drawing.Size(164, 33);
            this.btnAltaUsuario.TabIndex = 0;
            this.btnAltaUsuario.Text = "&Alta Usuario";
            this.btnAltaUsuario.UseVisualStyleBackColor = true;
            this.btnAltaUsuario.Click += new System.EventHandler(this.btnAltaUsuario_Click);
            // 
            // btnBajaUsuario
            // 
            this.btnBajaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBajaUsuario.Location = new System.Drawing.Point(207, 114);
            this.btnBajaUsuario.Name = "btnBajaUsuario";
            this.btnBajaUsuario.Size = new System.Drawing.Size(164, 33);
            this.btnBajaUsuario.TabIndex = 1;
            this.btnBajaUsuario.Text = "&Baja Usuario";
            this.btnBajaUsuario.UseVisualStyleBackColor = true;
            this.btnBajaUsuario.Click += new System.EventHandler(this.btnBajaUsuario_Click);
            // 
            // btnModificacionUsuario
            // 
            this.btnModificacionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificacionUsuario.Location = new System.Drawing.Point(207, 182);
            this.btnModificacionUsuario.Name = "btnModificacionUsuario";
            this.btnModificacionUsuario.Size = new System.Drawing.Size(164, 33);
            this.btnModificacionUsuario.TabIndex = 2;
            this.btnModificacionUsuario.Text = "&Modificacion Usuario";
            this.btnModificacionUsuario.UseVisualStyleBackColor = true;
            this.btnModificacionUsuario.Click += new System.EventHandler(this.btnModificacionUsuario_Click);
            // 
            // btnListarUsuarios
            // 
            this.btnListarUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarUsuarios.Location = new System.Drawing.Point(207, 255);
            this.btnListarUsuarios.Name = "btnListarUsuarios";
            this.btnListarUsuarios.Size = new System.Drawing.Size(164, 33);
            this.btnListarUsuarios.TabIndex = 3;
            this.btnListarUsuarios.Text = "&Listar Usuarios";
            this.btnListarUsuarios.UseVisualStyleBackColor = true;
            this.btnListarUsuarios.Click += new System.EventHandler(this.btnListarUsuarios_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(207, 382);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(151, 33);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "&Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ABMLUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnSalir;
            this.ClientSize = new System.Drawing.Size(577, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnListarUsuarios);
            this.Controls.Add(this.btnModificacionUsuario);
            this.Controls.Add(this.btnBajaUsuario);
            this.Controls.Add(this.btnAltaUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ABMLUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ABML Usuario";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAltaUsuario;
        private System.Windows.Forms.Button btnBajaUsuario;
        private System.Windows.Forms.Button btnModificacionUsuario;
        private System.Windows.Forms.Button btnListarUsuarios;
        private System.Windows.Forms.Button btnSalir;
    }
}