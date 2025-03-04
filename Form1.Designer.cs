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
            this.picBala = new System.Windows.Forms.PictureBox();
            this.PicEjemplo = new System.Windows.Forms.PictureBox();
            this.btnDisparar = new System.Windows.Forms.Button();
            this.tmrBala = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBala)).BeginInit();
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
            this.btnDesplazar.Click += new System.EventHandler(this.btnDesplazar_Click_1);
            // 
            // tmrDesplazar
            // 
            this.tmrDesplazar.Enabled = true;
            this.tmrDesplazar.Tick += new System.EventHandler(this.tmrDesplazar_Tick_1);
            // 
            // picBala
            // 
            this.picBala.Image = global::H_P_II_Clase3.Properties.Resources.PngBasket;
            this.picBala.Location = new System.Drawing.Point(321, 380);
            this.picBala.Name = "picBala";
            this.picBala.Size = new System.Drawing.Size(55, 58);
            this.picBala.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBala.TabIndex = 2;
            this.picBala.TabStop = false;
            this.picBala.Visible = false;
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
            this.btnDisparar.Click += new System.EventHandler(this.btnDisparar_Click_1);
            // 
            // tmrBala
            // 
            this.tmrBala.Enabled = true;
            this.tmrBala.Interval = 50;
            this.tmrBala.Tick += new System.EventHandler(this.tmrBala_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDisparar);
            this.Controls.Add(this.picBala);
            this.Controls.Add(this.btnDesplazar);
            this.Controls.Add(this.PicEjemplo);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picBala)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicEjemplo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicEjemplo;
        private System.Windows.Forms.Button btnDesplazar;
        private System.Windows.Forms.Timer tmrDesplazar;
        private System.Windows.Forms.PictureBox picBala;
        private System.Windows.Forms.Timer tmrBalas;
        private System.Windows.Forms.Button btnDisparar;
        private System.Windows.Forms.Timer tmrBala;
    }
}

