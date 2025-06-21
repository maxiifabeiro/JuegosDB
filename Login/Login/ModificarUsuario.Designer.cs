
namespace Login
{
    partial class ModificarUsuario
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
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.txtIDUsuario = new System.Windows.Forms.TextBox();
            this.lblBuscarUsuario = new System.Windows.Forms.Label();
            this.lblIDUsuario = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblPermisoUsuario = new System.Windows.Forms.Label();
            this.lblFechaRegistro = new System.Windows.Forms.Label();
            this.dtpFechaRegistro = new System.Windows.Forms.DateTimePicker();
            this.lblContraseniaUsuario = new System.Windows.Forms.Label();
            this.lblCorreoElectronico = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblMostrarIDUsuario = new System.Windows.Forms.Label();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtContraseniaUsuario = new System.Windows.Forms.TextBox();
            this.ckbEsAdministrador = new System.Windows.Forms.CheckBox();
            this.cbxPermiso = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModificarDatosUsuario = new System.Windows.Forms.Button();
            this.lblAvatarURL = new System.Windows.Forms.Label();
            this.txtAvatarURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(402, 92);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(75, 27);
            this.btnBuscarUsuario.TabIndex = 2;
            this.btnBuscarUsuario.Text = "&Buscar";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // txtIDUsuario
            // 
            this.txtIDUsuario.Location = new System.Drawing.Point(268, 95);
            this.txtIDUsuario.Name = "txtIDUsuario";
            this.txtIDUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtIDUsuario.TabIndex = 1;
            // 
            // lblBuscarUsuario
            // 
            this.lblBuscarUsuario.AutoSize = true;
            this.lblBuscarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscarUsuario.Location = new System.Drawing.Point(12, 95);
            this.lblBuscarUsuario.Name = "lblBuscarUsuario";
            this.lblBuscarUsuario.Size = new System.Drawing.Size(250, 20);
            this.lblBuscarUsuario.TabIndex = 0;
            this.lblBuscarUsuario.Text = "Ingrese ID del usuario a modificar:";
            // 
            // lblIDUsuario
            // 
            this.lblIDUsuario.AutoSize = true;
            this.lblIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDUsuario.Location = new System.Drawing.Point(12, 135);
            this.lblIDUsuario.Name = "lblIDUsuario";
            this.lblIDUsuario.Size = new System.Drawing.Size(89, 20);
            this.lblIDUsuario.TabIndex = 0;
            this.lblIDUsuario.Text = "ID Usuario:";
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVolver.Location = new System.Drawing.Point(268, 694);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 28);
            this.btnVolver.TabIndex = 11;
            this.btnVolver.Text = "&Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(59, 694);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 28);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblPermisoUsuario
            // 
            this.lblPermisoUsuario.AutoSize = true;
            this.lblPermisoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermisoUsuario.Location = new System.Drawing.Point(123, 534);
            this.lblPermisoUsuario.Name = "lblPermisoUsuario";
            this.lblPermisoUsuario.Size = new System.Drawing.Size(125, 20);
            this.lblPermisoUsuario.TabIndex = 0;
            this.lblPermisoUsuario.Text = "Tipo de permiso:";
            // 
            // lblFechaRegistro
            // 
            this.lblFechaRegistro.AutoSize = true;
            this.lblFechaRegistro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaRegistro.Location = new System.Drawing.Point(123, 369);
            this.lblFechaRegistro.Name = "lblFechaRegistro";
            this.lblFechaRegistro.Size = new System.Drawing.Size(137, 20);
            this.lblFechaRegistro.TabIndex = 0;
            this.lblFechaRegistro.Text = "Fecha de registro:";
            // 
            // dtpFechaRegistro
            // 
            this.dtpFechaRegistro.Location = new System.Drawing.Point(127, 392);
            this.dtpFechaRegistro.Name = "dtpFechaRegistro";
            this.dtpFechaRegistro.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaRegistro.TabIndex = 6;
            // 
            // lblContraseniaUsuario
            // 
            this.lblContraseniaUsuario.AutoSize = true;
            this.lblContraseniaUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseniaUsuario.Location = new System.Drawing.Point(123, 309);
            this.lblContraseniaUsuario.Name = "lblContraseniaUsuario";
            this.lblContraseniaUsuario.Size = new System.Drawing.Size(96, 20);
            this.lblContraseniaUsuario.TabIndex = 0;
            this.lblContraseniaUsuario.Text = "Contraseña:";
            // 
            // lblCorreoElectronico
            // 
            this.lblCorreoElectronico.AutoSize = true;
            this.lblCorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreoElectronico.Location = new System.Drawing.Point(123, 251);
            this.lblCorreoElectronico.Name = "lblCorreoElectronico";
            this.lblCorreoElectronico.Size = new System.Drawing.Size(144, 20);
            this.lblCorreoElectronico.TabIndex = 0;
            this.lblCorreoElectronico.Text = "Correo Electronico:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreUsuario.Location = new System.Drawing.Point(123, 195);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(147, 20);
            this.lblNombreUsuario.TabIndex = 0;
            this.lblNombreUsuario.Text = "Nombre de usuario:";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(127, 218);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtNombreUsuario.TabIndex = 3;
            // 
            // lblMostrarIDUsuario
            // 
            this.lblMostrarIDUsuario.AutoSize = true;
            this.lblMostrarIDUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMostrarIDUsuario.Location = new System.Drawing.Point(107, 135);
            this.lblMostrarIDUsuario.Name = "lblMostrarIDUsuario";
            this.lblMostrarIDUsuario.Size = new System.Drawing.Size(28, 20);
            this.lblMostrarIDUsuario.TabIndex = 0;
            this.lblMostrarIDUsuario.Text = "ID";
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(127, 274);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(200, 20);
            this.txtCorreoElectronico.TabIndex = 4;
            // 
            // txtContraseniaUsuario
            // 
            this.txtContraseniaUsuario.Location = new System.Drawing.Point(127, 332);
            this.txtContraseniaUsuario.Name = "txtContraseniaUsuario";
            this.txtContraseniaUsuario.Size = new System.Drawing.Size(200, 20);
            this.txtContraseniaUsuario.TabIndex = 5;
            // 
            // ckbEsAdministrador
            // 
            this.ckbEsAdministrador.AutoSize = true;
            this.ckbEsAdministrador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbEsAdministrador.Location = new System.Drawing.Point(127, 437);
            this.ckbEsAdministrador.Name = "ckbEsAdministrador";
            this.ckbEsAdministrador.Size = new System.Drawing.Size(149, 24);
            this.ckbEsAdministrador.TabIndex = 7;
            this.ckbEsAdministrador.Text = "&Es Administrador";
            this.ckbEsAdministrador.UseVisualStyleBackColor = true;
            // 
            // cbxPermiso
            // 
            this.cbxPermiso.FormattingEnabled = true;
            this.cbxPermiso.Location = new System.Drawing.Point(127, 557);
            this.cbxPermiso.Name = "cbxPermiso";
            this.cbxPermiso.Size = new System.Drawing.Size(200, 21);
            this.cbxPermiso.TabIndex = 8;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Britannic Bold", 24F);
            this.lblTitulo.Location = new System.Drawing.Point(121, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(267, 36);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Modificar Usuario";
            // 
            // btnModificarDatosUsuario
            // 
            this.btnModificarDatosUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificarDatosUsuario.FlatAppearance.BorderColor = System.Drawing.Color.DodgerBlue;
            this.btnModificarDatosUsuario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Moccasin;
            this.btnModificarDatosUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarDatosUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarDatosUsuario.Location = new System.Drawing.Point(127, 607);
            this.btnModificarDatosUsuario.Name = "btnModificarDatosUsuario";
            this.btnModificarDatosUsuario.Size = new System.Drawing.Size(216, 39);
            this.btnModificarDatosUsuario.TabIndex = 9;
            this.btnModificarDatosUsuario.Text = "M&odificar datos personales";
            this.btnModificarDatosUsuario.UseVisualStyleBackColor = true;
            this.btnModificarDatosUsuario.Click += new System.EventHandler(this.btnModificarDatosUsuario_Click);
            // 
            // lblAvatarURL
            // 
            this.lblAvatarURL.AutoSize = true;
            this.lblAvatarURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAvatarURL.Location = new System.Drawing.Point(123, 473);
            this.lblAvatarURL.Name = "lblAvatarURL";
            this.lblAvatarURL.Size = new System.Drawing.Size(144, 20);
            this.lblAvatarURL.TabIndex = 12;
            this.lblAvatarURL.Text = "URL Foto de Perfil:";
            // 
            // txtAvatarURL
            // 
            this.txtAvatarURL.Location = new System.Drawing.Point(127, 496);
            this.txtAvatarURL.Name = "txtAvatarURL";
            this.txtAvatarURL.Size = new System.Drawing.Size(200, 20);
            this.txtAvatarURL.TabIndex = 13;
            // 
            // ModificarUsuario
            // 
            this.AcceptButton = this.btnGuardar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(511, 742);
            this.Controls.Add(this.txtAvatarURL);
            this.Controls.Add(this.lblAvatarURL);
            this.Controls.Add(this.btnModificarDatosUsuario);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.cbxPermiso);
            this.Controls.Add(this.ckbEsAdministrador);
            this.Controls.Add(this.txtContraseniaUsuario);
            this.Controls.Add(this.txtCorreoElectronico);
            this.Controls.Add(this.lblMostrarIDUsuario);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.txtIDUsuario);
            this.Controls.Add(this.lblBuscarUsuario);
            this.Controls.Add(this.lblIDUsuario);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblPermisoUsuario);
            this.Controls.Add(this.lblFechaRegistro);
            this.Controls.Add(this.dtpFechaRegistro);
            this.Controls.Add(this.lblContraseniaUsuario);
            this.Controls.Add(this.lblCorreoElectronico);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ModificarUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Usuario";
            this.Load += new System.EventHandler(this.ModificarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.TextBox txtIDUsuario;
        private System.Windows.Forms.Label lblBuscarUsuario;
        private System.Windows.Forms.Label lblIDUsuario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label lblPermisoUsuario;
        private System.Windows.Forms.Label lblFechaRegistro;
        private System.Windows.Forms.DateTimePicker dtpFechaRegistro;
        private System.Windows.Forms.Label lblContraseniaUsuario;
        private System.Windows.Forms.Label lblCorreoElectronico;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblMostrarIDUsuario;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtContraseniaUsuario;
        private System.Windows.Forms.CheckBox ckbEsAdministrador;
        private System.Windows.Forms.ComboBox cbxPermiso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModificarDatosUsuario;
        private System.Windows.Forms.Label lblAvatarURL;
        private System.Windows.Forms.TextBox txtAvatarURL;
    }
}