namespace ExamenM5
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btMenjar = new System.Windows.Forms.Button();
            this.btVintage = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btMenjar
            // 
            this.btMenjar.Location = new System.Drawing.Point(59, 68);
            this.btMenjar.Name = "btMenjar";
            this.btMenjar.Size = new System.Drawing.Size(75, 31);
            this.btMenjar.TabIndex = 0;
            this.btMenjar.Text = "Menjar";
            this.btMenjar.UseVisualStyleBackColor = true;
            this.btMenjar.Click += new System.EventHandler(this.btMenjar_Click);
            // 
            // btVintage
            // 
            this.btVintage.Location = new System.Drawing.Point(234, 68);
            this.btVintage.Name = "btVintage";
            this.btVintage.Size = new System.Drawing.Size(75, 31);
            this.btVintage.TabIndex = 1;
            this.btVintage.Text = "Vintage";
            this.btVintage.UseVisualStyleBackColor = true;
            this.btVintage.Click += new System.EventHandler(this.btVintage_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 210);
            this.Controls.Add(this.btVintage);
            this.Controls.Add(this.btMenjar);
            this.Name = "FrmMain";
            this.Text = "Examen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btMenjar;
        private System.Windows.Forms.Button btVintage;
    }
}

