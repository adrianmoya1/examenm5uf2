namespace ExamenM5
{
    partial class FrmVintage
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
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.lbImg = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
            // 
            // pbImg
            // 
            this.pbImg.Image = global::ExamenM5.Properties.Resources.bali;
            this.pbImg.Location = new System.Drawing.Point(48, 33);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(417, 288);
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // lbImg
            // 
            this.lbImg.AutoSize = true;
            this.lbImg.Location = new System.Drawing.Point(539, 76);
            this.lbImg.Name = "lbImg";
            this.lbImg.Size = new System.Drawing.Size(70, 16);
            this.lbImg.TabIndex = 1;
            this.lbImg.Text = "Molt exòtic";
            // 
            // FrmVintage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbImg);
            this.Controls.Add(this.pbImg);
            this.Name = "FrmVintage";
            this.Text = "FrmVintage";
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lbImg;
    }
}