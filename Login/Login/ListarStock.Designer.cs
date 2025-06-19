namespace Login
{
    partial class ListarStock
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
            this.lblListarStock = new System.Windows.Forms.Label();
            this.lvListaStock = new System.Windows.Forms.ListView();
            this.btnVolverAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblListarStock
            // 
            this.lblListarStock.AutoSize = true;
            this.lblListarStock.Location = new System.Drawing.Point(333, 9);
            this.lblListarStock.Name = "lblListarStock";
            this.lblListarStock.Size = new System.Drawing.Size(75, 13);
            this.lblListarStock.TabIndex = 0;
            this.lblListarStock.Text = "Lista de Stock";
            // 
            // lvListaStock
            // 
            this.lvListaStock.HideSelection = false;
            this.lvListaStock.Location = new System.Drawing.Point(30, 53);
            this.lvListaStock.Name = "lvListaStock";
            this.lvListaStock.Size = new System.Drawing.Size(738, 345);
            this.lvListaStock.TabIndex = 3;
            this.lvListaStock.UseCompatibleStateImageBehavior = false;
            // 
            // btnVolverAtras
            // 
            this.btnVolverAtras.Location = new System.Drawing.Point(693, 415);
            this.btnVolverAtras.Name = "btnVolverAtras";
            this.btnVolverAtras.Size = new System.Drawing.Size(75, 23);
            this.btnVolverAtras.TabIndex = 4;
            this.btnVolverAtras.Text = "Volver Atras";
            this.btnVolverAtras.UseVisualStyleBackColor = true;
            this.btnVolverAtras.Click += new System.EventHandler(this.btnVolverAtras_Click);
            // 
            // ListarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnVolverAtras);
            this.Controls.Add(this.lvListaStock);
            this.Controls.Add(this.lblListarStock);
            this.Name = "ListarStock";
            this.Text = "ListarStock";
            this.Load += new System.EventHandler(this.ListarStock_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListarStock;
        private System.Windows.Forms.ListView lvListaStock;
        private System.Windows.Forms.Button btnVolverAtras;
    }
}