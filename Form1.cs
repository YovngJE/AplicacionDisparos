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
       
        private PictureBox imagenBalaOriginal; // PictureBox de la bala que ya tienes en el formulario

        public Form1()
        {
            InitializeComponent();

            // Asignar el PictureBox de la bala que ya tienes en el formulario
            imagenBalaOriginal = picBasket; // Cambia "picBala" por el nombre de tu PictureBox

            // Configurar el temporizador para mover las balas
            tmrBalas = new Timer();
            tmrBalas.Interval = 50; // Intervalo de tiempo en milisegundos
            tmrBalas.Tick += TmrBalas_Tick;
            tmrBalas.Start();
        }

        private void TmrBalas_Tick(object sender, EventArgs e)
        {
            for (int i = balas.Count - 1; i >= 0; i--)
            {
                balas[i].Mover();

                // Verificar colisión con la imagen principal (PicEjemplo)
                if (balas[i].ColisionaCon(PicEjemplo))
                {
                    balas[i].Imagen.Dispose(); // Eliminar la imagen de la bala
                    balas.RemoveAt(i);        // Eliminar la bala de la lista
                }
                else if (balas[i].Imagen.Top + balas[i].Imagen.Height < 0)
                {
                    balas[i].Imagen.Dispose(); // Eliminar la bala si sale de la pantalla
                    balas.RemoveAt(i);
                }
            }
        }

        private void btnDesplazar_Click(object sender, EventArgs e)
        {
            tmrDesplazar.Enabled = true;
        }

        private void tmrDesplazar_Tick(object sender, EventArgs e)
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

        private void btnDisparar_Click(object sender, EventArgs e)
        {
            // Crear una nueva bala y agregarla a la lista
            Point posicionInicial = new Point(PicEjemplo.Location.X + PicEjemplo.Width / 2, PicEjemplo.Location.Y);
            Bala nuevaBala = new Bala(posicionInicial, 10, imagenBalaOriginal); // Pasar el PictureBox original
            balas.Add(nuevaBala);
            this.Controls.Add(nuevaBala.Imagen); // Agregar la imagen de la bala al formulario
            nuevaBala.Imagen.BringToFront(); // Asegurarse de que la bala esté encima de otros controles
        }

    }
}