using System.Drawing;
using System.Windows.Forms;

namespace H_P_II_Clase1
{
    public class Bala
    {
        public PictureBox Imagen { get; private set; }
        private int velocidad;

        public Bala(Point posicionInicial, int velocidad, PictureBox imagenBala)
        {
            // Clona el PictureBox de la bala para crear una nueva instancia
            Imagen = new PictureBox
            {
                Size = imagenBala.Size,          // Mismo tamaño que la imagen original
                Image = imagenBala.Image,        // Misma imagen
                SizeMode = imagenBala.SizeMode,  // Mismo modo de ajuste
                Location = posicionInicial,       // Posición inicial
                Visible = true                    // Hacerla visible
            };
            this.velocidad = velocidad;
        }

        public void Mover()
        {
            Imagen.Top -= velocidad; // Mueve la bala hacia arriba
        }

        public bool ColisionaCon(PictureBox objetivo)
        {
            return Imagen.Bounds.IntersectsWith(objetivo.Bounds);
        }
    }
}