namespace Login
{
    partial class CambiarContrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CambiarContrasena));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCambiarContrasena = new System.Windows.Forms.Button();
            this.txtVerificarContrasena = new System.Windows.Forms.TextBox();
            this.txtNuevaContrasena = new System.Windows.Forms.TextBox();
            this.lbl_NuevaContrasenaConfirm_CC = new System.Windows.Forms.Label();
            this.lbl_NuevaContrasenaCC = new System.Windows.Forms.Label();
            this.btn_VerificarUsuario_CC = new System.Windows.Forms.Button();
            this.txtusuario_CC = new System.Windows.Forms.TextBox();
            this.lblFechaNac_CC = new System.Windows.Forms.Label();
            this.lblUsuario_CC = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnCambiarContrasena);
            this.groupBox1.Controls.Add(this.txtVerificarContrasena);
            this.groupBox1.Controls.Add(this.txtNuevaContrasena);
            this.groupBox1.Controls.Add(this.lbl_NuevaContrasenaConfirm_CC);
            this.groupBox1.Controls.Add(this.lbl_NuevaContrasenaCC);
            this.groupBox1.Controls.Add(this.btn_VerificarUsuario_CC);
            this.groupBox1.Controls.Add(this.txtusuario_CC);
            this.groupBox1.Controls.Add(this.lblFechaNac_CC);
            this.groupBox1.Controls.Add(this.lblUsuario_CC);
            this.groupBox1.Location = new System.Drawing.Point(89, 79);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(388, 293);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingrese los siguientes datos para modificar la contraseña";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(215, 70);
            this.dateTimePicker1.MaxDate = new System.DateTime(2025, 6, 17, 0, 0, 0, 0);
            this.dateTimePicker1.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Value = new System.DateTime(2025, 6, 17, 0, 0, 0, 0);
            // 
            // btnCambiarContrasena
            // 
            this.btnCambiarContrasena.Location = new System.Drawing.Point(129, 245);
            this.btnCambiarContrasena.Name = "btnCambiarContrasena";
            this.btnCambiarContrasena.Size = new System.Drawing.Size(116, 23);
            this.btnCambiarContrasena.TabIndex = 6;
            this.btnCambiarContrasena.Text = "Cambiar Contraseña";
            this.btnCambiarContrasena.UseVisualStyleBackColor = true;
            this.btnCambiarContrasena.Click += new System.EventHandler(this.btnCambiarContrasena_Click);
            // 
            // txtVerificarContrasena
            // 
            this.txtVerificarContrasena.Location = new System.Drawing.Point(215, 206);
            this.txtVerificarContrasena.Name = "txtVerificarContrasena";
            this.txtVerificarContrasena.PasswordChar = '*';
            this.txtVerificarContrasena.Size = new System.Drawing.Size(100, 20);
            this.txtVerificarContrasena.TabIndex = 5;
            // 
            // txtNuevaContrasena
            // 
            this.txtNuevaContrasena.Location = new System.Drawing.Point(215, 175);
            this.txtNuevaContrasena.Name = "txtNuevaContrasena";
            this.txtNuevaContrasena.PasswordChar = '*';
            this.txtNuevaContrasena.Size = new System.Drawing.Size(100, 20);
            this.txtNuevaContrasena.TabIndex = 5;
            // 
            // lbl_NuevaContrasenaConfirm_CC
            // 
            this.lbl_NuevaContrasenaConfirm_CC.AutoSize = true;
            this.lbl_NuevaContrasenaConfirm_CC.Location = new System.Drawing.Point(18, 206);
            this.lbl_NuevaContrasenaConfirm_CC.Name = "lbl_NuevaContrasenaConfirm_CC";
            this.lbl_NuevaContrasenaConfirm_CC.Size = new System.Drawing.Size(102, 13);
            this.lbl_NuevaContrasenaConfirm_CC.TabIndex = 4;
            this.lbl_NuevaContrasenaConfirm_CC.Text = "Verificar Contraseña";
            // 
            // lbl_NuevaContrasenaCC
            // 
            this.lbl_NuevaContrasenaCC.AutoSize = true;
            this.lbl_NuevaContrasenaCC.Location = new System.Drawing.Point(18, 178);
            this.lbl_NuevaContrasenaCC.Name = "lbl_NuevaContrasenaCC";
            this.lbl_NuevaContrasenaCC.Size = new System.Drawing.Size(96, 13);
            this.lbl_NuevaContrasenaCC.TabIndex = 4;
            this.lbl_NuevaContrasenaCC.Text = "Nueva Contraseña";
            // 
            // btn_VerificarUsuario_CC
            // 
            this.btn_VerificarUsuario_CC.Location = new System.Drawing.Point(129, 117);
            this.btn_VerificarUsuario_CC.Name = "btn_VerificarUsuario_CC";
            this.btn_VerificarUsuario_CC.Size = new System.Drawing.Size(102, 23);
            this.btn_VerificarUsuario_CC.TabIndex = 3;
            this.btn_VerificarUsuario_CC.Text = "Verificar usuario";
            this.btn_VerificarUsuario_CC.UseVisualStyleBackColor = true;
            this.btn_VerificarUsuario_CC.Click += new System.EventHandler(this.btnVerificarUsuario_Click);
            // 
            // txtusuario_CC
            // 
            this.txtusuario_CC.Location = new System.Drawing.Point(215, 43);
            this.txtusuario_CC.Name = "txtusuario_CC";
            this.txtusuario_CC.Size = new System.Drawing.Size(100, 20);
            this.txtusuario_CC.TabIndex = 2;
            this.txtusuario_CC.TextChanged += new System.EventHandler(this.txtusuario_CC_TextChanged);
            // 
            // lblFechaNac_CC
            // 
            this.lblFechaNac_CC.AutoSize = true;
            this.lblFechaNac_CC.Location = new System.Drawing.Point(18, 74);
            this.lblFechaNac_CC.Name = "lblFechaNac_CC";
            this.lblFechaNac_CC.Size = new System.Drawing.Size(111, 13);
            this.lblFechaNac_CC.TabIndex = 1;
            this.lblFechaNac_CC.Text = "Fecha de Nacimiento:";
            // 
            // lblUsuario_CC
            // 
            this.lblUsuario_CC.AutoSize = true;
            this.lblUsuario_CC.Location = new System.Drawing.Point(18, 50);
            this.lblUsuario_CC.Name = "lblUsuario_CC";
            this.lblUsuario_CC.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario_CC.TabIndex = 0;
            this.lblUsuario_CC.Text = "Usuario:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(521, 79);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(582, 324);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(124, 34);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // CambiarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "CambiarContrasena";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cambiar Contraseña";
            this.Load += new System.EventHandler(this.CambiarContrasena_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtusuario_CC;
        private System.Windows.Forms.Label lblFechaNac_CC;
        private System.Windows.Forms.Label lblUsuario_CC;
        private System.Windows.Forms.Button btnCambiarContrasena;
        private System.Windows.Forms.TextBox txtVerificarContrasena;
        private System.Windows.Forms.TextBox txtNuevaContrasena;
        private System.Windows.Forms.Label lbl_NuevaContrasenaConfirm_CC;
        private System.Windows.Forms.Label lbl_NuevaContrasenaCC;
        private System.Windows.Forms.Button btn_VerificarUsuario_CC;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

