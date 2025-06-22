namespace Login
{
    partial class ClasificaciónJuegosXEdad
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
            this.DGV_JuegosXEdad = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_JuegosXEdad)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_JuegosXEdad
            // 
            this.DGV_JuegosXEdad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_JuegosXEdad.Location = new System.Drawing.Point(44, 12);
            this.DGV_JuegosXEdad.Name = "DGV_JuegosXEdad";
            this.DGV_JuegosXEdad.Size = new System.Drawing.Size(708, 396);
            this.DGV_JuegosXEdad.TabIndex = 0;
            this.DGV_JuegosXEdad.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_JuegosXEdad_CellContentClick);
            // 
            // ClasificaciónJuegosXEdad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DGV_JuegosXEdad);
            this.Name = "ClasificaciónJuegosXEdad";
            this.Text = "ClasificaciónJuegosXEdad";
            this.Load += new System.EventHandler(this.ClasificaciónJuegosXEdad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_JuegosXEdad)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_JuegosXEdad;
    }
}