namespace Login
{
    partial class CrearUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbPermisos = new System.Windows.Forms.ComboBox();
            this.lblPermiso = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.txtAvatar = new System.Windows.Forms.TextBox();
            this.txtComprobarContrasena = new System.Windows.Forms.TextBox();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.txtCorreoElectronico = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.AvatarURL = new System.Windows.Forms.Label();
            this.ComprobarContrasena = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Contrasena = new System.Windows.Forms.Label();
            this.CorreoElectronico = new System.Windows.Forms.Label();
            this.NombreUsuario = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbPermisos);
            this.groupBox1.Controls.Add(this.lblPermiso);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.btnCrearUsuario);
            this.groupBox1.Controls.Add(this.txtAvatar);
            this.groupBox1.Controls.Add(this.txtComprobarContrasena);
            this.groupBox1.Controls.Add(this.txtContrasena);
            this.groupBox1.Controls.Add(this.txtCorreoElectronico);
            this.groupBox1.Controls.Add(this.txtNombreUsuario);
            this.groupBox1.Controls.Add(this.AvatarURL);
            this.groupBox1.Controls.Add(this.ComprobarContrasena);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Contrasena);
            this.groupBox1.Controls.Add(this.CorreoElectronico);
            this.groupBox1.Controls.Add(this.NombreUsuario);
            this.groupBox1.Location = new System.Drawing.Point(51, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 374);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Nuevo Usuario";
            // 
            // cmbPermisos
            // 
            this.cmbPermisos.FormattingEnabled = true;
            this.cmbPermisos.Location = new System.Drawing.Point(190, 159);
            this.cmbPermisos.Name = "cmbPermisos";
            this.cmbPermisos.Size = new System.Drawing.Size(200, 21);
            this.cmbPermisos.TabIndex = 1;
            // 
            // lblPermiso
            // 
            this.lblPermiso.AutoSize = true;
            this.lblPermiso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPermiso.Location = new System.Drawing.Point(21, 164);
            this.lblPermiso.Name = "lblPermiso";
            this.lblPermiso.Size = new System.Drawing.Size(60, 16);
            this.lblPermiso.TabIndex = 15;
            this.lblPermiso.Text = "Permiso:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(190, 194);
            this.dateTimePicker2.MaxDate = new System.DateTime(2025, 6, 18, 0, 0, 0, 0);
            this.dateTimePicker2.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(162, 20);
            this.dateTimePicker2.TabIndex = 14;
            this.dateTimePicker2.Value = new System.DateTime(2025, 6, 18, 0, 0, 0, 0);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(174, 310);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(125, 31);
            this.btnCrearUsuario.TabIndex = 9;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // txtAvatar
            // 
            this.txtAvatar.Location = new System.Drawing.Point(190, 220);
            this.txtAvatar.Name = "txtAvatar";
            this.txtAvatar.Size = new System.Drawing.Size(162, 20);
            this.txtAvatar.TabIndex = 8;
            // 
            // txtComprobarContrasena
            // 
            this.txtComprobarContrasena.Location = new System.Drawing.Point(190, 130);
            this.txtComprobarContrasena.Name = "txtComprobarContrasena";
            this.txtComprobarContrasena.PasswordChar = '*';
            this.txtComprobarContrasena.Size = new System.Drawing.Size(162, 20);
            this.txtComprobarContrasena.TabIndex = 3;
            // 
            // txtContrasena
            // 
            this.txtContrasena.Location = new System.Drawing.Point(190, 95);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '*';
            this.txtContrasena.Size = new System.Drawing.Size(162, 20);
            this.txtContrasena.TabIndex = 2;
            // 
            // txtCorreoElectronico
            // 
            this.txtCorreoElectronico.Location = new System.Drawing.Point(190, 64);
            this.txtCorreoElectronico.Name = "txtCorreoElectronico";
            this.txtCorreoElectronico.Size = new System.Drawing.Size(162, 20);
            this.txtCorreoElectronico.TabIndex = 1;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(190, 29);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(162, 20);
            this.txtNombreUsuario.TabIndex = 0;
            // 
            // AvatarURL
            // 
            this.AvatarURL.AutoSize = true;
            this.AvatarURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AvatarURL.Location = new System.Drawing.Point(21, 224);
            this.AvatarURL.Name = "AvatarURL";
            this.AvatarURL.Size = new System.Drawing.Size(73, 16);
            this.AvatarURL.TabIndex = 13;
            this.AvatarURL.Text = "AvatarURL";
            // 
            // ComprobarContrasena
            // 
            this.ComprobarContrasena.AutoSize = true;
            this.ComprobarContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComprobarContrasena.Location = new System.Drawing.Point(21, 134);
            this.ComprobarContrasena.Name = "ComprobarContrasena";
            this.ComprobarContrasena.Size = new System.Drawing.Size(150, 16);
            this.ComprobarContrasena.TabIndex = 9;
            this.ComprobarContrasena.Text = "Comprobar Contraseña:";
            this.ComprobarContrasena.Click += new System.EventHandler(this.ComprobarContrasena_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Fecha de Nacimiento:";
            // 
            // Contrasena
            // 
            this.Contrasena.AutoSize = true;
            this.Contrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Contrasena.Location = new System.Drawing.Point(21, 99);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(79, 16);
            this.Contrasena.TabIndex = 9;
            this.Contrasena.Text = "Contraseña:";
            // 
            // CorreoElectronico
            // 
            this.CorreoElectronico.AutoSize = true;
            this.CorreoElectronico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorreoElectronico.Location = new System.Drawing.Point(21, 68);
            this.CorreoElectronico.Name = "CorreoElectronico";
            this.CorreoElectronico.Size = new System.Drawing.Size(121, 16);
            this.CorreoElectronico.TabIndex = 8;
            this.CorreoElectronico.Text = "Correo Electrónico:";
            // 
            // NombreUsuario
            // 
            this.NombreUsuario.AutoSize = true;
            this.NombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreUsuario.Location = new System.Drawing.Point(21, 33);
            this.NombreUsuario.Name = "NombreUsuario";
            this.NombreUsuario.Size = new System.Drawing.Size(128, 16);
            this.NombreUsuario.TabIndex = 7;
            this.NombreUsuario.Text = "Nombre de Usuario:";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(515, 32);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(301, 296);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnVolver.Location = new System.Drawing.Point(617, 349);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 34);
            this.btnVolver.TabIndex = 0;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnVolver;
            this.ClientSize = new System.Drawing.Size(865, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear usuario nuevo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.TextBox txtCorreoElectronico;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label AvatarURL;
        private System.Windows.Forms.Label Contrasena;
        private System.Windows.Forms.Label CorreoElectronico;
        private System.Windows.Forms.Label NombreUsuario;
        private System.Windows.Forms.TextBox txtAvatar;
        private System.Windows.Forms.TextBox txtComprobarContrasena;
        private System.Windows.Forms.Label ComprobarContrasena;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPermisos;
        private System.Windows.Forms.Label lblPermiso;
    }
}