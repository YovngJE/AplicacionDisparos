using System.Drawing;
using System.Windows.Forms;

namespace H_P_II_Clase1
{
    public class Bala
    {
        private PictureBox imagenBala;
        private int velocidad = 10;

        public Bala(Form form, Point posicionInicial, Size tamano, Image imagen)
        {
            imagenBala = new PictureBox
            {
                Image = imagen != null ? (Image)imagen.Clone() : null, // Clona la imagen si existe
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = tamano,
                Location = posicionInicial,
                BackColor = Color.Transparent
            };
            form.Controls.Add(imagenBala); // Agrega la bala al formulario
            imagenBala.BringToFront(); // Asegura que la bala esté encima de otros controles
        }

        public bool Mover()
        {
            imagenBala.Top -= velocidad; // Mueve la bala hacia arriba

            if (imagenBala.Top + imagenBala.Height < 0) // Verifica si la bala sale de la pantalla
            {
                Destruir(); // Destruye la bala
                return false; // Indica que la bala ya no existe
            }
            return true; // Indica que la bala sigue en pantalla
        }

        public void Destruir()
        {
            if (imagenBala != null && !imagenBala.IsDisposed && imagenBala.Parent != null)
            {
                imagenBala.Parent.Controls.Remove(imagenBala); // Remueve la bala del formulario
                imagenBala.Dispose(); // Libera los recursos de la bala
            }
        }

        public bool ColisionaCon(PictureBox objetivo)
        {
            return imagenBala.Bounds.IntersectsWith(objetivo.Bounds); // Verifica colisión
        }
    }
}