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
                Image = imagen != null ? (Image)imagen.Clone() : null,
                SizeMode = PictureBoxSizeMode.Zoom,
                Size = tamano,
                Location = posicionInicial,
                BackColor = Color.Transparent
            };
            form.Controls.Add(imagenBala); 
            imagenBala.BringToFront(); 
        }

        public bool Mover()
        {
            imagenBala.Top -= velocidad; 

            if (imagenBala.Top + imagenBala.Height < 0)
            {
                Destruir();
                return false; 
            }
            return true;
        }

        public void Destruir()
        {
            if (imagenBala != null && !imagenBala.IsDisposed && imagenBala.Parent != null)
            {
                imagenBala.Parent.Controls.Remove(imagenBala); 
                imagenBala.Dispose(); 
            }
        }

        public bool ColisionaCon(PictureBox objetivo)
        {
            return imagenBala.Bounds.IntersectsWith(objetivo.Bounds); // Verifica colisión
        }
    }
}