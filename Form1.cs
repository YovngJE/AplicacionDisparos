using H_P_II_Clase1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace H_P_II_Clase3
{
    public partial class Form1 : Form
    {

        int x = 251;
        bool dir = true;
        private List<Bala> balas = new List<Bala>();

        private PictureBox imagenBalaOriginal; 

        public Form1()
        {
            InitializeComponent();
             imagenBalaOriginal = picBala;
        }

 
        

        private void btnDisparar_Click_1(object sender, EventArgs e)
        {

            Point posicionInicial = new Point(PicEjemplo.Location.X + PicEjemplo.Width / 2, PicEjemplo.Location.Y);
            Bala nuevaBala = new Bala(this, posicionInicial, new Size(20, 40), picBala.Image); // Usa la imagen de "picBala"
            balas.Add(nuevaBala);
        }

        private void btnDesplazar_Click_1(object sender, EventArgs e)
        {
            tmrDesplazar.Enabled = true;
        }

        private void tmrDesplazar_Tick_1(object sender, EventArgs e)
        {
            PicEjemplo.Location = new Point(x, 35);
            if (dir)
            {
                x += 10;
            }
            else
            {
                x -= 10;
            }
            if (x >= this.Size.Width - PicEjemplo.Width)
            {
                dir = false;
            }
            if (x <= 10)
            {
                dir = true;
            }
        }

        private void tmrBala_Tick(object sender, EventArgs e)
        {

            for (int i = balas.Count - 1; i >= 0; i--)
            {
                if (!balas[i].Mover()) // Mueve la bala y verifica si sigue en pantalla
                {
                    balas.RemoveAt(i); // Elimina la bala de la lista si ya no está en pantalla
                }
                else if (balas[i].ColisionaCon(PicEjemplo)) // Verifica colisión con "PicEjemplo"
                {
                    // Lógica cuando la bala colisiona con "PicEjemplo"
                    balas[i].Destruir(); // Destruye la bala
                    balas.RemoveAt(i); // Elimina la bala de la lista
                    MessageBox.Show("¡Le diste a la imagen!"); // Mensaje de éxito
                }
            }
        }
    }
}