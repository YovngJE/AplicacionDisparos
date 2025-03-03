namespace H_P_II_Clase3
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnDesplazar = new System.Windows.Forms.Button();
            this.tmrDesplazar = new System.Windows.Forms.Timer(this.components);
            this.picBasket = new System.Windows.Forms.PictureBox();
            this.PicEjemplo = new System.Windows.Forms.PictureBox();
            this.tmrDisparos = new System.Windows.Forms.Timer(this.components);
            this.btnDisparar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBasket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEjemplo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDesplazar
            // 
            this.btnDesplazar.Location = new System.Drawing.Point(32, 31);
            this.btnDesplazar.Name = "btnDesplazar";
            this.btnDesplazar.Size = new System.Drawing.Size(94, 23);
            this.btnDesplazar.TabIndex = 1;
            this.btnDesplazar.Text = "Desplazar";
            this.btnDesplazar.UseVisualStyleBackColor = true;
            // 
            // picBasket
            // 
            this.picBasket.Image = global::H_P_II_Clase3.Properties.Resources.PngBasket;
            this.picBasket.Location = new System.Drawing.Point(295, 360);
            this.picBasket.Name = "picBasket";
            this.picBasket.Size = new System.Drawing.Size(100, 78);
            this.picBasket.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBasket.TabIndex = 2;
            this.picBasket.TabStop = false;
            // 
            // PicEjemplo
            // 
            this.PicEjemplo.Image = global::H_P_II_Clase3.Properties.Resources.Imagen_de_WhatsApp_2025_02_26_a_las_12_29_32_9b74db36;
            this.PicEjemplo.Location = new System.Drawing.Point(257, 12);
            this.PicEjemplo.Name = "PicEjemplo";
            this.PicEjemplo.Size = new System.Drawing.Size(196, 218);
            this.PicEjemplo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicEjemplo.TabIndex = 0;
            this.PicEjemplo.TabStop = false;
            // 
            // btnDisparar
            // 
            this.btnDisparar.Location = new System.Drawing.Point(41, 73);
            this.btnDisparar.Name = "btnDisparar";
            this.btnDisparar.Size = new System.Drawing.Size(75, 23);
            this.btnDisparar.TabIndex = 3;
            this.btnDisparar.Text = "Disparar";
            this.btnDisparar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisparar);
            this.Controls.Add(this.picBasket);
            this.Controls.Add(this.btnDesplazar);
            this.Controls.Add(this.PicEjemplo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBasket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEjemplo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicEjemplo;
        private System.Windows.Forms.Button btnDesplazar;
        private System.Windows.Forms.Timer tmrDesplazar;
        private System.Windows.Forms.PictureBox picBasket;
        private System.Windows.Forms.Timer tmrBalas;
        private System.Windows.Forms.Timer tmrDisparos;
        private System.Windows.Forms.Button btnDisparar;
    }
}

